USE [VehicleDB]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 05/01/2021 7:07:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
	[Organization] [nvarchar](max) NULL,
	[Emailaddress] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[Photopath] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


