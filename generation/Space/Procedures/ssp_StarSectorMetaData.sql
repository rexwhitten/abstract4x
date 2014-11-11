CREATE PROCEDURE [dbo].[ssp_StarSectorMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@StarSectorSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[StarSectorSysId],
[KeyPath],
[KeyValue],
[Active]
FROM StarSectorMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@StarSectorSysId IS NULL OR StarSectorSysId = @StarSectorSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



