# .NET Coding Challenge
> This coding challenge is for a .NET developer. We are making the assumption that you are familiar with .NET Core, MVC and REST.

Your task is to build an API that manages accounts and users.

There is no strict time limit and you won't be judged on how long it took you to complete, however we would like you to spend between 2-4 hours on this.
1. You must use .NET Core and C#
2. The API should be a ASP.NET Core Web API project
3. The API should consume and return data as JSON
4. You do not need to consider any security implications. This includes using HTTPS or attempting to provide any Authorization/Authentication
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
 - Every user must have a unique email address

## How we will assess your work
We are looking production quality code which utilises design patterns where appropriate and conforms to best practices and principles such as SOLID, etc. Other things we will take into consideration:

 - Code should be testable
 - We expect you to be mindful of correct HTTP status code usage

You should clone this repository and when you're ready to share your work push it to private repository and our recruitment team will let you know the username to add as a collaborator so we can check it out.
