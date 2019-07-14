﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
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


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="STUDENTS")>  _
Partial Public Class DataClassesSTUDENTSDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertPERSON(instance As PERSON)
    End Sub
  Partial Private Sub UpdatePERSON(instance As PERSON)
    End Sub
  Partial Private Sub DeletePERSON(instance As PERSON)
    End Sub
  Partial Private Sub InsertTYPE_IDENTITY_DOCUMENT(instance As TYPE_IDENTITY_DOCUMENT)
    End Sub
  Partial Private Sub UpdateTYPE_IDENTITY_DOCUMENT(instance As TYPE_IDENTITY_DOCUMENT)
    End Sub
  Partial Private Sub DeleteTYPE_IDENTITY_DOCUMENT(instance As TYPE_IDENTITY_DOCUMENT)
    End Sub
  Partial Private Sub InsertTYPE_SEX(instance As TYPE_SEX)
    End Sub
  Partial Private Sub UpdateTYPE_SEX(instance As TYPE_SEX)
    End Sub
  Partial Private Sub DeleteTYPE_SEX(instance As TYPE_SEX)
    End Sub
  Partial Private Sub InsertUSER(instance As USER)
    End Sub
  Partial Private Sub UpdateUSER(instance As USER)
    End Sub
  Partial Private Sub DeleteUSER(instance As USER)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.Paso_5_Grupo_3.My.MySettings.Default.STUDENTSConnectionString, mappingSource)
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
	
	Public ReadOnly Property PERSON() As System.Data.Linq.Table(Of PERSON)
		Get
			Return Me.GetTable(Of PERSON)
		End Get
	End Property
	
	Public ReadOnly Property TYPE_IDENTITY_DOCUMENT() As System.Data.Linq.Table(Of TYPE_IDENTITY_DOCUMENT)
		Get
			Return Me.GetTable(Of TYPE_IDENTITY_DOCUMENT)
		End Get
	End Property
	
	Public ReadOnly Property TYPE_SEX() As System.Data.Linq.Table(Of TYPE_SEX)
		Get
			Return Me.GetTable(Of TYPE_SEX)
		End Get
	End Property
	
	Public ReadOnly Property USER() As System.Data.Linq.Table(Of USER)
		Get
			Return Me.GetTable(Of USER)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.PERSON")>  _
