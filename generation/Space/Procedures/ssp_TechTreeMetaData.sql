CREATE PROCEDURE [dbo].[ssp_TechTreeMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@TechTreeSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[TechTreeSysId],
[KeyPath],
[KeyValue],
[Active]
FROM TechTreeMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@TechTreeSysId IS NULL OR TechTreeSysId = @TechTreeSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



