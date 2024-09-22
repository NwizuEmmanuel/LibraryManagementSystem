Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Public Class LMS
    Inherits DbContext

    ' Your context has been configured to use a 'LMS' connection string from your application's 
    ' configuration file (App.config or Web.config). By default, this connection string targets the 
    ' 'LibraryManagementSystem.LMS' database on your LocalDb instance. 
    ' 
    ' If you wish to target a different database and/or database provider, modify the 'LMS' 
    ' connection string in the application configuration file.
    Public Sub New()
        MyBase.New("name=LMS")
    End Sub
    ' Add a DbSet for each entity type that you want to include in your model. For more information 
    ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)

    Public Property Users As DbSet(Of User)
    Public Property Students As DbSet(Of Student)
    Public Property Books As DbSet(Of Book)
End Class

'Public Class MyEntity
'    Public Property Id() As Int32
'    Public Property Name() As String
'End Class

Public Class User
    <Key>
    Public Property Id() As Int32
    <Required>
    Public Property Username As String
    <Required>
    Public Property Password As String
    <Required>
    Public Property Role As String
End Class

Public Class Student
    <Key>
    Public Property Id() As Int32
    <Required>
    Public Property Firstname As String
    Public Property Middlename As String
    <Required>
    Public Property Lastname As String
    <Required>
    Public Property Sex As String
    <Required>
    Public Property Course As String
End Class

Public Class Book
    <Key>
    <Index(IsUnique:=True)>
    <MaxLength(13)>
    Public Property ISBN As String
    <Required>
    Public Property Title As String
    <Required>
    Public Property Authors As String
    <Required>
    Public Property Publisher As String
    <Required>
    Public Property YearPublished As Int32
End Class
