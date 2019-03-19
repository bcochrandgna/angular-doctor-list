# angular-doctor-list

# pre
Initially it was requested to include a Visual Studio project, which should be DoctorsListAPI.csproj.  I use a Mac as my workstation and everything works from here; however, this may not translate well to Windows.  The API project can be run from the command line using the below installation instructions.

# structure
This repository contains two separate projects, one for the API, and one for the Angular SPA application.

DoctorListWeb - This folder contains the Angular web project.
DoctorListAPI - This folder contains the .NET WebAPI project.

# installation
Since these projects use separate package managers, you will need the following basics to get installed:

node (~v10.9.0)
npm (~6.1.0)
dotnet (^2.2.104)

Once these are installed, you will need to run the following:

cd DoctorListAPI
dotnet restore
dotnet run

This will start the API using Kestrel on port 5000 (http://localhost:5000)

cd DoctorListWeb
npm install
ng serve

This will start the web server on port 4200 (http://localhost:4200)

Once the two servers are running, you may browse to http://localhost:4200 to view the web application.

# notes
The web application is not using very many styles other than to format the data properly.  The list is formatted using a grid system as requested along with a single detail page when a record from the list is clicked.

The API uses SQLite to serve data which is locationed under the DoctorListAPI folder and named Doctors.db.  I have included a prefilled database for this review.
