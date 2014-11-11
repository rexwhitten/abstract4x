CREATE PROCEDURE [dbo].[ssp_LocationLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentLocationSysId [int] = NULL,
	@ChildLocationSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentLocationSysId],
[ChildLocationSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM LocationLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentLocationSysId IS NULL OR ParentLocationSysId = @ParentLocationSysId)
AND
(@ChildLocationSysId IS NULL OR ChildLocationSysId = @ChildLocationSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



