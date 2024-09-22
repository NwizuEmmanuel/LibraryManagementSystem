Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class FirstCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Books",
                Function(c) New With
                    {
                        .Id = c.Int(nullable:=False, identity:=True),
                        .ISBN = c.String(nullable:=False, maxLength:=13),
                        .Title = c.String(nullable:=False),
                        .Authors = c.String(nullable:=False),
                        .Publisher = c.String(nullable:=False),
                        .YearPublished = c.Int(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.Id) _
                .Index(Function(t) t.ISBN, unique:=True)

            CreateTable(
                "dbo.Students",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Firstname = c.String(nullable := False),
                        .Middlename = c.String(),
                        .Lastname = c.String(nullable := False),
                        .Sex = c.String(nullable := False),
                        .Course = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.Users",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .Username = c.String(nullable := False),
                        .Password = c.String(nullable := False),
                        .Role = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropIndex("dbo.Books", New String() { "ISBN" })
            DropTable("dbo.Users")
            DropTable("dbo.Students")
            DropTable("dbo.Books")
        End Sub
    End Class
End Namespace
