Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class DeleteBookAuthorManyToMany
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.BookAuthors", "AuthorId", "dbo.Authors")
            DropForeignKey("dbo.BookAuthors", "BookId", "dbo.Books")
            DropIndex("dbo.BookAuthors", New String() { "BookId" })
            DropIndex("dbo.BookAuthors", New String() { "AuthorId" })
            AddColumn("dbo.Books", "Authors", Function(c) c.String(nullable := False))
            DropTable("dbo.BookAuthors")
            DropTable("dbo.Authors")
        End Sub
        
        Public Overrides Sub Down()
            CreateTable(
                "dbo.Authors",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .AuthorName = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            CreateTable(
                "dbo.BookAuthors",
                Function(c) New With
                    {
                        .BookId = c.Int(nullable := False),
                        .AuthorId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.BookId, t.AuthorId })
            
            DropColumn("dbo.Books", "Authors")
            CreateIndex("dbo.BookAuthors", "AuthorId")
            CreateIndex("dbo.BookAuthors", "BookId")
            AddForeignKey("dbo.BookAuthors", "BookId", "dbo.Books", "Id", cascadeDelete := True)
            AddForeignKey("dbo.BookAuthors", "AuthorId", "dbo.Authors", "Id", cascadeDelete := True)
        End Sub
    End Class
End Namespace
