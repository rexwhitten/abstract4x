CREATE PROCEDURE [dbo].[ssp_CharacterQubits]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CharacterSysId [int] = NULL,
	@QubitsysId [int] = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[Path],
[CharacterSysId],
[QubitsysId],
[CreateDate],
[Active]
FROM CharacterQubits
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@Path IS NULL OR Path = @Path)
AND
(@CharacterSysId IS NULL OR CharacterSysId = @CharacterSysId)
AND
(@QubitsysId IS NULL OR QubitsysId = @QubitsysId)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



