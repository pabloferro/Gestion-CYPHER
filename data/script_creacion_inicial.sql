USE GD2C2013
GO
SET ANSI_NULLS ON
GO 
SET QUOTED_IDENTIFIER ON
GO

BEGIN TRAN

GO
CREATE SCHEMA CIPHER
GO

CREATE TABLE CIPHER.ROL(
	ROL_CODIGO	INT 	PRIMARY KEY	 Identity(1,1),
	ROL_NOMBRE	nvarchar(255) 	UNIQUE,
	ROL_INHABILITADO	Bit DEFAULT 0,
)

CREATE TABLE CIPHER.FUNCIONALIDAD(
	FUNC_CODIGO INT PRIMARY KEY Identity(1,1),
	FUNC_NOMBRE nvarchar(255) NOT NULL,
)

CREATE TABLE CIPHER.FUNCIONALIDAD_POR_ROL(
	FUNCROL_ROL	INT REFERENCES CIPHER.ROL,
	FUNCROL_FUNC	INT REFERENCES CIPHER.FUNCIONALIDAD,
	PRIMARY KEY(FUNCROL_ROL,FUNCROL_FUNC)
)

CREATE TABLE CIPHER.USUARIO(
	USUARIO_NOM	NVARCHAR(255)	PRIMARY KEY NOT NULL,
	USUARIO_PASS	NVARCHAR(255)	NOT NULL,
	USUARIO_LOGINSFALLIDOS	INT DEFAULT 0,
)

CREATE TABLE CIPHER.ROLES_POR_USUARIO(
	ROLUS_USUARIO	NVARCHAR(255) REFERENCES CIPHER.USUARIO,
	ROLUS_ROL	INT	REFERENCES CIPHER.ROL,
	PRIMARY KEY (ROLUS_USUARIO,ROLUS_ROL)
)

----------------------------
CREATE TABLE CIPHER.PLANCLINICA(
	PLAN_CODIGO	INT PRIMARY KEY,
	PLAN_DESC NVARCHAR(255),
	PLAN_BONOFARMACIAPRECIO	INT	NOT NULL,
	PLAN_BONOCONSULTAPRECIO	INT	NOT NULL,
)

CREATE TABLE CIPHER.AFILIADO(
	AFIL_NROAFILIADO	INT	PRIMARY KEY,
	AFIL_PLAN	INT	REFERENCES CIPHER.PLANCLINICA,
	AFIL_ACTIVO	BIT DEFAULT 1,
	AFIL_FECHABAJA DATETIME default null,
	AFIL_NOMBRE NVARCHAR(255),
	AFIL_APELLIDO NVARCHAR(255),
	AFIL_ESTADOCIVIL CHAR(11),
	AFIL_CANTFAMILIARES INT DEFAULT 0,
	AFIL_TELEFONO NUMERIC(18,0),
	AFIL_DNI INT ,
	AFIL_DIRE NVARCHAR(255),
	AFIL_MAIL NVARCHAR(255),
	AFIL_FECHANAC DATETIME,
	AFIL_SEXO CHAR(1) DEFAULT 'X'
)

CREATE TABLE CIPHER.MODIFICACIONPLAN(
	MODPLAN_CODIGO INT PRIMARY KEY IDENTITY(1,1),
	MODPLAN_NROAFILIADO	INT	REFERENCES CIPHER.AFILIADO,
	MODPLAN_PLANANTERIOR INT REFERENCES CIPHER.PLANCLINICA,
	MODPLAN_PLANNUEVO INT REFERENCES CIPHER.PLANCLINICA,
	MODPLAN_FECHA DATETIME,
	MODPLAN_MOTIVO NVARCHAR(255)
)

CREATE TABLE CIPHER.TIPOESPECIALIDAD(
	TIPOESP_CODIGO INT PRIMARY KEY,
	TIPOESP_DESC	NVARCHAR(50),
)

CREATE TABLE CIPHER.ESPECIALIDAD(
	ESP_CODIGO INT PRIMARY KEY,
	ESP_DESC NVARCHAR(50),
	ESP_TIPO INT REFERENCES CIPHER.TIPOESPECIALIDAD
)


