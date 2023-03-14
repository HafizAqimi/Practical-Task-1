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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblChallenge = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.RB1Male = New System.Windows.Forms.RadioButton()
        Me.RB2Female = New System.Windows.Forms.RadioButton()
        Me.CB1Yes = New System.Windows.Forms.CheckBox()
        Me.CB2No = New System.Windows.Forms.CheckBox()
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.comboboxDepartment = New System.Windows.Forms.ComboBox()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.openFD = New System.Windows.Forms.OpenFileDialog()
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmpName
        '
        resources.ApplyResources(Me.lblEmpName, "lblEmpName")
        Me.lblEmpName.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmpName.Name = "lblEmpName"
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.IndianRed
        resources.ApplyResources(Me.Header, "Header")
        Me.Header.ForeColor = System.Drawing.SystemColors.Info
        Me.Header.Name = "Header"
        Me.Header.ReadOnly = True
        '
        'txtEmployeeName
        '
        resources.ApplyResources(Me.txtEmployeeName, "txtEmployeeName")
        Me.txtEmployeeName.Name = "txtEmployeeName"
        '
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.Name = "txtEmail"
        '
        'lblEmail
        '
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmail.Name = "lblEmail"
        '
        'lblDepartment
        '
        resources.ApplyResources(Me.lblDepartment, "lblDepartment")
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDepartment.Name = "lblDepartment"
        '
        'lblGender
        '
        resources.ApplyResources(Me.lblGender, "lblGender")
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGender.Name = "lblGender"
        '
        'lblChallenge
        '
        resources.ApplyResources(Me.lblChallenge, "lblChallenge")
        Me.lblChallenge.BackColor = System.Drawing.Color.Transparent
        Me.lblChallenge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblChallenge.Name = "lblChallenge"
        '
        'txtAddress
        '
        resources.ApplyResources(Me.txtAddress, "txtAddress")
        Me.txtAddress.Name = "txtAddress"
        '
        'lblAddress
        '
        resources.ApplyResources(Me.lblAddress, "lblAddress")
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAddress.Name = "lblAddress"
        '
        'txtMobileNo
        '
        resources.ApplyResources(Me.txtMobileNo, "txtMobileNo")
        Me.txtMobileNo.Name = "txtMobileNo"
        '
        'lblMobileNo
        '
        resources.ApplyResources(Me.lblMobileNo, "lblMobileNo")
        Me.lblMobileNo.BackColor = System.Drawing.Color.Transparent
        Me.lblMobileNo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMobileNo.Name = "lblMobileNo"
        '
        'RB1Male
        '
        resources.ApplyResources(Me.RB1Male, "RB1Male")
        Me.RB1Male.BackColor = System.Drawing.Color.Transparent
        Me.RB1Male.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RB1Male.Name = "RB1Male"
        Me.RB1Male.TabStop = True
        Me.RB1Male.UseVisualStyleBackColor = False
        '
        'RB2Female
        '
        resources.ApplyResources(Me.RB2Female, "RB2Female")
        Me.RB2Female.BackColor = System.Drawing.Color.Transparent
        Me.RB2Female.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RB2Female.Name = "RB2Female"
        Me.RB2Female.TabStop = True
        Me.RB2Female.UseVisualStyleBackColor = False
        '
        'CB1Yes
        '
        resources.ApplyResources(Me.CB1Yes, "CB1Yes")
        Me.CB1Yes.BackColor = System.Drawing.Color.Transparent
        Me.CB1Yes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CB1Yes.Name = "CB1Yes"
        Me.CB1Yes.UseVisualStyleBackColor = False
        '
        'CB2No
        '
        resources.ApplyResources(Me.CB2No, "CB2No")
        Me.CB2No.BackColor = System.Drawing.Color.Transparent
        Me.CB2No.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CB2No.Name = "CB2No"
        Me.CB2No.UseVisualStyleBackColor = False
        '
        'BTNSubmit
        '
        Me.BTNSubmit.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.BTNSubmit, "BTNSubmit")
        Me.BTNSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.UseVisualStyleBackColor = False
        '
        'comboboxDepartment
        '
        Me.comboboxDepartment.FormattingEnabled = True
        Me.comboboxDepartment.Items.AddRange(New Object() {resources.GetString("comboboxDepartment.Items"), resources.GetString("comboboxDepartment.Items1"), resources.GetString("comboboxDepartment.Items2"), resources.GetString("comboboxDepartment.Items3"), resources.GetString("comboboxDepartment.Items4"), resources.GetString("comboboxDepartment.Items5")})
        resources.ApplyResources(Me.comboboxDepartment, "comboboxDepartment")
        Me.comboboxDepartment.Name = "comboboxDepartment"
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.Color.RosyBrown
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        resources.ApplyResources(Me.Menu, "Menu")
        Me.Menu.Name = "Menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenTool, Me.SaveTool, Me.ExitTool})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'OpenTool
        '
        Me.OpenTool.Name = "OpenTool"
        resources.ApplyResources(Me.OpenTool, "OpenTool")
        '
        'SaveTool
        '
        Me.SaveTool.Name = "SaveTool"
        resources.ApplyResources(Me.SaveTool, "SaveTool")
        '
        'ExitTool
        '
        Me.ExitTool.Name = "ExitTool"
        resources.ApplyResources(Me.ExitTool, "ExitTool")
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetTool})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        resources.ApplyResources(Me.EditToolStripMenuItem, "EditToolStripMenuItem")
        '
        'ResetTool
        '
        Me.ResetTool.Name = "ResetTool"
        resources.ApplyResources(Me.ResetTool, "ResetTool")
        '
        'openFD
        '
        Me.openFD.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.comboboxDepartment)
        Me.Controls.Add(Me.BTNSubmit)
        Me.Controls.Add(Me.CB2No)
        Me.Controls.Add(Me.CB1Yes)
        Me.Controls.Add(Me.RB2Female)
        Me.Controls.Add(Me.RB1Male)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.lblMobileNo)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblChallenge)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.Menu)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "Form1"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmpName As Label
    Friend WithEvents Header As TextBox
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblChallenge As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents lblMobileNo As Label
    Friend WithEvents RB1Male As RadioButton
    Friend WithEvents RB2Female As RadioButton
    Friend WithEvents CB1Yes As CheckBox
    Friend WithEvents CB2No As CheckBox
    Friend WithEvents BTNSubmit As Button
    Friend WithEvents comboboxDepartment As ComboBox
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenTool As ToolStripMenuItem
    Friend WithEvents SaveTool As ToolStripMenuItem
    Friend WithEvents ExitTool As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetTool As ToolStripMenuItem
    Friend WithEvents openFD As OpenFileDialog
End Class
