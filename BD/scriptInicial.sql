USE GD2C2019

----- Eliminacion de stored procedures ---------  
IF OBJECT_ID('GESTION_DE_GATOS.habilitarRol') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.habilitarRol

IF OBJECT_ID('GESTION_DE_GATOS.agregarRolAUsuario') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.agregarRolAUsuario

IF OBJECT_ID('GESTION_DE_GATOS.cambiarNombreRol') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.cambiarNombreRol

IF OBJECT_ID('GESTION_DE_GATOS.tarjetaRegaloParaUsuario') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.tarjetaRegaloParaUsuario

IF OBJECT_ID('GESTION_DE_GATOS.inhabilitarRol') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.inhabilitarRol

IF OBJECT_ID('GESTION_DE_GATOS.updateBloqueadoUser') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.updateBloqueadoUser

IF OBJECT_ID('GESTION_DE_GATOS.eliminarFuncionalidadARol') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.eliminarFuncionalidadARol

IF OBJECT_ID('GESTION_DE_GATOS.sumarIntentoFallido') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.sumarIntentoFallido

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

IF OBJECT_ID('GESTION_DE_GATOS.altaCliente') IS NOT NULL
    DROP PROCEDURE GESTION_DE_GATOS.altaCliente

----- Eliminacion de funciones ---------  
IF OBJECT_ID('GESTION_DE_GATOS.clienteEstaHabilitado') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.clienteEstaHabilitado

IF OBJECT_ID('GESTION_DE_GATOS.proveedorEstaHabilitado') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.proveedorEstaHabilitado

IF OBJECT_ID('GESTION_DE_GATOS.obtenerRolUsuario') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerRolUsuario

IF OBJECT_ID('GESTION_DE_GATOS.existeUsuario') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.existeUsuario

IF OBJECT_ID('GESTION_DE_GATOS.obtenerFecha') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerFecha

IF OBJECT_ID('GESTION_DE_GATOS.usuarioEstaBloqueado') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.usuarioEstaBloqueado

IF OBJECT_ID('GESTION_DE_GATOS.obtenerTarjetasUsuario') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerTarjetasUsuario

IF OBJECT_ID('GESTION_DE_GATOS.loginValido') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.loginValido

IF OBJECT_ID('GESTION_DE_GATOS.obtenerCantIntentosFallidos') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerCantIntentosFallidos 

IF OBJECT_ID('GESTION_DE_GATOS.rolEstaHabilitado') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.rolEstaHabilitado

IF OBJECT_ID('GESTION_DE_GATOS.obtenerTarjetasUsuario') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.obtenerTarjetasUsuario

IF OBJECT_ID('GESTION_DE_GATOS.tipoTarjeta') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.tipoTarjeta
	
IF OBJECT_ID('GESTION_DE_GATOS.duenioTarjeta') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.duenioTarjeta
	
IF OBJECT_ID('GESTION_DE_GATOS."bancoTarjeta"') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS."bancoTarjeta"

IF OBJECT_ID('GESTION_DE_GATOS."cvvTarjeta"') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS."cvvTarjeta"

IF OBJECT_ID('GESTION_DE_GATOS."saldoTarjeta"') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS."saldoTarjeta"

IF OBJECT_ID('GESTION_DE_GATOS."fechaVencimientoTarjeta"') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS."fechaVencimientoTarjeta" 

IF OBJECT_ID('GESTION_DE_GATOS."saldoCliente"') IS NOT NULL
    DROP FUNCTION  GESTION_DE_GATOS.saldoCliente
------------ Eliminacion de Triggers --------------
IF OBJECT_ID('GESTION_DE_GATOS."tr_evitar_proveedores_gemelos"') IS NOT NULL
    DROP TRIGGER  GESTION_DE_GATOS.tr_evitar_proveedores_gemelos

IF OBJECT_ID('GESTION_DE_GATOS."tr_evitar_clientes_gemelos"') IS NOT NULL
    DROP TRIGGER  GESTION_DE_GATOS.tr_evitar_clientes_gemelos

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

