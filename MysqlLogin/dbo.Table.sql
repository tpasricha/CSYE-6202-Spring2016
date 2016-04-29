USE [data]
GO
/****** Object:  Table [dbo].[Accounting]    Script Date: 4/29/2016 2:42:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounting](
	[username] [nvarchar](50) NOT NULL,
	[bankName] [nvarchar](50) NOT NULL,
	[cardNumber] [nvarchar](30) NOT NULL,
	[cvvNumber] [nvarchar](3) NOT NULL,
	[expiryDate] [date] NOT NULL,
	[transactionId] [int] NOT NULL,
	[FlightNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Booking]    Script Date: 4/29/2016 2:42:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[Flight Number] [nvarchar](20) NOT NULL,
	[Source] [nvarchar](30) NULL,
	[Destination] [nvarchar](30) NULL,
	[DepartureDate] [nvarchar](50) NULL,
	[DepartureTime] [nvarchar](30) NULL,
	[ArrivalDate] [nvarchar](50) NULL,
	[ArrivalTime] [nvarchar](30) NULL,
	[Fare] [decimal](18, 0) NULL,
	[NumberSeats] [int] NULL,
	[Airline] [nvarchar](30) NOT NULL,
	[Currency] [nvarchar](10) NULL,
	[seatType] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Flight Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Crew]    Script Date: 4/29/2016 2:42:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Crew](
	[flightNumber] [varchar](10) NULL,
	[crewId] [int] NOT NULL,
	[crewMembers] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[crewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Flight]    Script Date: 4/29/2016 2:42:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Flight](
	[FlightNumber] [varchar](15) NOT NULL,
	[Source] [varchar](20) NOT NULL,
	[Destination] [varchar](20) NOT NULL,
	[DepartureDate] [varchar](50) NULL,
	[DepartureTime] [varchar](20) NULL,
	[ArrivalDate] [varchar](50) NULL,
	[ArrivalTime] [varchar](20) NULL,
	[Fare] [varchar](10) NULL,
	[Currency] [varchar](20) NULL,
	[Seats] [int] NOT NULL,
	[Airline] [nchar](30) NULL,
	[Crew] [int] NULL,
	[SeatType] [nvarchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PassengerLogin]    Script Date: 4/29/2016 2:42:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassengerLogin](
	[name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](10) NOT NULL,
	[emailId] [nvarchar](50) NOT NULL,
	[age] [int] NOT NULL,
	[phoneNumber] [nvarchar](10) NULL,
	[userName] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[confirmPassword] [nvarchar](50) NOT NULL,
	[checkType] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
