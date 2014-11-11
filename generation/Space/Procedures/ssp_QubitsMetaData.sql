CREATE PROCEDURE [dbo].[ssp_QubitsMetaData]
	@SysId [int] = NULL,
	@PublicId [uniqueidentifier] = NULL,
	@QubitsSysId [int] = NULL,
	@KeyPath [varchar](256) = NULL,
	@KeyValue [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[SysId],
[PublicId],
[QubitsSysId],
[KeyPath],
[KeyValue],
[Active]
FROM QubitsMetaData
WHERE 
(@SysId IS NULL OR SysId =@SysId)
AND
(@PublicId IS NULL OR PublicId = @PublicId)
AND
(@QubitsSysId IS NULL OR QubitsSysId = @QubitsSysId)
AND
(@KeyPath IS NULL OR KeyPath = @KeyPath)
AND
(@KeyValue IS NULL OR KeyValue = @KeyValue)
AND
(@Active IS NULL OR Active = @Active)



