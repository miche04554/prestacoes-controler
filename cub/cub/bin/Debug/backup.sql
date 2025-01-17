USE [aluguel_banco]
GO
/****** Object:  Table [dbo].[apartamentos_tabela]    Script Date: 11/12/2019 16:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[apartamentos_tabela](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](50) NOT NULL,
	[data_compra] [date] NULL,
	[cub_quando_comprado] [decimal](36, 2) NOT NULL,
	[valor_em_cub] [decimal](36, 18) NOT NULL,
	[valor_parcela_cub] [decimal](36, 18) NOT NULL,
	[valor_reforco_cub] [decimal](36, 18) NULL,
	[valor_pago_reais] [decimal](18, 2) NOT NULL,
	[valor_pago_cub] [decimal](36, 18) NOT NULL,
	[saldo_devedor_cub] [decimal](36, 18) NOT NULL,
	[valor_em_reais] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_apartamentos_tabela] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cub_tabela]    Script Date: 11/12/2019 16:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cub_tabela](
	[valor_atual_do_cub] [decimal](18, 2) NOT NULL,
	[id] [int] NOT NULL,
 CONSTRAINT [PK_cub_tabela] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pagamentos_tabela]    Script Date: 11/12/2019 16:10:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pagamentos_tabela](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_apartamento] [int] NOT NULL,
	[tipo] [nchar](15) NOT NULL,
	[valor] [decimal](18, 2) NOT NULL,
	[data] [date] NOT NULL,
	[valor_cub] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_pagamentos_tabela] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[cub_tabela] ([valor_atual_do_cub], [id]) VALUES (CAST(1930.32 AS Decimal(18, 2)), 1)
ALTER TABLE [dbo].[pagamentos_tabela]  WITH CHECK ADD  CONSTRAINT [FK_pagamentos_apartamentos] FOREIGN KEY([id_apartamento])
REFERENCES [dbo].[apartamentos_tabela] ([id])
GO
ALTER TABLE [dbo].[pagamentos_tabela] CHECK CONSTRAINT [FK_pagamentos_apartamentos]
GO
