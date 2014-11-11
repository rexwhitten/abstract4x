CREATE PROCEDURE [dbo].[ssp_QubitsLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentQubitsSysId [int] = NULL,
	@ChildQubitsSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentQubitsSysId],
[ChildQubitsSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM QubitsLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentQubitsSysId IS NULL OR ParentQubitsSysId = @ParentQubitsSysId)
AND
(@ChildQubitsSysId IS NULL OR ChildQubitsSysId = @ChildQubitsSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



