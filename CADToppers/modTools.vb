Imports System.Windows.Forms
Imports Autodesk.AutoCAD.ApplicationServices
'CADToppers.com AutoCAD Plugin Copyright (C) 2014 Roy Nijkamp

'This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; 
'either version 2 of the License, or (at your option) any later version.

'This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
'without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

'You should have received a copy of the GNU General Public License along with this program; 
'if not, write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
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