IF (select object_id from sys.foreign_keys where [name] = 'FC19')  IS NOT NULL
    ALTER TABLE GESTION_DE_GATOS.Carga  DROP CONSTRAINT FC19

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
cliente_numero_dni NUMERIC(18,0),
cliente_email NVARCHAR(255),
cliente_fecha_nacimiento DATETIME,
cliente_telefono NUMERIC(18,0),
cliente_direccion NVARCHAR(255), --Formato direccion: "calle numero"
cliente_direccion_piso NVARCHAR(10),
cliente_direccion_depto nvarchar(5),
cliente_direccion_localidad nvarchar(50),
cliente_codigo_postal NVARCHAR(255),
cliente_dato_inconsistente CHAR(1),
cliente_nuevo CHAR(1),
cliente_habilitado char,
PRIMARY KEY (cliente_id)
);

CREATE TABLE GESTION_DE_GATOS.Tarjeta(
tarjeta_id NUMERIC(18,0) IDENTITY,
cliente_id NUMERIC(18,0),
tarjeta_numero NUMERIC(18,0) unique,
tarjeta_saldo NUMERIC(18,4),
tarjeta_tipo NVARCHAR(10),
tarjeta_banco VARCHAR(15),
tarjeta_fecha_vencimiento DATETIME,
tarjeta_cvv NUMERIC(18,0),
tarjeta_es_regalo char, --1 si es la de regalo, con esta no debería poder realizar cargas
PRIMARY KEY (tarjeta_id)
);

CREATE TABLE GESTION_DE_GATOS.Carga(
carga_id NUMERIC(18,0) IDENTITY ,
tarjeta_id NUMERIC(18,0),
cliente_id NUMERIC(18, 0), --Para saber de qué cliente son las cargas que ya están en la tabla maestra.
--Ya que no se puede referenciar en la migracion a qué tarjeta pertenece
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
proveedor_direccion NVARCHAR(255), --Formato direccion: "calle numero"
proveedor_direccion_piso int,
proveedor_direccion_depto nvarchar(5),
proveedor_direccion_localidad nvarchar(50),
proveedor_ciudad NVARCHAR(255),
proveedor_codigo_postal NVARCHAR(255),
proveedor_dato_inconsistente CHAR(1),
proveedor_nuevo CHAR(1),
proveedor_habilitado char,
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
--limite_cliente NUMERIC(18,0)
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
ALTER TABLE GESTION_DE_GATOS.Carga ADD CONSTRAINT FC19 FOREIGN KEY(cliente_id) REFERENCES GESTION_DE_GATOS.Cliente(cliente_id)

/* Inserccion de datos previos */
--Usuario Admin
INSERT INTO GESTION_DE_GATOS.Usuario (usuario_nombre,usuario_password)
VALUES('admin',HASHBYTES('SHA2_256',convert(nvarchar(128), 'admin'))) 

--Roles
insert into GESTION_DE_GATOS.Rol(rol_nombre, rol_habilitado) values('Administrador', '0')
insert into GESTION_DE_GATOS.Rol(rol_nombre, rol_habilitado) values('Cliente', '0')
insert into GESTION_DE_GATOS.Rol(rol_nombre, rol_habilitado) values('Proveedor', '0')

--Funcionalidades
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('ABM rol') --1 ADM
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('ABM cliente') --2 ADM
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('ABM proveedor') --3 ADM
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Facturar a proveedor') --4 ADM
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Listado estadistico') --5 ADM
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Cargar credito') --6 cliente
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Comprar oferta') --7 cliente
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('Registrar tarjeta') --8 cliente
insert into GESTION_DE_GATOS.Funcionalidad(funcionalidad_descripcion) values('ABM oferta') --9 prov

--Funcionalidades Admin
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 1)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 2)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 3)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 4)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(1, 5)

--Funcionalidades Cliente
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(2,6)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(2,7)
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(2,8)

--Funcionalidades Proveedor
insert into GESTION_DE_GATOS.FuncionalidadXRol(rol_id, funcionalidad_id) values(3,9)

/* Migracion de la Maestra */
--Cliente
PRINT 'Migrando Clientes'
INSERT  INTO GESTION_DE_GATOS.Cliente (cliente_nombre,cliente_apellido,cliente_email,
								cliente_numero_dni,cliente_direccion,cliente_fecha_nacimiento,
								cliente_ciudad,cliente_telefono, cliente_habilitado) 
SELECT DISTINCT Cli_Nombre,Cli_Apellido,Cli_Mail,Cli_Dni,Cli_Direccion,
		Cli_Fecha_Nac,Cli_Ciudad,Cli_Telefono, '0'
