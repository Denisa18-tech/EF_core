# Model Folder In

### Lazy Loading

Lazy Loading loads related data only when it is accessed for the first time.

This can reduce the initial amount of data retrieved from the database but may result in additional database queries.

### Eager Loading

Eager Loading loads related data together with the main entity in a single database query.

This helps reduce database round trips and is generally preferred when related data is known to be required.

## Responsibilities

- Define entity structure
- Represent database tables
- Configure relationships between entities
- Support navigation properties
- Enable loading of related data

## Benefits

- Clear data structure
- Easy relationship management
- Better maintainability
- Strong integration with EF Core

<br>
<br>
<br>
<br>

# Service Folder

### Synchronous Operations

Synchronous operations execute one task at a time.

The application waits for the operation to complete before continuing to the next statement.

While simple to understand, synchronous operations can block threads during long-running database operations.

### Asynchronous Operations

Asynchronous operations allow the application to continue executing other tasks while waiting for a database operation to complete.

This improves scalability, responsiveness, and overall application performance.

Async programming is commonly implemented using async and await keywords.

## Responsibilities

- Business logic implementation
- Data processing
- Communication with repositories or DbContext
- Request validation
- Coordinating application workflows

## Benefits

- Better code organization
- Separation of concerns
- Improved maintainability
- Easier testing
- Support for scalable asynchronous operations
