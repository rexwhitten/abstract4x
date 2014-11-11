CREATE PROCEDURE [dbo].[ssp_NebulaMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@NebulaSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[NebulaSysId],
[KeyPath],
[KeyValue],
[Active]
FROM NebulaMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@NebulaSysId IS NULL OR NebulaSysId = @NebulaSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



