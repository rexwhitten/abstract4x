CREATE PROCEDURE [dbo].[ssp_Qubits]
	@SysId [int] = NULL,
	@QubitStatusSysId [int] = NULL,
	@QubitTypeSysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@Path [varchar](1024) = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Is_ReadOnly [bit] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[QubitStatusSysId],
[QubitTypeSysId],
[PublicId],
[Path],
[CreateDate],
[LastModifiedDate],
[Is_ReadOnly],
[Active]
FROM Qubits
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@QubitStatusSysId IS NULL OR QubitStatusSysId = @QubitStatusSysId)
AND
(@QubitTypeSysId IS NULL OR QubitTypeSysId = @QubitTypeSysId)
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



