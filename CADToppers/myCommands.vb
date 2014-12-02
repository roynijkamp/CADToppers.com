'CADToppers.com AutoCAD Plugin Copyright (C) 2014 Roy Nijkamp

'This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; 
'either version 2 of the License, or (at your option) any later version.

'This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
'without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.

'You should have received a copy of the GNU General Public License along with this program; 
'if not, write to the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
'
Imports System
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices
Imports Autodesk.AutoCAD.Geometry
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.Windows

<Assembly: CommandClass(GetType(CADToppers.MyCommands))> 
Namespace CADToppers




    Public Class MyCommands
        Friend Shared m_palette As Autodesk.AutoCAD.Windows.PaletteSet = Nothing

        <CommandMethod("cadtop", CommandFlags.Modal + CommandFlags.Session)> _
        Public Sub cadtop()
            m_palette = Nothing
            m_palette = New Autodesk.AutoCAD.Windows.PaletteSet("CADtoppers")
            m_palette.Style = PaletteSetStyles.ShowPropertiesMenu + PaletteSetStyles.ShowAutoHideButton + PaletteSetStyles.ShowCloseButton
            Dim palette_start As Palette_legenda = New Palette_legenda()
            m_palette.Add("CAD Toppers", palette_start)
            m_palette.Visible = True
        End Sub
    End Class

End Namespace