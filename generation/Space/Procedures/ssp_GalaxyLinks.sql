CREATE PROCEDURE [dbo].[ssp_GalaxyLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentGalaxySysId [int] = NULL,
	@ChildGalaxySysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentGalaxySysId],
[ChildGalaxySysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM GalaxyLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentGalaxySysId IS NULL OR ParentGalaxySysId = @ParentGalaxySysId)
AND
(@ChildGalaxySysId IS NULL OR ChildGalaxySysId = @ChildGalaxySysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