CREATE TABLE CIPHER.MEDICO(
	MED_CODIGO INT PRIMARY KEY IDENTITY(1,1),
	MED_MATRICULA INT,
	MED_NOMBRE NVARCHAR(50),
	MED_APELLIDO NVARCHAR(50),
	MED_TELEFONO INT,
	MED_DNI INT ,
	MED_DIRECCION NVARCHAR(40),
	MED_MAIL NVARCHAR(70),
	MED_FECHANAC DATETIME,
)

CREATE TABLE CIPHER.AGENDA(
	AGEN_MEDICO INT PRIMARY KEY REFERENCES CIPHER.MEDICO, 
	AGEN_FECHAI DATETIME,
	AGEN_FECHAF DATETIME
)

CREATE TABLE CIPHER.AGENDA_DIA(
	AGDI_MEDICO INT REFERENCES CIPHER.MEDICO, 
	AGDI_DIA SMALLINT,
	AGDI_HORAI TIME,
	AGDI_HORAF TIME,
	PRIMARY KEY (AGDI_MEDICO,AGDI_DIA),
)

CREATE TABLE CIPHER.ESPECIALIDAD_POR_MEDICO(
	ESPMED_MEDICO	INT REFERENCES CIPHER.MEDICO,
	ESPMED_ESP INT REFERENCES CIPHER.ESPECIALIDAD,
	PRIMARY KEY (ESPMED_MEDICO,ESPMED_ESP),
)

CREATE TABLE CIPHER.TIPOCANCELACION(
	TIPOCANC_CODIGO INT PRIMARY KEY,
	TIPOCANC_DESCRIPCION NVARCHAR(50),
)

CREATE TABLE CIPHER.TURNO(
	TURN_CODIGO INT PRIMARY KEY,
	TURN_AFILIADO INT REFERENCES CIPHER.AFILIADO,
	TURN_MEDICO INT REFERENCES CIPHER.MEDICO,
	TURN_FECHA DATETIME,
	TURN_CANC_MOTIVO NVARCHAR(100),
	TURN_CANC_TIPO INT REFERENCES CIPHER.TIPOCANCELACION
)

CREATE TABLE CIPHER.TURNO_DISPONIBLE(
	TUDI_MEDICO INT REFERENCES CIPHER.MEDICO,
	TUDI_FECHA DATETIME,
	TUDI_HORAI TIME
	PRIMARY KEY (TUDI_MEDICO, TUDI_FECHA, TUDI_HORAI)
)

CREATE TABLE CIPHER.REGISTROLLEGADA(
	REGLLEG_TURNO INT REFERENCES CIPHER.TURNO PRIMARY KEY,
	REGLLEG_FECHA DATETIME,
)

CREATE TABLE CIPHER.ATENCIONMEDICA(
	ATENCMED_TURNO INT REFERENCES CIPHER.TURNO PRIMARY KEY,
	ATENMED_DIAGNOSTICO NVARCHAR(255),
	ATENMED_SINTOMAS NVARCHAR(255),
)

CREATE TABLE CIPHER.COMPRA(
	COMP_CODIGO INT PRIMARY KEY IDENTITY(1,1),
	COMP_FECHA DATETIME NOT NULL,
	COMP_AFILIADO INT REFERENCES CIPHER.AFILIADO,
	COMP_PLAN INT REFERENCES CIPHER.PLANCLINICA,
)

CREATE TABLE CIPHER.BONOFARMACIA(
	BONF_CODIGO INT PRIMARY KEY,
	BONF_COMPRA INT REFERENCES CIPHER.COMPRA,
	BONF_ATENCION INT REFERENCES CIPHER.ATENCIONMEDICA,
	BONF_AFILIADOCONSUMIO INT REFERENCES CIPHER.AFILIADO,
	BONOF_FECHAIMPRESION DATETIME,
	BONOF_FECHAVENCIMIENTO	DATETIME,
)

