----- Eliminacion de stored procedures ---------

IF OBJECT_ID('GESTION_DE_GATOS.altaUsuario') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaUsuario

IF OBJECT_ID('GESTION_DE_GATOS.actualizaBloqueoUsuario') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.actualizaBloqueoUsuario


----- Eliminacion de funciones ---------

IF OBJECT_ID('GESTION_DE_GATOS.existeUsuario') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.existeUsuario

IF OBJECT_ID('GESTION_DE_GATOS.obtenerFecha') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerFecha

IF OBJECT_ID('GESTION_DE_GATOS.usuarioEstaBloqueado') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.usuarioEstaBloqueado

IF OBJECT_ID('GESTION_DE_GATOS.loginValido') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.loginValido

------------ Eliminacion de tablas    ------------------

IF OBJECT_ID('GESTION_DE_GATOS.FuncionalidadXRol','U') IS NOT NULL
    DROP TABLE GESTION_DE_GATOS.FuncionalidadXRol;

IF OBJECT_ID('GESTION_DE_GATOS.UsuarioXRol','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.UsuarioXRol;

IF OBJECT_ID('GESTION_DE_GATOS.Rol','U') IS NOT NULL
    DROP TABLE GESTION_DE_GATOS.Rol;

IF OBJECT_ID('GESTION_DE_GATOS.Usuario','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Usuario;

IF OBJECT_ID('GESTION_DE_GATOS.Funcionalidad','U') IS NOT NULL
    DROP TABLE GESTION_DE_GATOS.Funcionalidad;

IF OBJECT_ID('GESTION_DE_GATOS.FormaPago','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.FormaPago;

IF OBJECT_ID('GESTION_DE_GATOS.Carga','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Carga;

IF OBJECT_ID('GESTION_DE_GATOS.Cuenta','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Cuenta;

IF OBJECT_ID('GESTION_DE_GATOS.Compra','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Compra;

IF OBJECT_ID('GESTION_DE_GATOS.Factura','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Factura;

IF OBJECT_ID('GESTION_DE_GATOS.Cliente','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Cliente;

IF OBJECT_ID('GESTION_DE_GATOS.Proveedor','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Proveedor;

IF OBJECT_ID('GESTION_DE_GATOS.Oferta','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Oferta;

IF OBJECT_ID('GESTION_DE_GATOS.Cupon','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Cupon;


-------Eliminacion del esquema------

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'GESTION_DE_GATOS')
    DROP SCHEMA GESTION_DE_GATOS
GO
 
/* Creacion del esquema */
CREATE SCHEMA GESTION_DE_GATOS AUTHORIZATION gdCupon2019
GO


/* Creacion de las tablas */
CREATE TABLE GESTION_DE_GATOS.Funcionalidad(
funcionalidad_id INT IDENTITY,
funcionalidad_descripcion VARCHAR(100)
PRIMARY KEY (funcionalidad_id)
);

CREATE TABLE GESTION_DE_GATOS.Rol(
rol_id INT IDENTITY,
rol_nombre VARCHAR(15),
rol_habilitado BIT,
PRIMARY KEY (rol_id)
);

CREATE TABLE GESTION_DE_GATOS.FuncionalidadXRol(
rol_id INT NOT NULL,
funcionalidad_id INT NOT NULL,
PRIMARY KEY(rol_id,funcionalidad_id)
);


CREATE TABLE GESTION_DE_GATOS.Usuario(
usuario_id INT IDENTITY,
usuario_nombre VARCHAR(50) UNIQUE,
usuario_password VARBINARY(128),
usuario_bloqueado INT DEFAULT 0,
usuario_fecha_bloqueo DATETIME
PRIMARY KEY(usuario_id)
);

CREATE TABLE GESTION_DE_GATOS.UsuarioXRol(
usuario_id VARCHAR(50) NOT NULL,
rol_id INT NOT NULL,
PRIMARY KEY (usuario_id,rol_id)
);


CREATE TABLE GESTION_DE_GATOS.Tarjeta(
tarjeta_id INT IDENTITY,
tarjeta_tipo CHAR(1),
tarjeta_banco VARCHAR(15),
tarjeta_fecha_vencimiento DATETIME,
tarjeta_cvv INT,
PRIMARY KEY (tarjeta_id)
);

CREATE TABLE GESTION_DE_GATOS.Carga(
carga_id INT IDENTITY ,
carga_fecha DATETIME,
carga_monto NUMERIC(18,0)
);

/* Claves Foraneas*/
FOREIGN KEY REFERENCES GESTION_DE_GATOS.FuncionalidadXRol(rol_id)
FOREIGN KEY REFERENCES GESTION_DE_GATOS.FuncionalidadXRol(funcionalidad_id)
FOREIGN KEY REFERENCES GESTION_DE_GATOS.UsuarioXRol(usuario_id)
FOREIGN KEY REFERENCES GESTION_DE_GATOS.UsuarioXRol(rol_id)


/* Creación de procedures */

GO
CREATE PROCEDURE GESTION_DE_GATOS.altaUsuario
@nombreUsuario varchar(50),
@password varchar(128)
AS
BEGIN 
DECLARE @passHash varbinary(128)
SET @passHash =  HASHBYTES('SHA2_256',@password)
INSERT INTO GESTION_DE_GATOS.Usuario (usuario_nombre,usuario_password) VALUES (@nombreUsuario,@passHash)
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.actualizaBloqueoUsuario
@nombreUsuario VARCHAR(50),
@bloqueado VARCHAR(1),
@fechaBloqueo VARCHAR(20)
AS
BEGIN
if @bloqueado = 1  
BEGIN
UPDATE GESTION_DE_GATOS.Usuario SET usuario_bloqueado = CAST(@bloqueado as INT),usuario_bloqueado = CAST(@fechaBloqueo as datetime) WHERE usuario_nombre= @nombreUsuario
END
if @bloqueado = 0 
BEGIN
UPDATE GESTION_DE_GATOS.Usuario SET usuario_bloqueado = CAST(@bloqueado as INT),usuario_fecha_bloqueo = NULL WHERE usuario_nombre = @nombreUsuario
END
END


/* Creacion de funciones */
GO
CREATE FUNCTION GESTION_DE_GATOS.existeUsuario(@nombreUsuario VARCHAR(50))
RETURNS INT
AS
BEGIN
DECLARE @ret int,@userDummy varchar(50)
SET @userDummy = (SELECT usuario_bloqueado FROM GESTION_DE_GATOS.Usuario where usuario_nombre = @nombreUsuario)
IF @nombreUsuario = @userDummy 
SET @ret = 0
ELSE
SET @ret = 1
RETURN @ret
END

GO
CREATE FUNCTION GESTION_DE_GATOS.obtenerFecha(@nombreUsuario VARCHAR(50),@increase INT)
RETURNS BIGINT
BEGIN 
DECLARE @dummyUser VARCHAR(30),
        @ret BIGINT,
		@fechaCon15Mins DATETIME
SET @fechaCon15Mins = (SELECT DATEADD(minute,@increase,usuario_fecha_bloqueo) FROM GESTION_DE_GATOS.Usuario WHERE usuario_nombre = @nombreUsuario)
SET @ret = (SELECT DATEDIFF(SECOND,{d '1970-01-01'},@fechaCon15Mins) FROM GESTION_DE_GATOS.Usuario WHERE usuario_nombre = @nombreUsuario)
IF @ret IS NULL
BEGIN
SET @ret =-1;
END
RETURN @ret;
END

GO
CREATE  FUNCTION GESTION_DE_GATOS.usuarioEstaBloqueado(@nombreUsuario VARCHAR(50))
RETURNS INT
AS
BEGIN
DECLARE @ret INT
SET @ret = (SELECT usuario_bloqueado FROM GESTION_DE_GATOS.Usuario WHERE usuario_nombre = @nombreUsuario)
RETURN @ret
END

GO
CREATE FUNCTION GESTION_DE_GATOS.loginValido(@nombreUsuario VARCHAR(50),@password VARCHAR(128))
RETURNS INT
AS
BEGIN
DECLARE @userDummy VARCHAR(30),
        @PasswordDummy VARBINARY(128),
		@ret BIT
SET @userDummy = (SELECT usuario_nombre from GESTION_DE_GATOS.Usuario  where usuario_nombre = @nombreUsuario)
SET @PasswordDummy = (SELECT  usuario_password from GESTION_DE_GATOS.Usuario where usuario_password = HASHBYTES('SHA2_256',@password))
IF  @userDummy IS NOT NULL AND @PasswordDummy IS NOT NULL
BEGIN
SET @ret = 0
END
ELSE
BEGIN
SET @ret = 1
END
RETURN @ret
END
