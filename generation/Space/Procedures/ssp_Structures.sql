CREATE PROCEDURE [dbo].[ssp_Structures]
	@SysId [int] = NULL,
	@StructureStatusSysId [int] = NULL,
	@StructureTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[StructureStatusSysId],
[StructureTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Structures
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@StructureStatusSysId IS NULL OR StructureStatusSysId = @StructureStatusSysId)
AND
(@StructureTypeSysId IS NULL OR StructureTypeSysId = @StructureTypeSysId)
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



