Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class FirstCreate1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropPrimaryKey("dbo.Books")
            AddPrimaryKey("dbo.Books", "ISBN")
            DropColumn("dbo.Books", "Id")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Books", "Id", Function(c) c.Int(nullable := False, identity := True))
            DropPrimaryKey("dbo.Books")
            AddPrimaryKey("dbo.Books", "Id")
        End Sub
    End Class
End Namespace
