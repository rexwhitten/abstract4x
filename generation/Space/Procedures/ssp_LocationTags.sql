CREATE PROCEDURE [dbo].[ssp_LocationTags]
	@SysId [int] = NULL,
	@LocationSysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[LocationSysId],
[Tag],
[CreateDate],
[Active]
FROM LocationTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@LocationSysId IS NULL OR LocationSysId = @LocationSysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



