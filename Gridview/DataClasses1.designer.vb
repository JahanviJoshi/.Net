'------------------------------------------------------------------------------
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

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="College")>  _
Partial Public Class DataClasses1DataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("CollegeConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Products() As System.Data.Linq.Table(Of Product)
		Get
			Return Me.GetTable(Of Product)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Product")>  _
Partial Public Class Product
	
	Private _ID As System.Nullable(Of Decimal)
	
	Private _PName As String
	
	Private _PPrice As System.Nullable(Of Decimal)
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", DbType:="Decimal(18,0)")>  _
	Public Property ID() As System.Nullable(Of Decimal)
		Get
			Return Me._ID
		End Get
		Set
			If (Me._ID.Equals(value) = false) Then
				Me._ID = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PName", DbType:="VarChar(50)")>  _
	Public Property PName() As String
		Get
			Return Me._PName
		End Get
		Set
			If (String.Equals(Me._PName, value) = false) Then
				Me._PName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PPrice", DbType:="Decimal(18,0)")>  _
	Public Property PPrice() As System.Nullable(Of Decimal)
		Get
			Return Me._PPrice
		End Get
		Set
			If (Me._PPrice.Equals(value) = false) Then
				Me._PPrice = value
			End If
		End Set
	End Property
End Class
