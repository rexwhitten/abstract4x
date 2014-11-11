CREATE PROCEDURE [dbo].[ssp_QubitAttributes]
	@SysId [int] = NULL,
	@QubitSysId [int] = NULL,
	@CreateDate [datetime] = NULL,
	@LastModifiedDate [datetime] = NULL,
	@Amount [int] = NULL
AS
SELECT 
[SysId],
[QubitSysId],
[CreateDate],
[LastModifiedDate],
[Amount]
FROM QubitAttributes
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@QubitSysId IS NULL OR QubitSysId = @QubitSysId)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@LastModifiedDate IS NULL OR LastModifiedDate = @LastModifiedDate)
AND
(@Amount IS NULL OR Amount = @Amount)



