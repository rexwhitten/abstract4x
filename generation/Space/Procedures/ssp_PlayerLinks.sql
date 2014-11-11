CREATE PROCEDURE [dbo].[ssp_PlayerLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentPlayerSysId [int] = NULL,
	@ChildPlayerSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentPlayerSysId],
[ChildPlayerSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM PlayerLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentPlayerSysId IS NULL OR ParentPlayerSysId = @ParentPlayerSysId)
AND
(@ChildPlayerSysId IS NULL OR ChildPlayerSysId = @ChildPlayerSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



