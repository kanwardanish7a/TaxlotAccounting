# TaxLotAccounting

TaxLotAccounting is a software solution built to track taxlots and analyze the distribution of taxlots and their cumulative results. It includes both a robust backend API developed using the ABP framework (.NET) and a mobile frontend built with Expo Go (React Native).

## Features
- Track individual taxlot details.
- Analytics of taxlot distributions.
- Real-time cumulative results and reporting.
- User management and role-based access.

## Tech Stack
- **Backend**: .NET ABP Framework
- **Frontend**: React Native (Expo Go)
- **Database**: SQL Server (or your choice)
- **Authentication**: JWT (or IdentityServer)

## Installation

### Backend (.NET)
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/taxlotaccounting-backend.git
   ```
2. Navigate to the project folder and restore dependencies:
   ```bash
   cd taxlotaccounting-backend
   dotnet restore
   ```
3. Run the backend:
   ```bash
   dotnet run
   ```

### Frontend (Expo Go)
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/taxlotaccounting-frontend.git
   ```
2. Navigate to the project folder and install dependencies:
   ```bash
   cd taxlotaccounting-frontend
   npm install
   ```
3. Run the app in Expo Go:
   ```bash
   expo start
   ```

## Usage
- Create and manage taxlot entries via the mobile app.
- View analytics, distributions, and cumulative results.

## License
MIT