FROM gd_esquema.Maestra
WHERE Cli_Apellido IS NOT NULL AND Cli_Nombre IS NOT NULL AND Cli_Dni IS NOT NULL
	
--Proveedores
PRINT 'Migrando Proovedores'
INSERT INTO GESTION_DE_GATOS.Proveedor (proveedor_razon_social,proveedor_cuit,proveedor_rubro,proveedor_telefono,proveedor_ciudad,proveedor_direccion, proveedor_habilitado)
SELECT DISTINCT Provee_RS,Provee_CUIT,Provee_Rubro,Provee_Telefono,Provee_Ciudad,Provee_Dom,'0' FROM gd_esquema.Maestra
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
SELECT proveedor_cuit, HASHBYTES('SHA2_256', CONVERT(nvarchar(128), proveedor_razon_social)), 0, 0 from GESTION_DE_GATOS.Proveedor

UPDATE GESTION_DE_GATOS.Proveedor SET
usuario_id = (SELECT usuario_id FROM GESTION_DE_GATOS.Usuario where usuario_nombre = proveedor_cuit)

--Roles
PRINT 'Asignando roles a clientes'
INSERT INTO GESTION_DE_GATOS.UsuarioXRol(usuario_id, rol_id)
SELECT usuario_id, 2 from GESTION_DE_GATOS.Cliente

PRINT 'Asignando roles a proveedores'
INSERT INTO GESTION_DE_GATOS.UsuarioXRol(usuario_id, rol_id)
SELECT usuario_id, 3 from GESTION_DE_GATOS.Proveedor

--Asignacion rol a administrador
INSERT INTO GESTION_DE_GATOS.UsuarioXRol(usuario_id, rol_id)
	VALUES(1, 1)

--Factura
PRINT 'Migrando Facturas'
INSERT INTO GESTION_DE_GATOS.Factura (proveedor_id,factura_numero,factura_fecha, factura_monto_total)
SELECT proveedor_id, Factura_Nro, Factura_Fecha, sum(Oferta_Cantidad * Oferta_Precio_Ficticio)
FROM gd_esquema.Maestra
JOIN GESTION_DE_GATOS.Proveedor ON (
Provee_RS = proveedor_razon_social AND
Provee_CUIT = Provee_CUIT AND
Provee_Telefono = proveedor_telefono
)
WHERE Factura_Nro IS NOT NULL AND Factura_Fecha IS NOT NULL
group by Factura_Nro, Factura_Fecha, proveedor_id


--Oferta
PRINT 'Migrando Ofertas'
INSERT INTO GESTION_DE_GATOS.Oferta (proveedor_id,oferta_stock_disponible,oferta_codigo,
	oferta_descripcion,oferta_fecha_publicacion,oferta_fecha_vencimiento,oferta_precio,
	oferta_precio_lista, oferta_limite_compra)
SELECT DISTINCT proveedor_id,Oferta_Cantidad,Oferta_Codigo,Oferta_Descripcion,Oferta_Fecha,
	Oferta_Fecha_Venc,Oferta_Precio,Oferta_Precio_Ficticio, Oferta_Cantidad --Inicialmente un cliente podria comprar todo el stock
FROM gd_esquema.Maestra
JOIN GESTION_DE_GATOS.Proveedor ON (
Provee_RS = proveedor_razon_social AND
Provee_CUIT = Provee_CUIT AND
Provee_Telefono = proveedor_telefono
)
WHERE Oferta_Codigo IS NOT NULL

--Tarjeta
/*PRINT 'Migrando Tarjetas'
INSERT INTO GESTION_DE_GATOS.Tarjeta(cliente_id,tarjeta_tipo)
SELECT DISTINCT cliente_id,Tipo_Pago_Desc
FROM gd_esquema.Maestra
JOIN GESTION_DE_GATOS.Cliente ON (
Cli_Nombre = cliente_nombre AND
Cli_Apellido = cliente_apellido AND
Cli_Dni = cliente_numero_dni AND
Cli_Mail = cliente_email
)*/
--Inicialmente un cliente no tiene tarjetas, ya que en la 
--tabla Maestra no hay datos de las tarjetas y no podemos mandar fruta. Las cargas de la tabla maestra
--quedarán referenciadas sin una tarjeta. Las nuevas tendrán datos de la tarjeta
--con la que se efectuó la carga

