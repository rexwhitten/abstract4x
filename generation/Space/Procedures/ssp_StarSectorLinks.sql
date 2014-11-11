CREATE PROCEDURE [dbo].[ssp_StarSectorLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentStarSectorSysId [int] = NULL,
	@ChildStarSectorSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentStarSectorSysId],
[ChildStarSectorSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM StarSectorLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentStarSectorSysId IS NULL OR ParentStarSectorSysId = @ParentStarSectorSysId)
AND
(@ChildStarSectorSysId IS NULL OR ChildStarSectorSysId = @ChildStarSectorSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



