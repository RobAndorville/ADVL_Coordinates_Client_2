<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMessages = New System.Windows.Forms.Button()
        Me.btnOnline = New System.Windows.Forms.Button()
        Me.btnAppInfo = New System.Windows.Forms.Button()
        Me.btnProject = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnCloseCoordsServer = New System.Windows.Forms.Button()
        Me.btnOpenCoordsServer = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtCrsKind = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCrsCode = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnGetCrsList = New System.Windows.Forms.Button()
        Me.txtCrsNameContains = New System.Windows.Forms.TextBox()
        Me.chkCrsNameContains = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNone = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.chkProjected = New System.Windows.Forms.CheckBox()
        Me.chkVertical = New System.Windows.Forms.CheckBox()
        Me.chkGeographic2D = New System.Windows.Forms.CheckBox()
        Me.chkGeocentric = New System.Windows.Forms.CheckBox()
        Me.chkGeographic3D = New System.Windows.Forms.CheckBox()
        Me.chkEngineering = New System.Windows.Forms.CheckBox()
        Me.chkCompound = New System.Windows.Forms.CheckBox()
        Me.chkDerived = New System.Windows.Forms.CheckBox()
        Me.btnSetOutputCrs = New System.Windows.Forms.Button()
        Me.btnSetInputCrs = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbCrsList = New System.Windows.Forms.ComboBox()
        Me.rbContainingPoint = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRefLat = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRefLong = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNorthLatBound = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEastLongBound = New System.Windows.Forms.TextBox()
        Me.txtSouthLatBound = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtWestLongBound = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbInside = New System.Windows.Forms.RadioButton()
        Me.rbExtendingInto = New System.Windows.Forms.RadioButton()
        Me.rbGetAll = New System.Windows.Forms.RadioButton()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnAutoSelectDatumTrans = New System.Windows.Forms.Button()
        Me.btnGetDatumTransList = New System.Windows.Forms.Button()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.txtAccuracy = New System.Windows.Forms.TextBox()
        Me.btdSetDatumTrans = New System.Windows.Forms.Button()
        Me.rbDatumTransViaWgs84 = New System.Windows.Forms.RadioButton()
        Me.rbDirectDatumTrans = New System.Windows.Forms.RadioButton()
        Me.rbDtNotRequired = New System.Windows.Forms.RadioButton()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.txtDirectDTOpName = New System.Windows.Forms.TextBox()
        Me.txtDirectDTOpCode = New System.Windows.Forms.TextBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.txtDirectDTOpAccuracy = New System.Windows.Forms.TextBox()
        Me.dgvDirectDTOps = New System.Windows.Forms.DataGridView()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.dgvInputToWgs84DTOps = New System.Windows.Forms.DataGridView()
        Me.Label169 = New System.Windows.Forms.Label()
        Me.Label170 = New System.Windows.Forms.Label()
        Me.txtInputToWgs84DTOpName = New System.Windows.Forms.TextBox()
        Me.txtInputToWgs84DTOpCode = New System.Windows.Forms.TextBox()
        Me.Label173 = New System.Windows.Forms.Label()
        Me.txtInputToWgs84DTOpAccuracy = New System.Windows.Forms.TextBox()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.txtWgs84ToOutputDTOpName = New System.Windows.Forms.TextBox()
        Me.txtWgs84ToOutputDTOpCode = New System.Windows.Forms.TextBox()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.txtWgs84ToOutputDTOpAccuracy = New System.Windows.Forms.TextBox()
        Me.dgvWgs84ToOutputDTOps = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.chkShowPointDescription = New System.Windows.Forms.CheckBox()
        Me.chkShowPointName = New System.Windows.Forms.CheckBox()
        Me.chkShowPointNumber = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDataName = New System.Windows.Forms.TextBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.btnNewConvFile = New System.Windows.Forms.Button()
        Me.btnOpenConvFile = New System.Windows.Forms.Button()
        Me.btnSaveConvFile = New System.Windows.Forms.Button()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.btnFormatHelp3 = New System.Windows.Forms.Button()
        Me.txtHeightFormat = New System.Windows.Forms.TextBox()
        Me.Label208 = New System.Windows.Forms.Label()
        Me.txtCartFormat = New System.Windows.Forms.TextBox()
        Me.Label207 = New System.Windows.Forms.Label()
        Me.chkDmsSymbols = New System.Windows.Forms.CheckBox()
        Me.txtProjFormat = New System.Windows.Forms.TextBox()
        Me.txtSecondsDecPlaces = New System.Windows.Forms.TextBox()
        Me.Label204 = New System.Windows.Forms.Label()
        Me.txtDegreeDecPlaces = New System.Windows.Forms.TextBox()
        Me.rbDecDegrees = New System.Windows.Forms.RadioButton()
        Me.Label206 = New System.Windows.Forms.Label()
        Me.rbDMS = New System.Windows.Forms.RadioButton()
        Me.Label205 = New System.Windows.Forms.Label()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.udPointFontSize = New System.Windows.Forms.NumericUpDown()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.chkShowOutputXYZ = New System.Windows.Forms.CheckBox()
        Me.chkShowOutputLongLat = New System.Windows.Forms.CheckBox()
        Me.chkShowOutputEastNorth = New System.Windows.Forms.CheckBox()
        Me.chkShowWgs84XYZ = New System.Windows.Forms.CheckBox()
        Me.chkShowInputXYZ = New System.Windows.Forms.CheckBox()
        Me.chkShowInputLongLat = New System.Windows.Forms.CheckBox()
        Me.chkShowInputEastNorth = New System.Windows.Forms.CheckBox()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.rbEnterInputXYZ = New System.Windows.Forms.RadioButton()
        Me.rbEnterInputLongLat = New System.Windows.Forms.RadioButton()
        Me.rbEnterInputEastNorth = New System.Windows.Forms.RadioButton()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btnApplyConvSettings = New System.Windows.Forms.Button()
        Me.btnCheckConnection = New System.Windows.Forms.Button()
        Me.txtWgs84ToOutputDatumTransOpApplyRev = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtWgs84ToOutputDatumTransOpCode = New System.Windows.Forms.TextBox()
        Me.txtWgs84ToOutputDatumTransOpName = New System.Windows.Forms.TextBox()
        Me.btnRecalculate = New System.Windows.Forms.Button()
        Me.txtInputToWgs84DatumTransOpApplyRev = New System.Windows.Forms.TextBox()
        Me.lblDatumTransApplyRev2 = New System.Windows.Forms.Label()
        Me.lblDatumTransCode2 = New System.Windows.Forms.Label()
        Me.lblInputToWgs84DatumTransName = New System.Windows.Forms.Label()
        Me.txtDirectDatumTransOpApplyRev = New System.Windows.Forms.TextBox()
        Me.lblDatumTransApplyRev1 = New System.Windows.Forms.Label()
        Me.lblDatumTransCode1 = New System.Windows.Forms.Label()
        Me.lblDirectDatumTransName = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtInputCrsKind = New System.Windows.Forms.TextBox()
        Me.txtOutputCrsKind = New System.Windows.Forms.TextBox()
        Me.dgvConversion = New System.Windows.Forms.DataGridView()
        Me.txtDatumTransType = New System.Windows.Forms.TextBox()
        Me.txtInputToWgs84DatumTransOpCode = New System.Windows.Forms.TextBox()
        Me.txtInputToWgs84DatumTransOpName = New System.Windows.Forms.TextBox()
        Me.txtDirectDatumTransOpCode = New System.Windows.Forms.TextBox()
        Me.txtDirectDatumTransOpName = New System.Windows.Forms.TextBox()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.txtOutputCrsCode = New System.Windows.Forms.TextBox()
        Me.txtInputCrsCode = New System.Windows.Forms.TextBox()
        Me.txtOutputCrsName = New System.Windows.Forms.TextBox()
        Me.Label185 = New System.Windows.Forms.Label()
        Me.txtInputCrsName = New System.Windows.Forms.TextBox()
        Me.Label184 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnOpenParentDir = New System.Windows.Forms.Button()
        Me.btnOpenArchive = New System.Windows.Forms.Button()
        Me.btnCreateArchive = New System.Windows.Forms.Button()
        Me.btnShowProjectInfo = New System.Windows.Forms.Button()
        Me.chkConnect = New System.Windows.Forms.CheckBox()
        Me.btnOpenProject = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProjectPath = New System.Windows.Forms.TextBox()
        Me.txtProNetName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnOpenAppDir = New System.Windows.Forms.Button()
        Me.btnOpenSystem = New System.Windows.Forms.Button()
        Me.btnOpenData = New System.Windows.Forms.Button()
        Me.btnOpenSettings = New System.Windows.Forms.Button()
        Me.btnParameters = New System.Windows.Forms.Button()
        Me.txtParentProject = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSystemLocationType = New System.Windows.Forms.TextBox()
        Me.txtSystemPath = New System.Windows.Forms.TextBox()
        Me.txtCurrentDuration = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotalDuration = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastUsed = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCreationDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDataPath = New System.Windows.Forms.TextBox()
        Me.txtDataLocationType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSettingsPath = New System.Windows.Forms.TextBox()
        Me.txtSettingsLocationType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProjectType = New System.Windows.Forms.TextBox()
        Me.txtProjectDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAndorville = New System.Windows.Forms.Button()
        Me.btnWebPages = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1_EditWorkflowTabPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1_ShowStartPageInWorkflowTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.dgvDirectDTOps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        CType(Me.dgvInputToWgs84DTOps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage11.SuspendLayout()
        CType(Me.dgvWgs84ToOutputDTOps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.udPointFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.dgvConversion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(1192, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(48, 22)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMessages
        '
        Me.btnMessages.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMessages.Location = New System.Drawing.Point(1052, 12)
        Me.btnMessages.Name = "btnMessages"
        Me.btnMessages.Size = New System.Drawing.Size(72, 22)
        Me.btnMessages.TabIndex = 33
        Me.btnMessages.Text = "Messages"
        Me.btnMessages.UseVisualStyleBackColor = True
        '
        'btnOnline
        '
        Me.btnOnline.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOnline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnline.ForeColor = System.Drawing.Color.Red
        Me.btnOnline.Location = New System.Drawing.Point(1130, 12)
        Me.btnOnline.Name = "btnOnline"
        Me.btnOnline.Size = New System.Drawing.Size(56, 22)
        Me.btnOnline.TabIndex = 36
        Me.btnOnline.Text = "Offline"
        Me.ToolTip1.SetToolTip(Me.btnOnline, "Toggle the connection to the Andorville™ Network")
        Me.btnOnline.UseVisualStyleBackColor = True
        '
        'btnAppInfo
        '
        Me.btnAppInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAppInfo.Location = New System.Drawing.Point(951, 12)
        Me.btnAppInfo.Name = "btnAppInfo"
        Me.btnAppInfo.Size = New System.Drawing.Size(95, 22)
        Me.btnAppInfo.TabIndex = 45
        Me.btnAppInfo.Text = "Application Info"
        Me.btnAppInfo.UseVisualStyleBackColor = True
        '
        'btnProject
        '
        Me.btnProject.Location = New System.Drawing.Point(6, 6)
        Me.btnProject.Name = "btnProject"
        Me.btnProject.Size = New System.Drawing.Size(72, 22)
        Me.btnProject.TabIndex = 47
        Me.btnProject.Text = "Project List"
        Me.btnProject.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.AllowDrop = True
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1228, 549)
        Me.TabControl1.TabIndex = 48
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.WebBrowser1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1220, 523)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Workflow"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1214, 517)
        Me.WebBrowser1.TabIndex = 68
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCloseCoordsServer)
        Me.TabPage1.Controls.Add(Me.btnOpenCoordsServer)
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1220, 523)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Coordinates"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCloseCoordsServer
        '
        Me.btnCloseCoordsServer.Location = New System.Drawing.Point(173, 6)
        Me.btnCloseCoordsServer.Name = "btnCloseCoordsServer"
        Me.btnCloseCoordsServer.Size = New System.Drawing.Size(161, 22)
        Me.btnCloseCoordsServer.TabIndex = 230
        Me.btnCloseCoordsServer.Text = "Close the Coordinates Server"
        Me.btnCloseCoordsServer.UseVisualStyleBackColor = True
        '
        'btnOpenCoordsServer
        '
        Me.btnOpenCoordsServer.Location = New System.Drawing.Point(6, 6)
        Me.btnOpenCoordsServer.Name = "btnOpenCoordsServer"
        Me.btnOpenCoordsServer.Size = New System.Drawing.Size(161, 22)
        Me.btnOpenCoordsServer.TabIndex = 229
        Me.btnOpenCoordsServer.Text = "Open the Coordinates Server"
        Me.btnOpenCoordsServer.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(6, 34)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1211, 483)
        Me.TabControl2.TabIndex = 70
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtCrsKind)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.txtCrsCode)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.btnGetCrsList)
        Me.TabPage4.Controls.Add(Me.txtCrsNameContains)
        Me.TabPage4.Controls.Add(Me.chkCrsNameContains)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.btnSetOutputCrs)
        Me.TabPage4.Controls.Add(Me.btnSetInputCrs)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.cmbCrsList)
        Me.TabPage4.Controls.Add(Me.rbContainingPoint)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.rbInside)
        Me.TabPage4.Controls.Add(Me.rbExtendingInto)
        Me.TabPage4.Controls.Add(Me.rbGetAll)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1203, 457)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Coordinate Reference Systems"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtCrsKind
        '
        Me.txtCrsKind.Location = New System.Drawing.Point(178, 346)
        Me.txtCrsKind.Name = "txtCrsKind"
        Me.txtCrsKind.Size = New System.Drawing.Size(90, 20)
        Me.txtCrsKind.TabIndex = 243
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(141, 349)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 242
        Me.Label20.Text = "Kind:"
        '
        'txtCrsCode
        '
        Me.txtCrsCode.Location = New System.Drawing.Point(45, 346)
        Me.txtCrsCode.Name = "txtCrsCode"
        Me.txtCrsCode.Size = New System.Drawing.Size(90, 20)
        Me.txtCrsCode.TabIndex = 241
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 349)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 240
        Me.Label19.Text = "Code:"
        '
        'btnGetCrsList
        '
        Me.btnGetCrsList.Location = New System.Drawing.Point(6, 6)
        Me.btnGetCrsList.Name = "btnGetCrsList"
        Me.btnGetCrsList.Size = New System.Drawing.Size(93, 22)
        Me.btnGetCrsList.TabIndex = 239
        Me.btnGetCrsList.Text = "Get CRS List"
        Me.btnGetCrsList.UseVisualStyleBackColor = True
        '
        'txtCrsNameContains
        '
        Me.txtCrsNameContains.Location = New System.Drawing.Point(254, 270)
        Me.txtCrsNameContains.Name = "txtCrsNameContains"
        Me.txtCrsNameContains.Size = New System.Drawing.Size(165, 20)
        Me.txtCrsNameContains.TabIndex = 238
        '
        'chkCrsNameContains
        '
        Me.chkCrsNameContains.AutoSize = True
        Me.chkCrsNameContains.Location = New System.Drawing.Point(125, 273)
        Me.chkCrsNameContains.Name = "chkCrsNameContains"
        Me.chkCrsNameContains.Size = New System.Drawing.Size(123, 17)
        Me.chkCrsNameContains.TabIndex = 237
        Me.chkCrsNameContains.Text = "CRS name contains:"
        Me.chkCrsNameContains.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNone)
        Me.GroupBox3.Controls.Add(Me.btnAll)
        Me.GroupBox3.Controls.Add(Me.chkProjected)
        Me.GroupBox3.Controls.Add(Me.chkVertical)
        Me.GroupBox3.Controls.Add(Me.chkGeographic2D)
        Me.GroupBox3.Controls.Add(Me.chkGeocentric)
        Me.GroupBox3.Controls.Add(Me.chkGeographic3D)
        Me.GroupBox3.Controls.Add(Me.chkEngineering)
        Me.GroupBox3.Controls.Add(Me.chkCompound)
        Me.GroupBox3.Controls.Add(Me.chkDerived)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(113, 256)
        Me.GroupBox3.TabIndex = 236
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CRS Kind:"
        '
        'btnNone
        '
        Me.btnNone.Location = New System.Drawing.Point(6, 228)
        Me.btnNone.Name = "btnNone"
        Me.btnNone.Size = New System.Drawing.Size(63, 22)
        Me.btnNone.TabIndex = 241
        Me.btnNone.Text = "None"
        Me.btnNone.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(6, 200)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(63, 22)
        Me.btnAll.TabIndex = 240
        Me.btnAll.Text = "All"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'chkProjected
        '
        Me.chkProjected.AutoSize = True
        Me.chkProjected.Location = New System.Drawing.Point(6, 19)
        Me.chkProjected.Name = "chkProjected"
        Me.chkProjected.Size = New System.Drawing.Size(71, 17)
        Me.chkProjected.TabIndex = 230
        Me.chkProjected.Text = "Projected"
        Me.chkProjected.UseVisualStyleBackColor = True
        '
        'chkVertical
        '
        Me.chkVertical.AutoSize = True
        Me.chkVertical.Location = New System.Drawing.Point(6, 180)
        Me.chkVertical.Name = "chkVertical"
        Me.chkVertical.Size = New System.Drawing.Size(61, 17)
        Me.chkVertical.TabIndex = 235
        Me.chkVertical.Text = "Vertical"
        Me.chkVertical.UseVisualStyleBackColor = True
        '
        'chkGeographic2D
        '
        Me.chkGeographic2D.AutoSize = True
        Me.chkGeographic2D.Location = New System.Drawing.Point(6, 42)
        Me.chkGeographic2D.Name = "chkGeographic2D"
        Me.chkGeographic2D.Size = New System.Drawing.Size(98, 17)
        Me.chkGeographic2D.TabIndex = 209
        Me.chkGeographic2D.Text = "Geographic 2D"
        Me.chkGeographic2D.UseVisualStyleBackColor = True
        '
        'chkGeocentric
        '
        Me.chkGeocentric.AutoSize = True
        Me.chkGeocentric.Location = New System.Drawing.Point(6, 157)
        Me.chkGeocentric.Name = "chkGeocentric"
        Me.chkGeocentric.Size = New System.Drawing.Size(78, 17)
        Me.chkGeocentric.TabIndex = 234
        Me.chkGeocentric.Text = "Geocentric"
        Me.chkGeocentric.UseVisualStyleBackColor = True
        '
        'chkGeographic3D
        '
        Me.chkGeographic3D.AutoSize = True
        Me.chkGeographic3D.Location = New System.Drawing.Point(6, 65)
        Me.chkGeographic3D.Name = "chkGeographic3D"
        Me.chkGeographic3D.Size = New System.Drawing.Size(98, 17)
        Me.chkGeographic3D.TabIndex = 210
        Me.chkGeographic3D.Text = "Geographic 3D"
        Me.chkGeographic3D.UseVisualStyleBackColor = True
        '
        'chkEngineering
        '
        Me.chkEngineering.AutoSize = True
        Me.chkEngineering.Location = New System.Drawing.Point(6, 134)
        Me.chkEngineering.Name = "chkEngineering"
        Me.chkEngineering.Size = New System.Drawing.Size(82, 17)
        Me.chkEngineering.TabIndex = 233
        Me.chkEngineering.Text = "Engineering"
        Me.chkEngineering.UseVisualStyleBackColor = True
        '
        'chkCompound
        '
        Me.chkCompound.AutoSize = True
        Me.chkCompound.Location = New System.Drawing.Point(6, 88)
        Me.chkCompound.Name = "chkCompound"
        Me.chkCompound.Size = New System.Drawing.Size(77, 17)
        Me.chkCompound.TabIndex = 231
        Me.chkCompound.Text = "Compound"
        Me.chkCompound.UseVisualStyleBackColor = True
        '
        'chkDerived
        '
        Me.chkDerived.AutoSize = True
        Me.chkDerived.Location = New System.Drawing.Point(6, 111)
        Me.chkDerived.Name = "chkDerived"
        Me.chkDerived.Size = New System.Drawing.Size(63, 17)
        Me.chkDerived.TabIndex = 232
        Me.chkDerived.Text = "Derived"
        Me.chkDerived.UseVisualStyleBackColor = True
        '
        'btnSetOutputCrs
        '
        Me.btnSetOutputCrs.Location = New System.Drawing.Point(393, 319)
        Me.btnSetOutputCrs.Name = "btnSetOutputCrs"
        Me.btnSetOutputCrs.Size = New System.Drawing.Size(91, 22)
        Me.btnSetOutputCrs.TabIndex = 229
        Me.btnSetOutputCrs.Text = "Set Output CRS"
        Me.btnSetOutputCrs.UseVisualStyleBackColor = True
        '
        'btnSetInputCrs
        '
        Me.btnSetInputCrs.Location = New System.Drawing.Point(296, 319)
        Me.btnSetInputCrs.Name = "btnSetInputCrs"
        Me.btnSetInputCrs.Size = New System.Drawing.Size(91, 22)
        Me.btnSetInputCrs.TabIndex = 228
        Me.btnSetInputCrs.Text = "Set Input CRS"
        Me.btnSetInputCrs.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 303)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(151, 13)
        Me.Label18.TabIndex = 227
        Me.Label18.Text = "Coordinate Reference System:"
        '
        'cmbCrsList
        '
        Me.cmbCrsList.FormattingEnabled = True
        Me.cmbCrsList.Location = New System.Drawing.Point(6, 319)
        Me.cmbCrsList.Name = "cmbCrsList"
        Me.cmbCrsList.Size = New System.Drawing.Size(284, 21)
        Me.cmbCrsList.TabIndex = 226
        '
        'rbContainingPoint
        '
        Me.rbContainingPoint.AutoSize = True
        Me.rbContainingPoint.Location = New System.Drawing.Point(125, 194)
        Me.rbContainingPoint.Name = "rbContainingPoint"
        Me.rbContainingPoint.Size = New System.Drawing.Size(181, 17)
        Me.rbContainingPoint.TabIndex = 225
        Me.rbContainingPoint.TabStop = True
        Me.rbContainingPoint.Text = "Get all CRSs containing the point"
        Me.rbContainingPoint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRefLat)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtRefLong)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(125, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 50)
        Me.GroupBox2.TabIndex = 224
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Geographic reference point:"
        '
        'txtRefLat
        '
        Me.txtRefLat.Location = New System.Drawing.Point(241, 19)
        Me.txtRefLat.Name = "txtRefLat"
        Me.txtRefLat.Size = New System.Drawing.Size(110, 20)
        Me.txtRefLat.TabIndex = 225
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(187, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 224
        Me.Label16.Text = "Latitude:"
        '
        'txtRefLong
        '
        Me.txtRefLong.Location = New System.Drawing.Point(71, 19)
        Me.txtRefLong.Name = "txtRefLong"
        Me.txtRefLong.Size = New System.Drawing.Size(110, 20)
        Me.txtRefLong.TabIndex = 223
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 13)
        Me.Label17.TabIndex = 222
        Me.Label17.Text = "Longitude:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNorthLatBound)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtEastLongBound)
        Me.GroupBox1.Controls.Add(Me.txtSouthLatBound)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtWestLongBound)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(125, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 108)
        Me.GroupBox1.TabIndex = 223
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Geographic bounding area:"
        '
        'txtNorthLatBound
        '
        Me.txtNorthLatBound.Location = New System.Drawing.Point(114, 19)
        Me.txtNorthLatBound.Name = "txtNorthLatBound"
        Me.txtNorthLatBound.Size = New System.Drawing.Size(120, 20)
        Me.txtNorthLatBound.TabIndex = 217
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(70, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 214
        Me.Label15.Text = "South:"
        '
        'txtEastLongBound
        '
        Me.txtEastLongBound.Location = New System.Drawing.Point(233, 45)
        Me.txtEastLongBound.Name = "txtEastLongBound"
        Me.txtEastLongBound.Size = New System.Drawing.Size(120, 20)
        Me.txtEastLongBound.TabIndex = 221
        '
        'txtSouthLatBound
        '
        Me.txtSouthLatBound.Location = New System.Drawing.Point(114, 71)
        Me.txtSouthLatBound.Name = "txtSouthLatBound"
        Me.txtSouthLatBound.Size = New System.Drawing.Size(120, 20)
        Me.txtSouthLatBound.TabIndex = 215
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 220
        Me.Label7.Text = "East:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(72, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 216
        Me.Label14.Text = "North:"
        '
        'txtWestLongBound
        '
        Me.txtWestLongBound.Location = New System.Drawing.Point(49, 45)
        Me.txtWestLongBound.Name = "txtWestLongBound"
        Me.txtWestLongBound.Size = New System.Drawing.Size(120, 20)
        Me.txtWestLongBound.TabIndex = 219
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 218
        Me.Label5.Text = "West:"
        '
        'rbInside
        '
        Me.rbInside.AutoSize = True
        Me.rbInside.Location = New System.Drawing.Point(327, 57)
        Me.rbInside.Name = "rbInside"
        Me.rbInside.Size = New System.Drawing.Size(157, 17)
        Me.rbInside.TabIndex = 213
        Me.rbInside.TabStop = True
        Me.rbInside.Text = "Get all CRSs inside the area"
        Me.rbInside.UseVisualStyleBackColor = True
        '
        'rbExtendingInto
        '
        Me.rbExtendingInto.AutoSize = True
        Me.rbExtendingInto.Location = New System.Drawing.Point(125, 57)
        Me.rbExtendingInto.Name = "rbExtendingInto"
        Me.rbExtendingInto.Size = New System.Drawing.Size(196, 17)
        Me.rbExtendingInto.TabIndex = 212
        Me.rbExtendingInto.TabStop = True
        Me.rbExtendingInto.Text = "Get all CRSs extending into the area"
        Me.rbExtendingInto.UseVisualStyleBackColor = True
        '
        'rbGetAll
        '
        Me.rbGetAll.AutoSize = True
        Me.rbGetAll.Location = New System.Drawing.Point(125, 34)
        Me.rbGetAll.Name = "rbGetAll"
        Me.rbGetAll.Size = New System.Drawing.Size(204, 17)
        Me.rbGetAll.TabIndex = 211
        Me.rbGetAll.TabStop = True
        Me.rbGetAll.Text = "Get all Coordinate Reference Systems"
        Me.rbGetAll.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnAutoSelectDatumTrans)
        Me.TabPage5.Controls.Add(Me.btnGetDatumTransList)
        Me.TabPage5.Controls.Add(Me.Label158)
        Me.TabPage5.Controls.Add(Me.txtAccuracy)
        Me.TabPage5.Controls.Add(Me.btdSetDatumTrans)
        Me.TabPage5.Controls.Add(Me.rbDatumTransViaWgs84)
        Me.TabPage5.Controls.Add(Me.rbDirectDatumTrans)
        Me.TabPage5.Controls.Add(Me.rbDtNotRequired)
        Me.TabPage5.Controls.Add(Me.TabControl3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1203, 457)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Datum Transformation"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnAutoSelectDatumTrans
        '
        Me.btnAutoSelectDatumTrans.Location = New System.Drawing.Point(525, 4)
        Me.btnAutoSelectDatumTrans.Name = "btnAutoSelectDatumTrans"
        Me.btnAutoSelectDatumTrans.Size = New System.Drawing.Size(83, 22)
        Me.btnAutoSelectDatumTrans.TabIndex = 233
        Me.btnAutoSelectDatumTrans.Text = "Auto Select"
        Me.btnAutoSelectDatumTrans.UseVisualStyleBackColor = True
        '
        'btnGetDatumTransList
        '
        Me.btnGetDatumTransList.Location = New System.Drawing.Point(378, 4)
        Me.btnGetDatumTransList.Name = "btnGetDatumTransList"
        Me.btnGetDatumTransList.Size = New System.Drawing.Size(141, 22)
        Me.btnGetDatumTransList.TabIndex = 232
        Me.btnGetDatumTransList.Text = "Get Transformation List"
        Me.btnGetDatumTransList.UseVisualStyleBackColor = True
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Location = New System.Drawing.Point(244, 9)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(55, 13)
        Me.Label158.TabIndex = 231
        Me.Label158.Text = "Accuracy:"
        '
        'txtAccuracy
        '
        Me.txtAccuracy.Location = New System.Drawing.Point(305, 6)
        Me.txtAccuracy.Name = "txtAccuracy"
        Me.txtAccuracy.ReadOnly = True
        Me.txtAccuracy.Size = New System.Drawing.Size(67, 20)
        Me.txtAccuracy.TabIndex = 230
        '
        'btdSetDatumTrans
        '
        Me.btdSetDatumTrans.Location = New System.Drawing.Point(614, 4)
        Me.btdSetDatumTrans.Name = "btdSetDatumTrans"
        Me.btdSetDatumTrans.Size = New System.Drawing.Size(152, 22)
        Me.btdSetDatumTrans.TabIndex = 229
        Me.btdSetDatumTrans.Text = "Set Datum Transformation"
        Me.btdSetDatumTrans.UseVisualStyleBackColor = True
        '
        'rbDatumTransViaWgs84
        '
        Me.rbDatumTransViaWgs84.AutoSize = True
        Me.rbDatumTransViaWgs84.Location = New System.Drawing.Point(154, 6)
        Me.rbDatumTransViaWgs84.Name = "rbDatumTransViaWgs84"
        Me.rbDatumTransViaWgs84.Size = New System.Drawing.Size(84, 17)
        Me.rbDatumTransViaWgs84.TabIndex = 3
        Me.rbDatumTransViaWgs84.Text = "Via WGS 84"
        Me.rbDatumTransViaWgs84.UseVisualStyleBackColor = True
        '
        'rbDirectDatumTrans
        '
        Me.rbDirectDatumTrans.AutoSize = True
        Me.rbDirectDatumTrans.Location = New System.Drawing.Point(95, 6)
        Me.rbDirectDatumTrans.Name = "rbDirectDatumTrans"
        Me.rbDirectDatumTrans.Size = New System.Drawing.Size(53, 17)
        Me.rbDirectDatumTrans.TabIndex = 2
        Me.rbDirectDatumTrans.Text = "Direct"
        Me.rbDirectDatumTrans.UseVisualStyleBackColor = True
        '
        'rbDtNotRequired
        '
        Me.rbDtNotRequired.AutoSize = True
        Me.rbDtNotRequired.Checked = True
        Me.rbDtNotRequired.Location = New System.Drawing.Point(6, 6)
        Me.rbDtNotRequired.Name = "rbDtNotRequired"
        Me.rbDtNotRequired.Size = New System.Drawing.Size(83, 17)
        Me.rbDtNotRequired.TabIndex = 1
        Me.rbDtNotRequired.TabStop = True
        Me.rbDtNotRequired.Text = "Not required"
        Me.rbDtNotRequired.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Controls.Add(Me.TabPage9)
        Me.TabControl3.Location = New System.Drawing.Point(6, 29)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1191, 422)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.Label154)
        Me.TabPage8.Controls.Add(Me.Label153)
        Me.TabPage8.Controls.Add(Me.txtDirectDTOpName)
        Me.TabPage8.Controls.Add(Me.txtDirectDTOpCode)
        Me.TabPage8.Controls.Add(Me.Label119)
        Me.TabPage8.Controls.Add(Me.txtDirectDTOpAccuracy)
        Me.TabPage8.Controls.Add(Me.dgvDirectDTOps)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1183, 396)
        Me.TabPage8.TabIndex = 0
        Me.TabPage8.Text = "Direct"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Label154
        '
        Me.Label154.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label154.AutoSize = True
        Me.Label154.Location = New System.Drawing.Point(331, 9)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(35, 13)
        Me.Label154.TabIndex = 80
        Me.Label154.Text = "Code:"
        '
        'Label153
        '
        Me.Label153.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label153.AutoSize = True
        Me.Label153.Location = New System.Drawing.Point(5, 9)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(85, 13)
        Me.Label153.TabIndex = 79
        Me.Label153.Text = "Operation name:"
        '
        'txtDirectDTOpName
        '
        Me.txtDirectDTOpName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDirectDTOpName.Location = New System.Drawing.Point(96, 6)
        Me.txtDirectDTOpName.Name = "txtDirectDTOpName"
        Me.txtDirectDTOpName.ReadOnly = True
        Me.txtDirectDTOpName.Size = New System.Drawing.Size(229, 20)
        Me.txtDirectDTOpName.TabIndex = 77
        '
        'txtDirectDTOpCode
        '
        Me.txtDirectDTOpCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDirectDTOpCode.Location = New System.Drawing.Point(372, 6)
        Me.txtDirectDTOpCode.Name = "txtDirectDTOpCode"
        Me.txtDirectDTOpCode.ReadOnly = True
        Me.txtDirectDTOpCode.Size = New System.Drawing.Size(63, 20)
        Me.txtDirectDTOpCode.TabIndex = 78
        '
        'Label119
        '
        Me.Label119.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label119.AutoSize = True
        Me.Label119.Location = New System.Drawing.Point(450, 9)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(55, 13)
        Me.Label119.TabIndex = 76
        Me.Label119.Text = "Accuracy:"
        '
        'txtDirectDTOpAccuracy
        '
        Me.txtDirectDTOpAccuracy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDirectDTOpAccuracy.Location = New System.Drawing.Point(511, 6)
        Me.txtDirectDTOpAccuracy.Name = "txtDirectDTOpAccuracy"
        Me.txtDirectDTOpAccuracy.ReadOnly = True
        Me.txtDirectDTOpAccuracy.Size = New System.Drawing.Size(67, 20)
        Me.txtDirectDTOpAccuracy.TabIndex = 75
        '
        'dgvDirectDTOps
        '
        Me.dgvDirectDTOps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDirectDTOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDirectDTOps.Location = New System.Drawing.Point(3, 32)
        Me.dgvDirectDTOps.MultiSelect = False
        Me.dgvDirectDTOps.Name = "dgvDirectDTOps"
        Me.dgvDirectDTOps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDirectDTOps.Size = New System.Drawing.Size(1177, 361)
        Me.dgvDirectDTOps.TabIndex = 36
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.TabControl4)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(1183, 396)
        Me.TabPage9.TabIndex = 1
        Me.TabPage9.Text = "Via WGS 84"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Controls.Add(Me.TabPage10)
        Me.TabControl4.Controls.Add(Me.TabPage11)
        Me.TabControl4.Location = New System.Drawing.Point(3, 6)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(918, 387)
        Me.TabControl4.TabIndex = 0
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.dgvInputToWgs84DTOps)
        Me.TabPage10.Controls.Add(Me.Label169)
        Me.TabPage10.Controls.Add(Me.Label170)
        Me.TabPage10.Controls.Add(Me.txtInputToWgs84DTOpName)
        Me.TabPage10.Controls.Add(Me.txtInputToWgs84DTOpCode)
        Me.TabPage10.Controls.Add(Me.Label173)
        Me.TabPage10.Controls.Add(Me.txtInputToWgs84DTOpAccuracy)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(910, 361)
        Me.TabPage10.TabIndex = 0
        Me.TabPage10.Text = "Input to WGS 84"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'dgvInputToWgs84DTOps
        '
        Me.dgvInputToWgs84DTOps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInputToWgs84DTOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInputToWgs84DTOps.Location = New System.Drawing.Point(3, 32)
        Me.dgvInputToWgs84DTOps.MultiSelect = False
        Me.dgvInputToWgs84DTOps.Name = "dgvInputToWgs84DTOps"
        Me.dgvInputToWgs84DTOps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInputToWgs84DTOps.Size = New System.Drawing.Size(904, 326)
        Me.dgvInputToWgs84DTOps.TabIndex = 99
        '
        'Label169
        '
        Me.Label169.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label169.AutoSize = True
        Me.Label169.Location = New System.Drawing.Point(331, 9)
        Me.Label169.Name = "Label169"
        Me.Label169.Size = New System.Drawing.Size(35, 13)
        Me.Label169.TabIndex = 98
        Me.Label169.Text = "Code:"
        '
        'Label170
        '
        Me.Label170.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label170.AutoSize = True
        Me.Label170.Location = New System.Drawing.Point(5, 9)
        Me.Label170.Name = "Label170"
        Me.Label170.Size = New System.Drawing.Size(85, 13)
        Me.Label170.TabIndex = 97
        Me.Label170.Text = "Operation name:"
        '
        'txtInputToWgs84DTOpName
        '
        Me.txtInputToWgs84DTOpName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInputToWgs84DTOpName.Location = New System.Drawing.Point(96, 6)
        Me.txtInputToWgs84DTOpName.Name = "txtInputToWgs84DTOpName"
        Me.txtInputToWgs84DTOpName.ReadOnly = True
        Me.txtInputToWgs84DTOpName.Size = New System.Drawing.Size(229, 20)
        Me.txtInputToWgs84DTOpName.TabIndex = 95
        '
        'txtInputToWgs84DTOpCode
        '
        Me.txtInputToWgs84DTOpCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInputToWgs84DTOpCode.Location = New System.Drawing.Point(372, 6)
        Me.txtInputToWgs84DTOpCode.Name = "txtInputToWgs84DTOpCode"
        Me.txtInputToWgs84DTOpCode.ReadOnly = True
        Me.txtInputToWgs84DTOpCode.Size = New System.Drawing.Size(63, 20)
        Me.txtInputToWgs84DTOpCode.TabIndex = 96
        '
        'Label173
        '
        Me.Label173.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label173.AutoSize = True
        Me.Label173.Location = New System.Drawing.Point(450, 9)
        Me.Label173.Name = "Label173"
        Me.Label173.Size = New System.Drawing.Size(55, 13)
        Me.Label173.TabIndex = 94
        Me.Label173.Text = "Accuracy:"
        '
        'txtInputToWgs84DTOpAccuracy
        '
        Me.txtInputToWgs84DTOpAccuracy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInputToWgs84DTOpAccuracy.Location = New System.Drawing.Point(511, 6)
        Me.txtInputToWgs84DTOpAccuracy.Name = "txtInputToWgs84DTOpAccuracy"
        Me.txtInputToWgs84DTOpAccuracy.ReadOnly = True
        Me.txtInputToWgs84DTOpAccuracy.Size = New System.Drawing.Size(67, 20)
        Me.txtInputToWgs84DTOpAccuracy.TabIndex = 93
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.Label126)
        Me.TabPage11.Controls.Add(Me.Label127)
        Me.TabPage11.Controls.Add(Me.txtWgs84ToOutputDTOpName)
        Me.TabPage11.Controls.Add(Me.txtWgs84ToOutputDTOpCode)
        Me.TabPage11.Controls.Add(Me.Label130)
        Me.TabPage11.Controls.Add(Me.txtWgs84ToOutputDTOpAccuracy)
        Me.TabPage11.Controls.Add(Me.dgvWgs84ToOutputDTOps)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(910, 361)
        Me.TabPage11.TabIndex = 1
        Me.TabPage11.Text = "WGS 84 to Output"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'Label126
        '
        Me.Label126.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label126.AutoSize = True
        Me.Label126.Location = New System.Drawing.Point(331, 9)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(35, 13)
        Me.Label126.TabIndex = 116
        Me.Label126.Text = "Code:"
        '
        'Label127
        '
        Me.Label127.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label127.AutoSize = True
        Me.Label127.Location = New System.Drawing.Point(5, 9)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(85, 13)
        Me.Label127.TabIndex = 115
        Me.Label127.Text = "Operation name:"
        '
        'txtWgs84ToOutputDTOpName
        '
        Me.txtWgs84ToOutputDTOpName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWgs84ToOutputDTOpName.Location = New System.Drawing.Point(96, 6)
        Me.txtWgs84ToOutputDTOpName.Name = "txtWgs84ToOutputDTOpName"
        Me.txtWgs84ToOutputDTOpName.ReadOnly = True
        Me.txtWgs84ToOutputDTOpName.Size = New System.Drawing.Size(229, 20)
        Me.txtWgs84ToOutputDTOpName.TabIndex = 113
        '
        'txtWgs84ToOutputDTOpCode
        '
        Me.txtWgs84ToOutputDTOpCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWgs84ToOutputDTOpCode.Location = New System.Drawing.Point(372, 6)
        Me.txtWgs84ToOutputDTOpCode.Name = "txtWgs84ToOutputDTOpCode"
        Me.txtWgs84ToOutputDTOpCode.ReadOnly = True
        Me.txtWgs84ToOutputDTOpCode.Size = New System.Drawing.Size(63, 20)
        Me.txtWgs84ToOutputDTOpCode.TabIndex = 114
        '
        'Label130
        '
        Me.Label130.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(450, 9)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(55, 13)
        Me.Label130.TabIndex = 112
        Me.Label130.Text = "Accuracy:"
        '
        'txtWgs84ToOutputDTOpAccuracy
        '
        Me.txtWgs84ToOutputDTOpAccuracy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWgs84ToOutputDTOpAccuracy.Location = New System.Drawing.Point(511, 6)
        Me.txtWgs84ToOutputDTOpAccuracy.Name = "txtWgs84ToOutputDTOpAccuracy"
        Me.txtWgs84ToOutputDTOpAccuracy.ReadOnly = True
        Me.txtWgs84ToOutputDTOpAccuracy.Size = New System.Drawing.Size(67, 20)
        Me.txtWgs84ToOutputDTOpAccuracy.TabIndex = 111
        '
        'dgvWgs84ToOutputDTOps
        '
        Me.dgvWgs84ToOutputDTOps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvWgs84ToOutputDTOps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWgs84ToOutputDTOps.Location = New System.Drawing.Point(3, 32)
        Me.dgvWgs84ToOutputDTOps.MultiSelect = False
        Me.dgvWgs84ToOutputDTOps.Name = "dgvWgs84ToOutputDTOps"
        Me.dgvWgs84ToOutputDTOps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWgs84ToOutputDTOps.Size = New System.Drawing.Size(680, 326)
        Me.dgvWgs84ToOutputDTOps.TabIndex = 38
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox21)
        Me.TabPage6.Controls.Add(Me.GroupBox4)
        Me.TabPage6.Controls.Add(Me.GroupBox22)
        Me.TabPage6.Controls.Add(Me.GroupBox17)
        Me.TabPage6.Controls.Add(Me.GroupBox16)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1203, 457)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Settings"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.chkShowPointDescription)
        Me.GroupBox21.Controls.Add(Me.chkShowPointName)
        Me.GroupBox21.Controls.Add(Me.chkShowPointNumber)
        Me.GroupBox21.Location = New System.Drawing.Point(6, 107)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(119, 95)
        Me.GroupBox21.TabIndex = 15
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Show Annotation:"
        '
        'chkShowPointDescription
        '
        Me.chkShowPointDescription.AutoSize = True
        Me.chkShowPointDescription.Location = New System.Drawing.Point(6, 65)
        Me.chkShowPointDescription.Name = "chkShowPointDescription"
        Me.chkShowPointDescription.Size = New System.Drawing.Size(106, 17)
        Me.chkShowPointDescription.TabIndex = 3
        Me.chkShowPointDescription.Text = "Point Description"
        Me.chkShowPointDescription.UseVisualStyleBackColor = True
        '
        'chkShowPointName
        '
        Me.chkShowPointName.AutoSize = True
        Me.chkShowPointName.Location = New System.Drawing.Point(6, 42)
        Me.chkShowPointName.Name = "chkShowPointName"
        Me.chkShowPointName.Size = New System.Drawing.Size(81, 17)
        Me.chkShowPointName.TabIndex = 2
        Me.chkShowPointName.Text = "Point Name"
        Me.chkShowPointName.UseVisualStyleBackColor = True
        '
        'chkShowPointNumber
        '
        Me.chkShowPointNumber.AutoSize = True
        Me.chkShowPointNumber.Location = New System.Drawing.Point(6, 19)
        Me.chkShowPointNumber.Name = "chkShowPointNumber"
        Me.chkShowPointNumber.Size = New System.Drawing.Size(90, 17)
        Me.chkShowPointNumber.TabIndex = 1
        Me.chkShowPointNumber.Text = "Point Number"
        Me.chkShowPointNumber.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtDataName)
        Me.GroupBox4.Controls.Add(Me.Label111)
        Me.GroupBox4.Controls.Add(Me.txtDescription)
        Me.GroupBox4.Controls.Add(Me.Label52)
        Me.GroupBox4.Controls.Add(Me.txtFileName)
        Me.GroupBox4.Controls.Add(Me.Label110)
        Me.GroupBox4.Controls.Add(Me.btnNewConvFile)
        Me.GroupBox4.Controls.Add(Me.btnOpenConvFile)
        Me.GroupBox4.Controls.Add(Me.btnSaveConvFile)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 209)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1191, 174)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "File:"
        '
        'txtDataName
        '
        Me.txtDataName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataName.Location = New System.Drawing.Point(83, 73)
        Me.txtDataName.Name = "txtDataName"
        Me.txtDataName.Size = New System.Drawing.Size(1102, 20)
        Me.txtDataName.TabIndex = 358
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(9, 76)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(62, 13)
        Me.Label111.TabIndex = 357
        Me.Label111.Text = "Data name:"
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.Location = New System.Drawing.Point(83, 99)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(1102, 62)
        Me.txtDescription.TabIndex = 356
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(9, 102)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(63, 13)
        Me.Label52.TabIndex = 355
        Me.Label52.Text = "Description:"
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.Location = New System.Drawing.Point(83, 47)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(1102, 20)
        Me.txtFileName.TabIndex = 354
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(6, 50)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(55, 13)
        Me.Label110.TabIndex = 353
        Me.Label110.Text = "File name:"
        '
        'btnNewConvFile
        '
        Me.btnNewConvFile.Location = New System.Drawing.Point(7, 19)
        Me.btnNewConvFile.Name = "btnNewConvFile"
        Me.btnNewConvFile.Size = New System.Drawing.Size(45, 22)
        Me.btnNewConvFile.TabIndex = 349
        Me.btnNewConvFile.Text = "New"
        Me.btnNewConvFile.UseVisualStyleBackColor = True
        '
        'btnOpenConvFile
        '
        Me.btnOpenConvFile.Location = New System.Drawing.Point(109, 19)
        Me.btnOpenConvFile.Name = "btnOpenConvFile"
        Me.btnOpenConvFile.Size = New System.Drawing.Size(45, 22)
        Me.btnOpenConvFile.TabIndex = 348
        Me.btnOpenConvFile.Text = "Open"
        Me.btnOpenConvFile.UseVisualStyleBackColor = True
        '
        'btnSaveConvFile
        '
        Me.btnSaveConvFile.Location = New System.Drawing.Point(58, 19)
        Me.btnSaveConvFile.Name = "btnSaveConvFile"
        Me.btnSaveConvFile.Size = New System.Drawing.Size(45, 22)
        Me.btnSaveConvFile.TabIndex = 347
        Me.btnSaveConvFile.Text = "Save"
        Me.btnSaveConvFile.UseVisualStyleBackColor = True
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.btnFormatHelp3)
        Me.GroupBox22.Controls.Add(Me.txtHeightFormat)
        Me.GroupBox22.Controls.Add(Me.Label208)
        Me.GroupBox22.Controls.Add(Me.txtCartFormat)
        Me.GroupBox22.Controls.Add(Me.Label207)
        Me.GroupBox22.Controls.Add(Me.chkDmsSymbols)
        Me.GroupBox22.Controls.Add(Me.txtProjFormat)
        Me.GroupBox22.Controls.Add(Me.txtSecondsDecPlaces)
        Me.GroupBox22.Controls.Add(Me.Label204)
        Me.GroupBox22.Controls.Add(Me.txtDegreeDecPlaces)
        Me.GroupBox22.Controls.Add(Me.rbDecDegrees)
        Me.GroupBox22.Controls.Add(Me.Label206)
        Me.GroupBox22.Controls.Add(Me.rbDMS)
        Me.GroupBox22.Controls.Add(Me.Label205)
        Me.GroupBox22.Location = New System.Drawing.Point(131, 108)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(409, 95)
        Me.GroupBox22.TabIndex = 13
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Display Format:"
        '
        'btnFormatHelp3
        '
        Me.btnFormatHelp3.Location = New System.Drawing.Point(208, 10)
        Me.btnFormatHelp3.Name = "btnFormatHelp3"
        Me.btnFormatHelp3.Size = New System.Drawing.Size(23, 22)
        Me.btnFormatHelp3.TabIndex = 48
        Me.btnFormatHelp3.Text = "?"
        Me.btnFormatHelp3.UseVisualStyleBackColor = True
        '
        'txtHeightFormat
        '
        Me.txtHeightFormat.Location = New System.Drawing.Point(346, 38)
        Me.txtHeightFormat.Name = "txtHeightFormat"
        Me.txtHeightFormat.Size = New System.Drawing.Size(50, 20)
        Me.txtHeightFormat.TabIndex = 16
        '
        'Label208
        '
        Me.Label208.AutoSize = True
        Me.Label208.Location = New System.Drawing.Point(264, 41)
        Me.Label208.Name = "Label208"
        Me.Label208.Size = New System.Drawing.Size(76, 13)
        Me.Label208.TabIndex = 15
        Me.Label208.Text = "Height Format:"
        '
        'txtCartFormat
        '
        Me.txtCartFormat.Location = New System.Drawing.Point(346, 12)
        Me.txtCartFormat.Name = "txtCartFormat"
        Me.txtCartFormat.Size = New System.Drawing.Size(50, 20)
        Me.txtCartFormat.TabIndex = 14
        '
        'Label207
        '
        Me.Label207.AutoSize = True
        Me.Label207.Location = New System.Drawing.Point(250, 15)
        Me.Label207.Name = "Label207"
        Me.Label207.Size = New System.Drawing.Size(89, 13)
        Me.Label207.TabIndex = 13
        Me.Label207.Text = "Cartesian Format:"
        '
        'chkDmsSymbols
        '
        Me.chkDmsSymbols.AutoSize = True
        Me.chkDmsSymbols.Location = New System.Drawing.Point(282, 66)
        Me.chkDmsSymbols.Name = "chkDmsSymbols"
        Me.chkDmsSymbols.Size = New System.Drawing.Size(92, 17)
        Me.chkDmsSymbols.TabIndex = 12
        Me.chkDmsSymbols.Text = "DMS Symbols"
        Me.chkDmsSymbols.UseVisualStyleBackColor = True
        '
        'txtProjFormat
        '
        Me.txtProjFormat.Location = New System.Drawing.Point(152, 12)
        Me.txtProjFormat.Name = "txtProjFormat"
        Me.txtProjFormat.Size = New System.Drawing.Size(50, 20)
        Me.txtProjFormat.TabIndex = 5
        '
        'txtSecondsDecPlaces
        '
        Me.txtSecondsDecPlaces.Location = New System.Drawing.Point(208, 64)
        Me.txtSecondsDecPlaces.Name = "txtSecondsDecPlaces"
        Me.txtSecondsDecPlaces.Size = New System.Drawing.Size(50, 20)
        Me.txtSecondsDecPlaces.TabIndex = 11
        '
        'Label204
        '
        Me.Label204.AutoSize = True
        Me.Label204.Location = New System.Drawing.Point(56, 15)
        Me.Label204.Name = "Label204"
        Me.Label204.Size = New System.Drawing.Size(90, 13)
        Me.Label204.TabIndex = 4
        Me.Label204.Text = "Projected Format:"
        '
        'txtDegreeDecPlaces
        '
        Me.txtDegreeDecPlaces.Location = New System.Drawing.Point(208, 38)
        Me.txtDegreeDecPlaces.Name = "txtDegreeDecPlaces"
        Me.txtDegreeDecPlaces.Size = New System.Drawing.Size(50, 20)
        Me.txtDegreeDecPlaces.TabIndex = 10
        '
        'rbDecDegrees
        '
        Me.rbDecDegrees.AutoSize = True
        Me.rbDecDegrees.Location = New System.Drawing.Point(7, 39)
        Me.rbDecDegrees.Name = "rbDecDegrees"
        Me.rbDecDegrees.Size = New System.Drawing.Size(106, 17)
        Me.rbDecDegrees.TabIndex = 6
        Me.rbDecDegrees.TabStop = True
        Me.rbDecDegrees.Text = "Decimal Degrees"
        Me.rbDecDegrees.UseVisualStyleBackColor = True
        '
        'Label206
        '
        Me.Label206.AutoSize = True
        Me.Label206.Location = New System.Drawing.Point(119, 67)
        Me.Label206.Name = "Label206"
        Me.Label206.Size = New System.Drawing.Size(83, 13)
        Me.Label206.TabIndex = 9
        Me.Label206.Text = "Decimal Places:"
        '
        'rbDMS
        '
        Me.rbDMS.AutoSize = True
        Me.rbDMS.Location = New System.Drawing.Point(7, 65)
        Me.rbDMS.Name = "rbDMS"
        Me.rbDMS.Size = New System.Drawing.Size(87, 17)
        Me.rbDMS.TabIndex = 7
        Me.rbDMS.TabStop = True
        Me.rbDMS.Text = "Deg Min Sec"
        Me.rbDMS.UseVisualStyleBackColor = True
        '
        'Label205
        '
        Me.Label205.AutoSize = True
        Me.Label205.Location = New System.Drawing.Point(119, 41)
        Me.Label205.Name = "Label205"
        Me.Label205.Size = New System.Drawing.Size(83, 13)
        Me.Label205.TabIndex = 8
        Me.Label205.Text = "Decimal Places:"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.udPointFontSize)
        Me.GroupBox17.Controls.Add(Me.Label51)
        Me.GroupBox17.Controls.Add(Me.chkShowOutputXYZ)
        Me.GroupBox17.Controls.Add(Me.chkShowOutputLongLat)
        Me.GroupBox17.Controls.Add(Me.chkShowOutputEastNorth)
        Me.GroupBox17.Controls.Add(Me.chkShowWgs84XYZ)
        Me.GroupBox17.Controls.Add(Me.chkShowInputXYZ)
        Me.GroupBox17.Controls.Add(Me.chkShowInputLongLat)
        Me.GroupBox17.Controls.Add(Me.chkShowInputEastNorth)
        Me.GroupBox17.Location = New System.Drawing.Point(226, 6)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(414, 95)
        Me.GroupBox17.TabIndex = 4
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Show Coordinate:"
        '
        'udPointFontSize
        '
        Me.udPointFontSize.Location = New System.Drawing.Point(174, 69)
        Me.udPointFontSize.Name = "udPointFontSize"
        Me.udPointFontSize.Size = New System.Drawing.Size(72, 20)
        Me.udPointFontSize.TabIndex = 44
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(116, 72)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(52, 13)
        Me.Label51.TabIndex = 43
        Me.Label51.Text = "Font size:"
        '
        'chkShowOutputXYZ
        '
        Me.chkShowOutputXYZ.AutoSize = True
        Me.chkShowOutputXYZ.Location = New System.Drawing.Point(256, 66)
        Me.chkShowOutputXYZ.Name = "chkShowOutputXYZ"
        Me.chkShowOutputXYZ.Size = New System.Drawing.Size(88, 17)
        Me.chkShowOutputXYZ.TabIndex = 6
        Me.chkShowOutputXYZ.Text = "Output X Y Z"
        Me.chkShowOutputXYZ.UseVisualStyleBackColor = True
        '
        'chkShowOutputLongLat
        '
        Me.chkShowOutputLongLat.AutoSize = True
        Me.chkShowOutputLongLat.Location = New System.Drawing.Point(256, 42)
        Me.chkShowOutputLongLat.Name = "chkShowOutputLongLat"
        Me.chkShowOutputLongLat.Size = New System.Drawing.Size(149, 17)
        Me.chkShowOutputLongLat.TabIndex = 5
        Me.chkShowOutputLongLat.Text = "Output Longitude Latitude"
        Me.chkShowOutputLongLat.UseVisualStyleBackColor = True
        '
        'chkShowOutputEastNorth
        '
        Me.chkShowOutputEastNorth.AutoSize = True
        Me.chkShowOutputEastNorth.Location = New System.Drawing.Point(256, 19)
        Me.chkShowOutputEastNorth.Name = "chkShowOutputEastNorth"
        Me.chkShowOutputEastNorth.Size = New System.Drawing.Size(139, 17)
        Me.chkShowOutputEastNorth.TabIndex = 4
        Me.chkShowOutputEastNorth.Text = "Output Easting Northing"
        Me.chkShowOutputEastNorth.UseVisualStyleBackColor = True
        '
        'chkShowWgs84XYZ
        '
        Me.chkShowWgs84XYZ.AutoSize = True
        Me.chkShowWgs84XYZ.Location = New System.Drawing.Point(153, 42)
        Me.chkShowWgs84XYZ.Name = "chkShowWgs84XYZ"
        Me.chkShowWgs84XYZ.Size = New System.Drawing.Size(97, 17)
        Me.chkShowWgs84XYZ.TabIndex = 3
        Me.chkShowWgs84XYZ.Text = "WGS 84 X Y Z"
        Me.chkShowWgs84XYZ.UseVisualStyleBackColor = True
        '
        'chkShowInputXYZ
        '
        Me.chkShowInputXYZ.AutoSize = True
        Me.chkShowInputXYZ.Location = New System.Drawing.Point(6, 66)
        Me.chkShowInputXYZ.Name = "chkShowInputXYZ"
        Me.chkShowInputXYZ.Size = New System.Drawing.Size(80, 17)
        Me.chkShowInputXYZ.TabIndex = 2
        Me.chkShowInputXYZ.Text = "Input X Y Z"
        Me.chkShowInputXYZ.UseVisualStyleBackColor = True
        '
        'chkShowInputLongLat
        '
        Me.chkShowInputLongLat.AutoSize = True
        Me.chkShowInputLongLat.Location = New System.Drawing.Point(6, 43)
        Me.chkShowInputLongLat.Name = "chkShowInputLongLat"
        Me.chkShowInputLongLat.Size = New System.Drawing.Size(141, 17)
        Me.chkShowInputLongLat.TabIndex = 1
        Me.chkShowInputLongLat.Text = "Input Longitude Latitude"
        Me.chkShowInputLongLat.UseVisualStyleBackColor = True
        '
        'chkShowInputEastNorth
        '
        Me.chkShowInputEastNorth.AutoSize = True
        Me.chkShowInputEastNorth.Location = New System.Drawing.Point(6, 20)
        Me.chkShowInputEastNorth.Name = "chkShowInputEastNorth"
        Me.chkShowInputEastNorth.Size = New System.Drawing.Size(131, 17)
        Me.chkShowInputEastNorth.TabIndex = 0
        Me.chkShowInputEastNorth.Text = "Input Easting Northing"
        Me.chkShowInputEastNorth.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.rbEnterInputXYZ)
        Me.GroupBox16.Controls.Add(Me.rbEnterInputLongLat)
        Me.GroupBox16.Controls.Add(Me.rbEnterInputEastNorth)
        Me.GroupBox16.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(214, 95)
        Me.GroupBox16.TabIndex = 3
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Entry Coordinate:"
        '
        'rbEnterInputXYZ
        '
        Me.rbEnterInputXYZ.AutoSize = True
        Me.rbEnterInputXYZ.Location = New System.Drawing.Point(6, 65)
        Me.rbEnterInputXYZ.Name = "rbEnterInputXYZ"
        Me.rbEnterInputXYZ.Size = New System.Drawing.Size(126, 17)
        Me.rbEnterInputXYZ.TabIndex = 4
        Me.rbEnterInputXYZ.TabStop = True
        Me.rbEnterInputXYZ.Text = "Input Cartesian X Y Z"
        Me.rbEnterInputXYZ.UseVisualStyleBackColor = True
        '
        'rbEnterInputLongLat
        '
        Me.rbEnterInputLongLat.AutoSize = True
        Me.rbEnterInputLongLat.Location = New System.Drawing.Point(6, 42)
        Me.rbEnterInputLongLat.Name = "rbEnterInputLongLat"
        Me.rbEnterInputLongLat.Size = New System.Drawing.Size(198, 17)
        Me.rbEnterInputLongLat.TabIndex = 3
        Me.rbEnterInputLongLat.TabStop = True
        Me.rbEnterInputLongLat.Text = "Input Geographic Longitude Latitude"
        Me.rbEnterInputLongLat.UseVisualStyleBackColor = True
        '
        'rbEnterInputEastNorth
        '
        Me.rbEnterInputEastNorth.AutoSize = True
        Me.rbEnterInputEastNorth.Location = New System.Drawing.Point(6, 19)
        Me.rbEnterInputEastNorth.Name = "rbEnterInputEastNorth"
        Me.rbEnterInputEastNorth.Size = New System.Drawing.Size(178, 17)
        Me.rbEnterInputEastNorth.TabIndex = 2
        Me.rbEnterInputEastNorth.TabStop = True
        Me.rbEnterInputEastNorth.Text = "Input Projected Easting Northing"
        Me.rbEnterInputEastNorth.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.btnApplyConvSettings)
        Me.TabPage7.Controls.Add(Me.btnCheckConnection)
        Me.TabPage7.Controls.Add(Me.txtWgs84ToOutputDatumTransOpApplyRev)
        Me.TabPage7.Controls.Add(Me.Label28)
        Me.TabPage7.Controls.Add(Me.Label29)
        Me.TabPage7.Controls.Add(Me.Label30)
        Me.TabPage7.Controls.Add(Me.txtWgs84ToOutputDatumTransOpCode)
        Me.TabPage7.Controls.Add(Me.txtWgs84ToOutputDatumTransOpName)
        Me.TabPage7.Controls.Add(Me.btnRecalculate)
        Me.TabPage7.Controls.Add(Me.txtInputToWgs84DatumTransOpApplyRev)
        Me.TabPage7.Controls.Add(Me.lblDatumTransApplyRev2)
        Me.TabPage7.Controls.Add(Me.lblDatumTransCode2)
        Me.TabPage7.Controls.Add(Me.lblInputToWgs84DatumTransName)
        Me.TabPage7.Controls.Add(Me.txtDirectDatumTransOpApplyRev)
        Me.TabPage7.Controls.Add(Me.lblDatumTransApplyRev1)
        Me.TabPage7.Controls.Add(Me.lblDatumTransCode1)
        Me.TabPage7.Controls.Add(Me.lblDirectDatumTransName)
        Me.TabPage7.Controls.Add(Me.Label27)
        Me.TabPage7.Controls.Add(Me.Label26)
        Me.TabPage7.Controls.Add(Me.Label25)
        Me.TabPage7.Controls.Add(Me.Label24)
        Me.TabPage7.Controls.Add(Me.Label23)
        Me.TabPage7.Controls.Add(Me.Label22)
        Me.TabPage7.Controls.Add(Me.Label21)
        Me.TabPage7.Controls.Add(Me.txtInputCrsKind)
        Me.TabPage7.Controls.Add(Me.txtOutputCrsKind)
        Me.TabPage7.Controls.Add(Me.dgvConversion)
        Me.TabPage7.Controls.Add(Me.txtDatumTransType)
        Me.TabPage7.Controls.Add(Me.txtInputToWgs84DatumTransOpCode)
        Me.TabPage7.Controls.Add(Me.txtInputToWgs84DatumTransOpName)
        Me.TabPage7.Controls.Add(Me.txtDirectDatumTransOpCode)
        Me.TabPage7.Controls.Add(Me.txtDirectDatumTransOpName)
        Me.TabPage7.Controls.Add(Me.Label142)
        Me.TabPage7.Controls.Add(Me.txtOutputCrsCode)
        Me.TabPage7.Controls.Add(Me.txtInputCrsCode)
        Me.TabPage7.Controls.Add(Me.txtOutputCrsName)
        Me.TabPage7.Controls.Add(Me.Label185)
        Me.TabPage7.Controls.Add(Me.txtInputCrsName)
        Me.TabPage7.Controls.Add(Me.Label184)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1203, 457)
        Me.TabPage7.TabIndex = 3
        Me.TabPage7.Text = "Point Conversion"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'btnApplyConvSettings
        '
        Me.btnApplyConvSettings.Location = New System.Drawing.Point(894, 32)
        Me.btnApplyConvSettings.Name = "btnApplyConvSettings"
        Me.btnApplyConvSettings.Size = New System.Drawing.Size(140, 22)
        Me.btnApplyConvSettings.TabIndex = 357
        Me.btnApplyConvSettings.Text = "Apply Conversion Settings"
        Me.btnApplyConvSettings.UseVisualStyleBackColor = True
        '
        'btnCheckConnection
        '
        Me.btnCheckConnection.Location = New System.Drawing.Point(1040, 4)
        Me.btnCheckConnection.Name = "btnCheckConnection"
        Me.btnCheckConnection.Size = New System.Drawing.Size(111, 22)
        Me.btnCheckConnection.TabIndex = 356
        Me.btnCheckConnection.Text = "Check Connection"
        Me.btnCheckConnection.UseVisualStyleBackColor = True
        '
        'txtWgs84ToOutputDatumTransOpApplyRev
        '
        Me.txtWgs84ToOutputDatumTransOpApplyRev.Location = New System.Drawing.Point(1073, 84)
        Me.txtWgs84ToOutputDatumTransOpApplyRev.Name = "txtWgs84ToOutputDatumTransOpApplyRev"
        Me.txtWgs84ToOutputDatumTransOpApplyRev.ReadOnly = True
        Me.txtWgs84ToOutputDatumTransOpApplyRev.Size = New System.Drawing.Size(45, 20)
        Me.txtWgs84ToOutputDatumTransOpApplyRev.TabIndex = 355
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(993, 87)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 13)
        Me.Label28.TabIndex = 354
        Me.Label28.Text = "Apply reverse:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(901, 87)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(35, 13)
        Me.Label29.TabIndex = 353
        Me.Label29.Text = "Code:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(564, 87)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(125, 13)
        Me.Label30.TabIndex = 352
        Me.Label30.Text = "WGS 84 to output name:"
        '
        'txtWgs84ToOutputDatumTransOpCode
        '
        Me.txtWgs84ToOutputDatumTransOpCode.Location = New System.Drawing.Point(942, 84)
        Me.txtWgs84ToOutputDatumTransOpCode.Name = "txtWgs84ToOutputDatumTransOpCode"
        Me.txtWgs84ToOutputDatumTransOpCode.ReadOnly = True
        Me.txtWgs84ToOutputDatumTransOpCode.Size = New System.Drawing.Size(45, 20)
        Me.txtWgs84ToOutputDatumTransOpCode.TabIndex = 351
        '
        'txtWgs84ToOutputDatumTransOpName
        '
        Me.txtWgs84ToOutputDatumTransOpName.Location = New System.Drawing.Point(695, 84)
        Me.txtWgs84ToOutputDatumTransOpName.Name = "txtWgs84ToOutputDatumTransOpName"
        Me.txtWgs84ToOutputDatumTransOpName.ReadOnly = True
        Me.txtWgs84ToOutputDatumTransOpName.Size = New System.Drawing.Size(200, 20)
        Me.txtWgs84ToOutputDatumTransOpName.TabIndex = 350
        '
        'btnRecalculate
        '
        Me.btnRecalculate.Location = New System.Drawing.Point(894, 4)
        Me.btnRecalculate.Name = "btnRecalculate"
        Me.btnRecalculate.Size = New System.Drawing.Size(140, 22)
        Me.btnRecalculate.TabIndex = 349
        Me.btnRecalculate.Text = "Recalculate Coordinates"
        Me.btnRecalculate.UseVisualStyleBackColor = True
        '
        'txtInputToWgs84DatumTransOpApplyRev
        '
        Me.txtInputToWgs84DatumTransOpApplyRev.Location = New System.Drawing.Point(513, 84)
        Me.txtInputToWgs84DatumTransOpApplyRev.Name = "txtInputToWgs84DatumTransOpApplyRev"
        Me.txtInputToWgs84DatumTransOpApplyRev.ReadOnly = True
        Me.txtInputToWgs84DatumTransOpApplyRev.Size = New System.Drawing.Size(45, 20)
        Me.txtInputToWgs84DatumTransOpApplyRev.TabIndex = 149
        '
        'lblDatumTransApplyRev2
        '
        Me.lblDatumTransApplyRev2.AutoSize = True
        Me.lblDatumTransApplyRev2.Location = New System.Drawing.Point(433, 87)
        Me.lblDatumTransApplyRev2.Name = "lblDatumTransApplyRev2"
        Me.lblDatumTransApplyRev2.Size = New System.Drawing.Size(74, 13)
        Me.lblDatumTransApplyRev2.TabIndex = 148
        Me.lblDatumTransApplyRev2.Text = "Apply reverse:"
        '
        'lblDatumTransCode2
        '
        Me.lblDatumTransCode2.AutoSize = True
        Me.lblDatumTransCode2.Location = New System.Drawing.Point(341, 87)
        Me.lblDatumTransCode2.Name = "lblDatumTransCode2"
        Me.lblDatumTransCode2.Size = New System.Drawing.Size(35, 13)
        Me.lblDatumTransCode2.TabIndex = 147
        Me.lblDatumTransCode2.Text = "Code:"
        '
        'lblInputToWgs84DatumTransName
        '
        Me.lblInputToWgs84DatumTransName.AutoSize = True
        Me.lblInputToWgs84DatumTransName.Location = New System.Drawing.Point(10, 87)
        Me.lblInputToWgs84DatumTransName.Name = "lblInputToWgs84DatumTransName"
        Me.lblInputToWgs84DatumTransName.Size = New System.Drawing.Size(119, 13)
        Me.lblInputToWgs84DatumTransName.TabIndex = 146
        Me.lblInputToWgs84DatumTransName.Text = "Input to WGS 84 name:"
        '
        'txtDirectDatumTransOpApplyRev
        '
        Me.txtDirectDatumTransOpApplyRev.Location = New System.Drawing.Point(715, 58)
        Me.txtDirectDatumTransOpApplyRev.Name = "txtDirectDatumTransOpApplyRev"
        Me.txtDirectDatumTransOpApplyRev.ReadOnly = True
        Me.txtDirectDatumTransOpApplyRev.Size = New System.Drawing.Size(45, 20)
        Me.txtDirectDatumTransOpApplyRev.TabIndex = 145
        '
        'lblDatumTransApplyRev1
        '
        Me.lblDatumTransApplyRev1.AutoSize = True
        Me.lblDatumTransApplyRev1.Location = New System.Drawing.Point(635, 61)
        Me.lblDatumTransApplyRev1.Name = "lblDatumTransApplyRev1"
        Me.lblDatumTransApplyRev1.Size = New System.Drawing.Size(74, 13)
        Me.lblDatumTransApplyRev1.TabIndex = 144
        Me.lblDatumTransApplyRev1.Text = "Apply reverse:"
        '
        'lblDatumTransCode1
        '
        Me.lblDatumTransCode1.AutoSize = True
        Me.lblDatumTransCode1.Location = New System.Drawing.Point(543, 61)
        Me.lblDatumTransCode1.Name = "lblDatumTransCode1"
        Me.lblDatumTransCode1.Size = New System.Drawing.Size(35, 13)
        Me.lblDatumTransCode1.TabIndex = 143
        Me.lblDatumTransCode1.Text = "Code:"
        '
        'lblDirectDatumTransName
        '
        Me.lblDirectDatumTransName.AutoSize = True
        Me.lblDirectDatumTransName.Location = New System.Drawing.Point(217, 61)
        Me.lblDirectDatumTransName.Name = "lblDirectDatumTransName"
        Me.lblDirectDatumTransName.Size = New System.Drawing.Size(114, 13)
        Me.lblDirectDatumTransName.TabIndex = 142
        Me.lblDirectDatumTransName.Text = "Direct operation name:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(771, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 13)
        Me.Label27.TabIndex = 141
        Me.Label27.Text = "Kind:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(664, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 13)
        Me.Label26.TabIndex = 140
        Me.Label26.Text = "Code:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(771, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 13)
        Me.Label25.TabIndex = 139
        Me.Label25.Text = "Kind:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(664, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 13)
        Me.Label24.TabIndex = 138
        Me.Label24.Text = "Code:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(194, 35)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 13)
        Me.Label23.TabIndex = 137
        Me.Label23.Text = "Name:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(194, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 136
        Me.Label22.Text = "Name:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(126, 61)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 135
        Me.Label21.Text = "Type:"
        '
        'txtInputCrsKind
        '
        Me.txtInputCrsKind.Location = New System.Drawing.Point(808, 6)
        Me.txtInputCrsKind.Name = "txtInputCrsKind"
        Me.txtInputCrsKind.ReadOnly = True
        Me.txtInputCrsKind.Size = New System.Drawing.Size(80, 20)
        Me.txtInputCrsKind.TabIndex = 134
        '
        'txtOutputCrsKind
        '
        Me.txtOutputCrsKind.Location = New System.Drawing.Point(808, 32)
        Me.txtOutputCrsKind.Name = "txtOutputCrsKind"
        Me.txtOutputCrsKind.ReadOnly = True
        Me.txtOutputCrsKind.Size = New System.Drawing.Size(80, 20)
        Me.txtOutputCrsKind.TabIndex = 133
        '
        'dgvConversion
        '
        Me.dgvConversion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConversion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConversion.Location = New System.Drawing.Point(3, 110)
        Me.dgvConversion.Name = "dgvConversion"
        Me.dgvConversion.Size = New System.Drawing.Size(1197, 344)
        Me.dgvConversion.TabIndex = 132
        '
        'txtDatumTransType
        '
        Me.txtDatumTransType.Location = New System.Drawing.Point(166, 58)
        Me.txtDatumTransType.Name = "txtDatumTransType"
        Me.txtDatumTransType.ReadOnly = True
        Me.txtDatumTransType.Size = New System.Drawing.Size(45, 20)
        Me.txtDatumTransType.TabIndex = 131
        '
        'txtInputToWgs84DatumTransOpCode
        '
        Me.txtInputToWgs84DatumTransOpCode.Location = New System.Drawing.Point(382, 84)
        Me.txtInputToWgs84DatumTransOpCode.Name = "txtInputToWgs84DatumTransOpCode"
        Me.txtInputToWgs84DatumTransOpCode.ReadOnly = True
        Me.txtInputToWgs84DatumTransOpCode.Size = New System.Drawing.Size(45, 20)
        Me.txtInputToWgs84DatumTransOpCode.TabIndex = 130
        '
        'txtInputToWgs84DatumTransOpName
        '
        Me.txtInputToWgs84DatumTransOpName.Location = New System.Drawing.Point(135, 84)
        Me.txtInputToWgs84DatumTransOpName.Name = "txtInputToWgs84DatumTransOpName"
        Me.txtInputToWgs84DatumTransOpName.ReadOnly = True
        Me.txtInputToWgs84DatumTransOpName.Size = New System.Drawing.Size(200, 20)
        Me.txtInputToWgs84DatumTransOpName.TabIndex = 129
        '
        'txtDirectDatumTransOpCode
        '
        Me.txtDirectDatumTransOpCode.Location = New System.Drawing.Point(584, 58)
        Me.txtDirectDatumTransOpCode.Name = "txtDirectDatumTransOpCode"
        Me.txtDirectDatumTransOpCode.ReadOnly = True
        Me.txtDirectDatumTransOpCode.Size = New System.Drawing.Size(45, 20)
        Me.txtDirectDatumTransOpCode.TabIndex = 128
        '
        'txtDirectDatumTransOpName
        '
        Me.txtDirectDatumTransOpName.Location = New System.Drawing.Point(337, 58)
        Me.txtDirectDatumTransOpName.Name = "txtDirectDatumTransOpName"
        Me.txtDirectDatumTransOpName.ReadOnly = True
        Me.txtDirectDatumTransOpName.Size = New System.Drawing.Size(200, 20)
        Me.txtDirectDatumTransOpName.TabIndex = 127
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Location = New System.Drawing.Point(10, 61)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(110, 13)
        Me.Label142.TabIndex = 126
        Me.Label142.Text = "Datum transformation:"
        '
        'txtOutputCrsCode
        '
        Me.txtOutputCrsCode.Location = New System.Drawing.Point(705, 32)
        Me.txtOutputCrsCode.Name = "txtOutputCrsCode"
        Me.txtOutputCrsCode.ReadOnly = True
        Me.txtOutputCrsCode.Size = New System.Drawing.Size(60, 20)
        Me.txtOutputCrsCode.TabIndex = 125
        '
        'txtInputCrsCode
        '
        Me.txtInputCrsCode.Location = New System.Drawing.Point(705, 6)
        Me.txtInputCrsCode.Name = "txtInputCrsCode"
        Me.txtInputCrsCode.ReadOnly = True
        Me.txtInputCrsCode.Size = New System.Drawing.Size(60, 20)
        Me.txtInputCrsCode.TabIndex = 124
        '
        'txtOutputCrsName
        '
        Me.txtOutputCrsName.Location = New System.Drawing.Point(238, 32)
        Me.txtOutputCrsName.Name = "txtOutputCrsName"
        Me.txtOutputCrsName.ReadOnly = True
        Me.txtOutputCrsName.Size = New System.Drawing.Size(420, 20)
        Me.txtOutputCrsName.TabIndex = 123
        '
        'Label185
        '
        Me.Label185.AutoSize = True
        Me.Label185.Location = New System.Drawing.Point(10, 35)
        Me.Label185.Name = "Label185"
        Me.Label185.Size = New System.Drawing.Size(178, 13)
        Me.Label185.TabIndex = 122
        Me.Label185.Text = "Output coordinate reference system:"
        '
        'txtInputCrsName
        '
        Me.txtInputCrsName.Location = New System.Drawing.Point(238, 6)
        Me.txtInputCrsName.Name = "txtInputCrsName"
        Me.txtInputCrsName.ReadOnly = True
        Me.txtInputCrsName.Size = New System.Drawing.Size(420, 20)
        Me.txtInputCrsName.TabIndex = 121
        '
        'Label184
        '
        Me.Label184.AutoSize = True
        Me.Label184.Location = New System.Drawing.Point(10, 9)
        Me.Label184.Name = "Label184"
        Me.Label184.Size = New System.Drawing.Size(170, 13)
        Me.Label184.TabIndex = 120
        Me.Label184.Text = "Input coordinate reference system:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnOpenParentDir)
        Me.TabPage2.Controls.Add(Me.btnOpenArchive)
        Me.TabPage2.Controls.Add(Me.btnCreateArchive)
        Me.TabPage2.Controls.Add(Me.btnShowProjectInfo)
        Me.TabPage2.Controls.Add(Me.chkConnect)
        Me.TabPage2.Controls.Add(Me.btnOpenProject)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtProjectPath)
        Me.TabPage2.Controls.Add(Me.txtProNetName)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.btnOpenAppDir)
        Me.TabPage2.Controls.Add(Me.btnOpenSystem)
        Me.TabPage2.Controls.Add(Me.btnOpenData)
        Me.TabPage2.Controls.Add(Me.btnOpenSettings)
        Me.TabPage2.Controls.Add(Me.btnParameters)
        Me.TabPage2.Controls.Add(Me.txtParentProject)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.Label80)
        Me.TabPage2.Controls.Add(Me.btnAdd)
        Me.TabPage2.Controls.Add(Me.txtSystemLocationType)
        Me.TabPage2.Controls.Add(Me.txtSystemPath)
        Me.TabPage2.Controls.Add(Me.txtCurrentDuration)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtTotalDuration)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txtLastUsed)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtCreationDate)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtDataPath)
        Me.TabPage2.Controls.Add(Me.txtDataLocationType)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtSettingsPath)
        Me.TabPage2.Controls.Add(Me.txtSettingsLocationType)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtProjectType)
        Me.TabPage2.Controls.Add(Me.txtProjectDescription)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtProjectName)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btnProject)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1220, 523)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Project Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnOpenParentDir
        '
        Me.btnOpenParentDir.Location = New System.Drawing.Point(125, 396)
        Me.btnOpenParentDir.Name = "btnOpenParentDir"
        Me.btnOpenParentDir.Size = New System.Drawing.Size(125, 22)
        Me.btnOpenParentDir.TabIndex = 307
        Me.btnOpenParentDir.Text = "Open Parent Directory"
        Me.ToolTip1.SetToolTip(Me.btnOpenParentDir, "Open the Parent directory")
        Me.btnOpenParentDir.UseVisualStyleBackColor = True
        '
        'btnOpenArchive
        '
        Me.btnOpenArchive.Location = New System.Drawing.Point(354, 396)
        Me.btnOpenArchive.Name = "btnOpenArchive"
        Me.btnOpenArchive.Size = New System.Drawing.Size(94, 22)
        Me.btnOpenArchive.TabIndex = 306
        Me.btnOpenArchive.Text = "Open Archive"
        Me.ToolTip1.SetToolTip(Me.btnOpenArchive, "Open a project archive file")
        Me.btnOpenArchive.UseVisualStyleBackColor = True
        '
        'btnCreateArchive
        '
        Me.btnCreateArchive.Location = New System.Drawing.Point(256, 396)
        Me.btnCreateArchive.Name = "btnCreateArchive"
        Me.btnCreateArchive.Size = New System.Drawing.Size(92, 22)
        Me.btnCreateArchive.TabIndex = 305
        Me.btnCreateArchive.Text = "Create Archive"
        Me.ToolTip1.SetToolTip(Me.btnCreateArchive, "Create a project archive file")
        Me.btnCreateArchive.UseVisualStyleBackColor = True
        '
        'btnShowProjectInfo
        '
        Me.btnShowProjectInfo.Location = New System.Drawing.Point(6, 396)
        Me.btnShowProjectInfo.Name = "btnShowProjectInfo"
        Me.btnShowProjectInfo.Size = New System.Drawing.Size(113, 22)
        Me.btnShowProjectInfo.TabIndex = 304
        Me.btnShowProjectInfo.Text = "Show Project Info"
        Me.btnShowProjectInfo.UseVisualStyleBackColor = True
        '
        'chkConnect
        '
        Me.chkConnect.AutoSize = True
        Me.chkConnect.Location = New System.Drawing.Point(419, 136)
        Me.chkConnect.Name = "chkConnect"
        Me.chkConnect.Size = New System.Drawing.Size(112, 17)
        Me.chkConnect.TabIndex = 303
        Me.chkConnect.Text = "Connect On Open"
        Me.chkConnect.UseVisualStyleBackColor = True
        '
        'btnOpenProject
        '
        Me.btnOpenProject.Location = New System.Drawing.Point(84, 177)
        Me.btnOpenProject.Name = "btnOpenProject"
        Me.btnOpenProject.Size = New System.Drawing.Size(48, 22)
        Me.btnOpenProject.TabIndex = 302
        Me.btnOpenProject.Text = "Open"
        Me.btnOpenProject.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 163)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 301
        Me.Label13.Text = "Project path:"
        '
        'txtProjectPath
        '
        Me.txtProjectPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProjectPath.Location = New System.Drawing.Point(137, 160)
        Me.txtProjectPath.Multiline = True
        Me.txtProjectPath.Name = "txtProjectPath"
        Me.txtProjectPath.Size = New System.Drawing.Size(555, 46)
        Me.txtProjectPath.TabIndex = 300
        '
        'txtProNetName
        '
        Me.txtProNetName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProNetName.Location = New System.Drawing.Point(281, 34)
        Me.txtProNetName.Name = "txtProNetName"
        Me.txtProNetName.Size = New System.Drawing.Size(411, 20)
        Me.txtProNetName.TabIndex = 299
        Me.ToolTip1.SetToolTip(Me.txtProNetName, "The name of the Application Network containing this project")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(172, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 298
        Me.Label9.Text = "Project network:"
        '
        'btnOpenAppDir
        '
        Me.btnOpenAppDir.Location = New System.Drawing.Point(6, 368)
        Me.btnOpenAppDir.Name = "btnOpenAppDir"
        Me.btnOpenAppDir.Size = New System.Drawing.Size(150, 22)
        Me.btnOpenAppDir.TabIndex = 297
        Me.btnOpenAppDir.Text = "Open Application Directory"
        Me.btnOpenAppDir.UseVisualStyleBackColor = True
        '
        'btnOpenSystem
        '
        Me.btnOpenSystem.Location = New System.Drawing.Point(84, 335)
        Me.btnOpenSystem.Name = "btnOpenSystem"
        Me.btnOpenSystem.Size = New System.Drawing.Size(48, 22)
        Me.btnOpenSystem.TabIndex = 294
        Me.btnOpenSystem.Text = "Open"
        Me.btnOpenSystem.UseVisualStyleBackColor = True
        '
        'btnOpenData
        '
        Me.btnOpenData.Location = New System.Drawing.Point(84, 283)
        Me.btnOpenData.Name = "btnOpenData"
        Me.btnOpenData.Size = New System.Drawing.Size(48, 22)
        Me.btnOpenData.TabIndex = 293
        Me.btnOpenData.Text = "Open"
        Me.btnOpenData.UseVisualStyleBackColor = True
        '
        'btnOpenSettings
        '
        Me.btnOpenSettings.Location = New System.Drawing.Point(84, 231)
        Me.btnOpenSettings.Name = "btnOpenSettings"
        Me.btnOpenSettings.Size = New System.Drawing.Size(48, 22)
        Me.btnOpenSettings.TabIndex = 292
        Me.btnOpenSettings.Text = "Open"
        Me.btnOpenSettings.UseVisualStyleBackColor = True
        '
        'btnParameters
        '
        Me.btnParameters.Location = New System.Drawing.Point(84, 6)
        Me.btnParameters.Name = "btnParameters"
        Me.btnParameters.Size = New System.Drawing.Size(72, 22)
        Me.btnParameters.TabIndex = 284
        Me.btnParameters.Text = "Parameters"
        Me.btnParameters.UseVisualStyleBackColor = True
        '
        'txtParentProject
        '
        Me.txtParentProject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParentProject.Location = New System.Drawing.Point(281, 8)
        Me.txtParentProject.Name = "txtParentProject"
        Me.txtParentProject.Size = New System.Drawing.Size(411, 20)
        Me.txtParentProject.TabIndex = 283
        Me.ToolTip1.SetToolTip(Me.txtParentProject, "The name of the Parent project containing this project")
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(172, 11)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(76, 13)
        Me.Label45.TabIndex = 282
        Me.Label45.Text = "Parent project:"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(6, 319)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(68, 13)
        Me.Label80.TabIndex = 87
        Me.Label80.Text = "System path:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(6, 34)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(150, 22)
        Me.btnAdd.TabIndex = 281
        Me.btnAdd.Text = "Add to Message Service"
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Add selected project to the Message Service list")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSystemLocationType
        '
        Me.txtSystemLocationType.Location = New System.Drawing.Point(6, 335)
        Me.txtSystemLocationType.Name = "txtSystemLocationType"
        Me.txtSystemLocationType.Size = New System.Drawing.Size(72, 20)
        Me.txtSystemLocationType.TabIndex = 85
        '
        'txtSystemPath
        '
        Me.txtSystemPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSystemPath.Location = New System.Drawing.Point(137, 316)
        Me.txtSystemPath.Multiline = True
        Me.txtSystemPath.Name = "txtSystemPath"
        Me.txtSystemPath.Size = New System.Drawing.Size(555, 46)
        Me.txtSystemPath.TabIndex = 84
        '
        'txtCurrentDuration
        '
        Me.txtCurrentDuration.Location = New System.Drawing.Point(480, 368)
        Me.txtCurrentDuration.Name = "txtCurrentDuration"
        Me.txtCurrentDuration.Size = New System.Drawing.Size(120, 20)
        Me.txtCurrentDuration.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(430, 373)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Current:"
        '
        'txtTotalDuration
        '
        Me.txtTotalDuration.Location = New System.Drawing.Point(283, 370)
        Me.txtTotalDuration.Name = "txtTotalDuration"
        Me.txtTotalDuration.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalDuration.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Project usage:"
        '
        'txtLastUsed
        '
        Me.txtLastUsed.Location = New System.Drawing.Point(281, 134)
        Me.txtLastUsed.Name = "txtLastUsed"
        Me.txtLastUsed.Size = New System.Drawing.Size(120, 20)
        Me.txtLastUsed.TabIndex = 65
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(219, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Last used:"
        '
        'txtCreationDate
        '
        Me.txtCreationDate.Location = New System.Drawing.Point(85, 134)
        Me.txtCreationDate.Name = "txtCreationDate"
        Me.txtCreationDate.Size = New System.Drawing.Size(120, 20)
        Me.txtCreationDate.TabIndex = 63
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Creation date:"
        '
        'txtDataPath
        '
        Me.txtDataPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataPath.Location = New System.Drawing.Point(137, 264)
        Me.txtDataPath.Multiline = True
        Me.txtDataPath.Name = "txtDataPath"
        Me.txtDataPath.Size = New System.Drawing.Size(555, 46)
        Me.txtDataPath.TabIndex = 61
        '
        'txtDataLocationType
        '
        Me.txtDataLocationType.Location = New System.Drawing.Point(6, 283)
        Me.txtDataLocationType.Name = "txtDataLocationType"
        Me.txtDataLocationType.Size = New System.Drawing.Size(72, 20)
        Me.txtDataLocationType.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Data path:"
        '
        'txtSettingsPath
        '
        Me.txtSettingsPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSettingsPath.Location = New System.Drawing.Point(137, 212)
        Me.txtSettingsPath.Multiline = True
        Me.txtSettingsPath.Name = "txtSettingsPath"
        Me.txtSettingsPath.Size = New System.Drawing.Size(555, 46)
        Me.txtSettingsPath.TabIndex = 57
        '
        'txtSettingsLocationType
        '
        Me.txtSettingsLocationType.Location = New System.Drawing.Point(6, 231)
        Me.txtSettingsLocationType.Name = "txtSettingsLocationType"
        Me.txtSettingsLocationType.Size = New System.Drawing.Size(72, 20)
        Me.txtSettingsLocationType.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Settings path:"
        '
        'txtProjectType
        '
        Me.txtProjectType.Location = New System.Drawing.Point(6, 179)
        Me.txtProjectType.Name = "txtProjectType"
        Me.txtProjectType.Size = New System.Drawing.Size(72, 20)
        Me.txtProjectType.TabIndex = 53
        '
        'txtProjectDescription
        '
        Me.txtProjectDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProjectDescription.Location = New System.Drawing.Point(85, 88)
        Me.txtProjectDescription.Multiline = True
        Me.txtProjectDescription.Name = "txtProjectDescription"
        Me.txtProjectDescription.Size = New System.Drawing.Size(607, 40)
        Me.txtProjectDescription.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Description:"
        '
        'txtProjectName
        '
        Me.txtProjectName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProjectName.Location = New System.Drawing.Point(85, 62)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(607, 20)
        Me.txtProjectName.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Project name:"
        '
        'btnAndorville
        '
        Me.btnAndorville.BackgroundImage = Global.ADVL_Coordinates_Client_2.My.Resources.Resources.Andorville_16May16_TM_Crop_Grey
        Me.btnAndorville.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAndorville.Font = New System.Drawing.Font("Harlow Solid Italic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAndorville.Location = New System.Drawing.Point(5, 5)
        Me.btnAndorville.Name = "btnAndorville"
        Me.btnAndorville.Size = New System.Drawing.Size(118, 29)
        Me.btnAndorville.TabIndex = 49
        Me.btnAndorville.UseVisualStyleBackColor = True
        '
        'btnWebPages
        '
        Me.btnWebPages.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWebPages.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnWebPages.Location = New System.Drawing.Point(877, 12)
        Me.btnWebPages.Name = "btnWebPages"
        Me.btnWebPages.Size = New System.Drawing.Size(68, 22)
        Me.btnWebPages.TabIndex = 279
        Me.btnWebPages.Text = "Workflows"
        Me.btnWebPages.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1_EditWorkflowTabPage, Me.ToolStripMenuItem1_ShowStartPageInWorkflowTab})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(248, 48)
        '
        'ToolStripMenuItem1_EditWorkflowTabPage
        '
        Me.ToolStripMenuItem1_EditWorkflowTabPage.Name = "ToolStripMenuItem1_EditWorkflowTabPage"
        Me.ToolStripMenuItem1_EditWorkflowTabPage.Size = New System.Drawing.Size(247, 22)
        Me.ToolStripMenuItem1_EditWorkflowTabPage.Text = "Edit Workflow Tab Page"
        '
        'ToolStripMenuItem1_ShowStartPageInWorkflowTab
        '
        Me.ToolStripMenuItem1_ShowStartPageInWorkflowTab.Name = "ToolStripMenuItem1_ShowStartPageInWorkflowTab"
        Me.ToolStripMenuItem1_ShowStartPageInWorkflowTab.Size = New System.Drawing.Size(247, 22)
        Me.ToolStripMenuItem1_ShowStartPageInWorkflowTab.Text = "Show Start Page in Workflow Tab"
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1252, 601)
        Me.Controls.Add(Me.btnWebPages)
        Me.Controls.Add(Me.btnAndorville)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnAppInfo)
        Me.Controls.Add(Me.btnOnline)
        Me.Controls.Add(Me.btnMessages)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Andorville™ Coordinates Client"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.dgvDirectDTOps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        CType(Me.dgvInputToWgs84DTOps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        CType(Me.dgvWgs84ToOutputDTOps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.udPointFontSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.dgvConversion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnMessages As System.Windows.Forms.Button
    Friend WithEvents btnOnline As System.Windows.Forms.Button
    Friend WithEvents btnAppInfo As System.Windows.Forms.Button
    Friend WithEvents btnProject As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtLastUsed As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCreationDate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDataLocationType As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSettingsPath As TextBox
    Friend WithEvents txtSettingsLocationType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProjectType As TextBox
    Friend WithEvents txtProjectDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProjectName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAndorville As Button
    Friend WithEvents txtCurrentDuration As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalDuration As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents txtSystemLocationType As TextBox
    Friend WithEvents txtSystemPath As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnWebPages As Button
    Friend WithEvents txtParentProject As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnParameters As Button
    Friend WithEvents btnOpenAppDir As Button
    Friend WithEvents btnOpenSystem As Button
    Friend WithEvents btnOpenData As Button
    Friend WithEvents btnOpenSettings As Button
    Friend WithEvents txtDataPath As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtProNetName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label13 As Label
    Friend WithEvents txtProjectPath As TextBox
    Friend WithEvents btnOpenProject As Button
    Friend WithEvents chkConnect As CheckBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1_EditWorkflowTabPage As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1_ShowStartPageInWorkflowTab As ToolStripMenuItem
    Friend WithEvents btnShowProjectInfo As Button
    Friend WithEvents btnOpenArchive As Button
    Friend WithEvents btnCreateArchive As Button
    Friend WithEvents btnOpenParentDir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtEastLongBound As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtWestLongBound As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNorthLatBound As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSouthLatBound As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents rbInside As RadioButton
    Friend WithEvents rbExtendingInto As RadioButton
    Friend WithEvents rbGetAll As RadioButton
    Friend WithEvents chkGeographic3D As CheckBox
    Friend WithEvents chkGeographic2D As CheckBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents rbContainingPoint As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRefLat As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRefLong As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSetOutputCrs As Button
    Friend WithEvents btnSetInputCrs As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbCrsList As ComboBox
    Friend WithEvents btnCloseCoordsServer As Button
    Friend WithEvents btnOpenCoordsServer As Button
    Friend WithEvents btnGetCrsList As Button
    Friend WithEvents txtCrsNameContains As TextBox
    Friend WithEvents chkCrsNameContains As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnNone As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents chkProjected As CheckBox
    Friend WithEvents chkVertical As CheckBox
    Friend WithEvents chkGeocentric As CheckBox
    Friend WithEvents chkEngineering As CheckBox
    Friend WithEvents chkCompound As CheckBox
    Friend WithEvents chkDerived As CheckBox
    Friend WithEvents txtCrsCode As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents txtDatumTransType As TextBox
    Friend WithEvents txtInputToWgs84DatumTransOpCode As TextBox
    Friend WithEvents txtInputToWgs84DatumTransOpName As TextBox
    Friend WithEvents txtDirectDatumTransOpCode As TextBox
    Friend WithEvents txtDirectDatumTransOpName As TextBox
    Friend WithEvents Label142 As Label
    Friend WithEvents txtOutputCrsCode As TextBox
    Friend WithEvents txtInputCrsCode As TextBox
    Friend WithEvents txtOutputCrsName As TextBox
    Friend WithEvents Label185 As Label
    Friend WithEvents txtInputCrsName As TextBox
    Friend WithEvents Label184 As Label
    Friend WithEvents Label158 As Label
    Friend WithEvents txtAccuracy As TextBox
    Friend WithEvents btdSetDatumTrans As Button
    Friend WithEvents rbDatumTransViaWgs84 As RadioButton
    Friend WithEvents rbDirectDatumTrans As RadioButton
    Friend WithEvents rbDtNotRequired As RadioButton
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents Label154 As Label
    Friend WithEvents Label153 As Label
    Friend WithEvents txtDirectDTOpName As TextBox
    Friend WithEvents txtDirectDTOpCode As TextBox
    Friend WithEvents Label119 As Label
    Friend WithEvents txtDirectDTOpAccuracy As TextBox
    Friend WithEvents dgvDirectDTOps As DataGridView
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents dgvInputToWgs84DTOps As DataGridView
    Friend WithEvents Label169 As Label
    Friend WithEvents Label170 As Label
    Friend WithEvents txtInputToWgs84DTOpName As TextBox
    Friend WithEvents txtInputToWgs84DTOpCode As TextBox
    Friend WithEvents Label173 As Label
    Friend WithEvents txtInputToWgs84DTOpAccuracy As TextBox
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents Label126 As Label
    Friend WithEvents Label127 As Label
    Friend WithEvents txtWgs84ToOutputDTOpName As TextBox
    Friend WithEvents txtWgs84ToOutputDTOpCode As TextBox
    Friend WithEvents Label130 As Label
    Friend WithEvents txtWgs84ToOutputDTOpAccuracy As TextBox
    Friend WithEvents dgvWgs84ToOutputDTOps As DataGridView
    Friend WithEvents btnGetDatumTransList As Button
    Friend WithEvents btnAutoSelectDatumTrans As Button
    Friend WithEvents dgvConversion As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtDataName As TextBox
    Friend WithEvents Label111 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label110 As Label
    Friend WithEvents btnNewConvFile As Button
    Friend WithEvents btnOpenConvFile As Button
    Friend WithEvents btnSaveConvFile As Button
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents btnFormatHelp3 As Button
    Friend WithEvents txtHeightFormat As TextBox
    Friend WithEvents Label208 As Label
    Friend WithEvents txtCartFormat As TextBox
    Friend WithEvents Label207 As Label
    Friend WithEvents chkDmsSymbols As CheckBox
    Friend WithEvents txtProjFormat As TextBox
    Friend WithEvents txtSecondsDecPlaces As TextBox
    Friend WithEvents Label204 As Label
    Friend WithEvents txtDegreeDecPlaces As TextBox
    Friend WithEvents rbDecDegrees As RadioButton
    Friend WithEvents Label206 As Label
    Friend WithEvents rbDMS As RadioButton
    Friend WithEvents Label205 As Label
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents udPointFontSize As NumericUpDown
    Friend WithEvents Label51 As Label
    Friend WithEvents chkShowOutputXYZ As CheckBox
    Friend WithEvents chkShowOutputLongLat As CheckBox
    Friend WithEvents chkShowOutputEastNorth As CheckBox
    Friend WithEvents chkShowWgs84XYZ As CheckBox
    Friend WithEvents chkShowInputXYZ As CheckBox
    Friend WithEvents chkShowInputLongLat As CheckBox
    Friend WithEvents chkShowInputEastNorth As CheckBox
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents rbEnterInputXYZ As RadioButton
    Friend WithEvents rbEnterInputLongLat As RadioButton
    Friend WithEvents rbEnterInputEastNorth As RadioButton
    Friend WithEvents txtInputCrsKind As TextBox
    Friend WithEvents txtOutputCrsKind As TextBox
    Friend WithEvents txtCrsKind As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents chkShowPointDescription As CheckBox
    Friend WithEvents chkShowPointName As CheckBox
    Friend WithEvents chkShowPointNumber As CheckBox
    Friend WithEvents txtInputToWgs84DatumTransOpApplyRev As TextBox
    Friend WithEvents lblDatumTransApplyRev2 As Label
    Friend WithEvents lblDatumTransCode2 As Label
    Friend WithEvents lblInputToWgs84DatumTransName As Label
    Friend WithEvents txtDirectDatumTransOpApplyRev As TextBox
    Friend WithEvents lblDatumTransApplyRev1 As Label
    Friend WithEvents lblDatumTransCode1 As Label
    Friend WithEvents lblDirectDatumTransName As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btnRecalculate As Button
    Friend WithEvents txtWgs84ToOutputDatumTransOpApplyRev As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents txtWgs84ToOutputDatumTransOpCode As TextBox
    Friend WithEvents txtWgs84ToOutputDatumTransOpName As TextBox
    Friend WithEvents btnCheckConnection As Button
    Friend WithEvents btnApplyConvSettings As Button
End Class