--Carga
PRINT 'Migrando Carga'
INSERT INTO GESTION_DE_GATOS.Carga(tarjeta_id,carga_monto,carga_fecha, cliente_id)
SELECT DISTINCT null, Carga_Credito, Carga_Fecha, c.cliente_id
FROM gd_esquema.Maestra
JOIN GESTION_DE_GATOS.Cliente c ON (
Cli_Nombre = c.cliente_nombre AND
Cli_Apellido = c.cliente_apellido AND
Cli_Dni = c.cliente_numero_dni AND
Cli_Mail = c.cliente_email
)
WHERE Carga_Credito IS NOT NULL 

--Compra
PRINT 'Migrando Compras'
INSERT INTO GESTION_DE_GATOS.Compra (oferta_id,cliente_id,compra_fecha)
SELECT o.oferta_id, c.cliente_id, m.Oferta_Fecha_Compra FROM  gd_esquema.Maestra m
JOIN GESTION_DE_GATOS.Cliente c  ON (
Cli_Dni = c.cliente_numero_dni AND
Cli_Mail = c.cliente_email
)
JOIN GESTION_DE_GATOS.Oferta o ON (
m.Oferta_Codigo = o.oferta_codigo AND
m.Oferta_Fecha = o.oferta_fecha_publicacion
)
where Oferta_Fecha_Compra is not null

--DetalleFactura
PRINT 'Migrando Fechas de entrega'
INSERT INTO GESTION_DE_GATOS.DetalleFactura(detalle_fecha_entregado)
SELECT m.Oferta_Entregado_Fecha FROM gd_esquema.Maestra m

/* Creación de procedures */
GO
CREATE PROCEDURE GESTION_DE_GATOS.altaUsuario
@nombreUsuario NVARCHAR(255),
@password NVARCHAR(128)
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
@cvvTarjeta NUMERIC(18,0),
@userName NVARCHAR(255)
AS
BEGIN 
DECLARE @clienteID NUMERIC(18,0)
SET @clienteID = (SELECT cliente_id FROM GESTION_DE_GATOS.Cliente c,GESTION_DE_GATOS.Usuario u
                  WHERE c.usuario_id = u.usuario_id and u.usuario_nombre = @userName)
INSERT INTO GESTION_DE_GATOS.Tarjeta (cliente_id,tarjeta_numero,tarjeta_tipo,tarjeta_banco,tarjeta_fecha_vencimiento,tarjeta_cvv, tarjeta_es_regalo, tarjeta_saldo)
VALUES (@clienteID,@numeroTarjeta,@tipoTarjeta,@bancoTarjeta,@vencimientoFechaTarjeta,@cvvTarjeta, '0', 0)
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.altaCarga
@fechaCarga NVARCHAR(20),
@montoCarga NUMERIC(18,2),
@numeroTarjeta NUMERIC(18,0)
AS
BEGIN
DECLARE @idTarjeta NUMERIC(18,0)
SELECT @idTarjeta = tarjeta_id FROM GESTION_DE_GATOS.Tarjeta WHERE tarjeta_numero = @numeroTarjeta
INSERT INTO GESTION_DE_GATOS.Carga(tarjeta_id, carga_fecha, carga_monto)
	VALUES(@idTarjeta, CONVERT(datetime, @fechaCarga), @montoCarga)
