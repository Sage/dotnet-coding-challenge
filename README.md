# .NET Coding Challenge
> This coding challenge is for a .NET developer. We are making the assumption that you are familiar with .NET Core, MVC and REST.

Your task is to build an API that manages accounts and users.

We would expect this task to take a few hours, however there is no strict time limit and you won't be judged on how long it took you to complete.
1. You must use .NET Core and C#
2. The API should be a ASP.NET Core Web API project
3. The API should consume and return data as JSON
4. You do not need to use HTTPS, attempt to provide any Authorization/Authentication or consider any other security implications
6. You do not need any persistent storage. Please use in-memory collections but treat these as actual data stores
7. You can use any NuGet package but be prepared to justify its usage

## Specification
We want you to develop an API that exposes two RESTful endpoints. These endpoints should provide standard CRUD functionality for two different entities **Accounts** and **Users**.

### Accounts
#### URL Formats
**GET**
```
/api/accounts
/api/accounts/{id}
```
**POST**
```
/api/accounts
```
**DELETE**
```
/api/accounts/{id}
```
**PUT**
```
/api/accounts/{id}
```
#### Fields
| Field Name | Data Type | Required | Validation |
|--|--|--|--|
| CompanyName | `string` | true | max length 128 |
| Website | `string` | false | n/a |

 - Account is the root entity
 - If you delete an account all user's associated to that account should also be deleted
 - If you get an account by ID, it should also include all associated users
 - If you get all accounts no users should be included
 - Creating/Updating an account should not affect users

### Users
#### URL Formats
**GET**
```
/api/accounts/{id}/users
/api/accounts/{id}/users/{id}
```
**POST**
```
/api/accounts/{id}/users
```
**DELETE**
```
/api/accounts/{id}/users/{id}
```
**PUT**
```
/api/accounts/{id}/users/{id}
```
#### Fields
| Field Name | Data Type | Required | Validation |
|--|--|--|--|
| FirstName | `string` | true | max length 128 |
| LastName | `string` | false | max length 128 |
| Email | `string` | true | must validate to a typical email address |

 - A user will always belong to an account
 - Email must be unique
 - An account must have no more than 50 users

## Additional Tasks
These tasks are not mandatory, this is your time to put your touch on your submission, you might want to consider:

 - Asynchronous programming
 - Pagination
 - API documentation, i.e Swagger
 - Logging/tracing
 - Awareness of load concerns, i.e retry logic
 - Advanced filtering such as OData/GraphQL
 - Anything else you can think of to enhance your app, we'd love to see your ideas

## How we will assess your work
We are looking production quality code which utilises design patterns where appropriate and conforms to best practices and principles such as SOLID, etc. Other things we will take into consideration:

 - Code should be testable with a high percentage of code coverage
 - We expect you to be mindful of correct HTTP status code usage

You should clone this repository and when you're ready to share your work push it to private repository and our recruitment team will let you know the username to add as a collaborator so we can check it out.
