USE [WTFDTMG]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 12/03/2012 09:48:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Purchase]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Purchase](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseDate] [datetime] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[AccountId] [int] NOT NULL,
	[LocationId] [int] NOT NULL,
	[Reason] [nvarchar](500) NOT NULL,
	[ForBusiness] [bit] NOT NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Purchase_ForBusiness]') AND parent_object_id = OBJECT_ID(N'[dbo].[Purchase]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Purchase_ForBusiness]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_ForBusiness]  DEFAULT ((0)) FOR [ForBusiness]
END


End
GO
