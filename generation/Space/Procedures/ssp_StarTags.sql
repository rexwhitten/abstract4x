CREATE PROCEDURE [dbo].[ssp_StarTags]
	@SysId [int] = NULL,
	@StarSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[StarSysId],
[Tag],
[CreateDate],
[Active]
FROM StarTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@StarSysId IS NULL OR StarSysId = @StarSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



