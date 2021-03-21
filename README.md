# ElinkxTask

Repository for CustomersApi for Elinkx task.

Customer's api documentation:

This API uses linux docker containers. It is connected to the local MSSQL server for docker. If you want to connect api to another database, edit connection string in appsettings.json.

If you want to use local MSSQL server for linux, you can use script, which is placed in CustomersApi folder. To open this script, run power shell in the same location, where you have downloaded the script.

Type:

docker-compose up -d (-d is used for running in the background)

When everything's ready, you can connect to DB via MS SQL Server Management studio. To log in, use following connection:

Server type: Database engine
Server name: localhost\ElinkxTaskDb,1433
Authentification: SQL Server Authentification
Login: sa
Password: Great_Password123 (you can set your own in the docker-compose script).

Create database and table named TbCustomers. You can use this script to make both and fill the customer table with some random data.



  


