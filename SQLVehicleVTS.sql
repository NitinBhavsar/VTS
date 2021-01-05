USE [VehicleDB]
GO

/****** Object:  Table [dbo].[Vehicles]    Script Date: 05/01/2021 7:08:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vehicles](
	[VehicleID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleNumber] [nvarchar](max) NULL,
	[VehicleType] [nvarchar](max) NULL,
	[ChassisNumber] [nvarchar](max) NULL,
	[EngineNumber] [nvarchar](max) NULL,
	[Manufacturingyear] [nvarchar](max) NULL,
	[Loadcarryingcapacity] [nvarchar](max) NULL,
	[Makeofvehicle] [nvarchar](max) NULL,
	[ModelNumber] [nvarchar](max) NULL,
	[Bodytype] [nvarchar](max) NULL,
	[Organisationname] [nvarchar](max) NULL,
	[DeviceID] [nvarchar](max) NULL,
	[UserID] [nvarchar](max) NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


