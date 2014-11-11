-- =============================================================================
-- Name:		cp_Players
-- Created By:	MGenerator.Tools.SqlGeneration.CrudProcedureGenerator (Generated)
-- Created On:	10/26/2014 5:37:11 PM
-- Description:	Provides CRUD access to [Space].[dbo].[Players]
--
--				This procedure was generated by a tool.
--
--				Changes to this file may cause incorrect behavior and will be 
--				lost if the procedure is regenerated.
-- =============================================================================
ALTER PROCEDURE [dbo].[cp_Players]
	 @Operation         	[INT]                	= 0
	,@Active            	[BIT]                	= NULL
	,@CreateDate        	[DATETIME]           	= NULL
	,@Is_ReadOnly       	[BIT]                	= NULL
	,@LastModifiedDate  	[DATETIME]           	= NULL
	,@Path              	[VARCHAR]( 1024 )    	= NULL
	,@PlayerStatusSysId 	[INT]                	= NULL
	,@PlayerTypeSysId   	[INT]                	= NULL
	,@PublicId          	[UNIQUEIDENTIFIER]   	= NULL
	,@SysId             	[INT]                	= NULL
	,@User              	[NVARCHAR]( 128 )    	= NULL
AS

 BEGIN TRY 
    
	IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Log_ProcedureCall]') AND type in (N'P', N'PC')) 
	BEGIN      
			DECLARE @ProcName VARCHAR(100)
			DECLARE @DBName2 VARCHAR(100) 
				SET @ProcName = OBJECT_NAME(@@PROCID)
				SET @DBName2 = DB_NAME() 
			EXECUTE [dbo].[Log_ProcedureCall] @ProcName,@DBName2
	END 
 
	IF( @User = NULL )
		BEGIN
			SELECT	@User = SYSTEM_USER
		END

	-- -------------------------------------------------------------------------
	-- SELECT ONE BY PRIMARY KEY
	-- -------------------------------------------------------------------------
	IF( @Operation = 1 )
		BEGIN
			SELECT	 [Active]
					,[CreateDate]
					,[Is_ReadOnly]
					,[LastModifiedDate]
					,[Path]
					,[PlayerStatusSysId]
					,[PlayerTypeSysId]
					,[PublicId]
					,[SysId]
			FROM	[Space].[dbo].[Players]
			WHERE	[SysId] = @SysId
		END
		
	-- -------------------------------------------------------------------------
	-- SELECT ALL
	-- -------------------------------------------------------------------------
	IF( @Operation = 2 )
		BEGIN
			SELECT	 [Active]
					,[CreateDate]
					,[Is_ReadOnly]
					,[LastModifiedDate]
					,[Path]
					,[PlayerStatusSysId]
					,[PlayerTypeSysId]
					,[PublicId]
					,[SysId]
			FROM	[Space].[dbo].[Players]
		END

	-- -------------------------------------------------------------------------
	-- SELECT ALL PRIMARY KEYS (ID ENUMERATOR)
	-- -------------------------------------------------------------------------
	IF( @Operation = 3 )
		BEGIN
			SELECT	 [SysId]
			FROM	[Space].[dbo].[Players]
		END

	-- -------------------------------------------------------------------------
	-- UPDATE
	-- -------------------------------------------------------------------------
	IF( @Operation = 4 )
		BEGIN
			UPDATE	[Space].[dbo].[Players]
			SET		 [Active]            	= @Active
					,[CreateDate]        	= @CreateDate
					,[Is_ReadOnly]       	= @Is_ReadOnly
					,[LastModifiedDate]  	= @LastModifiedDate
					,[Path]              	= @Path
					,[PlayerStatusSysId] 	= @PlayerStatusSysId
					,[PlayerTypeSysId]   	= @PlayerTypeSysId
					,[PublicId]          	= @PublicId
			WHERE	[SysId] = @SysId
		END

	-- -------------------------------------------------------------------------
	-- INSERT
	-- -------------------------------------------------------------------------
	IF( @Operation = 5 )
		BEGIN
			INSERT INTO
					[Space].[dbo].[Players] (
						 [Active]
						,[CreateDate]
						,[Is_ReadOnly]
						,[LastModifiedDate]
						,[Path]
						,[PlayerStatusSysId]
						,[PlayerTypeSysId]
						,[PublicId]
					)
			VALUES	(
						 @Active
						,@CreateDate
						,@Is_ReadOnly
						,@LastModifiedDate
						,@Path
						,@PlayerStatusSysId
						,@PlayerTypeSysId
						,@PublicId
					)
			
			SELECT	SCOPE_IDENTITY( )
		END

	-- -------------------------------------------------------------------------
	-- DELETE
	-- -------------------------------------------------------------------------
	IF( @Operation = 6 )
		BEGIN
			DELETE FROM
					[Space].[dbo].[Players]
			WHERE	[SysId] = @SysId
		END
	END TRY 

	BEGIN CATCH 
		DECLARE @ERROR_NUMBER		INT
		DECLARE @ERROR_SEVERITY		INT
		DECLARE @ERROR_STATE		INT
		DECLARE @ERROR_PROCEDURE	VARCHAR(100)
		DECLARE @ERROR_LINE			INT
		DECLARE @ERROR_MESSAGE		VARCHAR(MAX) 
		
		
	SELECT
        @ERROR_NUMBER		= ERROR_NUMBER(),
        @ERROR_SEVERITY		= ERROR_SEVERITY(),
        @ERROR_STATE		= ERROR_STATE(),
        @ERROR_PROCEDURE	= ERROR_PROCEDURE(),
        @ERROR_LINE			= ERROR_LINE(),
        @ERROR_MESSAGE		= ERROR_MESSAGE()
        
		INSERT INTO [dbo].[SqlErrors]
           ([ErrorTime]
           ,[ERROR_NUMBER]
           ,[ERROR_SEVERITY]
           ,[ERROR_PROCEDURE]
           ,[ERROR_LINE]
           ,[ERROR_STATE]
           ,[ERROR_MESSAGE])
		VALUES
           (GETDATE()
           ,@ERROR_NUMBER
           ,@ERROR_SEVERITY	
           ,@ERROR_PROCEDURE
           ,@ERROR_LINE	
           ,@ERROR_STATE
           ,@ERROR_MESSAGE)
	END CATCH 
GO
