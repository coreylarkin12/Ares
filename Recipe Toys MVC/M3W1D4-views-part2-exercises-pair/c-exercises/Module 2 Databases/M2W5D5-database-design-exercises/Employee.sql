USE [Employee]
GO

ALTER TABLE [dbo].[employee] DROP CONSTRAINT [FK_Table_1_Table_2]
GO

/****** Object:  Table [dbo].[employee]    Script Date: 6/12/2017 12:24:11 AM ******/
DROP TABLE [dbo].[employee]
GO

/****** Object:  Table [dbo].[employee]    Script Date: 6/12/2017 12:24:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[employee](
	[employeeNumber] [int] NOT NULL,
	[jobTitle] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[gender] [nchar](10) NOT NULL,
	[birthday] [int] NOT NULL,
	[hireDate] [int] NOT NULL,
	[departmentNumber] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[employeeNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [FK_Table_1_Table_2] FOREIGN KEY([departmentNumber])
REFERENCES [dbo].[department] ([departmentNumber])
GO

ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [FK_Table_1_Table_2]
GO


