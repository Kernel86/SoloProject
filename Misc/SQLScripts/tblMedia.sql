
CREATE TABLE [dbo].[tblMedia] (
  [Media_Id] INT NOT NULL IDENTITY(0,1),
  [ReleaseDate] DATE NULL ,
  [Title] VARCHAR(64) NULL ,
 CONSTRAINT [PK_tblMedia] PRIMARY KEY CLUSTERED 
(
	[Media_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO