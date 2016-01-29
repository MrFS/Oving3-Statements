<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvsluttToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HjelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JoachimFStamnesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilToolStripMenuItem, Me.HjelpToolStripMenuItem, Me.JoachimFStamnesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(358, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilToolStripMenuItem
        '
        Me.FilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AvsluttToolStripMenuItem})
        Me.FilToolStripMenuItem.Name = "FilToolStripMenuItem"
        Me.FilToolStripMenuItem.Size = New System.Drawing.Size(36, 24)
        Me.FilToolStripMenuItem.Text = "Fil"
        '
        'AvsluttToolStripMenuItem
        '
        Me.AvsluttToolStripMenuItem.Name = "AvsluttToolStripMenuItem"
        Me.AvsluttToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.AvsluttToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.AvsluttToolStripMenuItem.Text = "Avslutt"
        '
        'HjelpToolStripMenuItem
        '
        Me.HjelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OmToolStripMenuItem})
        Me.HjelpToolStripMenuItem.Enabled = False
        Me.HjelpToolStripMenuItem.Name = "HjelpToolStripMenuItem"
        Me.HjelpToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.HjelpToolStripMenuItem.Text = "Hjelp"
        '
        'OmToolStripMenuItem
        '
        Me.OmToolStripMenuItem.Name = "OmToolStripMenuItem"
        Me.OmToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.OmToolStripMenuItem.Text = "Om"
        '
        'JoachimFStamnesToolStripMenuItem
        '
        Me.JoachimFStamnesToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.JoachimFStamnesToolStripMenuItem.Enabled = False
        Me.JoachimFStamnesToolStripMenuItem.Name = "JoachimFStamnesToolStripMenuItem"
        Me.JoachimFStamnesToolStripMenuItem.Size = New System.Drawing.Size(212, 24)
        Me.JoachimFStamnesToolStripMenuItem.Text = "Laget av: Joachim F. Stamnes"
        Me.JoachimFStamnesToolStripMenuItem.ToolTipText = "^Han som laget denne saken"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(358, 353)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(350, 324)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Oppgave 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Er du myndig?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "år gammel."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jeg er"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vennligst oppgi din alder i feltet under."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Oppgave 1 - Pensjonister, myndige og barn"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(350, 324)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Oppgave 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Label8"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(50, 22)
        Me.TextBox2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Jeg tror det blir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Hva blir resultatet ved neste kamp?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Oppgave 2 - Fotballgal?"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.TextBox3)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(350, 324)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Oppgave 3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(132, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Trykk"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(116, 47)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(50, 22)
        Me.TextBox3.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Jeg tror det blir"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(231, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Hva blir resultatet ved neste kamp?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(241, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Oppgave 3 - Fotballgal ""Select Case"""
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListBox1)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.TextBox4)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.HScrollBar1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(350, 324)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Oppgave 4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(11, 121)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(215, 180)
        Me.ListBox1.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 17)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Velg distanse:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(83, 93)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(61, 22)
        Me.TextBox4.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Din alder:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(151, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Kalkuler"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(167, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Label13"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Busstur - Kalkuler din billettpris!"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(11, 57)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(150, 29)
        Me.HScrollBar1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 381)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HjelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JoachimFStamnesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AvsluttToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
