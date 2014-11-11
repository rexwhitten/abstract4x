CREATE PROCEDURE [dbo].[ssp_ActorLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentActorSysId [int] = NULL,
	@ChildActorSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentActorSysId],
[ChildActorSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM ActorLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentActorSysId IS NULL OR ParentActorSysId = @ParentActorSysId)
AND
(@ChildActorSysId IS NULL OR ChildActorSysId = @ChildActorSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



