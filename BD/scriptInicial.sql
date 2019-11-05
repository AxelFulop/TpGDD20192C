USE GD2C2019

----- Eliminacion de stored procedures --------- 
IF OBJECT_ID('GESTION_DE_GATOS.updateBloqueadoUser') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.updateBloqueadoUser

IF OBJECT_ID('GESTION_DE_GATOS.eliminarFuncionalidadARol') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.eliminarFuncionalidadARol

IF OBJECT_ID('GESTION_DE_GATOS.sumarIntentoFallido') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.sumarIntentoFallido

IF OBJECT_ID('GESTION_DE_GATOS.bajaRol') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.bajaRol

IF OBJECT_ID('GESTION_DE_GATOS.agregarFuncionalidadARol') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.agregarFuncionalidadARol

IF OBJECT_ID('GESTION_DE_GATOS.altaUsuario') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaUsuario

IF OBJECT_ID('GESTION_DE_GATOS.actualizaBloqueoUsuario') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.actualizaBloqueoUsuario

IF OBJECT_ID('GESTION_DE_GATOS.altaTarjeta') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaTarjeta

IF OBJECT_ID('GESTION_DE_GATOS.altaCarga') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaCarga

IF OBJECT_ID('GESTION_DE_GATOS.altaFuncionalidad') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaFuncionalidad

IF OBJECT_ID('GESTION_DE_GATOS.altaRol') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaRol

IF OBJECT_ID('GESTION_DE_GATOS.altaProveedor') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaProveedor

IF OBJECT_ID('GESTION_DE_GATOS.altaOferta') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaOferta


----- Eliminacion de funciones --------- 

IF OBJECT_ID('GESTION_DE_GATOS.obtenerRolUsuario') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerRolUsuario

IF OBJECT_ID('GESTION_DE_GATOS.existeUsuario') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.existeUsuario

IF OBJECT_ID('GESTION_DE_GATOS.obtenerFecha') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerFecha

IF OBJECT_ID('GESTION_DE_GATOS.usuarioEstaBloqueado') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.usuarioEstaBloqueado

IF OBJECT_ID('GESTION_DE_GATOS.loginValido') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.loginValido

IF OBJECT_ID('GESTION_DE_GATOS.obtenerCantIntentosFallidos') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerCantIntentosFallidos

------------ Eliminacion de FK   ------------------ 

IF (select object_id from sys.foreign_keys where [name] = 'FC1') IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.FuncionalidadXRol DROP CONSTRAINT FC1

IF (select object_id from sys.foreign_keys where [name] = 'FC2')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.FuncionalidadXRol DROP CONSTRAINT FC2

IF (select object_id from sys.foreign_keys where [name] = 'FC3')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.UsuarioXRol DROP CONSTRAINT FC3

IF (select object_id from sys.foreign_keys where [name] = 'FC4')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.UsuarioXRol DROP CONSTRAINT FC4

IF (select object_id from sys.foreign_keys where [name] = 'FC5')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Tarjeta  DROP CONSTRAINT FC5

IF (select object_id from sys.foreign_keys where [name] = 'FC6')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Cliente  DROP CONSTRAINT FC6

IF (select object_id from sys.foreign_keys where [name] = 'FC7')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Proveedor  DROP CONSTRAINT FC7

IF (select object_id from sys.foreign_keys where [name] = 'FC8')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Factura  DROP CONSTRAINT FC8

IF (select object_id from sys.foreign_keys where [name] = 'FC9')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Oferta  DROP CONSTRAINT FC9

IF (select object_id from sys.foreign_keys where [name] = 'FC10') IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Cupon  DROP CONSTRAINT FC10

IF (select object_id from sys.foreign_keys where [name] = 'FC11')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Compra  DROP CONSTRAINT FC11

IF (select object_id from sys.foreign_keys where [name] = 'FC12')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Compra  DROP CONSTRAINT FC12

IF (select object_id from sys.foreign_keys where [name] = 'FC13')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.DetallePorFactura  DROP CONSTRAINT FC13

IF (select object_id from sys.foreign_keys where [name] = 'FC14')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.DetallePorFactura  DROP CONSTRAINT FC14

IF (select object_id from sys.foreign_keys where [name] = 'FC15')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.DetallePorFactura  DROP CONSTRAINT FC15

IF (select object_id from sys.foreign_keys where [name] = 'FC16') IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.HistorialCliente  DROP CONSTRAINT FC16

IF (select object_id from sys.foreign_keys where [name] = 'FC17')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.HistorialCliente  DROP CONSTRAINT FC17

IF (select object_id from sys.foreign_keys where [name] = 'FC18')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Carga  DROP CONSTRAINT FC18

------------ Eliminacion de tablas    ------------------

IF OBJECT_ID('GESTION_DE_GATOS.FuncionalidadXRol','U') IS NOT NULL
    DROP TABLE GESTION_DE_GATOS.FuncionalidadXRol;

