CREATE PROCEDURE [meta].[ssp_Attributes]
	@Id [int] = NULL,
	@ObjectTitle [varchar](50) = NULL,
	@Name [varchar](50) = NULL,
	@DataType [varchar](50) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[Id],
[ObjectTitle],
[Name],
[DataType],
[Active]
FROM Attributes
WHERE 
(@Id IS NULL OR Id =@Id)
AND
(@ObjectTitle IS NULL OR ObjectTitle = @ObjectTitle)
AND
(@Name IS NULL OR Name = @Name)
AND
(@DataType IS NULL OR DataType = @DataType)
AND
(@Active IS NULL OR Active = @Active)



