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
CodDocente varchar(6) not null,
NombreDocente varchar(50),
ApellidoDocente varchar(50),
Email nvarchar(300) not null,
Usuario char(10) not null,
Pass nvarchar(100) not null
)


--TABLA ESTUDIANTE
CREATE TABLE ESTUDIANTES
(
CodCarnet varchar(8) not null,
NombreAlumno varchar(40),
CorreoAlumno varchar(25),
Becados varchar(30),
Inscrito varchar(10),
Solvente varchar(25),
Matricula varchar(25),
Carrera varchar(30),
Estado varchar(30),
)

--TABLA ASIGNATURA
CREATE TABLE ASIGNATURAS
(
CodGrupo varchar(8) not null,
CodDocente varchar(6) not null,
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

--PROCEDIMIENTOS ALMACENADOS---

create proc AgregarDocente
@CDocente varchar(6),
@Ndocente varchar(50),
@Adocente varchar(50),
@Correo nvarchar(300),
@User char(10),
@contra nvarchar(100)
as insert into DOCENTES(CodDocente,NombreDocente,ApellidoDocente,Email,Usuario,Pass) values(@CDocente,@Ndocente,@Adocente,@Correo,@User,ENCRYPTBYPASSPHRASE('password',@contra))
go

exec AgregarDocente 'DD102303','Carlos','Martínez','pinochofino@gmail.com','Elprofe','seguro';
select*from DOCENTES;
select Usuario,Email,Pass=CONVERT(nvarchar(100),DECRYPTBYPASSPHRASE('password',pass)) from DOCENTES where Usuario='Elprofe';



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