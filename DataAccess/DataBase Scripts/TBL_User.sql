/****** Object:  Table [dbo].[TBL_User]    Script Date: 16/6/2025 11:13:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TBL_User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Updated] [datetime] NULL,
	[UserCode] [nchar](30) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Email] [nchar](30) NOT NULL,
	[Password] [nchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Status] [nchar](10) NOT NULL,
 CONSTRAINT [PK_TBL_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