IF OBJECT_ID('GESTION_DE_GATOS.UsuarioXRol','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.UsuarioXRol;

IF OBJECT_ID('GESTION_DE_GATOS.HistorialCliente','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.HistorialCliente;

IF OBJECT_ID('GESTION_DE_GATOS.Rol','U') IS NOT NULL
    DROP TABLE GESTION_DE_GATOS.Rol;

IF OBJECT_ID('GESTION_DE_GATOS.Funcionalidad','U') IS NOT NULL
    DROP TABLE GESTION_DE_GATOS.Funcionalidad;

IF OBJECT_ID('GESTION_DE_GATOS.DetallePorFactura','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.DetallePorFactura;

IF OBJECT_ID('GESTION_DE_GATOS.Tarjeta','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Tarjeta;

IF OBJECT_ID('GESTION_DE_GATOS.Carga','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Carga;

IF OBJECT_ID('GESTION_DE_GATOS.Cupon','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Cupon;

IF OBJECT_ID('GESTION_DE_GATOS.Oferta','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Oferta;

IF OBJECT_ID('GESTION_DE_GATOS.Proveedor','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Proveedor;

IF OBJECT_ID('GESTION_DE_GATOS.Factura','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Factura;

IF OBJECT_ID('GESTION_DE_GATOS.Compra','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Compra;

IF OBJECT_ID('GESTION_DE_GATOS.DetalleFactura','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.DetalleFactura;

IF OBJECT_ID('GESTION_DE_GATOS.Cliente','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Cliente;

IF OBJECT_ID('GESTION_DE_GATOS.Usuario','U') IS NOT NULL
	DROP TABLE GESTION_DE_GATOS.Usuario;


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
funcionalidad_descripcion NVARCHAR(255) unique,
PRIMARY KEY (funcionalidad_id)
);

CREATE TABLE GESTION_DE_GATOS.Rol(
rol_id NUMERIC(18,0) IDENTITY,
rol_nombre NVARCHAR(15) unique,
rol_habilitado CHAR(1),
PRIMARY KEY (rol_id)
);

CREATE TABLE GESTION_DE_GATOS.FuncionalidadXRol(
rol_id NUMERIC(18,0) NOT NULL,
funcionalidad_id NUMERIC(18,0) NOT NULL,
PRIMARY KEY(rol_id, funcionalidad_id)
);

CREATE TABLE GESTION_DE_GATOS.Usuario(
usuario_id NUMERIC(18,0) IDENTITY,
usuario_nombre NVARCHAR(255) UNIQUE,
usuario_password VARBINARY(128),
usuario_bloqueado NUMERIC(18,0) DEFAULT 0,
usuario_primer_login NUMERIC(18,0),
usuario_fecha_bloqueo DATETIME,
usuario_cont_ingresos_fallidos int default 0 --Si llega a 3 se bloquea al usuario (se debe guardar en la DB)
PRIMARY KEY(usuario_id)
);

CREATE TABLE GESTION_DE_GATOS.UsuarioXRol(
usuario_id NUMERIC(18,0) NOT NULL,
rol_id NUMERIC(18,0) NOT NULL,
PRIMARY KEY (usuario_id, rol_id)
);

--Como en la maestra la direccion esta dada como calle + numero en la bd se migra igual y se separa en la app por calle,numero en atributos distintos
-- Dato inconsistente en un char , puede ser un 1 o 0 o un S o N, con esto sabemos que hay algun dato repetido o erroneo, se debera validar del todo desde la app

CREATE TABLE GESTION_DE_GATOS.Cliente(
cliente_id NUMERIC(18,0) IDENTITY,
usuario_id NUMERIC(18,0),
cliente_baja CHAR(1),
cliente_nombre NVARCHAR(255),
cliente_ciudad NVARCHAR(255),
cliente_apellido NVARCHAR(255),
cliente_tipo_dni NVARCHAR(255),
cliente_numero_dni NUMERIC(18,0),
cliente_cuil NVARCHAR(20),
cliente_email NVARCHAR(255),
cliente_fecha_nacimiento DATETIME,
cliente_telefono NUMERIC(18,0),
cliente_direccion NVARCHAR(255),
cliente_direccion_piso NUMERIC(18,0),
cliente_direccion_depto NUMERIC(18,0),
cliente_direccion_localidad NVARCHAR(255),
cliente_direccion_codigo_postal NVARCHAR(255),
cliente_dato_inconsistente CHAR(1),
cliente_nuevo CHAR(1),
PRIMARY KEY (cliente_id)
);

CREATE TABLE GESTION_DE_GATOS.Tarjeta(
tarjeta_id NUMERIC(18,0) IDENTITY,
cliente_id NUMERIC(18,0),
tarjeta_numero NUMERIC(18,0),
tajeta_saldo NUMERIC(18,4),
tarjeta_tipo NVARCHAR(100),
tarjeta_banco VARCHAR(15),
tarjeta_fecha_vencimiento DATETIME,
tarjeta_cvv NUMERIC(18,0),
PRIMARY KEY (tarjeta_id)
);

CREATE TABLE GESTION_DE_GATOS.Carga(
carga_id NUMERIC(18,0) IDENTITY ,
tarjeta_id NUMERIC(18,0),
carga_fecha DATETIME,
carga_monto NUMERIC(18,2),
PRIMARY KEY (carga_id)
);

CREATE TABLE GESTION_DE_GATOS.Proveedor(
proveedor_id NUMERIC(18,0) IDENTITY,
usuario_id NUMERIC(18,0),
proveedor_baja CHAR(1),
proveedor_razon_social NVARCHAR(100),
proveedor_contacto NVARCHAR(30),
proveedor_cuit  NVARCHAR(20),
proveedor_rubro NVARCHAR(100),
proveedor_email NVARCHAR(255),
proveedor_telefono NUMERIC(18,0),
proveedor_direccion NVARCHAR(255),
proveedor_direccion_piso NUMERIC(18,0),
proveedor_direccion_depto NVARCHAR(10),
proveedor_direccion_localidad NVARCHAR(255),
proveedor_ciudad NVARCHAR(255),
proveedor_direccion_codigo_postal NVARCHAR(255),
proveedor_dato_inconsistente CHAR(1),
proveedor_nuevo CHAR(1),
PRIMARY KEY (proveedor_id)
);

CREATE TABLE GESTION_DE_GATOS.Oferta(
oferta_id NUMERIC(18,0) IDENTITY,
proveedor_id NUMERIC(18,0),
oferta_descripcion NVARCHAR(255),
oferta_codigo NVARCHAR(50),
oferta_fecha_publicacion DATETIME,
oferta_fecha_vencimiento DATETIME,
oferta_limite_compra NUMERIC(18,0),
oferta_stock_disponible NUMERIC(18,0),
oferta_precio NUMERIC(18,2),
oferta_precio_lista NUMERIC(18,2),
oferta_dato_inconsistente NUMERIC(18,0),
PRIMARY KEY (oferta_id)
);


CREATE TABLE GESTION_DE_GATOS.Cupon(
cupon_id NUMERIC(18,0) IDENTITY,
oferta_id NUMERIC(18,0),
cupon_codigo NVARCHAR(50),
cupon_canjeado CHAR(1),
cupon_fecha_vencimiento DATETIME,
cupon_fecha_consumo DATETIME,
cupon_precio NUMERIC(18,0),
cupon_precio_lista NUMERIC(18,0)
PRIMARY KEY (cupon_id)
);

CREATE TABLE GESTION_DE_GATOS.Compra(
compra_id NUMERIC(18,0) IDENTITY,
cliente_id NUMERIC(18,0),
oferta_id NUMERIC(18,0),
compra_fecha DATETIME,
dato_inconsistente CHAR(1),
limite_cliente NUMERIC(18,0)
PRIMARY KEY (compra_id)
);

CREATE TABLE GESTION_DE_GATOS.Factura(
factura_id NUMERIC(18,0) IDENTITY,
proveedor_id NUMERIC(18,0),
factura_numero NUMERIC(18,0),
factura_fecha DATETIME,
factura_monto_total NUMERIC(18,0),
factura_dato_inconsistente CHAR(1)
PRIMARY KEY (factura_id)
);

CREATE TABLE GESTION_DE_GATOS.DetallePorFactura(
detalle_id NUMERIC(18,0),
factura_id NUMERIC(18,0),
oferta_id NUMERIC(18,0),
PRIMARY KEY (detalle_id, factura_id, oferta_id)
);

CREATE TABLE GESTION_DE_GATOS.DetalleFactura(
detalle_id NUMERIC(18,0) IDENTITY,
detalle_monto NUMERIC(18,0),
datalle_cantidad  NUMERIC(18,0),
detalle_descripcion NUMERIC(18,0),
detalle_fecha_entregado DATETIME
PRIMARY KEY (detalle_id)
);

CREATE TABLE GESTION_DE_GATOS.HistorialCliente(
historial_id NUMERIC(18,0) IDENTITY,
oferta_id NUMERIC(18,0),
cliente_id NUMERIC(18,0)
PRIMARY KEY (historial_id,oferta_id,cliente_id)
);

/* Claves Foraneas*/
ALTER TABLE GESTION_DE_GATOS.FuncionalidadXRol ADD CONSTRAINT FC1 FOREIGN KEY(rol_id) REFERENCES GESTION_DE_GATOS.Rol(rol_id)
ALTER TABLE GESTION_DE_GATOS.FuncionalidadXRol ADD CONSTRAINT FC2  FOREIGN KEY(funcionalidad_id) REFERENCES GESTION_DE_GATOS.Funcionalidad(funcionalidad_id)
ALTER TABLE GESTION_DE_GATOS.UsuarioXRol ADD CONSTRAINT FC3 FOREIGN KEY(usuario_id) REFERENCES GESTION_DE_GATOS.Usuario(usuario_id)
ALTER TABLE GESTION_DE_GATOS.UsuarioXRol ADD CONSTRAINT FC4 FOREIGN KEY(rol_id) REFERENCES GESTION_DE_GATOS.Rol(rol_id)
ALTER TABLE GESTION_DE_GATOS.Tarjeta ADD CONSTRAINT FC5 FOREIGN KEY(cliente_id) REFERENCES GESTION_DE_GATOS.Cliente(cliente_id)
ALTER TABLE GESTION_DE_GATOS.Cliente ADD CONSTRAINT FC6 FOREIGN KEY(usuario_id) REFERENCES GESTION_DE_GATOS.Usuario(usuario_id)
ALTER TABLE GESTION_DE_GATOS.Proveedor ADD CONSTRAINT FC7 FOREIGN KEY(usuario_id) REFERENCES GESTION_DE_GATOS.Usuario(usuario_id)
ALTER TABLE GESTION_DE_GATOS.Factura ADD CONSTRAINT FC8 FOREIGN KEY(proveedor_id) REFERENCES GESTION_DE_GATOS.Proveedor(proveedor_id)
ALTER TABLE GESTION_DE_GATOS.Oferta ADD CONSTRAINT FC9 FOREIGN KEY(proveedor_id) REFERENCES GESTION_DE_GATOS.Proveedor(proveedor_id)
ALTER TABLE GESTION_DE_GATOS.Cupon ADD CONSTRAINT FC10 FOREIGN KEY(oferta_id) REFERENCES GESTION_DE_GATOS.Oferta(oferta_id)
ALTER TABLE GESTION_DE_GATOS.Compra ADD CONSTRAINT FC11 FOREIGN KEY(oferta_id) REFERENCES GESTION_DE_GATOS.Oferta(oferta_id)
ALTER TABLE GESTION_DE_GATOS.Compra ADD CONSTRAINT FC12 FOREIGN KEY(cliente_id) REFERENCES GESTION_DE_GATOS.Cliente(cliente_id)
ALTER TABLE GESTION_DE_GATOS.DetallePorFactura ADD CONSTRAINT FC13 FOREIGN KEY(detalle_id) REFERENCES GESTION_DE_GATOS.DetalleFactura(detalle_id)
ALTER TABLE GESTION_DE_GATOS.DetallePorFactura ADD CONSTRAINT FC14 FOREIGN KEY(factura_id) REFERENCES GESTION_DE_GATOS.Factura(factura_id)
ALTER TABLE GESTION_DE_GATOS.DetallePorFactura ADD CONSTRAINT FC15 FOREIGN KEY(oferta_id) REFERENCES GESTION_DE_GATOS.Oferta(oferta_id)
ALTER TABLE GESTION_DE_GATOS.HistorialCliente ADD CONSTRAINT FC16 FOREIGN KEY(oferta_id) REFERENCES GESTION_DE_GATOS.Oferta(oferta_id)
ALTER TABLE GESTION_DE_GATOS.HistorialCliente ADD CONSTRAINT FC17 FOREIGN KEY(cliente_id) REFERENCES GESTION_DE_GATOS.Cliente(cliente_id)
ALTER TABLE GESTION_DE_GATOS.Carga ADD CONSTRAINT FC18 FOREIGN KEY(tarjeta_id) REFERENCES GESTION_DE_GATOS.Tarjeta(tarjeta_id)

/* Inserccion de datos previos */
--Usuario Admin

INSERT INTO GESTION_DE_GATOS.Usuario (usuario_nombre,usuario_password)
VALUES('admin',HASHBYTES('SHA2_256','admin'))


/*INSERT INTO GESTION_DE_GATOS.UsuarioXRol (rol_id,usuario_id)
SELECT 1,usuario_id FROM GESTION_DE_GATOS.Usuario WHERE usuario_nombre = 'admin'*/



--Roles
insert into GESTION_DE_GATOS.Rol(rol_nombre, rol_habilitado) values('Administrador', '0')
insert into GESTION_DE_GATOS.Rol(rol_nombre, rol_habilitado) values('Cliente', '0')
insert into GESTION_DE_GATOS.Rol(rol_nombre, rol_habilitado) values('Proveedor', '0')


--Funcionalidades ADM
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Crear  rol') --1
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Crear  cliente') --2
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Crear  proveedor') --3
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Modificar rol') --4
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Modificar cliente') --5
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Modificar proveedor') --6
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Dar de baja rol') --7
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Dar de baja proveedor') --8
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Dar de baja cliente') --9
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Facturar a proveedor') --10
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Listado estadistico') --11

--Funcionalidades Cliente
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Registrarse') --12, tanto el proveedor como el cliente pueden hacerlo
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Cargar credito') -- 13
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Comprar oferta') -- 14
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Registrar tarjeta') -- 15


--Funcionalidades Proveedor
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Armar oferta') -- 16
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('publicar oferta') -- 17, tanto el proveedor como adm pueden hacerlo
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Dar de baja oferta') -- 18

insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 1)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 2)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 3)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 4)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 5)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 6)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 7)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 8)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 9)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 10)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 11)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 17)

insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(2,12)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(2,13)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(2,14)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(2,15)


insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(3,12)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(3,16)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(3,17)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(3,18)

/* Migracion de la Maestra */
--Cliente
PRINT 'Migrando Clientes'
INSERT  INTO GESTION_DE_GATOS.Cliente (cliente_nombre,cliente_apellido,cliente_email,cliente_numero_dni,cliente_direccion,cliente_fecha_nacimiento,cliente_ciudad,cliente_telefono) 
SELECT DISTINCT Cli_Nombre,Cli_Apellido,Cli_Mail,Cli_Dni,Cli_Direccion,Cli_Fecha_Nac,Cli_Ciudad,Cli_Telefono  FROM gd_esquema.Maestra
WHERE Cli_Apellido IS NOT NULL AND Cli_Nombre IS NOT NULL AND Cli_Dni IS NOT NULL

--Proveedores
PRINT 'Migrando Proovedores'
INSERT INTO GESTION_DE_GATOS.Proveedor (proveedor_razon_social,proveedor_cuit,proveedor_rubro,proveedor_telefono,proveedor_ciudad,proveedor_direccion)
SELECT DISTINCT Provee_RS,Provee_CUIT,Provee_Rubro,Provee_Telefono,Provee_Ciudad,Provee_Dom FROM gd_esquema.Maestra
WHERE Provee_RS IS NOT NULL AND Provee_CUIT IS NOT NULL

