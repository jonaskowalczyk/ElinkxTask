# ElinkxTask

Repository for CustomersApi for Elinkx task.

Customer's api documentation:

This API uses linux docker containers. It is connected to the local MSSQL server for docker. If you want to connect api to another database, edit connection string in appsettings.json.

If you want to use local MSSQL server for linux, you can use script, which is placed in CustomersApi folder. To open and run this script, run power shell in the same location, where you have downloaded the script.

Type:

docker-compose up -d (-d is used for running in the background)

When everything's ready, you can connect to DB via MS SQL Server Management studio. To log in, use following connection:

Server type: Database engine
Server name: localhost\ElinkxTaskDb,1433
Authentification: SQL Server Authentification
Login: sa
Password: Great_Password123 (you can set your own in the docker-compose script).

Create database and table named TbCustomers. You can use this query to make both and fill the customer table with some random data:

CREATE DATABASE DbElinkxTask
GO

USE DbElinkxTask


CREATE TABLE TbCustomers(
ID INT,
Name VARCHAR(200),
Surname VARCHAR(200),
Age INT,
Gender VARCHAR(200),
Street VARCHAR(200),
City VARCHAR(200),
PostCode VARCHAR(200),
Email VARCHAR(200),
PhoneNumber VARCHAR(200)
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
1, 'Jonáš', 'Kowalczyk', 25, 'Muž', 'Pracharska 21', 'Ostrava', '74601', 'jonaskowalczyk1586@gmail.com', '778663131'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
2, 'Adam', 'Jícha', 35, 'Muž', 'Horymírova 13', 'Praha', '11100', 'adamjicha@seznam.cz', '524369815'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
3, 'Michal', 'Bořic', 80, 'Muž', 'Hradecká 14', 'Cvilín', '72103', 'michalboric@email.cz', '605862231'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
4, 'Debora', 'Mazáková', 15, 'Žena', 'Zámecká 13', 'Zlín', '74535', 'deboramazakova@seznam.cz', '741563285'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
5, 'Veronika', 'Bláhová', 23, 'Žena', 'Klášterní 69', 'Most', '25378', 'vercablahova@gmail.com', '654875213'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
6, 'Zuzana', 'Šestáková', 19, 'Žena', 'Nádražní 53/10', 'Kameník', '20506', 'zuzsestakova@seznam.cz', '765421356'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
7, 'Pavel', 'Šmíd', 28, 'Muž', 'Kovářova 96', 'České Budějovice', '35010', 'pavelsmid@centrum.cz', '775654852'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
8, 'Adam', 'Trnka', 13, 'Muž', 'Kvasimodova 2', 'Velké Hoštice', '72156', 'adamtrnka@gmail.com', '774653213'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
9, 'Vladimír', 'Morous', 25, 'Muž', 'Osvoboditelů 17', 'Havířov', '71289', 'vladimirekmourousek@seznam.cz', '608542152'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
10, 'Ben', 'Chico', 27, 'Muž', 'Zalidněná 12', 'Plevovice', '72564', 'benchico@gmail.com', '604235867'
);


INSERT INTO TbCustomers(ID, Name, Surname, Age, Gender, Street, City, PostCode, Email, PhoneNumber)
VALUES
(
11, 'Světlana', 'Mojmírová', 36, 'Žena', 'Životická 25', 'Mokré Lazce', '72584', 'svetlanamojmirova@seznam.cz', '742879168'
);

Now you can run the API and see, how it works. You can use Postman for testing.

For finding all customers: ../api/Customers
For finding one customer by their ID: ../api/Customers/"ID" (with no quotation marks)
For adding new customer: /api/Customers

To make this works, you have to add one header: Content-Type and Value: application/json into it.
Then you can just write down the information of your customer. Data has to be in JSON format.

You can use this for instance:

{
    "id": 20,
    "name": "Zdenka",
    "surname": "Markova",
    "age": 19,
    "gender": "Žena",
    "street": "Vladimirova 15",
    "city": "Nebořice",
    "postCode": "78584",
    "email": "zdenkamarkova@seznam.cz",
    "phoneNumber": "785164962"
}

For editing saved customer: ../api/Customers/"ID" (ID of the customer, who you want to edit)
And of course adding a body. Id in the body has to mach with the ID which you used in the link.

For deleting customer: ../api/Customer/"ID" (ID of customer, who you want to delete).

I hope everything works fine.










  


