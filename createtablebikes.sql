use Register;
GO

CREATE TABLE dbo.Bikes
	(BikeId int PRIMARY KEY IDENTITY NOT NULL,
	 RegNumber varchar(30) NOT NULL,
	 Company varchar(30) NULL,
	 Model varchar(20) NULL,
	 Color varchar(15) NOT NULL)
GO