--Usuarios
PRINT 'Migrando Usuarios - Clientes'
INSERT INTO GESTION_DE_GATOS.Usuario(usuario_nombre, usuario_password,
									 usuario_bloqueado, usuario_primer_login)
SELECT LOWER(CONCAT(cliente_nombre, '_', cliente_apellido)), HASHBYTES('SHA2_256', convert(nvarchar(128), cliente_numero_dni)), 0, 0 from GESTION_DE_GATOS.Cliente

UPDATE GESTION_DE_GATOS.Cliente SET 
usuario_id = (SELECT usuario_id FROM GESTION_DE_GATOS.Usuario 
	where usuario_nombre = LOWER(CONCAT(cliente_nombre, '_', cliente_apellido)))

PRINT 'Migrando Usuarios - Proveedores'
INSERT INTO GESTION_DE_GATOS.Usuario(usuario_nombre, usuario_password,
									 usuario_bloqueado, usuario_primer_login)
SELECT proveedor_cuit, HASHBYTES('SHA2_256', CONVERT(nvarchar(128), LOWER(proveedor_razon_social))), 0, 0 from GESTION_DE_GATOS.Proveedor

UPDATE GESTION_DE_GATOS.Proveedor SET
usuario_id = (SELECT usuario_id FROM GESTION_DE_GATOS.Usuario where usuario_nombre = proveedor_cuit)

