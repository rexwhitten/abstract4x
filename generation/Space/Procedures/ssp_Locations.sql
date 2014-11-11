CREATE PROCEDURE [dbo].[ssp_Locations]
	@SysId [int] = NULL,
	@LocationStatusSysId [int] = NULL,
	@LocationTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[LocationStatusSysId],
[LocationTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Locations
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@LocationStatusSysId IS NULL OR LocationStatusSysId = @LocationStatusSysId)
AND
(@LocationTypeSysId IS NULL OR LocationTypeSysId = @LocationTypeSysId)
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



