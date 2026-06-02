# Entity Framework Core(EF_core)

## What is Entity Framework Core?

Entity Framework Core (EF Core) is an Object Relational Mapper (ORM) developed by Microsoft for .NET applications.<br>

It allows developers to work with databases using C# objects instead of writing SQL queries manually. EF Core acts as a bridge between the application and the database.<br>

### Simple Definition

EF Core converts C# objects into database records and database records into C# objects.<br>

### Real-Life Example

Imagine a restaurant:<br>

Customer → Application<br>
Waiter → EF Core<br>
Kitchen → Database<br>

The customer gives an order to the waiter. The waiter communicates with the kitchen and brings back the food.<br>

Similarly:<br>

Application sends data requests to EF Core.<br>
EF Core communicates with the database.<br>
EF Core returns the results to the application.<br>

## What is ORM?

ORM (Object Relational Mapping) maps database tables to C# classes and database rows to objects.<br>

### What are the main benefits of EF Core?
  Less SQL coding<br>
  Faster development<br>
  LINQ support<br>
  Migrations<br>
  Change tracking<br>
  Database independence<br>
  
### What are the limitations of EF Core?
  Performance overhead<br>
  Complex query optimization issues<br>
  Less control over generated SQL