CREATE TABLE CIPHER.BONOCONSULTA(
	BONC_CODIGO INT PRIMARY KEY,
	BONC_COMPRA INT REFERENCES CIPHER.COMPRA,
	BONC_AFILIADOCONSUMIO INT REFERENCES CIPHER.AFILIADO,
	BONC_FECHAIMPRESION DATETIME,
)


CREATE TABLE CIPHER.MEDICAMENTO_POR_RECETA(
	MEDREC_MEDICAM NVARCHAR(255),
	MEDREC_RECETA INT REFERENCES CIPHER.BONOFARMACIA,
	MEDREC_CANTIDAD SMALLINT,
	PRIMARY KEY (MEDREC_MEDICAM,MEDREC_RECETA),
)

GO

---NUMERO DE AFILIADO
CREATE FUNCTION CIPHER.ULTIMOAFILIADO() RETURNS INT
AS
BEGIN
	DECLARE @N INT
	SET @N = (SELECT TOP 1 AFIL_NROAFILIADO FROM CIPHER.AFILIADO ORDER BY AFIL_NROAFILIADO DESC)
	IF (@N IS NULL)
		RETURN 0
	RETURN @N
END

GO

CREATE FUNCTION CIPHER.PROXIMONROAFILIADO()RETURNS INT
AS 
BEGIN
	DECLARE @NRO INT
	SELECT @NRO = (CIPHER.ULTIMOAFILIADO() / 100) +1
	RETURN (@NRO * 100 + 1)
END

GO

CREATE FUNCTION CIPHER.PROXIMONROTURNO()RETURNS INT
AS 
BEGIN
	DECLARE @N INT
	SET @N = (SELECT TOP 1 TURN_CODIGO FROM CIPHER.TURNO ORDER BY TURN_CODIGO DESC)
	IF (@N IS NULL)
		RETURN 1
	RETURN @N + 1
END

GO
--/NUMERO DE AFILIADO

----------MIGRACION
--declare @time dateTime
--declare @s nvarchar(255)
--set @s=(select * from openrowset (bulk N'C:\Archivo Configuracion.ini',single_clob) as contents)
--set @s=RIGHT(@s,10)
--set @time=CONVERT(datetime,@s,103)
--El primer d�a de la semana es Lunes
SET DATEFIRST 1
--Carga de los distintos planes
INSERT INTO CIPHER.PLANCLINICA(PLAN_CODIGO,PLAN_DESC,PLAN_BONOCONSULTAPRECIO,PLAN_BONOFARMACIAPRECIO)
	SELECT DISTINCT Plan_Med_Codigo,Plan_Med_Descripcion,Plan_Med_Precio_Bono_Consulta,Plan_Med_Precio_Bono_Farmacia from gd_esquema.Maestra

--Carga de todos los afiliados
--INSERT INTO CIPHER.AFILIADO(AFIL_NROAFILIADO, AFIL_NOMBRE,AFIL_APELLIDO,AFIL_DNI,AFIL_DIRE,AFIL_TELEFONO,AFIL_MAIL,AFIL_FECHANAC,AFIL_PLAN) 
--	SELECT DISTINCT CIPHER.PROXIMONROAFILIADO(), Paciente_Nombre,Paciente_Apellido,Paciente_Dni,Paciente_Direccion,Paciente_Telefono,Paciente_Mail,Paciente_Fecha_Nac,Plan_Med_Codigo FROM gd_esquema.Maestra

--CON CURSORES POR EL NRO
DECLARE CAFILIADOS CURSOR
FOR SELECT DISTINCT Paciente_Nombre,Paciente_Apellido,Paciente_Dni,Paciente_Direccion,Paciente_Telefono,Paciente_Mail,Paciente_Fecha_Nac,Plan_Med_Codigo FROM gd_esquema.Maestra
DECLARE @Paciente_Nombre NVARCHAR(255),@Paciente_Apellido NVARCHAR(255),@Paciente_Dni INT,
	@Paciente_Direccion NVARCHAR(255),@Paciente_Telefono NUMERIC(18,0) ,@Paciente_Mail NVARCHAR(255),
	@Paciente_Fecha_Nac DATETIME ,@Plan_Med_Codigo INT
