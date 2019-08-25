--Funciones utilizadas para el tp de gestion 2c2019


GO
CREATE FUNCTION existeUsuario(@userName VARCHAR(30))
RETURNS INT
AS
BEGIN
DECLARE @ret int,@userDummy varchar(30)
SET @userDummy = (SELECT userName FROM gdd.usuario where userName = @userName)
IF @userName = @userDummy 
SET @ret = 0
ELSE
SET @ret = 1
RETURN @ret
END
GO


CREATE FUNCTION validateLogin(
@user VARCHAR(30),@password VARCHAR(128))
RETURNS INT
AS
BEGIN
DECLARE @userDummy VARCHAR(30),
        @PasswordDummy VARBINARY(128),
		@ret BIT
SET @userDummy = (SELECT userName from gdd.usuario where gdd.usuario.userName = @user)
SET @PasswordDummy = (SELECT  password from gdd.usuario where gdd.usuario.password = HASHBYTES('SHA2_512',@password))
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
GO

CREATE FUNCTION userIsBlocked(@userName VARCHAR(30))
RETURNS INT
AS
BEGIN
DECLARE @ret INT
SET @ret = (SELECT bloqueado FROM gdd.usuario WHERE username = @userName)
RETURN @ret
END
GO

CREATE FUNCTION obtenerFechaBloqueoDe(@userName VARCHAR(30),@tiempoBloqueo INT)
RETURNS BIGINT
BEGIN 
DECLARE @dummyUser VARCHAR(30),
        @ret BIGINT,
		@fechaConMinutosAgregados DATETIME
SET @fechaConMinutosAgregados = (SELECT DATEADD(minute,@tiempoBloqueo,fechaBloqueo) FROM GDD.usuario WHERE userName = @userName)
SET @ret = (SELECT DATEDIFF(SECOND,{d '1970-01-01'},@fechaConMinutosAgregados) FROM gdd.usuario WHERE userName = @userName)
IF @ret IS NULL
BEGIN
SET @ret =-1;
END
RETURN @ret
END
GO



