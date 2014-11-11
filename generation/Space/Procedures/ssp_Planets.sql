CREATE PROCEDURE [dbo].[ssp_Planets]
	@SysId [int] = NULL,
	@PlanetStatusSysId [int] = NULL,
	@PlanetTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PlanetStatusSysId],
[PlanetTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Planets
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PlanetStatusSysId IS NULL OR PlanetStatusSysId = @PlanetStatusSysId)
AND
(@PlanetTypeSysId IS NULL OR PlanetTypeSysId = @PlanetTypeSysId)
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



