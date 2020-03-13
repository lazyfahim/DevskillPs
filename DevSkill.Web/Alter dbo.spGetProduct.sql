USE [Devskill]
GO

/****** Object: SqlProcedure [dbo].[spGetProduct] Script Date: 3/13/2020 11:18:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spGetProduct]
	@pageIndex int = 0,
	@pageSize int = 10,
	@orderBy nvarchar(50) = NULL,
	@searchString nvarchar(50) = NULL
AS 
BEGIN
	declare @sql nvarchar(max),
	 @params nvarchar(max),
	@searchRegex nvarchar(50)
	set nocount on;
	set @searchRegex = '%'+@searchString+'%'

	set @sql = 'select * from product where name like @searchRegex or Description like @searchRegex order by @orderBy
	offset  @pageSize*(pageIndex-1)  rows fetch next @pageSize rows only';

	set @params = '@searchRegex nvarchar(max), @orderBy nvarchar(50) ,@pageIndex int, @pageSize int';

	exec sp_executesql @sql,@params,@searchRegex,@orderBy,@pageIndex,@pageSize;

END
