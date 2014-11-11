CREATE PROCEDURE [dbo].[ssp_LocationMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@LocationSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[LocationSysId],
[KeyPath],
[KeyValue],
[Active]
FROM LocationMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@LocationSysId IS NULL OR LocationSysId = @LocationSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



