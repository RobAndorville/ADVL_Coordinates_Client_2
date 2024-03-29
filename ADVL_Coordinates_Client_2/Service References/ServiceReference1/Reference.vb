﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Runtime.Serialization

Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Project.Types", [Namespace]:="http://schemas.datacontract.org/2004/07/ADVL_Utilities_Library_1")>  _
    Public Enum ProjectTypes As Integer
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        None = 0
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        Directory = 1
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        Archive = 2
        
        <System.Runtime.Serialization.EnumMemberAttribute()>  _
        Hybrid = 3
    End Enum
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.IMsgService", CallbackContract:=GetType(ServiceReference1.IMsgServiceCallback))>  _
    Public Interface IMsgService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/Connect", ReplyAction:="http://tempuri.org/IMsgService/ConnectResponse")>  _
        Function Connect(ByVal proNetName As String, ByVal appName As String, ByVal connectionName As String, ByVal projectName As String, ByVal projectDescription As String, ByVal projectType As ServiceReference1.ProjectTypes, ByVal projectPath As String, ByVal getAllWarnings As Boolean, ByVal getAllMessages As Boolean) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/Connect", ReplyAction:="http://tempuri.org/IMsgService/ConnectResponse")>  _
        Function ConnectAsync(ByVal proNetName As String, ByVal appName As String, ByVal connectionName As String, ByVal projectName As String, ByVal projectDescription As String, ByVal projectType As ServiceReference1.ProjectTypes, ByVal projectPath As String, ByVal getAllWarnings As Boolean, ByVal getAllMessages As Boolean) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ConnectionAvailable", ReplyAction:="http://tempuri.org/IMsgService/ConnectionAvailableResponse")>  _
        Function ConnectionAvailable(ByVal ProNetName As String, ByVal ConnName As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ConnectionAvailable", ReplyAction:="http://tempuri.org/IMsgService/ConnectionAvailableResponse")>  _
        Function ConnectionAvailableAsync(ByVal ProNetName As String, ByVal ConnName As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ConnectionExists", ReplyAction:="http://tempuri.org/IMsgService/ConnectionExistsResponse")>  _
        Function ConnectionExists(ByVal ProNetName As String, ByVal ConnName As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ConnectionExists", ReplyAction:="http://tempuri.org/IMsgService/ConnectionExistsResponse")>  _
        Function ConnectionExistsAsync(ByVal ProNetName As String, ByVal ConnName As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/SendMessage", ReplyAction:="http://tempuri.org/IMsgService/SendMessageResponse")>  _
        Sub SendMessage(ByVal proNetName As String, ByVal connName As String, ByVal message As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/SendMessage", ReplyAction:="http://tempuri.org/IMsgService/SendMessageResponse")>  _
        Function SendMessageAsync(ByVal proNetName As String, ByVal connName As String, ByVal message As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/CheckConnection", ReplyAction:="http://tempuri.org/IMsgService/CheckConnectionResponse")>  _
        Function CheckConnection(ByVal proNetName As String, ByVal connName As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/CheckConnection", ReplyAction:="http://tempuri.org/IMsgService/CheckConnectionResponse")>  _
        Function CheckConnectionAsync(ByVal proNetName As String, ByVal connName As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/SendAllMessage", ReplyAction:="http://tempuri.org/IMsgService/SendAllMessageResponse")>  _
        Sub SendAllMessage(ByVal message As String, ByVal SenderName As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/SendAllMessage", ReplyAction:="http://tempuri.org/IMsgService/SendAllMessageResponse")>  _
        Function SendAllMessageAsync(ByVal message As String, ByVal SenderName As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/SendMainNodeMessage", ReplyAction:="http://tempuri.org/IMsgService/SendMainNodeMessageResponse")>  _
        Sub SendMainNodeMessage(ByVal message As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/SendMainNodeMessage", ReplyAction:="http://tempuri.org/IMsgService/SendMainNodeMessageResponse")>  _
        Function SendMainNodeMessageAsync(ByVal message As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetConnectionList", ReplyAction:="http://tempuri.org/IMsgService/GetConnectionListResponse")>  _
        Sub GetConnectionList()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetConnectionList", ReplyAction:="http://tempuri.org/IMsgService/GetConnectionListResponse")>  _
        Function GetConnectionListAsync() As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetApplicationList", ReplyAction:="http://tempuri.org/IMsgService/GetApplicationListResponse")>  _
        Sub GetApplicationList(ByVal ClientLocn As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetApplicationList", ReplyAction:="http://tempuri.org/IMsgService/GetApplicationListResponse")>  _
        Function GetApplicationListAsync(ByVal ClientLocn As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetApplicationInfo", ReplyAction:="http://tempuri.org/IMsgService/GetApplicationInfoResponse")>  _
        Sub GetApplicationInfo(ByVal appName As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetApplicationInfo", ReplyAction:="http://tempuri.org/IMsgService/GetApplicationInfoResponse")>  _
        Function GetApplicationInfoAsync(ByVal appName As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetProjectList", ReplyAction:="http://tempuri.org/IMsgService/GetProjectListResponse")>  _
        Sub GetProjectList(ByVal ClientLocn As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetProjectList", ReplyAction:="http://tempuri.org/IMsgService/GetProjectListResponse")>  _
        Function GetProjectListAsync(ByVal ClientLocn As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetAdvlNetworkAppInfo", ReplyAction:="http://tempuri.org/IMsgService/GetAdvlNetworkAppInfoResponse")>  _
        Sub GetAdvlNetworkAppInfo()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/GetAdvlNetworkAppInfo", ReplyAction:="http://tempuri.org/IMsgService/GetAdvlNetworkAppInfoResponse")>  _
        Function GetAdvlNetworkAppInfoAsync() As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/Disconnect", ReplyAction:="http://tempuri.org/IMsgService/DisconnectResponse")>  _
        Function Disconnect(ByVal proNetName As String, ByVal connName As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/Disconnect", ReplyAction:="http://tempuri.org/IMsgService/DisconnectResponse")>  _
        Function DisconnectAsync(ByVal proNetName As String, ByVal connName As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/IsAlive", ReplyAction:="http://tempuri.org/IMsgService/IsAliveResponse")>  _
        Function IsAlive() As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/IsAlive", ReplyAction:="http://tempuri.org/IMsgService/IsAliveResponse")>  _
        Function IsAliveAsync() As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ProNetNameUsed", ReplyAction:="http://tempuri.org/IMsgService/ProNetNameUsedResponse")>  _
        Function ProNetNameUsed(ByVal ProNetName As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ProNetNameUsed", ReplyAction:="http://tempuri.org/IMsgService/ProNetNameUsedResponse")>  _
        Function ProNetNameUsedAsync(ByVal ProNetName As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/StartProjectAtPath", ReplyAction:="http://tempuri.org/IMsgService/StartProjectAtPathResponse")>  _
        Sub StartProjectAtPath(ByVal ProjectPath As String, ByVal ConnectionName As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/StartProjectAtPath", ReplyAction:="http://tempuri.org/IMsgService/StartProjectAtPathResponse")>  _
        Function StartProjectAtPathAsync(ByVal ProjectPath As String, ByVal ConnectionName As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/StartProjectWithName", ReplyAction:="http://tempuri.org/IMsgService/StartProjectWithNameResponse")>  _
        Sub StartProjectWithName(ByVal ProjectName As String, ByVal ProNetName As String, ByVal AppName As String, ByVal ConnectionName As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/StartProjectWithName", ReplyAction:="http://tempuri.org/IMsgService/StartProjectWithNameResponse")>  _
        Function StartProjectWithNameAsync(ByVal ProjectName As String, ByVal ProNetName As String, ByVal AppName As String, ByVal ConnectionName As String) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ProjectOpen", ReplyAction:="http://tempuri.org/IMsgService/ProjectOpenResponse")>  _
        Function ProjectOpen(ByVal ProjectPath As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ProjectOpen", ReplyAction:="http://tempuri.org/IMsgService/ProjectOpenResponse")>  _
        Function ProjectOpenAsync(ByVal ProjectPath As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ConnNameFromProjPath", ReplyAction:="http://tempuri.org/IMsgService/ConnNameFromProjPathResponse")>  _
        Function ConnNameFromProjPath(ByVal ProjectPath As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ConnNameFromProjPath", ReplyAction:="http://tempuri.org/IMsgService/ConnNameFromProjPathResponse")>  _
        Function ConnNameFromProjPathAsync(ByVal ProjectPath As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ConnNameFromProjName", ReplyAction:="http://tempuri.org/IMsgService/ConnNameFromProjNameResponse")>  _
        Function ConnNameFromProjName(ByVal ProjectName As String, ByVal ProNetName As String, ByVal AppName As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IMsgService/ConnNameFromProjName", ReplyAction:="http://tempuri.org/IMsgService/ConnNameFromProjNameResponse")>  _
        Function ConnNameFromProjNameAsync(ByVal ProjectName As String, ByVal ProNetName As String, ByVal AppName As String) As System.Threading.Tasks.Task(Of String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IMsgServiceCallback
        
        <System.ServiceModel.OperationContractAttribute(IsOneWay:=true, Action:="http://tempuri.org/IMsgService/OnSendMessage")>  _
        Sub OnSendMessage(ByVal message As String)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IMsgServiceChannel
        Inherits ServiceReference1.IMsgService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class MsgServiceClient
        Inherits System.ServiceModel.DuplexClientBase(Of ServiceReference1.IMsgService)
        Implements ServiceReference1.IMsgService
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext)
            MyBase.New(callbackInstance)
        End Sub
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String)
            MyBase.New(callbackInstance, endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(callbackInstance, endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal callbackInstance As System.ServiceModel.InstanceContext, ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(callbackInstance, binding, remoteAddress)
        End Sub
        
        Public Function Connect(ByVal proNetName As String, ByVal appName As String, ByVal connectionName As String, ByVal projectName As String, ByVal projectDescription As String, ByVal projectType As ServiceReference1.ProjectTypes, ByVal projectPath As String, ByVal getAllWarnings As Boolean, ByVal getAllMessages As Boolean) As String Implements ServiceReference1.IMsgService.Connect
            Return MyBase.Channel.Connect(proNetName, appName, connectionName, projectName, projectDescription, projectType, projectPath, getAllWarnings, getAllMessages)
        End Function
        
        Public Function ConnectAsync(ByVal proNetName As String, ByVal appName As String, ByVal connectionName As String, ByVal projectName As String, ByVal projectDescription As String, ByVal projectType As ServiceReference1.ProjectTypes, ByVal projectPath As String, ByVal getAllWarnings As Boolean, ByVal getAllMessages As Boolean) As System.Threading.Tasks.Task(Of String) Implements ServiceReference1.IMsgService.ConnectAsync
            Return MyBase.Channel.ConnectAsync(proNetName, appName, connectionName, projectName, projectDescription, projectType, projectPath, getAllWarnings, getAllMessages)
        End Function
        
        Public Function ConnectionAvailable(ByVal ProNetName As String, ByVal ConnName As String) As Boolean Implements ServiceReference1.IMsgService.ConnectionAvailable
            Return MyBase.Channel.ConnectionAvailable(ProNetName, ConnName)
        End Function
        
        Public Function ConnectionAvailableAsync(ByVal ProNetName As String, ByVal ConnName As String) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IMsgService.ConnectionAvailableAsync
            Return MyBase.Channel.ConnectionAvailableAsync(ProNetName, ConnName)
        End Function
        
        Public Function ConnectionExists(ByVal ProNetName As String, ByVal ConnName As String) As Boolean Implements ServiceReference1.IMsgService.ConnectionExists
            Return MyBase.Channel.ConnectionExists(ProNetName, ConnName)
        End Function
        
        Public Function ConnectionExistsAsync(ByVal ProNetName As String, ByVal ConnName As String) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IMsgService.ConnectionExistsAsync
            Return MyBase.Channel.ConnectionExistsAsync(ProNetName, ConnName)
        End Function
        
        Public Sub SendMessage(ByVal proNetName As String, ByVal connName As String, ByVal message As String) Implements ServiceReference1.IMsgService.SendMessage
            MyBase.Channel.SendMessage(proNetName, connName, message)
        End Sub
        
        Public Function SendMessageAsync(ByVal proNetName As String, ByVal connName As String, ByVal message As String) As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.SendMessageAsync
            Return MyBase.Channel.SendMessageAsync(proNetName, connName, message)
        End Function
        
        Public Function CheckConnection(ByVal proNetName As String, ByVal connName As String) As String Implements ServiceReference1.IMsgService.CheckConnection
            Return MyBase.Channel.CheckConnection(proNetName, connName)
        End Function
        
        Public Function CheckConnectionAsync(ByVal proNetName As String, ByVal connName As String) As System.Threading.Tasks.Task(Of String) Implements ServiceReference1.IMsgService.CheckConnectionAsync
            Return MyBase.Channel.CheckConnectionAsync(proNetName, connName)
        End Function
        
        Public Sub SendAllMessage(ByVal message As String, ByVal SenderName As String) Implements ServiceReference1.IMsgService.SendAllMessage
            MyBase.Channel.SendAllMessage(message, SenderName)
        End Sub
        
        Public Function SendAllMessageAsync(ByVal message As String, ByVal SenderName As String) As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.SendAllMessageAsync
            Return MyBase.Channel.SendAllMessageAsync(message, SenderName)
        End Function
        
        Public Sub SendMainNodeMessage(ByVal message As String) Implements ServiceReference1.IMsgService.SendMainNodeMessage
            MyBase.Channel.SendMainNodeMessage(message)
        End Sub
        
        Public Function SendMainNodeMessageAsync(ByVal message As String) As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.SendMainNodeMessageAsync
            Return MyBase.Channel.SendMainNodeMessageAsync(message)
        End Function
        
        Public Sub GetConnectionList() Implements ServiceReference1.IMsgService.GetConnectionList
            MyBase.Channel.GetConnectionList
        End Sub
        
        Public Function GetConnectionListAsync() As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.GetConnectionListAsync
            Return MyBase.Channel.GetConnectionListAsync
        End Function
        
        Public Sub GetApplicationList(ByVal ClientLocn As String) Implements ServiceReference1.IMsgService.GetApplicationList
            MyBase.Channel.GetApplicationList(ClientLocn)
        End Sub
        
        Public Function GetApplicationListAsync(ByVal ClientLocn As String) As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.GetApplicationListAsync
            Return MyBase.Channel.GetApplicationListAsync(ClientLocn)
        End Function
        
        Public Sub GetApplicationInfo(ByVal appName As String) Implements ServiceReference1.IMsgService.GetApplicationInfo
            MyBase.Channel.GetApplicationInfo(appName)
        End Sub
        
        Public Function GetApplicationInfoAsync(ByVal appName As String) As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.GetApplicationInfoAsync
            Return MyBase.Channel.GetApplicationInfoAsync(appName)
        End Function
        
        Public Sub GetProjectList(ByVal ClientLocn As String) Implements ServiceReference1.IMsgService.GetProjectList
            MyBase.Channel.GetProjectList(ClientLocn)
        End Sub
        
        Public Function GetProjectListAsync(ByVal ClientLocn As String) As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.GetProjectListAsync
            Return MyBase.Channel.GetProjectListAsync(ClientLocn)
        End Function
        
        Public Sub GetAdvlNetworkAppInfo() Implements ServiceReference1.IMsgService.GetAdvlNetworkAppInfo
            MyBase.Channel.GetAdvlNetworkAppInfo
        End Sub
        
        Public Function GetAdvlNetworkAppInfoAsync() As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.GetAdvlNetworkAppInfoAsync
            Return MyBase.Channel.GetAdvlNetworkAppInfoAsync
        End Function
        
        Public Function Disconnect(ByVal proNetName As String, ByVal connName As String) As Boolean Implements ServiceReference1.IMsgService.Disconnect
            Return MyBase.Channel.Disconnect(proNetName, connName)
        End Function
        
        Public Function DisconnectAsync(ByVal proNetName As String, ByVal connName As String) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IMsgService.DisconnectAsync
            Return MyBase.Channel.DisconnectAsync(proNetName, connName)
        End Function
        
        Public Function IsAlive() As Boolean Implements ServiceReference1.IMsgService.IsAlive
            Return MyBase.Channel.IsAlive
        End Function
        
        Public Function IsAliveAsync() As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IMsgService.IsAliveAsync
            Return MyBase.Channel.IsAliveAsync
        End Function
        
        Public Function ProNetNameUsed(ByVal ProNetName As String) As Boolean Implements ServiceReference1.IMsgService.ProNetNameUsed
            Return MyBase.Channel.ProNetNameUsed(ProNetName)
        End Function
        
        Public Function ProNetNameUsedAsync(ByVal ProNetName As String) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IMsgService.ProNetNameUsedAsync
            Return MyBase.Channel.ProNetNameUsedAsync(ProNetName)
        End Function
        
        Public Sub StartProjectAtPath(ByVal ProjectPath As String, ByVal ConnectionName As String) Implements ServiceReference1.IMsgService.StartProjectAtPath
            MyBase.Channel.StartProjectAtPath(ProjectPath, ConnectionName)
        End Sub
        
        Public Function StartProjectAtPathAsync(ByVal ProjectPath As String, ByVal ConnectionName As String) As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.StartProjectAtPathAsync
            Return MyBase.Channel.StartProjectAtPathAsync(ProjectPath, ConnectionName)
        End Function
        
        Public Sub StartProjectWithName(ByVal ProjectName As String, ByVal ProNetName As String, ByVal AppName As String, ByVal ConnectionName As String) Implements ServiceReference1.IMsgService.StartProjectWithName
            MyBase.Channel.StartProjectWithName(ProjectName, ProNetName, AppName, ConnectionName)
        End Sub
        
        Public Function StartProjectWithNameAsync(ByVal ProjectName As String, ByVal ProNetName As String, ByVal AppName As String, ByVal ConnectionName As String) As System.Threading.Tasks.Task Implements ServiceReference1.IMsgService.StartProjectWithNameAsync
            Return MyBase.Channel.StartProjectWithNameAsync(ProjectName, ProNetName, AppName, ConnectionName)
        End Function
        
        Public Function ProjectOpen(ByVal ProjectPath As String) As Boolean Implements ServiceReference1.IMsgService.ProjectOpen
            Return MyBase.Channel.ProjectOpen(ProjectPath)
        End Function
        
        Public Function ProjectOpenAsync(ByVal ProjectPath As String) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IMsgService.ProjectOpenAsync
            Return MyBase.Channel.ProjectOpenAsync(ProjectPath)
        End Function
        
        Public Function ConnNameFromProjPath(ByVal ProjectPath As String) As String Implements ServiceReference1.IMsgService.ConnNameFromProjPath
            Return MyBase.Channel.ConnNameFromProjPath(ProjectPath)
        End Function
        
        Public Function ConnNameFromProjPathAsync(ByVal ProjectPath As String) As System.Threading.Tasks.Task(Of String) Implements ServiceReference1.IMsgService.ConnNameFromProjPathAsync
            Return MyBase.Channel.ConnNameFromProjPathAsync(ProjectPath)
        End Function
        
        Public Function ConnNameFromProjName(ByVal ProjectName As String, ByVal ProNetName As String, ByVal AppName As String) As String Implements ServiceReference1.IMsgService.ConnNameFromProjName
            Return MyBase.Channel.ConnNameFromProjName(ProjectName, ProNetName, AppName)
        End Function
        
        Public Function ConnNameFromProjNameAsync(ByVal ProjectName As String, ByVal ProNetName As String, ByVal AppName As String) As System.Threading.Tasks.Task(Of String) Implements ServiceReference1.IMsgService.ConnNameFromProjNameAsync
            Return MyBase.Channel.ConnNameFromProjNameAsync(ProjectName, ProNetName, AppName)
        End Function
    End Class
End Namespace
