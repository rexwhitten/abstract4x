CREATE PROCEDURE [dbo].[ssp_AsteroidFileds]
	@SysId [int] = NULL,
	@AsteroidFiledStatusSysId [int] = NULL,
	@AsteroidFiledTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[AsteroidFiledStatusSysId],
[AsteroidFiledTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM AsteroidFileds
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@AsteroidFiledStatusSysId IS NULL OR AsteroidFiledStatusSysId = @AsteroidFiledStatusSysId)
AND
(@AsteroidFiledTypeSysId IS NULL OR AsteroidFiledTypeSysId = @AsteroidFiledTypeSysId)
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



