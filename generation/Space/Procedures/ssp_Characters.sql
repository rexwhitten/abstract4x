CREATE PROCEDURE [dbo].[ssp_Characters]
	@SysId [int] = NULL,
	@CharacterStatusSysId [int] = NULL,
	@CharacterTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[CharacterStatusSysId],
[CharacterTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Characters
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@CharacterStatusSysId IS NULL OR CharacterStatusSysId = @CharacterStatusSysId)
AND
(@CharacterTypeSysId IS NULL OR CharacterTypeSysId = @CharacterTypeSysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@Path IS NULL OR Path = @Path)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Is_ReadOnly IS NULL OR Is_ReadOnly = @Is_ReadOnly)
AND
(@Active IS NULL OR Active = @Active)



