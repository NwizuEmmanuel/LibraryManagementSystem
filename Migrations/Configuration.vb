Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Data.Entity.Validation
Imports System.Linq

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of LMS)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As LMS)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method
            '  to avoid creating duplicate seed data.
            Try
                ' Seeding Users
                context.Users.AddOrUpdate(
                Function(u) u.Id,
                New User() With {.Id = 1, .Username = "admin", .Password = "admin123", .Role = "Administrato"},
                New User() With {.Id = 2, .Username = "john_doe", .Password = "password123", .Role = "User"},
                New User() With {.Id = 3, .Username = "jane_doe", .Password = "password456", .Role = "User"},
                New User() With {.Id = 5, .Username = "susan_jones", .Password = "password101", .Role = "Administrator"},
                New User() With {.Id = 6, .Username = "robert_brown", .Password = "password202", .Role = "User"}
            )

                ' Seeding Students
                context.Students.AddOrUpdate(
                Function(s) s.Id,
                New Student() With {.Id = 1, .Firstname = "Jane", .Middlename = "A", .Lastname = "Doe", .Sex = "Female", .Course = "Computer Science"},
                New Student() With {.Id = 2, .Firstname = "John", .Middlename = "B", .Lastname = "Smith", .Sex = "Male", .Course = "Engineering"},
                New Student() With {.Id = 3, .Firstname = "Alice", .Middlename = "C", .Lastname = "Johnson", .Sex = "Female", .Course = "Mathematics"},
                New Student() With {.Id = 4, .Firstname = "Bob", .Middlename = "D", .Lastname = "Williams", .Sex = "Male", .Course = "Physics"},
                New Student() With {.Id = 5, .Firstname = "Charlie", .Middlename = "E", .Lastname = "Brown", .Sex = "Male", .Course = "Chemistry"},
                New Student() With {.Id = 6, .Firstname = "Eve", .Middlename = "F", .Lastname = "Davis", .Sex = "Female", .Course = "Biology"}
            )

                ' Seeding Books
                context.Books.AddOrUpdate(
                Function(b) b.ISBN,
                New Book() With {.ISBN = "9783161484100", .Title = "Programming Basics", .Authors = "Alice, Bob", .Publisher = "TechBooks", .YearPublished = 2020},
                New Book() With {.ISBN = "9781234567897", .Title = "Advanced Programming", .Authors = "Carol, Dave", .Publisher = "EduBooks", .YearPublished = 2021},
                New Book() With {.ISBN = "9780143127741", .Title = "Data Structures and Algorithms", .Authors = "Edward, Frank", .Publisher = "LearnPress", .YearPublished = 2019},
                New Book() With {.ISBN = "9781402894625", .Title = "Artificial Intelligence", .Authors = "Grace, Henry", .Publisher = "AI Publishers", .YearPublished = 2022},
                New Book() With {.ISBN = "9780073383095", .Title = "Machine Learning", .Authors = "Ian, Jack", .Publisher = "ML Press", .YearPublished = 2020},
                New Book() With {.ISBN = "9780131103627", .Title = "Introduction to Python", .Authors = "Karen, Leo", .Publisher = "PyBooks", .YearPublished = 2018}
            )

                context.SaveChanges()
            Catch ex As DbEntityValidationException
                ' Loop through each entity validation error
                For Each entityError In ex.EntityValidationErrors
                    Console.WriteLine($"Entity: {entityError.Entry.Entity.GetType().Name}")

                    ' Loop through each property error for the entity
                    For Each validationError In entityError.ValidationErrors
                        Console.WriteLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}")
                    Next
                Next
                Throw ' Re-throw the exception after logging the validation errors
            End Try
        End Sub

    End Class

End Namespace
