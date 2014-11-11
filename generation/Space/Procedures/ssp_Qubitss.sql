CREATE PROCEDURE [dbo].[ssp_Qubitss]
	@SysId [int] = NULL,
	@QubitsStatusSysId [int] = NULL,
	@QubitsTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[QubitsStatusSysId],
[QubitsTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Qubitss
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@QubitsStatusSysId IS NULL OR QubitsStatusSysId = @QubitsStatusSysId)
AND
(@QubitsTypeSysId IS NULL OR QubitsTypeSysId = @QubitsTypeSysId)
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