--Roles
PRINT 'Asignando roles a clientes'
INSERT INTO GESTION_DE_GATOS.UsuarioXRol(usuario_id, rol_id)
SELECT usuario_id, 2 from GESTION_DE_GATOS.Cliente

PRINT 'Asignando roles a proveedores'
INSERT INTO GESTION_DE_GATOS.UsuarioXRol(usuario_id, rol_id)
SELECT usuario_id, 3 from GESTION_DE_GATOS.Proveedor

--Factura
PRINT 'Migrando Facturas'
INSERT INTO GESTION_DE_GATOS.Factura (proveedor_id,factura_numero,factura_fecha)
SELECT DISTINCT  proveedor_id,Factura_Nro,Factura_Nro
FROM gd_esquema.Maestra
JOIN GESTION_DE_GATOS.Cliente ON (
Cli_Nombre = cliente_nombre AND
Cli_Apellido = cliente_apellido AND
Cli_Dni = cliente_numero_dni AND
Cli_Mail = cliente_email)
JOIN GESTION_DE_GATOS.Proveedor ON (
Provee_RS = proveedor_razon_social AND
Provee_CUIT = Provee_CUIT AND
Provee_Telefono = proveedor_telefono
)
WHERE Factura_Nro IS NOT NULL AND Factura_Fecha IS NOT NULL


--Oferta
PRINT 'Migrando Ofertas'
INSERT INTO GESTION_DE_GATOS.Oferta (proveedor_id,oferta_stock_disponible,oferta_codigo,oferta_descripcion,oferta_fecha_publicacion,oferta_fecha_vencimiento,oferta_precio,oferta_precio_lista)
SELECT DISTINCT  proveedor_id,Oferta_Cantidad,Oferta_Codigo,Oferta_Descripcion,Oferta_Fecha,Oferta_Fecha_Venc,Oferta_Precio,Oferta_Precio_Ficticio
FROM gd_esquema.Maestra
JOIN GESTION_DE_GATOS.Proveedor ON (
Provee_RS = proveedor_razon_social AND
Provee_CUIT = Provee_CUIT AND
Provee_Telefono = proveedor_telefono
)
WHERE Oferta_Codigo IS NOT NULL


