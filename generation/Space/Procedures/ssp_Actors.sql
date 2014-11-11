CREATE PROCEDURE [dbo].[ssp_Actors]
	@SysId [int] = NULL,
	@ActorStatusSysId [int] = NULL,
	@ActorTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[ActorStatusSysId],
[ActorTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Actors
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@ActorStatusSysId IS NULL OR ActorStatusSysId = @ActorStatusSysId)
AND
(@ActorTypeSysId IS NULL OR ActorTypeSysId = @ActorTypeSysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@Path IS NULL OR Path = @Path)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Is_ReadOnly IS NULL OR Is_ReadOnly = @Is_ReadOnly)
AND
(@Active IS NULL OR Active = @Active)



