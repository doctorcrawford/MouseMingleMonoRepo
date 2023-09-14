# Mouse Mingle

### By Sarah Reimann, Emma Gerigscott, Kyle Crawford, Thomas McDowell, Eusebie Siebenberg

## Description

A dating app for rodents. User can login and see all the available rodents including their name, a photo, and a link to their further details. User can then upvote or downvote any of the rodents. 

## Technologies Used

* C#
* .NET
* ASP.NET CORE
  * Authentication
  * Versioning
  * Identity
* MVC
* Entity Framework Core
* EF Core Migrations
* Swashbuckle
* Swagger
* MySQL
* RestSharp

## Database Structure
![photo of SQL designer](./MouseMingleClient/wwwroot/img/sqldesign.png)

## Instructions to set up database
1. Clone this repo.
2. Open your terminal (e.g. Terminal or GitBash) and navigate to this project's directory called "MouseMingleMonoRepo".
3. Set up the project:
  * Create a file called 'appsettings.json' in MouseMingleMonoRepo.Solution/MouseMIngleApi directory
  * Add the following code to the appsettings.json file:
  ```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=mouse_mingle_api;uid=[YOUR_SQL_USERNAME_HERE];pwd=[YOUR_SQL_PASSWORD_HERE];"
  },
    "JWT": {
    "ValidAudience": "http://localhost:5000",
    "ValidIssuer": "http://localhost:5045",
    "Secret": "JWTAuthenticationHIGHsecuredPasswordVVVp1OH7Xzyr"
  }
}
  ```
  * Make sure to plug in your SQL user id and password at
   ```[YOUR_SQL_USERNAME_HERE]``` 
   and 
   ```[YOUR_SQL_PASSWORD_HERE]```
  * Create a file called 'appsettings.Development.json' in MouseMingleMonoRepo.Solution/MouseMingleApi directory
  * Add the following code to the appsettings.Development.json file:

  ```
  {
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
  ```

  * Create a file called appsettings.json in MouseMingleMonoRepo.Solution/MouseMIngleClient directory
  * add the following code to appsettings.json:

  ```
  {
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
  ```


1. Set up the database:
  * Make sure EF Core Migrations is installed on your computer by running ```dotnet tool install --global dotnet-ef --version 6.0.0```
  * In the production folder of the project (MouseMingleMonoRepo.Solution/MouseMingleApi) run:
  ```
  dotnet ef database update
  ```
  * You should see the new schema in your _Navigator > Schemas_ tab of your MySql Workbench on refresh called ```mouse_mingle_api```


## Using This Api

* Endpoints for **v1.0** are as follows:

```
# Authenticate:
POST https://localhost:5000/api/v1/authenticate/login
* This route requires a body:

{
  "username": "string",
  "password": "string"
}

POST https://localhost:5000/api/v1/authenticate/register
* This route requires a body:
{
  "username": "string",
  "email": "user@example.com",
  "password": "string"
}

# Interests:
GET https://localhost:5000/api/v1/interests/
POST https://localhost:5000/api/v1/interests/
* This route requires a body:
{
  "interestId": 0,
  "description": "string"
}
GET https://localhost:5000/api/v1/interests/{id}
PUT https://localhost:5000/api/v1/interests/{id}
DELETE https://localhost:5000/api/v1/interests/{id}

# RodentInterests:
GET https://localhost:5000/api/v1/rodentinterests
POST https://localhost:5000/api/v1/rodentinterests
* This route requires a body: 
{
  "interestId": 0,
  "description": "string"
}
GET https://localhost:5000/api/v1/rodentinterests/{id}
PUT https://localhost:5000/api/v1/rodents/{id}
DELETE https://localhost:5000/api/v1/rodents/{id}

# Rodents
GET https://localhost:5000/api/v1/rodents/
POST https://localhost:5000/api/v1/rodents/
* This route requires a body:
{
  "rodentId": 0,
  "species": "string",
  "name": "string",
  "age": 0,
  "location": "string",
  "profilePic": "string",
  "upVote": 0,
  "rodentInterests": [
    {
      "rodentInterestId": 0,
      "rodentId": 0,
      "interestId": 0,
      "interest": {
        "interestId": 0,
        "description": "string"
      }
    }
  ]
}
GET https://localhost:5000/api/v1/rodents/{id}
PUT https://localhost:5000/api/v1/rodents/{id}
DELETE https://localhost:5000/api/v1/rodents/{id}
POST https://localhost:5000/api/v1/rodents/{id}/interests/{interestId}
* This route requires two parameters, a rodentId and an interestId. It will add interests to a specfic rodent
GET https://localhost:5000/api/v1/rodents/{id}/rodentinterests
* This route require one parameter, a rodentId. It will return all the interests associated with a specific rodent. 

```
# To test routes in Swagger: 

* In your terminal, navigate to the project directory and run ```dotnet watch run``` 
* In your broswer, open https://localhost:5001/swagger/index.html
* Use the GUI to navigate the API

# To test routes in PostMan:

* Make sure that Postman API Platform is downloaded to your device
* Start a new request by clicking the + at the top of the window
* Copy and paste any of the above listed end point links into the text bar that says 'Enter URL or paste text'
* Make sure the method to the left of the text box matches the method described for the endpoint you are testing
* If route requires a body, navigate to the body window just below the text box
* Copy and paste the body code listed above and replace fields with their respective values
* Click send and wait for response at the bottom of the window

# Versioning
* This feature is half implemented. There is a version 1.0 which contains all of the functionality of the app as it currently stands. There is yet to be any further versions, but the app is set up to allow the creation of further versions.

## Known bugs
* User cannot log out of account -- Kyle will figure this out
* Can only save interests to a few rodents, it breaks on some of them
* Profile link is broken
* 'Add a rodent' route doesn't exist

## License

MIT License

Copyright (c) 2023 Sarah Reimann, Emma Gerigscott, Kyle Crawford, Thomas McDowell, Eusebie Siebenberg

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
