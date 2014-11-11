CREATE PROCEDURE [dbo].[ssp_StarLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentStarSysId [int] = NULL,
	@ChildStarSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentStarSysId],
[ChildStarSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM StarLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentStarSysId IS NULL OR ParentStarSysId = @ParentStarSysId)
AND
(@ChildStarSysId IS NULL OR ChildStarSysId = @ChildStarSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



