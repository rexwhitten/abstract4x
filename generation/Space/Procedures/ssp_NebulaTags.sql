CREATE PROCEDURE [dbo].[ssp_NebulaTags]
	@SysId [int] = NULL,
	@NebulaSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[NebulaSysId],
[Tag],
[CreateDate],
[Active]
FROM NebulaTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@NebulaSysId IS NULL OR NebulaSysId = @NebulaSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



