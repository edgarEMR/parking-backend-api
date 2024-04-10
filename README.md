# Test for .NET Back-end Development

Create a REST API to manage a car and motorcycle parking lot.

## Technologies

### - Entity Framework Core
### - Entity Framework Core SqlServer
### - Entity Framework Core Tools
### - Swagger
### - Swashbuckle

## Service Calls

### Company

#### GET
- /api/Company
  - Retrieves all companies available. 
  Example:
  ```
  {
    "id": 0,
    "name": "string",
    "address": "string",
    "telephone": "string",
    "motorcycleSpaces": 0,
    "carSpaces": 0
  }
  ```
- /api/Company/{id}
  - Retrieves the company with the provided id. 
  Example:
  ```
  {
    "id": 0,
    "name": "string",
    "address": "string",
    "telephone": "string",
    "motorcycleSpaces": 0,
    "carSpaces": 0
  }
  ```

  #### POST
- /api/Company/
  - Inserts a new company with the given information. 
  Example:
  ```
  {
    "id": 0,
    "name": "string",
    "address": "string",
    "telephone": "string",
    "motorcycleSpaces": 0,
    "carSpaces": 0
  }
  ```
  #### PUT
- /api/Company/{id}
  - Updates the company related to the provided ID with the given information. 
  Example:
  ```
  {
    "id": 0,
    "name": "string",
    "address": "string",
    "telephone": "string",
    "motorcycleSpaces": 0,
    "carSpaces": 0
  }
  ```
    #### DELETE
- /api/Company/{id}
  - Deletes the company with the provided id. 

### Vehicle

#### GET
- /api/Vehicle
  - Retrieves all vehicles available in the parking lot with the provided company ID. 
  Example:
  ```
  {
    "id": 0,
    "brand": "string",
    "model": "string",
    "color": "string",
    "plate": "string",
    "type": "string",
    "isParked": true,
    "inputDate": "2024-04-10T17:37:22.015Z",
    "outputDate": "2024-04-10T17:37:22.015Z",
    "companyId": 0
  }
  ```
- /api/Vehicle/{id}
  - Retrieves the vehicle with the provided id. 
  Example:
  ```
  {
    "id": 0,
    "brand": "string",
    "model": "string",
    "color": "string",
    "plate": "string",
    "type": "string",
    "isParked": true,
    "inputDate": "2024-04-10T17:37:22.015Z",
    "outputDate": "2024-04-10T17:37:22.015Z",
    "companyId": 0
  }
  ```

  #### POST
- /api/Vehicle/
  - Inserts a new vehicle in the parking lot with the given information. 
  Example:
  ```
  {
    "id": 0,
    "brand": "string",
    "model": "string",
    "color": "string",
    "plate": "string",
    "type": "string",
    "isParked": true,
    "inputDate": "2024-04-10T17:37:22.015Z",
    "outputDate": "2024-04-10T17:37:22.015Z",
    "companyId": 0
  }
  ```
  #### PUT
- /api/Vehicle/{id}
  - Updates the vehicle related to the provided ID with the given information. 
  Example:
  ```
  {
    "id": 0,
    "brand": "string",
    "model": "string",
    "color": "string",
    "plate": "string",
    "type": "string",
    "isParked": true,
    "inputDate": "2024-04-10T17:37:22.015Z",
    "outputDate": "2024-04-10T17:37:22.015Z",
    "companyId": 0
  }
  ```
  - /api/Vehicle/remove/{id}
  - Generates a logical delete to the provided vehicle. 
  Example:
  ```
  {
    "id": 0,
    "brand": "string",
    "model": "string",
    "color": "string",
    "plate": "string",
    "type": "string",
    "isParked": true,
    "inputDate": "2024-04-10T17:37:22.015Z",
    "outputDate": "2024-04-10T17:37:22.015Z",
    "companyId": 0
  }
  ```
    #### DELETE
- /api/Vehicle/{id}
  - Deletes the vehicle with the provided id.
 
## Necessary configurations
### Prior to runnning the project you will need to execute the latest migration file provided, using the Package Manager Console from Visual Studio or the .NET CLI, to generate the necessary database tables.
- Package Manager Console:
```
update-database -target <fileName>
```
- .NET CLI:
```
dotnet ef database update <fileName>
```
