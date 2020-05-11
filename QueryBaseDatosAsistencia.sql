USE master
GO
CREATE DATABASE RegistroDeAsistencia
GO
SELECT*FROM DOCENTES;
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
Contraseña varchar(max) not null,
CorreoElectronico varchar(max) not null,
Usuario char(10) not null,
)
--TABLA ESTUDIANTE
CREATE TABLE ESTUDIANTES
(
CodCarnet varchar(8) not null,
NombreAlumno varchar(40),
ApellidoAlumno varchar(40),
CorreoAlumno varchar(25),
)
--TABLA ASIGNATURA
CREATE TABLE ASIGNATURAS
(
CodAsignatura int identity(1,1) not null,
NombreAsignatura varchar(70),
CantidadUV int,
)

--TABLA GRUPOS
CREATE TABLE GRUPOS
(
CodGrupo varchar(12) not null,
CodAsignatura int not null,
Año date not null,
Ciclo int not null,
)

CREATE TABLE DETALLE_ALUMNO_GRUPO
(
CodCarnet varchar(8),
CodGrupo varchar(12)
)

CREATE TABLE SESIONES
(
CodSesion int identity(1,1) not null,
CodDocente varchar(8),
CodGrupo varchar(12),
FechaSesion date,
)

CREATE TABLE ASISTENCIAS
(
ConAsistencia int identity(1,1) not null,
CodSesion int,
CodCarnet varchar(8),
HoraEntrada date,
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

ALTER TABLE GRUPOS
ADD CONSTRAINT PK_CodGrupo
PRIMARY KEY (CodGrupo)
GO

ALTER TABLE ASIGNATURAS
ADD CONSTRAINT PK_CodAsignatura
PRIMARY KEY (CodAsignatura)
GO

ALTER TABLE SESIONES
ADD CONSTRAINT PK_CodSesion
PRIMARY KEY (CodSesion)
GO

ALTER TABLE ASISTENCIAS
ADD CONSTRAINT PK_CodAsistencia
PRIMARY KEY (ConAsistencia)
GO

--LLAVES FORANEAS
ALTER TABLE ASISTENCIAS
ADD CONSTRAINT FK_CodSesion
FOREIGN KEY(CodSesion)
REFERENCES SESIONES(CodSesion)

ALTER TABLE ASISTENCIAS
ADD CONSTRAINT FK_CodCarneto
FOREIGN KEY(CodCarnet)
REFERENCES ESTUDIANTES(CodCarnet)

ALTER TABLE DETALLE_ALUMNO_GRUPO
ADD CONSTRAINT FK_CodGrupot
FOREIGN KEY(CodGrupo)
REFERENCES GRUPOS(CodGrupo)

ALTER TABLE DETALLE_ALUMNO_GRUPO
ADD CONSTRAINT FK_CodCarnett
FOREIGN KEY(CodCarnet)
REFERENCES ESTUDIANTES(CodCarnet)

ALTER TABLE GRUPOS
ADD CONSTRAINT FK_CodAsignatura
FOREIGN KEY (CodAsignatura)
REFERENCES ASIGNATURAS(CodAsignatura)

ALTER TABLE SESIONES
ADD CONSTRAINT FK_CodDoc
FOREIGN KEY (CodDocente)
REFERENCES DOCENTES(CodDocente)

ALTER TABLE SESIONES
ADD CONSTRAINT FK_Group
FOREIGN KEY (CodGrupo)
REFERENCES GRUPOS(CodGrupo)
GO

--Procedimientos
create proc CrearDocente
@CodDocente varchar(8),
@NombreDocente varchar(50),
@ApellidoDocente varchar(50),
@Contraseña varchar(max),
@CorreoElectronico varchar(max),
@Usuario char(10)
as
INSERT INTO DOCENTES VALUES(@CodDocente,@NombreDocente,@ApellidoDocente,@Contraseña,@CorreoElectronico,@Usuario)
GO

create proc EditarDocente
@CodDocente varchar(8),
@NombreDocente varchar(50),
@ApellidoDocente varchar(50),
@Contraseña varchar(max),
@CorreoElectronico varchar(max),
@Usuario char(10)
As
UPDATE DOCENTES SET Contraseña=@Contraseña,NombreDocente=@NombreDocente,ApellidoDocente=@ApellidoDocente,CorreoElectronico=@CorreoElectronico, Usuario=@Usuario
where CodDocente=@CodDocente
go

create proc BuscarCodigoDocente
@CodDocente varchar(8)
as
SELECT*FROM DOCENTES
WHERE CodDocente=@CodDocente
GO

create proc BuscarContraDocente
@Contraseña varchar(max)
as
SELECT*FROM DOCENTES
WHERE Contraseña=@Contraseña
GO

create proc ConsultarDocentes
as 
select*from Docentes order by CodDocente asc
go


create proc ModificarDOC
@Usuario char(10),
@Contraseña varchar(max)
as update Docentes set Usuario=@Usuario,Contraseña=@Contraseña where Usuario=@Usuario
go

exec ModificarDOC elmario,'1234';
select*from Docentes;

create proc InicioSesion
@Usuario char(10),
@Contraseña varchar(max)
as
SELECT CodDocente FROM DOCENTES
WHERE Usuario=@Usuario AND Contraseña=@Contraseña
GO

create proc RecuperarContraseña
@Usuario char(10)
as
SELECT Usuario, Contraseña,CorreoElectronico  FROM DOCENTES
WHERE Usuario=@Usuario
go

create proc LeerNombreMail
@CodDocente varchar(8)
as 
SELECT NombreDocente,ApellidoDocente,CorreoElectronico FROM DOCENTES
WHERE CodDocente=@CodDocente
go

create proc CrearEstudiantes
@CodCarnet varchar(8),
@NombreAlumno varchar(40),
@ApellidoAlumno varchar(40),
@CorreoAlumno varchar(25)
as
INSERT INTO ESTUDIANTES VALUES(@CodCarnet,@NombreAlumno,@ApellidoAlumno,@CorreoAlumno)
GO

create proc CrearAsignatura
@NombreAsignatura varchar(max),
@CantidadUV int
as
INSERT INTO ASIGNATURAS VALUES(@NombreAsignatura,@CantidadUV)
GO

create proc CrearGrupo
@CodGrupo varchar(12),
@CodAsignatura int,
@Año date,
@Ciclo int
as
INSERT INTO GRUPOS VALUES(@CodGrupo,@CodAsignatura,@Año,@Ciclo)
go

create proc UnirAlumnoGrupo
@CodCarnet varchar(8),
@CodGrupo varchar(12)
as
INSERT INTO DETALLE_ALUMNO_GRUPO VALUES(@CodCarnet,@CodGrupo)
go

create proc CrearSesion
@CodDocente varchar(8),
@CodGrupo varchar(12),
@FechaSesion date
as
INSERT INTO SESIONES VALUES(@CodDocente,@CodGrupo,@FechaSesion)
SELECT SCOPE_IDENTITY() AS 'Identidad'
go

create proc CrearAsistencia
@CodSesion int,
@CodCarnet varchar(8),
@HoraEntrada date
as
INSERT INTO ASISTENCIAS VALUES(@CodSesion,@CodCarnet,@HoraEntrada)
go

create proc EditarAsistencia
@CodSesion int,
@CodCarnet varchar(8),
@HoraEntrada date
as
UPDATE ASISTENCIAS SET HoraEntrada=@HoraEntrada
WHERE CodCarnet=@CodCarnet AND CodSesion=@CodSesion
go

create proc MostrarGrupos
as
select G.CodGrupo, (A.NombreAsignatura+' '+G.CodGrupo)AS'Nombre de Asignatura' From GRUPOS G
INNER JOIN ASIGNATURAS A ON G.CodAsignatura=A.CodAsignatura
go

create proc AlumnosDeSalon
@CodGrupo varchar(12)
as
SELECT E.CodCarnet FROM DETALLE_ALUMNO_GRUPO DAG
INNER JOIN ESTUDIANTES E ON DAG.CodCarnet=E.CodCarnet
WHERE CodGrupo=@CodGrupo
go

create proc MostrarAsistencia
@CodSesion int
as
SELECT E.CodCarnet,(E.ApellidoAlumno+', '+E.NombreAlumno)AS'Apellido, Nombres', FORMAT(HoraEntrada,'dddd, MMMM dd, yyyy hh:mm:ss tt')AS'Hora Entrada' FROM ASISTENCIAS A
INNER JOIN ESTUDIANTES E ON A.CodCarnet=E.CodCarnet
WHERE CodSesion=@CodSesion
go

create proc BusquedaFecha
@CodGrupo varchar(12),
@FechaInicial date,
@FechaFinal date
as
SELECT CodSesion,CodGrupo,FechaSesion FROM SESIONES
WHERE CodGrupo=@CodGrupo AND FechaSesion BETWEEN @FechaInicial AND @FechaFinal
go

--Validaciones
ALTER TABLE ASISTENCIAS
ADD CONSTRAINT DF_horaEntrada
DEFAULT null for HoraEntrada

--Pruebas

exec MostrarGrupos

exec MostrarAsistencia 2
exec EditarAsistencia 39,VC324754,'12-12-12'

exec AlumnosDeSalon ADS044532

exec CrearDocente 'VC190544','Francisco José','Valle Cornejo','ratchet00','frankjose00@gmail.com','CESCO'

exec EditarDocente 'VC190544','Cosme','Fulanito','betho00','vallecesco@gmail.com','VALLE'

exec BuscarCodigoDocente VC190544

exec InicioSesion 'VALLE','betho00'

exec CrearDocente 'DD102303','Carlos','Martínez','seguro','pinochofino@gmail.com','Elprofe';
select*from DOCENTES;
DELETE DOCENTES

exec RecuperarContraseña VALLE

exec LeerNombreMail VC190544

SELECT Usuario, Contraseña,CorreoElectronico  FROM DOCENTES
WHERE CodDocente='vc190544'

exec CrearEstudiantes 'VC324654','Peto',' Amaya','petito@gmail.com'
exec CrearEstudiantes 'VC498750','Juanito',' Alcachofa','juanito69@gmail.com'
exec CrearEstudiantes 'VC498750','Karla',' Valle','pussydestroyer@gmail.com'
exec CrearEstudiantes 'VC998765','Carolina',' Salinas','conejitobueno@gmail.com'

exec CrearAsignatura 'Analisis de Diseño Informatico','4'

exec CrearAsignatura 'Programacion Orientada a Objetos','3'

exec CrearAsignatura 'PED','5'

exec CrearGrupo 'ADS044532','1','2020','03'

exec CrearGrupo 'POO6378','2','2021','01'

exec CrearGrupo 'PED4323','3','2019','02'

select*from GRUPOS
select*from ASIGNATURAS
select*from ESTUDIANTES

exec UnirAlumnoGrupo VC324654,ADS044532
exec UnirAlumnoGrupo VC324654,POO6378
exec UnirAlumnoGrupo VC324754,ADS044532
exec UnirAlumnoGrupo VC324754, PED4323
exec UnirAlumnoGrupo VC498750,ADS044532
exec UnirAlumnoGrupo VC498750,POO6378
exec UnirAlumnoGrupo VC498750,PED4323

SELECT E.NombreAlumno, A.NombreAsignatura FROM GRUPOS G
INNER JOIN DETALLE_ALUMNO_GRUPO DG ON G.CodGrupo=DG.CodGrupo
INNER JOIN ESTUDIANTES E ON DG.CodCarnet=E.CodCarnet
INNER JOIN ASIGNATURAS A ON G.CodAsignatura=A.CodAsignatura
WHERE G.CodGrupo='ADS044532'

select*from DETALLE_ALUMNO_GRUPO

exec CrearSesion VC190544,PED4323,'11-11-11'
exec CrearSesion VC190544,POO6378,'11-11-11'
exec CrearSesion VC190544,ADS044532,'12-12-12'

exec CrearAsistencia 1,VC324754,'11-11-11'
exec CrearAsistencia 1,VC498750,'11-11-11'

select*from ASISTENCIAS

select*from SESIONES
DELETE FROM SESIONES
WHERE CodSesion>3