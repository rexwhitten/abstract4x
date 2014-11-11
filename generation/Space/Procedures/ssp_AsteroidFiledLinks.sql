CREATE PROCEDURE [dbo].[ssp_AsteroidFiledLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentAsteroidFiledSysId [int] = NULL,
	@ChildAsteroidFiledSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentAsteroidFiledSysId],
[ChildAsteroidFiledSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM AsteroidFiledLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentAsteroidFiledSysId IS NULL OR ParentAsteroidFiledSysId = @ParentAsteroidFiledSysId)
AND
(@ChildAsteroidFiledSysId IS NULL OR ChildAsteroidFiledSysId = @ChildAsteroidFiledSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