UPDATE GESTION_DE_GATOS.Tarjeta SET tarjeta_saldo = tarjeta_saldo + @montoCarga
	WHERE tarjeta_id = @idTarjeta
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.altaRol
@nombreRol NVARCHAR(15)
AS
BEGIN
	INSERT INTO GESTION_DE_GATOS.Rol (rol_nombre, rol_habilitado)
		VALUES (@nombreRol, 0)
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
@pisoProveedor int,
@deptoProveedor nvarchar(5),
@localidadProveedor nvarchar(50),
@codigoPostalProveedor NUMERIC(18,0),
@ciudadProveedor NVARCHAR(255),
@cuitProveedor NUMERIC(18,0),
@rubroProveedor NVARCHAR(100),
@nombreDeContactoProveedor NVARCHAR(30),
@usuario NVARCHAR(255)
AS
BEGIN
	declare @id_usuario numeric(18)
	select @id_usuario = usuario_id from Usuario where usuario_nombre = @usuario
	INSERT INTO GESTION_DE_GATOS.Proveedor (proveedor_razon_social,proveedor_email,proveedor_telefono,
			proveedor_direccion,proveedor_codigo_postal,proveedor_ciudad,
			proveedor_cuit,proveedor_rubro,proveedor_contacto, usuario_id,
			proveedor_direccion_depto, proveedor_direccion_localidad, proveedor_direccion_piso)
		VALUES (@razonSocialProveedor,@mailProveedor,@teléfonoProveedor,@direccionProveedor,
			@codigoPostalProveedor,@ciudadProveedor,@cuitProveedor,@rubroProveedor,
			@nombreDeContactoProveedor, @id_usuario, @deptoProveedor, @localidadProveedor, @pisoProveedor)
	insert into UsuarioXRol(usuario_id, rol_id)
		values(@id_usuario, (select rol_id from Rol where rol_nombre = 'Proveedor'))
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.altaCliente
@fecha_nac NVARCHAR(25),
@nombreCliente NVARCHAR(255),
@apellidoCliente NVARCHAR(255),
@dniCliente NVARCHAR(255),
@mailCliente NVARCHAR(255),
@telefonoCliente NVARCHAR(255),
@direccionCliente NVARCHAR(255),
@pisoCliente nvarchar(10),
@deptoCliente nvarchar(5),
@localidadCliente nvarchar(50),
@codigoPostalCliente NVARCHAR(15),
@ciudadCliente NVARCHAR(255),
@usuario NVARCHAR(255)
AS
BEGIN
	declare @id_usuario numeric(18)
	select @id_usuario = usuario_id from Usuario where usuario_nombre = @usuario
	INSERT INTO GESTION_DE_GATOS.Cliente (cliente_fecha_nacimiento,
		cliente_nombre,cliente_apellido,cliente_numero_dni,cliente_email,cliente_telefono,
		cliente_direccion,cliente_codigo_postal,cliente_ciudad, usuario_id,
		cliente_direccion_depto, cliente_direccion_localidad, cliente_direccion_piso)
		VALUES(convert(datetime, @fecha_nac),@nombreCliente,@apellidoCliente,CAST(@dniCliente AS NUMERIC(18,0)),
		@mailCliente,CAST(@telefonoCliente AS numeric(18,0)),@direccionCliente,
		CAST(@codigoPostalCliente AS NUMERIC(18,0)) ,@ciudadCliente,@id_usuario, @deptoCliente, @localidadCliente,@pisoCliente)
	insert into UsuarioXRol(usuario_id, rol_id)
		values(@id_usuario, (select rol_id from Rol where rol_nombre = 'Cliente'))
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

GO
CREATE PROCEDURE GESTION_DE_GATOS.inhabilitarRol
@nombreRol NVARCHAR(15)
AS
BEGIN 
	begin transaction
	begin try
		update Rol set rol_habilitado = '1'
			where rol_nombre = @nombreRol
		delete UsuarioXRol where
			rol_id = (select rol_id from Rol where rol_nombre = @nombreRol)
		commit transaction
	end try
	begin catch
		rollback transaction
	end catch
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.habilitarRol
@nombreRol NVARCHAR(15)
AS
BEGIN 
	update Rol set rol_habilitado = '0'
		where rol_nombre = @nombreRol
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.cambiarNombreRol
@nombreRol NVARCHAR(15),
@nuevoNombre NVARCHAR(15)
AS
BEGIN 
	update Rol set rol_nombre = @nuevoNombre
		where rol_nombre = @nombreRol
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.agregarRolAUsuario
@nombreUsuario NVARCHAR(255),
@nombreRol NVARCHAR(15)
AS
BEGIN
	declare @esta_habilitado char
	select @esta_habilitado = rol_habilitado from Rol
		where rol_nombre = @nombreRol

	if(@esta_habilitado = '1') begin
		raiserror('Rol inhabilitado no puede ser asignado a un usuario', 1, 1)
	end
	else begin
		insert UsuarioXRol(usuario_id, rol_id)
			values(
				(select usuario_id from Usuario where usuario_nombre = @nombreUsuario),
				(select rol_id from Rol where rol_nombre = @nombreRol)
			)
	end
END

