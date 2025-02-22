# Aspire Project

## Overview
Aspire Project is a web application built using **.NET** for the backend and **Angular** for the frontend. The project is designed to provide a scalable, modular, and efficient solution for full-stack development.

## Features
- **Modular Architecture**: The project follows a clean separation between backend and frontend.
- **Responsive Design**: Optimized for different screen sizes using Bootstrap.
- **REST API Integration**: Communicates with a backend service built with .NET.
- **Unit Testing**: Written with xUnit for .NET and Jasmine/Karma for Angular.

## Prerequisites
Ensure you have the following installed before setting up the project:
- **Node.js** (Latest LTS Version) - [Download](https://nodejs.org/)
- **Angular CLI** - Install globally using:
  ```sh
  npm install -g @angular/cli
  ```
- **.NET SDK** - [Download](https://dotnet.microsoft.com/)
- **SQL Server** (For database management)
- **Git** (for version control)

## Installation
1. Clone the repository:
   ```sh
   git clone <repository-url>
   cd aspire-project
   ```
2. Install frontend dependencies:
   ```sh
   npm install
   ```
3. Navigate to the backend folder and restore dependencies:
   ```sh
   cd backend
   dotnet restore
   ```
4. Start the backend server:
   ```sh
   dotnet run
   ```
5. Start the frontend development server:
   ```sh
   cd ../frontend
   ng serve
   ```
6. Open the application in the browser:
   ```
   http://localhost:4200
   ```

## Configuration
- Update the `appsettings.json` file in the backend with database connection strings.
- Update the `environment.ts` and `environment.prod.ts` files in Angular with API endpoints.
- Configure authentication settings for OAuth/JWT.

## Build
To generate a production build for the frontend, run:
```sh
ng build --prod
```
To publish the backend, run:
```sh
dotnet publish -c Release
```

## Testing
Run backend tests:
```sh
dotnet test
```
Run frontend unit tests:
```sh
ng test
```
Run end-to-end tests:
```sh
ng e2e
```

## Deployment
To deploy on a server:
1. Deploy the backend using **IIS, Docker, or Azure App Services**.
2. Deploy the frontend by serving the `dist/` folder using **Nginx** or **Apache**.

## Contributing
Feel free to contribute by creating pull requests and reporting issues.

## License
This project is licensed under the **MIT License**.

---
**Author**: Harshal

