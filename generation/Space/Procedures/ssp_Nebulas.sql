CREATE PROCEDURE [dbo].[ssp_Nebulas]
	@SysId [int] = NULL,
	@NebulaStatusSysId [int] = NULL,
	@NebulaTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[NebulaStatusSysId],
[NebulaTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Nebulas
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@NebulaStatusSysId IS NULL OR NebulaStatusSysId = @NebulaStatusSysId)
AND
(@NebulaTypeSysId IS NULL OR NebulaTypeSysId = @NebulaTypeSysId)
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