GO
CREATE PROCEDURE GESTION_DE_GATOS.tarjetaRegaloParaUsuario
@userName NVARCHAR(255),
@fechaVencimiento NVARCHAR(20)
AS
BEGIN
DECLARE @numeroTarjeta NUMERIC(18,0),@CVV BIGINT,@idCliente NUMERIC(18,0)
SET @numeroTarjeta = (SELECT CAST(RAND() * 10000000000000000 AS NUMERIC(18,0)))
SET @CVV = (SELECT FLOOR(RAND() * 900)+ 100)
SET @idCliente = (SELECT c.cliente_id FROM GESTION_DE_GATOS.Cliente c,GESTION_DE_GATOS.Usuario u WHERE u.usuario_nombre = @userName and c.usuario_id = u.usuario_id )
INSERT INTO GESTION_DE_GATOS.Tarjeta (cliente_id,tarjeta_saldo,tarjeta_banco,tarjeta_cvv,tarjeta_fecha_vencimiento,tarjeta_numero,tarjeta_tipo, tarjeta_es_regalo)
VALUES(@idCliente,200,'HSCBC',@CVV,CONVERT(DATETIME,@fechaVencimiento),@numeroTarjeta,'Debito', '1')
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
CREATE FUNCTION GESTION_DE_GATOS.obtenerTarjetasUsuario(@userName NVARCHAR(255))
RETURNS NUMERIC(18,0)
AS
BEGIN
RETURN (SELECT tarjeta_numero 
        FROM GESTION_DE_GATOS.Tarjeta t
		JOIN GESTION_DE_GATOS.Cliente c on t.cliente_id = c.cliente_id
		JOIN GESTION_DE_GATOS.Usuario u on u.usuario_id = c.usuario_id
		WHERE u.usuario_nombre = @userName)
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

GO
CREATE FUNCTION GESTION_DE_GATOS.rolEstaHabilitado(@nombreRol NVARCHAR(15))
RETURNS char
AS
BEGIN
	return (select rol_habilitado from GESTION_DE_GATOS.Rol 
			where rol_nombre = @nombreRol)
END

GO
CREATE FUNCTION GESTION_DE_GATOS.clienteEstaHabilitado(@usuario NVARCHAR(15))
RETURNS char
AS
BEGIN
	return (select c.cliente_habilitado from GESTION_DE_GATOS.Cliente c
				inner join GESTION_DE_GATOS.Usuario u on c.usuario_id = u.usuario_id
			where u.usuario_nombre = @usuario)
END

GO
CREATE FUNCTION GESTION_DE_GATOS.proveedorEstaHabilitado(@usuario NVARCHAR(15))
RETURNS char
AS
BEGIN
	return (select c.proveedor_habilitado from GESTION_DE_GATOS.Proveedor c
				inner join GESTION_DE_GATOS.Usuario u on c.usuario_id = u.usuario_id
			where u.usuario_nombre = @usuario)
END

GO
CREATE FUNCTION GESTION_DE_GATOS.tipoTarjeta(@numeroTarjeta NUMERIC(18,0))
RETURNS NVARCHAR(10)
AS
BEGIN
DECLARE @TIPO NVARCHAR(10),@Res NVARCHAR(10)
SELECT @TIPO = tarjeta_tipo FROM GESTION_DE_GATOS.Tarjeta WHERE tarjeta_numero = @numeroTarjeta
RETURN @TIPO
END

GO
CREATE FUNCTION GESTION_DE_GATOS.duenioTarjeta(@numeroTarjeta NUMERIC(18,0),@username nvarchar(255))
RETURNS NVARCHAR(255)
AS
BEGIN
RETURN (SELECT u.usuario_nombre FROM GESTION_DE_GATOS.Tarjeta T ,GESTION_DE_GATOS.Cliente C, GESTION_DE_GATOS.Usuario u
        WHERE tarjeta_numero = @numeroTarjeta and
		c.usuario_id = u.usuario_id AND
		u.usuario_nombre = @username AND
		t.cliente_id = c.cliente_id)
END

GO
CREATE FUNCTION GESTION_DE_GATOS.saldoTarjeta(@numeroTarjeta NUMERIC(18,0))
RETURNS NUMERIC(18,4)
AS
BEGIN
DECLARE @saldo NUMERIC(18,4)
SELECT @saldo = tarjeta_saldo FROM GESTION_DE_GATOS.Tarjeta 
	WHERE tarjeta_numero = @numeroTarjeta
RETURN @saldo
END

GO
CREATE FUNCTION GESTION_DE_GATOS.fechaVencimientoTarjeta(@numeroTarjeta NUMERIC(18,0))
RETURNS datetime
AS
BEGIN
DECLARE @venc datetime
SELECT @venc = tarjeta_fecha_vencimiento FROM GESTION_DE_GATOS.Tarjeta 
	WHERE tarjeta_numero = @numeroTarjeta
