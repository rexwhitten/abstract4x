CREATE PROCEDURE [dbo].[ssp_QubitsTags]
	@SysId [int] = NULL,
	@QubitsSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[QubitsSysId],
[Tag],
[CreateDate],
[Active]
FROM QubitsTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@QubitsSysId IS NULL OR QubitsSysId = @QubitsSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



