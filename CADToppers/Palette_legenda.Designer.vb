<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Palette_legenda
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitel = New System.Windows.Forms.TextBox()
        Me.cmdPlaatsLegenda = New System.Windows.Forms.Button()
        Me.pgbVoortgang = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLengteLijn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTeksthoogte = New System.Windows.Forms.TextBox()
        Me.chkLayerDescription = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbLayerName = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdLayerOverzicht = New System.Windows.Forms.Button()
        Me.cmdReloadLayers = New System.Windows.Forms.Button()
        Me.pcbLogo = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Legenda Titel:"
        '
        'txtTitel
        '
        Me.txtTitel.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTitel.Location = New System.Drawing.Point(3, 78)
        Me.txtTitel.Name = "txtTitel"
        Me.txtTitel.Size = New System.Drawing.Size(209, 20)
        Me.txtTitel.TabIndex = 2
        Me.txtTitel.Text = "Legenda Titel"
        '
        'cmdPlaatsLegenda
        '
        Me.cmdPlaatsLegenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPlaatsLegenda.Location = New System.Drawing.Point(98, 228)
        Me.cmdPlaatsLegenda.Name = "cmdPlaatsLegenda"
        Me.cmdPlaatsLegenda.Size = New System.Drawing.Size(114, 30)
        Me.cmdPlaatsLegenda.TabIndex = 3
        Me.cmdPlaatsLegenda.Text = "Plaats Legenda"
        Me.cmdPlaatsLegenda.UseVisualStyleBackColor = True
        '
        'pgbVoortgang
        '
        Me.pgbVoortgang.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbVoortgang.Location = New System.Drawing.Point(0, 695)
        Me.pgbVoortgang.Name = "pgbVoortgang"
        Me.pgbVoortgang.Size = New System.Drawing.Size(258, 23)
        Me.pgbVoortgang.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Lengte lijn:"
        '
        'txtLengteLijn
        '
        Me.txtLengteLijn.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtLengteLijn.Location = New System.Drawing.Point(3, 128)
        Me.txtLengteLijn.Name = "txtLengteLijn"
        Me.txtLengteLijn.Size = New System.Drawing.Size(209, 20)
        Me.txtLengteLijn.TabIndex = 6
        Me.txtLengteLijn.Text = "8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Teksthoogte:"
        '
        'txtTeksthoogte
        '
        Me.txtTeksthoogte.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTeksthoogte.Location = New System.Drawing.Point(3, 178)
        Me.txtTeksthoogte.Name = "txtTeksthoogte"
        Me.txtTeksthoogte.Size = New System.Drawing.Size(209, 20)
        Me.txtTeksthoogte.TabIndex = 8
        Me.txtTeksthoogte.Text = "0.5"
        '
        'chkLayerDescription
        '
        Me.chkLayerDescription.AutoSize = True
        Me.chkLayerDescription.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkLayerDescription.Location = New System.Drawing.Point(3, 203)
        Me.chkLayerDescription.Name = "chkLayerDescription"
        Me.chkLayerDescription.Size = New System.Drawing.Size(209, 17)
        Me.chkLayerDescription.TabIndex = 10
        Me.chkLayerDescription.Text = "Layer Desctiption i.p.v. Layer Name"
        Me.chkLayerDescription.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Laagnaam voor Teksten"
        '
        'cmbLayerName
        '
        Me.cmbLayerName.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbLayerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLayerName.FormattingEnabled = True
        Me.cmbLayerName.Location = New System.Drawing.Point(3, 28)
        Me.cmbLayerName.Name = "cmbLayerName"
        Me.cmbLayerName.Size = New System.Drawing.Size(209, 21)
        Me.cmbLayerName.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmdLayerOverzicht, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbLayerName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkLayerDescription, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTeksthoogte, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdReloadLayers, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLengteLijn, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTitel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmdPlaatsLegenda, 0, 9)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 106)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(243, 305)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'cmdLayerOverzicht
        '
        Me.cmdLayerOverzicht.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLayerOverzicht.Location = New System.Drawing.Point(98, 266)
        Me.cmdLayerOverzicht.Name = "cmdLayerOverzicht"
        Me.cmdLayerOverzicht.Size = New System.Drawing.Size(114, 35)
        Me.cmdLayerOverzicht.TabIndex = 13
        Me.cmdLayerOverzicht.Text = "Maak layer overzicht"
        Me.cmdLayerOverzicht.UseVisualStyleBackColor = True
        '
        'cmdReloadLayers
        '
        Me.cmdReloadLayers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReloadLayers.Image = Global.CADToppers.My.Resources.Resources.reload
        Me.cmdReloadLayers.Location = New System.Drawing.Point(218, 28)
        Me.cmdReloadLayers.Name = "cmdReloadLayers"
        Me.cmdReloadLayers.Size = New System.Drawing.Size(22, 19)
        Me.cmdReloadLayers.TabIndex = 11
        Me.cmdReloadLayers.UseVisualStyleBackColor = True
        '
        'pcbLogo
        '
        Me.pcbLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pcbLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pcbLogo.Image = Global.CADToppers.My.Resources.Resources.logo
        Me.pcbLogo.Location = New System.Drawing.Point(0, 0)
        Me.pcbLogo.Name = "pcbLogo"
        Me.pcbLogo.Padding = New System.Windows.Forms.Padding(10)
        Me.pcbLogo.Size = New System.Drawing.Size(258, 106)
        Me.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbLogo.TabIndex = 0
        Me.pcbLogo.TabStop = False
        '
        'Palette_legenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pgbVoortgang)
        Me.Controls.Add(Me.pcbLogo)
        Me.MinimumSize = New System.Drawing.Size(258, 718)
        Me.Name = "Palette_legenda"
        Me.Size = New System.Drawing.Size(258, 718)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pcbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitel As System.Windows.Forms.TextBox
    Friend WithEvents cmdPlaatsLegenda As System.Windows.Forms.Button
    Friend WithEvents pgbVoortgang As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLengteLijn As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTeksthoogte As System.Windows.Forms.TextBox
    Friend WithEvents chkLayerDescription As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbLayerName As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdReloadLayers As System.Windows.Forms.Button
    Friend WithEvents cmdLayerOverzicht As System.Windows.Forms.Button

End Class
