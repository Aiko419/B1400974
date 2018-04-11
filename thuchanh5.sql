
CREATE TABLE [dbo].[Book]
(
	[BookId] [int] NOT NULL PRIMARY KEY,
	[Title] [nvarchar](150) NULL,
	[AuthorName] [nvarchar](150) NULL,
	[Price] [float] NULL,
	[Year] [int] NULL,
	[CoverPage] [varchar](150) NULL
)
GO


CREATE TABLE [dbo].[Chapter]
(
    [ChapterId] [int] NOT NULL PRIMARY KEY,
	[ChapterName] [nvarchar](50) NULL,
	[ShortContent] [nvarchar](250) NULL,
	[BookId] [int] NULL
)
GO

ALTER TABLE [dbo].[Chapter] ADD CONSTRAINT FK_Chapter_Book FOREIGN KEY([BookId]) REFERENCES [dbo].[Book]([BookId])