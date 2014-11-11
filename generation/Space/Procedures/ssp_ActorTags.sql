CREATE PROCEDURE [dbo].[ssp_ActorTags]
	@SysId [int] = NULL,
	@ActorSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[ActorSysId],
[Tag],
[CreateDate],
[Active]
FROM ActorTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@ActorSysId IS NULL OR ActorSysId = @ActorSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



