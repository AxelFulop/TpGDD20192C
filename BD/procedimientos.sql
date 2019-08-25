--Procedures utilizados para el tp

GO
CREATE PROCEDURE crearUsuario
@userName varchar(30),
@password varchar(128)
AS
BEGIN 
DECLARE @passHash varbinary(128)
SET @passHash =  HASHBYTES('SHA2_512',@password)
INSERT INTO gdd.usuario (userName,password) VALUES (@userName,@passHash)
END
GO



CREATE PROCEDURE actualizarEstadoBloqueadoUsuario
@userName VARCHAR(30),
@bloqueado VARCHAR(2),
@fechaBloqueo VARCHAR(20)
AS
BEGIN
if @bloqueado = 1  
BEGIN
UPDATE gdd.usuario SET bloqueado = CAST(@bloqueado as INT),fechaBloqueo = CAST(@fechaBloqueo as datetime) WHERE userName = @userName
END
if @bloqueado = 0 
BEGIN
UPDATE gdd.usuario SET bloqueado = CAST(@bloqueado as INT),fechaBloqueo = NULL WHERE userName = @userName
END
END
GO