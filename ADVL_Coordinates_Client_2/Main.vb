﻿'==============================================================================================================================================================================================
'
'Copyright 2022 Signalworks Pty Ltd, ABN 26 066 681 598

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at
'
'http://www.apache.org/licenses/LICENSE-2.0
'
'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
''WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
'
'----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Imports System.ComponentModel
Imports System.Security.Permissions
<PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
<System.Runtime.InteropServices.ComVisibleAttribute(True)> 'Note: There should be no blank lines between this line and the line: Public Class Main
Public Class Main
    'The ADVL_Coordinates_Client_2 is a demonstration of a client application controlling the ADVL_Coordinates_2 server.
    '
    'An Andorville™ application has the following features:
    '   Each application is relatively simple and has a single purpose.
    '   Networked applications - Any application can exchange information and instructions with any Andorville™ application connected to the Message Service. 
    '   Project based - Data is stored in directory or file based projects.
    '   Open source code-base - A basic set of Andorville™ applications and libraries are licenced under the Apache License, Version 2.0.


#Region " Coding Notes - Notes on the code used in this class." '==============================================================================================================================

    'ADD THE SYSTEM UTILITIES REFERENCE: ==========================================================================================
    'The following references are required by this software: 
    'ADVL_Utilities_Library_1.dll
    'To add the reference, press Project \ Add Reference... 
    '  Select the Browse option then press the Browse button
    '  Find the ADVL_Utilities_Library_1.dll file (it should be located in the directory ...\Projects\ADVL_Utilities_Library_1\ADVL_Utilities_Library_1\bin\Debug\)
    '  Press the Add button. Press the OK button.
    'The Utilities Library is used for Project Management, Archive file management, running XSequence files and running XMessage files.
    'If there are problems with a reference, try deleting it from the references list and adding it again.

    'Add a reference to System.IO.Compression:
    '  Project \ Add Refernce... \ Assemblies \ System.IO.Compression

    'ADD THE SERVICE REFERENCE: ===================================================================================================
    'A service reference to the Message Service must be added to the source code before this service can be used.
    'This is used to connect to the Application Network.

    'Adding the service reference to a project that includes the Message Service project: -----------------------------------------
    'Project \ Add Service Reference
    'Press the Discover button.
    'Expand the items in the Services window and select IMsgService.
    'Press OK.
    '------------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------------------------------------------------------------------------
    'Adding the service reference to other projects that dont include the Message Service project: -------------------------------
    'Run the ADVL_Network_1 application to start the message service.
    'In Microsoft Visual Studio select: Project \ Add Service Reference
    'Enter the address: http://localhost:8734/ADVLService
    'Press the Go button.
    'MsgService is found.
    'Press OK to add ServiceReference1 to the project.
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'ADD THE MsgServiceCallback CODE: =============================================================================================
    'This is used to connect to the Application Network.
    'In Microsoft Visual Studio select: Project \ Add Class
    'MsgServiceCallback.vb
    'Add the following code to the class:
    'Imports System.ServiceModel
    'Public Class MsgServiceCallback
    '    Implements ServiceReference1.IMsgServiceCallback
    '    Public Sub OnSendMessage(message As String) Implements ServiceReference1.IMsgServiceCallback.OnSendMessage
    '        'A message has been received.
    '        'Set the InstrReceived property value to the message (usually in XMessage format). This will also apply the instructions in the XMessage.
    '        Main.InstrReceived = message
    '    End Sub
    'End Class
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'DEBUGGING TIPS:
    '1. If an application based on the Application Template does not initially run correctly,
    '    check that the copied methods, such as Main_Load, have the correct Handles statement.
    '    For example: the Main_Load method should have the following declaration: Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
    '      It will not run when the application loads, with this declaration:      Private Sub Main_Load(sender As Object, e As EventArgs)
    '    For example: the Main_FormClosing method should have the following declaration: Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '      It will not run when the application closes, with this declaration:     Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs)
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'ADD THE Timer1 Control to the Main Form: =====================================================================================
    'Select the Main.vb [Design] tab.
    'Press Toolbox \ Components \ Timer and add Timer1 to the Main form.
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'EDIT THE DefaultAppProperties() CODE: ========================================================================================
    'This sets the Application properties that are stored in the Application_Info_ADVL_2.xml settings file.
    'The following properties need to be updated:
    '  ApplicationInfo.Name
    '  ApplicationInfo.Description
    '  ApplicationInfo.CreationDate
    '  ApplicationInfo.Author
    '  ApplicationInfo.Copyright
    '  ApplicationInfo.Trademarks
    '  ApplicationInfo.License
    '  ApplicationInfo.SourceCode          (Optional - Preliminary implemetation coded.)
    '  ApplicationInfo.ModificationSummary (Optional - Preliminary implemetation coded.)
    '  ApplicationInfo.Libraries           (Optional - Preliminary implemetation coded.)
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'ADD THE Application Icon: ====================================================================================================
    'Double-click My Project in the Solution Explorer window to open the project tab.
    'In the Application section press the Icon box and select Browse.
    'Select an application icon.
    'This icon can also be selected for the Main form icon by editing the properties of this form.
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'EDIT THE Application Info Text: ==============================================================================================
    'The Application Info Text is used to label the application icon in the Application Network tree view.
    'This is edited in the SendApplicationInfo() method of the Main form.
    'Edit the line of code: Dim text As New XElement("Text", "Application Template").
    'Replace the default text "Application Template" with the required text.
    'Note that this text can be updated at any time and when the updated executable is run, it will update the Application Network tree view the next time it is connected.
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'Calling JavaScript from VB.NET:
    'The following Imports statement and permissions are required for the Main form:
    'Imports System.Security.Permissions
    '<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> _
    '<System.Runtime.InteropServices.ComVisibleAttribute(True)> _
    'NOTE: the line continuation characters (_) will disappear form the code view after they have been typed!
    '------------------------------------------------------------------------------------------------------------------------------
    'Calling VB.NET from JavaScript
    'Add the following line to the Main.Load method:
    '  Me.WebBrowser1.ObjectForScripting = Me
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'Adding a Context Menu Strip:
    'In Visual Studio select the tab Main.vb [Design]
    'Select Toolbox \ Menus & Toolbars \ ContextMenuStrip and add it to the form. ContextMenuStrip1 appears in the panel below the form.
    'Right-click ContextMenuStrip1 and select Edit Items...
    'Press Add to add a new menu item
    '  Add item: Name: ToolStripMenuItem1_EditWorkflowTabPage         Text: Edit Workflow Tab Page (Edit the name and text on the right half of the Items Collection Editor.)
    '  Add item: Name: ToolStripMenuItem1_ShowStartPageInWorkflowTab  Text: Show Start Page In Workflow Tab
    'Select the Workflows button on the main form and select ContectMenuStrip property = ContextMenuStrip1
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'Edit the AppInfoHtmlString function to display the appropriate information about the application.
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'The ADVL_Network_1 application should be running the first time the new application is run.
    'The Network application will automatically send its executable file location to the new application.
    'This will allow the new application to start the Network when required.
    '------------------------------------------------------------------------------------------------------------------------------
    '
    'Other code edits:
    '  Main.Load - Message.AddText("------------------- Starting Application: ADVL Application Template ----------------- " & vbCrLf, "Heading")
    '  Private Sub SendApplicationInfo() - Dim text As New XElement("Text", "Application Template")
    '------------------------------------------------------------------------------------------------------------------------------
    '

#End Region 'Coding Notes ---------------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Variable Declarations - All the variables and class objects used in this form and this application." '===============================================================================

    Public WithEvents ApplicationInfo As New ADVL_Utilities_Library_1.ApplicationInfo 'This object is used to store application information.
    Public WithEvents Project As New ADVL_Utilities_Library_1.Project 'This object is used to store Project information.
    Public WithEvents Message As New ADVL_Utilities_Library_1.Message 'This object is used to display messages in the Messages window.
    Public WithEvents ApplicationUsage As New ADVL_Utilities_Library_1.Usage 'This object stores application usage information.

    'Declare Forms used by the application:
    Public WithEvents TemplateForm As frmTemplate
    Public WithEvents WebPageList As frmWebPageList
    Public WithEvents ProjectArchive As frmArchive 'Form used to view the files in a Project archive
    Public WithEvents SettingsArchive As frmArchive 'Form used to view the files in a Settings archive
    Public WithEvents DataArchive As frmArchive 'Form used to view the files in a Data archive
    Public WithEvents SystemArchive As frmArchive 'Form used to view the files in a System archive

    Public WithEvents NewHtmlDisplay As frmHtmlDisplay
    Public HtmlDisplayFormList As New ArrayList 'Used for displaying multiple HtmlDisplay forms.

    Public WithEvents NewWebPage As frmWebPage
    Public WebPageFormList As New ArrayList 'Used for displaying multiple WebView forms.



    'Declare objects used to connect to the Message Service:
    Public client As ServiceReference1.MsgServiceClient
    Public WithEvents XMsg As New ADVL_Utilities_Library_1.XMessage
    Dim XDoc As New System.Xml.XmlDocument
    Public Status As New System.Collections.Specialized.StringCollection
    Dim ClientProNetName As String = "" 'The name of the client Project Network requesting service. 
    Dim ClientAppName As String = "" 'The name of the client requesting service
    Dim ClientConnName As String = "" 'The name of the client connection requesting service
    Dim MessageXDoc As System.Xml.Linq.XDocument
    Dim xmessage As XElement 'This will contain the message. It will be added to MessageXDoc.
    Dim xlocns As New List(Of XElement) 'A list of locations. Each location forms part of the reply message. The information in the reply message will be sent to the specified location in the client application.
    Dim MessageText As String = "" 'The text of a message sent through the Application Network.

    Public OnCompletionInstruction As String = "Stop" 'The last instruction returned on completion of the processing of an XMessage.
    Public EndInstruction As String = "Stop" 'Another method of specifying the last instruction. This is processed in the EndOfSequence section of XMsg.Instructions.

    Public ConnectionName As String = "" 'The name of the connection used to connect this application to the ComNet (Message Service).

    Public ProNetName As String = "" 'The name of the Project Network
    Public ProNetPath As String = "" 'The path of the Project Network

    Public AdvlNetworkAppPath As String = "" 'The application path of the ADVL Network application (ComNet). This is where the "Application.Lock" file will be while ComNet is running
    Public AdvlNetworkExePath As String = "" 'The executable path of the ADVL Network.

    'Variable for local processing of an XMessage:
    Public WithEvents XMsgLocal As New ADVL_Utilities_Library_1.XMessage
    Dim XDocLocal As New System.Xml.XmlDocument
    Public StatusLocal As New System.Collections.Specialized.StringCollection

    'Main.Load variables:
    Dim ProjectSelected As Boolean = False 'If True, a project has been selected using Command Arguments. Used in Main.Load.
    Dim StartupConnectionName As String = "" 'If not "" the application will be connected to the ComNet using this connection name in  Main.Load.

    'The following variables are used to run JavaScript in Web Pages loaded into the Document View: -------------------
    Public WithEvents XSeq As New ADVL_Utilities_Library_1.XSequence
    'To run an XSequence:
    '  XSeq.RunXSequence(xDoc, Status) 'ImportStatus in Import
    '    Handle events:
    '      XSeq.ErrorMsg
    '      XSeq.Instruction(Info, Locn)

    Private XStatus As New System.Collections.Specialized.StringCollection

    'Variables used to restore Item values on a web page.
    Private FormName As String
    Private ItemName As String
    Private SelectId As String

    'StartProject variables:
    Private StartProject_AppName As String  'The application name
    Private StartProject_ConnName As String 'The connection name
    Private StartProject_ProjID As String   'The project ID
    Private StartProject_ProjName As String ' The project name

    Private WithEvents bgwComCheck As New System.ComponentModel.BackgroundWorker 'Used to perform communication checks on a separate thread.

    Public WithEvents bgwSendMessage As New System.ComponentModel.BackgroundWorker 'Used to send a message through the Message Service.
    Dim SendMessageParams As New clsSendMessageParams 'This holds the Send Message parameters: .ProjectNetworkName, .ConnectionName & .Message

    'Alternative SendMessage background worker - needed to send a message while instructions are being processed.
    Public WithEvents bgwSendMessageAlt As New System.ComponentModel.BackgroundWorker 'Used to send a message through the Message Service - alternative backgound worker.
    Dim SendMessageParamsAlt As New clsSendMessageParams 'This holds the Send Message parameters: .ProjectNetworkName, .ConnectionName & .Message - for the alternative background worker.

    Public WithEvents bgwRunInstruction As New System.ComponentModel.BackgroundWorker 'Used to run a single instruction
    Dim InstructionParams As New clsInstructionParams 'This holds the Info and Locn parameters of an instruction.

    'TEST CODE - NOT USED.
    ''UPDATE 6Oct21.
    'Public WithEvents bgwConnectToComNet As New System.ComponentModel.BackgroundWorker 'New version of ConnectToComNet. This version allows the connection process to be stopped and the application run offline.
    'Dim ConnName As String 'The connection name used to connect to the Message Service. If ConnName is blank, the Application Name will be used as the connection name.

    Dim myLock As New Object 'Lock object used with SyncLock in bgwCancelConn.

    'UPDATE 8Oct21.
    'bgwConnectToComNet does not work - Try cancelling the connection attempt using a separate bgw:
    Public WithEvents bgwCancelConn As New System.ComponentModel.BackgroundWorker 'Used to cancel the Client.Connect while it is trying to connect.

    Private ConnCancelled As Boolean = False 'True if the connection attempt has been cancelled.

    Dim CrsList As New List(Of crsInfo) 'Stores coordinate reference system information
    Dim CrsName As String 'Stores a coordinate reference system name
    Dim CrsCode As Integer 'Stores a coordinate reference system code

    'Dim DgvRow As DataGridViewRow
    Dim DatumTransName As String
    Dim DatumTransCode As Integer
    Dim DatumTransAccuracy As Single
    Dim DatumTransReversible As Boolean
    Dim DatumTransApplyReverse As Boolean

    Dim CoordIndex As Integer 'Stores the coordinated index - used to process converted coordinate infromation received fromt he Coordinates Server.


#End Region 'Variable Declarations ------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Properties - All the properties used in this form and this application" '============================================================================================================

    Private _connectionHashcode As Integer 'The Message Service connection hashcode. This is used to identify a connection in the Message Service when reconnecting.
    Property ConnectionHashcode As Integer
        Get
            Return _connectionHashcode
        End Get
        Set(value As Integer)
            _connectionHashcode = value
        End Set
    End Property

    Private _connectedToComNet As Boolean = False  'True if the application is connected to the Communication Network (Message Service).
    Property ConnectedToComNet As Boolean
        Get
            Return _connectedToComNet
        End Get
        Set(value As Boolean)
            _connectedToComNet = value
        End Set
    End Property

    Private _instrReceived As String = "" 'Contains Instructions received via the Message Service.
    Property InstrReceived As String
        Get
            Return _instrReceived
        End Get
        Set(value As String)
            If value = Nothing Then
                Message.Add("Empty message received!")
            Else
                _instrReceived = value
                ProcessInstructions(_instrReceived)
            End If
        End Set
    End Property

    Private Sub ProcessInstructions(ByVal Instructions As String)
        'Process the XMessage instructions.

        Dim MsgType As String
        If Instructions.StartsWith("<XMsg>") Then
            MsgType = "XMsg"
            If ShowXMessages Then
                'Add the message header to the XMessages window:
                Message.XAddText("Message received: " & vbCrLf, "XmlReceivedNotice")
            End If
        ElseIf Instructions.StartsWith("<XSys>") Then
            MsgType = "XSys"
            If ShowSysMessages Then
                'Add the message header to the XMessages window:
                Message.XAddText("System Message received: " & vbCrLf, "XmlReceivedNotice")
            End If
        Else
            MsgType = "Unknown"
        End If

        If MsgType = "XMsg" Or MsgType = "XSys" Then 'This is an XMessage or XSystem set of instructions.
            Try
                'Inititalise the reply message:
                ClientProNetName = ""
                ClientConnName = ""
                ClientAppName = ""
                xlocns.Clear() 'Clear the list of locations in the reply message. 
                Dim Decl As New XDeclaration("1.0", "utf-8", "yes")
                MessageXDoc = New XDocument(Decl, Nothing) 'Reply message - this will be sent to the Client App.
                xmessage = New XElement(MsgType)
                xlocns.Add(New XElement("Main")) 'Initially set the location in the Client App to Main.

                'Run the received message:
                Dim XmlHeader As String = "<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>"
                XDoc.LoadXml(XmlHeader & vbCrLf & Instructions.Replace("&", "&amp;")) 'Replace "&" with "&amp:" before loading the XML text.

                If (MsgType = "XMsg") And ShowXMessages Then
                    Message.XAddXml(XDoc)  'Add the message to the XMessages window.
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                ElseIf (MsgType = "XSys") And ShowSysMessages Then
                    Message.XAddXml(XDoc)  'Add the message to the XMessages window.
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                End If

                XMsg.Run(XDoc, Status)
            Catch ex As Exception
                Message.Add("Error running XMsg: " & ex.Message & vbCrLf)
            End Try

            'XMessage has been run.
            'Reply to this message:
            'Add the message reply to the XMessages window:
            'Complete the MessageXDoc:
            xmessage.Add(xlocns(xlocns.Count - 1)) 'Add the last location reply instructions to the message.
            MessageXDoc.Add(xmessage)
            MessageText = MessageXDoc.ToString

            If ClientConnName = "" Then
                'No client to send a message to - process the message locally.

                If (MsgType = "XMsg") And ShowXMessages Then
                    Message.XAddText("Message processed locally:" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(MessageText)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                ElseIf (MsgType = "XSys") And ShowSysMessages Then
                    Message.XAddText("System Message processed locally:" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(MessageText)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                End If
                ProcessLocalInstructions(MessageText)
            Else
                If (MsgType = "XMsg") And ShowXMessages Then
                    Message.XAddText("Message sent to [" & ClientProNetName & "]." & ClientConnName & ":" & vbCrLf, "XmlSentNotice")   'NOTE: There is no SendMessage code in the Message Service application!
                    Message.XAddXml(MessageText)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                ElseIf (MsgType = "XSys") And ShowSysMessages Then
                    Message.XAddText("System Message sent to [" & ClientProNetName & "]." & ClientConnName & ":" & vbCrLf, "XmlSentNotice")   'NOTE: There is no SendMessage code in the Message Service application!
                    Message.XAddXml(MessageText)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                End If

                'Send Message on a new thread:
                SendMessageParams.ProjectNetworkName = ClientProNetName
                SendMessageParams.ConnectionName = ClientConnName
                SendMessageParams.Message = MessageText
                If bgwSendMessage.IsBusy Then
                    Message.AddWarning("Send Message backgroundworker is busy." & vbCrLf)
                Else
                    bgwSendMessage.RunWorkerAsync(SendMessageParams)
                End If
            End If

        Else 'This is not an XMessage!
            If Instructions.StartsWith("<XMsgBlk>") Then 'This is an XMessageBlock.
                'Process the received message:
                Dim XmlHeader As String = "<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>"
                XDoc.LoadXml(XmlHeader & vbCrLf & Instructions.Replace("&", "&amp;")) 'Replace "&" with "&amp:" before loading the XML text.
                If ShowXMessages Then
                    Message.XAddXml(XDoc)   'Add the message to the XMessages window.
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                End If

                'Process the XMessageBlock:
                Dim XMsgBlkLocn As String
                XMsgBlkLocn = XDoc.GetElementsByTagName("ClientLocn")(0).InnerText
                Select Case XMsgBlkLocn
                    Case "TestLocn" 'Replace this with the required location name.
                        Dim XInfo As Xml.XmlNodeList = XDoc.GetElementsByTagName("XInfo") 'Get the XInfo node list
                        Dim InfoXDoc As New Xml.Linq.XDocument 'Create an XDocument to hold the information contained in XInfo 
                        InfoXDoc = XDocument.Parse("<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>" & vbCrLf & XInfo(0).InnerXml) 'Read the information into InfoXDoc
                        'Add processing instructions here 
                        ' The information in the InfoXDoc is usually sent to an XDocument in the application or stored as an XML file in the project.

                    Case Else
                        Message.AddWarning("Unknown XInfo Message location: " & XMsgBlkLocn & vbCrLf)
                End Select
            Else
                Message.XAddText("The message is not an XMessage or XMessageBlock: " & vbCrLf & Instructions & vbCrLf & vbCrLf, "Normal")
            End If
        End If
    End Sub

    Private Sub ProcessLocalInstructions(ByVal Instructions As String)
        'Process the XMessage instructions locally.

        If Instructions.StartsWith("<XMsg>") Or Instructions.StartsWith("<XSys>") Then 'This is an XMessage set of instructions.
            'Run the received message:
            Dim XmlHeader As String = "<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>"
            XDocLocal.LoadXml(XmlHeader & vbCrLf & Instructions)
            XMsgLocal.Run(XDocLocal, StatusLocal)
        Else 'This is not an XMessage!
            Message.XAddText("The message is not an XMessage: " & Instructions & vbCrLf, "Normal")
        End If
    End Sub

    Private _showXMessages As Boolean = True 'If True, XMessages that are sent or received will be shown in the Messages window.
    Property ShowXMessages As Boolean
        Get
            Return _showXMessages
        End Get
        Set(value As Boolean)
            _showXMessages = value
        End Set
    End Property

    Private _showSysMessages As Boolean = True 'If True, System messages that are sent or received will be shown in the messages window.
    Property ShowSysMessages As Boolean
        Get
            Return _showSysMessages
        End Get
        Set(value As Boolean)
            _showSysMessages = value
        End Set
    End Property

    Private _closedFormNo As Integer 'Temporarily holds the number of the form that is being closed. 
    Property ClosedFormNo As Integer
        Get
            Return _closedFormNo
        End Get
        Set(value As Integer)
            _closedFormNo = value
        End Set
    End Property



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private _workflowFileName As String = "" 'The file name of the html document displayed in the Workflow tab.

    Public Property WorkflowFileName As String
        Get
            Return _workflowFileName
        End Get
        Set(value As String)
            _workflowFileName = value
        End Set
    End Property

    Private _modified As Boolean = False 'If True, the conversion settings have been modified.
    Property Modified As Boolean
        Get
            Return _modified
        End Get
        Set(value As Boolean)
            _modified = value
        End Set
    End Property

#End Region 'Properties -----------------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Process XML Files - Read and write XML files." '=====================================================================================================================================

    Private Sub SaveFormSettings()
        'Save the form settings in an XML document.

        dgvConversion.AllowUserToAddRows = False

        Dim EntryCoordType As String
        If rbEnterInputEastNorth.Checked Then
            EntryCoordType = "Projected"
        ElseIf rbEnterInputLongLat.Checked Then
            EntryCoordType = "Geographic"
        ElseIf rbEnterInputXYZ.Checked Then
            EntryCoordType = "Cartesian"
        Else
            EntryCoordType = "Geographic"
        End If


        Dim settingsData = <?xml version="1.0" encoding="utf-8"?>
                           <!---->
                           <!--Form settings for Main form.-->
                           <FormSettings>
                               <Left><%= Me.Left %></Left>
                               <Top><%= Me.Top %></Top>
                               <Width><%= Me.Width %></Width>
                               <Height><%= Me.Height %></Height>
                               <AdvlNetworkAppPath><%= AdvlNetworkAppPath %></AdvlNetworkAppPath>
                               <AdvlNetworkExePath><%= AdvlNetworkExePath %></AdvlNetworkExePath>
                               <ShowXMessages><%= ShowXMessages %></ShowXMessages>
                               <ShowSysMessages><%= ShowSysMessages %></ShowSysMessages>
                               <WorkFlowFileName><%= WorkflowFileName %></WorkFlowFileName>
                               <!--Main Form Settings-->
                               <SelectedTabIndex><%= TabControl1.SelectedIndex %></SelectedTabIndex>
                               <CoordinatesTabIndex><%= TabControl2.SelectedIndex %></CoordinatesTabIndex>
                               <DatumTransTabIndex><%= TabControl3.SelectedIndex %></DatumTransTabIndex>
                               <ViaWgs84TabIndex><%= TabControl4.SelectedIndex %></ViaWgs84TabIndex>
                               <!--Coordinate Reference Systems-->
                               <ProjectedCrsKind><%= chkProjected.Checked %></ProjectedCrsKind>
                               <Geographic2DCrsKind><%= chkGeographic2D.Checked %></Geographic2DCrsKind>
                               <Geographic3DCrsKind><%= chkGeographic3D.Checked %></Geographic3DCrsKind>
                               <CompoundCrsKind><%= chkCompound.Checked %></CompoundCrsKind>
                               <DerivedCrsKind><%= chkDerived.Checked %></DerivedCrsKind>
                               <EngineeringCrsKind><%= chkEngineering.Checked %></EngineeringCrsKind>
                               <GeocentricCrsKind><%= chkGeocentric.Checked %></GeocentricCrsKind>
                               <VerticalCrsKind><%= chkVertical.Checked %></VerticalCrsKind>
                               <GetAll><%= rbGetAll.Checked %></GetAll>
                               <ExtendingInto><%= rbExtendingInto.Checked %></ExtendingInto>
                               <Inside><%= rbInside.Checked %></Inside>
                               <ContainingPoint><%= rbContainingPoint.Checked %></ContainingPoint>
                               <NorthLatBound><%= txtNorthLatBound.Text.Trim %></NorthLatBound>
                               <SouthLatBound><%= txtSouthLatBound.Text.Trim %></SouthLatBound>
                               <WestLongBound><%= txtWestLongBound.Text.Trim %></WestLongBound>
                               <EastLongBound><%= txtEastLongBound.Text.Trim %></EastLongBound>
                               <ReferenceLong><%= txtRefLong.Text.Trim %></ReferenceLong>
                               <ReferenceLat><%= txtRefLat.Text.Trim %></ReferenceLat>
                               <CrsNameContains><%= chkCrsNameContains.Checked %></CrsNameContains>
                               <CrsNameContainsText><%= txtCrsNameContains.Text.Trim %></CrsNameContainsText>
                               <!--Datum Transformation-->
                               <DatumTransType><%= txtDatumTransType.Text %></DatumTransType>
                               <!--Point Conversion Display Settings-->
                               <EntryCoordType><%= EntryCoordType %></EntryCoordType>
                               <ShowInputEastingNorthing><%= chkShowInputEastNorth.Checked %></ShowInputEastingNorthing>
                               <ShowInputLongitudeLatitude><%= chkShowInputLongLat.Checked %></ShowInputLongitudeLatitude>
                               <ShowInputXYS><%= chkShowInputXYZ.Checked %></ShowInputXYS>
                               <ShowWgs84XYZ><%= chkShowWgs84XYZ.Checked %></ShowWgs84XYZ>
                               <ShowOutputEastingNorthing><%= chkShowOutputEastNorth.Checked %></ShowOutputEastingNorthing>
                               <ShowOutputLongitudeLatitude><%= chkShowOutputLongLat.Checked %></ShowOutputLongitudeLatitude>
                               <ShowOutputXYZ><%= chkShowOutputXYZ.Checked %></ShowOutputXYZ>
                               <ShowPointNumber><%= chkShowPointNumber.Checked %></ShowPointNumber>
                               <ShowPointName><%= chkShowPointName.Checked %></ShowPointName>
                               <ShowPointDescription><%= chkShowPointDescription.Checked %></ShowPointDescription>
                               <ProjectedFormat><%= txtProjFormat.Text %></ProjectedFormat>
                               <CartesianFormat><%= txtCartFormat.Text %></CartesianFormat>
                               <ShowDegMinSec><%= rbDMS.Checked %></ShowDegMinSec>
                               <ShowDegMinSecSymbols><%= chkDmsSymbols.Checked %></ShowDegMinSecSymbols>
                               <DecDegreesDecPlaces><%= txtDegreeDecPlaces.Text %></DecDegreesDecPlaces>
                               <DmsSecondsDecPlaces><%= txtSecondsDecPlaces.Text %></DmsSecondsDecPlaces>
                               <HeightFormat><%= txtHeightFormat.Text %></HeightFormat>
                               <!--File Settings-->
                               <FileName><%= txtFileName.Text.Trim %></FileName>
                               <DataName><%= txtDataName.Text.Trim %></DataName>
                               <DataDescription><%= txtDescription.Text.Trim %></DataDescription>
                               <!--Point Conversion Settings-->
                               <InputCrsName><%= txtInputCrsName.Text.Trim %></InputCrsName>
                               <InputCrsCode><%= txtInputCrsCode.Text.Trim %></InputCrsCode>
                               <InputCrsKind><%= txtInputCrsKind.Text.Trim %></InputCrsKind>
                               <OutputCrsName><%= txtOutputCrsName.Text.Trim %></OutputCrsName>
                               <OutputCrsCode><%= txtOutputCrsCode.Text.Trim %></OutputCrsCode>
                               <OutputCrsKind><%= txtOutputCrsKind.Text %></OutputCrsKind>
                               <DatumTransType><%= txtDatumTransType.Text.Trim %></DatumTransType>
                               <DirectDatumTransOpName><%= txtDirectDatumTransOpName.Text.Trim %></DirectDatumTransOpName>
                               <DirectDatumTransOpCode><%= txtDirectDatumTransOpCode.Text.Trim %></DirectDatumTransOpCode>
                               <DirectDatumTransOpApplyRev><%= txtDirectDatumTransOpApplyRev.Text.Trim %></DirectDatumTransOpApplyRev>
                               <InputToWgs84DatumTransOpName><%= txtInputToWgs84DatumTransOpName.Text.Trim %></InputToWgs84DatumTransOpName>
                               <InputToWgs84DatumTransOpCode><%= txtInputToWgs84DatumTransOpCode.Text.Trim %></InputToWgs84DatumTransOpCode>
                               <InputToWgs84DatumTransOpApplyRev><%= txtInputToWgs84DatumTransOpApplyRev.Text.Trim %></InputToWgs84DatumTransOpApplyRev>
                               <Wgs84ToOutputDatumTransOpName><%= txtWgs84ToOutputDatumTransOpName.Text.Trim %></Wgs84ToOutputDatumTransOpName>
                               <Wgs84ToOutputDatumTransOpCode><%= txtWgs84ToOutputDatumTransOpCode.Text.Trim %></Wgs84ToOutputDatumTransOpCode>
                               <Wgs84ToOutputDatumTransOpApplyRev><%= txtWgs84ToOutputDatumTransOpApplyRev.Text.Trim %></Wgs84ToOutputDatumTransOpApplyRev>
                               <!--Save the Datum Transformation Input Points-->
                               <%= DatumTransInputData(EntryCoordType).<DatumTransInputData> %>
                           </FormSettings>

        'Add code to include other settings to save after the comment line <!---->

        Dim SettingsFileName As String = "FormSettings_" & ApplicationInfo.Name & " - Main.xml"
        Project.SaveXmlSettings(SettingsFileName, settingsData)
    End Sub

    Private Function DatumTransInputData(EntryCoordType As String) As XDocument
        'Returns a XDocument containing the Datum Transformation Input Points shown in dgvConversion.

        If EntryCoordType = "Projected" Then

            Dim XDoc = <?xml version="1.0" encoding="utf-8"?>
                       <DatumTransInputData>
                           <%= From Row As DataGridViewRow In dgvConversion.Rows
                               Select
                              <Row>
                                  <PointNumber><%= Row.Cells(0).Value %></PointNumber>
                                  <PointName><%= Row.Cells(1).Value %></PointName>
                                  <PointDescription><%= Row.Cells(2).Value %></PointDescription>
                                  <Easting><%= Row.Cells(3).Value %></Easting>
                                  <Northing><%= Row.Cells(4).Value %></Northing>
                              </Row> %>
                       </DatumTransInputData>
            Return XDoc

        ElseIf EntryCoordType = "Geographic" Then

            Dim XDoc = <?xml version="1.0" encoding="utf-8"?>
                       <DatumTransInputData>
                           <%= From Row As DataGridViewRow In dgvConversion.Rows
                               Select
                              <Row>
                                  <PointNumber><%= Row.Cells(0).Value %></PointNumber>
                                  <PointName><%= Row.Cells(1).Value %></PointName>
                                  <PointDescription><%= Row.Cells(2).Value %></PointDescription>
                                  <Longitude><%= Row.Cells(5).Value %></Longitude>
                                  <Latitude><%= Row.Cells(6).Value %></Latitude>
                                  <Height><%= Row.Cells(7).Value %></Height>
                              </Row> %>
                       </DatumTransInputData>
            Return XDoc

        ElseIf EntryCoordType = "Cartesian" Then

            Dim XDoc = <?xml version="1.0" encoding="utf-8"?>
                       <DatumTransInputData>
                           <%= From Row As DataGridViewRow In dgvConversion.Rows
                               Select
                              <Row>
                                  <PointNumber><%= Row.Cells(0).Value %></PointNumber>
                                  <PointName><%= Row.Cells(1).Value %></PointName>
                                  <PointDescription><%= Row.Cells(2).Value %></PointDescription>
                                  <X><%= Row.Cells(8).Value %></X>
                                  <Y><%= Row.Cells(9).Value %></Y>
                                  <Z><%= Row.Cells(10).Value %></Z>
                              </Row> %>
                       </DatumTransInputData>
            Return XDoc

        Else

        End If

    End Function

    Private Sub RestoreFormSettings()
        'Read the form settings from an XML document.

        Dim SettingsFileName As String = "FormSettings_" & ApplicationInfo.Name & " - Main.xml"

        If Project.SettingsFileExists(SettingsFileName) Then
            Dim Settings As System.Xml.Linq.XDocument
            Project.ReadXmlSettings(SettingsFileName, Settings)

            If IsNothing(Settings) Then 'There is no Settings XML data.
                Exit Sub
            End If

            'Restore form position and size:
            If Settings.<FormSettings>.<Left>.Value <> Nothing Then Me.Left = Settings.<FormSettings>.<Left>.Value
            If Settings.<FormSettings>.<Top>.Value <> Nothing Then Me.Top = Settings.<FormSettings>.<Top>.Value
            If Settings.<FormSettings>.<Height>.Value <> Nothing Then Me.Height = Settings.<FormSettings>.<Height>.Value
            If Settings.<FormSettings>.<Width>.Value <> Nothing Then Me.Width = Settings.<FormSettings>.<Width>.Value

            If Settings.<FormSettings>.<AdvlNetworkAppPath>.Value <> Nothing Then AdvlNetworkAppPath = Settings.<FormSettings>.<AdvlNetworkAppPath>.Value
            If Settings.<FormSettings>.<AdvlNetworkExePath>.Value <> Nothing Then AdvlNetworkExePath = Settings.<FormSettings>.<AdvlNetworkExePath>.Value

            If Settings.<FormSettings>.<ShowXMessages>.Value <> Nothing Then ShowXMessages = Settings.<FormSettings>.<ShowXMessages>.Value
            If Settings.<FormSettings>.<ShowSysMessages>.Value <> Nothing Then ShowSysMessages = Settings.<FormSettings>.<ShowSysMessages>.Value

            If Settings.<FormSettings>.<WorkFlowFileName>.Value <> Nothing Then WorkflowFileName = Settings.<FormSettings>.<WorkFlowFileName>.Value

            'Add code to read other saved setting here:
            'Restore Coordinate Reference Systems settings:
            If Settings.<FormSettings>.<SelectedTabIndex>.Value <> Nothing Then TabControl1.SelectedIndex = Settings.<FormSettings>.<SelectedTabIndex>.Value
            If Settings.<FormSettings>.<CoordinatesTabIndex>.Value <> Nothing Then TabControl2.SelectedIndex = Settings.<FormSettings>.<CoordinatesTabIndex>.Value
            If Settings.<FormSettings>.<DatumTransTabIndex>.Value <> Nothing Then TabControl3.SelectedIndex = Settings.<FormSettings>.<DatumTransTabIndex>.Value
            If Settings.<FormSettings>.<ViaWgs84TabIndex>.Value <> Nothing Then TabControl4.SelectedIndex = Settings.<FormSettings>.<ViaWgs84TabIndex>.Value

            If Settings.<FormSettings>.<ProjectedCrsKind>.Value <> Nothing Then chkProjected.Checked = Settings.<FormSettings>.<ProjectedCrsKind>.Value
            If Settings.<FormSettings>.<Geographic2DCrsKind>.Value <> Nothing Then chkGeographic2D.Checked = Settings.<FormSettings>.<Geographic2DCrsKind>.Value
            If Settings.<FormSettings>.<Geographic3DCrsKind>.Value <> Nothing Then chkGeographic3D.Checked = Settings.<FormSettings>.<Geographic3DCrsKind>.Value
            If Settings.<FormSettings>.<CompoundCrsKind>.Value <> Nothing Then chkCompound.Checked = Settings.<FormSettings>.<CompoundCrsKind>.Value
            If Settings.<FormSettings>.<DerivedCrsKind>.Value <> Nothing Then chkDerived.Checked = Settings.<FormSettings>.<DerivedCrsKind>.Value
            If Settings.<FormSettings>.<EngineeringCrsKind>.Value <> Nothing Then chkEngineering.Checked = Settings.<FormSettings>.<EngineeringCrsKind>.Value
            If Settings.<FormSettings>.<GeocentricCrsKind>.Value <> Nothing Then chkGeocentric.Checked = Settings.<FormSettings>.<GeocentricCrsKind>.Value
            If Settings.<FormSettings>.<VerticalCrsKind>.Value <> Nothing Then chkVertical.Checked = Settings.<FormSettings>.<VerticalCrsKind>.Value
            If Settings.<FormSettings>.<GetAll>.Value <> Nothing Then rbGetAll.Checked = Settings.<FormSettings>.<GetAll>.Value
            If Settings.<FormSettings>.<ExtendingInto>.Value <> Nothing Then rbExtendingInto.Checked = Settings.<FormSettings>.<ExtendingInto>.Value
            If Settings.<FormSettings>.<Inside>.Value <> Nothing Then rbInside.Checked = Settings.<FormSettings>.<Inside>.Value
            If Settings.<FormSettings>.<ContainingPoint>.Value <> Nothing Then rbContainingPoint.Checked = Settings.<FormSettings>.<ContainingPoint>.Value
            If Settings.<FormSettings>.<NorthLatBound>.Value <> Nothing Then txtNorthLatBound.Text = Settings.<FormSettings>.<NorthLatBound>.Value
            If Settings.<FormSettings>.<SouthLatBound>.Value <> Nothing Then txtSouthLatBound.Text = Settings.<FormSettings>.<SouthLatBound>.Value
            If Settings.<FormSettings>.<WestLongBound>.Value <> Nothing Then txtWestLongBound.Text = Settings.<FormSettings>.<WestLongBound>.Value
            If Settings.<FormSettings>.<EastLongBound>.Value <> Nothing Then txtEastLongBound.Text = Settings.<FormSettings>.<EastLongBound>.Value
            If Settings.<FormSettings>.<ReferenceLong>.Value <> Nothing Then txtRefLong.Text = Settings.<FormSettings>.<ReferenceLong>.Value
            If Settings.<FormSettings>.<ReferenceLat>.Value <> Nothing Then txtRefLat.Text = Settings.<FormSettings>.<ReferenceLat>.Value
            If Settings.<FormSettings>.<CrsNameContains>.Value <> Nothing Then chkCrsNameContains.Checked = Settings.<FormSettings>.<CrsNameContains>.Value
            If Settings.<FormSettings>.<CrsNameContainsText>.Value <> Nothing Then txtCrsNameContains.Text = Settings.<FormSettings>.<CrsNameContainsText>.Value
            'Restore Datum Transformation Settings:
            If Settings.<FormSettings>.<DatumTransType>.Value <> Nothing Then txtDatumTransType.Text = Settings.<FormSettings>.<DatumTransType>.Value
            'Restore the Point Conversion Settings:
            Dim EntryCoordType As String
            If Settings.<FormSettings>.<EntryCoordType>.Value <> Nothing Then
                EntryCoordType = Settings.<FormSettings>.<EntryCoordType>.Value
                'Select Case Settings.<FormSettings>.<EntryCoordType>.Value
                Select Case EntryCoordType
                    Case "Projected"
                        rbEnterInputEastNorth.Checked = True
                    Case "Geographic"
                        rbEnterInputLongLat.Checked = True
                    Case "Cartesian"
                        rbEnterInputXYZ.Checked = True
                End Select
            End If
            If Settings.<FormSettings>.<ShowPointNumber>.Value <> Nothing Then chkShowPointNumber.Checked = Settings.<FormSettings>.<ShowPointNumber>.Value
            If Settings.<FormSettings>.<ShowPointName>.Value <> Nothing Then chkShowPointName.Checked = Settings.<FormSettings>.<ShowPointName>.Value
            If Settings.<FormSettings>.<ShowPointDescription>.Value <> Nothing Then chkShowPointDescription.Checked = Settings.<FormSettings>.<ShowPointDescription>.Value
            If Settings.<FormSettings>.<ShowInputEastingNorthing>.Value <> Nothing Then chkShowInputEastNorth.Checked = Settings.<FormSettings>.<ShowInputEastingNorthing>.Value
            If Settings.<FormSettings>.<ShowInputLongitudeLatitude>.Value <> Nothing Then chkShowInputLongLat.Checked = Settings.<FormSettings>.<ShowInputLongitudeLatitude>.Value
            If Settings.<FormSettings>.<ShowInputXYS>.Value <> Nothing Then chkShowInputXYZ.Checked = Settings.<FormSettings>.<ShowInputXYS>.Value
            If Settings.<FormSettings>.<ShowWgs84XYZ>.Value <> Nothing Then chkShowWgs84XYZ.Checked = Settings.<FormSettings>.<ShowWgs84XYZ>.Value
            If Settings.<FormSettings>.<ShowOutputEastingNorthing>.Value <> Nothing Then chkShowOutputEastNorth.Checked = Settings.<FormSettings>.<ShowOutputEastingNorthing>.Value
            If Settings.<FormSettings>.<ShowOutputLongitudeLatitude>.Value <> Nothing Then chkShowOutputLongLat.Checked = Settings.<FormSettings>.<ShowOutputLongitudeLatitude>.Value
            If Settings.<FormSettings>.<ShowOutputXYZ>.Value <> Nothing Then chkShowOutputXYZ.Checked = Settings.<FormSettings>.<ShowOutputXYZ>.Value
            If Settings.<FormSettings>.<ProjectedFormat>.Value <> Nothing Then txtProjFormat.Text = Settings.<FormSettings>.<ProjectedFormat>.Value
            If Settings.<FormSettings>.<CartesianFormat>.Value <> Nothing Then txtCartFormat.Text = Settings.<FormSettings>.<CartesianFormat>.Value
            If Settings.<FormSettings>.<DecDegreesDecPlaces>.Value <> Nothing Then
                txtDegreeDecPlaces.Text = Settings.<FormSettings>.<DecDegreesDecPlaces>.Value
                If rbDecDegrees.Checked Then
                    Try
                        txtDegreeDecPlaces.Text = Int(txtDegreeDecPlaces.Text.Trim)
                        Dim Format As String = "F" & txtDegreeDecPlaces.Text.Trim
                        dgvConversion.Columns(5).DefaultCellStyle.Format = Format
                        dgvConversion.Columns(6).DefaultCellStyle.Format = Format
                        dgvConversion.Columns(17).DefaultCellStyle.Format = Format
                        dgvConversion.Columns(18).DefaultCellStyle.Format = Format
                    Catch ex As Exception

                    End Try
                End If
            End If
            If Settings.<FormSettings>.<DmsSecondsDecPlaces>.Value <> Nothing Then txtSecondsDecPlaces.Text = Settings.<FormSettings>.<DmsSecondsDecPlaces>.Value
            If Settings.<FormSettings>.<HeightFormat>.Value <> Nothing Then txtHeightFormat.Text = Settings.<FormSettings>.<HeightFormat>.Value
            If Settings.<FormSettings>.<ShowDegMinSec>.Value <> Nothing Then rbDMS.Checked = Settings.<FormSettings>.<ShowDegMinSec>.Value
            If Settings.<FormSettings>.<ShowDegMinSecSymbols>.Value <> Nothing Then chkDmsSymbols.Checked = Settings.<FormSettings>.<ShowDegMinSecSymbols>.Value

            'Restore File Settings
            If Settings.<FormSettings>.<FileName>.Value <> Nothing Then txtFileName.Text = Settings.<FormSettings>.<FileName>.Value
            If Settings.<FormSettings>.<DataName>.Value <> Nothing Then txtDataName.Text = Settings.<FormSettings>.<DataName>.Value
            If Settings.<FormSettings>.<DataDescription>.Value <> Nothing Then txtDescription.Text = Settings.<FormSettings>.<DataDescription>.Value

            'Restore Point Conversion Settings:
            If Settings.<FormSettings>.<InputCrsName>.Value <> Nothing Then txtInputCrsName.Text = Settings.<FormSettings>.<InputCrsName>.Value
            If Settings.<FormSettings>.<InputCrsCode>.Value <> Nothing Then txtInputCrsCode.Text = Settings.<FormSettings>.<InputCrsCode>.Value
            If Settings.<FormSettings>.<InputCrsKind>.Value <> Nothing Then txtInputCrsKind.Text = Settings.<FormSettings>.<InputCrsKind>.Value
            If Settings.<FormSettings>.<OutputCrsName>.Value <> Nothing Then txtOutputCrsName.Text = Settings.<FormSettings>.<OutputCrsName>.Value
            If Settings.<FormSettings>.<OutputCrsCode>.Value <> Nothing Then txtOutputCrsCode.Text = Settings.<FormSettings>.<OutputCrsCode>.Value
            If Settings.<FormSettings>.<OutputCrsKind>.Value <> Nothing Then txtOutputCrsKind.Text = Settings.<FormSettings>.<OutputCrsKind>.Value
            If Settings.<FormSettings>.<DatumTransType>.Value <> Nothing Then txtDatumTransType.Text = Settings.<FormSettings>.<DatumTransType>.Value
            If Settings.<FormSettings>.<DirectDatumTransOpName>.Value <> Nothing Then txtDirectDatumTransOpName.Text = Settings.<FormSettings>.<DirectDatumTransOpName>.Value
            If Settings.<FormSettings>.<DirectDatumTransOpCode>.Value <> Nothing Then txtDirectDatumTransOpCode.Text = Settings.<FormSettings>.<DirectDatumTransOpCode>.Value
            If Settings.<FormSettings>.<DirectDatumTransOpApplyRev>.Value <> Nothing Then txtDirectDatumTransOpApplyRev.Text = Settings.<FormSettings>.<DirectDatumTransOpApplyRev>.Value
            If Settings.<FormSettings>.<InputToWgs84DatumTransOpName>.Value <> Nothing Then txtInputToWgs84DatumTransOpName.Text = Settings.<FormSettings>.<InputToWgs84DatumTransOpName>.Value
            If Settings.<FormSettings>.<InputToWgs84DatumTransOpCode>.Value <> Nothing Then txtInputToWgs84DatumTransOpCode.Text = Settings.<FormSettings>.<InputToWgs84DatumTransOpCode>.Value
            If Settings.<FormSettings>.<InputToWgs84DatumTransOpApplyRev>.Value <> Nothing Then txtInputToWgs84DatumTransOpApplyRev.Text = Settings.<FormSettings>.<InputToWgs84DatumTransOpApplyRev>.Value
            If Settings.<FormSettings>.<Wgs84ToOutputDatumTransOpName>.Value <> Nothing Then txtWgs84ToOutputDatumTransOpName.Text = Settings.<FormSettings>.<Wgs84ToOutputDatumTransOpName>.Value
            If Settings.<FormSettings>.<Wgs84ToOutputDatumTransOpCode>.Value <> Nothing Then txtWgs84ToOutputDatumTransOpCode.Text = Settings.<FormSettings>.<Wgs84ToOutputDatumTransOpCode>.Value
            If Settings.<FormSettings>.<Wgs84ToOutputDatumTransOpApplyRev>.Value <> Nothing Then txtWgs84ToOutputDatumTransOpApplyRev.Text = Settings.<FormSettings>.<Wgs84ToOutputDatumTransOpApplyRev>.Value

            If EntryCoordType = "Projected" Then
                Dim RowNo As Integer
                If Settings.<FormSettings>.<DatumTransInputData>.Value <> Nothing Then
                    Dim InputPoints = From Item In Settings.<FormSettings>.<DatumTransInputData>.<Row>
                    For Each Item In InputPoints
                        RowNo = dgvConversion.Rows.Add()
                        If Item.<PointNumber>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(0).Value = Item.<PointNumber>.Value
                        If Item.<PointName>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(1).Value = Item.<PointName>.Value
                        If Item.<PointDescription>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(2).Value = Item.<PointDescription>.Value
                        dgvConversion.Rows(RowNo).Cells(3).Value = Item.<Easting>.Value
                        dgvConversion.Rows(RowNo).Cells(4).Value = Item.<Northing>.Value
                    Next
                End If

            ElseIf EntryCoordType = "Geographic" Then

                Dim RowNo As Integer

                If Settings.<FormSettings>.<DatumTransInputData>.Value <> Nothing Then
                    Dim InputPoints = From Item In Settings.<FormSettings>.<DatumTransInputData>.<Row>
                    For Each Item In InputPoints
                        RowNo = dgvConversion.Rows.Add()
                        If Item.<PointNumber>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(0).Value = Item.<PointNumber>.Value
                        If Item.<PointName>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(1).Value = Item.<PointName>.Value
                        If Item.<PointDescription>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(2).Value = Item.<PointDescription>.Value
                        dgvConversion.Rows(RowNo).Cells(5).Value = Item.<Longitude>.Value
                        dgvConversion.Rows(RowNo).Cells(6).Value = Item.<Latitude>.Value
                        dgvConversion.Rows(RowNo).Cells(7).Value = Item.<Height>.Value
                    Next
                End If

            ElseIf EntryCoordType = "Cartesian" Then
                Dim RowNo As Integer
                If Settings.<FormSettings>.<DatumTransInputData>.Value <> Nothing Then
                    Dim InputPoints = From Item In Settings.<FormSettings>.<DatumTransInputData>.<Row>
                    For Each Item In InputPoints
                        RowNo = dgvConversion.Rows.Add()
                        If Item.<PointNumber>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(0).Value = Item.<PointNumber>.Value
                        If Item.<PointName>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(1).Value = Item.<PointName>.Value
                        If Item.<PointDescription>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(2).Value = Item.<PointDescription>.Value
                        dgvConversion.Rows(RowNo).Cells(8).Value = Item.<X>.Value
                        dgvConversion.Rows(RowNo).Cells(9).Value = Item.<Y>.Value
                        dgvConversion.Rows(RowNo).Cells(10).Value = Item.<Z>.Value
                    Next
                End If

            End If

            ApplyCoordinateFormats()

            CheckFormPos()
        End If
    End Sub



    Private Sub CheckFormPos()
        'Check that the form can be seen on a screen.

        Dim MinWidthVisible As Integer = 192 'Minimum number of X pixels visible. The form will be moved if this many form pixels are not visible.
        Dim MinHeightVisible As Integer = 64 'Minimum number of Y pixels visible. The form will be moved if this many form pixels are not visible.

        Dim FormRect As New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
        Dim WARect As Rectangle = Screen.GetWorkingArea(FormRect) 'The Working Area rectangle - the usable area of the screen containing the form.

        'Check if the top of the form is above the top of the Working Area:
        If Me.Top < WARect.Top Then
            Me.Top = WARect.Top
        End If

        'Check if the top of the form is too close to the bottom of the Working Area:
        If (Me.Top + MinHeightVisible) > (WARect.Top + WARect.Height) Then
            Me.Top = WARect.Top + WARect.Height - MinHeightVisible
        End If

        'Check if the left edge of the form is too close to the right edge of the Working Area:
        If (Me.Left + MinWidthVisible) > (WARect.Left + WARect.Width) Then
            Me.Left = WARect.Left + WARect.Width - MinWidthVisible
        End If

        'Check if the right edge of the form is too close to the left edge of the Working Area:
        If (Me.Left + Me.Width - MinWidthVisible) < WARect.Left Then
            Me.Left = WARect.Left - Me.Width + MinWidthVisible
        End If
    End Sub

    Private Sub ReadApplicationInfo()
        'Read the Application Information.

        If ApplicationInfo.FileExists Then
            ApplicationInfo.ReadFile()
        Else
            'There is no Application_Info_ADVL_2.xml file.
            DefaultAppProperties() 'Create a new Application Info file with default application properties.
            ApplicationInfo.WriteFile() 'Write the file now. The file information may be used by other applications.
        End If
    End Sub

    Private Sub DefaultAppProperties()
        'These properties will be saved in the Application_Info.xml file in the application directory.
        'If this file is deleted, it will be re-created using these default application properties.

        'Change this to show your application Name, Description and Creation Date.
        ApplicationInfo.Name = "ADVL_Coordinates_Client_2"

        'ApplicationInfo.ApplicationDir is set when the application is started.
        ApplicationInfo.ExecutablePath = Application.ExecutablePath

        ApplicationInfo.Description = "The ADVL_Coordinates_Client_2 is a demonstration of a client application controlling the ADVL_Coordinates_2 server."
        ApplicationInfo.CreationDate = "1-Jan-2023 12:00:00"

        'Author -----------------------------------------------------------------------------------------------------------
        'Change this to show your Name, Description and Contact information.
        ApplicationInfo.Author.Name = "Signalworks Pty Ltd"
        ApplicationInfo.Author.Description = "Signalworks Pty Ltd" & vbCrLf &
            "Australian Proprietary Company" & vbCrLf &
            "ABN 26 066 681 598" & vbCrLf &
            "Registration Date 05/10/1994"

        ApplicationInfo.Author.Contact = "http://www.andorville.com.au/"

        'File Associations: -----------------------------------------------------------------------------------------------
        'Add any file associations here.
        'The file extension and a description of files that can be opened by this application are specified.
        'The example below specifies a coordinate system parameter file type with the file extension .ADVLCoord.
        'Dim Assn1 As New ADVL_System_Utilities.FileAssociation
        'Assn1.Extension = "ADVLCoord"
        'Assn1.Description = "Andorville™ software coordinate system parameter file"
        'ApplicationInfo.FileAssociations.Add(Assn1)

        'Version ----------------------------------------------------------------------------------------------------------
        ApplicationInfo.Version.Major = My.Application.Info.Version.Major
        ApplicationInfo.Version.Minor = My.Application.Info.Version.Minor
        ApplicationInfo.Version.Build = My.Application.Info.Version.Build
        ApplicationInfo.Version.Revision = My.Application.Info.Version.Revision

        'Copyright --------------------------------------------------------------------------------------------------------
        'Add your copyright information here.
        ApplicationInfo.Copyright.OwnerName = "Signalworks Pty Ltd, ABN 26 066 681 598"
        ApplicationInfo.Copyright.PublicationYear = "2023"

        'Trademarks -------------------------------------------------------------------------------------------------------
        'Add your trademark information here.
        Dim Trademark1 As New ADVL_Utilities_Library_1.Trademark
        Trademark1.OwnerName = "Signalworks Pty Ltd, ABN 26 066 681 598"
        Trademark1.Text = "Andorville"
        Trademark1.Registered = False
        Trademark1.GenericTerm = "software"
        ApplicationInfo.Trademarks.Add(Trademark1)
        Dim Trademark2 As New ADVL_Utilities_Library_1.Trademark
        Trademark2.OwnerName = "Signalworks Pty Ltd, ABN 26 066 681 598"
        Trademark2.Text = "AL-H7"
        Trademark2.Registered = False
        Trademark2.GenericTerm = "software"
        ApplicationInfo.Trademarks.Add(Trademark2)
        Dim Trademark3 As New ADVL_Utilities_Library_1.Trademark
        Trademark3.OwnerName = "Signalworks Pty Ltd, ABN 26 066 681 598"
        Trademark3.Text = "AL-M7"
        Trademark3.Registered = False
        Trademark3.GenericTerm = "software"
        ApplicationInfo.Trademarks.Add(Trademark3)
        Dim Trademark4 As New ADVL_Utilities_Library_1.Trademark
        Trademark4.OwnerName = "Signalworks Pty Ltd, ABN 26 066 681 598"
        Trademark4.Text = "AL-S7"
        Trademark4.Registered = False
        Trademark4.GenericTerm = "software"
        ApplicationInfo.Trademarks.Add(Trademark4)
        Dim Trademark5 As New ADVL_Utilities_Library_1.Trademark
        Trademark5.OwnerName = "Signalworks Pty Ltd, ABN 26 066 681 598"
        Trademark5.Text = "AL-Q7"
        Trademark5.Registered = False
        Trademark5.GenericTerm = "software"
        ApplicationInfo.Trademarks.Add(Trademark5)

        'License -------------------------------------------------------------------------------------------------------
        'Add your license information here.
        ApplicationInfo.License.CopyrightOwnerName = "Signalworks Pty Ltd, ABN 26 066 681 598"
        ApplicationInfo.License.PublicationYear = "2023"

        'License Links:
        'http://choosealicense.com/
        'http://www.apache.org/licenses/
        'http://opensource.org/

        'Apache License 2.0 ---------------------------------------------
        ApplicationInfo.License.Code = ADVL_Utilities_Library_1.License.Codes.Apache_License_2_0
        ApplicationInfo.License.Notice = ApplicationInfo.License.ApacheLicenseNotice 'Get the pre-defined Aapche license notice.
        ApplicationInfo.License.Text = ApplicationInfo.License.ApacheLicenseText     'Get the pre-defined Apache license text.

        'Code to use other pre-defined license types is shown below:

        'GNU General Public License, version 3 --------------------------
        'ApplicationInfo.License.Type = ADVL_Utilities_Library_1.License.Types.GNU_GPL_V3_0
        'ApplicationInfo.License.Notice = 'Add the License Notice to ADVL_Utilities_Library_1 License class.
        'ApplicationInfo.License.Text = 'Add the License Text to ADVL_Utilities_Library_1 License class.

        'The MIT License ------------------------------------------------
        'ApplicationInfo.License.Type = ADVL_Utilities_Library_1.License.Types.MIT_License
        'ApplicationInfo.License.Notice = ApplicationInfo.License.MITLicenseNotice
        'ApplicationInfo.License.Text = ApplicationInfo.License.MITLicenseText

        'No License Specified -------------------------------------------
        'ApplicationInfo.License.Type = ADVL_Utilities_Library_1.License.Types.None
        'ApplicationInfo.License.Notice = ""
        'ApplicationInfo.License.Text = ""

        'The Unlicense --------------------------------------------------
        'ApplicationInfo.License.Type = ADVL_Utilities_Library_1.License.Types.The_Unlicense
        'ApplicationInfo.License.Notice = ApplicationInfo.License.UnLicenseNotice
        'ApplicationInfo.License.Text = ApplicationInfo.License.UnLicenseText

        'Unknown License ------------------------------------------------
        'ApplicationInfo.License.Type = ADVL_Utilities_Library_1.License.Types.Unknown
        'ApplicationInfo.License.Notice = ""
        'ApplicationInfo.License.Text = ""

        'Source Code: --------------------------------------------------------------------------------------------------
        'Add your source code information here if required.
        'THIS SECTION WILL BE UPDATED TO ALLOW A GITHUB LINK.
        ApplicationInfo.SourceCode.Language = "Visual Basic 2015"
        ApplicationInfo.SourceCode.FileName = ""
        ApplicationInfo.SourceCode.FileSize = 0
        ApplicationInfo.SourceCode.FileHash = ""
        ApplicationInfo.SourceCode.WebLink = ""
        ApplicationInfo.SourceCode.Contact = ""
        ApplicationInfo.SourceCode.Comments = ""

        'ModificationSummary: -----------------------------------------------------------------------------------------
        'Add any source code modification here is required.
        ApplicationInfo.ModificationSummary.BaseCodeName = ""
        ApplicationInfo.ModificationSummary.BaseCodeDescription = ""
        ApplicationInfo.ModificationSummary.BaseCodeVersion.Major = 0
        ApplicationInfo.ModificationSummary.BaseCodeVersion.Minor = 0
        ApplicationInfo.ModificationSummary.BaseCodeVersion.Build = 0
        ApplicationInfo.ModificationSummary.BaseCodeVersion.Revision = 0
        ApplicationInfo.ModificationSummary.Description = "This is the first released version of the application. No earlier base code used."

        'Library List: ------------------------------------------------------------------------------------------------
        'Add the ADVL_Utilties_Library_1 library:
        Dim NewLib As New ADVL_Utilities_Library_1.LibrarySummary
        NewLib.Name = "ADVL_System_Utilities"
        NewLib.Description = "System Utility classes used in Andorville™ software development system applications"
        NewLib.CreationDate = "7-Jan-2016 12:00:00"
        NewLib.LicenseNotice = "Copyright 2016 Signalworks Pty Ltd, ABN 26 066 681 598" & vbCrLf &
                               vbCrLf &
                               "Licensed under the Apache License, Version 2.0 (the ""License"");" & vbCrLf &
                               "you may not use this file except in compliance with the License." & vbCrLf &
                               "You may obtain a copy of the License at" & vbCrLf &
                               vbCrLf &
                               "http://www.apache.org/licenses/LICENSE-2.0" & vbCrLf &
                               vbCrLf &
                               "Unless required by applicable law or agreed to in writing, software" & vbCrLf &
                               "distributed under the License is distributed on an ""AS IS"" BASIS," & vbCrLf &
                               "WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied." & vbCrLf &
                               "See the License for the specific language governing permissions and" & vbCrLf &
                               "limitations under the License." & vbCrLf

        NewLib.CopyrightNotice = "Copyright 2016 Signalworks Pty Ltd, ABN 26 066 681 598"

        NewLib.Version.Major = 1
        NewLib.Version.Minor = 0
        'NewLib.Version.Build = 1
        NewLib.Version.Build = 0
        NewLib.Version.Revision = 0

        NewLib.Author.Name = "Signalworks Pty Ltd"
        NewLib.Author.Description = "Signalworks Pty Ltd" & vbCrLf &
            "Australian Proprietary Company" & vbCrLf &
            "ABN 26 066 681 598" & vbCrLf &
            "Registration Date 05/10/1994"

        NewLib.Author.Contact = "http://www.andorville.com.au/"

        Dim NewClass1 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass1.Name = "ZipComp"
        NewClass1.Description = "The ZipComp class is used to compress files into and extract files from a zip file."
        NewLib.Classes.Add(NewClass1)
        Dim NewClass2 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass2.Name = "XSequence"
        NewClass2.Description = "The XSequence class is used to run an XML property sequence (XSequence) file. XSequence files are used to record and replay processing sequences in Andorville™ software applications."
        NewLib.Classes.Add(NewClass2)
        Dim NewClass3 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass3.Name = "XMessage"
        NewClass3.Description = "The XMessage class is used to read an XML Message (XMessage). An XMessage is a simplified XSequence used to exchange information between Andorville™ software applications."
        NewLib.Classes.Add(NewClass3)
        Dim NewClass4 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass4.Name = "Location"
        NewClass4.Description = "The Location class consists of properties and methods to store data in a location, which is either a directory or archive file."
        NewLib.Classes.Add(NewClass4)
        Dim NewClass5 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass5.Name = "Project"
        NewClass5.Description = "An Andorville™ software application can store data within one or more projects. Each project stores a set of related data files. The Project class contains properties and methods used to manage a project."
        NewLib.Classes.Add(NewClass5)
        Dim NewClass6 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass6.Name = "ProjectSummary"
        NewClass6.Description = "ProjectSummary stores a summary of a project."
        NewLib.Classes.Add(NewClass6)
        Dim NewClass7 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass7.Name = "DataFileInfo"
        NewClass7.Description = "The DataFileInfo class stores information about a data file."
        NewLib.Classes.Add(NewClass7)
        Dim NewClass8 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass8.Name = "Message"
        NewClass8.Description = "The Message class contains text properties and methods used to display messages in an Andorville™ software application."
        NewLib.Classes.Add(NewClass8)
        Dim NewClass9 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass9.Name = "ApplicationSummary"
        NewClass9.Description = "The ApplicationSummary class stores a summary of an Andorville™ software application."
        NewLib.Classes.Add(NewClass9)
        Dim NewClass10 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass10.Name = "LibrarySummary"
        NewClass10.Description = "The LibrarySummary class stores a summary of a software library used by an application."
        NewLib.Classes.Add(NewClass10)
        Dim NewClass11 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass11.Name = "ClassSummary"
        NewClass11.Description = "The ClassSummary class stores a summary of a class contained in a software library."
        NewLib.Classes.Add(NewClass11)
        Dim NewClass12 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass12.Name = "ModificationSummary"
        NewClass12.Description = "The ModificationSummary class stores a summary of any modifications made to an application or library."
        NewLib.Classes.Add(NewClass12)
        Dim NewClass13 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass13.Name = "ApplicationInfo"
        NewClass13.Description = "The ApplicationInfo class stores information about an Andorville™ software application."
        NewLib.Classes.Add(NewClass13)
        Dim NewClass14 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass14.Name = "Version"
        NewClass14.Description = "The Version class stores application, library or project version information."
        NewLib.Classes.Add(NewClass14)
        Dim NewClass15 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass15.Name = "Author"
        NewClass15.Description = "The Author class stores information about an Author."
        NewLib.Classes.Add(NewClass15)
        Dim NewClass16 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass16.Name = "FileAssociation"
        NewClass16.Description = "The FileAssociation class stores the file association extension and description. An application can open files on its file association list."
        NewLib.Classes.Add(NewClass16)
        Dim NewClass17 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass17.Name = "Copyright"
        NewClass17.Description = "The Copyright class stores copyright information."
        NewLib.Classes.Add(NewClass17)
        Dim NewClass18 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass18.Name = "License"
        NewClass18.Description = "The License class stores license information."
        NewLib.Classes.Add(NewClass18)
        Dim NewClass19 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass19.Name = "SourceCode"
        NewClass19.Description = "The SourceCode class stores information about the source code for the application."
        NewLib.Classes.Add(NewClass19)
        Dim NewClass20 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass20.Name = "Usage"
        NewClass20.Description = "The Usage class stores information about application or project usage."
        NewLib.Classes.Add(NewClass20)
        Dim NewClass21 As New ADVL_Utilities_Library_1.ClassSummary
        NewClass21.Name = "Trademark"
        NewClass21.Description = "The Trademark class stored information about a trademark used by the author of an application or data."
        NewLib.Classes.Add(NewClass21)

        ApplicationInfo.Libraries.Add(NewLib)

        'Add other library information here: --------------------------------------------------------------------------

    End Sub

    'Save the form settings if the form is being minimised:
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H112 Then 'SysCommand
            If m.WParam.ToInt32 = &HF020 Then 'Form is being minimised
                SaveFormSettings()
            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub SaveProjectSettings()
        'Save the project settings in an XML file.
        'Add any Project Settings to be saved into the settingsData XDocument.
        Dim settingsData = <?xml version="1.0" encoding="utf-8"?>
                           <!---->
                           <!--Project settings for ADVL_Coordinates_1 application.-->
                           <ProjectSettings>
                           </ProjectSettings>

        Dim SettingsFileName As String = "ProjectSettings_" & ApplicationInfo.Name & "_" & ".xml"
        Project.SaveXmlSettings(SettingsFileName, settingsData)
    End Sub

    Private Sub RestoreProjectSettings()
        'Restore the project settings from an XML document.

        Dim SettingsFileName As String = "ProjectSettings_" & ApplicationInfo.Name & "_" & ".xml"

        If Project.SettingsFileExists(SettingsFileName) Then
            Dim Settings As System.Xml.Linq.XDocument
            Project.ReadXmlSettings(SettingsFileName, Settings)

            If IsNothing(Settings) Then 'There is no Settings XML data.
                Exit Sub
            End If

            'Restore a Project Setting example:
            If Settings.<ProjectSettings>.<Setting1>.Value = Nothing Then
                'Project setting not saved.
                'Setting1 = ""
            Else
                'Setting1 = Settings.<ProjectSettings>.<Setting1>.Value
            End If

            'Continue restoring saved settings.

        End If

    End Sub

#End Region 'Process XML Files ----------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Form Display Methods - Code used to display this form." '============================================================================================================================

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Loading the Main form.

        'Set the Application Directory path: ------------------------------------------------
        Project.ApplicationDir = My.Application.Info.DirectoryPath.ToString

        'Read the Application Information file: ---------------------------------------------
        ApplicationInfo.ApplicationDir = My.Application.Info.DirectoryPath.ToString 'Set the Application Directory property

        ''Get the Application Version Information:
        'ApplicationInfo.Version.Major = My.Application.Info.Version.Major
        'ApplicationInfo.Version.Minor = My.Application.Info.Version.Minor
        'ApplicationInfo.Version.Build = My.Application.Info.Version.Build
        'ApplicationInfo.Version.Revision = My.Application.Info.Version.Revision

        If ApplicationInfo.ApplicationLocked Then
            MessageBox.Show("The application is locked. If the application is not already in use, remove the 'Application_Info.lock file from the application directory: " & ApplicationInfo.ApplicationDir, "Notice", MessageBoxButtons.OK)
            Dim dr As System.Windows.Forms.DialogResult
            dr = MessageBox.Show("Press 'Yes' to unlock the application", "Notice", MessageBoxButtons.YesNo)
            If dr = System.Windows.Forms.DialogResult.Yes Then
                ApplicationInfo.UnlockApplication()
            Else
                Application.Exit()
                Exit Sub
            End If
        End If

        ReadApplicationInfo()

        'Read the Application Usage information: --------------------------------------------
        ApplicationUsage.StartTime = Now
        ApplicationUsage.SaveLocn.Type = ADVL_Utilities_Library_1.FileLocation.Types.Directory
        ApplicationUsage.SaveLocn.Path = Project.ApplicationDir
        ApplicationUsage.RestoreUsageInfo()

        'Restore Project information: -------------------------------------------------------
        Project.Application.Name = ApplicationInfo.Name

        'Set up Message object:
        Message.ApplicationName = ApplicationInfo.Name

        'Set up a temporary initial settings location:
        Dim TempLocn As New ADVL_Utilities_Library_1.FileLocation
        TempLocn.Type = ADVL_Utilities_Library_1.FileLocation.Types.Directory
        TempLocn.Path = ApplicationInfo.ApplicationDir
        Message.SettingsLocn = TempLocn

        Me.Show() 'Show this form before showing the Message form - This will show the App icon on top in the TaskBar.

        'Start showing messages here - Message system is set up.
        Message.AddText("------------------- Starting Application: ADVL Coordinates Client 2 ----------------- " & vbCrLf, "Heading")
        'Message.AddText("Application usage: Total duration = " & Format(ApplicationUsage.TotalDuration.TotalHours, "#.##") & " hours" & vbCrLf, "Normal")
        Dim TotalDuration As String = ApplicationUsage.TotalDuration.Days.ToString.PadLeft(5, "0"c) & "d:" &
                           ApplicationUsage.TotalDuration.Hours.ToString.PadLeft(2, "0"c) & "h:" &
                           ApplicationUsage.TotalDuration.Minutes.ToString.PadLeft(2, "0"c) & "m:" &
                           ApplicationUsage.TotalDuration.Seconds.ToString.PadLeft(2, "0"c) & "s"
        Message.AddText("Application usage: Total duration = " & TotalDuration & vbCrLf, "Normal")

        'https://msdn.microsoft.com/en-us/library/z2d603cy(v=vs.80).aspx#Y550
        'Process any command line arguments:
        Try
            For Each s As String In My.Application.CommandLineArgs
                Message.Add("Command line argument: " & vbCrLf)
                Message.AddXml(s & vbCrLf & vbCrLf)
                InstrReceived = s
            Next
        Catch ex As Exception
            Message.AddWarning("Error processing command line arguments: " & ex.Message & vbCrLf)
        End Try

        If ProjectSelected = False Then
            'Read the Settings Location for the last project used:
            Project.ReadLastProjectInfo()
            'The Last_Project_Info.xml file contains:
            '  Project Name and Description. Settings Location Type and Settings Location Path.
            Message.Add("Last project details:" & vbCrLf)
            Message.Add("Project Type:  " & Project.Type.ToString & vbCrLf)
            Message.Add("Project Path:  " & Project.Path & vbCrLf)

            'At this point read the application start arguments, if any.
            'The selected project may be changed here.

            'Check if the project is locked:
            If Project.ProjectLocked Then
                Message.AddWarning("The project is locked: " & Project.Name & vbCrLf)
                Dim dr As System.Windows.Forms.DialogResult
                dr = MessageBox.Show("Press 'Yes' to unlock the project", "Notice", MessageBoxButtons.YesNo)
                If dr = System.Windows.Forms.DialogResult.Yes Then
                    Project.UnlockProject()
                    Message.AddWarning("The project has been unlocked: " & Project.Name & vbCrLf)
                    'Read the Project Information file: -------------------------------------------------
                    Message.Add("Reading project info." & vbCrLf)
                    Project.ReadProjectInfoFile()                 'Read the file in the SettingsLocation: ADVL_Project_Info.xml
                    Project.ReadParameters()
                    Project.ReadParentParameters()
                    If Project.ParentParameterExists("ProNetName") Then
                        Project.AddParameter("ProNetName", Project.ParentParameter("ProNetName").Value, Project.ParentParameter("ProNetName").Description) 'AddParameter will update the parameter if it already exists.
                        ProNetName = Project.Parameter("ProNetName").Value
                    Else
                        ProNetName = Project.GetParameter("ProNetName")
                    End If
                    If Project.ParentParameterExists("ProNetPath") Then 'Get the parent parameter value - it may have been updated.
                        Project.AddParameter("ProNetPath", Project.ParentParameter("ProNetPath").Value, Project.ParentParameter("ProNetPath").Description) 'AddParameter will update the parameter if it already exists.
                        ProNetPath = Project.Parameter("ProNetPath").Value
                    Else
                        ProNetPath = Project.GetParameter("ProNetPath") 'If the parameter does not exist, the value is set to ""
                    End If
                    Project.SaveParameters() 'These should be saved now - child projects look for parent parameters in the parameter file.

                    Project.LockProject() 'Lock the project while it is open in this application.
                    'Set the project start time. This is used to track project usage.
                    Project.Usage.StartTime = Now
                    ApplicationInfo.SettingsLocn = Project.SettingsLocn
                    'Set up the Message object:
                    Message.SettingsLocn = Project.SettingsLocn
                    Message.Show()
                Else
                    'Continue without any project selected.
                    Project.Name = ""
                    Project.Type = ADVL_Utilities_Library_1.Project.Types.None
                    Project.Description = ""
                    Project.SettingsLocn.Path = ""
                    Project.DataLocn.Path = ""
                End If
            Else
                'Read the Project Information file: -------------------------------------------------
                Message.Add("Reading project info." & vbCrLf)
                Project.ReadProjectInfoFile()  'Read the file in the Project Location: ADVL_Project_Info.xml
                Project.ReadParameters()
                Project.ReadParentParameters()
                If Project.ParentParameterExists("ProNetName") Then
                    Project.AddParameter("ProNetName", Project.ParentParameter("ProNetName").Value, Project.ParentParameter("ProNetName").Description) 'AddParameter will update the parameter if it already exists.
                    ProNetName = Project.Parameter("ProNetName").Value
                Else
                    ProNetName = Project.GetParameter("ProNetName")
                End If
                If Project.ParentParameterExists("ProNetPath") Then 'Get the parent parameter value - it may have been updated.
                    Project.AddParameter("ProNetPath", Project.ParentParameter("ProNetPath").Value, Project.ParentParameter("ProNetPath").Description) 'AddParameter will update the parameter if it already exists.
                    ProNetPath = Project.Parameter("ProNetPath").Value
                Else
                    ProNetPath = Project.GetParameter("ProNetPath") 'If the parameter does not exist, the value is set to ""
                End If
                Project.SaveParameters() 'These should be saved now - child projects look for parent parameters in the parameter file.

                Project.LockProject() 'Lock the project while it is open in this application.
                'Set the project start time. This is used to track project usage.
                Project.Usage.StartTime = Now
                ApplicationInfo.SettingsLocn = Project.SettingsLocn
                'Set up the Message object:
                Message.SettingsLocn = Project.SettingsLocn
                Message.Show() 'Added 18May19
            End If

        Else  'Project has been opened using Command Line arguments.
            Project.ReadParameters()
            Project.ReadParentParameters()
            If Project.ParentParameterExists("ProNetName") Then
                Project.AddParameter("ProNetName", Project.ParentParameter("ProNetName").Value, Project.ParentParameter("ProNetName").Description) 'AddParameter will update the parameter if it already exists.
                ProNetName = Project.Parameter("ProNetName").Value
            Else
                ProNetName = Project.GetParameter("ProNetName")
            End If
            If Project.ParentParameterExists("ProNetPath") Then 'Get the parent parameter value - it may have been updated.
                Project.AddParameter("ProNetPath", Project.ParentParameter("ProNetPath").Value, Project.ParentParameter("ProNetPath").Description) 'AddParameter will update the parameter if it already exists.
                ProNetPath = Project.Parameter("ProNetPath").Value
            Else
                ProNetPath = Project.GetParameter("ProNetPath") 'If the parameter does not exist, the value is set to ""
            End If
            Project.SaveParameters() 'These should be saved now - child projects look for parent parameters in the parameter file.

            Project.LockProject() 'Lock the project while it is open in this application.
            ProjectSelected = False 'Reset the Project Selected flag.

            'Set up the Message object:
            Message.SettingsLocn = Project.SettingsLocn
            Message.Show() 'Added 18May19
        End If

        'START Initialise the form: ===============================================================

        Me.WebBrowser1.ObjectForScripting = Me
        'IF THE LINE ABOVE PRODUCES AN ERROR ON STARTUP, CHECK THAT THE CODE ON THE FOLLOWING THREE LINES IS INSERTED JUST ABOVE THE Public Class Main STATEMENT.
        'Imports System.Security.Permissions
        '<PermissionSet(SecurityAction.Demand, Name:="FullTrust")>
        '<System.Runtime.InteropServices.ComVisibleAttribute(True)>

        bgwSendMessage.WorkerReportsProgress = True
        bgwSendMessage.WorkerSupportsCancellation = True

        bgwSendMessageAlt.WorkerReportsProgress = True
        bgwSendMessageAlt.WorkerSupportsCancellation = True

        bgwRunInstruction.WorkerReportsProgress = True
        bgwRunInstruction.WorkerSupportsCancellation = True

        ''UPDATE 6Oct21
        'bgwConnectToComNet.WorkerReportsProgress = True
        'bgwConnectToComNet.WorkerSupportsCancellation = True

        'UPDATE 8Oct21
        bgwCancelConn.WorkerSupportsCancellation = True

        InitialiseForm() 'Initialise the form for a new project.

        'END   Initialise the form: ---------------------------------------------------------------


        dgvDirectDTOps.ColumnCount = 5
        dgvDirectDTOps.Columns(0).HeaderText = "Name"
        dgvDirectDTOps.Columns(1).HeaderText = "Code"
        dgvDirectDTOps.Columns(2).HeaderText = "Accuracy"
        dgvDirectDTOps.Columns(3).HeaderText = "Reversible"
        dgvDirectDTOps.Columns(4).HeaderText = "Apply Reverse"
        dgvDirectDTOps.AllowUserToAddRows = False

        dgvInputToWgs84DTOps.ColumnCount = 5
        dgvInputToWgs84DTOps.Columns(0).HeaderText = "Name"
        dgvInputToWgs84DTOps.Columns(1).HeaderText = "Code"
        dgvInputToWgs84DTOps.Columns(2).HeaderText = "Accuracy"
        dgvInputToWgs84DTOps.Columns(3).HeaderText = "Reversible"
        dgvInputToWgs84DTOps.Columns(4).HeaderText = "Apply Reverse"
        dgvInputToWgs84DTOps.AllowUserToAddRows = False

        dgvWgs84ToOutputDTOps.ColumnCount = 5
        dgvWgs84ToOutputDTOps.Columns(0).HeaderText = "Name"
        dgvWgs84ToOutputDTOps.Columns(1).HeaderText = "Code"
        dgvWgs84ToOutputDTOps.Columns(2).HeaderText = "Accuracy"
        dgvWgs84ToOutputDTOps.Columns(3).HeaderText = "Reversible"
        dgvWgs84ToOutputDTOps.Columns(4).HeaderText = "Apply Reverse"
        dgvWgs84ToOutputDTOps.AllowUserToAddRows = False

        Dim NewFont As New Font("Arial", 11, FontStyle.Regular)

        dgvConversion.ColumnCount = 22
        dgvConversion.Columns(0).HeaderText = "Point Number"
        dgvConversion.Columns(0).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(0).ReadOnly = True
        dgvConversion.Columns(0).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(0).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(1).HeaderText = "Point Name"
        dgvConversion.Columns(1).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(1).ReadOnly = True
        dgvConversion.Columns(1).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(1).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(2).HeaderText = "Point Description"
        dgvConversion.Columns(2).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(2).ReadOnly = True
        dgvConversion.Columns(2).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(2).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(3).HeaderText = "Input Easting"
        dgvConversion.Columns(3).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(3).ReadOnly = True
        dgvConversion.Columns(3).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(3).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(4).HeaderText = "Input Northing"
        dgvConversion.Columns(4).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(4).ReadOnly = True
        dgvConversion.Columns(4).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(4).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(5).HeaderText = "Input Longitude"
        dgvConversion.Columns(5).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(5).ReadOnly = True
        dgvConversion.Columns(5).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(5).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(6).HeaderText = "Input Latitude"
        dgvConversion.Columns(6).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(6).ReadOnly = True
        dgvConversion.Columns(6).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(6).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(7).HeaderText = "Input Ellipsoidal Height"
        dgvConversion.Columns(7).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(7).ReadOnly = True
        dgvConversion.Columns(7).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(7).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(8).HeaderText = "Input X"
        dgvConversion.Columns(8).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(8).ReadOnly = True
        dgvConversion.Columns(8).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(8).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(9).HeaderText = "Input Y"
        dgvConversion.Columns(9).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(9).ReadOnly = True
        dgvConversion.Columns(9).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(9).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(10).HeaderText = "Input Z"
        dgvConversion.Columns(10).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(10).ReadOnly = True
        dgvConversion.Columns(10).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(10).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(11).HeaderText = "WGS 84 X"
        dgvConversion.Columns(11).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(1).ReadOnly = True
        dgvConversion.Columns(1).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(11).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(12).HeaderText = "WGS 84 Y"
        dgvConversion.Columns(12).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(12).ReadOnly = True
        dgvConversion.Columns(12).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(12).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(13).HeaderText = "WGS 84 Z"
        dgvConversion.Columns(13).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(13).ReadOnly = True
        dgvConversion.Columns(13).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(13).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(14).HeaderText = "Output X"
        dgvConversion.Columns(14).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(14).ReadOnly = True
        dgvConversion.Columns(14).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(14).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(15).HeaderText = "Output Y"
        dgvConversion.Columns(15).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(15).ReadOnly = True
        dgvConversion.Columns(15).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(15).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(16).HeaderText = "Output Z"
        dgvConversion.Columns(16).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(16).ReadOnly = True
        dgvConversion.Columns(16).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(16).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(17).HeaderText = "Output Longitude"
        dgvConversion.Columns(17).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(17).ReadOnly = True
        dgvConversion.Columns(17).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(17).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(18).HeaderText = "Output Latitude"
        dgvConversion.Columns(18).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(18).ReadOnly = True
        dgvConversion.Columns(18).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(18).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(19).HeaderText = "Output Ellipsoidal Height"
        dgvConversion.Columns(19).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(19).ReadOnly = True
        dgvConversion.Columns(19).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(19).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(20).HeaderText = "Output Easting"
        dgvConversion.Columns(20).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(20).ReadOnly = True
        dgvConversion.Columns(20).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(20).DefaultCellStyle.BackColor = Color.White
        dgvConversion.Columns(21).HeaderText = "Output Northing"
        dgvConversion.Columns(21).HeaderCell.Style.Font = NewFont
        dgvConversion.Columns(21).ReadOnly = True
        dgvConversion.Columns(21).DefaultCellStyle.Font = NewFont
        dgvConversion.Columns(21).DefaultCellStyle.BackColor = Color.White
        dgvConversion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvConversion.AutoResizeColumns()

        udPointFontSize.Minimum = 8
        udPointFontSize.Maximum = 24
        udPointFontSize.Increment = 0.5
        udPointFontSize.DecimalPlaces = 1
        udPointFontSize.Value = 11

        rbDirectDatumTrans.Checked = True 'Select the Direct Datum Transformation button.
        TabControl4.SelectedIndex = 0 'Select the Direct Datum Transformation tab.

        rbEnterInputLongLat.Checked = True
        chkShowInputLongLat.Checked = True
        chkShowOutputLongLat.Checked = True

        rbDecDegrees.Checked = True

        'rbInputLongLat.Checked = True
        'rbInputDecDegrees.Checked = True
        'rbOutputLongLat.Checked = True
        'rbOutputDecDegrees.Checked = True

        RestoreFormSettings() 'Restore the form settings

        UpdateConversionTable()
        'ApplyPointConversionSettings()
        'ReCalcConversionTable()


        OpenStartPage()
        Message.ShowXMessages = ShowXMessages
        Message.ShowSysMessages = ShowSysMessages
        RestoreProjectSettings() 'Restore the Project settings

        ShowProjectInfo() 'Show the project information.

        Message.AddText("------------------- Started OK -------------------------------------------------------------------------- " & vbCrLf & vbCrLf, "Heading")


        'Dim dr As System.Windows.Forms.DialogResult
        'dr = MessageBox.Show("Press OK to cancel the connection and run in Standalone mode.", "Notice", MessageBoxButtons.OK)

        bgwCancelConn.RunWorkerAsync() 'Show the cancel dialog.

        'For Each OpenForm In My.Application.OpenForms
        '    Message.Add("Open Form name :" & OpenForm.ToString & vbCrLf)
        'Next

        ''Check if a new form can be used to cancel the connection attempt:
        'WebPageList = New frmWebPageList
        'WebPageList.Show()
        'DOESNT WORK - Form start to display but cannot be used until the main form has finished loading.

        'Try starting it in bgwCancelConn


        If StartupConnectionName = "" Then
            If Project.ConnectOnOpen Then
                ConnectToComNet() 'The Project is set to connect when it is opened.
                'bgwConnectToComNet.RunWorkerAsync("")
                'NewConnectToComNet("")
            ElseIf ApplicationInfo.ConnectOnStartup Then
                ConnectToComNet() 'The Application is set to connect when it is started.
                'bgwConnectToComNet.RunWorkerAsync("")
            Else
                'Don't connect to ComNet.
            End If
        Else
            'Connect to ComNet using the connection name StartupConnectionName.
            ConnectToComNet(StartupConnectionName)
            'bgwConnectToComNet.RunWorkerAsync(StartupConnectionName)
        End If

        If bgwCancelConn.IsBusy Then

            'Message.Add("bgwCancelConn.Container.Components.Count : " & bgwCancelConn.Container.Components.Count & vbCrLf) 'ERROR

            SendKeys.Send("{ESC}") 'Close the MessageBox

            bgwCancelConn.CancelAsync()
            bgwCancelConn.Dispose()
            'bgwCancelConn = Nothing
            Message.Add("Cancel Connection Dialog stopped." & vbCrLf)


            'Message.Add("My.Application.OpenForms.Count :" & My.Application.OpenForms.Count & vbCrLf)
            'Dim I As Integer
            'For I = 1 To My.Application.OpenForms.Count
            '    Message.Add("Open Form name :" & My.Application.OpenForms(I - 1).Text & vbCrLf)
            'Next

            'For Each OpenForm In My.Application.OpenForms
            '    Message.Add("Open Form name :" & OpenForm.ToString & vbCrLf)
            'Next
        End If

        'Get the Application Version Information:
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            'Application is network deployed.
            ApplicationInfo.Version.Number = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
            ApplicationInfo.Version.Major = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Major
            ApplicationInfo.Version.Minor = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor
            ApplicationInfo.Version.Build = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Build
            ApplicationInfo.Version.Revision = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision
            ApplicationInfo.Version.Source = "Publish"
            Message.Add("Application version: " & System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString & vbCrLf)
        Else
            'Application is not network deployed.
            ApplicationInfo.Version.Number = My.Application.Info.Version.ToString
            ApplicationInfo.Version.Major = My.Application.Info.Version.Major
            ApplicationInfo.Version.Minor = My.Application.Info.Version.Minor
            ApplicationInfo.Version.Build = My.Application.Info.Version.Build
            ApplicationInfo.Version.Revision = My.Application.Info.Version.Revision
            ApplicationInfo.Version.Source = "Assembly"
            Message.Add("Application version: " & My.Application.Info.Version.ToString & vbCrLf)
        End If

        'These methods use bgwSendMessage to avoid locking up the application.
        ApplyPointConversionSettings()
        'ReCalcConversionTable() No connection available???

    End Sub

    'THE FOLLOWING CODE DOESNT FIX THE ERROR THAT IS RAISED WHEN THE CONNECTION IS MADE USING bgwConnectToComNet
    'Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    '    'This code is executed after the form is shown

    '    If StartupConnectionName = "" Then
    '        If Project.ConnectOnOpen Then
    '            'ConnectToComNet() 'The Project is set to connect when it is opened.
    '            'bgwConnectToComNet.RunWorkerAsync("")
    '            NewConnectToComNet("")
    '        ElseIf ApplicationInfo.ConnectOnStartup Then
    '            ConnectToComNet() 'The Application is set to connect when it is started.
    '            'bgwConnectToComNet.RunWorkerAsync("")
    '        Else
    '            'Don't connect to ComNet.
    '        End If
    '    Else
    '        'Connect to ComNet using the connection name StartupConnectionName.
    '        ConnectToComNet(StartupConnectionName)
    '        'bgwConnectToComNet.RunWorkerAsync(StartupConnectionName)
    '    End If

    'End Sub

    Private Sub InitialiseForm()
        'Initialise the form for a new project.
        'OpenStartPage()
    End Sub

    Private Sub ShowProjectInfo()
        'Show the project information:

        txtParentProject.Text = Project.ParentProjectName
        txtProNetName.Text = Project.GetParameter("ProNetName")
        txtProjectName.Text = Project.Name
        txtProjectDescription.Text = Project.Description
        Select Case Project.Type
            Case ADVL_Utilities_Library_1.Project.Types.Directory
                txtProjectType.Text = "Directory"
            Case ADVL_Utilities_Library_1.Project.Types.Archive
                txtProjectType.Text = "Archive"
            Case ADVL_Utilities_Library_1.Project.Types.Hybrid
                txtProjectType.Text = "Hybrid"
            Case ADVL_Utilities_Library_1.Project.Types.None
                txtProjectType.Text = "None"
        End Select

        txtCreationDate.Text = Format(Project.Usage.FirstUsed, "d-MMM-yyyy H:mm:ss")
        txtLastUsed.Text = Format(Project.Usage.LastUsed, "d-MMM-yyyy H:mm:ss")

        txtProjectPath.Text = Project.Path

        Select Case Project.SettingsLocn.Type
            Case ADVL_Utilities_Library_1.FileLocation.Types.Directory
                txtSettingsLocationType.Text = "Directory"
            Case ADVL_Utilities_Library_1.FileLocation.Types.Archive
                txtSettingsLocationType.Text = "Archive"
        End Select
        txtSettingsPath.Text = Project.SettingsLocn.Path

        Select Case Project.DataLocn.Type
            Case ADVL_Utilities_Library_1.FileLocation.Types.Directory
                txtDataLocationType.Text = "Directory"
            Case ADVL_Utilities_Library_1.FileLocation.Types.Archive
                txtDataLocationType.Text = "Archive"
        End Select
        txtDataPath.Text = Project.DataLocn.Path

        Select Case Project.SystemLocn.Type
            Case ADVL_Utilities_Library_1.FileLocation.Types.Directory
                txtSystemLocationType.Text = "Directory"
            Case ADVL_Utilities_Library_1.FileLocation.Types.Archive
                txtSystemLocationType.Text = "Archive"
        End Select
        txtSystemPath.Text = Project.SystemLocn.Path

        If Project.ConnectOnOpen Then
            chkConnect.Checked = True
        Else
            chkConnect.Checked = False
        End If

        'txtTotalDuration.Text = Project.Usage.TotalDuration.Days.ToString.PadLeft(5, "0"c) & ":" &
        '                        Project.Usage.TotalDuration.Hours.ToString.PadLeft(2, "0"c) & ":" &
        '                        Project.Usage.TotalDuration.Minutes.ToString.PadLeft(2, "0"c) & ":" &
        '                        Project.Usage.TotalDuration.Seconds.ToString.PadLeft(2, "0"c)

        'txtCurrentDuration.Text = Project.Usage.CurrentDuration.Days.ToString.PadLeft(5, "0"c) & ":" &
        '                          Project.Usage.CurrentDuration.Hours.ToString.PadLeft(2, "0"c) & ":" &
        '                          Project.Usage.CurrentDuration.Minutes.ToString.PadLeft(2, "0"c) & ":" &
        '                          Project.Usage.CurrentDuration.Seconds.ToString.PadLeft(2, "0"c)

        txtTotalDuration.Text = Project.Usage.TotalDuration.Days.ToString.PadLeft(5, "0"c) & "d:" &
                Project.Usage.TotalDuration.Hours.ToString.PadLeft(2, "0"c) & "h:" &
                Project.Usage.TotalDuration.Minutes.ToString.PadLeft(2, "0"c) & "m:" &
                Project.Usage.TotalDuration.Seconds.ToString.PadLeft(2, "0"c) & "s"

        txtCurrentDuration.Text = Project.Usage.CurrentDuration.Days.ToString.PadLeft(5, "0"c) & "d:" &
                                  Project.Usage.CurrentDuration.Hours.ToString.PadLeft(2, "0"c) & "h:" &
                                  Project.Usage.CurrentDuration.Minutes.ToString.PadLeft(2, "0"c) & "m:" &
                                  Project.Usage.CurrentDuration.Seconds.ToString.PadLeft(2, "0"c) & "s"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the Application

        DisconnectFromComNet() 'Disconnect from the Communication Network (Message Service).

        SaveProjectSettings() 'Save project settings.

        ApplicationInfo.WriteFile() 'Update the Application Information file.

        Project.SaveLastProjectInfo() 'Save information about the last project used.

        Project.SaveParameters()

        'Project.SaveProjectInfoFile() 'Update the Project Information file. This is not required unless there is a change made to the project.

        Project.Usage.SaveUsageInfo() 'Save Project usage information.

        Project.UnlockProject() 'Unlock the project.

        ApplicationUsage.SaveUsageInfo() 'Save Application usage information.
        ApplicationInfo.UnlockApplication()

        Application.Exit()

    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Save the form settings if the form state is normal. (A minimised form will have the incorrect size and location.)
        If WindowState = FormWindowState.Normal Then
            SaveFormSettings()
        End If
    End Sub


#End Region 'Form Display Methods -------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Open and Close Forms - Code used to open and close other forms." '===================================================================================================================

    'Private Sub btnOpenTemplateForm_Click(sender As Object, e As EventArgs) Handles btnOpenTemplateForm.Click
    '    'Open the Template form:
    '    If IsNothing(TemplateForm) Then
    '        TemplateForm = New frmTemplate
    '        TemplateForm.Show()
    '    Else
    '        TemplateForm.Show()
    '    End If
    'End Sub

    'Private Sub TemplateForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles TemplateForm.FormClosed
    '    TemplateForm = Nothing
    'End Sub

    Private Sub btnMessages_Click(sender As Object, e As EventArgs) Handles btnMessages.Click
        'Show the Messages form.
        Message.ApplicationName = ApplicationInfo.Name
        Message.SettingsLocn = Project.SettingsLocn
        Message.Show()
        Message.ShowXMessages = ShowXMessages
        Message.MessageForm.BringToFront()
    End Sub

    Private Sub btnWebPages_Click(sender As Object, e As EventArgs) Handles btnWebPages.Click
        'Open the Web Pages form.

        If IsNothing(WebPageList) Then
            WebPageList = New frmWebPageList
            WebPageList.Show()
        Else
            WebPageList.Show()
            WebPageList.BringToFront()
        End If
    End Sub

    Private Sub WebPageList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles WebPageList.FormClosed
        WebPageList = Nothing
    End Sub

    Public Function OpenNewWebPage() As Integer
        'Open a new HTML Web View window, or reuse an existing one if avaiable.
        'The new forms index number in WebViewFormList is returned.

        NewWebPage = New frmWebPage
        If WebPageFormList.Count = 0 Then
            WebPageFormList.Add(NewWebPage)
            WebPageFormList(0).FormNo = 0
            WebPageFormList(0).Show
            Return 0 'The new HTML Display is at position 0 in WebViewFormList()
        Else
            Dim I As Integer
            Dim FormAdded As Boolean = False
            For I = 0 To WebPageFormList.Count - 1 'Check if there are closed forms in WebViewFormList. They can be re-used.
                If IsNothing(WebPageFormList(I)) Then
                    WebPageFormList(I) = NewWebPage
                    WebPageFormList(I).FormNo = I
                    WebPageFormList(I).Show
                    FormAdded = True
                    Return I 'The new Html Display is at position I in WebViewFormList()
                    Exit For
                End If
            Next
            If FormAdded = False Then 'Add a new form to WebViewFormList
                Dim FormNo As Integer
                WebPageFormList.Add(NewWebPage)
                FormNo = WebPageFormList.Count - 1
                WebPageFormList(FormNo).FormNo = FormNo
                WebPageFormList(FormNo).Show
                Return FormNo 'The new WebPage is at position FormNo in WebPageFormList()
            End If
        End If
    End Function

    Public Sub WebPageFormClosed()
        'This subroutine is called when the Web Page form has been closed.
        'The subroutine is usually called from the FormClosed event of the WebPage form.
        'The WebPage form may have multiple instances.
        'The ClosedFormNumber property should contain the number of the instance of the WebPage form.
        'This property should be updated by the WebPage form when it is being closed.
        'The ClosedFormNumber property value is used to determine which element in WebPageList should be set to Nothing.

        If WebPageFormList.Count < ClosedFormNo + 1 Then
            'ClosedFormNo is too large to exist in WebPageFormList
            Exit Sub
        End If

        If IsNothing(WebPageFormList(ClosedFormNo)) Then
            'The form is already set to nothing
        Else
            WebPageFormList(ClosedFormNo) = Nothing
        End If
    End Sub

    Public Function OpenNewHtmlDisplayPage() As Integer
        'Open a new HTML display window, or reuse an existing one if avaiable.
        'The new forms index number in HtmlDisplayFormList is returned.

        NewHtmlDisplay = New frmHtmlDisplay
        If HtmlDisplayFormList.Count = 0 Then
            HtmlDisplayFormList.Add(NewHtmlDisplay)
            HtmlDisplayFormList(0).FormNo = 0
            HtmlDisplayFormList(0).Show
            Return 0 'The new HTML Display is at position 0 in HtmlDisplayFormList()
        Else
            Dim I As Integer
            Dim FormAdded As Boolean = False
            For I = 0 To HtmlDisplayFormList.Count - 1 'Check if there are closed forms in HtmlDisplayFormList. They can be re-used.
                If IsNothing(HtmlDisplayFormList(I)) Then
                    HtmlDisplayFormList(I) = NewHtmlDisplay
                    HtmlDisplayFormList(I).FormNo = I
                    HtmlDisplayFormList(I).Show
                    FormAdded = True
                    Return I 'The new Html Display is at position I in HtmlDisplayFormList()
                    Exit For
                End If
            Next
            If FormAdded = False Then 'Add a new form to HtmlDisplayFormList
                Dim FormNo As Integer
                HtmlDisplayFormList.Add(NewHtmlDisplay)
                FormNo = HtmlDisplayFormList.Count - 1
                HtmlDisplayFormList(FormNo).FormNo = FormNo
                HtmlDisplayFormList(FormNo).Show
                Return FormNo 'The new HtmlDisplay is at position FormNo in HtmlDisplayFormList()
            End If
        End If
    End Function

    Public Sub HtmlDisplayFormClosed()
        'This subroutine is called when the Html Display form has been closed.
        'The subroutine is usually called from the FormClosed event of the HtmlDisplay form.
        'The HtmlDisplay form may have multiple instances.
        'The ClosedFormNumber property should contain the number of the instance of the HtmlDisplay form.
        'This property should be updated by the HtmlDisplay form when it is being closed.
        'The ClosedFormNumber property value is used to determine which element in HtmlDisplayList should be set to Nothing.

        If HtmlDisplayFormList.Count < ClosedFormNo + 1 Then
            'ClosedFormNo is too large to exist in HtmlDisplayFormList
            Exit Sub
        End If

        If IsNothing(HtmlDisplayFormList(ClosedFormNo)) Then
            'The form is already set to nothing
        Else
            HtmlDisplayFormList(ClosedFormNo) = Nothing
        End If
    End Sub



#End Region 'Open and Close Forms -------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Form Methods - The main actions performed by this form." '===========================================================================================================================

    Public Sub CloseAppAtConnection(ByVal ProNetName As String, ByVal ConnectionName As String)
        'Close the application and project at the specified connection.

        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                'Create the XML instructions to close the application at the connection.
                Dim decl As New XDeclaration("1.0", "utf-8", "yes")
                Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
                Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

                Dim command As New XElement("Command", "Close")
                xmessage.Add(command)
                doc.Add(xmessage)

                'Show the message sent:
                Message.XAddText("Message sent to: [" & ProNetName & "]." & ConnectionName & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line
                client.SendMessage(ProNetName, ConnectionName, doc.ToString)
            End If
        End If
    End Sub

    Private Sub btnProject_Click(sender As Object, e As EventArgs) Handles btnProject.Click
        Project.SelectProject()
    End Sub

    Private Sub btnParameters_Click(sender As Object, e As EventArgs) Handles btnParameters.Click
        Project.ShowParameters()
    End Sub

    Private Sub btnAppInfo_Click(sender As Object, e As EventArgs) Handles btnAppInfo.Click
        ApplicationInfo.ShowInfo()
    End Sub

    Private Sub btnAndorville_Click(sender As Object, e As EventArgs) Handles btnAndorville.Click
        ApplicationInfo.ShowInfo()
    End Sub

    Private Sub ApplicationInfo_UpdateExePath() Handles ApplicationInfo.UpdateExePath
        'Update the Executable Path.
        ApplicationInfo.ExecutablePath = Application.ExecutablePath
    End Sub

    Private Sub ApplicationInfo_RestoreDefaults() Handles ApplicationInfo.RestoreDefaults
        'Restore the default application settings.
        DefaultAppProperties()
    End Sub

    Public Sub UpdateWebPage(ByVal FileName As String)
        'Update the web page in WebPageFormList if the Web file name is FileName.

        Dim NPages As Integer = WebPageFormList.Count
        Dim I As Integer

        Try
            For I = 0 To NPages - 1
                If IsNothing(WebPageFormList(I)) Then
                    'Web page has been deleted!
                Else
                    If WebPageFormList(I).FileName = FileName Then
                        WebPageFormList(I).OpenDocument
                    End If
                End If
            Next
        Catch ex As Exception
            Message.AddWarning(ex.Message & vbCrLf)
        End Try
    End Sub


#Region " Start Page Code" '=========================================================================================================================================

    Public Sub OpenStartPage()
        'Open the workflow page:

        If Project.DataFileExists(WorkflowFileName) Then
            'Note: WorkflowFileName should have been restored when the application started.
            DisplayWorkflow()
        ElseIf Project.DataFileExists("StartPage.html") Then
            WorkflowFileName = "StartPage.html"
            DisplayWorkflow()
        Else
            CreateStartPage()
            WorkflowFileName = "StartPage.html"
            DisplayWorkflow()
        End If

        'Open the StartPage.html file and display in the Workflow tab.
        'If Project.DataFileExists("StartPage.html") Then
        '    WorkflowFileName = "StartPage.html"
        '    DisplayWorkflow()
        'Else
        '    CreateStartPage()
        '    WorkflowFileName = "StartPage.html"
        '    DisplayWorkflow()
        'End If

    End Sub

    Public Sub DisplayWorkflow()
        'Display the StartPage.html file in the Start Page tab.

        If Project.DataFileExists(WorkflowFileName) Then
            Dim rtbData As New IO.MemoryStream
            Project.ReadData(WorkflowFileName, rtbData)
            rtbData.Position = 0
            Dim sr As New IO.StreamReader(rtbData)
            WebBrowser1.DocumentText = sr.ReadToEnd()
        Else
            Message.AddWarning("Web page file not found: " & WorkflowFileName & vbCrLf)
        End If
    End Sub

    Private Sub CreateStartPage()
        'Create a new default StartPage.html file.

        Dim htmData As New IO.MemoryStream
        Dim sw As New IO.StreamWriter(htmData)
        sw.Write(AppInfoHtmlString("Application Information")) 'Create a web page providing information about the application.
        sw.Flush()
        Project.SaveData("StartPage.html", htmData)
    End Sub

    Public Function AppInfoHtmlString(ByVal DocumentTitle As String) As String
        'Create an Application Information Web Page.

        'This function should be edited to provide a brief description of the Application.

        Dim sb As New System.Text.StringBuilder

        sb.Append("<!DOCTYPE html>" & vbCrLf)
        sb.Append("<html>" & vbCrLf)
        sb.Append("<head>" & vbCrLf)
        sb.Append("<title>" & DocumentTitle & "</title>" & vbCrLf)
        sb.Append("<meta name=""description"" content=""Application information."">" & vbCrLf)
        sb.Append("</head>" & vbCrLf)

        sb.Append("<body style=""font-family:arial;"">" & vbCrLf & vbCrLf)

        sb.Append("<h2>" & "Andorville&trade; Coordinates Client 2" & "</h2>" & vbCrLf & vbCrLf) 'Add the page title.
        sb.Append("<hr>" & vbCrLf) 'Add a horizontal divider line.
        sb.Append("<p>The ADVL_Coordinates_Client_2 is a demonstration of a client application controlling the ADVL_Coordinates_2 server.</p>" & vbCrLf) 'Add an application description.
        sb.Append("<hr>" & vbCrLf & vbCrLf) 'Add a horizontal divider line.

        sb.Append(DefaultJavaScriptString)

        sb.Append("</body>" & vbCrLf)
        sb.Append("</html>" & vbCrLf)

        Return sb.ToString

    End Function

    Public Function DefaultJavaScriptString() As String
        'Generate the default JavaScript section of an Andorville(TM) Workflow Web Page.

        Dim sb As New System.Text.StringBuilder

        'Add JavaScript section:
        sb.Append("<script>" & vbCrLf & vbCrLf)

        'START: User defined JavaScript functions ==========================================================================
        'Add functions to implement the main actions performed by this web page.
        sb.Append("//START: User defined JavaScript functions ==========================================================================" & vbCrLf)
        sb.Append("//  Add functions to implement the main actions performed by this web page." & vbCrLf & vbCrLf)

        sb.Append("//END:   User defined JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf & vbCrLf)
        'END:   User defined JavaScript functions --------------------------------------------------------------------------


        'START: User modified JavaScript functions ==========================================================================
        'Modify these function to save all required web page settings and process all expected XMessage instructions.
        sb.Append("//START: User modified JavaScript functions ==========================================================================" & vbCrLf)
        sb.Append("//  Modify these function to save all required web page settings and process all expected XMessage instructions." & vbCrLf & vbCrLf)

        'Add the Start Up code section.
        sb.Append("//Code to execute on Start Up:" & vbCrLf)
        sb.Append("function StartUpCode() {" & vbCrLf)
        sb.Append("  RestoreSettings() ;" & vbCrLf)
        sb.Append("}" & vbCrLf & vbCrLf)

        'Add the SaveSettings function - This is used to save web page settings between sessions.
        sb.Append("//Save the web page settings." & vbCrLf)
        sb.Append("function SaveSettings() {" & vbCrLf)
        sb.Append("  var xSettings = ""<Settings>"" + "" \n"" ; //String containing the web page settings in XML format." & vbCrLf)
        sb.Append("  //Add xml lines to save each setting." & vbCrLf & vbCrLf)
        sb.Append("  xSettings +=    ""</Settings>"" + ""\n"" ; //End of the Settings element." & vbCrLf)
        sb.Append(vbCrLf)
        sb.Append("  //Save the settings as an XML file in the project." & vbCrLf)
        sb.Append("  window.external.SaveHtmlSettings(xSettings) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Process a single XMsg instruction (Information:Location pair)
        sb.Append("//Process an XMessage instruction:" & vbCrLf)
        sb.Append("function XMsgInstruction(Info, Locn) {" & vbCrLf)
        sb.Append("  switch(Locn) {" & vbCrLf)
        sb.Append("  //Insert case statements here." & vbCrLf)
        sb.Append(vbCrLf)

        'sb.Append(vbCrLf)
        'sb.Append("  case ""Status"" :" & vbCrLf)
        'sb.Append("    if (Info = ""OK"") { " & vbCrLf)
        'sb.Append("      //Instruction processing completed OK:" & vbCrLf)
        'sb.Append("      } else {" & vbCrLf)
        'sb.Append("      window.external.AddWarning(""Error: Unknown Status information: "" + "" Info: "" + Info + ""\r\n"") ;" & vbCrLf)
        'sb.Append("     }" & vbCrLf)
        'sb.Append("    break ;" & vbCrLf)
        'sb.Append(vbCrLf)

        'sb.Append("  case ""OnCompletion"" :" & vbCrLf)
        sb.Append("  case ""EndInstruction"" :" & vbCrLf)
        sb.Append("    switch(Info) {" & vbCrLf)
        sb.Append("      case ""Stop"" :" & vbCrLf)
        sb.Append("        //Do nothing." & vbCrLf)
        sb.Append("        break ;" & vbCrLf)
        sb.Append(vbCrLf)
        sb.Append("      default:" & vbCrLf)
        'sb.Append("        window.external.AddWarning(""Error: Unknown OnCompletion information:  "" + "" Info: "" + Info + ""\r\n"") ;" & vbCrLf)
        sb.Append("        window.external.AddWarning(""Error: Unknown EndInstruction information:  "" + "" Info: "" + Info + ""\r\n"") ;" & vbCrLf)
        sb.Append("        break ;" & vbCrLf)
        sb.Append("    }" & vbCrLf)
        sb.Append("    break ;" & vbCrLf)
        sb.Append(vbCrLf)

        sb.Append("  case ""Status"" :" & vbCrLf)
        sb.Append("    switch(Info) {" & vbCrLf)
        sb.Append("      case ""OK"" :" & vbCrLf)
        sb.Append("        //Instruction processing completed OK." & vbCrLf)
        sb.Append("        break ;" & vbCrLf)
        sb.Append(vbCrLf)
        sb.Append("      default:" & vbCrLf)
        sb.Append("        window.external.AddWarning(""Error: Unknown Status information:  "" + "" Info: "" + Info + ""\r\n"") ;" & vbCrLf)
        sb.Append("        break ;" & vbCrLf)
        sb.Append("    }" & vbCrLf)
        sb.Append("    break ;" & vbCrLf)
        sb.Append(vbCrLf)

        sb.Append("  default:" & vbCrLf)
        sb.Append("    window.external.AddWarning(""Unknown location: "" + Locn + ""\r\n"") ;" & vbCrLf)
        sb.Append("  }" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        sb.Append("//END:   User modified JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf & vbCrLf)
        'END:   User modified JavaScript functions --------------------------------------------------------------------------

        'START: Required Document Library Web Page JavaScript functions ==========================================================================
        sb.Append("//START: Required Document Library Web Page JavaScript functions ==========================================================================" & vbCrLf & vbCrLf)

        'Add the AddText function - This sends a message to the message window using a named text type.
        sb.Append("//Add text to the Message window using a named txt type:" & vbCrLf)
        sb.Append("function AddText(Msg, TextType) {" & vbCrLf)
        sb.Append("  window.external.AddText(Msg, TextType) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the AddMessage function - This sends a message to the message window using default black text.
        sb.Append("//Add a message to the Message window using the default black text:" & vbCrLf)
        sb.Append("function AddMessage(Msg) {" & vbCrLf)
        sb.Append("  window.external.AddMessage(Msg) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the AddWarning function - This sends a red, bold warning message to the message window.
        sb.Append("//Add a warning message to the Message window using bold red text:" & vbCrLf)
        sb.Append("function AddWarning(Msg) {" & vbCrLf)
        sb.Append("  window.external.AddWarning(Msg) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the RestoreSettings function - This is used to restore web page settings.
        sb.Append("//Restore the web page settings." & vbCrLf)
        sb.Append("function RestoreSettings() {" & vbCrLf)
        sb.Append("  window.external.RestoreHtmlSettings() " & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'This line runs the RestoreSettings function when the web page is loaded.
        sb.Append("//Restore the web page settings when the page loads." & vbCrLf)
        'sb.Append("window.onload = RestoreSettings; " & vbCrLf)
        sb.Append("window.onload = StartUpCode ; " & vbCrLf)
        sb.Append(vbCrLf)

        'Restores a single setting on the web page.
        sb.Append("//Restore a web page setting." & vbCrLf)
        sb.Append("  function RestoreSetting(FormName, ItemName, ItemValue) {" & vbCrLf)
        sb.Append("  document.forms[FormName][ItemName].value = ItemValue ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the RestoreOption function - This is used to add an option to a Select list.
        sb.Append("//Restore a Select control Option." & vbCrLf)
        sb.Append("function RestoreOption(SelectId, OptionText) {" & vbCrLf)
        sb.Append("  var x = document.getElementById(SelectId) ;" & vbCrLf)
        sb.Append("  var option = document.createElement(""Option"") ;" & vbCrLf)
        sb.Append("  option.text = OptionText ;" & vbCrLf)
        sb.Append("  x.add(option) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        sb.Append("//END:   Required Document Library Web Page JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf)
        'END:   Required Document Library Web Page JavaScript functions --------------------------------------------------------------------------

        sb.Append("</script>" & vbCrLf & vbCrLf)

        Return sb.ToString

    End Function

    Public Function DefaultJavaScriptString_Old() As String
        'Generate the default JavaScript section of an Andorville(TM) Workflow Web Page.

        Dim sb As New System.Text.StringBuilder

        'Add JavaScript section:
        sb.Append("<script>" & vbCrLf & vbCrLf)

        'START: User defined JavaScript functions ==========================================================================
        'Add functions to implement the main actions performed by this web page.
        sb.Append("//START: User defined JavaScript functions ==========================================================================" & vbCrLf)
        sb.Append("//  Add functions to implement the main actions performed by this web page." & vbCrLf & vbCrLf)

        sb.Append("//END:   User defined JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf & vbCrLf)
        'END:   User defined JavaScript functions --------------------------------------------------------------------------


        'START: User modified JavaScript functions ==========================================================================
        'Modify these function to save all required web page settings and process all expected XMessage instructions.
        sb.Append("//START: User modified JavaScript functions ==========================================================================" & vbCrLf)
        sb.Append("//  Modify these function to save all required web page settings and process all expected XMessage instructions." & vbCrLf & vbCrLf)

        'Add the Start Up code section.
        sb.Append("//Code to execute on Start Up:" & vbCrLf)
        sb.Append("function StartUpCode() {" & vbCrLf)
        sb.Append("  RestoreSettings() ;" & vbCrLf)
        'sb.Append("  GetCalcsDbPath() ;" & vbCrLf)
        sb.Append("}" & vbCrLf & vbCrLf)

        'Add the SaveSettings function - This is used to save web page settings between sessions.
        sb.Append("//Save the web page settings." & vbCrLf)
        sb.Append("function SaveSettings() {" & vbCrLf)
        sb.Append("  var xSettings = ""<Settings>"" + "" \n"" ; //String containing the web page settings in XML format." & vbCrLf)
        sb.Append("  //Add xml lines to save each setting." & vbCrLf & vbCrLf)
        sb.Append("  xSettings +=    ""</Settings>"" + ""\n"" ; //End of the Settings element." & vbCrLf)
        sb.Append(vbCrLf)
        sb.Append("  //Save the settings as an XML file in the project." & vbCrLf)
        sb.Append("  window.external.SaveHtmlSettings(xSettings) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Process a single XMsg instruction (Information:Location pair)
        sb.Append("//Process an XMessage instruction:" & vbCrLf)
        sb.Append("function XMsgInstruction(Info, Locn) {" & vbCrLf)
        sb.Append("  switch(Locn) {" & vbCrLf)
        sb.Append("  //Insert case statements here." & vbCrLf)
        sb.Append("  case ""Status"" :" & vbCrLf)
        sb.Append("    if (Info = ""OK"") { " & vbCrLf)
        sb.Append("      //Instruction processing completed OK:" & vbCrLf)
        sb.Append("      } else {" & vbCrLf)
        sb.Append("      window.external.AddWarning(""Error: Unknown Status information: "" + "" Info: "" + Info + ""\r\n"") ;" & vbCrLf)
        sb.Append("     }" & vbCrLf)
        sb.Append("    break ;" & vbCrLf)
        sb.Append(vbCrLf)
        sb.Append("  default:" & vbCrLf)
        sb.Append("    window.external.AddWarning(""Unknown location: "" + Locn + ""\r\n"") ;" & vbCrLf)
        sb.Append("  }" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        sb.Append("//END:   User modified JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf & vbCrLf)
        'END:   User modified JavaScript functions --------------------------------------------------------------------------

        'START: Required Document Library Web Page JavaScript functions ==========================================================================
        sb.Append("//START: Required Document Library Web Page JavaScript functions ==========================================================================" & vbCrLf & vbCrLf)

        'Add the AddText function - This sends a message to the message window using a named text type.
        sb.Append("//Add text to the Message window using a named txt type:" & vbCrLf)
        sb.Append("function AddText(Msg, TextType) {" & vbCrLf)
        sb.Append("  window.external.AddText(Msg, TextType) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the AddMessage function - This sends a message to the message window using default black text.
        sb.Append("//Add a message to the Message window using the default black text:" & vbCrLf)
        sb.Append("function AddMessage(Msg) {" & vbCrLf)
        sb.Append("  window.external.AddMessage(Msg) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the AddWarning function - This sends a red, bold warning message to the message window.
        sb.Append("//Add a warning message to the Message window using bold red text:" & vbCrLf)
        sb.Append("function AddWarning(Msg) {" & vbCrLf)
        sb.Append("  window.external.AddWarning(Msg) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the RestoreSettings function - This is used to restore web page settings.
        sb.Append("//Restore the web page settings." & vbCrLf)
        sb.Append("function RestoreSettings() {" & vbCrLf)
        sb.Append("  window.external.RestoreHtmlSettings() " & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'This line runs the RestoreSettings function when the web page is loaded.
        sb.Append("//Restore the web page settings when the page loads." & vbCrLf)
        'sb.Append("window.onload = RestoreSettings; " & vbCrLf)
        sb.Append("window.onload = StartUpCode ; " & vbCrLf)
        sb.Append(vbCrLf)

        'Restores a single setting on the web page.
        sb.Append("//Restore a web page setting." & vbCrLf)
        sb.Append("  function RestoreSetting(FormName, ItemName, ItemValue) {" & vbCrLf)
        sb.Append("  document.forms[FormName][ItemName].value = ItemValue ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the RestoreOption function - This is used to add an option to a Select list.
        sb.Append("//Restore a Select control Option." & vbCrLf)
        sb.Append("function RestoreOption(SelectId, OptionText) {" & vbCrLf)
        sb.Append("  var x = document.getElementById(SelectId) ;" & vbCrLf)
        sb.Append("  var option = document.createElement(""Option"") ;" & vbCrLf)
        sb.Append("  option.text = OptionText ;" & vbCrLf)
        sb.Append("  x.add(option) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        sb.Append("//END:   Required Document Library Web Page JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf)
        'END:   Required Document Library Web Page JavaScript functions --------------------------------------------------------------------------

        sb.Append("</script>" & vbCrLf & vbCrLf)

        Return sb.ToString

    End Function

    Public Function DefaultHtmlString(ByVal DocumentTitle As String) As String
        'Create a blank HTML Web Page.

        Dim sb As New System.Text.StringBuilder

        sb.Append("<!DOCTYPE html>" & vbCrLf)
        sb.Append("<html>" & vbCrLf)
        sb.Append("<!-- Andorville(TM) Workflow File -->" & vbCrLf)
        sb.Append("<!-- Application Name:    " & ApplicationInfo.Name & " -->" & vbCrLf)
        sb.Append("<!-- Application Version: " & My.Application.Info.Version.ToString & " -->" & vbCrLf)
        sb.Append("<!-- Creation Date:          " & Format(Now, "dd MMMM yyyy") & " -->" & vbCrLf)
        sb.Append("<head>" & vbCrLf)
        sb.Append("<title>" & DocumentTitle & "</title>" & vbCrLf)
        sb.Append("<meta name=""description"" content=""Workflow description."">" & vbCrLf)
        sb.Append("</head>" & vbCrLf)

        sb.Append("<body style=""font-family:arial;"">" & vbCrLf & vbCrLf)

        sb.Append("<h2>" & DocumentTitle & "</h2>" & vbCrLf & vbCrLf)

        sb.Append(DefaultJavaScriptString)

        sb.Append("</body>" & vbCrLf)
        sb.Append("</html>" & vbCrLf)

        Return sb.ToString

    End Function

    Public Function DefaultHtmlString_Old(ByVal DocumentTitle As String) As String
        'Create a blank HTML Web Page.

        Dim sb As New System.Text.StringBuilder

        sb.Append("<!DOCTYPE html>" & vbCrLf)
        sb.Append("<html>" & vbCrLf & "<head>" & vbCrLf & "<title>" & DocumentTitle & "</title>" & vbCrLf)
        sb.Append("</head>" & vbCrLf & "<body>" & vbCrLf & vbCrLf)
        sb.Append("<h1>" & DocumentTitle & "</h1>" & vbCrLf & vbCrLf)

        'Add JavaScript section:
        sb.Append("<script>" & vbCrLf & vbCrLf)

        'START: User defined JavaScript functions ==========================================================================
        'Add functions to implement the main actions performed by this web page.
        sb.Append("//START: User defined JavaScript functions ==========================================================================" & vbCrLf)
        sb.Append("//  Add functions to implement the main actions performed by this web page." & vbCrLf & vbCrLf)

        sb.Append("//END:   User defined JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf & vbCrLf)
        'END:   User defined JavaScript functions --------------------------------------------------------------------------


        'START: User modified JavaScript functions ==========================================================================
        'Modify these function to save all required web page settings and process all expected XMessage instructions.
        sb.Append("//START: User modified JavaScript functions ==========================================================================" & vbCrLf)
        sb.Append("//  Modify these function to save all required web page settings and process all expected XMessage instructions." & vbCrLf & vbCrLf)

        'Add the SaveSettings function - This is used to save web page settings between sessions.
        sb.Append("//Save the web page settings." & vbCrLf)
        sb.Append("function SaveSettings() {" & vbCrLf)
        sb.Append("  var xSettings = ""<Settings>"" + "" \n"" ; //String containing the web page settings in XML format." & vbCrLf)
        sb.Append("  //Add xml lines to save each setting." & vbCrLf & vbCrLf)
        sb.Append("  xSettings +=    ""</Settings>"" + ""\n"" ; //End of the Settings element." & vbCrLf)
        sb.Append(vbCrLf)
        sb.Append("  //Save the settings as an XML file in the project." & vbCrLf)
        sb.Append("  window.external.SaveHtmlSettings(xSettings) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Process a single XMsg instruction (Information:Location pair)
        sb.Append("//Process an XMessage instruction:" & vbCrLf)
        sb.Append("function XMsgInstruction(Info, Locn) {" & vbCrLf)
        sb.Append("  switch(Locn) {" & vbCrLf)
        sb.Append("  //Insert case statements here." & vbCrLf)
        sb.Append("  default:" & vbCrLf)
        sb.Append("    window.external.AddWarning(""Unknown location: "" + Locn + ""\r\n"") ;" & vbCrLf)
        sb.Append("  }" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        sb.Append("//END:   User modified JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf & vbCrLf)
        'END:   User modified JavaScript functions --------------------------------------------------------------------------

        'START: Required Document Library Web Page JavaScript functions ==========================================================================
        sb.Append("//START: Required Document Library Web Page JavaScript functions ==========================================================================" & vbCrLf & vbCrLf)

        'Add the AddText function - This sends a message to the message window using a named text type.
        sb.Append("//Add text to the Message window using a named txt type:" & vbCrLf)
        sb.Append("function AddText(Msg, TextType) {" & vbCrLf)
        sb.Append("  window.external.AddText(Msg, TextType) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the AddMessage function - This sends a message to the message window using default black text.
        sb.Append("//Add a message to the Message window using the default black text:" & vbCrLf)
        sb.Append("function AddMessage(Msg) {" & vbCrLf)
        sb.Append("  window.external.AddMessage(Msg) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the AddWarning function - This sends a red, bold warning message to the message window.
        sb.Append("//Add a warning message to the Message window using bold red text:" & vbCrLf)
        sb.Append("function AddWarning(Msg) {" & vbCrLf)
        sb.Append("  window.external.AddWarning(Msg) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the RestoreSettings function - This is used to restore web page settings.
        sb.Append("//Restore the web page settings." & vbCrLf)
        sb.Append("function RestoreSettings() {" & vbCrLf)
        sb.Append("  window.external.RestoreHtmlSettings() " & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'This line runs the RestoreSettings function when the web page is loaded.
        sb.Append("//Restore the web page settings when the page loads." & vbCrLf)
        sb.Append("window.onload = RestoreSettings; " & vbCrLf)
        sb.Append(vbCrLf)

        'Restores a single setting on the web page.
        sb.Append("//Restore a web page setting." & vbCrLf)
        sb.Append("  function RestoreSetting(FormName, ItemName, ItemValue) {" & vbCrLf)
        sb.Append("  document.forms[FormName][ItemName].value = ItemValue ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        'Add the RestoreOption function - This is used to add an option to a Select list.
        sb.Append("//Restore a Select control Option." & vbCrLf)
        sb.Append("function RestoreOption(SelectId, OptionText) {" & vbCrLf)
        sb.Append("  var x = document.getElementById(SelectId) ;" & vbCrLf)
        sb.Append("  var option = document.createElement(""Option"") ;" & vbCrLf)
        sb.Append("  option.text = OptionText ;" & vbCrLf)
        sb.Append("  x.add(option) ;" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append(vbCrLf)

        sb.Append("//END:   Required Document Library Web Page JavaScript functions __________________________________________________________________________" & vbCrLf & vbCrLf)
        'END:   Required Document Library Web Page JavaScript functions --------------------------------------------------------------------------

        sb.Append("</script>" & vbCrLf & vbCrLf)

        sb.Append("</body>" & vbCrLf & "</html>" & vbCrLf)

        Return sb.ToString

    End Function

#End Region 'Start Page Code ------------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Methods Called by JavaScript - A collection of methods that can be called by JavaScript in a web page shown in WebBrowser1" '==================================
    'These methods are used to display HTML pages in the Workflow tab.
    'The same methods can be found in the WebView form, which displays web pages on seprate forms.


    'Display Messages ==============================================================================================

    Public Sub AddMessage(ByVal Msg As String)
        'Add a normal text message to the Message window.
        Message.Add(Msg)
    End Sub

    Public Sub AddWarning(ByVal Msg As String)
        'Add a warning text message to the Message window.
        Message.AddWarning(Msg)
    End Sub

    Public Sub AddTextTypeMessage(ByVal Msg As String, ByVal TextType As String)
        'Add a message with the specified Text Type to the Message window.
        Message.AddText(Msg, TextType)
    End Sub

    Public Sub AddXmlMessage(ByVal XmlText As String)
        'Add an Xml message to the Message window.
        Message.AddXml(XmlText)
    End Sub

    'END Display Messages ------------------------------------------------------------------------------------------


    'Run an XSequence ==============================================================================================

    Public Sub RunClipboardXSeq()
        'Run the XSequence instructions in the clipboard.

        Dim XDocSeq As System.Xml.Linq.XDocument
        Try
            XDocSeq = XDocument.Parse(My.Computer.Clipboard.GetText)
        Catch ex As Exception
            Message.AddWarning("Error reading Clipboard data. " & ex.Message & vbCrLf)
            Exit Sub
        End Try

        If IsNothing(XDocSeq) Then
            Message.Add("No XSequence instructions were found in the clipboard.")
        Else
            Dim XmlSeq As New System.Xml.XmlDocument
            Try
                XmlSeq.LoadXml(XDocSeq.ToString) 'Convert XDocSeq to an XmlDocument to process with XSeq.
                'Run the sequence:
                XSeq.RunXSequence(XmlSeq, Status)
            Catch ex As Exception
                Message.AddWarning("Error restoring HTML settings. " & ex.Message & vbCrLf)
            End Try
        End If
    End Sub

    Public Sub RunXSequence(ByVal XSequence As String)
        'Run the XMSequence
        Dim XmlSeq As New System.Xml.XmlDocument
        XmlSeq.LoadXml(XSequence)
        XSeq.RunXSequence(XmlSeq, Status)
    End Sub

    Private Sub XSeq_ErrorMsg(ErrMsg As String) Handles XSeq.ErrorMsg
        Message.AddWarning(ErrMsg & vbCrLf)
    End Sub

    Private Sub XSeq_Instruction(Data As String, Locn As String) Handles XSeq.Instruction
        'Execute each instruction produced by running the XSeq file.

        Select Case Locn

            'Restore Web Page Settings: -------------------------------------------------
            Case "Settings:Form:Name"
                FormName = Data

            Case "Settings:Form:Item:Name"
                ItemName = Data

            Case "Settings:Form:Item:Value"
                RestoreSetting(FormName, ItemName, Data)

            Case "Settings:Form:SelectId"
                SelectId = Data

            Case "Settings:Form:OptionText"
                RestoreOption(SelectId, Data)
            'END Restore Web Page Settings: ---------------------------------------------

            ''Start Project commands: ----------------------------------------------------

            'Case "StartProject:AppName"
            '    StartProject_AppName = Data

            'Case "StartProject:ConnectionName"
            '    StartProject_ConnName = Data

            'Case "StartProject:ProNetName"
            '    StartProject_ProNetName = Data

            'Case "StartProject:ProjectID"
            '    StartProject_ProjID = Data

            'Case "StartProject:ProjectName"
            '    StartProject_ProjName = Data

            'Case "StartProject:Command"
            '    Select Case Data
            '        Case "Apply"
            '            If StartProject_ProjName <> "" Then
            '                StartApp_ProjectName(StartProject_AppName, StartProject_ProjName, StartProject_ConnName)
            '            ElseIf StartProject_ProjID <> "" Then
            '                StartApp_ProjectID(StartProject_AppName, StartProject_ProjID, StartProject_ConnName)
            '            Else
            '                Message.AddWarning("Project not specified. Project Name and Project ID are blank." & vbCrLf)
            '            End If
            '        Case Else
            '            Message.AddWarning("Unknown Start Project command : " & Data & vbCrLf)
            '    End Select

            ''END Start project commands ---------------------------------------------

            Case "Settings"
                'Do nothing


            Case "EndOfSequence"
                'Main.Message.Add("End of processing sequence" & Data & vbCrLf)

            Case Else
                Message.AddWarning("Unknown location: " & Locn & "  Data: " & Data & vbCrLf)

        End Select
    End Sub

    'END Run an XSequence ------------------------------------------------------------------------------------------


    'Run an XMessage ===============================================================================================

    Public Sub RunXMessage(ByVal XMsg As String)
        'Run the XMessage by sending it to InstrReceived.
        InstrReceived = XMsg
    End Sub

    Public Sub SendXMessage(ByVal ConnName As String, ByVal XMsg As String)
        'Send the XMessage to the application with the connection name ConnName.
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                If bgwSendMessage.IsBusy Then
                    Message.AddWarning("Send Message backgroundworker is busy." & vbCrLf)
                Else
                    Dim SendMessageParams As New Main.clsSendMessageParams
                    SendMessageParams.ProjectNetworkName = ProNetName
                    SendMessageParams.ConnectionName = ConnName
                    SendMessageParams.Message = XMsg
                    bgwSendMessage.RunWorkerAsync(SendMessageParams)
                    If ShowXMessages Then
                        Message.XAddText("Message sent to " & "[" & ProNetName & "]." & ConnName & ":" & vbCrLf, "XmlSentNotice")
                        Message.XAddXml(XMsg)
                        Message.XAddText(vbCrLf, "Normal") 'Add extra line
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub SendXMessageExt(ByVal ProNetName As String, ByVal ConnName As String, ByVal XMsg As String)
        'Send the XMsg to the application with the connection name ConnName and Project Network Name ProNetname.
        'This version can send the XMessage to a connection external to the current Project Network.
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                If bgwSendMessage.IsBusy Then
                    Message.AddWarning("Send Message backgroundworker is busy." & vbCrLf)
                Else
                    Dim SendMessageParams As New Main.clsSendMessageParams
                    SendMessageParams.ProjectNetworkName = ProNetName
                    SendMessageParams.ConnectionName = ConnName
                    SendMessageParams.Message = XMsg
                    bgwSendMessage.RunWorkerAsync(SendMessageParams)
                    If ShowXMessages Then
                        Message.XAddText("Message sent to " & "[" & ProNetName & "]." & ConnName & ":" & vbCrLf, "XmlSentNotice")
                        Message.XAddXml(XMsg)
                        Message.XAddText(vbCrLf, "Normal") 'Add extra line
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub SendXMessageWait(ByVal ConnName As String, ByVal XMsg As String)
        'Send the XMsg to the application with the connection name ConnName.
        'Wait for the connection to be made.
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            Try
                'Application.DoEvents() 'TRY THE METHOD WITHOUT THE DOEVENTS
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("client state is faulted. Message not sent!" & vbCrLf)
                Else
                    Dim StartTime As Date = Now
                    Dim Duration As TimeSpan
                    'Wait up to 16 seconds for the connection ConnName to be established
                    While client.ConnectionExists(ProNetName, ConnName) = False 'Wait until the required connection is made.
                        System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
                        Duration = Now - StartTime
                        If Duration.Seconds > 16 Then Exit While
                    End While

                    If client.ConnectionExists(ProNetName, ConnName) = False Then
                        Message.AddWarning("Connection not available: " & ConnName & " in application network: " & ProNetName & vbCrLf)
                    Else
                        If bgwSendMessage.IsBusy Then
                            Message.AddWarning("Send Message backgroundworker is busy." & vbCrLf)
                        Else
                            Dim SendMessageParams As New Main.clsSendMessageParams
                            SendMessageParams.ProjectNetworkName = ProNetName
                            SendMessageParams.ConnectionName = ConnName
                            SendMessageParams.Message = XMsg
                            bgwSendMessage.RunWorkerAsync(SendMessageParams)
                            If ShowXMessages Then
                                Message.XAddText("Message sent to " & "[" & ProNetName & "]." & ConnName & ":" & vbCrLf, "XmlSentNotice")
                                Message.XAddXml(XMsg)
                                Message.XAddText(vbCrLf, "Normal") 'Add extra line
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                Message.AddWarning(ex.Message & vbCrLf)
            End Try
        End If
    End Sub

    Public Sub SendXMessageExtWait(ByVal ProNetName As String, ByVal ConnName As String, ByVal XMsg As String)
        'Send the XMsg to the application with the connection name ConnName and Project Network Name ProNetName.
        'Wait for the connection to be made.
        'This version can send the XMessage to a connection external to the current Project Network.
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                Dim StartTime As Date = Now
                Dim Duration As TimeSpan
                'Wait up to 16 seconds for the connection ConnName to be established
                While client.ConnectionExists(ProNetName, ConnName) = False
                    System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
                    Duration = Now - StartTime
                    If Duration.Seconds > 16 Then Exit While
                End While

                If client.ConnectionExists(ProNetName, ConnName) = False Then
                    Message.AddWarning("Connection not available: " & ConnName & " in application network: " & ProNetName & vbCrLf)
                Else
                    If bgwSendMessage.IsBusy Then
                        Message.AddWarning("Send Message backgroundworker is busy." & vbCrLf)
                    Else
                        Dim SendMessageParams As New Main.clsSendMessageParams
                        SendMessageParams.ProjectNetworkName = ProNetName
                        SendMessageParams.ConnectionName = ConnName
                        SendMessageParams.Message = XMsg
                        bgwSendMessage.RunWorkerAsync(SendMessageParams)
                        If ShowXMessages Then
                            Message.XAddText("Message sent to " & "[" & ProNetName & "]." & ConnName & ":" & vbCrLf, "XmlSentNotice")
                            Message.XAddXml(XMsg)
                            Message.XAddText(vbCrLf, "Normal") 'Add extra line
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub XMsgInstruction(ByVal Info As String, ByVal Locn As String)
        'Send the XMessage Instruction to the JavaScript function XMsgInstruction for processing.
        Me.WebBrowser1.Document.InvokeScript("XMsgInstruction", New String() {Info, Locn})
    End Sub

    'END Run an XMessage -------------------------------------------------------------------------------------------


    'Get Information ===============================================================================================

    Public Function GetFormNo() As String
        'Return the Form Number of the current instance of the WebPage form.
        'Return FormNo.ToString
        Return "-1" 'The Main Form is not a Web Page form.
    End Function

    Public Function GetParentFormNo() As String
        'Return the Form Number of the Parent Form (that called this form).
        'Return ParentWebPageFormNo.ToString
        Return "-1" 'The Main Form does not have a Parent Web Page.
    End Function

    Public Function GetConnectionName() As String
        'Return the Connection Name of the Project.
        Return ConnectionName
    End Function

    Public Function GetProNetName() As String
        'Return the Project Network Name of the Project.
        Return ProNetName
    End Function

    Public Sub ParentProjectName(ByVal FormName As String, ByVal ItemName As String)
        'Return the Parent Project name:
        RestoreSetting(FormName, ItemName, Project.ParentProjectName)
    End Sub

    Public Sub ParentProjectPath(ByVal FormName As String, ByVal ItemName As String)
        'Return the Parent Project path:
        RestoreSetting(FormName, ItemName, Project.ParentProjectPath)
    End Sub

    Public Sub ParentProjectParameterValue(ByVal FormName As String, ByVal ItemName As String, ByVal ParameterName As String)
        'Return the specified Parent Project parameter value:
        RestoreSetting(FormName, ItemName, Project.ParentParameter(ParameterName).Value)
    End Sub

    Public Sub ProjectParameterValue(ByVal FormName As String, ByVal ItemName As String, ByVal ParameterName As String)
        'Return the specified Project parameter value:
        RestoreSetting(FormName, ItemName, Project.Parameter(ParameterName).Value)
    End Sub

    Public Sub ProjectNetworkName(ByVal FormName As String, ByVal ItemName As String)
        'Return the name of the Project Network:
        RestoreSetting(FormName, ItemName, Project.Parameter("ProNetName").Value)
    End Sub

    'END Get Information -------------------------------------------------------------------------------------------


    'Open a Web Page ===============================================================================================

    Public Sub OpenWebPage(ByVal FileName As String)
        'Open the web page with the specified File Name.

        If FileName = "" Then

        Else
            'First check if the HTML file is already open:
            Dim FileFound As Boolean = False
            If WebPageFormList.Count = 0 Then

            Else
                Dim I As Integer
                For I = 0 To WebPageFormList.Count - 1
                    If WebPageFormList(I) Is Nothing Then

                    Else
                        If WebPageFormList(I).FileName = FileName Then
                            FileFound = True
                            WebPageFormList(I).BringToFront
                        End If
                    End If
                Next
            End If

            If FileFound = False Then
                Dim FormNo As Integer = OpenNewWebPage()
                WebPageFormList(FormNo).FileName = FileName
                WebPageFormList(FormNo).OpenDocument
                WebPageFormList(FormNo).BringToFront
            End If
        End If
    End Sub

    'END Open a Web Page -------------------------------------------------------------------------------------------


    'Open and Close Projects =======================================================================================

    Public Sub OpenProjectAtRelativePath(ByVal RelativePath As String, ByVal ConnectionName As String)
        'Open the Project at the specified Relative Path using the specified Connection Name.

        Dim ProjectPath As String
        If RelativePath.StartsWith("\") Then
            ProjectPath = Project.Path & RelativePath
            client.StartProjectAtPath(ProjectPath, ConnectionName)
        Else
            ProjectPath = Project.Path & "\" & RelativePath
            client.StartProjectAtPath(ProjectPath, ConnectionName)
        End If
    End Sub

    Public Sub CheckOpenProjectAtRelativePath(ByVal RelativePath As String, ByVal ConnectionName As String)
        'Check if the project at the specified Relative Path is open.
        'Open it if it is not already open.
        'Open the Project at the specified Relative Path using the specified Connection Name.

        Dim ProjectPath As String
        If RelativePath.StartsWith("\") Then
            ProjectPath = Project.Path & RelativePath
            If client.ProjectOpen(ProjectPath) Then
                'Project is already open.
            Else
                client.StartProjectAtPath(ProjectPath, ConnectionName)
            End If
        Else
            ProjectPath = Project.Path & "\" & RelativePath
            If client.ProjectOpen(ProjectPath) Then
                'Project is already open.
            Else
                client.StartProjectAtPath(ProjectPath, ConnectionName)
            End If
        End If
    End Sub

    Public Sub OpenProjectAtProNetPath(ByVal RelativePath As String, ByVal ConnectionName As String)
        'Open the Project at the specified Path (relative to the Project Network Path) using the specified Connection Name.

        Dim ProjectPath As String
        If RelativePath.StartsWith("\") Then
            If Project.ParameterExists("ProNetPath") Then
                ProjectPath = Project.GetParameter("ProNetPath") & RelativePath
                client.StartProjectAtPath(ProjectPath, ConnectionName)
            Else
                Message.AddWarning("The Project Network Path is not known." & vbCrLf)
            End If
        Else
            If Project.ParameterExists("ProNetPath") Then
                ProjectPath = Project.GetParameter("ProNetPath") & "\" & RelativePath
                client.StartProjectAtPath(ProjectPath, ConnectionName)
            Else
                Message.AddWarning("The Project Network Path is not known." & vbCrLf)
            End If
        End If
    End Sub

    Public Sub CheckOpenProjectAtProNetPath(ByVal RelativePath As String, ByVal ConnectionName As String)
        'Check if the project at the specified Path (relative to the Project Network Path) is open.
        'Open it if it is not already open.
        'Open the Project at the specified Path using the specified Connection Name.

        Dim ProjectPath As String
        If RelativePath.StartsWith("\") Then
            If Project.ParameterExists("ProNetPath") Then
                ProjectPath = Project.GetParameter("ProNetPath") & RelativePath
                'client.StartProjectAtPath(ProjectPath, ConnectionName)
                If client.ProjectOpen(ProjectPath) Then
                    'Project is already open.
                Else
                    client.StartProjectAtPath(ProjectPath, ConnectionName)
                End If
            Else
                Message.AddWarning("The Project Network Path is not known." & vbCrLf)
            End If
        Else
            If Project.ParameterExists("ProNetPath") Then
                ProjectPath = Project.GetParameter("ProNetPath") & "\" & RelativePath
                'client.StartProjectAtPath(ProjectPath, ConnectionName)
                If client.ProjectOpen(ProjectPath) Then
                    'Project is already open.
                Else
                    client.StartProjectAtPath(ProjectPath, ConnectionName)
                End If
            Else
                Message.AddWarning("The Project Network Path is not known." & vbCrLf)
            End If
        End If
    End Sub


    Public Sub CloseProjectAtConnection(ByVal ProNetName As String, ByVal ConnectionName As String)
        'Close the Project at the specified connection.

        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                'Create the XML instructions to close the application at the connection.
                Dim decl As New XDeclaration("1.0", "utf-8", "yes")
                Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
                Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

                'NOTE: No reply expected. No need to provide the following client information(?)
                'Dim clientConnName As New XElement("ClientConnectionName", Me.ConnectionName)
                'xmessage.Add(clientConnName)

                Dim command As New XElement("Command", "Close")
                xmessage.Add(command)
                doc.Add(xmessage)

                'Show the message sent:
                Message.XAddText("Message sent to: [" & ProNetName & "]." & ConnectionName & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line

                client.SendMessage(ProNetName, ConnectionName, doc.ToString)
            End If
        End If
    End Sub

    'END Open and Close Projects -----------------------------------------------------------------------------------


    'System Methods ================================================================================================

    Public Sub SaveHtmlSettings(ByVal xSettings As String, ByVal FileName As String)
        'Save the Html settings for a web page.

        'Convert the XSettings to XML format:
        Dim XmlHeader As String = "<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>"
        Dim XDocSettings As New System.Xml.Linq.XDocument

        Try
            XDocSettings = System.Xml.Linq.XDocument.Parse(XmlHeader & vbCrLf & xSettings)
        Catch ex As Exception
            Message.AddWarning("Error saving HTML settings file. " & ex.Message & vbCrLf)
        End Try

        Project.SaveXmlData(FileName, XDocSettings)
    End Sub

    Public Sub RestoreHtmlSettings()
        'Restore the Html settings for a web page.

        Dim SettingsFileName As String = WorkflowFileName & "Settings"
        Dim XDocSettings As New System.Xml.Linq.XDocument
        Project.ReadXmlData(SettingsFileName, XDocSettings)

        If XDocSettings Is Nothing Then
            'Message.Add("No HTML Settings file : " & SettingsFileName & vbCrLf)
        Else
            Dim XSettings As New System.Xml.XmlDocument
            Try
                XSettings.LoadXml(XDocSettings.ToString)
                'Run the Settings file:
                XSeq.RunXSequence(XSettings, Status)
            Catch ex As Exception
                Message.AddWarning("Error restoring HTML settings. " & ex.Message & vbCrLf)
            End Try
        End If
    End Sub

    Public Sub RestoreSetting(ByVal FormName As String, ByVal ItemName As String, ByVal ItemValue As String)
        'Restore the setting value with the specified Form Name and Item Name.
        Me.WebBrowser1.Document.InvokeScript("RestoreSetting", New String() {FormName, ItemName, ItemValue})
    End Sub

    Public Sub RestoreOption(ByVal SelectId As String, ByVal OptionText As String)
        'Restore the Option text in the Select control with the Id SelectId.
        Me.WebBrowser1.Document.InvokeScript("RestoreOption", New String() {SelectId, OptionText})
    End Sub

    Private Sub SaveWebPageSettings()
        'Call the SaveSettings JavaScript function:
        Try
            Me.WebBrowser1.Document.InvokeScript("SaveSettings")
        Catch ex As Exception
            Message.AddWarning("Web page settings not saved: " & ex.Message & vbCrLf)
        End Try
    End Sub

    'END System Methods --------------------------------------------------------------------------------------------


    'Legacy Code (These methods should no longer be used) ==========================================================

    Public Sub JSMethodTest1()
        'Test method that is called from JavaScript.
        Message.Add("JSMethodTest1 called OK." & vbCrLf)
    End Sub

    Public Sub JSMethodTest2(ByVal Var1 As String, ByVal Var2 As String)
        'Test method that is called from JavaScript.
        Message.Add("Var1 = " & Var1 & " Var2 = " & Var2 & vbCrLf)
    End Sub

    Public Sub JSDisplayXml(ByRef XDoc As XDocument)
        Message.Add(XDoc.ToString & vbCrLf & vbCrLf)
    End Sub

    Public Sub ShowMessage(ByVal Msg As String)
        Message.Add(Msg)
    End Sub

    Public Sub AddText(ByVal Msg As String, ByVal TextType As String)
        Message.AddText(Msg, TextType)
    End Sub

    'END Legacy Code -----------------------------------------------------------------------------------------------


#End Region 'Methods Called by JavaScript -------------------------------------------------------------------------------------------------------------------------------


#Region " Project Events Code"

    Private Sub Project_Message(Msg As String) Handles Project.Message
        'Display the Project message:
        Message.Add(Msg & vbCrLf)
    End Sub

    Private Sub Project_ErrorMessage(Msg As String) Handles Project.ErrorMessage
        'Display the Project error message:
        Message.AddWarning(Msg & vbCrLf)
    End Sub

    Private Sub Project_Closing() Handles Project.Closing
        'The current project is closing.
        CloseProject()
        'SaveFormSettings() 'Save the form settings - they are saved in the Project before is closes.
        'SaveProjectSettings() 'Update this subroutine if project settings need to be saved.
        'Project.Usage.SaveUsageInfo() 'Save the current project usage information.
        'Project.UnlockProject() 'Unlock the current project before it Is closed.
        'If ConnectedToComNet Then DisconnectFromComNet() 'ADDED 9Apr20
    End Sub

    Private Sub CloseProject()
        'Close the Project:
        SaveFormSettings() 'Save the form settings - they are saved in the Project before is closes.
        SaveProjectSettings() 'Update this subroutine if project settings need to be saved.
        Project.Usage.SaveUsageInfo() 'Save the current project usage information.
        Project.UnlockProject() 'Unlock the current project before it Is closed.
        If ConnectedToComNet Then DisconnectFromComNet() 'ADDED 9Apr20
    End Sub

    Private Sub Project_Selected() Handles Project.Selected
        'A new project has been selected.
        OpenProject()
        'RestoreFormSettings()
        'Project.ReadProjectInfoFile()

        'Project.ReadParameters()
        'Project.ReadParentParameters()
        'If Project.ParentParameterExists("ProNetName") Then
        '    Project.AddParameter("ProNetName", Project.ParentParameter("ProNetName").Value, Project.ParentParameter("ProNetName").Description) 'AddParameter will update the parameter if it already exists.
        '    ProNetName = Project.Parameter("ProNetName").Value
        'Else
        '    ProNetName = Project.GetParameter("ProNetName")
        'End If
        'If Project.ParentParameterExists("ProNetPath") Then 'Get the parent parameter value - it may have been updated.
        '    Project.AddParameter("ProNetPath", Project.ParentParameter("ProNetPath").Value, Project.ParentParameter("ProNetPath").Description) 'AddParameter will update the parameter if it already exists.
        '    ProNetPath = Project.Parameter("ProNetPath").Value
        'Else
        '    ProNetPath = Project.GetParameter("ProNetPath") 'If the parameter does not exist, the value is set to ""
        'End If
        'Project.SaveParameters() 'These should be saved now - child projects look for parent parameters in the parameter file.

        'Project.LockProject() 'Lock the project while it is open in this application.

        'Project.Usage.StartTime = Now

        'ApplicationInfo.SettingsLocn = Project.SettingsLocn
        'Message.SettingsLocn = Project.SettingsLocn
        'Message.Show() 'Added 18May19

        ''Restore the new project settings:
        'RestoreProjectSettings() 'Update this subroutine if project settings need to be restored.

        'ShowProjectInfo()

        'If Project.ConnectOnOpen Then
        '    ConnectToComNet() 'The Project is set to connect when it is opened.
        'ElseIf ApplicationInfo.ConnectOnStartup Then
        '    ConnectToComNet() 'The Application is set to connect when it is started.
        'Else
        '    'Don't connect to ComNet.
        'End If

    End Sub

    Private Sub OpenProject()
        'Open the Project:
        RestoreFormSettings()
        Project.ReadProjectInfoFile()

        Project.ReadParameters()
        Project.ReadParentParameters()
        If Project.ParentParameterExists("ProNetName") Then
            Project.AddParameter("ProNetName", Project.ParentParameter("ProNetName").Value, Project.ParentParameter("ProNetName").Description) 'AddParameter will update the parameter if it already exists.
            ProNetName = Project.Parameter("ProNetName").Value
        Else
            ProNetName = Project.GetParameter("ProNetName")
        End If
        If Project.ParentParameterExists("ProNetPath") Then 'Get the parent parameter value - it may have been updated.
            Project.AddParameter("ProNetPath", Project.ParentParameter("ProNetPath").Value, Project.ParentParameter("ProNetPath").Description) 'AddParameter will update the parameter if it already exists.
            ProNetPath = Project.Parameter("ProNetPath").Value
        Else
            ProNetPath = Project.GetParameter("ProNetPath") 'If the parameter does not exist, the value is set to ""
        End If
        Project.SaveParameters() 'These should be saved now - child projects look for parent parameters in the parameter file.

        Project.LockProject() 'Lock the project while it is open in this application.

        Project.Usage.StartTime = Now

        ApplicationInfo.SettingsLocn = Project.SettingsLocn
        Message.SettingsLocn = Project.SettingsLocn
        Message.Show() 'Added 18May19

        'Restore the new project settings:
        RestoreProjectSettings() 'Update this subroutine if project settings need to be restored.

        ShowProjectInfo()

        If Project.ConnectOnOpen Then
            ConnectToComNet() 'The Project is set to connect when it is opened.
        ElseIf ApplicationInfo.ConnectOnStartup Then
            ConnectToComNet() 'The Application is set to connect when it is started.
        Else
            'Don't connect to ComNet.
        End If
    End Sub

    Private Sub chkConnect_LostFocus(sender As Object, e As EventArgs) Handles chkConnect.LostFocus
        If chkConnect.Checked Then
            Project.ConnectOnOpen = True
        Else
            Project.ConnectOnOpen = False
        End If
        Project.SaveProjectInfoFile()
    End Sub

#End Region 'Project Events Code

#Region " Online/Offline Code" '=========================================================================================================================================

    Private Sub btnOnline_Click(sender As Object, e As EventArgs) Handles btnOnline.Click
        'Connect to or disconnect from the Message System (ComNet).
        If ConnectedToComNet = False Then
            ConnectToComNet()
        Else
            DisconnectFromComNet()
        End If
    End Sub

    Private Sub ConnectToComNet()
        'Connect to the Message Service. (ComNet)

        If IsNothing(client) Then
            client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
        End If

        'UPDATE 14 Feb 2021 - If the VS2019 version of the ADVL Network is running it may not detected by ComNetRunning()!
        'Check if the Message Service is running by trying to open a connection:
        Try
            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 16) 'Temporarily set the send timeaout to 16 seconds (8 seconds is too short for a slow computer!)
            ConnectionName = ApplicationInfo.Name 'This name will be modified if it is already used in an existing connection.
            ConnectionName = client.Connect(ProNetName, ApplicationInfo.Name, ConnectionName, Project.Name, Project.Description, Project.Type, Project.Path, False, False)
            If ConnectionName <> "" Then
                Message.Add("Connected to the Andorville™ Network with Connection Name: [" & ProNetName & "]." & ConnectionName & vbCrLf)
                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
                btnOnline.Text = "Online"
                btnOnline.ForeColor = Color.ForestGreen
                ConnectedToComNet = True
                SendApplicationInfo()
                SendProjectInfo()
                client.GetAdvlNetworkAppInfoAsync() 'Update the Exe Path in case it has changed. This path may be needed in the future to start the ComNet (Message Service).

                bgwComCheck.WorkerReportsProgress = True
                bgwComCheck.WorkerSupportsCancellation = True
                If bgwComCheck.IsBusy Then
                    'The ComCheck thread is already running.
                Else
                    bgwComCheck.RunWorkerAsync() 'Start the ComCheck thread.
                End If
                Exit Sub 'Connection made OK
            Else
                'Message.Add("Connection to the Andorville™ Network failed!" & vbCrLf)
                Message.Add("The Andorville™ Network was not found. Attempting to start it." & vbCrLf)
                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
            End If
        Catch ex As System.TimeoutException
            Message.Add("Message Service Check Timeout error. Check if the Andorville™ Network (Message Service) is running." & vbCrLf)
            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
            Message.Add("Attempting to start the Message Service." & vbCrLf)
        Catch ex As Exception
            Message.Add("Error message: " & ex.Message & vbCrLf)
            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
            Message.Add("Attempting to start the Message Service." & vbCrLf)
        End Try
        'END UPDATE

        If ComNetRunning() Then
            'The Application.Lock file has been found at AdvlNetworkAppPath
            'The Message Service is Running.
        Else 'The Message Service is NOT running'
            'Start the Andorville™ Network:
            If ConnCancelled = True Then
                Message.AddWarning("The connection attempt has been cancelled." & vbCrLf)
                Exit Sub
            Else
                If AdvlNetworkAppPath = "" Then
                    Message.AddWarning("Andorville™ Network application path is unknown." & vbCrLf)
                Else
                    If System.IO.File.Exists(AdvlNetworkExePath) Then 'OK to start the Message Service application:
                        Shell(Chr(34) & AdvlNetworkExePath & Chr(34), AppWinStyle.NormalFocus) 'Start Message Service application with no argument
                    Else
                        'Incorrect Message Service Executable path.
                        Message.AddWarning("Andorville™ Network exe file not found. Service not started." & vbCrLf)
                    End If
                End If
            End If
        End If

        'Try to fix a faulted client state:
        If client.State = ServiceModel.CommunicationState.Faulted Then
            client = Nothing
            client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
        End If

        If client.State = ServiceModel.CommunicationState.Faulted Then
            Message.AddWarning("Client state is faulted. Connection not made!" & vbCrLf)
        Else
            Try
                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 16) 'Temporarily set the send timeaout to 16 seconds (8 seconds is too short for a slow computer!)

                ConnectionName = ApplicationInfo.Name 'This name will be modified if it is already used in an existing connection.
                ConnectionName = client.Connect(ProNetName, ApplicationInfo.Name, ConnectionName, Project.Name, Project.Description, Project.Type, Project.Path, False, False)

                If ConnectionName <> "" Then
                    Message.Add("Connected to the Andorville™ Network with Connection Name: [" & ProNetName & "]." & ConnectionName & vbCrLf)
                    client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
                    btnOnline.Text = "Online"
                    btnOnline.ForeColor = Color.ForestGreen
                    ConnectedToComNet = True
                    SendApplicationInfo()
                    SendProjectInfo()
                    client.GetAdvlNetworkAppInfoAsync() 'Update the Exe Path in case it has changed. This path may be needed in the future to start the ComNet (Message Service).

                    bgwComCheck.WorkerReportsProgress = True
                    bgwComCheck.WorkerSupportsCancellation = True
                    If bgwComCheck.IsBusy Then
                        'The ComCheck thread is already running.
                    Else
                        bgwComCheck.RunWorkerAsync() 'Start the ComCheck thread.
                    End If

                Else
                    Message.Add("Connection to the Andorville™ Network failed!" & vbCrLf)
                    client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
                End If
            Catch ex As System.TimeoutException
                Message.Add("Timeout error. Check if the Andorville™ Network (Message Service) is running." & vbCrLf)
            Catch ex As Exception
                Message.Add("Error message: " & ex.Message & vbCrLf)
                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
            End Try
        End If
    End Sub

    Private Sub ConnectToComNet(ByVal ConnName As String)
        'Connect to the Message Service (ComNet) with the connection name ConnName.

        'UPDATE 14 Feb 2021 - If the VS2019 version of the ADVL Network is running it may not be detected by ComNetRunning()!
        'Check if the Message Service is running by trying to open a connection:

        If IsNothing(client) Then
            client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
        End If

        Try
            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 16) 'Temporarily set the send timeaout to 16 seconds (8 seconds is too short for a slow computer!)
            ConnectionName = ConnName 'This name will be modified if it is already used in an existing connection.
            ConnectionName = client.Connect(ProNetName, ApplicationInfo.Name, ConnectionName, Project.Name, Project.Description, Project.Type, Project.Path, False, False)
            If ConnectionName <> "" Then
                Message.Add("Connected to the Andorville™ Network with Connection Name: [" & ProNetName & "]." & ConnectionName & vbCrLf)
                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
                btnOnline.Text = "Online"
                btnOnline.ForeColor = Color.ForestGreen
                ConnectedToComNet = True
                SendApplicationInfo()
                SendProjectInfo()
                client.GetAdvlNetworkAppInfoAsync() 'Update the Exe Path in case it has changed. This path may be needed in the future to start the ComNet (Message Service).

                bgwComCheck.WorkerReportsProgress = True
                bgwComCheck.WorkerSupportsCancellation = True
                If bgwComCheck.IsBusy Then
                    'The ComCheck thread is already running.
                Else
                    bgwComCheck.RunWorkerAsync() 'Start the ComCheck thread.
                End If
                Exit Sub 'Connection made OK
            Else
                'Message.Add("Connection to the Andorville™ Network failed!" & vbCrLf)
                Message.Add("The Andorville™ Network was not found. Attempting to start it." & vbCrLf)
                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
            End If
        Catch ex As System.TimeoutException
            Message.Add("Message Service Check Timeout error. Check if the Andorville™ Network (Message Service) is running." & vbCrLf)
            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
            Message.Add("Attempting to start the Message Service." & vbCrLf)
        Catch ex As Exception
            Message.Add("Error message: " & ex.Message & vbCrLf)
            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
            Message.Add("Attempting to start the Message Service." & vbCrLf)
        End Try
        'END UPDATE

        If ConnectedToComNet = False Then
            If ConnCancelled = True Then
                Message.AddWarning("The connection attempt has been cancelled." & vbCrLf)
                Exit Sub
            End If
            If IsNothing(client) Then
                client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
            End If

            'Try to fix a faulted client state:
            If client.State = ServiceModel.CommunicationState.Faulted Then
                client = Nothing
                client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
            End If

            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.AddWarning("client state is faulted. Connection not made!" & vbCrLf)
            Else
                Try
                    client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 16) 'Temporarily set the send timeout to 16 seconds (8 seconds is too short for a slow computer!)
                    ConnectionName = ConnName 'This name will be modified if it is already used in an existing connection.
                    ConnectionName = client.Connect(ProNetName, ApplicationInfo.Name, ConnectionName, Project.Name, Project.Description, Project.Type, Project.Path, False, False)

                    If ConnectionName <> "" Then
                        Message.Add("Connected to the Andorville™ Network with Connection Name: [" & ProNetName & "]." & ConnectionName & vbCrLf)
                        client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
                        btnOnline.Text = "Online"
                        btnOnline.ForeColor = Color.ForestGreen
                        ConnectedToComNet = True
                        SendApplicationInfo()
                        SendProjectInfo()
                        client.GetAdvlNetworkAppInfoAsync() 'Update the Exe Path in case it has changed. This path may be needed in the future to start the ComNet (Message Service).

                        bgwComCheck.WorkerReportsProgress = True
                        bgwComCheck.WorkerSupportsCancellation = True
                        If bgwComCheck.IsBusy Then
                            'The ComCheck thread is already running.
                        Else
                            bgwComCheck.RunWorkerAsync() 'Start the ComCheck thread.
                        End If

                    Else
                        Message.Add("Connection to the Andorville™ Network failed!" & vbCrLf)
                        client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
                    End If
                Catch ex As System.TimeoutException
                    Message.Add("Timeout error. Check if the Andorville™ Network (Message Service) is running." & vbCrLf)
                Catch ex As Exception
                    Message.Add("Error message: " & ex.Message & vbCrLf)
                    client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
                End Try
            End If
        Else
            Message.AddWarning("Already connected to the Andorville™ Network (Message Service)." & vbCrLf)
        End If
    End Sub



    'THIS WAS TEST CODE - NOT USED:
    Private Sub NewConnectToComNet(ByVal ConnName As String) 'New Version - calls a separate thread to make the connection.
        'Connect to the Message Service (ComNet) with the connection name ConnName.

        If IsNothing(client) Then 'Create the client
            client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
        ElseIf client.State = ServiceModel.CommunicationState.Faulted Then 'Try to fix the client
            client = Nothing
            client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
        End If

        'bgwConnectToComNet.RunWorkerAsync(ConnName) 'Use a separate thread to try to connect to the Message Service.

        'Wait for bgwConnectToComNet to finish processing
        Dim StartTime As Date = Now
        Dim Duration As TimeSpan
        'While bgwConnectToComNet.IsBusy
        '    System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
        '    Duration = Now - StartTime
        '    If Duration.Seconds > 16 Then
        '        'bgwConnectToComNet.CancelAsync()
        '        Exit While
        '    End If
        'End While

        Debug.WriteLine("ProNetName = " & ProNetName)
        Debug.WriteLine("ConnName = " & ConnName)

        'While client.ConnectionExists(ProNetName, ConnName) = False
        While ConnectedToComNet = False
            System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
            Duration = Now - StartTime
            Debug.WriteLine("Duration = " & Duration.Seconds)
            If Duration.Seconds > 16 Then
                'bgwConnectToComNet.CancelAsync()
                Exit While
            End If
        End While

        'The loop exits after 1 second but still returns a threading error.
        'Wait unti the BackgroundWorker exits:

        'While bgwConnectToComNet.IsBusy
        '    System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
        '    Duration = Now - StartTime
        '    Debug.WriteLine("Duration = " & Duration.Seconds)
        '    If Duration.Seconds > 16 Then
        '        'bgwConnectToComNet.CancelAsync()
        '        Exit While
        '    End If
        'End While

        'SAME ERROR!!!

        'Try waiting for the connection:
        'While client.ConnectionExists(ProNetName, ConnName) = False
        '    System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
        '    Duration = Now - StartTime
        '    Debug.WriteLine("Duration = " & Duration.Seconds)
        '    If Duration.Seconds > 16 Then Exit While
        'End While

        'SAME ERROR!!!

        'While bgwConnectToComNet.IsBusy
        '    System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
        '    Duration = Now - StartTime
        '    Debug.WriteLine("Duration = " & Duration.Seconds)
        '    If Duration.Seconds > 16 Then
        '        'bgwConnectToComNet.CancelAsync()
        '        Exit While
        '    End If
        'End While



        If ConnectedToComNet = True Then
            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
            btnOnline.Text = "Online"
            btnOnline.ForeColor = Color.ForestGreen
            'I = 16
        End If

        'While client.ConnectionExists(ProNetName, ConnName) = False
        '    System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
        '    Duration = Now - StartTime
        '    If Duration.Seconds > 16 Then Exit While
        'End While

        'Dim I As Integer
        'For I = 1 To 16
        '    System.Threading.Thread.Sleep(1000) 'Pause for 1000ms
        '    SyncLock myLock
        '        If ConnectedToComNet = True Then
        '            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
        '            btnOnline.Text = "Online"
        '            btnOnline.ForeColor = Color.ForestGreen
        '            I = 16
        '        End If
        '    End SyncLock
        'Next



        SendApplicationInfo()
        SendProjectInfo()
        client.GetAdvlNetworkAppInfoAsync() 'Update the Exe Path in case it has changed. This path may be needed in the future to start the ComNet (Message Service).

        'SHOW OPTION TO CANCEL AND RUN IN STANDALONE MODE!!!

    End Sub

    Private Sub bgwCancelConn_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwCancelConn.DoWork


        'Dim MB As MessageBox("Press OK to cancel the connection and run in Standalone mode.",)

        'Dim frm As New Form

        'This code results in an error:
        'WebPageList = New frmWebPageList
        'WebPageList.Show()

        'This code results in an error:
        'Dim NewForm As New frmWebPageList
        'NewForm.Show()


        'Dim MBox As MessageBox()
        'Dim Result As

        'ERROR:
        'WebPageList = New frmWebPageList
        'WebPageList.Show()


        Dim dr As System.Windows.Forms.DialogResult

        'dr = MessageBox.Show("Press OK to cancel the connection and run in Standalone mode.", "Notice", MessageBoxButtons.OK)
        'dr = MessageBox.Show("Press OK to cancel the connection and run in Standalone mode.", "Notice", MessageBoxButtons.OKCancel)
        'dr = MessageBox.Show(Me, "Press OK to cancel the connection and run in Standalone mode.", "Notice", MessageBoxButtons.OKCancel) 'ERROR
        'dr = MessageBox.Show("Press OK to cancel the connection and run in Standalone mode.", "Notice", MessageBoxButtons.OKCancel)
        'dr = MessageBox.Show("Press OK to cancel the connection and run in Standalone mode.", "Notice", MessageBoxButtons.OK) 'Only need the OK button
        'dr = MessageBox.Show("Press OK to run in Stand-alone mode.", "Attempting to connect to the Message Service.", MessageBoxButtons.OK) 'Only need the OK button ERROR
        dr = MessageBox.Show("Press OK to run in Stand-alone mode.", "Attempting to connect to the Message Service.", MessageBoxButtons.OKCancel) 'Only need the OK button ERROR
        If dr = System.Windows.Forms.DialogResult.OK Then
            SyncLock myLock
                ConnCancelled = True
                'client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 0) 'This does not seem to work. THe original 16 second timeout is still used.
                client.Close()
                Debug.WriteLine("Client Closed")
            End SyncLock
        End If

        ''Try looping:
        'Dim I As Integer
        'For I = 1 To 16
        '    dr = MessageBox.Show("Press OK to cancel the connection and run in Standalone mode." & I, "Notice", MessageBoxButtons.OK)
        '    If dr = System.Windows.Forms.DialogResult.OK Then
        '        SyncLock myLock
        '            ConnCancelled = True
        '            'client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 0) 'This does not seem to work. THe original 16 second timeout is still used.
        '            client.Close()
        '            Exit For
        '        End SyncLock
        '    End If
        '    System.Threading.Thread.Sleep(500) 'Pause for 500ms
        '    dr = Nothing
        'Next
        'DOESNT WORK

    End Sub

    'THIS WAS TEST CODE - NOT USED:
    'This causes an error:
    'Private Sub bgwCancelConn_Disposed(sender As Object, e As DoWorkEventArgs) Handles bgwCancelConn.Disposed
    '    'WebPageList.Close() 'ERROR
    'End Sub

    'THIS WAS TEST CODE - NOT USED:
    'Private Sub bgwConnectToComNet_DoWork(sender As Object, e As String) Handles bgwConnectToComNet.DoWork
    'Private Sub bgwConnectToComNet_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwConnectToComNet.DoWork
    '    'Connect to the Message Service on a separate thread.

    '    'Note: Use SyncLock if a global variable will be modified in a background worker. https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/statements/synclock-statement

    '    'UPDATE: this is now done in NewConnectToComNet
    '    'SyncLock myLock
    '    '    If IsNothing(client) Then
    '    '        client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
    '    '    End If
    '    'End SyncLock

    '    Try
    '        SyncLock myLock
    '            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 16) 'Temporarily set the send timeaout to 16 seconds (8 seconds is too short for a slow computer!)
    '            'ConnectionName = ConnName 'This name will be modified if it is already used in an existing connection.
    '            ConnectionName = e.Argument 'Use the passed connection name.
    '            If ConnectionName = "" Then ConnectionName = ApplicationInfo.Name
    '            ConnectionName = client.Connect(ProNetName, ApplicationInfo.Name, ConnectionName, Project.Name, Project.Description, Project.Type, Project.Path, False, False)
    '            'ConnectionName = client.ConnectAsync(ProNetName, ApplicationInfo.Name, ConnectionName, Project.Name, Project.Description, Project.Type, Project.Path, False, False)
    '        End SyncLock

    '        If ConnectionName <> "" Then
    '            'Message.Add("Connected to the Andorville™ Network with Connection Name: [" & ProNetName & "]." & ConnectionName & vbCrLf)
    '            'bgwConnectToComNet.ReportProgress(1, "Connected to the Andorville™ Network with Connection Name: [" & ProNetName & "]." & ConnectionName & vbCrLf)

    '            'bgwConnectToComNet.ReportProgress(1, "Connected")
    '            'UPDATE: Trying to update ConnectedToComNet directly - to avoid delay:
    '            SyncLock myLock
    '                ConnectedToComNet = True
    '                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 0)
    '            End SyncLock


    '            'The following code is now run in bgwConnectToComNet.ProgressChanged
    '            'client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
    '            'btnOnline.Text = "Online"
    '            'btnOnline.ForeColor = Color.ForestGreen
    '            'ConnectedToComNet = True
    '            'SendApplicationInfo()
    '            'SendProjectInfo()
    '            'client.GetAdvlNetworkAppInfoAsync() 'Update the Exe Path in case it has changed. This path may be needed in the future to start the ComNet (Message Service).

    '            'UPDATE: commented out in an attempt to avoid error
    '            'bgwComCheck.WorkerReportsProgress = True
    '            'bgwComCheck.WorkerSupportsCancellation = True
    '            'If bgwComCheck.IsBusy Then
    '            '    'The ComCheck thread is already running.
    '            'Else
    '            '    bgwComCheck.RunWorkerAsync() 'Start the ComCheck thread.
    '            'End If
    '            'Exit Sub 'Connection made OK
    '        Else
    '            'Message.Add("Connection to the Andorville™ Network failed!" & vbCrLf)
    '            'Message.Add("The Andorville™ Network was not found. Attempting to start it." & vbCrLf)
    '            'bgwConnectToComNet.ReportProgress(1, "The Andorville™ Network was not found. Attempting to start it." & vbCrLf)
    '            'SyncLock myLock
    '            '    client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
    '            'End SyncLock
    '        End If
    '    Catch ex As System.TimeoutException
    '        'Message.Add("Message Service Check Timeout error. Check if the Andorville™ Network (Message Service) is running." & vbCrLf)
    '        'bgwConnectToComNet.ReportProgress(1, "Message Service Check Timeout error. Check if the Andorville™ Network (Message Service) is running." & vbCrLf)
    '        'SyncLock myLock
    '        '    client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
    '        'End SyncLock

    '        'Message.Add("Attempting to start the Message Service." & vbCrLf)
    '        'bgwConnectToComNet.ReportProgress(1, "Attempting to start the Message Service." & vbCrLf)
    '    Catch ex As Exception
    '        'Message.Add("Error message: " & ex.Message & vbCrLf)
    '        'bgwConnectToComNet.ReportProgress(1, "Error message: " & ex.Message & vbCrLf)
    '        'SyncLock myLock
    '        '    client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
    '        'End SyncLock

    '        'Message.Add("Attempting to start the Message Service." & vbCrLf)
    '        'bgwConnectToComNet.ReportProgress(1, "Attempting to start the Message Service." & vbCrLf)
    '    End Try
    '    'END UPDATE

    '    'UPDATE No longer required??? NewConnectToComNet will now try to fix a faulted client.
    '    'If ConnectedToComNet = False Then
    '    '    SyncLock myLock
    '    '        If IsNothing(client) Then
    '    '            client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
    '    '        End If

    '    '        'Try to fix a faulted client state:
    '    '        If client.State = ServiceModel.CommunicationState.Faulted Then
    '    '            client = Nothing
    '    '            client = New ServiceReference1.MsgServiceClient(New System.ServiceModel.InstanceContext(New MsgServiceCallback))
    '    '        End If
    '    '    End SyncLock

    '    '    If client.State = ServiceModel.CommunicationState.Faulted Then
    '    '        'Message.AddWarning("client state is faulted. Connection not made!" & vbCrLf)
    '    '        bgwConnectToComNet.ReportProgress(1, "client state is faulted. Connection not made!" & vbCrLf)
    '    '        bgwConnectToComNet.ReportProgress(1, "Run Standalone")
    '    '    Else
    '    '        Try
    '    '            SyncLock myLock
    '    '                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(0, 0, 16) 'Temporarily set the send timeout to 16 seconds (8 seconds is too short for a slow computer!)
    '    '                ConnectionName = ConnName 'This name will be modified if it is already used in an existing connection.
    '    '                ConnectionName = client.Connect(ProNetName, ApplicationInfo.Name, ConnectionName, Project.Name, Project.Description, Project.Type, Project.Path, False, False)
    '    '            End SyncLock

    '    '            If ConnectionName <> "" Then
    '    '                'Message.Add("Connected to the Andorville™ Network with Connection Name: [" & ProNetName & "]." & ConnectionName & vbCrLf)
    '    '                bgwConnectToComNet.ReportProgress(1, "Connected to the Andorville™ Network with Connection Name: [" & ProNetName & "]." & ConnectionName & vbCrLf)
    '    '                bgwConnectToComNet.ReportProgress(1, "Connected")
    '    '                'The following code is now run in bgwConnectToComNet.ProgressChanged
    '    '                'client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
    '    '                'btnOnline.Text = "Online"
    '    '                'btnOnline.ForeColor = Color.ForestGreen
    '    '                'ConnectedToComNet = True
    '    '                'SendApplicationInfo()
    '    '                'SendProjectInfo()
    '    '                'client.GetAdvlNetworkAppInfoAsync() 'Update the Exe Path in case it has changed. This path may be needed in the future to start the ComNet (Message Service).

    '    '                'bgwConnectToComNet.ReportProgress(1, "Cancel Run Standalone Dialog")

    '    '                bgwComCheck.WorkerReportsProgress = True
    '    '                bgwComCheck.WorkerSupportsCancellation = True
    '    '                If bgwComCheck.IsBusy Then
    '    '                    'The ComCheck thread is already running.
    '    '                Else
    '    '                    bgwComCheck.RunWorkerAsync() 'Start the ComCheck thread.
    '    '                End If

    '    '            Else
    '    '                'Message.Add("Connection to the Andorville™ Network failed!" & vbCrLf)
    '    '                bgwConnectToComNet.ReportProgress(1, "Connection to the Andorville™ Network failed!" & vbCrLf)
    '    '                SyncLock myLock
    '    '                    client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
    '    '                End SyncLock
    '    '                bgwConnectToComNet.ReportProgress(1, "Run Standalone")
    '    '            End If
    '    '        Catch ex As System.TimeoutException
    '    '            'Message.Add("Timeout error. Check if the Andorville™ Network (Message Service) is running." & vbCrLf)
    '    '            bgwConnectToComNet.ReportProgress(1, "Timeout error. Check if the Andorville™ Network (Message Service) is running." & vbCrLf)
    '    '            bgwConnectToComNet.ReportProgress(1, "Run Standalone")
    '    '        Catch ex As Exception
    '    '            'Message.Add("Error message: " & ex.Message & vbCrLf)
    '    '            bgwConnectToComNet.ReportProgress(1, "Error message: " & ex.Message & vbCrLf)
    '    '            SyncLock myLock
    '    '                client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
    '    '            End SyncLock
    '    '            bgwConnectToComNet.ReportProgress(1, "Run Standalone")
    '    '        End Try
    '    '    End If
    '    'Else
    '    '    'Message.AddWarning("Already connected to the Andorville™ Network (Message Service)." & vbCrLf)
    '    '    bgwConnectToComNet.ReportProgress(1, "Already connected to the Andorville™ Network (Message Service)." & vbCrLf)
    '    '    bgwConnectToComNet.ReportProgress(1, "Run Standalone" & vbCrLf)
    '    'End If


    'End Sub

    'THIS WAS TEST CODE - NOT USED:
    'Private Sub bgwConnectToComNet_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwConnectToComNet.ProgressChanged
    '    'The Connect to ComNet progress has changed.
    '    'e.UserState.ToString is the progress message.

    '    'NOTE: This technique seems to delay the code execution.

    '    Select Case e.UserState.ToString
    '        Case "Connected"
    '            client.Endpoint.Binding.SendTimeout = New System.TimeSpan(1, 0, 0) 'Restore the send timeout to 1 hour
    '            btnOnline.Text = "Online"
    '            btnOnline.ForeColor = Color.ForestGreen
    '            ConnectedToComNet = True
    '            'Try doing this later
    '            'SendApplicationInfo()
    '            'SendProjectInfo()
    '            'client.GetAdvlNetworkAppInfoAsync() 'Update the Exe Path in case it has changed. This path may be needed in the future to start the ComNet (Message Service).

    '        Case "Run Standalone"
    '            'Run the application in Standalong mode.

    '        Case Else
    '            'Message.Add(e.UserState.ToString)
    '    End Select

    'End Sub


    Private Sub DisconnectFromComNet()
        'Disconnect from the Communication Network (Message Service).

        If ConnectedToComNet = True Then
            If IsNothing(client) Then
                Message.Add("Already disconnected from the Andorville™ Network (Message Service)." & vbCrLf)
                btnOnline.Text = "Offline"
                btnOnline.ForeColor = Color.Red
                ConnectedToComNet = False
                ConnectionName = ""
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("client state is faulted." & vbCrLf)
                    ConnectionName = ""
                Else
                    Try
                        client.Disconnect(ProNetName, ConnectionName)
                        btnOnline.Text = "Offline"
                        btnOnline.ForeColor = Color.Red
                        ConnectedToComNet = False
                        ConnectionName = ""
                        Message.Add("Disconnected from the Andorville™ Network (Message Service)." & vbCrLf)

                        If bgwComCheck.IsBusy Then
                            bgwComCheck.CancelAsync()
                        End If

                    Catch ex As Exception
                        Message.AddWarning("Error disconnecting from Andorville™ Network (Message Service): " & ex.Message & vbCrLf)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub SendApplicationInfo()
        'Send the application information to the Network application.

        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("Client state is faulted. Message not sent!" & vbCrLf)
            Else
                'Create the XML instructions to send application information.
                Dim decl As New XDeclaration("1.0", "utf-8", "yes")
                Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
                Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class
                Dim applicationInfo As New XElement("ApplicationInfo")
                Dim name As New XElement("Name", Me.ApplicationInfo.Name)
                applicationInfo.Add(name)

                Dim text As New XElement("Text", "Coordinates Client 2")
                applicationInfo.Add(text)

                Dim exePath As New XElement("ExecutablePath", Me.ApplicationInfo.ExecutablePath)
                applicationInfo.Add(exePath)

                Dim directory As New XElement("Directory", Me.ApplicationInfo.ApplicationDir)
                applicationInfo.Add(directory)
                Dim description As New XElement("Description", Me.ApplicationInfo.Description)
                applicationInfo.Add(description)
                xmessage.Add(applicationInfo)
                doc.Add(xmessage)

                'Show the message sent to ComNet:
                Message.XAddText("Message sent to " & "Message Service" & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line

                client.SendMessage("", "MessageService", doc.ToString)
            End If
        End If
    End Sub

    Private Sub SendProjectInfo()
        'Send the project information to the Network application.

        If ConnectedToComNet = False Then
            Message.AddWarning("The 1 application is not connected to the Message Service." & vbCrLf)
        Else 'Connected to the Message Service (ComNet).
            If IsNothing(client) Then
                Message.Add("No client connection available!" & vbCrLf)
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("Client state is faulted. Message not sent!" & vbCrLf)
                Else
                    'Construct the XMessage to send to AppNet:
                    Dim decl As New XDeclaration("1.0", "utf-8", "yes")
                    Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
                    Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class
                    Dim projectInfo As New XElement("ProjectInfo")

                    Dim Path As New XElement("Path", Project.Path)
                    projectInfo.Add(Path)
                    xmessage.Add(projectInfo)
                    doc.Add(xmessage)

                    'Show the message sent to the Message Service:
                    Message.XAddText("Message sent to " & "Message Service" & ":" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(doc.ToString)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                    client.SendMessage("", "MessageService", doc.ToString)
                End If
            End If
        End If
    End Sub

    Public Sub SendProjectInfo(ByVal ProjectPath As String)
        'Send the project information to the Network application.
        'This version of SendProjectInfo uses the ProjectPath argument.

        If ConnectedToComNet = False Then
            Message.AddWarning("The 2 application is not connected to the Message Service." & vbCrLf)
        Else 'Connected to the Message Service (ComNet).
            If IsNothing(client) Then
                Message.Add("No client connection available!" & vbCrLf)
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("Client state is faulted. Message not sent!" & vbCrLf)
                Else
                    'Construct the XMessage to send to AppNet:
                    Dim decl As New XDeclaration("1.0", "utf-8", "yes")
                    Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
                    Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class
                    Dim projectInfo As New XElement("ProjectInfo")

                    'Dim Path As New XElement("Path", Project.Path)
                    Dim Path As New XElement("Path", ProjectPath)
                    projectInfo.Add(Path)
                    xmessage.Add(projectInfo)
                    doc.Add(xmessage)

                    'Show the message sent to the Message Service:
                    Message.XAddText("Message sent to " & "Message Service" & ":" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(doc.ToString)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                    client.SendMessage("", "MessageService", doc.ToString)
                End If
            End If
        End If
    End Sub

    Private Function ComNetRunning() As Boolean
        'Return True if ComNet (Message Service) is running.
        ''If System.IO.File.Exists(MsgServiceAppPath & "\Application.Lock") Then
        'If System.IO.File.Exists(AdvlNetworkAppPath & "\Application.Lock") Then
        '    Return True
        'Else
        '    Return False
        'End If

        'If MsgServiceAppPath = "" Then
        If AdvlNetworkAppPath = "" Then
            'Message.Add("Message Service application path is not known." & vbCrLf)
            Message.Add("Andorville™ Network application path is not known." & vbCrLf)
            'Message.Add("Run the Message Service before connecting to update the path." & vbCrLf)
            Message.Add("Run the Andorville™ Network before connecting to update the path." & vbCrLf)
            Return False
        Else
            'If System.IO.File.Exists(MsgServiceAppPath & "\Application.Lock") Then
            If System.IO.File.Exists(AdvlNetworkAppPath & "\Application.Lock") Then
                'Message.Add("AppLock found - ComNet is running." & vbCrLf)
                Return True
            Else
                'Message.Add("AppLock not found - ComNet is running." & vbCrLf)
                Return False
            End If
        End If

    End Function

#End Region 'Online/Offline code ----------------------------------------------------------------------------------------------------------------------------------------

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter
        'Update the current duration:

        'txtCurrentDuration.Text = Project.Usage.CurrentDuration.Days.ToString.PadLeft(5, "0"c) & ":" &
        '                           Project.Usage.CurrentDuration.Hours.ToString.PadLeft(2, "0"c) & ":" &
        '                           Project.Usage.CurrentDuration.Minutes.ToString.PadLeft(2, "0"c) & ":" &
        '                           Project.Usage.CurrentDuration.Seconds.ToString.PadLeft(2, "0"c)

        txtCurrentDuration.Text = Project.Usage.CurrentDuration.Days.ToString.PadLeft(5, "0"c) & "d:" &
                           Project.Usage.CurrentDuration.Hours.ToString.PadLeft(2, "0"c) & "h:" &
                           Project.Usage.CurrentDuration.Minutes.ToString.PadLeft(2, "0"c) & "m:" &
                           Project.Usage.CurrentDuration.Seconds.ToString.PadLeft(2, "0"c) & "s"

        Timer1.Interval = 5000 '5 seconds
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Update the current duration:

        'txtCurrentDuration.Text = Project.Usage.CurrentDuration.Days.ToString.PadLeft(5, "0"c) & ":" &
        '                   Project.Usage.CurrentDuration.Hours.ToString.PadLeft(2, "0"c) & ":" &
        '                   Project.Usage.CurrentDuration.Minutes.ToString.PadLeft(2, "0"c) & ":" &
        '                   Project.Usage.CurrentDuration.Seconds.ToString.PadLeft(2, "0"c)

        txtCurrentDuration.Text = Project.Usage.CurrentDuration.Days.ToString.PadLeft(5, "0"c) & "d:" &
                   Project.Usage.CurrentDuration.Hours.ToString.PadLeft(2, "0"c) & "h:" &
                   Project.Usage.CurrentDuration.Minutes.ToString.PadLeft(2, "0"c) & "m:" &
                   Project.Usage.CurrentDuration.Seconds.ToString.PadLeft(2, "0"c) & "s"
    End Sub

    Private Sub TabPage2_Leave(sender As Object, e As EventArgs) Handles TabPage2.Leave
        Timer1.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Add the current project to the Message Service list.

        If Project.ParentProjectName <> "" Then
            Message.AddWarning("This project has a parent: " & Project.ParentProjectName & vbCrLf)
            Message.AddWarning("Child projects can not be added to the list." & vbCrLf)
            Exit Sub
        End If

        If ConnectedToComNet = False Then
            Message.AddWarning("The 3 application is not connected to the Message Service." & vbCrLf)
        Else 'Connected to the Message Service (ComNet).
            If IsNothing(client) Then
                Message.Add("No client connection available!" & vbCrLf)
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("Client state is faulted. Message not sent!" & vbCrLf)
                Else
                    'Construct the XMessage to send to AppNet:
                    Dim decl As New XDeclaration("1.0", "utf-8", "yes")
                    Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
                    Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class
                    Dim projectInfo As New XElement("ProjectInfo")

                    Dim Path As New XElement("Path", Project.Path)
                    projectInfo.Add(Path)
                    xmessage.Add(projectInfo)
                    doc.Add(xmessage)

                    'Show the message sent to AppNet:
                    Message.XAddText("Message sent to " & "Message Service" & ":" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(doc.ToString)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                    client.SendMessage("", "MessageService", doc.ToString)
                End If
            End If
        End If
    End Sub

    Private Sub btnOpenProject_Click(sender As Object, e As EventArgs) Handles btnOpenProject.Click

        If Project.Type = ADVL_Utilities_Library_1.Project.Types.Archive Then
            If IsNothing(ProjectArchive) Then
                ProjectArchive = New frmArchive
                ProjectArchive.Show()
                ProjectArchive.Title = "Project Archive"
                ProjectArchive.Path = Project.Path
            Else
                ProjectArchive.Show()
                ProjectArchive.BringToFront()
            End If
        Else
            Process.Start(Project.Path)
        End If

    End Sub

    Private Sub ProjectArchive_FormClosed(sender As Object, e As FormClosedEventArgs) Handles ProjectArchive.FormClosed
        ProjectArchive = Nothing
    End Sub

    Private Sub btnOpenSettings_Click(sender As Object, e As EventArgs) Handles btnOpenSettings.Click
        If Project.SettingsLocn.Type = ADVL_Utilities_Library_1.FileLocation.Types.Directory Then
            Process.Start(Project.SettingsLocn.Path)
        ElseIf Project.SettingsLocn.Type = ADVL_Utilities_Library_1.FileLocation.Types.Archive Then
            If IsNothing(SettingsArchive) Then
                SettingsArchive = New frmArchive
                SettingsArchive.Show()
                SettingsArchive.Title = "Settings Archive"
                SettingsArchive.Path = Project.SettingsLocn.Path
            Else
                SettingsArchive.Show()
                SettingsArchive.BringToFront()
            End If
        End If
    End Sub

    Private Sub SettingsArchive_FormClosed(sender As Object, e As FormClosedEventArgs) Handles SettingsArchive.FormClosed
        SettingsArchive = Nothing
    End Sub

    Private Sub btnOpenData_Click(sender As Object, e As EventArgs) Handles btnOpenData.Click
        If Project.DataLocn.Type = ADVL_Utilities_Library_1.FileLocation.Types.Directory Then
            Process.Start(Project.DataLocn.Path)
        ElseIf Project.DataLocn.Type = ADVL_Utilities_Library_1.FileLocation.Types.Archive Then
            If IsNothing(DataArchive) Then
                DataArchive = New frmArchive
                DataArchive.Show()
                DataArchive.Title = "Data Archive"
                DataArchive.Path = Project.DataLocn.Path
            Else
                DataArchive.Show()
                DataArchive.BringToFront()
            End If
        End If
    End Sub

    Private Sub DataArchive_FormClosed(sender As Object, e As FormClosedEventArgs) Handles DataArchive.FormClosed
        DataArchive = Nothing
    End Sub


    Private Sub btnOpenSystem_Click(sender As Object, e As EventArgs) Handles btnOpenSystem.Click
        If Project.SystemLocn.Type = ADVL_Utilities_Library_1.FileLocation.Types.Directory Then
            Process.Start(Project.SystemLocn.Path)
        ElseIf Project.SystemLocn.Type = ADVL_Utilities_Library_1.FileLocation.Types.Archive Then
            If IsNothing(SystemArchive) Then
                SystemArchive = New frmArchive
                SystemArchive.Show()
                SystemArchive.Title = "System Archive"
                SystemArchive.Path = Project.SystemLocn.Path
            Else
                SystemArchive.Show()
                SystemArchive.BringToFront()
            End If
        End If
    End Sub

    Private Sub SystemArchive_FormClosed(sender As Object, e As FormClosedEventArgs) Handles SystemArchive.FormClosed
        SystemArchive = Nothing
    End Sub

    Private Sub btnOpenAppDir_Click(sender As Object, e As EventArgs) Handles btnOpenAppDir.Click
        Process.Start(ApplicationInfo.ApplicationDir)
    End Sub

    Private Sub btnCreateArchive_Click(sender As Object, e As EventArgs) Handles btnCreateArchive.Click
        'Create a Project Archive file.
        If Project.Type = ADVL_Utilities_Library_1.Project.Types.Archive Then
            Message.Add("The Project is an Archive type. It is already in an archived format." & vbCrLf)

        Else
            'The project is contained in the directory Project.Path.
            'This directory and contents will be saved in a zip file in the parent directory with the same name but with extension .AdvlArchive.

            Dim ParentDir As String = System.IO.Directory.GetParent(Project.Path).FullName
            Dim ProjectArchiveName As String = System.IO.Path.GetFileName(Project.Path) & ".AdvlArchive"

            If My.Computer.FileSystem.FileExists(ParentDir & "\" & ProjectArchiveName) Then 'The Project Archive file already exists.
                Message.Add("The Project Archive file already exists: " & ParentDir & "\" & ProjectArchiveName & vbCrLf)
            Else 'The Project Archive file does not exist. OK to create the Archive.
                System.IO.Compression.ZipFile.CreateFromDirectory(Project.Path, ParentDir & "\" & ProjectArchiveName)

                'Remove all Lock files:
                Dim Zip As System.IO.Compression.ZipArchive
                Zip = System.IO.Compression.ZipFile.Open(ParentDir & "\" & ProjectArchiveName, IO.Compression.ZipArchiveMode.Update)
                Dim DeleteList As New List(Of String) 'List of entry names to delete
                Dim myEntry As System.IO.Compression.ZipArchiveEntry
                For Each entry As System.IO.Compression.ZipArchiveEntry In Zip.Entries
                    If entry.Name = "Project.Lock" Then
                        DeleteList.Add(entry.FullName)
                    End If
                Next
                For Each item In DeleteList
                    myEntry = Zip.GetEntry(item)
                    myEntry.Delete()
                Next
                Zip.Dispose()

                Message.Add("Project Archive file created: " & ParentDir & "\" & ProjectArchiveName & vbCrLf)
            End If
        End If
    End Sub

    Private Sub btnOpenArchive_Click(sender As Object, e As EventArgs) Handles btnOpenArchive.Click
        'Open a Project Archive file.

        'Use the OpenFileDialog to look for an .AdvlArchive file.      
        OpenFileDialog1.Title = "Select an Archived Project File"
        OpenFileDialog1.InitialDirectory = System.IO.Directory.GetParent(Project.Path).FullName 'Start looking in the ParentDir.
        OpenFileDialog1.Filter = "Archived Project|*.AdvlArchive"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim FileName As String = OpenFileDialog1.FileName
            OpenArchivedProject(FileName)
        End If
    End Sub

    Private Sub OpenArchivedProject(ByVal FilePath As String)
        'Open the archived project at the specified path.

        Dim Zip As System.IO.Compression.ZipArchive
        Try
            Zip = System.IO.Compression.ZipFile.OpenRead(FilePath)

            Dim Entry As System.IO.Compression.ZipArchiveEntry = Zip.GetEntry("Project_Info_ADVL_2.xml")
            If IsNothing(Entry) Then
                Message.AddWarning("The file is not an Archived Andorville Project." & vbCrLf)
                'Check if it is an Archive project type with a .AdvlProject extension.
                'NOTE: These are already zip files so no need to archive.

            Else
                Message.Add("The file is an Archived Andorville Project." & vbCrLf)
                Dim ParentDir As String = System.IO.Directory.GetParent(FilePath).FullName
                Dim ProjectName As String = System.IO.Path.GetFileNameWithoutExtension(FilePath)
                Message.Add("The Project will be expanded in the directory: " & ParentDir & vbCrLf)
                Message.Add("The Project name will be: " & ProjectName & vbCrLf)
                Zip.Dispose()
                If System.IO.Directory.Exists(ParentDir & "\" & ProjectName) Then
                    Message.AddWarning("The Project already exists: " & ParentDir & "\" & ProjectName & vbCrLf)
                Else
                    System.IO.Compression.ZipFile.ExtractToDirectory(FilePath, ParentDir & "\" & ProjectName) 'Extract the project from the archive                   
                    Project.AddProjectToList(ParentDir & "\" & ProjectName)
                    'Open the new project                 
                    CloseProject()  'Close the current project
                    Project.SelectProject(ParentDir & "\" & ProjectName) 'Select the project at the specifed path.
                    OpenProject() 'Open the selected project.
                End If
            End If
        Catch ex As Exception
            Message.AddWarning("Error opening Archived Andorville Project: " & ex.Message & vbCrLf)
        End Try
    End Sub

    Private Sub TabPage2_DragEnter(sender As Object, e As DragEventArgs) Handles TabPage2.DragEnter
        'DragEnter: An object has been dragged into TabPage2 - Project Information tab.
        'This code is required to get the link to the item(s) being dragged into Project Information:
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Link
        End If
    End Sub

    Private Sub TabPage2_DragDrop(sender As Object, e As DragEventArgs) Handles TabPage2.DragDrop
        'A file has been dropped into the Project Information tab.

        Dim Path As String()
        Path = e.Data.GetData(DataFormats.FileDrop)
        Dim I As Integer

        If Path.Count > 0 Then
            If Path.Count > 1 Then
                Message.AddWarning("More than one file has been dropped into the Project Information tab. Only the first one will be opened." & vbCrLf)
            End If

            Try
                Dim ArchivedProjectPath As String = Path(0)
                If ArchivedProjectPath.EndsWith(".AdvlArchive") Then
                    Message.Add("The archived project will be opened: " & vbCrLf & ArchivedProjectPath & vbCrLf)
                    OpenArchivedProject(ArchivedProjectPath)
                Else
                    Message.Add("The dropped file is not an archived project: " & vbCrLf & ArchivedProjectPath & vbCrLf)
                End If
            Catch ex As Exception
                Message.AddWarning("Error opening dropped archived project. " & ex.Message & vbCrLf)
            End Try
        End If
    End Sub

    Private Sub btnOpenParentDir_Click(sender As Object, e As EventArgs) Handles btnOpenParentDir.Click
        'Open the Parent directory of the selected project.
        Dim ParentDir As String = System.IO.Directory.GetParent(Project.Path).FullName
        If System.IO.Directory.Exists(ParentDir) Then
            Process.Start(ParentDir)
        Else
            Message.AddWarning("The parent directory was not found: " & ParentDir & vbCrLf)
        End If

    End Sub


#Region " Process XMessages" '===========================================================================================================================================

    Private Sub XMsg_Instruction(Data As String, Locn As String) Handles XMsg.Instruction
        'Process an XMessage instruction.
        'An XMessage is a simplified XSequence. It is used to exchange information between Andorville™ applications.
        '
        'An XSequence file is an AL-H7™ Information Sequence stored in an XML format.
        'AL-H7™ is the name of a programming system that uses sequences of data and location value pairs to store information or processing steps.
        'Any program, mathematical expression or data set can be expressed as an Information Sequence.

        'Add code here to process the XMessage instructions.
        'See other Andorville™ applications for examples.

        If IsDBNull(Data) Then
            Data = ""
        End If

        'Intercept instructions with the prefix "WebPage_"
        If Locn.StartsWith("WebPage_") Then 'Send the Data, Location data to the correct Web Page:
            'Message.Add("Web Page Location: " & Locn & vbCrLf)
            If Locn.Contains(":") Then
                Dim EndOfWebPageNoString As Integer = Locn.IndexOf(":")
                If Locn.Contains("-") Then
                    Dim HyphenLocn As Integer = Locn.IndexOf("-")
                    If HyphenLocn < EndOfWebPageNoString Then 'Web Page Location contains a sub-location in the web page - WebPage_1-SubLocn:Locn - SubLocn:Locn will be sent to Web page 1
                        EndOfWebPageNoString = HyphenLocn
                    End If
                End If
                Dim PageNoLen As Integer = EndOfWebPageNoString - 8
                Dim WebPageNoString As String = Locn.Substring(8, PageNoLen)
                Dim WebPageNo As Integer = CInt(WebPageNoString)
                Dim WebPageData As String = Data
                Dim WebPageLocn As String = Locn.Substring(EndOfWebPageNoString + 1)

                'Message.Add("WebPageData = " & WebPageData & "  WebPageLocn = " & WebPageLocn & vbCrLf)

                WebPageFormList(WebPageNo).XMsgInstruction(WebPageData, WebPageLocn)
            Else
                Message.AddWarning("XMessage instruction location is not complete: " & Locn & vbCrLf)
            End If
        Else

            Select Case Locn

                Case "ClientProNetName"
                    ClientProNetName = Data 'The name of the Client Application Network requesting service. AD

                Case "ClientName"
                    ClientAppName = Data 'The name of the Client application requesting service.

                Case "ClientConnectionName"
                    ClientConnName = Data 'The name of the client connection requesting service.

                Case "ClientLocn" 'The Location within the Client requesting service.
                    Dim statusOK As New XElement("Status", "OK") 'Add Status OK element when the Client Location is changed
                    xlocns(xlocns.Count - 1).Add(statusOK)

                    xmessage.Add(xlocns(xlocns.Count - 1)) 'Add the instructions for the last location to the reply xmessage
                    xlocns.Add(New XElement(Data)) 'Start the new location instructions

                Case "OnCompletion"
                    OnCompletionInstruction = Data

                Case "Main"
                 'Blank message - do nothing.

                Case "Main:EndInstruction"
                    Select Case Data
                        Case "Stop"
                            'Stop at the end of the instruction sequence.
                            'Add other cases here:
                        'Case "AutoResizeDatumTransLists"
                        '    dgvDirectDTOps.AutoResizeColumns()
                        '    dgvInputToWgs84DTOps.AutoResizeColumns()
                        '    dgvWgs84ToOutputDTOps.AutoResizeColumns()

                        Case "DatumListsUpdated"
                            dgvDirectDTOps.AutoResizeColumns()
                            dgvInputToWgs84DTOps.AutoResizeColumns()
                            dgvWgs84ToOutputDTOps.AutoResizeColumns()
                            AutoSelectDatumTrans()
                            'This method should not send a message with the selections back to the server: 
                            'Error running XMsg: This operation would deadlock because the reply cannot be received until the current Message completes processing. 
                            'If you want to allow out-of-order message processing, specify ConcurrencyMode of Reentrant or Multiple on CallbackBehaviorAttribute.


                    End Select

                Case "Main:Status"
                    Select Case Data
                        Case "OK"
                            'Main instructions completed OK
                    End Select



                Case "Command"
                    Select Case Data
                        Case "ConnectToComNet" 'Startup Command
                            If ConnectedToComNet = False Then
                                ConnectToComNet()
                            End If
                        Case "AppComCheck"
                            'Add the Appplication Communication info to the reply message:
                            Dim clientProNetName As New XElement("ClientProNetName", ProNetName) 'The Project Network Name
                            xlocns(xlocns.Count - 1).Add(clientProNetName)
                            Dim clientName As New XElement("ClientName", "ADVL_Coordinates_Client_2") 'The name of this application.
                            xlocns(xlocns.Count - 1).Add(clientName)
                            Dim clientConnectionName As New XElement("ClientConnectionName", ConnectionName)
                            xlocns(xlocns.Count - 1).Add(clientConnectionName)
                            '<Status>OK</Status> will be automatically appended to the XMessage before it is sent.
                    End Select




                'Case "Main:Geographic2DCrsList:Geographic2DCrsName" 'NOW USE ONLY Case "Main:CrsList:CrsName"
                '    'Case "Geographic2DCrsList:Geographic2DCrsName"
                '    cmbCrsList.Items.Add(Data)

                'Case "Main:Geographic3DCrsList:Geographic3DCrsName" 'NOW USE ONLY Case "Main:CrsList:CrsName"
                '    ' "Geographic3DCrsList:Geographic3DCrsName"
                '    cmbCrsList.Items.Add(Data)

                'Case "Main:ProjectedCrsList:ProjectedCrsName" 'NOW USE ONLY Case "Main:CrsList:CrsName"
                '    'Case "ProjectedCrsList:ProjectedCrsName"
                '    cmbCrsList.Items.Add(Data)


                'Case "Main:CrsList:CrsName" 'SUPERCEDED BY   Case "Main:CrsList:Crs:Name" and Case "Main:CrsList:Crs:Code"
                '    cmbCrsList.Items.Add(Data)

                Case "Main:CrsList:Crs:Name"
                    CrsName = Data

                Case "Main:CrsList:Crs:Code"
                    CrsCode = Data

                Case "Main:CrsList:Crs:Kind"
                    Dim NewCrsInfo As New crsInfo
                    NewCrsInfo.Name = CrsName
                    NewCrsInfo.Code = CrsCode
                    NewCrsInfo.Kind = Data
                    CrsList.Add(NewCrsInfo)
                    cmbCrsList.Items.Add(CrsName)


                Case "Main:Direct7ParamDatumTransList:DatumTrans:Name"
                    DatumTransName = Data

                Case "Main:Direct7ParamDatumTransList:DatumTrans:Code"
                    DatumTransCode = Data

                Case "Main:Direct7ParamDatumTransList:DatumTrans:Accuracy"
                    DatumTransAccuracy = Data

                Case "Main:Direct7ParamDatumTransList:DatumTrans:Reversible"
                    DatumTransReversible = Data

                Case "Main:Direct7ParamDatumTransList:DatumTrans:ApplyReverse" 'This is the last property of a Datum Transformation record: add the properties to a new entry in the list.
                    DatumTransApplyReverse = Data
                    dgvDirectDTOps.Rows.Add(DatumTransName, DatumTransCode, DatumTransAccuracy, DatumTransReversible, DatumTransApplyReverse)


                Case "Main:InputToWgs84_7ParamDatumTransList:DatumTrans:Name"
                    DatumTransName = Data

                Case "Main:InputToWgs84_7ParamDatumTransList:DatumTrans:Code"
                    DatumTransCode = Data

                Case "Main:InputToWgs84_7ParamDatumTransList:DatumTrans:Accuracy"
                    DatumTransAccuracy = Data

                Case "Main:InputToWgs84_7ParamDatumTransList:DatumTrans:Reversible"
                    DatumTransReversible = Data

                Case "Main:InputToWgs84_7ParamDatumTransList:DatumTrans:ApplyReverse" 'This is the last property of a Datum Transformation record: add the properties to a new entry in the list.
                    DatumTransApplyReverse = Data
                    dgvInputToWgs84DTOps.Rows.Add(DatumTransName, DatumTransCode, DatumTransAccuracy, DatumTransReversible, DatumTransApplyReverse)



                Case "Main:Wgs84ToOutput_7ParamDatumTransList:DatumTrans:Name"
                    DatumTransName = Data

                Case "Main:Wgs84ToOutput_7ParamDatumTransList:DatumTrans:Code"
                    DatumTransCode = Data

                Case "Main:Wgs84ToOutput_7ParamDatumTransList:DatumTrans:Accuracy"
                    DatumTransAccuracy = Data

                Case "Main:Wgs84ToOutput_7ParamDatumTransList:DatumTrans:Reversible"
                    DatumTransReversible = Data

                Case "Main:Wgs84ToOutput_7ParamDatumTransList:DatumTrans:ApplyReverse" 'This is the last property of a Datum Transformation record: add the properties to a new entry in the list.
                    DatumTransApplyReverse = Data
                    dgvWgs84ToOutputDTOps.Rows.Add(DatumTransName, DatumTransCode, DatumTransAccuracy, DatumTransReversible, DatumTransApplyReverse)


               'Process instructions - Converted coordinates received from the Coordinate Server: ------------------------------------------------------------

                Case "Main:Coord:Index"
                    CoordIndex = Data
                Case "Main:Coord:InputEasting"
                    'If chkShowInputEastNorth.Checked Then dgvConversion.Rows(CoordIndex).Cells(3).Value = Data
                    If chkShowInputEastNorth.Checked Then dgvConversion.Rows(CoordIndex).Cells(3).Value = CDbl(Data)
                Case "Main:Coord:InputNorthing"
                    If chkShowInputEastNorth.Checked Then dgvConversion.Rows(CoordIndex).Cells(4).Value = CDbl(Data)
                Case "Main:Coord:InputLongitude"
                    If chkShowInputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(5).Value = CDbl(Data)
                Case "Main:Coord:InputLatitude"
                    If chkShowInputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(6).Value = CDbl(Data)
                Case "Main:Coord:InputLongitudeDms"
                    If chkShowInputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(5).Value = Data
                Case "Main:Coord:InputLatitudeDms"
                    If chkShowInputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(6).Value = Data
                Case "Main:Coord:InputEllHeight"
                    If chkShowInputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(7).Value = CDbl(Data)
                Case "Main:Coord:InputX"
                    If chkShowInputXYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(8).Value = CDbl(Data)
                Case "Main:Coord:InputY"
                    If chkShowInputXYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(9).Value = CDbl(Data)
                Case "Main:Coord:InputZ"
                    If chkShowInputXYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(10).Value = CDbl(Data)
                Case "Main:Coord:Wgs84X"
                    If chkShowWgs84XYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(11).Value = CDbl(Data)
                Case "Main:Coord:Wgs84Y"
                    If chkShowWgs84XYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(12).Value = CDbl(Data)
                Case "Main:Coord:Wgs84Z"
                    If chkShowWgs84XYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(13).Value = CDbl(Data)
                Case "Main:Coord:OutputX"
                    If chkShowOutputXYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(14).Value = CDbl(Data)
                Case "Main:Coord:OutputY"
                    If chkShowOutputXYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(15).Value = CDbl(Data)
                Case "Main:Coord:OutputZ"
                    If chkShowOutputXYZ.Checked Then dgvConversion.Rows(CoordIndex).Cells(16).Value = CDbl(Data)
                Case "Main:Coord:OutputLongitude"
                    If chkShowOutputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(17).Value = CDbl(Data)
                Case "Main:Coord:OutputLatitude"
                    If chkShowOutputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(18).Value = CDbl(Data)
                Case "Main:Coord:OutputLongitudeDms"
                    If chkShowOutputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(17).Value = Data
                Case "Main:Coord:OutputLatitudeDms"
                    If chkShowOutputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(18).Value = Data
                Case "Main:Coord:OutputEllHeight"
                    If chkShowOutputLongLat.Checked Then dgvConversion.Rows(CoordIndex).Cells(19).Value = CDbl(Data)
                Case "Main:Coord:OutputEasting"
                    If chkShowOutputEastNorth.Checked Then dgvConversion.Rows(CoordIndex).Cells(20).Value = CDbl(Data)
                Case "Main:Coord:OutputNorthing"
                    If chkShowOutputEastNorth.Checked Then dgvConversion.Rows(CoordIndex).Cells(21).Value = CDbl(Data)





            'Startup Command Arguments ================================================
                Case "ProNetName"
                'This is currently not used.
                'The ProNetName is determined elsewhere.

                Case "ProjectName"
                    If Project.OpenProject(Data) = True Then
                        ProjectSelected = True 'Project has been opened OK.
                    Else
                        ProjectSelected = False 'Project could not be opened.
                    End If

                Case "ProjectID"
                    Message.AddWarning("Add code to handle ProjectID parameter at StartUp!" & vbCrLf)
                'Note the ComNet will usually select a project using ProjectPath.

                Case "ProjectPath"
                    If Project.OpenProjectPath(Data) = True Then
                        ProjectSelected = True 'Project has been opened OK.
                        'THE PROJECT IS LOCKED IN THE Form.Load EVENT:

                        ApplicationInfo.SettingsLocn = Project.SettingsLocn
                        Message.SettingsLocn = Project.SettingsLocn 'Set up the Message object
                        Message.Show() 'Added 18May19

                        'txtTotalDuration.Text = Project.Usage.TotalDuration.Days.ToString.PadLeft(5, "0"c) & ":" &
                        '              Project.Usage.TotalDuration.Hours.ToString.PadLeft(2, "0"c) & ":" &
                        '              Project.Usage.TotalDuration.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                        '              Project.Usage.TotalDuration.Seconds.ToString.PadLeft(2, "0"c)

                        'txtCurrentDuration.Text = Project.Usage.CurrentDuration.Days.ToString.PadLeft(5, "0"c) & ":" &
                        '               Project.Usage.CurrentDuration.Hours.ToString.PadLeft(2, "0"c) & ":" &
                        '               Project.Usage.CurrentDuration.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                        '               Project.Usage.CurrentDuration.Seconds.ToString.PadLeft(2, "0"c)

                        txtTotalDuration.Text = Project.Usage.TotalDuration.Days.ToString.PadLeft(5, "0"c) & "d:" &
                                        Project.Usage.TotalDuration.Hours.ToString.PadLeft(2, "0"c) & "h:" &
                                        Project.Usage.TotalDuration.Minutes.ToString.PadLeft(2, "0"c) & "m:" &
                                        Project.Usage.TotalDuration.Seconds.ToString.PadLeft(2, "0"c) & "s"

                        txtCurrentDuration.Text = Project.Usage.CurrentDuration.Days.ToString.PadLeft(5, "0"c) & "d:" &
                                       Project.Usage.CurrentDuration.Hours.ToString.PadLeft(2, "0"c) & "h:" &
                                       Project.Usage.CurrentDuration.Minutes.ToString.PadLeft(2, "0"c) & "m:" &
                                       Project.Usage.CurrentDuration.Seconds.ToString.PadLeft(2, "0"c) & "s"

                    Else
                        ProjectSelected = False 'Project could not be opened.
                        Message.AddWarning("Project could not be opened at path: " & Data & vbCrLf)
                    End If

                Case "ConnectionName"
                    StartupConnectionName = Data
            '--------------------------------------------------------------------------

            'Application Information  =================================================
            'returned by client.GetAdvlNetworkAppInfoAsync()
                Case "AdvlNetworkAppInfo:Name"
                'The name of the Andorville™ Network Application. (Not used.)

                Case "AdvlNetworkAppInfo:ExePath"
                    'The executable file path of the Andorville™ Network Application.
                    AdvlNetworkExePath = Data

                Case "AdvlNetworkAppInfo:Path"
                    'The path of the Andorville™ Network Application (ComNet). (This is where an Application.Lock file will be found while ComNet is running.)
                    AdvlNetworkAppPath = Data
           '---------------------------------------------------------------------------

           'Message Window Instructions  ==============================================
                Case "MessageWindow:Left"
                    If IsNothing(Message.MessageForm) Then
                        Message.ApplicationName = ApplicationInfo.Name
                        Message.SettingsLocn = Project.SettingsLocn
                        Message.Show()
                    End If
                    Message.MessageForm.Left = Data
                Case "MessageWindow:Top"
                    If IsNothing(Message.MessageForm) Then
                        Message.ApplicationName = ApplicationInfo.Name
                        Message.SettingsLocn = Project.SettingsLocn
                        Message.Show()
                    End If
                    Message.MessageForm.Top = Data
                Case "MessageWindow:Width"
                    If IsNothing(Message.MessageForm) Then
                        Message.ApplicationName = ApplicationInfo.Name
                        Message.SettingsLocn = Project.SettingsLocn
                        Message.Show()
                    End If
                    Message.MessageForm.Width = Data
                Case "MessageWindow:Height"
                    If IsNothing(Message.MessageForm) Then
                        Message.ApplicationName = ApplicationInfo.Name
                        Message.SettingsLocn = Project.SettingsLocn
                        Message.Show()
                    End If
                    Message.MessageForm.Height = Data
                Case "MessageWindow:Command"
                    Select Case Data
                        Case "BringToFront"
                            If IsNothing(Message.MessageForm) Then
                                Message.ApplicationName = ApplicationInfo.Name
                                Message.SettingsLocn = Project.SettingsLocn
                                Message.Show()
                            End If
                            Message.MessageForm.Activate()
                            Message.MessageForm.TopMost = True
                            Message.MessageForm.TopMost = False
                        Case "SaveSettings"
                            Message.MessageForm.SaveFormSettings()
                    End Select

            '---------------------------------------------------------------------------

            'Command to bring the Application window to the front:
                Case "ApplicationWindow:Command"
                    Select Case Data
                        Case "BringToFront"
                            Me.Activate()
                            Me.TopMost = True
                            Me.TopMost = False
                    End Select

                Case "EndOfSequence"
                    'End of Information Sequence reached.
                    'Add Status OK element at the end of the sequence:
                    Dim statusOK As New XElement("Status", "OK")
                    xlocns(xlocns.Count - 1).Add(statusOK)

                    Select Case EndInstruction
                        Case "Stop"
                            'No instructions.

                            'Add any other Cases here:

                        Case Else
                            Message.AddWarning("Unknown End Instruction: " & EndInstruction & vbCrLf)
                    End Select
                    EndInstruction = "Stop"

                    'Add the final EndInstruction:
                    If OnCompletionInstruction = "Stop" Then
                        'Final EndInstruction is not required.
                    Else
                        Dim xEndInstruction As New XElement("EndInstruction", OnCompletionInstruction)
                        xlocns(xlocns.Count - 1).Add(xEndInstruction)
                        OnCompletionInstruction = "Stop" 'Reset the OnCompletion Instruction
                    End If

                Case Else
                    Message.AddWarning("Unknown location: " & Locn & vbCrLf)
                    Message.AddWarning("            data: " & Data & vbCrLf & vbCrLf)
            End Select
        End If
    End Sub

    Private Sub XMsgLocal_Instruction(Data As String, Locn As String) Handles XMsgLocal.Instruction
        'Process an XMessage instruction locally.

        If IsDBNull(Data) Then
            Data = ""
        End If

        'Intercept instructions with the prefix "WebPage_"
        If Locn.StartsWith("WebPage_") Then 'Send the Data, Location data to the correct Web Page:
            'Message.Add("Web Page Location: " & Locn & vbCrLf)
            If Locn.Contains(":") Then
                Dim EndOfWebPageNoString As Integer = Locn.IndexOf(":")
                If Locn.Contains("-") Then
                    Dim HyphenLocn As Integer = Locn.IndexOf("-")
                    If HyphenLocn < EndOfWebPageNoString Then 'Web Page Location contains a sub-location in the web page - WebPage_1-SubLocn:Locn - SubLocn:Locn will be sent to Web page 1
                        EndOfWebPageNoString = HyphenLocn
                    End If
                End If
                Dim PageNoLen As Integer = EndOfWebPageNoString - 8
                Dim WebPageNoString As String = Locn.Substring(8, PageNoLen)
                Dim WebPageNo As Integer = CInt(WebPageNoString)
                Dim WebPageData As String = Data
                Dim WebPageLocn As String = Locn.Substring(EndOfWebPageNoString + 1)

                'Message.Add("WebPageData = " & WebPageData & "  WebPageLocn = " & WebPageLocn & vbCrLf)

                WebPageFormList(WebPageNo).XMsgInstruction(WebPageData, WebPageLocn)
            Else
                Message.AddWarning("XMessage instruction location is not complete: " & Locn & vbCrLf)
            End If
        Else

            Select Case Locn
                Case "ClientName"
                    ClientAppName = Data 'The name of the Client requesting service.

                'UPDATE:
                Case "OnCompletion"
                    OnCompletionInstruction = Data

                Case "Main"
                 'Blank message - do nothing.


                Case "Main:EndInstruction"
                    Select Case Data
                        Case "Stop"
                            'Stop at the end of the instruction sequence.

                            'Add other cases here:
                    End Select

                Case "Main:Status"
                    Select Case Data
                        Case "OK"
                            'Main instructions completed OK
                    End Select

                Case "EndOfSequence"
                    'End of Information Vector Sequence reached.

                Case Else
                    Message.AddWarning("Local XMessage: " & Locn & vbCrLf)
                    Message.AddWarning("Unknown location: " & Locn & vbCrLf)
                    Message.AddWarning("            data: " & Data & vbCrLf & vbCrLf)
            End Select
        End If
    End Sub



#End Region 'Process XMessages ------------------------------------------------------------------------------------------------------------------------------------------


    Private Sub ToolStripMenuItem1_EditWorkflowTabPage_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1_EditWorkflowTabPage.Click
        'Edit the Workflow Web Page:

        If WorkflowFileName = "" Then
            Message.AddWarning("No page to edit." & vbCrLf)
        Else
            Dim FormNo As Integer = OpenNewHtmlDisplayPage()
            HtmlDisplayFormList(FormNo).FileName = WorkflowFileName
            HtmlDisplayFormList(FormNo).OpenDocument
        End If

    End Sub

    Private Sub ToolStripMenuItem1_ShowStartPageInWorkflowTab_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1_ShowStartPageInWorkflowTab.Click
        'Show the Start Page in the Workflow Tab:
        OpenStartPage()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub Main_Move(sender As Object, e As EventArgs) Handles Me.Move
    '    txtLeft.Text = Me.Left
    '    txtTop.Text = Me.Top
    'End Sub

    Private Sub bgwComCheck_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwComCheck.DoWork
        'The communications check thread.
        While ConnectedToComNet
            Try
                If client.IsAlive() Then
                    bgwComCheck.ReportProgress(1, Format(Now, "HH:mm:ss") & " Connection OK." & vbCrLf)
                Else
                    bgwComCheck.ReportProgress(1, Format(Now, "HH:mm:ss") & " Connection Fault.")
                End If
            Catch ex As Exception
                bgwComCheck.ReportProgress(1, "Error in bgeComCheck_DoWork!" & vbCrLf)
                bgwComCheck.ReportProgress(1, ex.Message & vbCrLf)
            End Try

            'System.Threading.Thread.Sleep(60000) 'Sleep time in milliseconds (60 seconds) - For testing only.
            'System.Threading.Thread.Sleep(3600000) 'Sleep time in milliseconds (60 minutes)
            System.Threading.Thread.Sleep(1800000) 'Sleep time in milliseconds (30 minutes)
        End While
    End Sub

    Private Sub bgwComCheck_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwComCheck.ProgressChanged
        Message.Add(e.UserState.ToString) 'Show the ComCheck message 
    End Sub

    Private Sub XMsg_ErrorMsg(ErrMsg As String) Handles XMsg.ErrorMsg
        Message.AddWarning(ErrMsg & vbCrLf)
    End Sub

    Private Sub bgwSendMessage_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwSendMessage.DoWork
        'Send a message on a separate thread:
        Try
            If IsNothing(client) Then
                bgwSendMessage.ReportProgress(1, "No Connection available. Message not sent!")
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    bgwSendMessage.ReportProgress(1, "Connection state is faulted. Message not sent!")
                Else
                    Dim SendMessageParams As clsSendMessageParams = e.Argument
                    client.SendMessage(SendMessageParams.ProjectNetworkName, SendMessageParams.ConnectionName, SendMessageParams.Message)
                End If
            End If
        Catch ex As Exception
            bgwSendMessage.ReportProgress(1, ex.Message)
        End Try
    End Sub

    Private Sub bgwSendMessage_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwSendMessage.ProgressChanged
        'Display an error message:
        Message.AddWarning("Send Message error: " & e.UserState.ToString & vbCrLf) 'Show the bgwSendMessage message 
    End Sub

    Private Sub bgwSendMessageAlt_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwSendMessageAlt.DoWork
        'Alternative SendMessage background worker - used to send a message while instructions are being processed. 
        'Send a message on a separate thread
        Try
            If IsNothing(client) Then
                bgwSendMessageAlt.ReportProgress(1, "No Connection available. Message not sent!")
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    bgwSendMessageAlt.ReportProgress(1, "Connection state is faulted. Message not sent!")
                Else
                    Dim SendMessageParamsAlt As clsSendMessageParams = e.Argument
                    client.SendMessage(SendMessageParamsAlt.ProjectNetworkName, SendMessageParamsAlt.ConnectionName, SendMessageParamsAlt.Message)
                End If
            End If
        Catch ex As Exception
            bgwSendMessageAlt.ReportProgress(1, ex.Message)
        End Try
    End Sub

    Private Sub bgwSendMessageAlt_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwSendMessageAlt.ProgressChanged
        'Display an error message:
        Message.AddWarning("Send Message error: " & e.UserState.ToString & vbCrLf) 'Show the bgwSendMessageAlt message 
    End Sub

    Private Sub bgwRunInstruction_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwRunInstruction.DoWork
        'Run a single instruction.
        Try
            Dim Instruction As clsInstructionParams = e.Argument
            XMsg_Instruction(Instruction.Info, Instruction.Locn)
        Catch ex As Exception
            bgwRunInstruction.ReportProgress(1, ex.Message)
        End Try
    End Sub

    Private Sub bgwRunInstruction_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwRunInstruction.ProgressChanged
        'Display an error message:
        Message.AddWarning("Run Instruction error: " & e.UserState.ToString & vbCrLf) 'Show the bgwRunInstruction message 
    End Sub


    Private Sub btnShowProjectInfo_Click(sender As Object, e As EventArgs) Handles btnShowProjectInfo.Click
        'Show the current Project information:
        Message.Add("--------------------------------------------------------------------------------------" & vbCrLf)
        Message.Add("Project ------------------------ " & vbCrLf)
        Message.Add("   Name: " & Project.Name & vbCrLf)
        Message.Add("   Type: " & Project.Type.ToString & vbCrLf)
        Message.Add("   Description: " & Project.Description & vbCrLf)
        Message.Add("   Creation Date: " & Project.CreationDate & vbCrLf)
        Message.Add("   ID: " & Project.ID & vbCrLf)
        Message.Add("   Relative Path: " & Project.RelativePath & vbCrLf)
        Message.Add("   Path: " & Project.Path & vbCrLf & vbCrLf)

        Message.Add("Parent Project ----------------- " & vbCrLf)
        Message.Add("   Name: " & Project.ParentProjectName & vbCrLf)
        Message.Add("   Path: " & Project.ParentProjectPath & vbCrLf)

        Message.Add("Application -------------------- " & vbCrLf)
        Message.Add("   Name: " & Project.Application.Name & vbCrLf)
        Message.Add("   Description: " & Project.Application.Description & vbCrLf)
        Message.Add("   Path: " & Project.ApplicationDir & vbCrLf)

        Message.Add("Settings ----------------------- " & vbCrLf)
        Message.Add("   Settings Relative Location Type: " & Project.SettingsRelLocn.Type.ToString & vbCrLf)
        Message.Add("   Settings Relative Location Path: " & Project.SettingsRelLocn.Path & vbCrLf)
        Message.Add("   Settings Location Type: " & Project.SettingsLocn.Type.ToString & vbCrLf)
        Message.Add("   Settings Location Path: " & Project.SettingsLocn.Path & vbCrLf)

        Message.Add("Data --------------------------- " & vbCrLf)
        Message.Add("   Data Relative Location Type: " & Project.DataRelLocn.Type.ToString & vbCrLf)
        Message.Add("   Data Relative Location Path: " & Project.DataRelLocn.Path & vbCrLf)
        Message.Add("   Data Location Type: " & Project.DataLocn.Type.ToString & vbCrLf)
        Message.Add("   Data Location Path: " & Project.DataLocn.Path & vbCrLf)

        Message.Add("System ------------------------- " & vbCrLf)
        Message.Add("   System Relative Location Type: " & Project.SystemRelLocn.Type.ToString & vbCrLf)
        Message.Add("   System Relative Location Path: " & Project.SystemRelLocn.Path & vbCrLf)
        Message.Add("   System Location Type: " & Project.SystemLocn.Type.ToString & vbCrLf)
        Message.Add("   System Location Path: " & Project.SystemLocn.Path & vbCrLf)
        Message.Add("======================================================================================" & vbCrLf)

    End Sub

    Private Sub Message_ShowXMessagesChanged(Show As Boolean) Handles Message.ShowXMessagesChanged
        ShowXMessages = Show
    End Sub

    Private Sub Message_ShowSysMessagesChanged(Show As Boolean) Handles Message.ShowSysMessagesChanged
        ShowSysMessages = Show
    End Sub

    Private Sub Project_NewProjectCreated(ProjectPath As String) Handles Project.NewProjectCreated
        SendProjectInfo(ProjectPath) 'Send the path of the new project to the Network application. The new project will be added to the list of projects.
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    'Private Sub btnGetGeoCRSList_Click(sender As Object, e As EventArgs) Handles btnGetGeoCRSList.Click
    '    'Send instructions to the Coordinates application to get a list of Geographic coordinate reference systems.

    '    cmbCrsList.Items.Clear()

    '    'Create the xml instructions:
    '    Dim decl As New XDeclaration("1.0", "utf-8", "yes")
    '    Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
    '    Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

    '    Dim clientProNetName As New XElement("ClientProNetName", ProNetName) 'The name of the Clent Project Network.
    '    xmessage.Add(clientProNetName)

    '    Dim clientConnName As New XElement("ClientConnectionName", ConnectionName) 'This tells the coordinate server the connection name of the client making the request.
    '    xmessage.Add(clientConnName)

    '    'Specifications for the Geographic CRS list.:
    '    Dim operation As New XElement("GetGeographicCRSList")

    '    If rbGetAll.Checked Then 'Get all the Geographic CRSs
    '        Dim SelectMethod As New XElement("SelectMethod", "All")
    '        operation.Add(SelectMethod)
    '    Else 'Get Geographic CRSs within specified boundaries.
    '        Try
    '            Dim NorthLatBound As Single = txtNorthLatBound.Text
    '            Dim SouthLatBound As Single = txtSouthLatBound.Text
    '            Dim WestLongBound As Single = txtWestLongBound.Text
    '            Dim EastLongBound As Single = txtEastLongBound.Text

    '            Dim NorthLatitude As New XElement("NorthLatitude", NorthLatBound)
    '            operation.Add(NorthLatitude)
    '            Dim SouthLatitude As New XElement("SouthLatitude", SouthLatBound)
    '            operation.Add(SouthLatitude)
    '            Dim WestLongitude As New XElement("WestLongitude", WestLongBound)
    '            operation.Add(WestLongitude)
    '            Dim EastLongitude As New XElement("EastLongitude", EastLongBound)
    '            operation.Add(EastLongitude)
    '            If rbExtendingInto.Checked Then
    '                Dim SelectMethod As New XElement("SelectMethod", "ExtendingInto")
    '                operation.Add(SelectMethod)
    '            ElseIf rbInside.Checked Then
    '                Dim SelectMethod As New XElement("SelectMethod", "Inside")
    '                operation.Add(SelectMethod)
    '            Else
    '                Message.SetWarningStyle()
    '                Message.Add("Geographic CRS selection error. No selection criteria specified." & vbCrLf)
    '                Message.SetNormalStyle()
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            Message.AddWarning(ex.Message & vbCrLf)
    '        End Try

    '    End If

    '    If chkGeographic2D.Checked Then
    '        Dim GetGeographic2D As New XElement("GetGeographic2D", "true")
    '        operation.Add(GetGeographic2D)
    '    Else
    '        Dim GetGeographic2D As New XElement("GetGeographic2D", "false")
    '        operation.Add(GetGeographic2D)
    '    End If

    '    If chkGeographic3D.Checked Then
    '        Dim GetGeographic3D As New XElement("GetGeographic3D", "true")
    '        operation.Add(GetGeographic3D)
    '    Else
    '        Dim GetGeographic3D As New XElement("GetGeographic3D", "false")
    '        operation.Add(GetGeographic3D)
    '    End If

    '    If chkGeographic2D.Checked Then
    '    Else
    '        If chkGeographic3D.Checked Then
    '        Else
    '            'Neither Geographic 2D or Geographic 3D checked.
    '            Message.SetWarningStyle()
    '            Message.Add("Neither Geographic 2D or Geographic 3D checked." & vbCrLf)
    '            Message.SetNormalStyle()
    '            Exit Sub
    '        End If
    '    End If

    '    Dim command As New XElement("Command", "OK")
    '    operation.Add(command)

    '    xmessage.Add(operation)
    '    doc.Add(xmessage)

    '    'Send the instructions to the Coordinates 2 application:
    '    If IsNothing(client) Then
    '        Message.Add("No client connection available!" & vbCrLf)
    '    Else
    '        If client.State = ServiceModel.CommunicationState.Faulted Then
    '            Message.Add("client state is faulted. Message not sent!" & vbCrLf)
    '        Else
    '            cmbCrsList.Items.Clear()
    '            client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
    '            Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
    '            Message.XAddXml(doc.ToString)
    '            Message.XAddText(vbCrLf, "Normal") 'Add extra line
    '        End If
    '    End If
    'End Sub

    'Private Sub btnGetProjCRSList_Click(sender As Object, e As EventArgs) Handles btnGetProjCRSList.Click
    '    'Send instructions to the Coordinates application to get a list of Projected coordinate reference systems.

    '    cmbCrsList.Items.Clear()

    '    'Create the xml instructions:
    '    Dim decl As New XDeclaration("1.0", "utf-8", "yes")
    '    Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
    '    Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

    '    Dim clientProNetName As New XElement("ClientProNetName", ProNetName) 'The name of the Clent Project Network.
    '    xmessage.Add(clientProNetName)

    '    Dim clientConnName As New XElement("ClientConnectionName", ConnectionName) 'This tells the coordinate server the connection name of the client making the request.
    '    xmessage.Add(clientConnName)

    '    'Specifications for the Projected CRS list.:
    '    Dim operation As New XElement("GetProjectedCRSList")

    '    If rbGetAll.Checked Then 'Get all the Projected CRSs
    '        Dim SelectMethod As New XElement("SelectMethod", "All")
    '        operation.Add(SelectMethod)
    '    Else 'Get Projected CRSs within specified boundaries.
    '        Try
    '            Dim NorthLatBound As Single = txtNorthLatBound.Text
    '            Dim SouthLatBound As Single = txtSouthLatBound.Text
    '            Dim WestLongBound As Single = txtWestLongBound.Text
    '            Dim EastLongBound As Single = txtEastLongBound.Text

    '            Dim NorthLatitude As New XElement("NorthLatitude", NorthLatBound)
    '            operation.Add(NorthLatitude)
    '            Dim SouthLatitude As New XElement("SouthLatitude", SouthLatBound)
    '            operation.Add(SouthLatitude)
    '            Dim WestLongitude As New XElement("WestLongitude", WestLongBound)
    '            operation.Add(WestLongitude)
    '            Dim EastLongitude As New XElement("EastLongitude", EastLongBound)
    '            operation.Add(EastLongitude)
    '            If rbExtendingInto.Checked Then
    '                Dim SelectMethod As New XElement("SelectMethod", "ExtendingInto")
    '                operation.Add(SelectMethod)
    '            ElseIf rbInside.Checked Then
    '                Dim SelectMethod As New XElement("SelectMethod", "Inside")
    '                operation.Add(SelectMethod)
    '            Else
    '                Message.SetWarningStyle()
    '                Message.Add("Projected CRS selection error. No selection criteria specified." & vbCrLf)
    '                Message.SetNormalStyle()
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            Message.AddWarning(ex.Message & vbCrLf)
    '        End Try

    '    End If

    '    'If chkGeographic2D.Checked Then
    '    '    Dim GetGeographic2D As New XElement("GetGeographic2D", "true")
    '    '    operation.Add(GetGeographic2D)
    '    'Else
    '    '    Dim GetGeographic2D As New XElement("GetGeographic2D", "false")
    '    '    operation.Add(GetGeographic2D)
    '    'End If

    '    'If chkGeographic3D.Checked Then
    '    '    Dim GetGeographic3D As New XElement("GetGeographic3D", "true")
    '    '    operation.Add(GetGeographic3D)
    '    'Else
    '    '    Dim GetGeographic3D As New XElement("GetGeographic3D", "false")
    '    '    operation.Add(GetGeographic3D)
    '    'End If

    '    'If chkGeographic2D.Checked Then
    '    'Else
    '    '    If chkGeographic3D.Checked Then
    '    '    Else
    '    '        'Neither Geographic 2D or Geographic 3D checked.
    '    '        Message.SetWarningStyle()
    '    '        Message.Add("Neither Geographic 2D or Geographic 3D checked." & vbCrLf)
    '    '        Message.SetNormalStyle()
    '    '        Exit Sub
    '    '    End If
    '    'End If

    '    Dim command As New XElement("Command", "OK")
    '    operation.Add(command)

    '    xmessage.Add(operation)
    '    doc.Add(xmessage)

    '    'Send the instructions to the Coordinates 2 application:
    '    If IsNothing(client) Then
    '        Message.Add("No client connection available!" & vbCrLf)
    '    Else
    '        If client.State = ServiceModel.CommunicationState.Faulted Then
    '            Message.Add("client state is faulted. Message not sent!" & vbCrLf)
    '        Else
    '            cmbCrsList.Items.Clear()
    '            client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
    '            Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
    '            Message.XAddXml(doc.ToString)
    '            Message.XAddText(vbCrLf, "Normal") 'Add extra line
    '        End If
    '    End If
    'End Sub

    Private Sub btnStartCoordsServer_Click(sender As Object, e As EventArgs) Handles btnOpenCoordsServer.Click
        'Start the ADVL_Coordinates_2 coordinates server.

        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                'cmbCrsList.Items.Clear()
                'client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                'Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                'Message.XAddXml(doc.ToString)
                'Message.XAddText(vbCrLf, "Normal") 'Add extra line
                client.StartProjectWithName("Default", "", "ADVL_Coordinates_2", "ADVL_Coordinates_2")
            End If
        End If


    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        'Select all CRS kinds.
        chkProjected.Checked = True
        chkGeographic2D.Checked = True
        chkGeographic3D.Checked = True
        chkCompound.Checked = True
        chkDerived.Checked = True
        chkEngineering.Checked = True
        chkGeocentric.Checked = True
        chkVertical.Checked = True
    End Sub

    Private Sub btnNone_Click(sender As Object, e As EventArgs) Handles btnNone.Click
        'DeSelect all CRS kinds.
        chkProjected.Checked = False
        chkGeographic2D.Checked = False
        chkGeographic3D.Checked = False
        chkCompound.Checked = False
        chkDerived.Checked = False
        chkEngineering.Checked = False
        chkGeocentric.Checked = False
        chkVertical.Checked = False
    End Sub

    Private Sub btnGetCrsList_Click(sender As Object, e As EventArgs) Handles btnGetCrsList.Click
        'Send instructions to the Coordinates 2 application to get a list of Coordinate Reference System names.

        cmbCrsList.Items.Clear()
        CrsList.Clear()

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        Dim clientProNetName As New XElement("ClientProNetName", ProNetName) 'The name of the Clent Project Network.
        xmessage.Add(clientProNetName)

        Dim clientConnName As New XElement("ClientConnectionName", ConnectionName) 'This tells the coordinate server the connection name of the client making the request.
        xmessage.Add(clientConnName)

        'Specifications for the CRS list.:
        Dim operation As New XElement("GetCRSList")

        If rbGetAll.Checked Then
            Dim SelectMethod As New XElement("SelectMethod", "All")
            operation.Add(SelectMethod)
        ElseIf rbExtendingInto.Checked Then
            Dim SelectMethod As New XElement("SelectMethod", "ExtendingIntoArea")
            operation.Add(SelectMethod)
            Dim NorthLatitude As New XElement("NorthLatitude", txtNorthLatBound.Text.Trim)
            operation.Add(NorthLatitude)
            Dim SouthLatitude As New XElement("SouthLatitude", txtSouthLatBound.Text.Trim)
            operation.Add(SouthLatitude)
            Dim WestLongitude As New XElement("WestLongitude", txtWestLongBound.Text.Trim)
            operation.Add(WestLongitude)
            Dim EastLongitude As New XElement("EastLongitude", txtEastLongBound.Text.Trim)
            operation.Add(EastLongitude)
        ElseIf rbInside.Checked Then
            Dim SelectMethod As New XElement("SelectMethod", "InsideArea")
            operation.Add(SelectMethod)
            Dim NorthLatitude As New XElement("NorthLatitude", txtNorthLatBound.Text.Trim)
            operation.Add(NorthLatitude)
            Dim SouthLatitude As New XElement("SouthLatitude", txtSouthLatBound.Text.Trim)
            operation.Add(SouthLatitude)
            Dim WestLongitude As New XElement("WestLongitude", txtWestLongBound.Text.Trim)
            operation.Add(WestLongitude)
            Dim EastLongitude As New XElement("EastLongitude", txtEastLongBound.Text.Trim)
            operation.Add(EastLongitude)
        ElseIf rbContainingPoint.Checked Then
            Dim SelectMethod As New XElement("SelectMethod", "ContainingPoint")
            operation.Add(SelectMethod)
            Dim ReferenceLongitude As New XElement("ReferenceLongitude", txtRefLong.Text.Trim)
            operation.Add(ReferenceLongitude)
            Dim ReferenceLatitude As New XElement("ReferenceLatitude", txtRefLat.Text.Trim)
            operation.Add(ReferenceLatitude)
        End If

        If chkCrsNameContains.Checked And txtCrsNameContains.Text.Trim <> "" Then
            Dim UseCrsNameContains As New XElement("UseCrsNameContains", "true")
            operation.Add(UseCrsNameContains)
            Dim CrsNameContains As New XElement("CrsNameContains", txtCrsNameContains.Text.Trim)
            operation.Add(CrsNameContains)
        Else
            Dim UseCrsNameContains As New XElement("UseCrsNameContains", "false")
            operation.Add(UseCrsNameContains)
        End If

        If chkProjected.Checked Then
            Dim GetProjected As New XElement("GetProjected", "true")
            operation.Add(GetProjected)
        Else
            Dim GetProjected As New XElement("GetProjected", "false")
            operation.Add(GetProjected)
        End If

        If chkGeographic2D.Checked Then
            Dim GetGeographic2D As New XElement("GetGeographic2D", "true")
            operation.Add(GetGeographic2D)
        Else
            Dim GetGeographic2D As New XElement("GetGeographic2D", "false")
            operation.Add(GetGeographic2D)
        End If

        If chkGeographic3D.Checked Then
            Dim GetGeographic3D As New XElement("GetGeographic3D", "true")
            operation.Add(GetGeographic3D)
        Else
            Dim GetGeographic3D As New XElement("GetGeographic3D", "false")
            operation.Add(GetGeographic3D)
        End If

        If chkCompound.Checked Then
            Dim GetCompound As New XElement("GetCompound", "true")
            operation.Add(GetCompound)
        Else
            Dim GetCompound As New XElement("GetCompound", "false")
            operation.Add(GetCompound)
        End If

        If chkDerived.Checked Then
            Dim GetDerived As New XElement("GetDerived", "true")
            operation.Add(GetDerived)
        Else
            Dim GetDerived As New XElement("GetDerived", "false")
            operation.Add(GetDerived)
        End If

        If chkEngineering.Checked Then
            Dim GetEngineering As New XElement("GetEngineering", "true")
            operation.Add(GetEngineering)
        Else
            Dim GetEngineering As New XElement("GetEngineering", "false")
            operation.Add(GetEngineering)
        End If

        If chkGeocentric.Checked Then
            Dim GetGeocentric As New XElement("GetGeocentric", "true")
            operation.Add(GetGeocentric)
        Else
            Dim GetGeocentric As New XElement("GetGeocentric", "false")
            operation.Add(GetGeocentric)
        End If

        If chkVertical.Checked Then
            Dim GetVertical As New XElement("GetVertical", "true")
            operation.Add(GetVertical)
        Else
            Dim GetVertical As New XElement("GetVertical", "false")
            operation.Add(GetVertical)
        End If

        Dim command As New XElement("Command", "OK")
        operation.Add(command)

        xmessage.Add(operation)
        doc.Add(xmessage)

        'Send the instructions to the Coordinates 2 application:
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                'cmbCrsList.Items.Clear()
                client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line
            End If
        End If
    End Sub

    Private Sub cmbCrsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCrsList.SelectedIndexChanged

        Dim Index As Integer = cmbCrsList.SelectedIndex
        If Index >= 0 Then
            txtCrsCode.Text = CrsList(Index).Code
            txtCrsKind.Text = CrsList(Index).Kind
        Else
            txtCrsCode.Text = ""
            txtCrsKind.Text = ""
        End If

    End Sub

    Private Sub btnGetDatumTransList_Click(sender As Object, e As EventArgs) Handles btnGetDatumTransList.Click
        'Send instructions to the Coordinates 2 application to get the datum transformation settings nad options.

        'The Datum Transformation grid views contain the following columns:
        '  Name | Code | Accuracy | Reversible | Apply Reverse
        dgvDirectDTOps.Rows.Clear()
        dgvInputToWgs84DTOps.Rows.Clear()
        dgvWgs84ToOutputDTOps.Rows.Clear()

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        Dim clientProNetName As New XElement("ClientProNetName", ProNetName) 'The name of the Clent Project Network.
        xmessage.Add(clientProNetName)

        Dim clientConnName As New XElement("ClientConnectionName", ConnectionName) 'This tells the coordinate server the connection name of the client making the request.
        xmessage.Add(clientConnName)

        'Instructions to get the Datum Transformation Information:
        Dim operation As New XElement("GetDatumTransInfo")

        Dim GetDirect7ParamDatumTransList As New XElement("Command", "GetDirect7ParamDatumTransList")
        operation.Add(GetDirect7ParamDatumTransList)

        Dim GetInputToWgs84_7ParamDatumTransList As New XElement("Command", "GetInputToWgs84_7ParamDatumTransList")
        operation.Add(GetInputToWgs84_7ParamDatumTransList)

        Dim GetWgs84ToOutput_7ParamDatumTransList As New XElement("Command", "GetWgs84ToOutput_7ParamDatumTransList")
        operation.Add(GetWgs84ToOutput_7ParamDatumTransList)


        'Dim OnCompletion As New XElement("OnCompletion", "AutoResizeDirectDatumTransList")
        'operation.Add(OnCompletion)

        'Dim GetInputToWgs84_7ParamDatumTransList As New XElement("Command", "GetInputToWgs84_7ParamDatumTransList")
        'operation.Add(GetInputToWgs84_7ParamDatumTransList)

        'Dim GetWgs84ToOutput_7ParamDatumTransList As New XElement("Command", "GetWgs84ToOutput_7ParamDatumTransList")
        'operation.Add(GetWgs84ToOutput_7ParamDatumTransList)

        xmessage.Add(operation)

        'Dim OnCompletion As New XElement("OnCompletion", "AutoResizeDatumTransLists") 'This instruction is returned to the client - it will then resize the datum transformation lists
        Dim OnCompletion As New XElement("OnCompletion", "DatumListsUpdated") 'This instruction is returned to the client - it will then resize the datum transformation lists
        xmessage.Add(OnCompletion)

        doc.Add(xmessage)

        'Send the instructions to the Coordinates 2 application:
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                'cmbCrsList.Items.Clear()
                client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line
            End If
        End If



    End Sub

    Private Sub btnSetInputCrs_Click(sender As Object, e As EventArgs) Handles btnSetInputCrs.Click

        If cmbCrsList.SelectedIndex <> -1 Then
            txtInputCrsName.Text = cmbCrsList.SelectedItem.ToString
            txtInputCrsCode.Text = txtCrsCode.Text
            txtInputCrsKind.Text = txtCrsKind.Text

            If txtInputCrsCode.Text = txtOutputCrsCode.Text Then
                rbDtNotRequired.Enabled = True
                rbDtNotRequired.Checked = True
            Else
                rbDtNotRequired.Enabled = False
                rbDtNotRequired.Checked = False
            End If

            'Create the xml instructions:
            Dim decl As New XDeclaration("1.0", "utf-8", "yes")
            Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
            Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

            Dim SetInputCrsCode As New XElement("SetInputCrsCode", txtCrsCode.Text) 'Set the Input Coordinate Reference System code.
            xmessage.Add(SetInputCrsCode)

            doc.Add(xmessage)

            'Send the instructions to the Coordinates 2 application:
            If IsNothing(client) Then
                Message.Add("No client connection available!" & vbCrLf)
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("client state is faulted. Message not sent!" & vbCrLf)
                Else
                    'cmbCrsList.Items.Clear()
                    client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                    Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(doc.ToString)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                End If
            End If
        End If
    End Sub

    Private Sub btnSetOutputCrs_Click(sender As Object, e As EventArgs) Handles btnSetOutputCrs.Click

        If cmbCrsList.SelectedIndex <> -1 Then
            txtOutputCrsName.Text = cmbCrsList.SelectedItem.ToString
            txtOutputCrsCode.Text = txtCrsCode.Text
            txtOutputCrsKind.Text = txtCrsKind.Text

            If txtInputCrsCode.Text = txtOutputCrsCode.Text Then
                rbDtNotRequired.Enabled = True
                rbDtNotRequired.Checked = True
            Else
                rbDtNotRequired.Enabled = False
                rbDtNotRequired.Checked = False
            End If

            'Create the xml instructions:
            Dim decl As New XDeclaration("1.0", "utf-8", "yes")
            Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
            Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

            Dim SetOutputCrsCode As New XElement("SetOutputCrsCode", txtCrsCode.Text) 'Set the Input Coordinate Reference System code.
            xmessage.Add(SetOutputCrsCode)

            doc.Add(xmessage)

            'Send the instructions to the Coordinates 2 application:
            If IsNothing(client) Then
                Message.Add("No client connection available!" & vbCrLf)
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("client state is faulted. Message not sent!" & vbCrLf)
                Else
                    'cmbCrsList.Items.Clear()
                    client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                    Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(doc.ToString)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                End If
            End If
        End If
    End Sub

    Private Sub AutoSelectDatumTrans()
        'Select a sutable datum transformation operation

        ''Create the xml instructions:
        'Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        'Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        'Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        If txtInputCrsCode.Text = txtOutputCrsCode.Text Then 'Datum Transformation is not required
            rbDtNotRequired.Enabled = True
            rbDtNotRequired.Checked = True
            Dim SetDatumTransType As New XElement("SetDatumTransType", "None") 'Set the Datum Transformation type to None.
            xmessage.Add(SetDatumTransType)
        ElseIf dgvDirectDTOps.RowCount > 0 Then
            rbDtNotRequired.Enabled = False
            rbDirectDatumTrans.Checked = True
            TabControl3.SelectedIndex = 0 'Select the Direct tab
            'Find the Direct datum trasformation operation with the smallest error:
            Dim DirectDatumTransError As Single = Single.MaxValue
            Dim BestDirectDatumTransName As String = ""
            Dim BestDirectDatumTransCode As Integer
            Dim BestDirectDatumTransIndex As Integer
            Dim BestDirectDatumTransApplyRev As Boolean
            For Each Row As DataGridViewRow In dgvDirectDTOps.Rows '| Name | Code | Accuracy | Reversible | Apply Reverse |
                If Row.Cells(2).Value < DirectDatumTransError Then
                    DirectDatumTransError = Row.Cells(2).Value
                    BestDirectDatumTransName = Row.Cells(0).Value
                    BestDirectDatumTransCode = Row.Cells(1).Value
                    BestDirectDatumTransApplyRev = Row.Cells(4).Value
                    BestDirectDatumTransIndex = Row.Index
                End If
            Next
            dgvDirectDTOps.ClearSelection()
            dgvDirectDTOps.Rows(BestDirectDatumTransIndex).Selected = True
            txtDatumTransType.Text = "Direct"
            'lblDirectDatumTransName.Text = "Direct operation name:"
            txtDirectDatumTransOpName.Text = BestDirectDatumTransName
            txtDirectDatumTransOpCode.Text = BestDirectDatumTransCode
            txtDirectDatumTransOpApplyRev.Text = BestDirectDatumTransApplyRev.ToString
            lblInputToWgs84DatumTransName.Enabled = False
            txtInputToWgs84DatumTransOpName.Enabled = False
            'txtInputToWgs84DatumTransOpName.Text = ""
            txtInputToWgs84DatumTransOpCode.Enabled = False
            'txtInputToWgs84DatumTransOpCode.Text = ""
            txtInputToWgs84DatumTransOpApplyRev.Enabled = False
            'txtInputToWgs84DatumTransOpApplyRev.Text = ""
            txtWgs84ToOutputDatumTransOpName.Enabled = False
            txtWgs84ToOutputDatumTransOpCode.Enabled = False
            txtWgs84ToOutputDatumTransOpApplyRev.Enabled = False
            txtAccuracy.Text = DirectDatumTransError

            'Dim SetDatumTransType As New XElement("SetDatumTransType", "Direct") 'Set the Datum Transformation type to Direct.
            'xmessage.Add(SetDatumTransType)
            'Dim SetDirectDatumTransCode As New XElement("SetDirectDatumTransCode", BestDirectDatumTransCode)
            'xmessage.Add(SetDirectDatumTransCode)
            'Dim SetDirectDatumTransApplyRev As New XElement("SetDirectDatumTransApplyRev", BestDirectDatumTransApplyRev)
            'xmessage.Add(SetDirectDatumTransApplyRev)

        ElseIf dgvInputToWgs84DTOps.RowCount > 0 And dgvWgs84ToOutputDTOps.RowCount > 0 Then
            rbDtNotRequired.Enabled = False
            rbDatumTransViaWgs84.Checked = True
            TabControl3.SelectedIndex = 1 'Select the Via WGS 84 tab
            'Find the Via WGS 84 datum trasformation operations with the smallest error:
            Dim InputToWgs84DatumTransError As Single = Single.MaxValue
            Dim BestInputToWgs84DatumTransName As String = ""
            Dim BestInputToWgs84DatumTransCode As Integer
            Dim BestInputToWgs84DatumTransIndex As Integer
            Dim BestInputToWgs84DatumTransApplyRev As Boolean
            For Each Row As DataGridViewRow In dgvInputToWgs84DTOps.Rows '| Name | Code | Accuracy | Reversible | Apply Reverse |
                If Row.Cells(2).Value < InputToWgs84DatumTransError Then
                    InputToWgs84DatumTransError = Row.Cells(2).Value
                    BestInputToWgs84DatumTransName = Row.Cells(0).Value
                    BestInputToWgs84DatumTransCode = Row.Cells(1).Value
                    BestInputToWgs84DatumTransApplyRev = Row.Cells(4).Value
                    BestInputToWgs84DatumTransIndex = Row.Index
                End If
            Next
            dgvInputToWgs84DTOps.ClearSelection()
            dgvInputToWgs84DTOps.Rows(BestInputToWgs84DatumTransIndex).Selected = True
            Dim Wgs84ToOutputDatumTransError As Single = Single.MaxValue
            Dim BestWgs84ToOutputDatumTransName As String = ""
            Dim BestWgs84ToOutputDatumTransCode As Integer
            Dim BestWgs84ToOutputDatumTransIndex As Integer
            Dim BestWgs84ToOutputDatumTransApplyRev As Boolean
            For Each Row As DataGridViewRow In dgvWgs84ToOutputDTOps.Rows '| Name | Code | Accuracy | Reversible | Apply Reverse |
                If Row.Cells(2).Value < InputToWgs84DatumTransError Then
                    Wgs84ToOutputDatumTransError = Row.Cells(2).Value
                    BestWgs84ToOutputDatumTransName = Row.Cells(0).Value
                    BestWgs84ToOutputDatumTransCode = Row.Cells(1).Value
                    BestWgs84ToOutputDatumTransApplyRev = Row.Cells(4).Value
                    BestWgs84ToOutputDatumTransIndex = Row.Index
                End If
            Next
            dgvWgs84ToOutputDTOps.ClearSelection()
            dgvWgs84ToOutputDTOps.Rows(BestWgs84ToOutputDatumTransIndex).Selected = True

            txtDatumTransType.Text = "ViaWGS84"
            'lblDirectDatumTransName.Text = "Input to WGS 84 operation name:"
            'txtDirectDatumTransOpName.Text = BestInputToWgs84DatumTransName
            'txtDirectDatumTransOpCode.Text = BestInputToWgs84DatumTransCode
            'txtDirectDatumTransOpApplyRev.Text = BestInputToWgs84DatumTransApplyRev.ToString

            txtInputToWgs84DatumTransOpName.Enabled = True
            txtInputToWgs84DatumTransOpName.Text = BestInputToWgs84DatumTransName
            txtInputToWgs84DatumTransOpCode.Enabled = True
            txtInputToWgs84DatumTransOpCode.Text = BestInputToWgs84DatumTransCode
            txtInputToWgs84DatumTransOpApplyRev.Enabled = True
            txtInputToWgs84DatumTransOpApplyRev.Text = BestInputToWgs84DatumTransApplyRev.ToString

            txtWgs84ToOutputDatumTransOpName.Enabled = True
            txtWgs84ToOutputDatumTransOpName.Text = BestWgs84ToOutputDatumTransName
            txtWgs84ToOutputDatumTransOpCode.Enabled = True
            txtWgs84ToOutputDatumTransOpCode.Text = BestWgs84ToOutputDatumTransCode
            txtWgs84ToOutputDatumTransOpApplyRev.Enabled = True
            txtWgs84ToOutputDatumTransOpApplyRev.Text = BestWgs84ToOutputDatumTransApplyRev.ToString

            txtAccuracy.Text = InputToWgs84DatumTransError + Wgs84ToOutputDatumTransError

            'Dim SetDatumTransType As New XElement("SetDatumTransType", "ViaWgs84") 'Set the Datum Transformation type to Direct.
            'xmessage.Add(SetDatumTransType)
            'Dim SetInputToWgs84DatumTransCode As New XElement("SetInputToWgs84DatumTransCode", BestInputToWgs84DatumTransCode)
            'xmessage.Add(SetInputToWgs84DatumTransCode)
            'Dim SetInputToWgs84DatumTransApplyRev As New XElement("SetInputToWgs84DatumTransApplyRev", BestInputToWgs84DatumTransApplyRev)
            'xmessage.Add(SetInputToWgs84DatumTransApplyRev)
            'Dim SetWgs84ToOutputDatumTransCode As New XElement("SetWgs84ToOutputDatumTransCode", BestWgs84ToOutputDatumTransCode)
            'xmessage.Add(SetWgs84ToOutputDatumTransCode)
            'Dim SetoWgs84ToOutputDatumTransApplyRev As New XElement("SetoWgs84ToOutputDatumTransApplyRev", BestWgs84ToOutputDatumTransApplyRev)
            'xmessage.Add(SetoWgs84ToOutputDatumTransApplyRev)
        End If

        'doc.Add(xmessage)

        ''Send the instructions to the Coordinates 2 application:
        'If IsNothing(client) Then
        '    Message.Add("No client connection available!" & vbCrLf)
        'Else
        '    If client.State = ServiceModel.CommunicationState.Faulted Then
        '        Message.Add("client state is faulted. Message not sent!" & vbCrLf)
        '    Else
        '        client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
        '        Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
        '        Message.XAddXml(doc.ToString)
        '        Message.XAddText(vbCrLf, "Normal") 'Add extra line
        '    End If
        'End If
    End Sub

    Private Sub btnAutoSelectDatumTrans_Click(sender As Object, e As EventArgs) Handles btnAutoSelectDatumTrans.Click
        'Automatically select the best Datum Transformation option
        AutoSelectDatumTrans()
    End Sub

    Private Sub rbEnterInputEastNorth_CheckedChanged(sender As Object, e As EventArgs) Handles rbEnterInputEastNorth.CheckedChanged
        If rbEnterInputEastNorth.Checked Then UpdateDatumTransTableInput()
    End Sub

    Private Sub rbEnterInputLongLat_CheckedChanged(sender As Object, e As EventArgs) Handles rbEnterInputLongLat.CheckedChanged
        If rbEnterInputLongLat.Checked Then UpdateDatumTransTableInput()
    End Sub

    Private Sub rbEnterInputXYZ_CheckedChanged(sender As Object, e As EventArgs) Handles rbEnterInputXYZ.CheckedChanged
        If rbEnterInputXYZ.Checked Then UpdateDatumTransTableInput()
    End Sub

    'Private Sub UpdateDatumTransTable()
    Private Sub UpdateConversionTable()

        If chkShowPointNumber.Checked Then dgvConversion.Columns(0).Visible = True Else dgvConversion.Columns(0).Visible = False
        If chkShowPointName.Checked Then dgvConversion.Columns(1).Visible = True Else dgvConversion.Columns(1).Visible = False
        If chkShowPointDescription.Checked Then dgvConversion.Columns(2).Visible = True Else dgvConversion.Columns(2).Visible = False
        If chkShowInputEastNorth.Checked Then
            dgvConversion.Columns(3).Visible = True
            dgvConversion.Columns(4).Visible = True
        Else
            dgvConversion.Columns(3).Visible = False
            dgvConversion.Columns(4).Visible = False
        End If
        If chkShowInputLongLat.Checked Then
            dgvConversion.Columns(5).Visible = True
            dgvConversion.Columns(6).Visible = True
            dgvConversion.Columns(7).Visible = True
        Else
            dgvConversion.Columns(5).Visible = False
            dgvConversion.Columns(6).Visible = False
            dgvConversion.Columns(7).Visible = False
        End If
        If chkShowInputXYZ.Checked Then
            dgvConversion.Columns(8).Visible = True
            dgvConversion.Columns(9).Visible = True
            dgvConversion.Columns(10).Visible = True
        Else
            dgvConversion.Columns(8).Visible = False
            dgvConversion.Columns(9).Visible = False
            dgvConversion.Columns(10).Visible = False
        End If
        If chkShowWgs84XYZ.Checked Then
            dgvConversion.Columns(11).Visible = True
            dgvConversion.Columns(12).Visible = True
            dgvConversion.Columns(13).Visible = True
        Else
            dgvConversion.Columns(11).Visible = False
            dgvConversion.Columns(12).Visible = False
            dgvConversion.Columns(13).Visible = False
        End If
        If chkShowOutputXYZ.Checked Then
            dgvConversion.Columns(14).Visible = True
            dgvConversion.Columns(15).Visible = True
            dgvConversion.Columns(16).Visible = True
        Else
            dgvConversion.Columns(14).Visible = False
            dgvConversion.Columns(15).Visible = False
            dgvConversion.Columns(16).Visible = False
        End If
        If chkShowOutputLongLat.Checked Then
            dgvConversion.Columns(17).Visible = True
            dgvConversion.Columns(18).Visible = True
            dgvConversion.Columns(19).Visible = True
        Else
            dgvConversion.Columns(17).Visible = False
            dgvConversion.Columns(18).Visible = False
            dgvConversion.Columns(19).Visible = False
        End If
        If chkShowOutputEastNorth.Checked Then
            dgvConversion.Columns(20).Visible = True
            dgvConversion.Columns(21).Visible = True
        Else
            dgvConversion.Columns(20).Visible = False
            dgvConversion.Columns(21).Visible = False
        End If
    End Sub

    Private Sub UpdateDatumTransTableInput()
        'Update the Datum Transformation Table Input columns: dgvConversion
        'This method sets the data entry columns to Read-Write with a white background.

        If rbEnterInputEastNorth.Checked Then
            For Each Col As DataGridViewColumn In dgvConversion.Columns
                'If Col.HeaderText = "Input Easting" Or Col.HeaderText = "Input Northing" Then
                If Col.HeaderText = "Input Easting" Or Col.HeaderText = "Input Northing" Or Col.HeaderText = "Point Number" Or Col.HeaderText = "Point Name" Or Col.HeaderText = "Point Description" Then
                    Col.ReadOnly = False
                    Col.DefaultCellStyle.BackColor = Color.White
                Else
                    Col.ReadOnly = True
                    Col.DefaultCellStyle.BackColor = Color.WhiteSmoke
                End If
            Next

        ElseIf rbEnterInputLongLat.Checked Then
            For Each Col As DataGridViewColumn In dgvConversion.Columns
                If Col.HeaderText = "Input Longitude" Or Col.HeaderText = "Input Latitude" Or Col.HeaderText = "Input Ellipsoidal Height" Or Col.HeaderText = "Point Number" Or Col.HeaderText = "Point Name" Or Col.HeaderText = "Point Description" Then
                    Col.ReadOnly = False
                    Col.DefaultCellStyle.BackColor = Color.White
                Else
                    Col.ReadOnly = True
                    Col.DefaultCellStyle.BackColor = Color.WhiteSmoke
                End If
            Next
        ElseIf rbEnterInputXYZ.Checked Then
            For Each Col As DataGridViewColumn In dgvConversion.Columns
                If Col.HeaderText = "Input X" Or Col.HeaderText = "Input Y" Or Col.HeaderText = "Input Z" Or Col.HeaderText = "Point Number" Or Col.HeaderText = "Point Name" Or Col.HeaderText = "Point Description" Then
                    Col.ReadOnly = False
                    Col.DefaultCellStyle.BackColor = Color.White
                Else
                    Col.ReadOnly = True
                    Col.DefaultCellStyle.BackColor = Color.WhiteSmoke
                End If
            Next
        End If
    End Sub



    'Private Sub ReCalcDatumTransTable()
    Private Sub ReCalcConversionTable()
        'Recalculate location values in the Datum Transformation table.

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        'Add clent information - any reply to the XMessage will be sent back to the client - location information can also be specified if the reply needs to be sent to a particular location in the client.
        Dim clientProNetName As New XElement("ClientProNetName", ProNetName) 'The name of the Clent Project Network.
        xmessage.Add(clientProNetName)
        Dim clientConnName As New XElement("ClientConnectionName", ConnectionName) 'This tells the coordinate server the connection name of the client making the request.
        xmessage.Add(clientConnName)


        dgvConversion.AllowUserToAddRows = False

        If rbEnterInputEastNorth.Checked Then
            Dim Convert As New XElement("Convert")
            For Each Row As DataGridViewRow In dgvConversion.Rows
                Dim Coord As New XElement("Coord")
                Dim Index As New XElement("Index", Row.Index)
                Coord.Add(Index)
                'Conversion.InputCrs.Coord.SetEasting(Row.Cells(3).Value, Coordinate.UpdateMode.None) 'Update the new Input Easting value
                Dim SetEasting As New XElement("SetEasting", Row.Cells(3).Value)
                Coord.Add(SetEasting)
                'Conversion.InputCrs.Coord.SetNorthing(Row.Cells(4).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Northing value
                Dim SetNorthing As New XElement("SetNorthing", Row.Cells(4).Value)
                Coord.Add(SetNorthing)
                'UpdateDatumTransTable(Row.Index)
                If rbDecDegrees.Checked Then
                    Dim Command As New XElement("Command", "InputEastNorthToIndexedInputOutputAll")
                    Coord.Add(Command)
                Else
                    Dim Command As New XElement("Command", "InputEastNorthToIndexedInputOutputAllDms")
                    Coord.Add(Command)
                End If
                Convert.Add(Coord)
            Next
            xmessage.Add(Convert)

        ElseIf rbEnterInputLongLat.Checked Then
            Dim Convert As New XElement("Convert")
            For Each Row As DataGridViewRow In dgvConversion.Rows
                Dim Coord As New XElement("Coord")
                Dim Index As New XElement("Index", Row.Index)
                Coord.Add(Index)
                'Conversion.InputCrs.Coord.SetLongitude(Row.Cells(5).Value, Coordinate.UpdateMode.None) 'Update the new Input Longitude value
                Dim SetLongitude As New XElement("SetLongitude", Row.Cells(5).Value)
                Coord.Add(SetLongitude)
                'Conversion.InputCrs.Coord.SetLatitude(Row.Cells(6).Value, Coordinate.UpdateMode.None) 'Update the new Input Latitude value
                Dim SetLatitude As New XElement("SetLatitude", Row.Cells(6).Value)
                Coord.Add(SetLatitude)
                'Conversion.InputCrs.Coord.SetEllipsoidalHeight(Row.Cells(7).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Ellipsoidal Height value
                Dim SetEllHeight As New XElement("SetEllHeight", Row.Cells(7).Value)
                Coord.Add(SetEllHeight)
                'UpdateDatumTransTable(Row.Index)
                If rbDecDegrees.Checked Then
                    Dim Command As New XElement("Command", "InputLongLatToIndexedInputOutputAll")
                    Coord.Add(Command)
                Else
                    Dim Command As New XElement("Command", "InputLongLatToIndexedInputOutputAllDms")
                    Coord.Add(Command)
                End If
                Convert.Add(Coord)
            Next
            xmessage.Add(Convert)

        ElseIf rbEnterInputXYZ.Checked Then
            Dim Convert As New XElement("Convert")
            For Each Row As DataGridViewRow In dgvConversion.Rows
                Dim Coord As New XElement("Coord")
                Dim Index As New XElement("Index", Row.Index)
                Coord.Add(Index)
                'Conversion.InputCrs.Coord.SetLongitude(Row.Cells(8).Value, Coordinate.UpdateMode.None) 'Update the new Input X value
                Dim SetX As New XElement("SetX", Row.Cells(8).Value)
                Coord.Add(SetX)
                'Conversion.InputCrs.Coord.SetLatitude(Row.Cells(9).Value, Coordinate.UpdateMode.None) 'Update the new Input Y value
                Dim SetY As New XElement("SetY", Row.Cells(9).Value)
                Coord.Add(SetY)
                'Conversion.InputCrs.Coord.SetEllipsoidalHeight(Row.Cells(10).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Z value
                Dim SetZ As New XElement("SetZ", Row.Cells(10).Value)
                Coord.Add(SetZ)
                'UpdateDatumTransTable(Row.Index)
                If rbDecDegrees.Checked Then
                    Dim Command As New XElement("Command", "InputXYZToIndexedInputOutputAll")
                    Coord.Add(Command)
                Else
                    Dim Command As New XElement("Command", "InputXYZToIndexedInputOutputAllDms")
                    Coord.Add(Command)
                End If
                Convert.Add(Coord)
            Next
            xmessage.Add(Convert)
        End If

        dgvConversion.AllowUserToAddRows = True

        doc.Add(xmessage)


        'Send the XMessage to the Coordinates 2 application:
        Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
        Message.XAddXml(doc.ToString)
        Message.XAddText(vbCrLf, "Normal") 'Add extra line

        SendMessageParamsAlt.ProjectNetworkName = ProNetName
        SendMessageParamsAlt.ConnectionName = "ADVL_Coordinates_2"
        SendMessageParamsAlt.Message = doc.ToString
        If bgwSendMessageAlt.IsBusy Then
            Message.AddWarning("ReCalcConversionTable: Send Message backgroundworker is busy." & vbCrLf)
        Else
            bgwSendMessageAlt.RunWorkerAsync(SendMessageParamsAlt)
        End If

        ''Send the instructions to the Coordinates 2 application:
        'If IsNothing(client) Then
        '    Message.Add("No client connection available!" & vbCrLf)
        'Else
        '    If client.State = ServiceModel.CommunicationState.Faulted Then
        '        Message.Add("client state is faulted. Message not sent!" & vbCrLf)
        '    Else
        '        'cmbCrsList.Items.Clear()
        '        client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
        '        Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
        '        Message.XAddXml(doc.ToString)
        '        Message.XAddText(vbCrLf, "Normal") 'Add extra line
        '    End If
        'End If

    End Sub

    'Private Sub UpdateDatumTransTable(RowNo As Integer)
    '    'Update the calculated values in the Datum Transformation table dgvConversion
    '    'The row specified by RowNo is updated.

    '    For Each Col As DataGridViewColumn In dgvConversion.Columns
    '        If Col.ReadOnly = True Then
    '            Select Case Col.HeaderText
    '                Case "Input Easting"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.Easting
    '                Case "Input Northing"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.Northing
    '                Case "Input Longitude"
    '                    If rbDMS.Checked Then
    '                        dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.LongitudeDMS
    '                    Else
    '                        dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.Longitude
    '                    End If
    '                Case "Input Latitude"
    '                    If rbDMS.Checked Then
    '                        dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.LatitudeDMS
    '                    Else
    '                        dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.Latitude
    '                    End If

    '                Case "Input Ellipsoidal Height"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.EllipsoidalHeight
    '                Case "Input X"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.X
    '                Case "Input Y"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.Y
    '                Case "Input Z"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.InputCrs.Coord.Z
    '                Case "WGS 84 X"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.DatumTrans.Wgs84Coord.X
    '                Case "WGS 84 Y"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.DatumTrans.Wgs84Coord.Y
    '                Case "WGS 84 Z"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.DatumTrans.Wgs84Coord.Z
    '                Case "Output X"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.X
    '                Case "Output Y"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.Y
    '                Case "Output Z"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.Z
    '                Case "Output Longitude"
    '                    If rbDMS.Checked Then
    '                        dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.LongitudeDMS
    '                    Else
    '                        dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.Longitude
    '                    End If
    '                Case "Output Latitude"
    '                    If rbDMS.Checked Then
    '                        dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.LatitudeDMS
    '                    Else
    '                        dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.Latitude
    '                    End If
    '                Case "Output Ellipsoidal Height"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.EllipsoidalHeight
    '                Case "Output Easting"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.Easting
    '                Case "Output Northing"
    '                    dgvConversion.Rows(RowNo).Cells(Col.Index).Value = Conversion.OutputCrs.Coord.Northing
    '            End Select
    '        End If
    '    Next

    '    dgvConversion.AutoResizeColumns()

    'End Sub

    Private Sub chkShowInputEastNorth_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowInputEastNorth.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowInputEastNorth.Checked Then 'Show the Input Easting and Northing columns.
            dgvConversion.Columns(3).Visible = True
            dgvConversion.Columns(4).Visible = True
        Else 'Hide the Input Easting and Northing columns.
            dgvConversion.Columns(3).Visible = False
            dgvConversion.Columns(4).Visible = False
        End If
    End Sub

    Private Sub chkShowInputLongLat_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowInputLongLat.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowInputLongLat.Checked Then 'Show the Input Longitude, Latitude and Ellipsoidal Height columns.
            dgvConversion.Columns(5).Visible = True
            dgvConversion.Columns(6).Visible = True
            dgvConversion.Columns(7).Visible = True
        Else 'Hide the Input Longitude, Latitude and Ellipsoidal Height columns.
            dgvConversion.Columns(5).Visible = False
            dgvConversion.Columns(6).Visible = False
            dgvConversion.Columns(7).Visible = False
        End If
    End Sub

    Private Sub chkShowInputXYZ_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowInputXYZ.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowInputXYZ.Checked Then 'Show the Input X, Y and Z columns.
            dgvConversion.Columns(8).Visible = True
            dgvConversion.Columns(9).Visible = True
            dgvConversion.Columns(10).Visible = True
        Else 'Hide the Input X, Y and Z columns.
            dgvConversion.Columns(8).Visible = False
            dgvConversion.Columns(9).Visible = False
            dgvConversion.Columns(10).Visible = False
        End If
    End Sub

    Private Sub chkShowWgs84XYZ_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowWgs84XYZ.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowWgs84XYZ.Checked Then 'Show the WGS 84 X, Y and Z columns.
            dgvConversion.Columns(11).Visible = True
            dgvConversion.Columns(12).Visible = True
            dgvConversion.Columns(13).Visible = True
        Else 'Hide the WGS 84 X, Y and Z columns.
            dgvConversion.Columns(11).Visible = False
            dgvConversion.Columns(12).Visible = False
            dgvConversion.Columns(13).Visible = False
        End If
    End Sub

    Private Sub chkShowOutputEastNorth_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowOutputEastNorth.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowOutputEastNorth.Checked Then 'Show the Output Easting and Northing columns.
            dgvConversion.Columns(20).Visible = True
            dgvConversion.Columns(21).Visible = True
        Else 'Hide the Output Easting and Northing columns.
            dgvConversion.Columns(20).Visible = False
            dgvConversion.Columns(21).Visible = False
        End If
    End Sub

    Private Sub chkShowOutputLongLat_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowOutputLongLat.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowOutputLongLat.Checked Then 'Show the Output Longitude, Latitude and Ellipsoidal Height columns.
            dgvConversion.Columns(17).Visible = True
            dgvConversion.Columns(18).Visible = True
            dgvConversion.Columns(19).Visible = True
        Else 'Hide the Output Longitude, Latitude and Ellipsoidal Height columns.
            dgvConversion.Columns(17).Visible = False
            dgvConversion.Columns(18).Visible = False
            dgvConversion.Columns(19).Visible = False
        End If
    End Sub

    Private Sub chkShowOutputXYZ_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowOutputXYZ.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowOutputXYZ.Checked Then 'Show the Output X, Y and Z columns.
            dgvConversion.Columns(14).Visible = True
            dgvConversion.Columns(15).Visible = True
            dgvConversion.Columns(16).Visible = True
        Else 'Hide the Output X, Y and Z columns.
            dgvConversion.Columns(14).Visible = False
            dgvConversion.Columns(15).Visible = False
            dgvConversion.Columns(16).Visible = False
        End If
    End Sub

    Private Sub txtProjFormat_TextChanged(sender As Object, e As EventArgs) Handles txtProjFormat.TextChanged

    End Sub

    Private Sub txtProjFormat_LostFocus(sender As Object, e As EventArgs) Handles txtProjFormat.LostFocus
        'The Projected Easting and Northing format has changed.
        Dim Format As String = txtProjFormat.Text.Trim
        dgvConversion.Columns(3).DefaultCellStyle.Format = Format
        dgvConversion.Columns(4).DefaultCellStyle.Format = Format
        dgvConversion.Columns(20).DefaultCellStyle.Format = Format
        dgvConversion.Columns(21).DefaultCellStyle.Format = Format
    End Sub

    Private Sub txtCartFormat_TextChanged(sender As Object, e As EventArgs) Handles txtCartFormat.TextChanged

    End Sub

    Private Sub txtCartFormat_LostFocus(sender As Object, e As EventArgs) Handles txtCartFormat.LostFocus
        'The Cartesian coordinate format has changed.
        Dim Format As String = txtCartFormat.Text.Trim
        dgvConversion.Columns(8).DefaultCellStyle.Format = Format
        dgvConversion.Columns(9).DefaultCellStyle.Format = Format
        dgvConversion.Columns(10).DefaultCellStyle.Format = Format
        dgvConversion.Columns(11).DefaultCellStyle.Format = Format
        dgvConversion.Columns(12).DefaultCellStyle.Format = Format
        dgvConversion.Columns(13).DefaultCellStyle.Format = Format
        dgvConversion.Columns(14).DefaultCellStyle.Format = Format
        dgvConversion.Columns(15).DefaultCellStyle.Format = Format
        dgvConversion.Columns(16).DefaultCellStyle.Format = Format
    End Sub

    Private Sub rbDecDegrees_CheckedChanged(sender As Object, e As EventArgs) Handles rbDecDegrees.CheckedChanged

        If rbDecDegrees.Focused Then UpdateOutputGeographicCoords()
    End Sub

    Private Sub rbDMS_CheckedChanged(sender As Object, e As EventArgs) Handles rbDMS.CheckedChanged
        If rbDMS.Focused Then UpdateOutputGeographicCoords()
    End Sub

    Private Sub UpdateOutputGeographicCoords()
        'Update all of the Output Grographic Coordinates.
        'This is done if the Geographic display format has changed.

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        If rbDecDegrees.Checked Then
            Try
                txtDegreeDecPlaces.Text = Int(txtDegreeDecPlaces.Text.Trim)
                Dim Format As String = "F" & txtDegreeDecPlaces.Text.Trim
                dgvConversion.Columns(5).DefaultCellStyle.Format = Format
                dgvConversion.Columns(6).DefaultCellStyle.Format = Format
                dgvConversion.Columns(17).DefaultCellStyle.Format = Format
                dgvConversion.Columns(18).DefaultCellStyle.Format = Format
            Catch ex As Exception

            End Try
        End If


        dgvConversion.AllowUserToAddRows = False

        'If Conversion.InputCrs.Kind = CoordRefSystem.CrsKind.projected Then
        If txtInputCrsKind.Text = "projected" Then
            rbEnterInputEastNorth.Enabled = True
        Else
            rbEnterInputEastNorth.Enabled = False
            If rbEnterInputEastNorth.Checked Then rbEnterInputLongLat.Checked = True
        End If

        If rbEnterInputEastNorth.Checked Then
            Dim Convert As New XElement("Convert")
            For Each Row As DataGridViewRow In dgvConversion.Rows
                Dim Coord As New XElement("Coord")
                'Conversion.InputCrs.Coord.SetEasting(Row.Cells(3).Value, Coordinate.UpdateMode.None)
                Dim SetEasting As New XElement("SetEasting", Row.Cells(3).Value)
                Coord.Add(SetEasting)
                'Conversion.InputCrs.Coord.SetNorthing(Row.Cells(4).Value, Coordinate.UpdateMode.TransLongLat)
                Dim SetNorthing As New XElement("SetNorthing", Row.Cells(4).Value)
                Coord.Add(SetNorthing)
                If rbDecDegrees.Checked Then
                    Dim Command As New XElement("Command", "InputEastNorthToOutputLongLat")
                    Coord.Add(Command)
                Else
                    Dim Command As New XElement("Command", "InputEastNorthToOutputLongLatDms")
                    Coord.Add(Command)
                End If
                'If rbDecDegrees.Checked Then
                '    'Row.Cells(17).Value = Conversion.OutputCrs.Coord.Longitude
                '    'Row.Cells(18).Value = Conversion.OutputCrs.Coord.Latitude
                '    Dim CommandGetLongLat As New XElement("Command", "GetLongLat")
                '    Coord.Add(CommandGetLongLat)
                'Else
                '    'Row.Cells(17).Value = Conversion.OutputCrs.Coord.LongitudeDMS
                '    'Row.Cells(18).Value = Conversion.OutputCrs.Coord.LatitudeDMS
                '    Dim CommandGetLongLat As New XElement("Command", "GetLongLatDms")
                '    Coord.Add(CommandGetLongLat)
                'End If
                Convert.Add(Coord)
            Next
            xmessage.Add(Convert)

        ElseIf rbEnterInputLongLat.Checked Then
            Dim Convert As New XElement("Convert")
            For Each Row As DataGridViewRow In dgvConversion.Rows
                Dim Coord As New XElement("Coord")
                'Conversion.InputCrs.Coord.SetLongitude(Row.Cells(5).Value, Coordinate.UpdateMode.None)
                Dim SetLongitude As New XElement("SetLongitude", Row.Cells(5).Value)
                Coord.Add(SetLongitude)
                'Conversion.InputCrs.Coord.SetLatitude(Row.Cells(6).Value, Coordinate.UpdateMode.None)
                Dim SetLatitude As New XElement("SetLatitude", Row.Cells(6).Value)
                Coord.Add(SetLatitude)
                'Conversion.InputCrs.Coord.SetEllipsoidalHeight(Row.Cells(7).Value, Coordinate.UpdateMode.TransLongLat)
                Dim SetEllHeight As New XElement("SetEllHeight", Row.Cells(7).Value)
                Coord.Add(SetEllHeight)
                If rbDecDegrees.Checked Then
                    Dim Command As New XElement("Command", "InputLongLatToOutputLongLat")
                    Coord.Add(Command)
                Else
                    Dim Command As New XElement("Command", "InputLongLatToOutputLongLatDms")
                    Coord.Add(Command)
                End If
                'If rbDecDegrees.Checked Then
                '    'Row.Cells(17).Value = Conversion.OutputCrs.Coord.Longitude
                '    'Row.Cells(18).Value = Conversion.OutputCrs.Coord.Latitude
                '    Dim CommandGetLongLat As New XElement("Command", "GetLongLat")
                '    Coord.Add(CommandGetLongLat)
                'Else
                '    'Row.Cells(17).Value = Conversion.OutputCrs.Coord.LongitudeDMS
                '    'Row.Cells(18).Value = Conversion.OutputCrs.Coord.LatitudeDMS
                '    Dim CommandGetLongLat As New XElement("Command", "GetLongLatDms")
                '    Coord.Add(CommandGetLongLat)
                'End If
                Convert.Add(Coord)
            Next
            xmessage.Add(Convert)

        ElseIf rbEnterInputXYZ.Checked Then
            Dim Convert As New XElement("Convert")
            For Each Row As DataGridViewRow In dgvConversion.Rows
                Dim Coord As New XElement("Coord")
                'Conversion.InputCrs.Coord.SetX(Row.Cells(8).Value, Coordinate.UpdateMode.None)
                Dim SetX As New XElement("SetX", Row.Cells(8).Value)
                Coord.Add(SetX)
                'Conversion.InputCrs.Coord.SetY(Row.Cells(9).Value, Coordinate.UpdateMode.None)
                Dim SetY As New XElement("SetY", Row.Cells(9).Value)
                Coord.Add(SetY)
                'Conversion.InputCrs.Coord.SetZ(Row.Cells(10).Value, Coordinate.UpdateMode.TransLongLat)
                Dim SetZ As New XElement("SetZ", Row.Cells(10).Value)
                Coord.Add(SetZ)
                If rbDecDegrees.Checked Then
                    Dim Command As New XElement("Command", "InputXYZToOutputLongLat")
                    Coord.Add(Command)
                Else
                    Dim Command As New XElement("Command", "InputXYZToOutputLongLatDms")
                    Coord.Add(Command)
                End If
                '    If rbDecDegrees.Checked Then
                '        'Row.Cells(17).Value = Conversion.OutputCrs.Coord.Longitude
                '        'Row.Cells(18).Value = Conversion.OutputCrs.Coord.Latitude
                '        Dim CommandGetLongLat As New XElement("Command", "GetLongLat")
                '        Coord.Add(CommandGetLongLat)
                '    Else
                '        'Row.Cells(17).Value = Conversion.OutputCrs.Coord.LongitudeDMS
                '        'Row.Cells(18).Value = Conversion.OutputCrs.Coord.LatitudeDMS
                '        Dim CommandGetLongLat As New XElement("Command", "GetLongLatDms")
                '        Coord.Add(CommandGetLongLat)
                '    End If
            Next
            xmessage.Add(Convert)

        Else

        End If

        dgvConversion.AllowUserToAddRows = True
        dgvConversion.AutoResizeColumns()

        doc.Add(xmessage)

        'Send the instructions to the Coordinates 2 application:
        If IsNothing(client) Then
            Message.Add("UpdateOutputGeographicCoords: No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                'cmbCrsList.Items.Clear()
                client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line
            End If
        End If

    End Sub

    Private Sub txtDegreeDecPlaces_TextChanged(sender As Object, e As EventArgs) Handles txtDegreeDecPlaces.TextChanged

    End Sub

    Private Sub txtDegreeDecPlaces_LostFocus(sender As Object, e As EventArgs) Handles txtDegreeDecPlaces.LostFocus
        'The number of Decimal Degrees decimal places has changed.
        If rbDecDegrees.Checked Then
            Try
                txtDegreeDecPlaces.Text = Int(txtDegreeDecPlaces.Text.Trim)
                Dim Format As String = "F" & txtDegreeDecPlaces.Text.Trim
                dgvConversion.Columns(5).DefaultCellStyle.Format = Format
                dgvConversion.Columns(6).DefaultCellStyle.Format = Format
                dgvConversion.Columns(17).DefaultCellStyle.Format = Format
                dgvConversion.Columns(18).DefaultCellStyle.Format = Format
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtHeightFormat_TextChanged(sender As Object, e As EventArgs) Handles txtHeightFormat.TextChanged

    End Sub

    Private Sub txtHeightFormat_LostFocus(sender As Object, e As EventArgs) Handles txtHeightFormat.LostFocus
        'The Ellipsoidal Height format has changed.
        Dim Format As String = txtHeightFormat.Text.Trim
        dgvConversion.Columns(7).DefaultCellStyle.Format = Format
        dgvConversion.Columns(19).DefaultCellStyle.Format = Format
    End Sub

    Private Sub ApplyCoordinateFormats()
        'Apply the Datum Transformation number formats to dgvConversion

        Dim ProjFormat As String = txtProjFormat.Text.Trim
        Dim CartFormat As String = txtCartFormat.Text.Trim
        Dim HeightFormat As String = txtHeightFormat.Text.Trim

        'For Each Col As DataGridViewColumn In dgvConversion.Columns
        '    'If Col.HeaderText = "Input Easting" Then Col.DefaultCellStyle.Format = ProjFormat
        '    If Col.Visible And Col.HeaderText = "Input Easting" Then Col.DefaultCellStyle.Format = ProjFormat
        '    If Col.Visible And Col.HeaderText = "Input Northing" Then Col.DefaultCellStyle.Format = ProjFormat
        '    If Col.Visible And Col.HeaderText = "Output Easting" Then Col.DefaultCellStyle.Format = ProjFormat
        '    If Col.Visible And Col.HeaderText = "Output Northing" Then Col.DefaultCellStyle.Format = ProjFormat

        '    If Col.Visible And Col.HeaderText = "Input Ellipsoidal Height" Then Col.DefaultCellStyle.Format = HeightFormat
        '    If Col.Visible And Col.HeaderText = "Output Ellipsoidal Height" Then Col.DefaultCellStyle.Format = HeightFormat

        '    If Col.Visible And Col.HeaderText = "Input X" Then Col.DefaultCellStyle.Format = CartFormat
        '    If Col.Visible And Col.HeaderText = "Input Y" Then Col.DefaultCellStyle.Format = CartFormat
        '    If Col.Visible And Col.HeaderText = "Input Z" Then Col.DefaultCellStyle.Format = CartFormat
        '    If Col.Visible And Col.HeaderText = "Output X" Then Col.DefaultCellStyle.Format = CartFormat
        '    If Col.Visible And Col.HeaderText = "Output Y" Then Col.DefaultCellStyle.Format = CartFormat
        '    If Col.Visible And Col.HeaderText = "Output Z" Then Col.DefaultCellStyle.Format = CartFormat
        'Next

        dgvConversion.Columns(3).DefaultCellStyle.Format = ProjFormat
        dgvConversion.Columns(4).DefaultCellStyle.Format = ProjFormat
        dgvConversion.Columns(20).DefaultCellStyle.Format = ProjFormat
        dgvConversion.Columns(21).DefaultCellStyle.Format = ProjFormat

        dgvConversion.Columns(7).DefaultCellStyle.Format = HeightFormat
        dgvConversion.Columns(19).DefaultCellStyle.Format = HeightFormat

        dgvConversion.Columns(8).DefaultCellStyle.Format = CartFormat
        dgvConversion.Columns(9).DefaultCellStyle.Format = CartFormat
        dgvConversion.Columns(10).DefaultCellStyle.Format = CartFormat
        dgvConversion.Columns(11).DefaultCellStyle.Format = CartFormat
        dgvConversion.Columns(12).DefaultCellStyle.Format = CartFormat
        dgvConversion.Columns(13).DefaultCellStyle.Format = CartFormat
        dgvConversion.Columns(14).DefaultCellStyle.Format = CartFormat
        dgvConversion.Columns(15).DefaultCellStyle.Format = CartFormat
        dgvConversion.Columns(16).DefaultCellStyle.Format = CartFormat

        If rbDecDegrees.Checked Then
            Try
                txtDegreeDecPlaces.Text = Int(txtDegreeDecPlaces.Text.Trim)
                Dim Format As String = "F" & txtDegreeDecPlaces.Text.Trim
                'For Each Col As DataGridViewColumn In dgvConversion.Columns
                '    'If Col.HeaderText = "Input Longitude" Then Col.DefaultCellStyle.Format = Format
                '    If Col.Visible And Col.HeaderText = "Input Longitude" Then Col.DefaultCellStyle.Format = Format
                '    If Col.Visible And Col.HeaderText = "Input Latitude" Then Col.DefaultCellStyle.Format = Format
                '    If Col.Visible And Col.HeaderText = "Output Longitude" Then Col.DefaultCellStyle.Format = Format
                '    If Col.Visible And Col.HeaderText = "Output Latitude" Then Col.DefaultCellStyle.Format = Format
                'Next
                dgvConversion.Columns(5).DefaultCellStyle.Format = Format
                dgvConversion.Columns(6).DefaultCellStyle.Format = Format
                dgvConversion.Columns(17).DefaultCellStyle.Format = Format
                dgvConversion.Columns(18).DefaultCellStyle.Format = Format
            Catch ex As Exception

            End Try
        Else

        End If

        dgvConversion.AutoResizeColumns()

    End Sub

    Private Sub txtSecondsDecPlaces_TextChanged(sender As Object, e As EventArgs) Handles txtSecondsDecPlaces.TextChanged

    End Sub

    Private Sub txtSecondsDecPlaces_LostFocus(sender As Object, e As EventArgs) Handles txtSecondsDecPlaces.LostFocus
        'Set the Seconds decimal places in the Deg-Min-Sec degree format.

        'Conversion.InputCrs.Coord.DegMinSecDecimalPlaces = txtSecondsDecPlaces.Text
        'Conversion.OutputCrs.Coord.DegMinSecDecimalPlaces = txtSecondsDecPlaces.Text

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        Dim SetDegMinSecDecimalPlaces As New XElement("SetDegMinSecDecimalPlaces", txtSecondsDecPlaces.Text.Trim) 'Set the Seconds decimal places.
        xmessage.Add(SetDegMinSecDecimalPlaces)

        doc.Add(xmessage)

        'Send the instructions to the Coordinates 2 application:
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                'cmbCrsList.Items.Clear()
                client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line
            End If
        End If


    End Sub

    Private Sub chkDmsSymbols_CheckedChanged(sender As Object, e As EventArgs) Handles chkDmsSymbols.CheckedChanged

        'If chkDmsSymbols.Checked Then
        '    Conversion.InputCrs.Coord.ShowDmsSymbols = True
        '    Conversion.OutputCrs.Coord.ShowDmsSymbols = True
        'Else
        '    Conversion.InputCrs.Coord.ShowDmsSymbols = False
        '    Conversion.OutputCrs.Coord.ShowDmsSymbols = False
        'End If

        If chkDmsSymbols.Focused Then
            'Create the xml instructions:
            Dim decl As New XDeclaration("1.0", "utf-8", "yes")
            Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
            Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

            Dim ShowDmsSymbols As New XElement("ShowDmsSymbols", chkDmsSymbols.Checked)
            xmessage.Add(ShowDmsSymbols)

            doc.Add(xmessage)

            'Send the instructions to the Coordinates 2 application:
            If IsNothing(client) Then
                Message.Add("DmsSymbols changed: No client connection available!" & vbCrLf)
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("client state is faulted. Message not sent!" & vbCrLf)
                Else
                    'cmbCrsList.Items.Clear()
                    client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                    Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(doc.ToString)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line
                End If
            End If
        End If
    End Sub

    Private Sub chkShowPointNumber_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPointNumber.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowPointNumber.Checked Then 'Show the Point Number column.
            dgvConversion.Columns(0).Visible = True
        Else 'Remove the Point Number column
            dgvConversion.Columns(0).Visible = False
        End If
    End Sub

    Private Sub chkShowPointName_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPointName.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowPointName.Checked Then 'Show the Point Name column.
            dgvConversion.Columns(1).Visible = True
        Else 'Hide the Point Name column
            dgvConversion.Columns(1).Visible = False
        End If
    End Sub

    Private Sub chkShowPointDescription_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPointDescription.CheckedChanged
        'UpdateDatumTransTable()
        If chkShowPointDescription.Checked Then 'Show the Point Description column.
            dgvConversion.Columns(2).Visible = True
        Else 'Hide the Point Description column
            dgvConversion.Columns(2).Visible = False
        End If
    End Sub

    Private Sub dgvConversion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConversion.CellContentClick

    End Sub

    Private Sub dgvConversion_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConversion.CellEndEdit
        'The cell has been edited - update the coordinates.

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        'Add clent information - any reply to the XMessage will be sent back to the client - location information can also be specified if the reply needs to be sent to a particular location in the client.
        Dim clientProNetName As New XElement("ClientProNetName", ProNetName) 'The name of the Clent Project Network.
        xmessage.Add(clientProNetName)
        Dim clientConnName As New XElement("ClientConnectionName", ConnectionName) 'This tells the coordinate server the connection name of the client making the request.
        xmessage.Add(clientConnName)


        Dim ColHeader As String = dgvConversion.Columns(e.ColumnIndex).HeaderText
        Select Case ColHeader
            Case "Point Number"
                'The Point number has been edited

            Case "Point Name"
                'The Point name has been edited

            Case "Point Description"
                'The Point description has been edited

            Case "Input Easting"
                If rbEnterInputEastNorth.Checked Then 'This is a valid entry coordinate
                    'Check that the Northing value is valid:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).ToString.Trim = "" Then  'There is no Northing value
                        'New coordinate values can not be calculated.
                    Else
                        Dim Convert As New XElement("Convert")
                        Dim Coord As New XElement("Coord")
                        Dim Index As New XElement("Index", e.RowIndex)
                        Coord.Add(Index)
                        'Conversion.InputCrs.Coord.SetNorthing(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value, Coordinate.UpdateMode.None) 'Set the Input Northing value
                        Dim SetNorthing As New XElement("SetNorthing", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                        Coord.Add(SetNorthing)
                        'Conversion.InputCrs.Coord.SetEasting(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Easting value and Update all the Input and Output coordinate types
                        Dim SetEasting As New XElement("SetEasting", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                        Coord.Add(SetEasting)
                        'UpdateDatumTransTable(e.RowIndex)
                        If rbDecDegrees.Checked Then
                            Dim Command As New XElement("Command", "InputEastNorthToIndexedInputOutputAll")
                            Coord.Add(Command)
                        Else
                            Dim Command As New XElement("Command", "InputEastNorthToIndexedInputOutputAllDms")
                            Coord.Add(Command)
                        End If
                        Convert.Add(Coord)
                        xmessage.Add(Convert)
                    End If
                End If
            Case "Input Northing"
                If rbEnterInputEastNorth.Checked Then 'This is a valid entry coordinate
                    'Check that the Easting value is valid:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).ToString.Trim = "" Then  'There is no Easting value
                        'New coordinate values can not be calculated.
                    Else
                        Dim Convert As New XElement("Convert")
                        Dim Coord As New XElement("Coord")
                        Dim Index As New XElement("Index", e.RowIndex)
                        Coord.Add(Index)
                        'Conversion.InputCrs.Coord.SetEasting(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value, Coordinate.UpdateMode.None) 'Set the Input Easting value
                        Dim SetEasting As New XElement("SetEasting", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                        Coord.Add(SetEasting)
                        'Conversion.InputCrs.Coord.SetNorthing(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Northing value and Update all the Input and Output coordinate types
                        Dim SetNorthing As New XElement("SetNorthing", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                        Coord.Add(SetNorthing)
                        'UpdateDatumTransTable(e.RowIndex)
                        If rbDecDegrees.Checked Then
                            Dim Command As New XElement("Command", "InputEastNorthToIndexedInputOutputAll")
                            Coord.Add(Command)
                        Else
                            Dim Command As New XElement("Command", "InputEastNorthToIndexedInputOutputAllDms")
                            Coord.Add(Command)
                        End If
                        Convert.Add(Coord)
                        xmessage.Add(Convert)
                    End If
                End If
            Case "Input Longitude"
                If rbEnterInputLongLat.Checked Then
                    'Check if the Ellipsoidal Height has been defined:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).ToString.Trim = "" Then dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value = 0
                    'Check that the Latitude value is valid:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).ToString.Trim = "" Then  'There is no Latitude value
                        'New coordinate values can not be calculated.
                    Else
                        Dim Convert As New XElement("Convert")
                        Dim Coord As New XElement("Coord")
                        Dim Index As New XElement("Index", e.RowIndex)
                        Coord.Add(Index)
                        'Conversion.InputCrs.Coord.SetLatitude(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value, Coordinate.UpdateMode.None) 'Set the Input Latitude value
                        Dim SetLatitude As New XElement("SetLatitude", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                        Coord.Add(SetLatitude)
                        'Conversion.InputCrs.Coord.SetEllipsoidalHeight(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value, Coordinate.UpdateMode.None) 'Set the Input Ellipsoidal Height value
                        Dim SetEllHeight As New XElement("SetEllHeight", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                        Coord.Add(SetEllHeight)
                        'Conversion.InputCrs.Coord.SetLongitude(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Longitude value and Update all the Input and Output coordinate types
                        Dim SetLongitude As New XElement("SetLongitude", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                        Coord.Add(SetLongitude)
                        'UpdateDatumTransTable(e.RowIndex)
                        If rbDecDegrees.Checked Then
                            Dim Command As New XElement("Command", "InputLongLatToIndexedInputOutputAll")
                            Coord.Add(Command)
                        Else
                            Dim Command As New XElement("Command", "InputLongLatToIndexedInputOutputAllDms")
                            Coord.Add(Command)
                        End If
                        Convert.Add(Coord)
                        xmessage.Add(Convert)
                    End If
                End If
            Case "Input Latitude"
                If rbEnterInputLongLat.Checked Then
                    'Check if the Ellipsoidal Height has been defined:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).ToString.Trim = "" Then dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = 0
                    'Check that the Longitude value is valid:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).ToString.Trim = "" Then  'There is no Longitude value
                        'New coordinate values can not be calculated.
                    Else
                        Dim Convert As New XElement("Convert")
                        Dim Coord As New XElement("Coord")
                        Dim Index As New XElement("Index", e.RowIndex)
                        Coord.Add(Index)
                        'Conversion.InputCrs.Coord.SetLongitude(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value, Coordinate.UpdateMode.None) 'Set the Input Longitude value
                        Dim SetLongitude As New XElement("SetLongitude", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                        Coord.Add(SetLongitude)
                        'Conversion.InputCrs.Coord.SetEllipsoidalHeight(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value, Coordinate.UpdateMode.None) 'Set the Input Ellipsoidal Height value
                        Dim SetEllHeight As New XElement("SetEllHeight", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                        Coord.Add(SetEllHeight)
                        'Conversion.InputCrs.Coord.SetLatitude(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Latitude value and Update all the Input and Output coordinate types
                        Dim SetLatitude As New XElement("SetLatitude", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                        Coord.Add(SetLatitude)
                        'UpdateDatumTransTable(e.RowIndex)
                        If rbDecDegrees.Checked Then
                            Dim Command As New XElement("Command", "InputLongLatToIndexedInputOutputAll")
                            Coord.Add(Command)
                        Else
                            Dim Command As New XElement("Command", "InputLongLatToIndexedInputOutputAllDms")
                            Coord.Add(Command)
                        End If
                        Convert.Add(Coord)
                        xmessage.Add(Convert)
                    End If
                End If
            Case "Input Ellipsoidal Height"
                If rbEnterInputLongLat.Checked Then
                    'Check that the Longitude and Latitude values are valid:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).ToString.Trim = "" Or dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).ToString.Trim = "" Then  'There is no Longitude or Latitude value
                        'New coordinate values can not be calculated.
                    Else
                        Dim Convert As New XElement("Convert")
                        Dim Coord As New XElement("Coord")
                        Dim Index As New XElement("Index", e.RowIndex)
                        Coord.Add(Index)
                        'Conversion.InputCrs.Coord.SetLongitude(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value, Coordinate.UpdateMode.None)
                        Dim SetLongitude As New XElement("SetLongitude", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                        Coord.Add(SetLongitude)
                        'Conversion.InputCrs.Coord.SetLatitude(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value, Coordinate.UpdateMode.None)
                        Dim SetLatitude As New XElement("SetLatitude", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                        Coord.Add(SetLatitude)
                        'Conversion.InputCrs.Coord.SetEllipsoidalHeight(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Coordinate.UpdateMode.InputOutputAll)
                        Dim SetEllHeight As New XElement("SetEllHeight", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                        Coord.Add(SetEllHeight)
                        'If Conversion.InputCrs.Kind = CoordRefSystem.CrsKind.projected Then Conversion.InputCrs.LongLatToEastNorth()
                        'Conversion.InputCrs.LongLatEllHtToXYZ()
                        'Conversion.DatumTrans.InputToOutput()
                        'Conversion.OutputCrs.XYZToLongLatEllHt()
                        'If Conversion.OutputCrs.Kind = CoordRefSystem.CrsKind.projected Then Conversion.OutputCrs.LongLatToEastNorth()
                        'UpdateDatumTransTable(e.RowIndex)
                        If rbDecDegrees.Checked Then
                            Dim Command As New XElement("Command", "InputLongLatToIndexedInputOutputAll")
                            Coord.Add(Command)
                        Else
                            Dim Command As New XElement("Command", "InputLongLatToIndexedInputOutputAllDms")
                            Coord.Add(Command)
                        End If
                        Convert.Add(Coord)
                        xmessage.Add(Convert)
                    End If
                End If
            Case "Input X"
                If rbEnterInputXYZ.Checked Then
                    'Check if the Y and Z values are valid:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).ToString.Trim = "" Or dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).ToString.Trim = "" Then  'There is no Y or Z value
                        'New coordinate values can not be calculated.
                    Else
                        Dim Convert As New XElement("Convert")
                        Dim Coord As New XElement("Coord")
                        Dim Index As New XElement("Index", e.RowIndex)
                        Coord.Add(Index)
                        'Conversion.InputCrs.Coord.SetY(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value, Coordinate.UpdateMode.None) 'Set the Input Y value
                        Dim SetY As New XElement("SetY", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                        Coord.Add(SetY)
                        'Conversion.InputCrs.Coord.SetZ(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value, Coordinate.UpdateMode.None) 'Set the Input Z value
                        Dim SetZ As New XElement("SetZ", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 2).Value)
                        Coord.Add(SetZ)
                        'Conversion.InputCrs.Coord.SetX(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input X value and Update all the Input and Output coordinate types
                        Dim SetX As New XElement("SetX", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                        Coord.Add(SetX)
                        'UpdateDatumTransTable(e.RowIndex)
                        If rbDecDegrees.Checked Then
                            Dim Command As New XElement("Command", "InputXYZToIndexedInputOutputAll")
                            Coord.Add(Command)
                        Else
                            Dim Command As New XElement("Command", "InputXYZToIndexedInputOutputAllDms")
                            Coord.Add(Command)
                        End If
                        Convert.Add(Coord)
                        xmessage.Add(Convert)
                    End If
                End If
            Case "Input Y"
                If rbEnterInputXYZ.Checked Then
                    'Check if the X and Z values are valid:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).ToString.Trim = "" Or dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).ToString.Trim = "" Then  'There is no X or Z value
                        'New coordinate values can not be calculated.
                    Else
                        Dim Convert As New XElement("Convert")
                        Dim Coord As New XElement("Coord")
                        Dim Index As New XElement("Index", e.RowIndex)
                        Coord.Add(Index)
                        'Conversion.InputCrs.Coord.SetX(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value, Coordinate.UpdateMode.None) 'Set the Input X value
                        Dim SetX As New XElement("SetX", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                        Coord.Add(SetX)
                        'Conversion.InputCrs.Coord.SetZ(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value, Coordinate.UpdateMode.None) 'Set the Input Z value
                        Dim SetZ As New XElement("SetZ", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
                        Coord.Add(SetZ)
                        'Conversion.InputCrs.Coord.SetY(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Y value and Update all the Input and Output coordinate types
                        Dim SetY As New XElement("SetY", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                        Coord.Add(SetY)
                        'UpdateDatumTransTable(e.RowIndex)
                        If rbDecDegrees.Checked Then
                            Dim Command As New XElement("Command", "InputXYZToIndexedInputOutputAll")
                            Coord.Add(Command)
                        Else
                            Dim Command As New XElement("Command", "InputXYZToIndexedInputOutputAllDms")
                            Coord.Add(Command)
                        End If
                        Convert.Add(Coord)
                        xmessage.Add(Convert)
                    End If
                End If
            Case "Input Z"
                If rbEnterInputXYZ.Checked Then
                    'Check if the X and Y values are valid:
                    If dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).ToString.Trim = "" Or dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).ToString.Trim = "" Then  'There is no X or Y value
                        'New coordinate values can not be calculated.
                    Else
                        Dim Convert As New XElement("Convert")
                        Dim Coord As New XElement("Coord")
                        Dim Index As New XElement("Index", e.RowIndex)
                        Coord.Add(Index)
                        'Conversion.InputCrs.Coord.SetX(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value, Coordinate.UpdateMode.None) 'Update the Input X value
                        Dim SetX As New XElement("SetX", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 2).Value)
                        Coord.Add(SetX)
                        'Conversion.InputCrs.Coord.SetY(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value, Coordinate.UpdateMode.None) 'Update the Input Y value
                        Dim SetY As New XElement("SetY", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value)
                        Coord.Add(SetY)
                        'Conversion.InputCrs.Coord.SetZ(dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value, Coordinate.UpdateMode.InputOutputAll) 'Update the new Input Z value and Update all the Input and Output coordinate types
                        Dim SetZ As New XElement("SetZ", dgvConversion.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                        Coord.Add(SetZ)
                        'UpdateDatumTransTable(e.RowIndex)
                        If rbDecDegrees.Checked Then
                            Dim Command As New XElement("Command", "InputXYZToIndexedInputOutputAll")
                            Coord.Add(Command)
                        Else
                            Dim Command As New XElement("Command", "InputXYZToIndexedInputOutputAllDms")
                            Coord.Add(Command)
                        End If
                        Convert.Add(Coord)
                        xmessage.Add(Convert)
                    End If
                End If
            Case "WGS 84 X"
                'This column is not editable.
            Case "WGS 84 Y"
                 'This column is not editable.
            Case "WGS 84 Z"
                 'This column is not editable.
            Case "Output X"
                 'This column is not editable.
            Case "Output Y"
                 'This column is not editable.
            Case "Output Z"
                 'This column is not editable.
            Case "Output Longitude"
                 'This column is not editable.
            Case "Output Latitude"
                 'This column is not editable.
            Case "Output Ellipsoidal Height"
                 'This column is not editable.
            Case "Output Easting"
                 'This column is not editable.
            Case "Output Northing"
                'This column is not editable.
            Case Else

        End Select

        doc.Add(xmessage)

        'Send the instructions to the Coordinates 2 application:
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                'cmbCrsList.Items.Clear()
                client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line
            End If
        End If
    End Sub

    Private Sub btdSetDatumTrans_Click(sender As Object, e As EventArgs) Handles btdSetDatumTrans.Click
        'Set the coordinates server datum transformation parameters.

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        If rbDtNotRequired.Enabled And rbDtNotRequired.Checked Then
            Dim SetDatumTransType As New XElement("SetDatumTransType", "None") 'Set the Datum Transformation type to None.
            xmessage.Add(SetDatumTransType)

        ElseIf rbDirectDatumTrans.Checked Then
            Dim SetDatumTransType As New XElement("SetDatumTransType", "Direct") 'Set the Datum Transformation type to Direct.
            xmessage.Add(SetDatumTransType)
            Dim SetDirectDatumTransCode As New XElement("SetDirectDatumTransCode", txtDirectDatumTransOpCode.Text)
            xmessage.Add(SetDirectDatumTransCode)
            Dim SetDirectDatumTransApplyRev As New XElement("SetDirectDatumTransApplyRev", txtDirectDatumTransOpApplyRev.Text)
            xmessage.Add(SetDirectDatumTransApplyRev)

        ElseIf rbDatumTransViaWgs84.Checked Then
            Dim SetDatumTransType As New XElement("SetDatumTransType", "ViaWgs84") 'Set the Datum Transformation type to Direct.
            xmessage.Add(SetDatumTransType)
            Dim SetInputToWgs84DatumTransCode As New XElement("SetInputToWgs84DatumTransCode", txtDirectDatumTransOpCode.Text)
            xmessage.Add(SetInputToWgs84DatumTransCode)
            Dim SetInputToWgs84DatumTransApplyRev As New XElement("SetInputToWgs84DatumTransApplyRev", txtDirectDatumTransOpApplyRev.Text)
            xmessage.Add(SetInputToWgs84DatumTransApplyRev)
            Dim SetWgs84ToOutputDatumTransCode As New XElement("SetWgs84ToOutputDatumTransCode", txtInputToWgs84DatumTransOpCode.Text)
            xmessage.Add(SetWgs84ToOutputDatumTransCode)
            Dim SetoWgs84ToOutputDatumTransApplyRev As New XElement("SetoWgs84ToOutputDatumTransApplyRev", txtInputToWgs84DatumTransOpApplyRev.Text)
            xmessage.Add(SetoWgs84ToOutputDatumTransApplyRev)

        Else
            'Datum transformation parameters not defined.
        End If



        doc.Add(xmessage)




        'Send the instructions to the Coordinates 2 application:
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line
            End If
        End If

    End Sub

    Private Sub ApplyPointConversionSettings()
        'Apply the Point Conversion settings.

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        Dim SetInputCrsCode As New XElement("SetInputCrsCode", txtInputCrsCode.Text) 'Set the Input Coordinate Reference System code.
        xmessage.Add(SetInputCrsCode)

        Dim SetOutputCrsCode As New XElement("SetOutputCrsCode", txtOutputCrsCode.Text) 'Set the Input Coordinate Reference System code.
        xmessage.Add(SetOutputCrsCode)

        Select Case txtDatumTransType.Text.Trim
            Case "None"
                Dim SetDatumTransType As New XElement("SetDatumTransType", "None") 'Set the Datum Transformation type to None.
                xmessage.Add(SetDatumTransType)

            Case "Direct"
                Dim SetDatumTransType As New XElement("SetDatumTransType", "Direct") 'Set the Datum Transformation type to Direct.
                xmessage.Add(SetDatumTransType)
                Dim SetDirectDatumTransCode As New XElement("SetDirectDatumTransCode", txtDirectDatumTransOpCode.Text)
                xmessage.Add(SetDirectDatumTransCode)
                Dim SetDirectDatumTransApplyRev As New XElement("SetDirectDatumTransApplyRev", txtDirectDatumTransOpApplyRev.Text)
                xmessage.Add(SetDirectDatumTransApplyRev)

            Case "ViaWgs84"
                Dim SetDatumTransType As New XElement("SetDatumTransType", "ViaWgs84") 'Set the Datum Transformation type to Direct.
                xmessage.Add(SetDatumTransType)
                Dim SetInputToWgs84DatumTransCode As New XElement("SetInputToWgs84DatumTransCode", txtDirectDatumTransOpCode.Text)
                xmessage.Add(SetInputToWgs84DatumTransCode)
                Dim SetInputToWgs84DatumTransApplyRev As New XElement("SetInputToWgs84DatumTransApplyRev", txtDirectDatumTransOpApplyRev.Text)
                xmessage.Add(SetInputToWgs84DatumTransApplyRev)
                Dim SetWgs84ToOutputDatumTransCode As New XElement("SetWgs84ToOutputDatumTransCode", txtInputToWgs84DatumTransOpCode.Text)
                xmessage.Add(SetWgs84ToOutputDatumTransCode)
                Dim SetoWgs84ToOutputDatumTransApplyRev As New XElement("SetoWgs84ToOutputDatumTransApplyRev", txtInputToWgs84DatumTransOpApplyRev.Text)
                xmessage.Add(SetoWgs84ToOutputDatumTransApplyRev)

            Case ""
                Message.AddWarning("The datum transformation type has not been selected." & vbCrLf)
            Case Else
                Message.AddWarning("Unknown datum transformation type: " & txtDatumTransType.Text.Trim & vbCrLf)

        End Select

        Dim ShowDmsSymbols As New XElement("ShowDmsSymbols", chkDmsSymbols.Checked)
        xmessage.Add(ShowDmsSymbols)

        doc.Add(xmessage)


        'Send the XMessage to the Coordinates 2 application:
        Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
        Message.XAddXml(doc.ToString)
        Message.XAddText(vbCrLf, "Normal") 'Add extra line

        SendMessageParams.ProjectNetworkName = ProNetName
        SendMessageParams.ConnectionName = "ADVL_Coordinates_2"
        SendMessageParams.Message = doc.ToString
        If bgwSendMessage.IsBusy Then
            Message.AddWarning("ApplyPointConversionSettings: Send Message backgroundworker is busy." & vbCrLf)
        Else
            bgwSendMessage.RunWorkerAsync(SendMessageParams)
        End If

        ''Send the instructions to the Coordinates 2 application:
        'If IsNothing(client) Then
        '    Message.Add("No client connection available!" & vbCrLf)
        'Else
        '    If client.State = ServiceModel.CommunicationState.Faulted Then
        '        Message.Add("client state is faulted. Message not sent!" & vbCrLf)
        '    Else
        '        client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
        '        Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
        '        Message.XAddXml(doc.ToString)
        '        Message.XAddText(vbCrLf, "Normal") 'Add extra line
        '    End If
        'End If
    End Sub

    Private Sub ApplyPointConversionSettings_OLD()
        'Apply the Point Conversion settings.

        'Create the xml instructions:
        Dim decl As New XDeclaration("1.0", "utf-8", "yes")
        Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
        Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

        Dim SetInputCrsCode As New XElement("SetInputCrsCode", txtInputCrsCode.Text) 'Set the Input Coordinate Reference System code.
        xmessage.Add(SetInputCrsCode)

        Dim SetOutputCrsCode As New XElement("SetOutputCrsCode", txtOutputCrsCode.Text) 'Set the Input Coordinate Reference System code.
        xmessage.Add(SetOutputCrsCode)

        Select Case txtDatumTransType.Text.Trim
            Case "None"
                Dim SetDatumTransType As New XElement("SetDatumTransType", "None") 'Set the Datum Transformation type to None.
                xmessage.Add(SetDatumTransType)

            Case "Direct"
                Dim SetDatumTransType As New XElement("SetDatumTransType", "Direct") 'Set the Datum Transformation type to Direct.
                xmessage.Add(SetDatumTransType)
                Dim SetDirectDatumTransCode As New XElement("SetDirectDatumTransCode", txtDirectDatumTransOpCode.Text)
                xmessage.Add(SetDirectDatumTransCode)
                Dim SetDirectDatumTransApplyRev As New XElement("SetDirectDatumTransApplyRev", txtDirectDatumTransOpApplyRev.Text)
                xmessage.Add(SetDirectDatumTransApplyRev)

            Case "ViaWgs84"
                Dim SetDatumTransType As New XElement("SetDatumTransType", "ViaWgs84") 'Set the Datum Transformation type to Direct.
                xmessage.Add(SetDatumTransType)
                Dim SetInputToWgs84DatumTransCode As New XElement("SetInputToWgs84DatumTransCode", txtDirectDatumTransOpCode.Text)
                xmessage.Add(SetInputToWgs84DatumTransCode)
                Dim SetInputToWgs84DatumTransApplyRev As New XElement("SetInputToWgs84DatumTransApplyRev", txtDirectDatumTransOpApplyRev.Text)
                xmessage.Add(SetInputToWgs84DatumTransApplyRev)
                Dim SetWgs84ToOutputDatumTransCode As New XElement("SetWgs84ToOutputDatumTransCode", txtInputToWgs84DatumTransOpCode.Text)
                xmessage.Add(SetWgs84ToOutputDatumTransCode)
                Dim SetoWgs84ToOutputDatumTransApplyRev As New XElement("SetoWgs84ToOutputDatumTransApplyRev", txtInputToWgs84DatumTransOpApplyRev.Text)
                xmessage.Add(SetoWgs84ToOutputDatumTransApplyRev)

            Case ""
                Message.AddWarning("The datum transformation type has not been selected." & vbCrLf)
            Case Else
                Message.AddWarning("Unknown datum transformation type: " & txtDatumTransType.Text.Trim & vbCrLf)

        End Select


        doc.Add(xmessage)

        'Send the instructions to the Coordinates 2 application:
        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                client.SendMessageAsync(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                Message.XAddText("Message sent to [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                Message.XAddXml(doc.ToString)
                Message.XAddText(vbCrLf, "Normal") 'Add extra line
            End If
        End If
    End Sub

    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'ReCalcConversionTable()
        ReCalcConversionTable()
    End Sub

    Private Sub btnRecalculate_Click(sender As Object, e As EventArgs) Handles btnRecalculate.Click
        If ConnectionOK() Then ReCalcConversionTable()
    End Sub

    Private Sub btnNewConvFile_Click(sender As Object, e As EventArgs) Handles btnNewConvFile.Click
        'Create a new Coordinate Conversion file.
        Dim EntryForm As New ADVL_Utilities_Library_1.frmNewDataNameModal
        EntryForm.EntryName = "NewConvFile"
        EntryForm.Title = "New Coordinate Conversion File"
        EntryForm.FileExtension = "CoordConv"
        EntryForm.GetFileName = True
        EntryForm.GetDataName = True
        EntryForm.GetDataLabel = False
        EntryForm.GetDataDescription = True
        EntryForm.SettingsLocn = Project.SettingsLocn
        EntryForm.DataLocn = Project.DataLocn
        EntryForm.ApplicationName = ApplicationInfo.Name
        EntryForm.RestoreFormSettings()

        If EntryForm.ShowDialog() = DialogResult.OK Then
            If txtFileName.Text.Trim = "" Then
                'There is no file to save
            Else
                If Modified Then
                    Dim Result As DialogResult = MessageBox.Show("Do you want to save the changes in the current conversion settings?", "Warning", MessageBoxButtons.YesNoCancel)
                    If Result = DialogResult.Yes Then
                        'SaveDistribModel()
                        SaveCoordConvSettings()
                    ElseIf Result = DialogResult.Cancel Then
                        Exit Sub
                    Else
                        'Contunue without saving the conversion settings.
                        Modified = False
                    End If
                End If
            End If
        End If

        ClearSettings()
        txtFileName.Text = EntryForm.FileName
        txtDataName.Text = EntryForm.DataName
        txtDescription.Text = EntryForm.DataDescription
    End Sub

    Private Sub ClearSettings()
        'Clear the Coordinate Conversion settings.
        dgvConversion.Rows.Clear()
    End Sub

    Private Sub btnSaveConvFile_Click(sender As Object, e As EventArgs) Handles btnSaveConvFile.Click
        SaveCoordConvSettings()
    End Sub

    Private Sub SaveCoordConvSettings()
        'Save the Coordinate Conversion settings.

        Dim FileName As String = txtFileName.Text.Trim

        'Check if a file name has been specified:
        If FileName = "" Then
            Message.AddWarning("Please enter a file name." & vbCrLf)
            Exit Sub
        End If

        'Check the file name extension:
        If LCase(FileName).EndsWith(".coordconv") Then
            FileName = IO.Path.GetFileNameWithoutExtension(FileName) & ".CoordConv"
        ElseIf FileName.Contains(".") Then
            Message.AddWarning("Unknown file extension: " & IO.Path.GetExtension(FileName) & vbCrLf)
            Exit Sub
        Else
            FileName = FileName & ".CoordConv"
        End If

        txtFileName.Text = FileName

        dgvConversion.AllowUserToAddRows = False

        'Datum Transformation:
        Dim EntryCoordType As String
        If rbEnterInputEastNorth.Checked Then
            EntryCoordType = "Projected"
        ElseIf rbEnterInputLongLat.Checked Then
            EntryCoordType = "Geographic"
        ElseIf rbEnterInputXYZ.Checked Then
            EntryCoordType = "Cartesian"
        Else
            EntryCoordType = "Geographic"
        End If

        Dim settingsData = <?xml version="1.0" encoding="utf-8"?>
                           <!---->
                           <CoordinateConversionSettings>
                               <SettingsName><%= txtDataName.Text %></SettingsName>
                               <SettingsDescription><%= txtDescription.Text %></SettingsDescription>
                               <!--Other Settings-->
                               <SelectedTabIndex><%= TabControl1.SelectedIndex %></SelectedTabIndex>
                               <CoordinatesTabIndex><%= TabControl2.SelectedIndex %></CoordinatesTabIndex>
                               <DatumTransTabIndex><%= TabControl3.SelectedIndex %></DatumTransTabIndex>
                               <ViaWgs84TabIndex><%= TabControl4.SelectedIndex %></ViaWgs84TabIndex>
                               <!--CRS Settings-->
                               <InputCrsName><%= txtInputCrsName.Text.Trim %></InputCrsName>
                               <InputCrsCode><%= txtInputCrsCode.Text %></InputCrsCode>
                               <InputCrsKind><%= txtInputCrsKind.Text.Trim %></InputCrsKind>
                               <OutputCrsName><%= txtOutputCrsName.Text.Trim %></OutputCrsName>
                               <OutputCrsCode><%= txtOutputCrsCode.Text.Trim %></OutputCrsCode>
                               <OutputCrsKind><%= txtOutputCrsKind.Text %></OutputCrsKind>
                               <!--Datum Transformation Settings-->
                               <DatumTransType><%= txtDatumTransType.Text.Trim %></DatumTransType>
                               <DirectDatumTransOpName><%= txtDirectDatumTransOpName.Text.Trim %></DirectDatumTransOpName>
                               <DirectDatumTransOpCode><%= txtDirectDatumTransOpCode.Text.Trim %></DirectDatumTransOpCode>
                               <DirectDatumTransOpApplyRev><%= txtDirectDatumTransOpApplyRev.Text.Trim %></DirectDatumTransOpApplyRev>
                               <InputToWgs84DatumTransOpName><%= txtInputToWgs84DatumTransOpName.Text.Trim %></InputToWgs84DatumTransOpName>
                               <InputToWgs84DatumTransOpCode><%= txtInputToWgs84DatumTransOpCode.Text.Trim %></InputToWgs84DatumTransOpCode>
                               <InputToWgs84DatumTransOpApplyRev><%= txtInputToWgs84DatumTransOpApplyRev.Text.Trim %></InputToWgs84DatumTransOpApplyRev>
                               <Wgs84ToOutputDatumTransOpName><%= txtWgs84ToOutputDatumTransOpName.Text.Trim %></Wgs84ToOutputDatumTransOpName>
                               <Wgs84ToOutputDatumTransOpCode><%= txtWgs84ToOutputDatumTransOpCode.Text.Trim %></Wgs84ToOutputDatumTransOpCode>
                               <Wgs84ToOutputDatumTransOpApplyRev><%= txtWgs84ToOutputDatumTransOpApplyRev.Text.Trim %></Wgs84ToOutputDatumTransOpApplyRev>
                               <!--Display Settings-->
                               <EntryCoordType><%= EntryCoordType %></EntryCoordType>
                               <ShowInputEastingNorthing><%= chkShowInputEastNorth.Checked %></ShowInputEastingNorthing>
                               <ShowInputLongitudeLatitude><%= chkShowInputLongLat.Checked %></ShowInputLongitudeLatitude>
                               <ShowInputXYS><%= chkShowInputXYZ.Checked %></ShowInputXYS>
                               <ShowWgs84XYZ><%= chkShowWgs84XYZ.Checked %></ShowWgs84XYZ>
                               <ShowOutputEastingNorthing><%= chkShowOutputEastNorth.Checked %></ShowOutputEastingNorthing>
                               <ShowOutputLongitudeLatitude><%= chkShowOutputLongLat.Checked %></ShowOutputLongitudeLatitude>
                               <ShowOutputXYZ><%= chkShowOutputXYZ.Checked %></ShowOutputXYZ>
                               <ShowPointNumber><%= chkShowPointNumber.Checked %></ShowPointNumber>
                               <ShowPointName><%= chkShowPointName.Checked %></ShowPointName>
                               <ShowPointDescription><%= chkShowPointDescription.Checked %></ShowPointDescription>
                               <ProjectedFormat><%= txtProjFormat.Text %></ProjectedFormat>
                               <CartesianFormat><%= txtCartFormat.Text %></CartesianFormat>
                               <ShowDegMinSec><%= rbDMS.Checked %></ShowDegMinSec>
                               <ShowDegMinSecSymbols><%= chkDmsSymbols.Checked %></ShowDegMinSecSymbols>
                               <DecDegreesDecPlaces><%= txtDegreeDecPlaces.Text %></DecDegreesDecPlaces>
                               <DmsSecondsDecPlaces><%= txtSecondsDecPlaces.Text %></DmsSecondsDecPlaces>
                               <HeightFormat><%= txtHeightFormat.Text %></HeightFormat>
                               <!--Save the Datum Transformation Input Points-->
                               <%= DatumTransInputData(EntryCoordType).<DatumTransInputData> %>
                           </CoordinateConversionSettings>

        Project.SaveXmlSettings(FileName, settingsData)

        dgvConversion.AllowUserToAddRows = True

    End Sub

    Private Sub btnOpenConvFile_Click(sender As Object, e As EventArgs) Handles btnOpenConvFile.Click
        'Open a Coordinate Conversion settings file.

        Dim FileName As String = Project.SelectDataFile("Coordinate Conversion files", "CoordConv")
        If FileName = "" Then
            'No file has been selected.
        Else
            OpenCoordConvSettings(FileName)
        End If
    End Sub

    Private Sub OpenCoordConvSettings(FileName As String)
        'Open the Coordinate Conversion settings file named FileName.

        ClearSettings()
        Dim Settings As System.Xml.Linq.XDocument
        Project.ReadXmlData(FileName, Settings)

        If IsNothing(Settings) Then 'There is no Settings XML data.
            Exit Sub
        End If

        txtFileName.Text = FileName

        If Settings.<CoordinateConversionSettings>.<SettingsName>.Value <> Nothing Then txtDataName.Text = Settings.<CoordinateConversionSettings>.<SettingsName>.Value
        If Settings.<CoordinateConversionSettings>.<SettingsDescription>.Value <> Nothing Then txtDescription.Text = Settings.<CoordinateConversionSettings>.<SettingsDescription>.Value

        'Add code to read other saved setting here:
        If Settings.<CoordinateConversionSettings>.<SelectedTabIndex>.Value <> Nothing Then TabControl1.SelectedIndex = Settings.<CoordinateConversionSettings>.<SelectedTabIndex>.Value
        If Settings.<CoordinateConversionSettings>.<CoordinatesTabIndex>.Value <> Nothing Then TabControl2.SelectedIndex = Settings.<CoordinateConversionSettings>.<CoordinatesTabIndex>.Value
        If Settings.<CoordinateConversionSettings>.<DatumTransTabIndex>.Value <> Nothing Then TabControl3.SelectedIndex = Settings.<CoordinateConversionSettings>.<DatumTransTabIndex>.Value
        If Settings.<CoordinateConversionSettings>.<ViaWgs84TabIndex>.Value <> Nothing Then TabControl4.SelectedIndex = Settings.<CoordinateConversionSettings>.<ViaWgs84TabIndex>.Value


        If Settings.<CoordinateConversionSettings>.<InputCrsName>.Value <> Nothing Then txtInputCrsName.Text = Settings.<CoordinateConversionSettings>.<InputCrsName>.Value
        If Settings.<CoordinateConversionSettings>.<InputCrsCode>.Value <> Nothing Then txtInputCrsCode.Text = Settings.<CoordinateConversionSettings>.<InputCrsCode>.Value
        If Settings.<CoordinateConversionSettings>.<InputCrsKind>.Value <> Nothing Then txtInputCrsKind.Text = Settings.<CoordinateConversionSettings>.<InputCrsKind>.Value
        If Settings.<CoordinateConversionSettings>.<OutputCrsName>.Value <> Nothing Then txtOutputCrsName.Text = Settings.<CoordinateConversionSettings>.<OutputCrsName>.Value
        If Settings.<CoordinateConversionSettings>.<OutputCrsCode>.Value <> Nothing Then txtOutputCrsCode.Text = Settings.<CoordinateConversionSettings>.<OutputCrsCode>.Value
        If Settings.<CoordinateConversionSettings>.<OutputCrsKind>.Value <> Nothing Then txtOutputCrsKind.Text = Settings.<CoordinateConversionSettings>.<OutputCrsKind>.Value


        If Settings.<CoordinateConversionSettings>.<DatumTransType>.Value <> Nothing Then txtDatumTransType.Text = Settings.<CoordinateConversionSettings>.<DatumTransType>.Value
        If Settings.<CoordinateConversionSettings>.<DirectDatumTransOpName>.Value <> Nothing Then txtDirectDatumTransOpName.Text = Settings.<CoordinateConversionSettings>.<DirectDatumTransOpName>.Value
        If Settings.<CoordinateConversionSettings>.<DirectDatumTransOpCode>.Value <> Nothing Then txtDirectDatumTransOpCode.Text = Settings.<CoordinateConversionSettings>.<DirectDatumTransOpCode>.Value
        If Settings.<CoordinateConversionSettings>.<DirectDatumTransOpApplyRev>.Value <> Nothing Then txtDirectDatumTransOpApplyRev.Text = Settings.<CoordinateConversionSettings>.<DirectDatumTransOpApplyRev>.Value
        If Settings.<CoordinateConversionSettings>.<InputToWgs84DatumTransOpName>.Value <> Nothing Then txtInputToWgs84DatumTransOpName.Text = Settings.<CoordinateConversionSettings>.<InputToWgs84DatumTransOpName>.Value
        If Settings.<CoordinateConversionSettings>.<InputToWgs84DatumTransOpCode>.Value <> Nothing Then txtInputToWgs84DatumTransOpCode.Text = Settings.<CoordinateConversionSettings>.<InputToWgs84DatumTransOpCode>.Value
        If Settings.<CoordinateConversionSettings>.<InputToWgs84DatumTransOpApplyRev>.Value <> Nothing Then txtInputToWgs84DatumTransOpApplyRev.Text = Settings.<CoordinateConversionSettings>.<InputToWgs84DatumTransOpApplyRev>.Value
        If Settings.<CoordinateConversionSettings>.<Wgs84ToOutputDatumTransOpName>.Value <> Nothing Then txtWgs84ToOutputDatumTransOpName.Text = Settings.<CoordinateConversionSettings>.<Wgs84ToOutputDatumTransOpName>.Value
        If Settings.<CoordinateConversionSettings>.<Wgs84ToOutputDatumTransOpCode>.Value <> Nothing Then txtWgs84ToOutputDatumTransOpCode.Text = Settings.<CoordinateConversionSettings>.<Wgs84ToOutputDatumTransOpCode>.Value
        If Settings.<CoordinateConversionSettings>.<Wgs84ToOutputDatumTransOpApplyRev>.Value <> Nothing Then txtWgs84ToOutputDatumTransOpApplyRev.Text = Settings.<CoordinateConversionSettings>.<Wgs84ToOutputDatumTransOpApplyRev>.Value

        Dim EntryCoordType As String
        If Settings.<CoordinateConversionSettings>.<EntryCoordType>.Value <> Nothing Then
            EntryCoordType = Settings.<CoordinateConversionSettings>.<EntryCoordType>.Value
            Select Case EntryCoordType
                Case "Projected"
                    rbEnterInputEastNorth.Checked = True
                Case "Geographic"
                    rbEnterInputLongLat.Checked = True
                Case "Cartesian"
                    rbEnterInputXYZ.Checked = True
            End Select
        End If
        If Settings.<CoordinateConversionSettings>.<ShowPointNumber>.Value <> Nothing Then chkShowPointNumber.Checked = Settings.<CoordinateConversionSettings>.<ShowPointNumber>.Value
        If Settings.<CoordinateConversionSettings>.<ShowPointName>.Value <> Nothing Then chkShowPointName.Checked = Settings.<CoordinateConversionSettings>.<ShowPointName>.Value
        If Settings.<CoordinateConversionSettings>.<ShowPointDescription>.Value <> Nothing Then chkShowPointDescription.Checked = Settings.<CoordinateConversionSettings>.<ShowPointDescription>.Value
        If Settings.<CoordinateConversionSettings>.<ShowInputEastingNorthing>.Value <> Nothing Then chkShowInputEastNorth.Checked = Settings.<CoordinateConversionSettings>.<ShowInputEastingNorthing>.Value
        If Settings.<CoordinateConversionSettings>.<ShowInputLongitudeLatitude>.Value <> Nothing Then chkShowInputLongLat.Checked = Settings.<CoordinateConversionSettings>.<ShowInputLongitudeLatitude>.Value
        If Settings.<CoordinateConversionSettings>.<ShowInputXYS>.Value <> Nothing Then chkShowInputXYZ.Checked = Settings.<CoordinateConversionSettings>.<ShowInputXYS>.Value
        If Settings.<CoordinateConversionSettings>.<ShowWgs84XYZ>.Value <> Nothing Then chkShowWgs84XYZ.Checked = Settings.<CoordinateConversionSettings>.<ShowWgs84XYZ>.Value
        If Settings.<CoordinateConversionSettings>.<ShowOutputEastingNorthing>.Value <> Nothing Then chkShowOutputEastNorth.Checked = Settings.<CoordinateConversionSettings>.<ShowOutputEastingNorthing>.Value
        If Settings.<CoordinateConversionSettings>.<ShowOutputLongitudeLatitude>.Value <> Nothing Then chkShowOutputLongLat.Checked = Settings.<CoordinateConversionSettings>.<ShowOutputLongitudeLatitude>.Value
        If Settings.<CoordinateConversionSettings>.<ShowOutputXYZ>.Value <> Nothing Then chkShowOutputXYZ.Checked = Settings.<CoordinateConversionSettings>.<ShowOutputXYZ>.Value
        If Settings.<CoordinateConversionSettings>.<ProjectedFormat>.Value <> Nothing Then txtProjFormat.Text = Settings.<CoordinateConversionSettings>.<ProjectedFormat>.Value
        If Settings.<CoordinateConversionSettings>.<CartesianFormat>.Value <> Nothing Then txtCartFormat.Text = Settings.<CoordinateConversionSettings>.<CartesianFormat>.Value
        If Settings.<CoordinateConversionSettings>.<DecDegreesDecPlaces>.Value <> Nothing Then
            txtDegreeDecPlaces.Text = Settings.<CoordinateConversionSettings>.<DecDegreesDecPlaces>.Value
            If rbDecDegrees.Checked Then
                Try
                    txtDegreeDecPlaces.Text = Int(txtDegreeDecPlaces.Text.Trim)
                    Dim Format As String = "F" & txtDegreeDecPlaces.Text.Trim
                    dgvConversion.Columns(5).DefaultCellStyle.Format = Format
                    dgvConversion.Columns(6).DefaultCellStyle.Format = Format
                    dgvConversion.Columns(17).DefaultCellStyle.Format = Format
                    dgvConversion.Columns(18).DefaultCellStyle.Format = Format
                Catch ex As Exception

                End Try
            End If
        End If
        If Settings.<CoordinateConversionSettings>.<DmsSecondsDecPlaces>.Value <> Nothing Then
            txtSecondsDecPlaces.Text = Settings.<CoordinateConversionSettings>.<DmsSecondsDecPlaces>.Value
            'Conversion.InputCrs.Coord.DegMinSecDecimalPlaces = txtSecondsDecPlaces.Text
            'Conversion.OutputCrs.Coord.DegMinSecDecimalPlaces = txtSecondsDecPlaces.Text
        End If
        If Settings.<CoordinateConversionSettings>.<HeightFormat>.Value <> Nothing Then
            txtHeightFormat.Text = Settings.<CoordinateConversionSettings>.<HeightFormat>.Value
        End If

        If Settings.<CoordinateConversionSettings>.<ShowDegMinSec>.Value <> Nothing Then rbDMS.Checked = Settings.<CoordinateConversionSettings>.<ShowDegMinSec>.Value
        If Settings.<CoordinateConversionSettings>.<ShowDegMinSecSymbols>.Value <> Nothing Then chkDmsSymbols.Checked = Settings.<CoordinateConversionSettings>.<ShowDegMinSecSymbols>.Value
        If EntryCoordType = "Projected" Then
            Dim RowNo As Integer
            If Settings.<CoordinateConversionSettings>.<DatumTransInputData>.Value <> Nothing Then
                Dim InputPoints = From Item In Settings.<CoordinateConversionSettings>.<DatumTransInputData>.<Row>
                For Each Item In InputPoints
                    RowNo = dgvConversion.Rows.Add()
                    If Item.<PointNumber>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(0).Value = Item.<PointNumber>.Value
                    If Item.<PointName>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(1).Value = Item.<PointName>.Value
                    If Item.<PointDescription>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(2).Value = Item.<PointDescription>.Value
                    dgvConversion.Rows(RowNo).Cells(3).Value = Item.<Easting>.Value
                    dgvConversion.Rows(RowNo).Cells(4).Value = Item.<Northing>.Value
                Next
            End If

        ElseIf EntryCoordType = "Geographic" Then

            Dim RowNo As Integer

            If Settings.<CoordinateConversionSettings>.<DatumTransInputData>.Value <> Nothing Then
                Dim InputPoints = From Item In Settings.<CoordinateConversionSettings>.<DatumTransInputData>.<Row>
                For Each Item In InputPoints
                    RowNo = dgvConversion.Rows.Add()
                    If Item.<PointNumber>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(0).Value = Item.<PointNumber>.Value
                    If Item.<PointName>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(1).Value = Item.<PointName>.Value
                    If Item.<PointDescription>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(2).Value = Item.<PointDescription>.Value
                    dgvConversion.Rows(RowNo).Cells(5).Value = Item.<Longitude>.Value
                    dgvConversion.Rows(RowNo).Cells(6).Value = Item.<Latitude>.Value
                    dgvConversion.Rows(RowNo).Cells(7).Value = Item.<Height>.Value
                Next
            End If

        ElseIf EntryCoordType = "Cartesian" Then
            Dim RowNo As Integer
            If Settings.<CoordinateConversionSettings>.<DatumTransInputData>.Value <> Nothing Then
                Dim InputPoints = From Item In Settings.<CoordinateConversionSettings>.<DatumTransInputData>.<Row>
                For Each Item In InputPoints
                    RowNo = dgvConversion.Rows.Add()
                    If Item.<PointNumber>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(0).Value = Item.<PointNumber>.Value
                    If Item.<PointName>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(1).Value = Item.<PointName>.Value
                    If Item.<PointDescription>.Value <> Nothing Then dgvConversion.Rows(RowNo).Cells(2).Value = Item.<PointDescription>.Value
                    dgvConversion.Rows(RowNo).Cells(8).Value = Item.<X>.Value
                    dgvConversion.Rows(RowNo).Cells(9).Value = Item.<Y>.Value
                    dgvConversion.Rows(RowNo).Cells(10).Value = Item.<Z>.Value
                Next
            End If

        End If

        ApplyCoordinateFormats()

        UpdateConversionTable()

        ReCalcConversionTable()

        ApplyPointConversionSettings()
        'ReCalcConversionTable()

        dgvConversion.AutoResizeColumns()

        Modified = False

    End Sub

    Private Sub btnCheckConnection_Click(sender As Object, e As EventArgs) Handles btnCheckConnection.Click
        'Check if the coonection ADVL_Coordinates_2 exists.

        If IsNothing(client) Then
            Message.Add("No client connection available!" & vbCrLf)
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Message.Add("client state is faulted. Message not sent!" & vbCrLf)
            Else
                If client.ConnectionExists("", "ADVL_Coordinates_2") Then
                    Message.Add("Connection found: [" & ProNetName & "]." & "ADVL_Coordinates_2" & vbCrLf)
                Else
                    Message.Add("Connection not found: [" & ProNetName & "]." & "ADVL_Coordinates_2" & vbCrLf)
                End If

            End If
        End If
    End Sub

    Private Function ConnectionOK() As Boolean
        'If the [].ADVL_Coordinates_2 connection exists then return True, Else return False.
        If IsNothing(client) Then
            Return False
        Else
            If client.State = ServiceModel.CommunicationState.Faulted Then
                Return False
            Else
                If client.ConnectionExists("", "ADVL_Coordinates_2") Then
                    Return True
                Else
                    Return False
                End If
            End If
        End If
    End Function

    Private Sub btnApplyConvSettings_Click(sender As Object, e As EventArgs) Handles btnApplyConvSettings.Click
        'Apply the coordinate conversion settings.
        If ConnectionOK() Then
            ApplyPointConversionSettings()
        Else
            Message.AddWarning("Please start the Coordinates 2 server." & vbCrLf)
        End If
    End Sub

    Private Sub btnCloseCoordsServer_Click(sender As Object, e As EventArgs) Handles btnCloseCoordsServer.Click
        'Close the Coordinates 2 Server
        If ConnectionOK() Then
            If IsNothing(client) Then
                Message.Add("No client connection available!" & vbCrLf)
            Else
                If client.State = ServiceModel.CommunicationState.Faulted Then
                    Message.Add("client state is faulted. Message not sent!" & vbCrLf)
                Else
                    'Create the XML instructions to close the application at the connection.
                    Dim decl As New XDeclaration("1.0", "utf-8", "yes")
                    Dim doc As New XDocument(decl, Nothing) 'Create an XDocument to store the instructions.
                    Dim xmessage As New XElement("XMsg") 'This indicates the start of the message in the XMessage class

                    Dim command As New XElement("Command", "Close")
                    xmessage.Add(command)
                    doc.Add(xmessage)

                    'Show the message sent to AppNet:
                    Message.XAddText("Message sent to: [" & ProNetName & "]." & "ADVL_Coordinates_2" & ":" & vbCrLf, "XmlSentNotice")
                    Message.XAddXml(doc.ToString)
                    Message.XAddText(vbCrLf, "Normal") 'Add extra line

                    client.SendMessage(ProNetName, "ADVL_Coordinates_2", doc.ToString)
                End If
            End If

        Else

        End If

    End Sub

#End Region 'Form Methods ---------------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Form Events - Events raised by this form." '=========================================================================================================================================

#End Region 'Form Events ----------------------------------------------------------------------------------------------------------------------------------------------------------------------


#Region " Form Classes - Other classes used by this form." '===================================================================================================================================

    Public Class clsSendMessageParams
        'Parameters used when sending a message using the Message Service.
        Public ProjectNetworkName As String
        Public ConnectionName As String
        Public Message As String
    End Class

    Public Class clsInstructionParams
        'Parameters used when executing an instruction.
        Public Info As String 'The information in an instruction.
        Public Locn As String 'The location to send the information.
    End Class

    Public Class crsInfo 'Coordinate reference system information.
        Property Name As String 'The name of the coordinate reference system
        Property Code As Integer 'The EPSG code of the coordinate reference system
        Property Kind As String 'The kind of the coordinate reference system
    End Class







































#End Region 'Form Classes ---------------------------------------------------------------------------------------------------------------------------------------------------------------------


End Class


