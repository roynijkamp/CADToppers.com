Imports System.Windows.Forms
Imports Autodesk.AutoCAD.ApplicationServices

Module modTools


    Public Sub listLayers(ByRef cmbList As ComboBox)
        Dim acDoc As Document = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument
        Dim acCurDb As Autodesk.AutoCAD.DatabaseServices.Database = acDoc.Database
        Dim arrLayname(0 To 9999) As String
        Dim teller As Integer = 0
        Dim dtTable As DataTable 'tabel met layers
        dtTable = New DataTable()
        dtTable.Columns.Add("id")
        dtTable.Columns.Add("laagnaam")
        Using acLockDoc As DocumentLock = acDoc.LockDocument()
            Using acTrans As Autodesk.AutoCAD.DatabaseServices.Transaction = acCurDb.TransactionManager.StartTransaction
                Dim acLyrTbl As Autodesk.AutoCAD.DatabaseServices.LayerTable
                acLyrTbl = acTrans.GetObject(acCurDb.LayerTableId, Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead)
                For Each acObjId As Autodesk.AutoCAD.DatabaseServices.ObjectId In acLyrTbl
                    Dim acLyrTblRec As Autodesk.AutoCAD.DatabaseServices.LayerTableRecord
                    acLyrTblRec = acTrans.GetObject(acObjId, Autodesk.AutoCAD.DatabaseServices.OpenMode.ForRead)
                    If Not acLyrTblRec.Name.Contains("|") Then
                        Dim dtRow As DataRow = dtTable.NewRow()
                        dtRow(0) = teller
                        dtRow(1) = acLyrTblRec.Name
                        dtTable.Rows.Add(dtRow)
                        teller = teller + 1
                    End If
                Next
            End Using
            dtTable.DefaultView.Sort = "laagnaam ASC"
            cmbList.DataSource = dtTable
            cmbList.DisplayMember = "laagnaam"
            cmbList.ValueMember = "laagnaam"
        End Using
    End Sub


End Module
