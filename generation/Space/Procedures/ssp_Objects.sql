CREATE PROCEDURE [meta].[ssp_Objects]
	@Id [int] = NULL,
	@Title [varchar](150) = NULL,
	@Path [varchar](512) = NULL,
	@Active [bit] = NULL
AS
SELECT 
[Id],
[Title],
[Path],
[Active]
FROM Objects
WHERE 
(@Id IS NULL OR Id =@Id)
AND
(@Title IS NULL OR Title = @Title)
AND
(@Path IS NULL OR Path = @Path)
AND
(@Active IS NULL OR Active = @Active)



