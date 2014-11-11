CREATE PROCEDURE [dbo].[ssp_PlayerMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@PlayerSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[PlayerSysId],
[KeyPath],
[KeyValue],
[Active]
FROM PlayerMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@PlayerSysId IS NULL OR PlayerSysId = @PlayerSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



