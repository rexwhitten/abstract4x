CREATE PROCEDURE [dbo].[ssp_CharacterMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@CharacterSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[CharacterSysId],
[KeyPath],
[KeyValue],
[Active]
FROM CharacterMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@CharacterSysId IS NULL OR CharacterSysId = @CharacterSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