Partial Public Class PERSON
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID_PERSON As Integer
	
	Private _IDENTIFICATION_DOCUMENT As String
	
	Private _TYPE_IDENTITY_DOCUMENT As Integer
	
	Private _FIRST_NAME As String
	
	Private _MIDDLE_NAME As String
	
	Private _SURNAME As String
	
	Private _SECOND_SURNAME As String
	
	Private _TELEPHONE As String
	
	Private _ADDRESS As String
	
	Private _TYPE_SEX As Integer
	
	Private _TYPE_IDENTITY_DOCUMENT1 As EntityRef(Of TYPE_IDENTITY_DOCUMENT)
	
	Private _TYPE_SEX1 As EntityRef(Of TYPE_SEX)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnID_PERSONChanging(value As Integer)
    End Sub
    Partial Private Sub OnID_PERSONChanged()
    End Sub
    Partial Private Sub OnIDENTIFICATION_DOCUMENTChanging(value As String)
    End Sub
    Partial Private Sub OnIDENTIFICATION_DOCUMENTChanged()
    End Sub
    Partial Private Sub OnTYPE_IDENTITY_DOCUMENTChanging(value As Integer)
    End Sub
    Partial Private Sub OnTYPE_IDENTITY_DOCUMENTChanged()
    End Sub
    Partial Private Sub OnFIRST_NAMEChanging(value As String)
    End Sub
    Partial Private Sub OnFIRST_NAMEChanged()
    End Sub
    Partial Private Sub OnMIDDLE_NAMEChanging(value As String)
    End Sub
    Partial Private Sub OnMIDDLE_NAMEChanged()
    End Sub
    Partial Private Sub OnSURNAMEChanging(value As String)
    End Sub
    Partial Private Sub OnSURNAMEChanged()
    End Sub
    Partial Private Sub OnSECOND_SURNAMEChanging(value As String)
    End Sub
    Partial Private Sub OnSECOND_SURNAMEChanged()
    End Sub
    Partial Private Sub OnTELEPHONEChanging(value As String)
    End Sub
    Partial Private Sub OnTELEPHONEChanged()
    End Sub
    Partial Private Sub OnADDRESSChanging(value As String)
    End Sub
    Partial Private Sub OnADDRESSChanged()
    End Sub
    Partial Private Sub OnTYPE_SEXChanging(value As Integer)
    End Sub
    Partial Private Sub OnTYPE_SEXChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._TYPE_IDENTITY_DOCUMENT1 = CType(Nothing, EntityRef(Of TYPE_IDENTITY_DOCUMENT))
		Me._TYPE_SEX1 = CType(Nothing, EntityRef(Of TYPE_SEX))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_PERSON", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID_PERSON() As Integer
		Get
			Return Me._ID_PERSON
		End Get
		Set
			If ((Me._ID_PERSON = value)  _
						= false) Then
				Me.OnID_PERSONChanging(value)
				Me.SendPropertyChanging
				Me._ID_PERSON = value
				Me.SendPropertyChanged("ID_PERSON")
				Me.OnID_PERSONChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IDENTIFICATION_DOCUMENT", DbType:="NChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property IDENTIFICATION_DOCUMENT() As String
		Get
			Return Me._IDENTIFICATION_DOCUMENT
		End Get
		Set
			If (String.Equals(Me._IDENTIFICATION_DOCUMENT, value) = false) Then
				Me.OnIDENTIFICATION_DOCUMENTChanging(value)
				Me.SendPropertyChanging
				Me._IDENTIFICATION_DOCUMENT = value
				Me.SendPropertyChanged("IDENTIFICATION_DOCUMENT")
				Me.OnIDENTIFICATION_DOCUMENTChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TYPE_IDENTITY_DOCUMENT", DbType:="Int NOT NULL")>  _
	Public Property TYPE_IDENTITY_DOCUMENT() As Integer
		Get
			Return Me._TYPE_IDENTITY_DOCUMENT
		End Get
		Set
			If ((Me._TYPE_IDENTITY_DOCUMENT = value)  _
						= false) Then
				If Me._TYPE_IDENTITY_DOCUMENT1.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnTYPE_IDENTITY_DOCUMENTChanging(value)
				Me.SendPropertyChanging
				Me._TYPE_IDENTITY_DOCUMENT = value
				Me.SendPropertyChanged("TYPE_IDENTITY_DOCUMENT")
				Me.OnTYPE_IDENTITY_DOCUMENTChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FIRST_NAME", DbType:="NChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property FIRST_NAME() As String
		Get
			Return Me._FIRST_NAME
		End Get
		Set
			If (String.Equals(Me._FIRST_NAME, value) = false) Then
				Me.OnFIRST_NAMEChanging(value)
				Me.SendPropertyChanging
				Me._FIRST_NAME = value
				Me.SendPropertyChanged("FIRST_NAME")
				Me.OnFIRST_NAMEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_MIDDLE_NAME", DbType:="NChar(25)")>  _
	Public Property MIDDLE_NAME() As String
		Get
			Return Me._MIDDLE_NAME
		End Get
		Set
			If (String.Equals(Me._MIDDLE_NAME, value) = false) Then
				Me.OnMIDDLE_NAMEChanging(value)
				Me.SendPropertyChanging
				Me._MIDDLE_NAME = value
				Me.SendPropertyChanged("MIDDLE_NAME")
				Me.OnMIDDLE_NAMEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SURNAME", DbType:="NChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property SURNAME() As String
		Get
			Return Me._SURNAME
		End Get
		Set
			If (String.Equals(Me._SURNAME, value) = false) Then
				Me.OnSURNAMEChanging(value)
				Me.SendPropertyChanging
				Me._SURNAME = value
				Me.SendPropertyChanged("SURNAME")
				Me.OnSURNAMEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SECOND_SURNAME", DbType:="NChar(25)")>  _
	Public Property SECOND_SURNAME() As String
		Get
			Return Me._SECOND_SURNAME
		End Get
		Set
			If (String.Equals(Me._SECOND_SURNAME, value) = false) Then
				Me.OnSECOND_SURNAMEChanging(value)
				Me.SendPropertyChanging
				Me._SECOND_SURNAME = value
				Me.SendPropertyChanged("SECOND_SURNAME")
				Me.OnSECOND_SURNAMEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TELEPHONE", DbType:="NChar(15)")>  _
	Public Property TELEPHONE() As String
		Get
			Return Me._TELEPHONE
		End Get
		Set
			If (String.Equals(Me._TELEPHONE, value) = false) Then
				Me.OnTELEPHONEChanging(value)
				Me.SendPropertyChanging
				Me._TELEPHONE = value
				Me.SendPropertyChanged("TELEPHONE")
				Me.OnTELEPHONEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ADDRESS", DbType:="NChar(50)")>  _
	Public Property ADDRESS() As String
		Get
			Return Me._ADDRESS
		End Get
		Set
			If (String.Equals(Me._ADDRESS, value) = false) Then
				Me.OnADDRESSChanging(value)
				Me.SendPropertyChanging
				Me._ADDRESS = value
				Me.SendPropertyChanged("ADDRESS")
				Me.OnADDRESSChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TYPE_SEX", DbType:="Int NOT NULL")>  _
	Public Property TYPE_SEX() As Integer
		Get
			Return Me._TYPE_SEX
		End Get
		Set
			If ((Me._TYPE_SEX = value)  _
						= false) Then
				If Me._TYPE_SEX1.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnTYPE_SEXChanging(value)
				Me.SendPropertyChanging
				Me._TYPE_SEX = value
				Me.SendPropertyChanged("TYPE_SEX")
				Me.OnTYPE_SEXChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TYPE_IDENTITY_DOCUMENT_PERSON", Storage:="_TYPE_IDENTITY_DOCUMENT1", ThisKey:="TYPE_IDENTITY_DOCUMENT", OtherKey:="ID_TYPE_IDENTITY_DOCUMENT", IsForeignKey:=true)>  _
	Public Property TYPE_IDENTITY_DOCUMENT1() As TYPE_IDENTITY_DOCUMENT
		Get
			Return Me._TYPE_IDENTITY_DOCUMENT1.Entity
		End Get
		Set
			Dim previousValue As TYPE_IDENTITY_DOCUMENT = Me._TYPE_IDENTITY_DOCUMENT1.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._TYPE_IDENTITY_DOCUMENT1.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._TYPE_IDENTITY_DOCUMENT1.Entity = Nothing
					previousValue.PERSON.Remove(Me)
				End If
				Me._TYPE_IDENTITY_DOCUMENT1.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.PERSON.Add(Me)
					Me._TYPE_IDENTITY_DOCUMENT = value.ID_TYPE_IDENTITY_DOCUMENT
				Else
					Me._TYPE_IDENTITY_DOCUMENT = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("TYPE_IDENTITY_DOCUMENT1")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TYPE_SEX_PERSON", Storage:="_TYPE_SEX1", ThisKey:="TYPE_SEX", OtherKey:="ID_TYPE_SEX", IsForeignKey:=true)>  _
	Public Property TYPE_SEX1() As TYPE_SEX
		Get
			Return Me._TYPE_SEX1.Entity
		End Get
		Set
			Dim previousValue As TYPE_SEX = Me._TYPE_SEX1.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._TYPE_SEX1.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._TYPE_SEX1.Entity = Nothing
					previousValue.PERSON.Remove(Me)
				End If
				Me._TYPE_SEX1.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.PERSON.Add(Me)
					Me._TYPE_SEX = value.ID_TYPE_SEX
				Else
					Me._TYPE_SEX = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("TYPE_SEX1")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TYPE_IDENTITY_DOCUMENT")>  _
