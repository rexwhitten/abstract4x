CREATE PROCEDURE [dbo].[ssp_StarSectorTags]
	@SysId [int] = NULL,
	@StarSectorSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[StarSectorSysId],
[Tag],
[CreateDate],
[Active]
FROM StarSectorTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@StarSectorSysId IS NULL OR StarSectorSysId = @StarSectorSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



