CREATE PROCEDURE [dbo].[ssp_MoonTags]
	@SysId [int] = NULL,
	@MoonSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[MoonSysId],
[Tag],
[CreateDate],
[Active]
FROM MoonTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@MoonSysId IS NULL OR MoonSysId = @MoonSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



