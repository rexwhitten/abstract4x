CREATE PROCEDURE [dbo].[ssp_TechTrees]
	@SysId [int] = NULL,
	@TechTreeStatusSysId [int] = NULL,
	@TechTreeTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[TechTreeStatusSysId],
[TechTreeTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM TechTrees
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@TechTreeStatusSysId IS NULL OR TechTreeStatusSysId = @TechTreeStatusSysId)
AND
(@TechTreeTypeSysId IS NULL OR TechTreeTypeSysId = @TechTreeTypeSysId)
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



