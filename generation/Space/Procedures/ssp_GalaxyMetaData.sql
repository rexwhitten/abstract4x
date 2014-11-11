CREATE PROCEDURE [dbo].[ssp_GalaxyMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@GalaxySysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[GalaxySysId],
[KeyPath],
[KeyValue],
[Active]
FROM GalaxyMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@GalaxySysId IS NULL OR GalaxySysId = @GalaxySysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



