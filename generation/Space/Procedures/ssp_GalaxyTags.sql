CREATE PROCEDURE [dbo].[ssp_GalaxyTags]
	@SysId [int] = NULL,
	@GalaxySysId [int] = NULL,
	@Tag [varchar](50) = NULL,
	@CreateDate [datetime] = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[GalaxySysId],
[Tag],
[CreateDate],
[Active]
FROM GalaxyTags
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@GalaxySysId IS NULL OR GalaxySysId = @GalaxySysId)
AND
(@Tag IS NULL OR Tag = @Tag)
AND
(@CreateDate IS NULL OR CreateDate = @CreateDate)
AND
(@Active IS NULL OR Active = @Active)



