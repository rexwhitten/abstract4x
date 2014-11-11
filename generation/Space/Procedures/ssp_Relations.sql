CREATE PROCEDURE [meta].[ssp_Relations]
	@Id [int] = NULL,
	@Parent [varchar](50) = NULL,
	@Child [varchar](50) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[Id],
[Parent],
[Child],
[Active]
FROM Relations
WHERE 
(@Id IS NULL OR Id =@Id)
AND
(@Parent IS NULL OR Parent = @Parent)
AND
(@Child IS NULL OR Child = @Child)
AND
(@Active IS NULL OR Active = @Active)



