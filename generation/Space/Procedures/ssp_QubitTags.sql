CREATE PROCEDURE [dbo].[ssp_QubitTags]
	@SysId [int] = NULL,
	@QubitSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[QubitSysId],
[Tag],
[CreateDate],
[Active]
FROM QubitTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@QubitSysId IS NULL OR QubitSysId = @QubitSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



