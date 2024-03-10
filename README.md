Instructions for setting up the project: Connect to a Database, in the case of this EF Core example, MSSql was used.

To execute the EF Core migrations, first you must ensure you have the EF Core CLI tools installed, which can be done here: https://learn.microsoft.com/en-us/ef/core/cli/dotnet

Ensure you are on the branch ef/initial-setup before proceeding with the next step.

Navigate to DesignTimeDbContextFactory.cs and change the ConnectionString variable to match your local MSSql instance.

![image](https://github.com/Sintry1/DBForDevCompulsory/assets/75076281/730439d9-56ea-415c-ab1a-2251e252261f)

Next, change the value of the DatabaseName variable to match your desired name for your database.

Once this is done, open a terminal and navigate to the DBMigrations project directory and type the following command: dotnet ef database update

THis will create your database with the connection you specified and the database name. It will also create a Products table that matches the Product Model that is defined.

![image](https://github.com/Sintry1/DBForDevCompulsory/assets/75076281/0a5ae444-c0a0-4b9e-aa0e-5742002d0f72)

To apply new migration to your database schema: 

Change branch to ef/add-ratings or ef/add-categories (the instructions are the same for both)

Ensure that the connection string in the DesignTimeDbContextFactory.cs file is still set correctly and then run the same command in the terminal: dotnet ef database update

This will apply any subsequent migrations to your database.

To rollback to a previous migration, first identify which migration you would like to roll back to by typing the following command into the terminal: dotnet ef migrations list

Once you have identified the migration you wish to rollback to, you can rollback by running the following command in the terminal: dotnet ef database update <PreviousMigrationName>

