USE [Employee]
GO

/****** Object:  Table [dbo].[department]    Script Date: 6/12/2017 12:23:16 AM ******/
DROP TABLE [dbo].[department]
GO

/****** Object:  Table [dbo].[department]    Script Date: 6/12/2017 12:23:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[department](
	[departmentNumber] [int] NOT NULL,
	[deptName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Table_2] PRIMARY KEY CLUSTERED 
(
	[departmentNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


