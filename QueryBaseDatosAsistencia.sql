USE master
GO
CREATE DATABASE RegistroDeAsistencia
GO
USE RegistroDeAsistencia
GO
--DROP DATABASE RegistroDeAsistencia
--CREACION DE TABLAS
--TABLA DOCENTE
CREATE TABLE DOCENTES
(
CodDocente varchar(8) not null,
NombreDocente varchar(50),
ApellidoDocente varchar(50),
Contraseña varchar(max),
CorreoElectronico varchar(max),
)
--TABLA ESTUDIANTE
CREATE TABLE ESTUDIANTES
(
CodCarnet varchar(8) not null,
NombreAlumno varchar(40),
CorreoAlumno varchar(25),
)
--TABLA ASIGNATURA
CREATE TABLE ASIGNATURAS
(
CodGrupo varchar(8) not null,
CodDocente varchar(8) not null,
CodCarnet varchar(8) not null,
)
--TABLA ASISTENCIA
CREATE TABLE ASISTENCIAS
(
CodAsistencia int identity(1,1) not null,
HoraEntrada date,
HoraSalida date,
CodGrupo varchar(8),
Asistencia bit,
)

--LLAVES PRIMARIAS
ALTER TABLE DOCENTES
ADD CONSTRAINT PK_CodDocente
PRIMARY KEY (CodDocente)
GO

ALTER TABLE ESTUDIANTES
ADD CONSTRAINT PK_CodCarnet
PRIMARY KEY (CodCarnet)
GO

ALTER TABLE ASIGNATURAS
ADD CONSTRAINT PK_CodGrupo
PRIMARY KEY (CodGrupo)
GO

ALTER TABLE ASISTENCIAS
ADD CONSTRAINT PK_CodAsistencia
PRIMARY KEY (CodAsistencia)
GO

--LLAVES FORANEAS
ALTER TABLE ASIGNATURAS
ADD CONSTRAINT FK_CodDocente
FOREIGN KEY(CodDocente)
REFERENCES DOCENTES(CodDocente)

ALTER TABLE ASIGNATURAS
ADD CONSTRAINT FK_CodCarnet
FOREIGN KEY(CodCarnet)
REFERENCES ESTUDIANTES(CodCarnet)

ALTER TABLE ASISTENCIAS
ADD CONSTRAINT FK_CodGrupo
FOREIGN KEY(CodGrupo)
REFERENCES ASIGNATURAS(CodGrupo)

--Procedimientos
create proc CrearDocente
@CodDocente varchar(8),
@NombreDocente varchar(50),
@ApellidoDocente varchar(50),
@Contraseña varchar(max),
@CorreoElectronico varchar(max)
as
INSERT INTO DOCENTES VALUES(@CodDocente,@NombreDocente,@ApellidoDocente,@Contraseña,@CorreoElectronico)
GO

create proc EditarDocente
@CodDocente varchar(8),
@NombreDocente varchar(50),
@ApellidoDocente varchar(50),
@Contraseña varchar(max),
@CorreoElectronico varchar(max)
As
UPDATE DOCENTES SET Contraseña=@Contraseña,NombreDocente=@NombreDocente,ApellidoDocente=@ApellidoDocente,CorreoElectronico=@CorreoElectronico
where CodDocente=@CodDocente
go

create proc BuscarCodigoDocente
@CodDocente varchar(8)
as
SELECT*FROM DOCENTES
WHERE CodDocente=@CodDocente
GO

--Pruebas
exec CrearDocente 'VC190544','Francisco José','Valle Cornejo','ratchet00','frankjose00@gmail.com'

exec EditarDocente 'VC190544','Cosme','Fulanito','betho00','vallecesco@gmail.com'

exec BuscarCodigoDocente VC190544

SELECT*FROM DOCENTES