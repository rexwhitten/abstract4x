CREATE PROCEDURE [dbo].[ssp_QubitLinks]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@ParentQubitSysId [int] = NULL,
	@ChildQubitSysId [int] = NULL,
	@LinkPath [varchar](512) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[ParentQubitSysId],
[ChildQubitSysId],
[LinkPath],
[CreateDate],
[LastModifiedDate],
[Active]
FROM QubitLinks
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@ParentQubitSysId IS NULL OR ParentQubitSysId = @ParentQubitSysId)
AND
(@ChildQubitSysId IS NULL OR ChildQubitSysId = @ChildQubitSysId)
AND
(@LinkPath IS NULL OR LinkPath = @LinkPath)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Active IS NULL OR Active = @Active)



