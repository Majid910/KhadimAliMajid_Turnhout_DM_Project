

CREATE DATABASE [movieDB]
 CONTAINMENT = NO
 ON  PRIMARY 
( NAME = N'movieDB', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\movieDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'movieDB_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\movieDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [movieDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [movieDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [movieDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [movieDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [movieDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [movieDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [movieDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [movieDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [movieDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [movieDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [movieDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [movieDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [movieDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [movieDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [movieDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [movieDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [movieDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [movieDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [movieDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [movieDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [movieDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [movieDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [movieDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [movieDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [movieDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [movieDB] SET  MULTI_USER 
GO
ALTER DATABASE [movieDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [movieDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [movieDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [movieDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [movieDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [movieDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cast](
	[id] [int] NOT NULL,
	[character] [varchar](50) NOT NULL,
	[name] [varchar](30) NOT NULL,
	[profilePath] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cast] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[movie](
	[id] [int] NOT NULL,
	[title] [varchar](50) NOT NULL,
	[overview] [varchar](700) NOT NULL,
	[releaseDate] [datetime] NOT NULL,
	[voteAverage] [float] NOT NULL,
	[posterPath] [varchar](50) NOT NULL,
	[genre] [varchar](200) NOT NULL,
	[runtime] [int] NOT NULL,
 CONSTRAINT [PK_movie] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movieCast](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[movieId] [int] NOT NULL,
	[castId] [int] NOT NULL,
 CONSTRAINT [PK_movieCast] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (13, N'Marlin (voice)', N'Albert Brooks', N'/kahlMTdygrPJ28VYRhKPavYD9hs.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (14, N'Dory (voice)', N'Ellen DeGeneres', N'/4LG2bFkqOzxzR1kpnoDcwIVuQTG.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (19, N'Dr. Golan', N'Allison Janney', N'/fido6hwI8tFSZNt6HtP2DZH2eu6.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (34, N'Joe Dixon', N'Mykelti Williamson', N'/8TTxzpuvvpw2tB8xZBCDslYupNU.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (207, N'Ewen MacAskill', N'Tom Wilkinson', N'/4mxZKgdem0sQ8hJd0Y7TREwq7TJ.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (500, N'Jack Reacher', N'Tom Cruise', N'/3oWEuo0e8Nx8JvkqYCDec2iMY6K.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (569, N'Goodnight Robicheaux', N'Ethan Hawke', N'/kcby6VYk6Gb0036nUyh8chY5ZAJ.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (880, N'Chris', N'Ben Affleck', N'/yXtyygmSGtrwTfEmr6g2WgHFJIZ.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (934, N'Jackson Healy', N'Russell Crowe', N'/ktuOAyUHM2u2YPPChH8gAArxJ7b.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (976, N'Arthur Bishop', N'Jason Statham', N'/PhWiWgasncGWD9LdbsGcmxkV4r.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1229, N'Marcus Hamilton', N'Jeff Bridges', N'/eronr4zagxsKCBkGsFBDBCOqyma.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1331, N'Tom Doss', N'Hugo Weaving', N'/ysED1kp94bpnweNVaDoVQQ6iy8X.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1372, N'Doctor ''Bones'' McCoy', N'Karl Urban', N'/tHYOUO33K7iaDw8nXyqRvDIkVuM.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1620, N'Mei', N'Michelle Yeoh', N'/OhW6BfeZBRn7iupeI8elngV2EN.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1892, N'Jason Bourne', N'Matt Damon', N'/3XH8bkV1Oz24pOMcZbraEL5EtwM.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1925, N'Asset', N'Vincent Cassel', N'/yXeowAl5D40ChEzB91AJF5tC1w6.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (2176, N'Robert Dewey', N'Tommy Lee Jones', N'/gRXugLFvr1oHZ6alLUxmYDq8cgW.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (2178, N'Colonel Weber', N'Forest Whitaker', N'/4pMQkelS5lK661m9Kz3oIxLYiyS.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (2888, N'Floyd Lawton / Deadshot', N'Will Smith', N'/2iYXDlCvLyVO49louRyDDXagZ0G.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (3092, N'Jenny (voice)', N'Diane Keaton', N'/fzgUMnbOkxC6E3EFcYHWHFaiKyp.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (3967, N'Selene', N'Kate Beckinsale', N'/pTRtcZn9gWQZRiet36qWKh94urn.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (4175, N'Francis Silverberg', N'Jeffrey Tambor', N'/zavDMLHU3QpZOLlMlq1mobhzNG0.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (4391, N'Thomas', N'Charles Dance', N'/bLT03rnI29YmbYWjA1JJCl4xVXw.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (4757, N'Ornithologist', N'Rupert Everett', N'/pgwbXEVq1v6vVNwcjqbMnhIvA4k.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (5292, N'Sam Chisolm', N'Denzel Washington', N'/t9arcZbg1nLt8GZt2SkWm227YoK.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (5469, N'Moon King (voice)', N'Ralph Fiennes', N'/nt6wcXariJ2kQiMFocMUjvVP92A.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (6832, N'Laura Poitras', N'Melissa Leo', N'/pWP5xzOtoOcqJ0lZo2xguQ5BnrB.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (6885, N'Monkey (voice)', N'Charlize Theron', N'/fG0mtmBm3OsvKFucvoQyqBnVwya.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (7132, N'Jack Horne', N'Vincent D''Onofrio', N'/lUEn7f7xCLuT1kRCHoxMTRnYKXW.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (7499, N'The Joker', N'Jared Leto', N'/hNNKHKQYC0cJ2ji295yFp1c2MTt.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (8210, N'Jack', N'Wes Bentley', N'/fbHHalL9CS52zvJp015G31vwX23.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (8691, N'Lieutenant Uhura', N'Zoe Saldana', N'/ofNrWiA2KDdqiNxFTLp51HcXUlp.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (9273, N'Dr. Louise Banks', N'Amy Adams', N'/tk5eWJcOBr9uRefeUm9ntvehbLA.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (10297, N'Beetle (voice)', N'Matthew McConaughey', N'/jdRmHrG0TWXGhs4tO6TJNSoL25T.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (10361, N'Caleb Warrens', N'Raymond J. Barry', N'/k4WDNgYHOUgRaPQIsZUPUxl1lO6.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (10912, N'Miss Peregrine', N'Eva Green', N'/wqK0BhMuNBvDqIg1bwT9RhYMy6L.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (11107, N'Tanner Howard', N'Ben Foster', N'/kETVqU8PMDM44wM5mxPeegdGt2F.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (11108, N'Montgomery ''Scotty'' Scott', N'Simon Pegg', N'/23e2uoNlpDvLumNic16fS2YjZjL.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (12041, N'Nicky Parsons', N'Julia Stiles', N'/t6Huug0W671ZtP5PDcXzE7qca8K.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (15556, N'Mary', N'Rebecca Hall', N'/2UlQluPzoafQQ2HWqsxN2kfni6n.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (17306, N'Commander Spock', N'Zachary Quinto', N'/gSBxQWda0T67hrK3pNyqreRYoyw.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (17604, N'Ian Donnelly', N'Jeremy Renner', N'/g8gheNEdPSXWH5SnjfjTYWj5ziU.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (18918, N'Maui (voice)', N'Dwayne Johnson', N'/akweMz59qsSoPUJYe7QpjAc2rQp.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (18977, N'Hank (voice)', N'Ed O''Neill', N'/pIaygzkgrZ9FfJRxmtwPBMcWmIz.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (18997, N'Grace Meacham', N'Bryce Dallas Howard', N'/xLjvSRDOl6CiAhVCt2eKPA78dnC.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (18999, N'Ray King', N'J.K. Simmons', N'/jYYnhWbNoCSufoYkvs1GBZIyIX.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (19274, N'Frank / Sergeant Pepper (voice)', N'Seth Rogen', N'/aQc8O52P4vWDRfuxCLsz9rvnwf3.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (19278, N'Bloodbottler', N'Bill Hader', N'/3Z5JsyLw7YTLZgpA3FAlLmFSN9F.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (19492, N'Amanda Waller', N'Viola Davis', N'/fZDYv4yIUOvnELoKzXpIWx8YNlq.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (19498, N'Brax', N'Jon Bernthal', N'/w3epqN0BlV4TiUV9255d5tSCIRV.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (20374, N'Dorothy Schuttle', N'Teresa Palmer', N'/tuylHaajvnkJTPgyqbXGWuwAkbr.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (21007, N'Carl (voice)', N'Jonah Hill', N'/paKfXGK2gnYHWkqe1NiQR1pGac7.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (21088, N'Hei Hei the Rooster (voice)', N'Alan Tudyk', N'/6QuMtbD8kmhpwWhFKfNzEvHRLOu.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (21629, N'General Shang', N'Tzi Ma', N'/qhE0WSceO8bwZcZ7Ssi8qhQb7xD.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (24045, N'Edward Snowden', N'Joseph Gordon-Levitt', N'/zSuXCR6xCKIgo0gWLdp8moMlH3I.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (25002, N'Billy Rocks', N'Lee Byung-hun', N'/snuA1bKjeh4SKUmF0sNqip1zVpJ.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (25703, N'Chloe (voice)', N'Lake Bell', N'/zEHX5HhwQmYGO9Wvq3Cktwuv90G.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (30614, N'Holland March', N'Ryan Gosling', N'/5rOcicCrTCWye0O2S3dnbnWaCr1.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (31167, N'Charlene ''''Charlie'''' Roan', N'Elizabeth Mitchell', N'/k7Mtxruey23xxZDBWmB7apEHKDy.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (32747, N'Norman Nordstrom / The Blind Man', N'Stephen Lang', N'/tqF6ibURpLvRPlgvLRvjCQqWaa2.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (37625, N'Desmond T. Doss', N'Andrew Garfield', N'/lYzsWRuCdJqrOqWsc2ujzTKuVk5.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (37632, N'Newt Scamander', N'Eddie Redmayne', N'/1aPKU3S8TA9VSo3htB9Tq42ahtx.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (39995, N'Barry (voice)', N'Michael Cera', N'/kxeJQa9Ae7Ns1J1b5012SMeyXn2.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (40477, N'Franklin Portman', N'Chris O''Dowd', N'/hmTLgS5aT1t1sdg1GfdXM9yYUPI.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (40900, N'The BFG', N'Mark Rylance', N'/5XrQYvdYqiGUepbgmRQfOltgBRJ.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (41091, N'Brenda (voice)', N'Kristen Wiig', N'/lh42BSDh30GD65nfCTWDorZE46Z.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (52849, N'Max (voice)', N'Louis C.K.', N'/2BuRuObAnjrpEyjdZ7D7VPxwsbE.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (55638, N'Snowball (voice)', N'Kevin Hart', N'/9zxRAhWMxhVrgDnUysvTGLW7fcW.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (55936, N'Fleshlumpeater', N'Jemaine Clement', N'/juL82d8Cl1AQ1cUIOgJLRBGuNyY.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (56679, N'Dante Bishop', N'Edwin Hodge', N'/3T6xlpUq3d0qHIuOOzKyAUK87nZ.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (56731, N'Gina', N'Jessica Alba', N'/yMiHrSyrv5u8qwfi3T8EuI4VPFk.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (58873, N'Jacob Kowalski', N'Dan Fogler', N'/75hCIe6KHpHUlJDcyoxEp035BWz.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (59450, N'Jenny Ann', N'Katy Mixon', N'/o6yDzpvqsq0bObKDGPQdoszRKyW.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (62064, N'Captain James T. Kirk', N'Chris Pine', N'/1UvmmLI0tc8QgGEktNm7sB4Ft6u.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (65731, N'Captain Glover', N'Sam Worthington', N'/9XzAE3ZnCnazub4xrSY8YBN7sNq.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (66743, N'John Boy', N'Matt Bomer', N'/aSW1IvDtHnsDOovid4U6fl4EU8f.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (71189, N'Susan Turner', N'Cobie Smulders', N'/7TIENKNwDdKSuYqyTENKtCznkCG.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (72466, N'Percival Graves', N'Colin Farrell', N'/9FDzNq8cixv5PzJwjNXx1mJKAhU.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (72873, N'Agent Halpern', N'Michael Stuhlbarg', N'/i2AFa0liDriyN93myRSZHTUtoTN.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (73457, N'Joshua Farraday', N'Chris Pratt', N'/n4DD1AYU7WEMNPLga1TxqnHivn1.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (77795, N'Porpentina "Tina" Goldstein', N'Katherine Waterston', N'/x7WN8B1DB9RCptRZdzCN7fBjA61.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (77996, N'Jacob Portman', N'Asa Butterfield', N'/oYtmA3RB4wNhpISRDF4UXLnDQMC.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (81685, N'Sergeant Leo Barnes', N'Frank Grillo', N'/7JNCBT6A7zEN3ZqRjFNiTXGISo6.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (83860, N'Espin', N'Aldis Hodge', N'/bwnP5uuAsJgceLF2kJbeMJN0ONP.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (84223, N'Dana', N'Anna Kendrick', N'/dJn4oRzQAICBUYz6qPKhZjrXljr.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (84225, N'Alberto Parker', N'Gil Birmingham', N'/hbcG5tET6HMacNRKimbfsG6XRkX.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (94185, N'Lindsay Mills', N'Shailene Woodley', N'/esWtEnjI8tfsX4s9A5K0AoM0Yae.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (108916, N'The Sisters (voice)', N'Rooney Mara', N'/tkEzMpWji55VRm5R3lpnS6YU6ja.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (112476, N'Alex', N'Dylan Minnette', N'/4H7ycJx7nU3PRUEn5N3843DJASM.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (154689, N'', N'Bradley James', N'/4XAtJsz67pmpIsCQ9SBKfqayk2d.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (156962, N'Duke (voice)', N'Eric Stonestreet', N'/tBWsJGp3MSZg1nW3HKsQBRw8RTd.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (213001, N'Gidget (voice)', N'Jenny Slate', N'/bKyUz4N566bXBEhj1TkFfMiNFyT.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (221116, N'Eve', N'India Eisley', N'/dksLN6umGe9VYeraFgihEaAmSK4.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (227454, N'Heather Lee', N'Alicia Vikander', N'/oEgh5Clk8l0O5N60I8CsC2bk6QM.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (234352, N'Harleen Quinzel / Harley Quinn', N'Margot Robbie', N'/wHMKWqIkvJYFntCPHgQlcWYKav9.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (530618, N'Rocky', N'Jane Levy', N'/fwuotbEoG21Ci3WIzCQkjJ3rbWt.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (587020, N'David', N'Theo James', N'/hLNSoQ3gc52X5VVb172yO3CuUEq.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (972356, N'Smitty', N'Luke Bracey', N'/cfUv5lXfWVlbQeRaD8XZ0WDxqF9.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (998225, N'Queenie Goldstein', N'Alison Sudol', N'/w0ixLYjKN5I171bQ3XSsgW3Lte3.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1050248, N'Kubo (voice)', N'Art Parkinson', N'/3GAtluhYknwmQzorRusc2HGWQwQ.jpg')
GO
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1172147, N'Money', N'Daniel Zovatto', N'/hfohvPNLolPSLSsw4jPzHW7if2R.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1223163, N'The Hunter', N'Patrick Heusinger', N'/p63zyQsr6PcT8m0htg5YjJofK1V.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1265629, N'Holly March', N'Angourie Rice', N'/yaFJrFZGJsrqVJz75DpT44U0vcq.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1289968, N'June Moone / Enchantress', N'Cara Delevingne', N'/xyQ6aGfrjYyo7THhJLznPUpeMlt.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1317159, N'Natalie Stone', N'Natalie Burn', N'/gX2F7OfsLT2NhjgaQzPQ1viyH1M.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1392137, N'Amelia Kuttner', N'Margaret Qualley', N'/94vfDuj0OOlBfeIgw6vu8mhToNB.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1422517, N'Pete', N'Oakes Fegley', N'/43affsxtSULznVGP3wZ5XUC8dQj.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1423519, N'Natalie', N'Oona Laurence', N'/eyN1qM8HPV1CHxPVx8NprZGOMCV.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1425420, N'Sophie', N'Ruby Barnhill', N'/bu5Q7tQpY8Sf1dOSuEqfmDaEqm4.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1451101, N'Cindy', N'Franciska Torocsik', N'/zrYuRnc4um666uVHrG8WDpOSQa1.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1466613, N'Samantha', N'Danika Yarosh', N'/z3KZxKBOOSDhnHxiZiDl3WWkECD.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1564846, N'Moana (voice)', N'Auli''i Cravalho', N'/uSYgcqhxETyMezXLPK9nTRAbdWx.jpg')
INSERT [dbo].[cast] ([id], [character], [name], [profilePath]) VALUES (1631814, N'(voice)', N'Phillipa Soo', N'/8q9xwbtMmVr7mjjt9a2T0SXI1y4.jpg')
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (127380, N'Finding Dory', N'"Finding Dory" reunites Dory with friends Nemo and Marlin on a search for answers about her past. What can she remember? Who are her parents? And where did she learn to speak Whale?', CAST(N'2016-06-16T00:00:00.000' AS DateTime), 6.66, N'/z09QAf8WbZncbitewNk6lKYMZsh.jpg', N'Animation,Family', 97)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (188927, N'Star Trek Beyond', N'The USS Enterprise crew explores the furthest reaches of uncharted space, where they encounter a mysterious new enemy who puts them and everything the Federation stands for to the test.', CAST(N'2016-07-07T00:00:00.000' AS DateTime), 6.3, N'/mLrQMqyZgLeP8FrT5LCobKAiqmK.jpg', N'Action,Adventure,Science Fiction,Thriller', 122)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (223702, N'Sausage Party', N'Sausage Party, the first R-rated CG animated movie, is about one sausage leading a group of supermarket products on a quest to discover the truth about their existence and what really happens when they become chosen to leave the grocery store.', CAST(N'2016-07-11T00:00:00.000' AS DateTime), 5.93, N'/jDeDRLEa8JqB3xmKVy6q3bkmDt6.jpg', N'Adventure,Animation,Comedy,Fantasy', 83)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (259316, N'Fantastic Beasts and Where to Find Them', N'In 1926, Newt Scamander arrives at the Magical Congress of the United States of America with a magically expanded briefcase, which houses a number of dangerous creatures and their habitats. When the creatures escape from the briefcase, it sends the American wizarding authorities after Newt, and threatens to strain even further the state of magical and non-magical relations.', CAST(N'2016-11-16T00:00:00.000' AS DateTime), 7.33, N'/9HE9xiNMEFJnCzndlkWD7oPfAOx.jpg', N'Adventure,Family,Fantasy', 133)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (267935, N'The BFG', N'The BFG is no ordinary bone-crunching giant. He is far too nice and jumbly. It''s lucky for Sophie that he is. Had she been carried off in the middle of the night by the Bloodbottler, or any of the other giants—rather than the BFG—she would have soon become breakfast. When Sophie hears that the giants are flush-bunking off to England to swollomp a few nice little chiddlers, she decides she must stop them once and for all. And the BFG is going to help her!', CAST(N'2016-06-01T00:00:00.000' AS DateTime), 5.67, N'/lGHoH7pHsiwPs96tM9nA42id7K0.jpg', N'Adventure,Family,Fantasy', 120)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (277834, N'Moana', N'A young woman uses her navigational talents to set sail for a fabled island. Joining her on the adventure is her hero, the legendary demi-god Maui.', CAST(N'2016-11-23T00:00:00.000' AS DateTime), 4.25, N'/z4x0Bp48ar3Mda8KiPD1vwSY3D8.jpg', N'Music,Animation,Adventure,Comedy,Family,Fantasy', 103)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (278924, N'Mechanic: Resurrection', N'Arthur Bishop thought he had put his murderous past behind him when his most formidable foe kidnaps the love of his life. Now he is forced to travel the globe to complete three impossible assassinations, and do what he does best, make them look like accidents.', CAST(N'2016-08-25T00:00:00.000' AS DateTime), 4.73, N'/tgfRDJs5PFW20Aoh1orEzuxW8cN.jpg', N'Action,Crime,Thriller', 99)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (283366, N'Miss Peregrine''s Home for Peculiar Children', N'A teenager finds himself transported to an island where he must help protect a group of orphans with special powers from creatures intent on destroying them.', CAST(N'2016-09-28T00:00:00.000' AS DateTime), 6.13, N'/vR9YvUJCead23MOWwVzv9776eb1.jpg', N'Fantasy', 127)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (290250, N'The Nice Guys', N'A private eye investigates the apparent suicide of a fading porn star in 1970s Los Angeles and uncovers a conspiracy.', CAST(N'2016-05-15T00:00:00.000' AS DateTime), 6.85, N'/pbJ1vNwK9X6ZQm2vxarxcLJ0aGn.jpg', N'Action,Comedy,Crime,Mystery,Thriller', 116)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (294272, N'Pete''s Dragon', N'Pete is a mysterious 10-year-old with no family and no home who claims to live in the woods with a giant, green dragon named Elliott. With the help of Natalie, an 11-year-old girl whose father Jack owns the local lumber mill, forest ranger Grace sets out to determine where Pete came from, where he belongs, and the truth about this dragon.', CAST(N'2016-08-10T00:00:00.000' AS DateTime), 5.74, N'/e9Rzr8Hhu3pqdJtdDLC52PerLk1.jpg', N'Adventure,Family,Fantasy', 102)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (297761, N'Suicide Squad', N'From DC Comics comes the Suicide Squad, an antihero team of incarcerated supervillains who act as deniable assets for the United States government, undertaking high-risk black ops missions in exchange for commuted prison sentences.', CAST(N'2016-08-02T00:00:00.000' AS DateTime), 5.96, N'/e1mjopzAS2KNsvpbpahQ1a6SkSn.jpg', N'Action,Crime,Fantasy', 123)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (300669, N'Don''t Breathe', N'A group of teens break into a blind man''s home thinking they''ll get away with the perfect crime. They''re wrong.', CAST(N'2016-08-25T00:00:00.000' AS DateTime), 6.31, N'/lw0IqOSMsQcy1QnVIEIDppLmNwk.jpg', N'Crime,Horror,Thriller', 88)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (302401, N'Snowden', N'CIA employee Edward Snowden leaks thousands of classified documents to the press.', CAST(N'2016-09-15T00:00:00.000' AS DateTime), 6.47, N'/mWOotrG1MMKP9iCy2uPepbu27jk.jpg', N'Drama,Thriller', 134)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (302946, N'The Accountant', N'As a math savant uncooks the books for a new client, the Treasury Department closes in on his activities and the body count starts to rise.', CAST(N'2016-10-14T00:00:00.000' AS DateTime), 6.24, N'/l9BWPqUV57X5ELBDLlbO7Vhh3Mr.jpg', N'Crime,Thriller,Drama', 128)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (313297, N'Kubo and the Two Strings', N'In the epic fantasy, scruffy, kindhearted Kubo ekes out a humble living while devotedly caring for his mother in their sleepy shoreside village. It is a quiet existence – until a spirit from the past catches up with him to enforce an age-old vendetta. Suddenly on the run from gods and monsters, Kubo’s chance for survival rests on finding the magical suit of armor once worn by his fallen father, the greatest samurai the world has ever known. Summoning courage, Kubo embarks on a thrilling odyssey as he faces his family’s history, navigates the elements, and bravely fights for the earth and the stars.', CAST(N'2016-08-18T00:00:00.000' AS DateTime), 7.4, N'/3Kr9CIIMcXTPlm6cdZ9y3QTe4Y7.jpg', N'Adventure,Animation,Fantasy,Family', 101)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (316727, N'The Purge: Election Year', N'Two years after choosing not to kill the man who killed his son, former police sergeant Leo Barnes has become head of security for Senator Charlene Roan, the front runner in the next Presidential election due to her vow to eliminate the Purge. On the night of what should be the final Purge, a betrayal from within the government forces Barnes and Roan out onto the street where they must fight to survive the night.', CAST(N'2016-06-29T00:00:00.000' AS DateTime), 5.83, N'/bjOJFjUffRZQpNQ9g3yvc9F6LBM.jpg', N'Action,Horror,Thriller', 105)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (324668, N'Jason Bourne', N'The most dangerous former operative of the CIA is drawn out of hiding to uncover hidden truths about his past.', CAST(N'2016-07-27T00:00:00.000' AS DateTime), 5.56, N'/lFSSLTlFozwpaGlO31OoUeirBgQ.jpg', N'Action,Thriller', 123)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (324786, N'Hacksaw Ridge', N'WWII American Army Medic Desmond T. Doss, who served during the Battle of Okinawa, refuses to kill people and becomes the first Conscientious Objector in American history to win the Congressional Medal of Honor.', CAST(N'2016-11-04T00:00:00.000' AS DateTime), 6.71, N'/bndiUFfJxNd2fYx8XO610L9a07m.jpg', N'Drama,History,War', 131)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (328111, N'The Secret Life of Pets', N'The quiet life of a terrier named Max is upended when his owner takes in Duke, a stray whom Max instantly dislikes.', CAST(N'2016-06-18T00:00:00.000' AS DateTime), 5.98, N'/WLQN5aiQG8wc9SeKwixW7pAR8K.jpg', N'Adventure,Animation,Comedy,Family', 87)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (329865, N'Arrival', N'Taking place after alien crafts land around the world, an expert linguist is recruited by the military to determine whether they come in peace or are a threat.', CAST(N'2016-11-10T00:00:00.000' AS DateTime), 6.72, N'/4Iu5f2nv7huqvuYkmZvSPOtbFjs.jpg', N'Drama,Science Fiction', 116)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (333484, N'The Magnificent Seven', N'A big screen remake of John Sturges'' classic western The Magnificent Seven, itself a remake of Akira Kurosawa''s Seven Samurai. Seven gun men in the old west gradually come together to help a poor village against savage thieves.', CAST(N'2016-09-14T00:00:00.000' AS DateTime), 4.6, N'/z6BP8yLwck8mN9dtdYKkZ4XGa3D.jpg', N'Action,Adventure,Western', 132)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (338766, N'Hell or High Water', N'A divorced dad and his ex-con brother resort to a desperate scheme in order to save their family''s farm in West Texas.', CAST(N'2016-08-12T00:00:00.000' AS DateTime), 7.11, N'/rMev9yIIQkAk2odkMVnM8hszPVd.jpg', N'Crime,Drama', 102)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (343611, N'Jack Reacher: Never Go Back', N'Jack Reacher must uncover the truth behind a major government conspiracy in order to clear his name. On the run as a fugitive from the law, Reacher uncovers a potential secret from his past that could change his life forever.', CAST(N'2016-10-19T00:00:00.000' AS DateTime), 4.44, N'/IfB9hy4JH1eH6HEfIgIGORXi5h.jpg', N'Thriller,Action,Crime,Drama,Mystery', 118)
INSERT [dbo].[movie] ([id], [title], [overview], [releaseDate], [voteAverage], [posterPath], [genre], [runtime]) VALUES (346672, N'Underworld: Blood Wars', N'Underworld: Blood Wars follows Vampire death dealer, Selene, as she fends off brutal attacks from both the Lycan clan and the Vampire faction that betrayed her. With her only allies, David and his father Thomas, she must stop the eternal war between Lycans and Vampires, even if it means she has to make the ultimate sacrifice.', CAST(N'2016-12-01T00:00:00.000' AS DateTime), 0, N'/nHXiMnWUAUba2LZ0dFkNDVdvJ1o.jpg', N'Action,Horror', 120)
SET IDENTITY_INSERT [dbo].[movieCast] ON 

INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (583, 259316, 37632)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (584, 259316, 72466)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (585, 259316, 77795)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (586, 259316, 58873)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (587, 259316, 998225)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (588, 329865, 9273)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (589, 329865, 17604)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (590, 329865, 2178)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (591, 329865, 72873)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (592, 329865, 21629)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (593, 324668, 1892)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (594, 324668, 2176)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (595, 324668, 227454)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (596, 324668, 1925)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (597, 324668, 12041)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (598, 297761, 234352)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (599, 297761, 7499)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (600, 297761, 19492)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (601, 297761, 2888)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (602, 297761, 1289968)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (603, 328111, 52849)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (604, 328111, 156962)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (605, 328111, 55638)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (606, 328111, 213001)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (607, 328111, 25703)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (608, 127380, 14)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (609, 127380, 13)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (611, 127380, 18977)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (612, 127380, 3092)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (613, 188927, 62064)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (614, 188927, 17306)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (615, 188927, 1372)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (616, 188927, 11108)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (617, 188927, 8691)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (618, 267935, 1425420)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (619, 267935, 40900)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (620, 267935, 15556)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (621, 267935, 55936)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (622, 267935, 19278)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (623, 278924, 976)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (624, 278924, 56731)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (625, 278924, 1620)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (626, 278924, 1317159)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (627, 343611, 500)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (628, 343611, 71189)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (629, 343611, 83860)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (630, 343611, 1466613)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (631, 343611, 1223163)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (632, 300669, 530618)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (633, 300669, 112476)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (634, 300669, 1172147)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (635, 300669, 32747)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (636, 300669, 1451101)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (637, 223702, 19274)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (638, 223702, 41091)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (639, 223702, 21007)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (640, 223702, 39995)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (641, 313297, 1050248)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (642, 313297, 6885)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (643, 313297, 108916)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (644, 313297, 10297)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (645, 313297, 5469)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (646, 302401, 24045)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (647, 302401, 94185)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (648, 302401, 6832)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (649, 302401, 207)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (650, 324786, 37625)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (651, 324786, 65731)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (652, 324786, 972356)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (653, 324786, 20374)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (654, 324786, 1331)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (655, 277834, 1564846)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (656, 277834, 18918)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (657, 277834, 21088)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (658, 277834, 1631814)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (659, 290250, 934)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (660, 290250, 30614)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (661, 290250, 1265629)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (662, 290250, 66743)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (663, 290250, 1392137)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (664, 302946, 880)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (665, 302946, 84223)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (666, 302946, 18999)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (667, 302946, 19498)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (668, 302946, 4175)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (669, 316727, 31167)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (670, 316727, 81685)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (671, 316727, 34)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (672, 316727, 56679)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (673, 316727, 10361)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (674, 346672, 3967)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (675, 346672, 587020)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (676, 346672, 221116)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (677, 346672, 4391)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (678, 346672, 154689)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (679, 333484, 5292)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (680, 333484, 73457)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (681, 333484, 569)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (682, 333484, 7132)
GO
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (683, 333484, 25002)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (684, 294272, 18997)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (685, 294272, 1422517)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (686, 294272, 8210)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (687, 294272, 1423519)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (688, 283366, 10912)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (689, 283366, 77996)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (690, 283366, 40477)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (691, 283366, 19)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (692, 283366, 4757)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (693, 338766, 1229)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (694, 338766, 11107)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (695, 338766, 84225)
INSERT [dbo].[movieCast] ([id], [movieId], [castId]) VALUES (696, 338766, 59450)
SET IDENTITY_INSERT [dbo].[movieCast] OFF
ALTER TABLE [dbo].[movieCast]  WITH CHECK ADD  CONSTRAINT [FK_movieCast_cast] FOREIGN KEY([castId])
REFERENCES [dbo].[cast] ([id])
GO
ALTER TABLE [dbo].[movieCast] CHECK CONSTRAINT [FK_movieCast_cast]
GO
ALTER TABLE [dbo].[movieCast]  WITH CHECK ADD  CONSTRAINT [FK_movieCast_movie] FOREIGN KEY([movieId])
REFERENCES [dbo].[movie] ([id])
GO
ALTER TABLE [dbo].[movieCast] CHECK CONSTRAINT [FK_movieCast_movie]
GO
USE [master]
GO
ALTER DATABASE [movieDB] SET  READ_WRITE 
GO
