CREATE PROCEDURE [dbo].[ssp_NebulaLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentNebulaSysId [int] = NULL,
	@ChildNebulaSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentNebulaSysId],
[ChildNebulaSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM NebulaLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentNebulaSysId IS NULL OR ParentNebulaSysId = @ParentNebulaSysId)
AND
(@ChildNebulaSysId IS NULL OR ChildNebulaSysId = @ChildNebulaSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



