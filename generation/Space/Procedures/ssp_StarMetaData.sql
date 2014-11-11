CREATE PROCEDURE [dbo].[ssp_StarMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@StarSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[StarSysId],
[KeyPath],
[KeyValue],
[Active]
FROM StarMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@StarSysId IS NULL OR StarSysId = @StarSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