RETURN @venc
END

GO
CREATE FUNCTION GESTION_DE_GATOS.cvvTarjeta(@numeroTarjeta NUMERIC(18,0))
RETURNS NUMERIC(18,0)
AS
BEGIN
DECLARE @cvv NUMERIC(18,0)
SELECT @cvv = tarjeta_cvv FROM GESTION_DE_GATOS.Tarjeta 
	WHERE tarjeta_numero = @numeroTarjeta
RETURN @cvv
END

GO
CREATE FUNCTION GESTION_DE_GATOS.bancoTarjeta(@numeroTarjeta NUMERIC(18,0))
RETURNS VARCHAR(15)
AS
BEGIN
DECLARE @banco VARCHAR(15)
SELECT @banco = tarjeta_banco FROM GESTION_DE_GATOS.Tarjeta 
	WHERE tarjeta_numero = @numeroTarjeta
RETURN @banco
END

GO
CREATE FUNCTION GESTION_DE_GATOS.saldoCliente(@usuario nvarchar(255))
RETURNS numeric(18, 4)
AS
BEGIN
DECLARE @saldo numeric(18, 4)
SELECT @saldo = sum(t.tarjeta_saldo) FROM GESTION_DE_GATOS.Tarjeta t
	inner join GESTION_DE_GATOS.Cliente c on c.cliente_id = t.cliente_id
	inner join GESTION_DE_GATOS.Usuario u on u.usuario_id = c.usuario_id
	where u.usuario_nombre = @usuario
RETURN @saldo
END

--Triggers
go
create trigger GESTION_DE_GATOS.tr_evitar_clientes_gemelos on GESTION_DE_GATOS.Cliente instead of insert, update
as begin
	declare @id_cli numeric(18), @nombre nvarchar(255), @apellido nvarchar(255), @dni numeric(18),
		    @id_user numeric(18), @baja char, @ciudad nvarchar(255), @mail nvarchar(255),
			@fecha_nac datetime, @tel numeric(18), @dir nvarchar(255), @piso nvarchar(10), @depto nvarchar(5),
			@localidad nvarchar(50), @cp nvarchar(255), @dato_inc char, @nuevo char, @habilitado char
	declare c_cursor cursor for (select * from inserted)
	open c_cursor
	fetch c_cursor into @id_cli, @id_user, @baja, @nombre, @ciudad, @apellido, @dni, @mail, @fecha_nac, 
		@tel, @dir, @piso, @depto,@localidad, @cp, @dato_inc, @nuevo, @habilitado
	while(@@FETCH_STATUS = 0) begin
		declare @hayClieGemelo int = 
			(select count(*) from GESTION_DE_GATOS.Cliente 
				where cliente_apellido = @apellido and
					  cliente_nombre = @nombre and
					  cliente_numero_dni = @dni)
		if(@hayClieGemelo > 0) begin
			raiserror('Cliente gemelo ya existente', 1, 1)
			rollback
		end
		else begin
			begin try 
				insert into GESTION_DE_GATOS.Cliente(usuario_id, cliente_baja, cliente_nombre, cliente_ciudad,
						cliente_apellido, cliente_numero_dni, cliente_email, cliente_fecha_nacimiento,
						cliente_telefono, cliente_direccion, cliente_direccion_piso, cliente_direccion_depto,
						cliente_direccion_localidad, cliente_codigo_postal, cliente_dato_inconsistente,
						cliente_nuevo, cliente_habilitado)
					(select usuario_id, cliente_baja, cliente_nombre, cliente_ciudad,
						cliente_apellido, cliente_numero_dni, cliente_email, cliente_fecha_nacimiento,
						cliente_telefono, cliente_direccion, cliente_direccion_piso, cliente_direccion_depto,
						cliente_direccion_localidad, cliente_codigo_postal, cliente_dato_inconsistente,
						cliente_nuevo, cliente_habilitado
						from inserted where cliente_id = @id_cli)
			end try
			begin catch --Si hay error es porque fue un update(ya existía cliente)
				update GESTION_DE_GATOS.Cliente set cliente_apellido = @apellido, 
					cliente_baja = @baja, cliente_ciudad = @ciudad, cliente_codigo_postal = @cp, cliente_dato_inconsistente = @dato_inc,
					cliente_direccion = @dir, cliente_direccion_depto = @depto, cliente_direccion_localidad = @localidad,
					cliente_direccion_piso = @piso, cliente_email = @mail, cliente_fecha_nacimiento = @fecha_nac,
					cliente_habilitado = @habilitado, cliente_nombre = @nombre, cliente_nuevo = @nuevo, 
					cliente_numero_dni = @dni, cliente_telefono = @tel, usuario_id = @id_user
					where cliente_id = @id_cli
			end catch
		end
		fetch c_cursor into @id_cli, @id_user, @baja, @nombre, @ciudad, @apellido, @dni, @mail, @fecha_nac, 
			@tel, @dir, @piso, @depto,@localidad, @cp, @dato_inc, @nuevo, @habilitado
	end
	close c_cursor
	deallocate c_cursor
