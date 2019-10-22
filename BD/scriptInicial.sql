USE GD2C2019

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

IF OBJECT_ID('GESTION_DE_GATOS.Tarjeta','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Tarjeta;

IF OBJECT_ID('GESTION_DE_GATOS.Carga','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Carga;

IF OBJECT_ID('GESTION_DE_GATOS.Usuario','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Usuario;

IF OBJECT_ID('GESTION_DE_GATOS.EstadoPublicacion','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.EstadoPublicacion;

IF OBJECT_ID('GESTION_DE_GATOS.DetallePorFactura','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.DetallePorFactura;

IF OBJECT_ID('GESTION_DE_GATOS.DetalleFactura','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.DetalleFactura;

IF OBJECT_ID('GESTION_DE_GATOS.Funcionalidad','U') IS NOT NULL
    DROP TABLE GESTION_DE_GATOS.Funcionalidad;

IF OBJECT_ID('GESTION_DE_GATOS.FormaPago','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.FormaPago;

IF OBJECT_ID('GESTION_DE_GATOS.Cuenta','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Cuenta;

IF OBJECT_ID('GESTION_DE_GATOS.Compra','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Compra;

IF OBJECT_ID('GESTION_DE_GATOS.Factura','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Factura;

IF OBJECT_ID('GESTION_DE_GATOS.Oferta','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Oferta;

IF OBJECT_ID('GESTION_DE_GATOS.Cupon','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Cupon;

IF OBJECT_ID('GESTION_DE_GATOS.Cliente','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Cliente;

IF OBJECT_ID('GESTION_DE_GATOS.Publicacion','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Publicacion;

IF OBJECT_ID('GESTION_DE_GATOS.Proveedor','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Proveedor;

-------Eliminacion del esquema------

IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'GESTION_DE_GATOS')
    DROP SCHEMA GESTION_DE_GATOS
GO
 
/* Creacion del esquema */
CREATE SCHEMA GESTION_DE_GATOS AUTHORIZATION gdCupon2019
GO

/* Creacion de las tablas */
CREATE TABLE GESTION_DE_GATOS.Funcionalidad(
funcionalidad_id NUMERIC(18,0) IDENTITY,
funcionalidad_descripcion NVARCHAR(255)
PRIMARY KEY (funcionalidad_id)
);

CREATE TABLE GESTION_DE_GATOS.Rol(
rol_id NUMERIC(18,0) IDENTITY,
rol_nombre VARCHAR(15),
rol_habilitado BIT,
PRIMARY KEY (rol_id)
);

CREATE TABLE GESTION_DE_GATOS.FuncionalidadXRol(
rol_id NUMERIC(18,0) NOT NULL,
funcionalidad_id NUMERIC(18,0) NOT NULL,
PRIMARY KEY(rol_id, funcionalidad_id)
);

CREATE TABLE GESTION_DE_GATOS.Usuario(
usuario_id NUMERIC(18,0) IDENTITY,
cliente_id NUMERIC(18,0),
proveedor_id NUMERIC(18,0),
usuario_nombre NVARCHAR(255) UNIQUE,
usuario_password VARBINARY(128),
usuario_bloqueado NUMERIC(18,0) DEFAULT 0,
usuario_primer_login NUMERIC(18,0),
usuario_fecha_bloqueo DATETIME
PRIMARY KEY(usuario_id)
);

CREATE TABLE GESTION_DE_GATOS.UsuarioXRol(
usuario_id NUMERIC(18,0) NOT NULL,
rol_id NUMERIC(18,0) NOT NULL,
PRIMARY KEY (usuario_id, rol_id)
);

CREATE TABLE GESTION_DE_GATOS.Cliente(
cliente_id NUMERIC(18,0) IDENTITY,
cliente_baja NUMERIC(18,0),
cliente_nombre NVARCHAR(255),
cliente_apellido NVARCHAR(255),
cliente_tipo_dni NVARCHAR(255),
cliente_numero_dni NUMERIC(18,0),
cliente_cuil NUMERIC(18,0),
cliente_email NVARCHAR(255),
cliente_fecha_nacimiento DATETIME,
cliente_telefono NUMERIC(18,0),
cliente_direccion_calle NVARCHAR(255),
cliente_direccion_numero NUMERIC(18,0),
cliente_direccion_piso NUMERIC(18,0),
cliente_direccion_depto NUMERIC(18,0),
cliente_direccion_localidad NVARCHAR(255),
cliente_direccion_codigo_postal NVARCHAR(255),
cliente_dato_inconsistente NUMERIC(18,0),
cliente_nuevo NUMERIC(18,0),
PRIMARY KEY (cliente_id)
);

CREATE TABLE GESTION_DE_GATOS.Tarjeta(
tarjeta_id NUMERIC(18,0) IDENTITY,
cliente_id NUMERIC(18,0),
tarjeta_numero NUMERIC(18,0),
tarjeta_tipo CHAR(1),
tarjeta_banco VARCHAR(15),
tarjeta_fecha_vencimiento DATETIME,
tarjeta_cvv NUMERIC(18,0),
PRIMARY KEY (tarjeta_id)
);

CREATE TABLE GESTION_DE_GATOS.Carga(
carga_id NUMERIC(18,0) IDENTITY ,
tarjeta_id NUMERIC(18,0),
carga_fecha DATETIME,
carga_monto NUMERIC(18,0),
PRIMARY KEY (carga_id)
);

CREATE TABLE GESTION_DE_GATOS.Proveedor(
proveedor_id NUMERIC(18,0) IDENTITY,
proveedor_baja NUMERIC(18,0),
proveedor_razon_social NVARCHAR(100),
proveedor_cuit  NVARCHAR(20),
proveedor_rubro NVARCHAR(100),
proveedor_email NVARCHAR(255),
proveedor_fecha_nacimiento DATETIME,
proveedor_telefono NUMERIC(18,0),
proveedor_direccion_calle NVARCHAR(255),
proveedor_direccion_numero NUMERIC(18,0),
proveedor_direccion_piso NUMERIC(18,0),
proveedor_direccion_depto NUMERIC(18,0),
proveedor_direccion_localidad NVARCHAR(255),
proveedor_ciudad NVARCHAR(255),
proveedor_direccion_codigo_postal NVARCHAR(255),
proveedor_dato_inconsistente NUMERIC(18,0),
proveedor_nuevo NUMERIC(18,0),
PRIMARY KEY (proveedor_id)
);

CREATE TABLE GESTION_DE_GATOS.Oferta(
oferta_id NUMERIC(18,0) IDENTITY,
proveedor_id NUMERIC(18,0),
oferta_descripcion NVARCHAR(255),
oferta_dato_inconsistente NUMERIC(18,0),
PRIMARY KEY (oferta_id)
);

CREATE TABLE GESTION_DE_GATOS.Publicacion(
publicacion_id NUMERIC(18,0) IDENTITY,
PRIMARY KEY (publicacion_id)
);

CREATE TABLE GESTION_DE_GATOS.EstadoPublicacion(
estado_publicacion_id NUMERIC(18,0) IDENTITY,
estado_publicacion_descripcion NVARCHAR(255),
estado_publicacion_fecha_consumo DATETIME,
publicacion_id NUMERIC(18,0),
PRIMARY KEY (estado_publicacion_id)
);

CREATE TABLE GESTION_DE_GATOS.Cupon(
cupon_id NUMERIC(18,0) IDENTITY,
PRIMARY KEY (cupon_id)
);

CREATE TABLE GESTION_DE_GATOS.Compra(
compra_id NUMERIC(18,0) IDENTITY,
PRIMARY KEY (compra_id)
);

CREATE TABLE GESTION_DE_GATOS.Factura(
factura_id NUMERIC(18,0) IDENTITY,
factura_numero NUMERIC(18,0),
factura_fecha DATETIME,
factura_dato_inconsistente NUMERIC(18,0),
factura_monto_total NUMERIC(18,0),
PRIMARY KEY (factura_id)
);

CREATE TABLE GESTION_DE_GATOS.DetallePorFactura(
detalle_id NUMERIC(18,0),
factura_id NUMERIC(18,0),
publicacion_id NUMERIC(18,0),
PRIMARY KEY (detalle_id, factura_id, publicacion_id)
);

CREATE TABLE GESTION_DE_GATOS.DetalleFactura(
detalle_id NUMERIC(18,0) IDENTITY,
detalle_monto NUMERIC(18,0),
datalle_cantidad  NUMERIC(18,0),
detalle_descripcion NUMERIC(18,0),
PRIMARY KEY (detalle_id)
);

/* Claves Foraneas*/
ALTER TABLE GESTION_DE_GATOS.FuncionalidadXRol ADD FOREIGN KEY(rol_id) REFERENCES GESTION_DE_GATOS.Rol(rol_id)
ALTER TABLE GESTION_DE_GATOS.FuncionalidadXRol ADD FOREIGN KEY(funcionalidad_id) REFERENCES GESTION_DE_GATOS.Funcionalidad(funcionalidad_id)
ALTER TABLE GESTION_DE_GATOS.UsuarioXRol ADD FOREIGN KEY(usuario_id) REFERENCES GESTION_DE_GATOS.Usuario(usuario_id)
ALTER TABLE GESTION_DE_GATOS.UsuarioXRol ADD FOREIGN KEY(rol_id) REFERENCES GESTION_DE_GATOS.Rol(rol_id)
ALTER TABLE GESTION_DE_GATOS.Tarjeta ADD FOREIGN KEY(cliente_id) REFERENCES GESTION_DE_GATOS.Cliente(cliente_id)
ALTER TABLE GESTION_DE_GATOS.Carga ADD FOREIGN KEY(tarjeta_id) REFERENCES GESTION_DE_GATOS.Tarjeta(tarjeta_id)
ALTER TABLE GESTION_DE_GATOS.Usuario ADD FOREIGN KEY(cliente_id) REFERENCES GESTION_DE_GATOS.Cliente(cliente_id)
ALTER TABLE GESTION_DE_GATOS.Usuario ADD FOREIGN KEY(proveedor_id) REFERENCES GESTION_DE_GATOS.Proveedor(proveedor_id)
ALTER TABLE GESTION_DE_GATOS.Oferta ADD FOREIGN KEY(proveedor_id) REFERENCES GESTION_DE_GATOS.Proveedor(proveedor_id)
ALTER TABLE GESTION_DE_GATOS.EstadoPublicacion ADD FOREIGN KEY(publicacion_id) REFERENCES GESTION_DE_GATOS.Publicacion(publicacion_id)
ALTER TABLE GESTION_DE_GATOS.DetallePorFactura ADD FOREIGN KEY(detalle_id) REFERENCES GESTION_DE_GATOS.DetalleFactura(detalle_id)
ALTER TABLE GESTION_DE_GATOS.DetallePorFactura ADD FOREIGN KEY(factura_id) REFERENCES GESTION_DE_GATOS.Factura(factura_id)
ALTER TABLE GESTION_DE_GATOS.DetallePorFactura ADD FOREIGN KEY(publicacion_id) REFERENCES GESTION_DE_GATOS.Publicacion(publicacion_id)


/* Creación de procedures */
GO
CREATE PROCEDURE GESTION_DE_GATOS.altaUsuario
@nombreUsuario NVARCHAR(255),
@password VARCHAR(128)
AS
BEGIN 
DECLARE @passHash varbinary(128)
SET @passHash =  HASHBYTES('SHA2_256',@password)
INSERT INTO GESTION_DE_GATOS.Usuario (usuario_nombre,usuario_password) VALUES (@nombreUsuario,@passHash)
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.actualizaBloqueoUsuario
@nombreUsuario NVARCHAR(255),
@bloqueado NVARCHAR(18),
@fechaBloqueo NVARCHAR(20)
AS
BEGIN
if @bloqueado = 1  
BEGIN
UPDATE GESTION_DE_GATOS.Usuario SET usuario_bloqueado = CAST(@bloqueado as NUMERIC(18,0)),usuario_fecha_bloqueo = CAST(@fechaBloqueo as datetime) WHERE usuario_nombre= @nombreUsuario
END
if @bloqueado = 0 
BEGIN
UPDATE GESTION_DE_GATOS.Usuario SET usuario_bloqueado = CAST(@bloqueado as NUMERIC(18,0)),usuario_fecha_bloqueo = NULL WHERE usuario_nombre = @nombreUsuario
END
END


/* Creacion de funciones */
GO
CREATE FUNCTION GESTION_DE_GATOS.existeUsuario(@nombreUsuario VARCHAR(50))
RETURNS NUMERIC(18,0)
AS
BEGIN
DECLARE @ret NUMERIC(18,0),@userDummy NVARCHAR(255)
SET @userDummy = (SELECT usuario_bloqueado FROM GESTION_DE_GATOS.Usuario where usuario_nombre = @nombreUsuario)
IF @nombreUsuario = @userDummy 
SET @ret = 0
ELSE
SET @ret = 1
RETURN @ret
END

GO
CREATE FUNCTION GESTION_DE_GATOS.obtenerFecha(@nombreUsuario NVARCHAR(255),@increase NUMERIC(18,0))
RETURNS NUMERIC(18,0)
BEGIN 
DECLARE @dummyUser NVARCHAR(255),
        @ret NUMERIC(18,0),
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
CREATE  FUNCTION GESTION_DE_GATOS.usuarioEstaBloqueado(@nombreUsuario NVARCHAR(255))
RETURNS NUMERIC(18,0)
AS
BEGIN
DECLARE @ret NUMERIC(18,0)
SET @ret = (SELECT usuario_bloqueado FROM GESTION_DE_GATOS.Usuario WHERE usuario_nombre = @nombreUsuario)
RETURN @ret
END

GO
CREATE FUNCTION GESTION_DE_GATOS.loginValido(@nombreUsuario NVARCHAR(255),@password NVARCHAR(128))
RETURNS NUMERIC(18,0)
AS
BEGIN
DECLARE @userDummy NVARCHAR(255),
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
