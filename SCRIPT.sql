USE [TPEquiposJugadores]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 13/12/2023 08:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[idEquipo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NOT NULL,
	[Imagen] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[idEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 13/12/2023 08:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[idJugador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NOT NULL,
	[Apellido] [varchar](max) NOT NULL,
	[NumeroCamiseta] [int] NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Imagen] [varchar](max) NOT NULL,
	[idEquipo] [int] NOT NULL,
 CONSTRAINT [PK_Jugadores] PRIMARY KEY CLUSTERED 
(
	[idJugador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Equipos] ON 

INSERT [dbo].[Equipos] ([idEquipo], [Nombre], [Imagen]) VALUES (1, N'Al Nassr', N'https://logodownload.org/wp-content/uploads/2023/07/al-nassr-fc-logo-0.png')
INSERT [dbo].[Equipos] ([idEquipo], [Nombre], [Imagen]) VALUES (2, N'Inter de Miami', N'https://1000marcas.net/wp-content/uploads/2021/05/Inter-Miami-logo.png')
INSERT [dbo].[Equipos] ([idEquipo], [Nombre], [Imagen]) VALUES (3, N'Juventus de Turín', N'data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/...')
SET IDENTITY_INSERT [dbo].[Equipos] OFF
GO
SET IDENTITY_INSERT [dbo].[Jugadores] ON 

INSERT [dbo].[Jugadores] ([idJugador], [Nombre], [Apellido], [NumeroCamiseta], [FechaNacimiento], [Imagen], [idEquipo]) VALUES (1, N'Lionel', N'Messi', 10, CAST(N'1987-06-24' AS Date), N'https://image.ondacero.es/...', 2)
INSERT [dbo].[Jugadores] ([idJugador], [Nombre], [Apellido], [NumeroCamiseta], [FechaNacimiento], [Imagen], [idEquipo]) VALUES (2, N'Paul', N'Pogba', 6, CAST(N'1993-03-15' AS Date), N'https://www.juventus.com/...', 3)
INSERT [dbo].[Jugadores] ([idJugador], [Nombre], [Apellido], [NumeroCamiseta], [FechaNacimiento], [Imagen], [idEquipo]) VALUES (3, N'Cristiano', N'Ronaldo', 7, CAST(N'1985-02-05' AS Date), N'https://www.directvsports.com/...', 1)
SET IDENTITY_INSERT [dbo].[Jugadores] OFF
GO
