# National Park API

#### Written by Maxwell Meyer

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

## Description

A project utilizing ASP.NET CORE to practice building a back-end API, including full CRUD functionality, along with versioning and Swagger documentation for endpoints.

## Applied Technologies

This project was built using:

- ASP.NET 5.0(https://dotnet.microsoft.com/download/dotnet/5.0)
- ASP.NET MVC
- CLI
- Postman
- Swagger
- Entity Framework Core

### Instructions for Installing C# and .NET:

**1a.** _WINDOWS: Download the [64-bit .NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer). Clicking these links will prompt a **.exe** file download from Microsoft_.\
 \
 **1b.** MAC: Download this [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer). Clicking this link will prompt a **.pkg** file download from Microsoft.\
 \
 **2.** _Open the file and follow the steps provided by the installer for your OS_.\
 \
 **3.** _Confirm the installation is successful by opening a new Windows PowerShell OR Max Terminal window and running the command dotnet --version_.\

### Installation/Setup

1. View on Github

2. Alternatively, clone this repository to your computer and navigate to the cloned directory

3. Navigate to the `ParksApi` directory

4. Install the required dependencies by running `$ dotnet restore` in the command line

5. Create a file named appsettings.json in the `ParksApi` directory and copy the following code:

```
{
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database={DATABASE_NAME_HERE};uid={USERNAME_NAME_HERE};pwd={YOUR_PASSWORD_HERE};"
  }
}
```

Be sure you have entered the correct username, DB name, and password, and omitted the curly brackets {}!

7. In the ParksApi directory, run the terminal command `dotnet restore`

8. Now run `dotnet ef migrations add Initial` to build the Migrations Folder

9. Run `dotnet ef database update` to implement the database structure

10. Run `dotnet watch run` to run the application on your browser's local server at `http://localhost:5000`

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

### To view and test API endpoints:

1. Download/open [PostMan](https://www.postman.com/downloads/)

2. Explore by entering one of the following URLs along with its corresponding CRUD method (GET/POST/DELETE/PUT)

-GET will retrieve an example entry from a variety of pre-seeded park entries

-POST will add an additional entry into the Database

-PUT will allow you to edit an existing entry

-DELETE will remove a specific entry form the Database

3. You can also utilize the Swagger UI by navigating to `https://localhost:5001/index.html` and exploring the various endpoint options/functionality.

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/rainbow.png)

## License Information

You can find all applicable licensing information [here](https://opensource.org/licenses/MIT).

## Contact me!

Maxwell Meyer

maxreadswell@gmail.com