OPEN CAFILIADOS
FETCH CAFILIADOS INTO @Paciente_Nombre,@Paciente_Apellido,@Paciente_Dni,@Paciente_Direccion,@Paciente_Telefono,@Paciente_Mail,@Paciente_Fecha_Nac,@Plan_Med_Codigo
WHILE @@FETCH_STATUS = 0
BEGIN
	INSERT INTO CIPHER.AFILIADO(AFIL_NROAFILIADO, AFIL_NOMBRE,AFIL_APELLIDO,AFIL_DNI,AFIL_DIRE,AFIL_TELEFONO,AFIL_MAIL,AFIL_FECHANAC,AFIL_PLAN) 
	VALUES(CIPHER.PROXIMONROAFILIADO(),@Paciente_Nombre,@Paciente_Apellido,@Paciente_Dni,@Paciente_Direccion,@Paciente_Telefono,@Paciente_Mail,@Paciente_Fecha_Nac,@Plan_Med_Codigo)
	FETCH CAFILIADOS INTO @Paciente_Nombre,@Paciente_Apellido,@Paciente_Dni,@Paciente_Direccion,@Paciente_Telefono,@Paciente_Mail,@Paciente_Fecha_Nac,@Plan_Med_Codigo
END
CLOSE CAFILIADOS
DEALLOCATE CAFILIADOS
GO
--

--Carga de todos los tipos de especialidad
INSERT INTO CIPHER.TIPOESPECIALIDAD(TIPOESP_CODIGO,TIPOESP_DESC)
	SELECT DISTINCT Tipo_Especialidad_Codigo,Tipo_Especialidad_Descripcion FROM gd_esquema.Maestra where Tipo_Especialidad_Codigo is not null 

--Carga de todas las especialidades 
INSERT INTO CIPHER.ESPECIALIDAD(ESP_CODIGO,ESP_DESC,ESP_TIPO)
	SELECT DISTINCT Especialidad_Codigo,Especialidad_Descripcion,Tipo_Especialidad_Codigo FROM gd_esquema.Maestra where Especialidad_Codigo is not null

--Carga de los medicos
INSERT INTO CIPHER.MEDICO(MED_NOMBRE,MED_APELLIDO,MED_DNI,MED_DIRECCION,MED_TELEFONO,MED_MAIL,MED_FECHANAC)
	SELECT DISTINCT Medico_Nombre,Medico_Apellido,Medico_Dni,Medico_Direccion,Medico_Telefono,Medico_Mail,Medico_Fecha_Nac FROM gd_esquema.Maestra where Medico_Apellido is not null

--Carga de las especialidades de cada medico
INSERT INTO CIPHER.ESPECIALIDAD_POR_MEDICO(ESPMED_ESP,ESPMED_MEDICO)
	SELECT DISTINCT Especialidad_Codigo,(SELECT MED_CODIGO FROM CIPHER.MEDICO WHERE MED_DNI=Medico_Dni) FROM gd_esquema.Maestra WHERE Especialidad_Codigo IS NOT NULL

--Carga de todos los turnos planificados de la tabla maestra
INSERT INTO CIPHER.TURNO(TURN_CODIGO,TURN_AFILIADO,TURN_FECHA,TURN_MEDICO)
	SELECT DISTINCT Turno_Numero,(SELECT TOP 1 AFIL_NROAFILIADO FROM CIPHER.AFILIADO WHERE AFIL_DNI=Paciente_Dni),Turno_Fecha,(SELECT MED_CODIGO FROM CIPHER.MEDICO WHERE MED_DNI=Medico_Dni) FROM gd_esquema.Maestra WHERE Turno_Numero IS NOT NULL

--Carga de la agenda del medico, considerando los dias y horarios de los turnos planificados, se descarta el domingo
INSERT INTO CIPHER.AGENDA(AGEN_MEDICO, AGEN_FECHAI, AGEN_FECHAF)
	SELECT DISTINCT TURN_MEDICO, MIN(TURN_FECHA),MAX(TURN_FECHA)
	FROM CIPHER.TURNO
	WHERE DATEPART(WEEKDAY,TURN_FECHA)<>7
	GROUP BY TURN_MEDICO

