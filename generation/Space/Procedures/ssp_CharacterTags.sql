CREATE PROCEDURE [dbo].[ssp_CharacterTags]
	@SysId [int] = NULL,
	@CharacterSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[CharacterSysId],
[Tag],
[CreateDate],
[Active]
FROM CharacterTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@CharacterSysId IS NULL OR CharacterSysId = @CharacterSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



