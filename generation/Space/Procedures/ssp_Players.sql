CREATE PROCEDURE [dbo].[ssp_Players]
	@SysId [int] = NULL,
	@PlayerStatusSysId [int] = NULL,
	@PlayerTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PlayerStatusSysId],
[PlayerTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Players
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PlayerStatusSysId IS NULL OR PlayerStatusSysId = @PlayerStatusSysId)
AND
(@PlayerTypeSysId IS NULL OR PlayerTypeSysId = @PlayerTypeSysId)
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