end

go
create trigger tr_evitar_proveedores_gemelos on GESTION_DE_GATOS.Proveedor instead of insert, update
as begin --No puede haber 2 proveedores con la misma razon social y CUIT
	declare @id_prov numeric(18), @id_user numeric(18), @baja char, @r_social nvarchar(100), 
			@contacto nvarchar(30), @cuit nvarchar(20), @rubro nvarchar(100), @mail nvarchar(255),
			@tel numeric(18), @dir nvarchar(255), @piso nvarchar(10), @depto nvarchar(5), @localidad nvarchar(50), 
			@ciudad nvarchar(255), @cp nvarchar(255), @dato_inc char, @nuevo char, @habilitado char
	declare p_cursor cursor for (select * from inserted)
	open p_cursor
	fetch p_cursor into @id_prov, @id_user, @baja, @r_social, @contacto, @cuit, @rubro, @mail,
			@tel, @dir, @piso, @depto, @localidad, @ciudad, @cp, @dato_inc, @nuevo, @habilitado
	while(@@FETCH_STATUS = 0) begin
		declare @hayProvGemelo int = 
			(select count(*) from GESTION_DE_GATOS.Proveedor 
				where proveedor_cuit = @cuit and
					  proveedor_razon_social = @r_social)
		if(@hayProvGemelo > 0) begin
			raiserror('Proveedor gemelo ya existente', 1, 1)
			rollback
		end
		else begin
			begin try 
				insert into GESTION_DE_GATOS.Proveedor(usuario_id, proveedor_baja, proveedor_razon_social, proveedor_contacto,
						proveedor_cuit, proveedor_rubro, proveedor_email, proveedor_telefono, proveedor_direccion,
						proveedor_direccion_piso, proveedor_direccion_depto, proveedor_direccion_localidad,
						proveedor_ciudad, proveedor_codigo_postal, proveedor_dato_inconsistente,
						proveedor_nuevo, proveedor_habilitado)
					(select usuario_id, proveedor_baja, proveedor_razon_social, proveedor_contacto,
						proveedor_cuit, proveedor_rubro, proveedor_email, proveedor_telefono, proveedor_direccion,
						proveedor_direccion_piso, proveedor_direccion_depto, proveedor_direccion_localidad,
						proveedor_ciudad, proveedor_codigo_postal, proveedor_dato_inconsistente,
						proveedor_nuevo, proveedor_habilitado
						from inserted where proveedor_id = @id_prov)
			end try
			begin catch --Si hay error es porque fue un update(ya existía proveedor)
				update GESTION_DE_GATOS.Proveedor set proveedor_contacto = @contacto, 
					proveedor_baja = @baja, proveedor_ciudad = @ciudad, proveedor_codigo_postal = @cp, proveedor_dato_inconsistente = @dato_inc,
					proveedor_direccion = @dir, proveedor_direccion_depto = @depto, proveedor_direccion_localidad = @localidad,
					proveedor_direccion_piso = @piso, proveedor_email = @mail, proveedor_rubro = @rubro,
					proveedor_habilitado = @habilitado, proveedor_nuevo = @nuevo, 
					proveedor_cuit = @cuit, proveedor_telefono = @tel, usuario_id = @id_user
					where proveedor_id = @id_prov
			end catch
		end
		fetch p_cursor into @id_prov, @id_user, @baja, @r_social, @contacto, @cuit, @rubro, @mail,
			@tel, @dir, @piso, @depto, @localidad, @ciudad, @cp, @dato_inc, @nuevo, @habilitado
	end
	close p_cursor
	deallocate p_cursor
end