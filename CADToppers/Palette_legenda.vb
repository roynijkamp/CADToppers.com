Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Geometry
Imports System.Windows.Forms

Public Class Palette_legenda

    Private Sub cmdPlaatsLegenda_Click(sender As Object, e As EventArgs) Handles cmdPlaatsLegenda.Click
        plaatsLegenda()
    End Sub

    Public Sub plaatsLegenda()
        Autodesk.AutoCAD.Internal.Utils.SetFocusToDwgView()
        Dim ptInsert, ptBase As Point3d
        Dim acBlkTbl As BlockTable
        Dim acBlkTblRec As BlockTableRecord

        Dim acDoc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim acCurDb As Database = acDoc.Database

        Dim acSSPrompt As PromptSelectionResult
        Dim acSSOpts As PromptSelectionOptions = New PromptSelectionOptions()
        Dim pPtRes As PromptPointResult
        Dim pPtOpts As PromptPointOptions = New PromptPointOptions("")

        Dim strLayerAdded As List(Of String) = New List(Of String)

        Dim ptLengte As Double = CDbl(txtLengteLijn.Text)
        Dim ptHoogte As Double = CDbl(txtTeksthoogte.Text)
        Dim ptVerSpacing As Double = ptHoogte * 2
        Dim ptStart As Point2d
        Dim ptEnd As Point2d
        Dim ptCount As Integer = 0
        Dim voortgangTeller As Integer = 0

        Dim objGlobalWidth As Double = 0
        Dim entDescription As String
        Dim entLayer As String = "0"
        Dim entLinetype As String
        Dim entLinetypeScale As Double

        Using acLockDoc As DocumentLock = acDoc.LockDocument()
            Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()

                acSSOpts.MessageForAdding = vbLf & "Selecteer de objecten "
                acSSPrompt = acDoc.Editor.GetSelection(acSSOpts)
                'indien selectie akkoord verder gaan
                If acSSPrompt.Status = PromptStatus.OK Then
                    'selection is ok, nu insertion point opvragen

                    pPtOpts.Message = vbLf & "Kies het invoegpunt voor de Legenda! "
                    pPtRes = acDoc.Editor.GetPoint(pPtOpts)
                    ptInsert = pPtRes.Value

                    acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId, OpenMode.ForWrite)
                    acBlkTblRec = acTrans.GetObject(acBlkTbl(BlockTableRecord.ModelSpace), OpenMode.ForWrite)

                    Dim objIds() As ObjectId = acSSPrompt.Value.GetObjectIds
                    If UBound(objIds) = 0 Then Exit Sub
                    pgbVoortgang.Maximum = objIds.Length
                    For Each objId As ObjectId In objIds
                        Dim ent As Entity = CType(acTrans.GetObject(objId, OpenMode.ForWrite), Entity)
                        Dim strObject As String = ent.GetType().ToString.ToLower
                        If strLayerAdded.Contains(ent.Layer.ToString) = False Then
                            strLayerAdded.Add(ent.Layer.ToString)
                            Dim lt As LayerTable = acTrans.GetObject(acCurDb.LayerTableId, OpenMode.ForRead)
                            Dim layerId As ObjectId = lt.Item(ent.Layer)
                            Dim ltr As LayerTableRecord = acTrans.GetObject(lt.Item(ent.Layer), OpenMode.ForRead)
                            'kijken of we de layer description moeten gebruiken
                            If chkLayerDescription.Checked = True Then
                                entDescription = ltr.Description
                                If entDescription = "" Then
                                    'description leeg dus layername gebruiken
                                    entDescription = ent.Layer
                                End If
                            Else
                                entDescription = ent.Layer
                            End If
                            entLinetypeScale = ent.LinetypeScale
                            entLinetype = ent.Linetype
                            entLayer = ent.Layer
                            objGlobalWidth = 0
                            'kijken of het een polyline betreft, zo ja globalwith meenemen
                            If strObject = "autodesk.autocad.databaseservices.polyline" Then
                                Dim entPolyline As Polyline = ent
                                objGlobalWidth = entPolyline.GetStartWidthAt(0)
                            End If

                            'End Select
                            If entLayer <> "" Then
                                ptStart = New Point2d(ptInsert.X, ptInsert.Y - (ptCount * ptVerSpacing))
                                ptEnd = New Point2d(ptInsert.X + ptLengte, ptInsert.Y - (ptCount * ptVerSpacing))
                                Dim acLine As Polyline = New Polyline()
                                acLine.AddVertexAt(0, ptStart, 0, objGlobalWidth, objGlobalWidth)
                                acLine.AddVertexAt(1, ptEnd, 0, objGlobalWidth, objGlobalWidth)
                                acLine.Layer = entLayer
                                acLine.Linetype = entLinetype
                                acLine.LinetypeScale = entLinetypeScale
                                acBlkTblRec.AppendEntity(acLine)
                                acTrans.AddNewlyCreatedDBObject(acLine, True)
                                Dim acMtext As MText = New MText()
                                acMtext.Location = New Point3d(ptInsert.X + (ptLengte * 1.1), ptInsert.Y - (ptCount * ptVerSpacing), 0)
                                acMtext.Layer = cmbLayerName.Text
                                acMtext.Contents = entDescription
                                acMtext.TextHeight = ptHoogte
                                acMtext.Attachment = AttachmentPoint.MiddleLeft
                                acBlkTblRec.AppendEntity(acMtext)
                                acTrans.AddNewlyCreatedDBObject(acMtext, True)
                                ptCount += 1
                                entLayer = ""
                            End If
                        End If
                        voortgangTeller += 1
                        pgbVoortgang.Value = voortgangTeller
                    Next
                End If
                'titel toevoegen
                If ptCount > 0 Then
                    Dim acMtext As MText = New MText()
                    acMtext.Location = New Point3d(ptInsert.X, ptInsert.Y + (ptVerSpacing), 0)
                    acMtext.Layer = cmbLayerName.Text
                    acMtext.Contents = txtTitel.Text
                    acMtext.TextHeight = ptHoogte * 2
                    acMtext.Attachment = AttachmentPoint.BottomLeft
                    acBlkTblRec.AppendEntity(acMtext)
                    acTrans.AddNewlyCreatedDBObject(acMtext, True)
                End If
                acTrans.Commit()
            End Using
        End Using
        pgbVoortgang.Value = 0
    End Sub

   
    Private Sub Palette_legenda_Load(sender As Object, e As EventArgs) Handles Me.Load
        modTools.listLayers(cmbLayerName)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub cmdReloadLayers_Click(sender As Object, e As EventArgs) Handles cmdReloadLayers.Click
        modTools.listLayers(cmbLayerName)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(Me.Width.ToString)
    End Sub

    Private Sub cmdLayerOverzicht_Click(sender As Object, e As EventArgs) Handles cmdLayerOverzicht.Click
        Autodesk.AutoCAD.Internal.Utils.SetFocusToDwgView()
        Dim ptInsert, ptBase As Point3d
        Dim acBlkTbl As BlockTable
        Dim acBlkTblRec As BlockTableRecord

        Dim acDoc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim acCurDb As Database = acDoc.Database

        Dim acSSOpts As PromptSelectionOptions = New PromptSelectionOptions()
        Dim pPtRes As PromptPointResult
        Dim pPtOpts As PromptPointOptions = New PromptPointOptions("")

        Dim strLayerAdded As List(Of String) = New List(Of String)

        Dim ptLengte As Double = CDbl(txtLengteLijn.Text)
        Dim ptHoogte As Double = CDbl(txtTeksthoogte.Text)
        Dim ptVerSpacing As Double = ptHoogte * 2
        Dim ptStart As Point2d
        Dim ptEnd As Point2d
        Dim ptCount As Integer = 0
        Dim voortgangTeller As Integer = 0

        Dim objGlobalWidth As Double = 0
        Dim entDescription As String
        Dim entLayer As String = "0"
        Dim entLinetype As ObjectId
        Dim entLineWeight As Double

        Using acLockDoc As DocumentLock = acDoc.LockDocument()
            Using acTrans As Transaction = acCurDb.TransactionManager.StartTransaction()

                acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId, OpenMode.ForWrite)
                acBlkTblRec = acTrans.GetObject(acBlkTbl(BlockTableRecord.ModelSpace), OpenMode.ForWrite)

                pPtOpts.Message = vbLf & "Kies het invoegpunt voor de Legenda! "
                pPtRes = acDoc.Editor.GetPoint(pPtOpts)
                ptInsert = pPtRes.Value
                Dim acLyrTbl As Autodesk.AutoCAD.DatabaseServices.LayerTable
                acLyrTbl = acTrans.GetObject(acCurDb.LayerTableId, Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead)

                For Each acObjId As Autodesk.AutoCAD.DatabaseServices.ObjectId In acLyrTbl
                    Dim acLyrTblRec As Autodesk.AutoCAD.DatabaseServices.LayerTableRecord
                    acLyrTblRec = acTrans.GetObject(acObjId, Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead)
                    If Not acLyrTblRec.Name.Contains("|") Then
                        'kijken of we de layer description moeten gebruiken
                        If chkLayerDescription.Checked = True Then
                            entDescription = acLyrTblRec.Description.ToString
                            If entDescription = "" Then
                                'description leeg dus layername gebruiken
                                entDescription = acLyrTblRec.Name.ToString
                            End If
                        Else
                            entDescription = acLyrTblRec.Name.ToString
                        End If
                        entLineWeight = acLyrTblRec.LineWeight
                        entLinetype = acLyrTblRec.LinetypeObjectId
                        entLayer = acLyrTblRec.Name.ToString

                        ptStart = New Point2d(ptInsert.X, ptInsert.Y - (ptCount * ptVerSpacing))
                        ptEnd = New Point2d(ptInsert.X + ptLengte, ptInsert.Y - (ptCount * ptVerSpacing))
                        Dim acLine As Polyline = New Polyline()
                        acLine.AddVertexAt(0, ptStart, 0, objGlobalWidth, objGlobalWidth)
                        acLine.AddVertexAt(1, ptEnd, 0, objGlobalWidth, objGlobalWidth)
                        acLine.Layer = entLayer
                        acLine.LinetypeId = entLinetype
                        acLine.LineWeight = entLineWeight
                        acBlkTblRec.AppendEntity(acLine)
                        acTrans.AddNewlyCreatedDBObject(acLine, True)
                        Dim acMtext As MText = New MText()
                        acMtext.Location = New Point3d(ptInsert.X + (ptLengte * 1.1), ptInsert.Y - (ptCount * ptVerSpacing), 0)
                        acMtext.Layer = cmbLayerName.Text
                        acMtext.Contents = entDescription
                        acMtext.TextHeight = ptHoogte
                        acMtext.Attachment = AttachmentPoint.MiddleLeft
                        acBlkTblRec.AppendEntity(acMtext)
                        acTrans.AddNewlyCreatedDBObject(acMtext, True)
                        ptCount += 1
                        entLayer = ""

                        ptCount += 1
                    End If
                Next
                'titel toevoegen
                If ptCount > 0 Then
                    Dim acMtext As MText = New MText()
                    acMtext.Location = New Point3d(ptInsert.X, ptInsert.Y + (ptVerSpacing), 0)
                    acMtext.Layer = cmbLayerName.Text
                    acMtext.Contents = txtTitel.Text
                    acMtext.TextHeight = ptHoogte * 2
                    acMtext.Attachment = AttachmentPoint.BottomLeft
                    acBlkTblRec.AppendEntity(acMtext)
                    acTrans.AddNewlyCreatedDBObject(acMtext, True)
                End If
                acTrans.Commit()
            End Using
        End Using

    End Sub
End Class
