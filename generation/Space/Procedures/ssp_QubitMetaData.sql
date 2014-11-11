CREATE PROCEDURE [dbo].[ssp_QubitMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@QubitSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[QubitSysId],
[KeyPath],
[KeyValue],
[Active]
FROM QubitMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@QubitSysId IS NULL OR QubitSysId = @QubitSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