--Tarjeta
PRINT 'Migrando Tarjetas'
INSERT INTO GESTION_DE_GATOS.Tarjeta(cliente_id,tarjeta_tipo)
SELECT DISTINCT cliente_id,Tipo_Pago_Desc
FROM gd_esquema.Maestra
JOIN GESTION_DE_GATOS.Cliente ON (
Cli_Nombre = cliente_nombre AND
Cli_Apellido = cliente_apellido AND
Cli_Dni = cliente_numero_dni AND
Cli_Mail = cliente_email
)

--Carga
PRINT 'Migrando Carga'
INSERT INTO GESTION_DE_GATOS.Carga(tarjeta_id,carga_monto,carga_fecha)
SELECT DISTINCT t.tarjeta_id,Carga_Credito,Carga_Fecha
FROM gd_esquema.Maestra
JOIN GESTION_DE_GATOS.Cliente c ON (
Cli_Nombre = c.cliente_nombre AND
Cli_Apellido = c.cliente_apellido AND
Cli_Dni = c.cliente_numero_dni AND
Cli_Mail = c.cliente_email
)
JOIN GESTION_DE_GATOS.Tarjeta t ON (
Tipo_Pago_Desc = t.tarjeta_tipo AND
t.cliente_id = c.cliente_id AND
Cli_Dni = c.cliente_numero_dni
)
WHERE Carga_Credito IS NOT NULL 



--Compra
PRINT 'Migrando Compras'
INSERT INTO GESTION_DE_GATOS.Compra (oferta_id,cliente_id,compra_fecha)
SELECT o.oferta_id,c.cliente_id,m.Oferta_Fecha_Compra FROM  gd_esquema.Maestra m
JOIN GESTION_DE_GATOS.Cliente c  ON (
Cli_Dni = c.cliente_numero_dni AND
Cli_Mail = c.cliente_email
)
JOIN GESTION_DE_GATOS.Oferta o ON (
m.Oferta_Codigo = o.oferta_codigo AND
m.Oferta_Fecha = o.oferta_fecha_publicacion

)


--DetalleFactura
PRINT 'Migrando Fechas de entrega'
INSERT INTO GESTION_DE_GATOS.DetalleFactura  (detalle_fecha_entregado)
SELECT m.Oferta_Entregado_Fecha FROM gd_esquema.Maestra m




/* Creación de procedures */
GO
CREATE PROCEDURE GESTION_DE_GATOS.altaUsuario
@nombreUsuario NVARCHAR(255),
@password VARCHAR(128)
AS
BEGIN 
DECLARE @passHash varbinary(128)
SET @passHash =  HASHBYTES('SHA2_256', convert(nvarchar(128), @password))
INSERT INTO GESTION_DE_GATOS.Usuario (usuario_nombre,usuario_password) VALUES (@nombreUsuario,@passHash)
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.altaTarjeta
@numeroTarjeta NUMERIC(18,0),
@tipoTarjeta NVARCHAR(100),
@bancoTarjeta  NVARCHAR(15),
@vencimientoFechaTarjeta NVARCHAR(20),
@cvvTarjeta NUMERIC(18,0)
AS
BEGIN
INSERT INTO GESTION_DE_GATOS.Tarjeta (tarjeta_numero,tarjeta_tipo,tarjeta_banco,tarjeta_fecha_vencimiento,tarjeta_cvv)
VALUES (@numeroTarjeta,@tipoTarjeta,@bancoTarjeta,@vencimientoFechaTarjeta,@cvvTarjeta)
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.altaCarga
@fechaCarga DATETIME,
@montoCarga NUMERIC(18,2),
@numeroTarjeta NUMERIC(18,0),
@tipoTarjeta NVARCHAR(100),
@bancoTarjeta  NVARCHAR(15),
@vencimientoFechaTarjeta NVARCHAR(20),
@cvvTarjeta NUMERIC(18,0),
@idTarjeta INT
AS
BEGIN
EXEC GESTION_DE_GATOS.altaTarjeta @numeroTarjeta,@tipoTarjeta,@bancoTarjeta,@vencimientoFechaTarjeta,@cvvTarjeta
set @idTarjeta = SCOPE_IDENTITY()
INSERT INTO GESTION_DE_GATOS.Carga(tarjeta_id,carga_fecha,carga_monto)
VALUES(@idTarjeta,@fechaCarga,@montoCarga)
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.altaRol
@nombreRol NVARCHAR(15),
@descripcionFuncionalidad NVARCHAR(255)
AS
BEGIN
DECLARE @idRol NUMERIC(18,0),@idFuncionalidad NUMERIC(18,0)
	INSERT INTO  GESTION_DE_GATOS.Rol (rol_nombre)
		VALUES (@nombreRol)
	INSERT INTO GESTION_DE_GATOS.Funcionalidad (funcionalidad_descripcion)
	VALUES (@descripcionFuncionalidad)
	SET @idRol = (SELECT rol_id FROM GESTION_DE_GATOS.Rol WHERE rol_nombre = @nombreRol)
	IF @idRol IS NULL
	BEGIN
	SET @idRol = SCOPE_IDENTITY()
	END
	SET @idFuncionalidad = (SELECT funcionalidad_id FROM GESTION_DE_GATOS.Funcionalidad WHERE funcionalidad_descripcion = @descripcionFuncionalidad)
	IF @idFuncionalidad IS NULL
	BEGIN
	SET @idFuncionalidad = SCOPE_IDENTITY()
	END
	INSERT INTO GESTION_DE_GATOS.FuncionalidadXRol (rol_id,funcionalidad_id)
	VALUES(@idRol,@idFuncionalidad)
