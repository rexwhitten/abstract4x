CREATE PROCEDURE [dbo].[ssp_TechTreeLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentTechTreeSysId [int] = NULL,
	@ChildTechTreeSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentTechTreeSysId],
[ChildTechTreeSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM TechTreeLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentTechTreeSysId IS NULL OR ParentTechTreeSysId = @ParentTechTreeSysId)
AND
(@ChildTechTreeSysId IS NULL OR ChildTechTreeSysId = @ChildTechTreeSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



