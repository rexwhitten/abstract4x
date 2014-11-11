CREATE PROCEDURE [dbo].[ssp_StructureTags]
	@SysId [int] = NULL,
	@StructureSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[StructureSysId],
[Tag],
[CreateDate],
[Active]
FROM StructureTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@StructureSysId IS NULL OR StructureSysId = @StructureSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



