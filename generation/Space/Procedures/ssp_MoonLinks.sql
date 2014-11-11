CREATE PROCEDURE [dbo].[ssp_MoonLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentMoonSysId [int] = NULL,
	@ChildMoonSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentMoonSysId],
[ChildMoonSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM MoonLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentMoonSysId IS NULL OR ParentMoonSysId = @ParentMoonSysId)
AND
(@ChildMoonSysId IS NULL OR ChildMoonSysId = @ChildMoonSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



