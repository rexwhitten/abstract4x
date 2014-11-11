CREATE PROCEDURE [dbo].[ssp_Stars]
	@SysId [int] = NULL,
	@StarStatusSysId [int] = NULL,
	@StarTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[StarStatusSysId],
[StarTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Stars
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@StarStatusSysId IS NULL OR StarStatusSysId = @StarStatusSysId)
AND
(@StarTypeSysId IS NULL OR StarTypeSysId = @StarTypeSysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@Path IS NULL OR Path = @Path)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Is_ReadOnly IS NULL OR Is_ReadOnly = @Is_ReadOnly)
AND
(@Active IS NULL OR Active = @Active)



