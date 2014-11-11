CREATE PROCEDURE [dbo].[ssp_PlayerTags]
	@SysId [int] = NULL,
	@PlayerSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PlayerSysId],
[Tag],
[CreateDate],
[Active]
FROM PlayerTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PlayerSysId IS NULL OR PlayerSysId = @PlayerSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



