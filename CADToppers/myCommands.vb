' (C) Copyright 2014 by  Roy Nijkamp
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