Partial Public Class TYPE_IDENTITY_DOCUMENT
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID_TYPE_IDENTITY_DOCUMENT As Integer
	
	Private _CODE As String
	
	Private _DESCRIPTION As String
	
	Private _ONLY_NUMBER As System.Nullable(Of Boolean)
	
	Private _PERSON As EntitySet(Of PERSON)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnID_TYPE_IDENTITY_DOCUMENTChanging(value As Integer)
    End Sub
    Partial Private Sub OnID_TYPE_IDENTITY_DOCUMENTChanged()
    End Sub
    Partial Private Sub OnCODEChanging(value As String)
    End Sub
    Partial Private Sub OnCODEChanged()
    End Sub
    Partial Private Sub OnDESCRIPTIONChanging(value As String)
    End Sub
    Partial Private Sub OnDESCRIPTIONChanged()
    End Sub
    Partial Private Sub OnONLY_NUMBERChanging(value As System.Nullable(Of Boolean))
    End Sub
    Partial Private Sub OnONLY_NUMBERChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._PERSON = New EntitySet(Of PERSON)(AddressOf Me.attach_PERSON, AddressOf Me.detach_PERSON)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_TYPE_IDENTITY_DOCUMENT", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID_TYPE_IDENTITY_DOCUMENT() As Integer
		Get
			Return Me._ID_TYPE_IDENTITY_DOCUMENT
		End Get
		Set
			If ((Me._ID_TYPE_IDENTITY_DOCUMENT = value)  _
						= false) Then
				Me.OnID_TYPE_IDENTITY_DOCUMENTChanging(value)
				Me.SendPropertyChanging
				Me._ID_TYPE_IDENTITY_DOCUMENT = value
				Me.SendPropertyChanged("ID_TYPE_IDENTITY_DOCUMENT")
				Me.OnID_TYPE_IDENTITY_DOCUMENTChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CODE", DbType:="NChar(10)")>  _
	Public Property CODE() As String
		Get
			Return Me._CODE
		End Get
		Set
			If (String.Equals(Me._CODE, value) = false) Then
				Me.OnCODEChanging(value)
				Me.SendPropertyChanging
				Me._CODE = value
				Me.SendPropertyChanged("CODE")
				Me.OnCODEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DESCRIPTION", DbType:="NChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property DESCRIPTION() As String
		Get
			Return Me._DESCRIPTION
		End Get
		Set
			If (String.Equals(Me._DESCRIPTION, value) = false) Then
				Me.OnDESCRIPTIONChanging(value)
				Me.SendPropertyChanging
				Me._DESCRIPTION = value
				Me.SendPropertyChanged("DESCRIPTION")
				Me.OnDESCRIPTIONChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ONLY_NUMBER", DbType:="Bit")>  _
	Public Property ONLY_NUMBER() As System.Nullable(Of Boolean)
		Get
			Return Me._ONLY_NUMBER
		End Get
		Set
			If (Me._ONLY_NUMBER.Equals(value) = false) Then
				Me.OnONLY_NUMBERChanging(value)
				Me.SendPropertyChanging
				Me._ONLY_NUMBER = value
				Me.SendPropertyChanged("ONLY_NUMBER")
				Me.OnONLY_NUMBERChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TYPE_IDENTITY_DOCUMENT_PERSON", Storage:="_PERSON", ThisKey:="ID_TYPE_IDENTITY_DOCUMENT", OtherKey:="TYPE_IDENTITY_DOCUMENT")>  _
	Public Property PERSON() As EntitySet(Of PERSON)
		Get
			Return Me._PERSON
		End Get
		Set
			Me._PERSON.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_PERSON(ByVal entity As PERSON)
		Me.SendPropertyChanging
		entity.TYPE_IDENTITY_DOCUMENT1 = Me
	End Sub
	
	Private Sub detach_PERSON(ByVal entity As PERSON)
		Me.SendPropertyChanging
		entity.TYPE_IDENTITY_DOCUMENT1 = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.TYPE_SEX")>  _
