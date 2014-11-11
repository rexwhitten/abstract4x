CREATE PROCEDURE [dbo].[ssp_AsteroidFiledTags]
	@SysId [int] = NULL,
	@AsteroidFiledSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[AsteroidFiledSysId],
[Tag],
[CreateDate],
[Active]
FROM AsteroidFiledTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@AsteroidFiledSysId IS NULL OR AsteroidFiledSysId = @AsteroidFiledSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



