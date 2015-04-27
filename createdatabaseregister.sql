USE master ;
GO
CREATE DATABASE Register
ON 
( NAME = Register_dat,
    FILENAME = 'C:\register\regdat.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 )
LOG ON
( NAME = Register_log,
    FILENAME = 'C:\register\reglog.ldf',
    SIZE = 5MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 5MB ) ;
GO