CREATE PROCEDURE [dbo].[ssp_Moons]
	@SysId [int] = NULL,
	@MoonStatusSysId [int] = NULL,
	@MoonTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[MoonStatusSysId],
[MoonTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Moons
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@MoonStatusSysId IS NULL OR MoonStatusSysId = @MoonStatusSysId)
AND
(@MoonTypeSysId IS NULL OR MoonTypeSysId = @MoonTypeSysId)
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



