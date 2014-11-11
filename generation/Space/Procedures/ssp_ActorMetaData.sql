CREATE PROCEDURE [dbo].[ssp_ActorMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ActorSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ActorSysId],
[KeyPath],
[KeyValue],
[Active]
FROM ActorMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ActorSysId IS NULL OR ActorSysId = @ActorSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



