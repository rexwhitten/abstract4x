CREATE PROCEDURE [dbo].[ssp_CharacterLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentCharacterSysId [int] = NULL,
	@ChildCharacterSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentCharacterSysId],
[ChildCharacterSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM CharacterLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentCharacterSysId IS NULL OR ParentCharacterSysId = @ParentCharacterSysId)
AND
(@ChildCharacterSysId IS NULL OR ChildCharacterSysId = @ChildCharacterSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



