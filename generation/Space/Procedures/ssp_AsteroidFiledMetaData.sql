CREATE PROCEDURE [dbo].[ssp_AsteroidFiledMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@AsteroidFiledSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[AsteroidFiledSysId],
[KeyPath],
[KeyValue],
[Active]
FROM AsteroidFiledMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@AsteroidFiledSysId IS NULL OR AsteroidFiledSysId = @AsteroidFiledSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



