CREATE PROCEDURE [dbo].[ssp_StarSectors]
	@SysId [int] = NULL,
	@StarSectorStatusSysId [int] = NULL,
	@StarSectorTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[StarSectorStatusSysId],
[StarSectorTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM StarSectors
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@StarSectorStatusSysId IS NULL OR StarSectorStatusSysId = @StarSectorStatusSysId)
AND
(@StarSectorTypeSysId IS NULL OR StarSectorTypeSysId = @StarSectorTypeSysId)
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



