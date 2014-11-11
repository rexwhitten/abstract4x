CREATE PROCEDURE [dbo].[ssp_PlayerAttributes]
	@SysId [int] = NULL,
	@PlayerSysId [int] = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Email [varchar](128) = NULL,
	@Username [varchar](128) = NULL,
	@PasswordHash [varchar](256) = NULL
AS
SELECT 
[SysId],
[PlayerSysId],
[CreateDate],
[LastModifiedDate],
[Email],
[Username],
[PasswordHash]
FROM PlayerAttributes
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PlayerSysId IS NULL OR PlayerSysId = @PlayerSysId)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Email IS NULL OR Email = @Email)
AND
(@Username IS NULL OR Username = @Username)
AND
(@PasswordHash IS NULL OR PasswordHash = @PasswordHash)



