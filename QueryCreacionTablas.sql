
Create database Ingenio;
Use Ingenio;

Create table Usuario
(
	Id int identity(1, 1) primary key,
	Usuario varchar(20),
	Contraseña varchar(10)
);

Create table Clima
(
	Id int identity(1, 1) primary key,
	Ciudad varchar(100) not null,
	FechaHora datetime default getdate(),
	Temperatura varchar(10) not null,
	Humendad float not null,
	Viento varchar(10) not null
);