<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUnidades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TbcVolumen = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuPrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CmbVolumen = New System.Windows.Forms.ComboBox
        Me.LblResVol = New System.Windows.Forms.Label
        Me.BtnCalcularVolumen = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TbcVolumen.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TbcVolumen)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(298, 260)
        Me.TabControl1.TabIndex = 0
        '
        'TbcVolumen
        '
        Me.TbcVolumen.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbcVolumen.Controls.Add(Me.BtnCalcularVolumen)
        Me.TbcVolumen.Controls.Add(Me.LblResVol)
        Me.TbcVolumen.Controls.Add(Me.CmbVolumen)
        Me.TbcVolumen.Location = New System.Drawing.Point(4, 22)
        Me.TbcVolumen.Name = "TbcVolumen"
        Me.TbcVolumen.Padding = New System.Windows.Forms.Padding(3)
        Me.TbcVolumen.Size = New System.Drawing.Size(290, 234)
        Me.TbcVolumen.TabIndex = 0
        Me.TbcVolumen.Text = "Volumen"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(290, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Peso"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(322, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(290, 234)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Area"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuPrincipalToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MenuPrincipalToolStripMenuItem
        '
        Me.MenuPrincipalToolStripMenuItem.Name = "MenuPrincipalToolStripMenuItem"
        Me.MenuPrincipalToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.MenuPrincipalToolStripMenuItem.Text = "Menu principal"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'CmbVolumen
        '
        Me.CmbVolumen.AutoCompleteCustomSource.AddRange(New String() {"L→m³", "m³→L"})
        Me.CmbVolumen.FormattingEnabled = True
        Me.CmbVolumen.Items.AddRange(New Object() {"m³ → L", "L → m³"})
        Me.CmbVolumen.Location = New System.Drawing.Point(70, 6)
        Me.CmbVolumen.Name = "CmbVolumen"
        Me.CmbVolumen.Size = New System.Drawing.Size(121, 21)
        Me.CmbVolumen.TabIndex = 0
        '
        'LblResVol
        '
        Me.LblResVol.AutoSize = True
        Me.LblResVol.Location = New System.Drawing.Point(103, 115)
        Me.LblResVol.Name = "LblResVol"
        Me.LblResVol.Size = New System.Drawing.Size(55, 13)
        Me.LblResVol.TabIndex = 1
        Me.LblResVol.Text = "Resultado"
        '
        'BtnCalcularVolumen
        '
        Me.BtnCalcularVolumen.Location = New System.Drawing.Point(96, 205)
        Me.BtnCalcularVolumen.Name = "BtnCalcularVolumen"
        Me.BtnCalcularVolumen.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalcularVolumen.TabIndex = 2
        Me.BtnCalcularVolumen.Text = "Calcular"
        Me.BtnCalcularVolumen.UseVisualStyleBackColor = True
        '
        'FrmUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 299)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUnidades"
        Me.Text = "FrmUnidades"
        Me.TabControl1.ResumeLayout(False)
        Me.TbcVolumen.ResumeLayout(False)
        Me.TbcVolumen.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TbcVolumen As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BtnCalcularVolumen As System.Windows.Forms.Button
    Friend WithEvents LblResVol As System.Windows.Forms.Label
    Friend WithEvents CmbVolumen As System.Windows.Forms.ComboBox
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPrincipalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
