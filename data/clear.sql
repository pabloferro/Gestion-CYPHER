USE GD2C2013

DROP TABLE CIPHER.FUNCIONALIDAD_POR_ROL
DROP TABLE CIPHER.ROLES_POR_USUARIO
DROP TABLE CIPHER.ROL
DROP TABLE CIPHER.FUNCIONALIDAD
DROP TABLE CIPHER.USUARIO

DROP TABLE CIPHER.MEDICAMENTO_POR_RECETA

DROP TABLE CIPHER.BONOFARMACIA
DROP TABLE CIPHER.BONOCONSULTA
DROP TABLE CIPHER.COMPRA

DROP TABLE CIPHER.ATENCIONMEDICA
DROP TABLE CIPHER.REGISTROLLEGADA

DROP TABLE CIPHER.CANCELACIONTURNO
DROP TABLE CIPHER.TURNO
DROP TABLE CIPHER.TIPOCANCELACION

DROP TABLE CIPHER.ESPECIALIDAD_POR_MEDICO
DROP TABLE CIPHER.ESPECIALIDAD
DROP TABLE CIPHER.TIPOESPECIALIDAD

DROP TABLE CIPHER.AGENDA
DROP TABLE CIPHER.AGENDA_DIA
DROP TABLE CIPHER.TURNO_DISPONIBLE
DROP TABLE CIPHER.MEDICO

DROP TABLE CIPHER.MODIFICACIONPLAN
DROP TABLE CIPHER.AFILIADO
DROP TABLE CIPHER.PLANCLINICA

DROP TABLE CIPHER.TIPO_DOCUMENTO

DROP PROCEDURE CIPHER.CHECKLOGIN
DROP PROCEDURE CIPHER.GETFUNCIONALIDADES
--ROLES
DROP PROCEDURE CIPHER.GETFUNCIONALIDADESNUEVOROL
DROP PROCEDURE CIPHER.GETFUNCIONALIDADESROL
DROP PROCEDURE CIPHER.GETNOMBRESROLES
DROP PROCEDURE CIPHER.UPDATEROL
DROP PROCEDURE CIPHER.UPDATEROLFUNCIONALIDAD
DROP PROCEDURE CIPHER.HABILITARROL
--PLANES
DROP PROCEDURE CIPHER.GETPLANES
--AFILIADOS
DROP FUNCTION CIPHER.ULTIMOAFILIADO
DROP FUNCTION CIPHER.PROXIMONROAFILIADO
DROP FUNCTION CIPHER.NROGRUPO
DROP FUNCTION CIPHER.NROFAMILIAR
DROP PROCEDURE CIPHER.CAMBIARPLAN
DROP PROCEDURE CIPHER.TURNOSASIGNADOS
DROP PROCEDURE CIPHER.CANCELARTURNOPACIENTE
---AGENDA
DROP FUNCTION CIPHER.AGENDADESDE
DROP FUNCTION CIPHER.AGENDAHASTA
DROP FUNCTION CIPHER.ATIENDEDIA
DROP PROCEDURE CIPHER.FECHASTURNOS
DROP PROCEDURE CIPHER.PEDIRTURNO
DROP FUNCTION CIPHER.PROXIMONROTURNO
DROP FUNCTION CIPHER.TURNOCANCELADO
DROP PROCEDURE CIPHER.TURNOSPORFECHA
DROP PROCEDURE CIPHER.CANCELARTURNOMEDICO
DROP PROCEDURE CIPHER.TURNOSMEDICOFECHA
--/AGENDA
---BONOS
DROP FUNCTION CIPHER.AFILIADOBONOVALIDO
DROP FUNCTION CIPHER.GRUPO
DROP FUNCTION CIPHER.NROENGRUPO
--/BONOS
DROP PROCEDURE CIPHER.GETTIPOSDOCUMENTOS
DROP FUNCTION CIPHER.CODIGOTIPODOCUMENTO
DROP FUNCTION CIPHER.NOMBRETIPODOCUMENTO

DROP FUNCTION CIPHER.AFILIADODOCUMENTOVALIDO

DROP SCHEMA CIPHER
