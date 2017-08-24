USE [Employee]
GO

ALTER TABLE [dbo].[project] DROP CONSTRAINT [FK_project_Table_1]
GO

/****** Object:  Table [dbo].[project]    Script Date: 6/12/2017 12:24:35 AM ******/
DROP TABLE [dbo].[project]
GO

/****** Object:  Table [dbo].[project]    Script Date: 6/12/2017 12:24:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[project](
	[projectNumber] [int] NOT NULL,
	[projName] [varchar](50) NOT NULL,
	[employeeNumber] [int] NULL,
 CONSTRAINT [PK_project] PRIMARY KEY CLUSTERED 
(
	[projectNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[project]  WITH CHECK ADD  CONSTRAINT [FK_project_Table_1] FOREIGN KEY([employeeNumber])
REFERENCES [dbo].[employee] ([employeeNumber])
GO

ALTER TABLE [dbo].[project] CHECK CONSTRAINT [FK_project_Table_1]
GO