INSERT INTO CIPHER.AGENDA_DIA(AGDI_MEDICO,AGDI_DIA,AGDI_HORAI,AGDI_HORAF)
	SELECT DISTINCT TURN_MEDICO,DATEPART(WEEKDAY,TURN_FECHA),MIN(CONVERT(TIME,TURN_FECHA)),MAX(CONVERT(TIME,TURN_FECHA))
	FROM CIPHER.TURNO
	GROUP BY TURN_MEDICO,DATEPART(WEEKDAY,TURN_FECHA)
	HAVING DATEPART(WEEKDAY,TURN_FECHA)<>7

--Carga de todas las compras de bonos
INSERT INTO CIPHER.COMPRA(COMP_AFILIADO,COMP_FECHA,COMP_PLAN)
	SELECT DISTINCT (SELECT TOP 1 AFIL_NROAFILIADO FROM CIPHER.AFILIADO WHERE Paciente_Dni=AFIL_DNI), Compra_Bono_Fecha,Plan_Med_Codigo FROM gd_esquema.Maestra WHERE Bono_Consulta_Numero IS NOT NULL AND Turno_Fecha IS NULL 

--Carga de todos los bonos consulta, el afiliado que consumio se lo deja en null 
INSERT INTO CIPHER.BONOCONSULTA(BONC_CODIGO,BONC_FECHAIMPRESION,BONC_AFILIADOCONSUMIO,BONC_COMPRA)
	SELECT DISTINCT Bono_Consulta_Numero,Bono_Consulta_Fecha_Impresion,NULL,(SELECT COMP_CODIGO FROM CIPHER.COMPRA WHERE COMP_AFILIADO=(SELECT TOP 1 AFIL_NROAFILIADO FROM CIPHER.AFILIADO WHERE Paciente_Dni=AFIL_DNI) AND COMP_FECHA=Compra_Bono_Fecha )
	FROM gd_esquema.Maestra WHERE Bono_Consulta_Numero IS NOT NULL AND Turno_Fecha IS NULL

--Update del campo que representa el afiliado que consumio los bono consulta
UPDATE CIPHER.BONOCONSULTA SET BONC_AFILIADOCONSUMIO=(SELECT (SELECT TOP 1 AFIL_NROAFILIADO FROM CIPHER.AFILIADO WHERE Paciente_Dni=AFIL_DNI)FROM gd_esquema.Maestra WHERE BONC_CODIGO=Bono_Consulta_Numero AND Turno_Fecha IS NOT NULL)
WHERE (SELECT Turno_Fecha FROM gd_esquema.Maestra WHERE Bono_Consulta_Numero=BONC_CODIGO AND Turno_Fecha IS NOT NULL) IS NOT NULL

--Carga de todos los bonos farmacia, el afiliado que consumio se lo deja en null 
INSERT INTO CIPHER.BONOFARMACIA(BONF_CODIGO,BONOF_FECHAIMPRESION,BONF_AFILIADOCONSUMIO,BONF_COMPRA,BONOF_FECHAVENCIMIENTO)
	SELECT DISTINCT Bono_Farmacia_Numero,Bono_Farmacia_Fecha_Impresion,NULL,(SELECT COMP_CODIGO FROM CIPHER.COMPRA WHERE COMP_AFILIADO=(SELECT TOP 1 AFIL_NROAFILIADO FROM CIPHER.AFILIADO WHERE Paciente_Dni=AFIL_DNI) AND COMP_FECHA=Compra_Bono_Fecha ),Bono_Farmacia_Fecha_Vencimiento
	FROM gd_esquema.Maestra WHERE Bono_Farmacia_Numero IS NOT NULL AND Turno_Fecha IS NULL

--Update del campo que representa el afiliado que consumio los bono farmacia
UPDATE CIPHER.BONOFARMACIA SET BONF_AFILIADOCONSUMIO=(SELECT (SELECT TOP 1 AFIL_NROAFILIADO FROM CIPHER.AFILIADO WHERE Paciente_Dni=AFIL_DNI)FROM gd_esquema.Maestra WHERE BONF_CODIGO=Bono_Consulta_Numero AND Turno_Fecha IS NOT NULL)
WHERE (SELECT Turno_Fecha FROM gd_esquema.Maestra WHERE Bono_Farmacia_Numero=BONF_CODIGO AND Turno_Fecha IS NOT NULL) IS NOT NULL