END


GO
CREATE PROCEDURE GESTION_DE_GATOS.altaOferta
@descripcionOferta NVARCHAR(255), 
@codigoOferta NVARCHAR(50),
@fechaPublicacionOferta DATETIME,
@fechaVencimientoOferta DATETIME,
@limiteCompraOferta NUMERIC(18,0),
@stockDisponibleOferta NUMERIC(18,0),
@precioOferta NUMERIC(18,2),
@precioListaOferta NUMERIC(18,2),
@proveedorCuit NUMERIC(18,0)
AS
BEGIN
DECLARE @proveedorId NUMERIC(18,0)
SET @proveedorId = (SELECT proveedor_id FROM GESTION_DE_GATOS.Proveedor WHERE proveedor_cuit = @proveedorCuit)
INSERT INTO GESTION_DE_GATOS.Oferta (proveedor_id,oferta_descripcion,oferta_codigo,oferta_fecha_publicacion,oferta_fecha_vencimiento,oferta_limite_compra,oferta_stock_disponible,oferta_precio,oferta_precio_lista)
VALUES(@proveedorId,@descripcionOferta,@codigoOferta,@fechaPublicacionOferta,@fechaVencimientoOferta,@limiteCompraOferta,@stockDisponibleOferta,@precioOferta,@precioListaOferta)
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.altaProveedor
@razonSocialProveedor NVARCHAR(100),
@mailProveedor NVARCHAR(255),
@teléfonoProveedor NUMERIC(18,0),
@direccionProveedor NVARCHAR(255),
@numeroProveedor NUMERIC(18,0),
@pisoProveedor NUMERIC(18,0),
@departamentoProveedor NVARCHAR(10),
@localidadProveedor NVARCHAR(255),
@codigoPostalProveedor NUMERIC(18,0),
@ciudadProveedor NVARCHAR(255),
@cuitProveedor NUMERIC(18,0),
@rubroProveedor NVARCHAR(100),
@nombreDeContactoProveedor NVARCHAR(30)
AS
BEGIN
INSERT INTO GESTION_DE_GATOS.Proveedor (proveedor_razon_social,proveedor_email,proveedor_telefono,proveedor_direccion,proveedor_direccion_piso,proveedor_direccion_depto,proveedor_direccion_localidad,proveedor_direccion_codigo_postal,proveedor_ciudad,proveedor_cuit,proveedor_rubro,proveedor_contacto)
VALUES (@razonSocialProveedor,@mailProveedor,@teléfonoProveedor,CONCAT(@direccionProveedor,@numeroProveedor),@pisoProveedor,
@departamentoProveedor,@localidadProveedor,@codigoPostalProveedor,@ciudadProveedor,@cuitProveedor,@rubroProveedor,@nombreDeContactoProveedor)
END


GO
CREATE PROCEDURE GESTION_DE_GATOS.updateBloqueadoUser
@nombreUsuario NVARCHAR(255),
@bloqueado NVARCHAR
AS
BEGIN
	UPDATE GESTION_DE_GATOS.Usuario SET usuario_bloqueado = CAST(@bloqueado as NUMERIC(18,0)),
										usuario_cont_ingresos_fallidos = 0,
										usuario_fecha_bloqueo = (case when (@bloqueado = 1) then GETDATE() else null end)
		WHERE usuario_nombre = @nombreUsuario
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.sumarIntentoFallido
@nombreUsuario NVARCHAR(255)
AS
BEGIN
	UPDATE GESTION_DE_GATOS.Usuario SET usuario_cont_ingresos_fallidos = cast(usuario_cont_ingresos_fallidos as int) + 1
		WHERE usuario_nombre = @nombreUsuario
END





