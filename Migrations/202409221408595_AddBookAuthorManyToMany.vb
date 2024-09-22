Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddBookAuthorManyToMany
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropIndex("dbo.Books", New String() { "ISBN" })
            DropPrimaryKey("dbo.Books")
            CreateTable(
                "dbo.BookAuthors",
                Function(c) New With
                    {
                        .BookId = c.Int(nullable := False),
                        .AuthorId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.BookId, t.AuthorId }) _
                .ForeignKey("dbo.Authors", Function(t) t.AuthorId, cascadeDelete := True) _
                .ForeignKey("dbo.Books", Function(t) t.BookId, cascadeDelete := True) _
                .Index(Function(t) t.BookId) _
                .Index(Function(t) t.AuthorId)
            
            CreateTable(
                "dbo.Authors",
                Function(c) New With
                    {
                        .Id = c.Int(nullable := False, identity := True),
                        .AuthorName = c.String(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Books", "Id", Function(c) c.Int(nullable := False, identity := True))
            AlterColumn("dbo.Books", "ISBN", Function(c) c.String(maxLength := 13))
            AddPrimaryKey("dbo.Books", "Id")
            CreateIndex("dbo.Books", "ISBN", unique := True)
            DropColumn("dbo.Books", "Authors")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Books", "Authors", Function(c) c.String(nullable := False))
            DropForeignKey("dbo.BookAuthors", "BookId", "dbo.Books")
            DropForeignKey("dbo.BookAuthors", "AuthorId", "dbo.Authors")
            DropIndex("dbo.Books", New String() { "ISBN" })
            DropIndex("dbo.BookAuthors", New String() { "AuthorId" })
            DropIndex("dbo.BookAuthors", New String() { "BookId" })
            DropPrimaryKey("dbo.Books")
            AlterColumn("dbo.Books", "ISBN", Function(c) c.String(nullable := False, maxLength := 13))
            DropColumn("dbo.Books", "Id")
            DropTable("dbo.Authors")
            DropTable("dbo.BookAuthors")
            AddPrimaryKey("dbo.Books", "ISBN")
            CreateIndex("dbo.Books", "ISBN", unique := True)
        End Sub
    End Class
End Namespace
