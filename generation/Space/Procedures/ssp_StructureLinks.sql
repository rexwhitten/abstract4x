CREATE PROCEDURE [dbo].[ssp_StructureLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentStructureSysId [int] = NULL,
	@ChildStructureSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentStructureSysId],
[ChildStructureSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM StructureLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentStructureSysId IS NULL OR ParentStructureSysId = @ParentStructureSysId)
AND
(@ChildStructureSysId IS NULL OR ChildStructureSysId = @ChildStructureSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



