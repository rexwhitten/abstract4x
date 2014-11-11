CREATE PROCEDURE [dbo].[ssp_PlanetLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentPlanetSysId [int] = NULL,
	@ChildPlanetSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentPlanetSysId],
[ChildPlanetSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM PlanetLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentPlanetSysId IS NULL OR ParentPlanetSysId = @ParentPlanetSysId)
AND
(@ChildPlanetSysId IS NULL OR ChildPlanetSysId = @ChildPlanetSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



