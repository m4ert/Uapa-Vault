CREATE DATABASE PacientesDB;
GO

USE PacientesDB;
GO

CREATE TABLE Pacientes (
    codigopac     VARCHAR(50) NOT NULL,
    nombrepac     VARCHAR(50) NOT NULL,
    apelldiopac   VARCHAR(50) NOT NULL,
    direccionpac  VARCHAR(100),
    telefonopac   VARCHAR(20),
    estatuspac    BIT DEFAULT 1,

    CONSTRAINT PK_Pacientes PRIMARY KEY (codigopac)
);
GO