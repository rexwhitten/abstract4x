CREATE PROCEDURE [dbo].[ssp_PlanetMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@PlanetSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[PlanetSysId],
[KeyPath],
[KeyValue],
[Active]
FROM PlanetMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@PlanetSysId IS NULL OR PlanetSysId = @PlanetSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



