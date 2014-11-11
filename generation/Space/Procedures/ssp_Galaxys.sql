CREATE PROCEDURE [dbo].[ssp_Galaxys]
	@SysId [int] = NULL,
	@GalaxyStatusSysId [int] = NULL,
	@GalaxyTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[GalaxyStatusSysId],
[GalaxyTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Galaxys
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@GalaxyStatusSysId IS NULL OR GalaxyStatusSysId = @GalaxyStatusSysId)
AND
(@GalaxyTypeSysId IS NULL OR GalaxyTypeSysId = @GalaxyTypeSysId)
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