--Carga de todas las atenciones medicas generadas
INSERT INTO CIPHER.ATENCIONMEDICA(ATENCMED_TURNO,ATENMED_DIAGNOSTICO,ATENMED_SINTOMAS)
	SELECT DISTINCT Turno_Numero,Consulta_Enfermedades,Consulta_Sintomas
	FROM gd_esquema.Maestra WHERE Consulta_Enfermedades IS NOT NULL 

--Carga de todos los medicantos recetados asociandolos a sus correspondientes bonos farmacia
INSERT INTO CIPHER.MEDICAMENTO_POR_RECETA(MEDREC_RECETA,MEDREC_MEDICAM,MEDREC_CANTIDAD)
	SELECT DISTINCT Bono_Farmacia_Numero,Bono_Farmacia_Medicamento,1
	FROM gd_esquema.Maestra WHERE Consulta_Enfermedades IS NOT NULL

--Carga de todos los registro de llegada	
INSERT INTO CIPHER.REGISTROLLEGADA(REGLLEG_TURNO,REGLLEG_FECHA)
	SELECT DISTINCT Turno_Numero,Turno_Fecha
	FROM gd_esquema.Maestra
	WHERE Bono_Consulta_Numero IS NOT NULL AND Turno_Numero IS NOT NULL

INSERT INTO CIPHER.TIPOCANCELACION(TIPOCANC_CODIGO,TIPOCANC_DESCRIPCION)
	SELECT 1,'Desconocido'

--Update de todos los turnos que se presuponen cancelados
UPDATE  CIPHER.TURNO  SET TURN_CANC_TIPO=1
	where 
	TURN_CODIGO IN (SELECT Turno_Numero 
			FROM gd_esquema.Maestra
			WHERE Turno_Fecha<GETDATE() and Bono_Consulta_Numero is null and Turno_Numero is not null and Turno_Numero not in (select REGLLEG_TURNO from CIPHER.REGISTROLLEGADA))

--Cancelacion de los turnos que caen Domingo
INSERT INTO CIPHER.TIPOCANCELACION(TIPOCANC_CODIGO,TIPOCANC_DESCRIPCION)
	SELECT 2,'Cambio Politicas'
	
UPDATE CIPHER.TURNO SET TURN_CANC_TIPO=2,TURN_CANC_MOTIVO='La clinica no atiende los domingos'
	where 
	TURN_FECHA>GETDATE() AND DAY(TURN_FECHA)=7

----------CARGA DE DATO PARA EL LOGIN
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('ROL')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('REGISTRO USUARIO')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('AFILIADOS')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('PROFESIONAL')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('ESPECIALIDADES')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('PLAN')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('AGENDA')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('BONOS')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('TURNO')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('REGISTRO DE LLEGADA')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('REGISTRO DE RESULTADO')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('CANCELAR')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('RECETA')
INSERT INTO CIPHER.FUNCIONALIDAD VALUES('ESTADISTICAS')

INSERT INTO CIPHER.ROL VALUES('ADMINISTRACION GENERAL',1)
INSERT INTO CIPHER.USUARIO VALUES('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',0)
INSERT INTO CIPHER.ROLES_POR_USUARIO VALUES('admin',1)

DECLARE @i int
set @i=1
WHILE(@i <= 14)
begin
	INSERT INTO CIPHER.FUNCIONALIDAD_POR_ROL VALUES (1,@i)
	set @i=@i+1
end

GO


---------------------------------------------------
CREATE PROCEDURE CIPHER.CHECKLOGIN(@usuario nvarchar(255),@pass nvarchar(255))
AS
BEGIN
declare @result int

set @result=(SELECT CASE WHEN USUARIO_LOGINSFALLIDOS>2 then -1 when  USUARIO_PASS=@pass THEN 1 END
FROM CIPHER.USUARIO
WHERE USUARIO_NOM = @usuario 
)