GO
CREATE PROCEDURE GESTION_DE_GATOS.bajaRol
@nombreRol NVARCHAR(15)
AS
BEGIN
	declare @id_rol numeric(18, 0)
	select @id_rol = rol_id from GESTION_DE_GATOS.Rol
		where rol_nombre = @nombreRol
	delete from GESTION_DE_GATOS.Rol
		where rol_nombre = @nombreRol
	delete from GESTION_DE_GATOS.FuncionalidadXRol
		where rol_id = @id_rol
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.agregarFuncionalidadARol
@nombreRol NVARCHAR(15), --Rol ya existente
@descripcionFuncionalidad NVARCHAR(255)
AS
BEGIN
	declare @id_rol numeric(18, 0)
	declare @id_func numeric(18, 0)

	BEGIN TRANSACTION
	select @id_rol = rol_id from GESTION_DE_GATOS.Rol 
		where rol_nombre = @nombreRol
	if(@id_rol is null) begin
		insert into GESTION_DE_GATOS.Rol (rol_nombre)
			values (@nombreRol)
		set @id_rol = SCOPE_IDENTITY()
	end
	select @id_func = funcionalidad_id from GESTION_DE_GATOS.Funcionalidad 
		where funcionalidad_descripcion = @descripcionFuncionalidad
	if(@id_func is null) begin
		insert into GESTION_DE_GATOS.Funcionalidad (funcionalidad_descripcion)
			values (@descripcionFuncionalidad)
		set @id_func = SCOPE_IDENTITY()
	end
	INSERT INTO GESTION_DE_GATOS.FuncionalidadXRol(funcionalidad_id, rol_id)
		VALUES (@id_func, @id_rol)
	COMMIT
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.eliminarFuncionalidadARol
@nombreRol NVARCHAR(15), --Rol ya existente
@descripcionFuncionalidad NVARCHAR(255)
AS
BEGIN
	declare @id_rol numeric(18, 0)
	declare @id_func numeric(18, 0)

	select @id_rol = rol_id from GESTION_DE_GATOS.Rol 
		where rol_nombre = @nombreRol
	select @id_func = funcionalidad_id from GESTION_DE_GATOS.Funcionalidad 
		where funcionalidad_descripcion = @descripcionFuncionalidad

	delete from GESTION_DE_GATOS.FuncionalidadXRol
		where rol_id = @id_rol and funcionalidad_id = @id_func
END

/* Creacion de funciones */
GO
CREATE FUNCTION GESTION_DE_GATOS.existeUsuario(@nombreUsuario VARCHAR(50))
RETURNS NUMERIC(18,0)
AS
BEGIN
DECLARE @ret NUMERIC(18,0), @userDummy NVARCHAR(255)
SELECT @userDummy = usuario_nombre FROM GESTION_DE_GATOS.Usuario 
	where usuario_nombre = @nombreUsuario
IF @userDummy is not null
SET @ret = 1
ELSE
SET @ret = 0
RETURN @ret
END

GO
CREATE FUNCTION GESTION_DE_GATOS.obtenerRolUsuario(@nombreUsuario VARCHAR(50))
RETURNS nvarchar(15)
AS
BEGIN
	DECLARE @ret nvarchar(15)
	SELECT @ret = r.rol_nombre from GESTION_DE_GATOS.Usuario u 
		inner join GESTION_DE_GATOS.UsuarioXRol uxr on uxr.usuario_id = u.usuario_id
		inner join GESTION_DE_GATOS.Rol r on uxr.rol_id = r.rol_id
		where u.usuario_nombre = @nombreUsuario
	RETURN @ret
END

GO
CREATE FUNCTION GESTION_DE_GATOS.obtenerCantIntentosFallidos(@nombreUsuario VARCHAR(50))
RETURNS int
AS
BEGIN
DECLARE @ret int
select @ret = usuario_cont_ingresos_fallidos from Usuario where usuario_nombre = @nombreUsuario
IF @ret IS NULL
BEGIN
SET @ret = -1
END
RETURN @ret
END

GO
CREATE FUNCTION GESTION_DE_GATOS.obtenerFecha(@nombreUsuario NVARCHAR(255),@increase NUMERIC(18,0))
RETURNS int
BEGIN 
DECLARE @ret NUMERIC(18,0),
		@fechaCon15Mins DATETIME
SELECT @fechaCon15Mins = DATEADD(minute, @increase, usuario_fecha_bloqueo) 
	FROM GESTION_DE_GATOS.Usuario WHERE usuario_nombre = @nombreUsuario
SET @ret = DATEDIFF(SECOND,{d '1970-01-01'}, @fechaCon15Mins)
IF @ret IS NULL
BEGIN
SET @ret = -1
END
RETURN @ret
END

GO
CREATE  FUNCTION GESTION_DE_GATOS.usuarioEstaBloqueado(@nombreUsuario NVARCHAR(255))
RETURNS NUMERIC(18,0)
AS
BEGIN
DECLARE @ret NUMERIC(18,0)
SELECT @ret = usuario_bloqueado FROM GESTION_DE_GATOS.Usuario 
	WHERE usuario_nombre = @nombreUsuario
IF @ret IS NULL
BEGIN
SET @ret = 0
END
RETURN @ret
END



GO
CREATE FUNCTION GESTION_DE_GATOS.loginValido(@nombreUsuario NVARCHAR(255), @password NVARCHAR(128))
RETURNS BIT
AS
BEGIN
DECLARE @userDummy NVARCHAR(255),
		@ret BIT
SELECT @userDummy = usuario_nombre FROM GESTION_DE_GATOS.Usuario 
where usuario_password = HASHBYTES('SHA2_256', convert(nvarchar(128), @password)) AND
	  usuario_nombre = @nombreUsuario
IF  (@userDummy IS NOT NULL)
BEGIN
	SET @ret = 1
END
ELSE
BEGIN
	SET @ret = 0
END
RETURN @ret
END