Partial Public Class TYPE_SEX
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID_TYPE_SEX As Integer
	
	Private _CODE As String
	
	Private _DESCRIPTION As String
	
	Private _PERSON As EntitySet(Of PERSON)
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnID_TYPE_SEXChanging(value As Integer)
    End Sub
    Partial Private Sub OnID_TYPE_SEXChanged()
    End Sub
    Partial Private Sub OnCODEChanging(value As String)
    End Sub
    Partial Private Sub OnCODEChanged()
    End Sub
    Partial Private Sub OnDESCRIPTIONChanging(value As String)
    End Sub
    Partial Private Sub OnDESCRIPTIONChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._PERSON = New EntitySet(Of PERSON)(AddressOf Me.attach_PERSON, AddressOf Me.detach_PERSON)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_TYPE_SEX", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID_TYPE_SEX() As Integer
		Get
			Return Me._ID_TYPE_SEX
		End Get
		Set
			If ((Me._ID_TYPE_SEX = value)  _
						= false) Then
				Me.OnID_TYPE_SEXChanging(value)
				Me.SendPropertyChanging
				Me._ID_TYPE_SEX = value
				Me.SendPropertyChanged("ID_TYPE_SEX")
				Me.OnID_TYPE_SEXChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CODE", DbType:="NChar(3) NOT NULL", CanBeNull:=false)>  _
	Public Property CODE() As String
		Get
			Return Me._CODE
		End Get
		Set
			If (String.Equals(Me._CODE, value) = false) Then
				Me.OnCODEChanging(value)
				Me.SendPropertyChanging
				Me._CODE = value
				Me.SendPropertyChanged("CODE")
				Me.OnCODEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DESCRIPTION", DbType:="NChar(20) NOT NULL", CanBeNull:=false)>  _
	Public Property DESCRIPTION() As String
		Get
			Return Me._DESCRIPTION
		End Get
		Set
			If (String.Equals(Me._DESCRIPTION, value) = false) Then
				Me.OnDESCRIPTIONChanging(value)
				Me.SendPropertyChanging
				Me._DESCRIPTION = value
				Me.SendPropertyChanged("DESCRIPTION")
				Me.OnDESCRIPTIONChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="TYPE_SEX_PERSON", Storage:="_PERSON", ThisKey:="ID_TYPE_SEX", OtherKey:="TYPE_SEX")>  _
	Public Property PERSON() As EntitySet(Of PERSON)
		Get
			Return Me._PERSON
		End Get
		Set
			Me._PERSON.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_PERSON(ByVal entity As PERSON)
		Me.SendPropertyChanging
		entity.TYPE_SEX1 = Me
	End Sub
	
	Private Sub detach_PERSON(ByVal entity As PERSON)
		Me.SendPropertyChanging
		entity.TYPE_SEX1 = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.[USER]")>  _