if (@result=1)
UPDATE USUARIO SET USUARIO_LOGINSFALLIDOS=0
WHERE USUARIO_NOM=@usuario
else
UPDATE USUARIO SET USUARIO_LOGINSFALLIDOS=USUARIO_LOGINSFALLIDOS+1
WHERE USUARIO_NOM=@usuario

if(@result is null)
select 0
else
select @result
END
GO


CREATE PROCEDURE CIPHER.GETFUNCIONALIDADES(@USUARIO nvarchar(255),@ROL int)
AS
BEGIN
select FUNCROL_FUNC
from CIPHER.ROLES_POR_USUARIO JOIN CIPHER.FUNCIONALIDAD_POR_ROL ON ROLUS_ROL=FUNCROL_ROL
where ROLUS_ROL= @ROL AND ROLUS_USUARIO =@USUARIO
END

GO

--ROLES
CREATE PROCEDURE CIPHER.GETFUNCIONALIDADESNUEVOROL
AS
BEGIN
	select 0 HAB, FUNC_CODIGO CODIGO, FUNC_NOMBRE NOMBRE
	from CIPHER.FUNCIONALIDAD
	order by FUNC_CODIGO ASC
END

GO

CREATE PROCEDURE CIPHER.GETFUNCIONALIDADESROL(@ROL int)
AS
BEGIN
	select 
		(CASE when exists(select * from CIPHER.FUNCIONALIDAD_POR_ROL
						  where FUNCROL_ROL = @ROL AND FUNCROL_FUNC = FUNC_CODIGO) 
		 then 1 else 0 end) HAB,
		 FUNC_CODIGO CODIGO,
		 FUNC_NOMBRE NOMBRE
	from CIPHER.FUNCIONALIDAD
	order by FUNC_CODIGO ASC
END

GO

CREATE PROCEDURE CIPHER.GETNOMBRESROLES
AS
BEGIN
	select ROL_CODIGO CODE, ROL_INHABILITADO HAB, ROL_NOMBRE NOMBRE from ROL order by ROL_CODIGO
END

GO

CREATE PROCEDURE CIPHER.UPDATEROL(@ROL int, @NOMBRE nvarchar(255))
AS
BEGIN
	UPDATE CIPHER.ROL SET ROL_NOMBRE = @NOMBRE where ROL_CODIGO = @ROL
END

GO

CREATE PROCEDURE CIPHER.UPDATEROLFUNCIONALIDAD(@ROL int, @FUNC int, @ACTIVADA bit)
AS
BEGIN
	IF EXISTS (SELECT * FROM CIPHER.FUNCIONALIDAD_POR_ROL WHERE FUNCROL_ROL = @ROL AND FUNCROL_FUNC = @FUNC)
	 begin
		IF (@ACTIVADA=0) 
			DELETE FROM CIPHER.FUNCIONALIDAD_POR_ROL WHERE FUNCROL_ROL = @ROL AND FUNCROL_FUNC = @FUNC
	 end
	ELSE
	 begin
		IF (@ACTIVADA=1) 
			INSERT INTO CIPHER.FUNCIONALIDAD_POR_ROL (FUNCROL_ROL, FUNCROL_FUNC) VALUES (@ROL, @FUNC)
	 end
END

GO

CREATE PROCEDURE CIPHER.HABILITARROL(@ROL int, @HABILITADO bit)
AS
BEGIN
	if @HABILITADO = 0
		if (SELECT ROL_INHABILITADO FROM CIPHER.ROL WHERE ROL_CODIGO = @ROL) = 1
				DELETE FROM CIPHER.ROLES_POR_USUARIO WHERE ROLUS_ROL = @ROL		
	--
	UPDATE CIPHER.ROL SET ROL_INHABILITADO = @HABILITADO where ROL_CODIGO = @ROL 						
END
--/ROLES

GO

--PLANES
CREATE PROCEDURE CIPHER.GETPLANES
AS
BEGIN
	SELECT PLAN_CODIGO FROM CIPHER.PLANCLINICA
