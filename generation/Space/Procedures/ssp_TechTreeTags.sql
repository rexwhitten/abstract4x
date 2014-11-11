CREATE PROCEDURE [dbo].[ssp_TechTreeTags]
	@SysId [int] = NULL,
	@TechTreeSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[TechTreeSysId],
[Tag],
[CreateDate],
[Active]
FROM TechTreeTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@TechTreeSysId IS NULL OR TechTreeSysId = @TechTreeSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



