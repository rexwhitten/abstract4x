CREATE PROCEDURE [dbo].[ssp_CharacterAttributes]
	@SysId [int] = NULL,
	@CharacterSysId [int] = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Score [int] = NULL,
	@Level [int] = NULL
AS
SELECT 
[SysId],
[CharacterSysId],
[CreateDate],
[LastModifiedDate],
[Score],
[Level]
FROM CharacterAttributes
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@CharacterSysId IS NULL OR CharacterSysId = @CharacterSysId)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Score IS NULL OR Score = @Score)
AND
(@Level IS NULL OR Level = @Level)