END
--/PLANES

GO

--AFILIADOS
CREATE FUNCTION CIPHER.NROGRUPO(@NRO INT) RETURNS INT
AS
BEGIN
	RETURN (@NRO / 100)
END

GO

CREATE FUNCTION CIPHER.NROFAMILIAR(@NRO INT) RETURNS INT
AS
BEGIN
	RETURN (@NRO % 100)
END

GO

CREATE PROCEDURE CIPHER.CAMBIARPLAN(@AFILIADO INT, @PLAN INT, @FECHA DATETIME, @MOTIVO NVARCHAR(255))
AS
BEGIN
	DECLARE @PLAN_ANTERIOR INT
	SELECT @PLAN_ANTERIOR=AFIL_PLAN FROM CIPHER.AFILIADO WHERE AFIL_NROAFILIADO = @AFILIADO
	IF @PLAN <> @PLAN_ANTERIOR
	BEGIN
		UPDATE CIPHER.AFILIADO SET AFIL_PLAN = @PLAN WHERE AFIL_NROAFILIADO = @AFILIADO
		INSERT INTO CIPHER.MODIFICACIONPLAN 
			(MODPLAN_NROAFILIADO, MODPLAN_PLANANTERIOR, MODPLAN_PLANNUEVO, MODPLAN_FECHA, MODPLAN_MOTIVO)
		VALUES(@AFILIADO, @PLAN_ANTERIOR, @PLAN, @FECHA, @MOTIVO)
	END
END
GO
--/AFILIADOS
---TURNOS
CREATE FUNCTION CIPHER.AGENDADESDE(@MEDICO INT) RETURNS DATETIME
AS
BEGIN
	RETURN (SELECT AGEN_FECHAI FROM CIPHER.AGENDA WHERE AGEN_MEDICO = @MEDICO)
END

GO

CREATE FUNCTION CIPHER.AGENDAHASTA(@MEDICO INT) RETURNS DATETIME
AS
BEGIN
	RETURN (SELECT AGEN_FECHAF FROM CIPHER.AGENDA WHERE AGEN_MEDICO = @MEDICO)
END

GO

CREATE FUNCTION CIPHER.ATIENDEDIA(@MEDICO INT, @DIA INT) RETURNS BIT
AS
BEGIN
	IF EXISTS (SELECT * FROM CIPHER.AGENDA_DIA WHERE AGDI_MEDICO = @MEDICO AND AGDI_DIA = @DIA)
		RETURN 1
	RETURN 0
END

GO

CREATE PROCEDURE CIPHER.FECHASTURNOS(@MEDICO INT, @FECHA DATETIME)
AS
BEGIN
SELECT datename(dw, TUDI_FECHA) 'D�a', TUDI_FECHA 'Fecha'
  FROM CIPHER.TURNO_DISPONIBLE
  GROUP BY TUDI_MEDICO, TUDI_FECHA
END 

GO

CREATE PROCEDURE CIPHER.TURNOSPORFECHA(@MEDICO INT, @FECHA DATETIME)
AS
BEGIN
	SELECT TUDI_HORAI 'Desde', DATEADD(MINUTE, 30, TUDI_HORAI) 'Hasta'
	FROM CIPHER.TURNO_DISPONIBLE
	WHERE TUDI_MEDICO = @MEDICO AND TUDI_FECHA = @FECHA 
END

GO

CREATE PROCEDURE CIPHER.PEDIRTURNO(@MEDICO INT, @AFILIADO INT, @FECHA DATETIME, @HORAI TIME)
AS
BEGIN
	INSERT INTO CIPHER.TURNO (TURN_CODIGO, TURN_AFILIADO, TURN_MEDICO, TURN_FECHA)
	VALUES (CIPHER.PROXIMONROTURNO(), @AFILIADO, @MEDICO, @FECHA+@HORAI)
	
	DELETE FROM TURNO_DISPONIBLE
	WHERE TUDI_MEDICO = @MEDICO AND TUDI_FECHA = @FECHA AND TUDI_HORAI = @HORAI
END

GO
--/TURNOS
COMMIT TRAN