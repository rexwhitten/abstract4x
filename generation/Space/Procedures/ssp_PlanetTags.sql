CREATE PROCEDURE [dbo].[ssp_PlanetTags]
	@SysId [int] = NULL,
	@PlanetSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PlanetSysId],
[Tag],
[CreateDate],
[Active]
FROM PlanetTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PlanetSysId IS NULL OR PlanetSysId = @PlanetSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



