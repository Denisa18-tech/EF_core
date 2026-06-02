# Code-First vs Database-First

## What is Code-First?

In Code-First approach, developers create C# classes first.

EF Core generates database tables from those classes.

### Flow

C# Classes → EF Core → Database

# Example

C#
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}



## What is Database-First?

In Database-First approach, developers create the database first.

EF Core generates C# classes from the existing database.

### Flow

Database → EF Core → C# Classes

### Example

Database Table:

Employee

| Id | Name |
|----|------|
| 1  | Rahul |
| 2  | Amit |

Generate Models:

C#
public partial class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
