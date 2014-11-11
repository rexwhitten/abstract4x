CREATE PROCEDURE [dbo].[ssp_MoonMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@MoonSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[MoonSysId],
[KeyPath],
[KeyValue],
[Active]
FROM MoonMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@MoonSysId IS NULL OR MoonSysId = @MoonSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