Partial Public Class USER
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID_USER As Integer
	
	Private _USER_NAME As String
	
	Private _PASSWORD As String
	
    #Region "Definiciones de métodos de extensibilidad"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnID_USERChanging(value As Integer)
    End Sub
    Partial Private Sub OnID_USERChanged()
    End Sub
    Partial Private Sub OnUSER_NAMEChanging(value As String)
    End Sub
    Partial Private Sub OnUSER_NAMEChanged()
    End Sub
    Partial Private Sub OnPASSWORDChanging(value As String)
    End Sub
    Partial Private Sub OnPASSWORDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID_USER", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ID_USER() As Integer
		Get
			Return Me._ID_USER
		End Get
		Set
			If ((Me._ID_USER = value)  _
						= false) Then
				Me.OnID_USERChanging(value)
				Me.SendPropertyChanging
				Me._ID_USER = value
				Me.SendPropertyChanged("ID_USER")
				Me.OnID_USERChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_USER_NAME", DbType:="NChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property USER_NAME() As String
		Get
			Return Me._USER_NAME
		End Get
		Set
			If (String.Equals(Me._USER_NAME, value) = false) Then
				Me.OnUSER_NAMEChanging(value)
				Me.SendPropertyChanging
				Me._USER_NAME = value
				Me.SendPropertyChanged("USER_NAME")
				Me.OnUSER_NAMEChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PASSWORD", DbType:="NChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property PASSWORD() As String
		Get
			Return Me._PASSWORD
		End Get
		Set
			If (String.Equals(Me._PASSWORD, value) = false) Then
				Me.OnPASSWORDChanging(value)
				Me.SendPropertyChanging
				Me._PASSWORD = value
				Me.SendPropertyChanged("PASSWORD")
				Me.OnPASSWORDChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class