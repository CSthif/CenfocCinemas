/****** Object:  Table [dbo].[TBL_Movie]    Script Date: 16/6/2025 11:11:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TBL_Movie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Created] [datetime] NOT NULL,
	[Updated] [datetime] NULL,
	[Title] [nchar](75) NOT NULL,
	[Description] [nchar](250) NOT NULL,
	[ReleaseDate] [datetime] NOT NULL,
	[Genre] [nchar](20) NOT NULL,
	[Director] [nchar](30) NULL,
 CONSTRAINT [PK_TBL_Movie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
