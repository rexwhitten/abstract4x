CREATE PROCEDURE [dbo].[ssp_StructureMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@StructureSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[StructureSysId],
[KeyPath],
[KeyValue],
[Active]
FROM StructureMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@StructureSysId IS NULL OR StructureSysId = @StructureSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



