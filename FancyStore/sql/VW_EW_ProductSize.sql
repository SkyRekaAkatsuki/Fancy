USE [FancyStore]
GO

/****** Object:  View [dbo].[VW_EW_ProductSize]    Script Date: 2019/6/8 ¤U¤È 04:55:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[VW_EW_ProductSize]
as
select ps.ProductSizeID, s.SizeName
from ProductSize as ps
join Size as s on ps.SizeID = s.SizeID
GO


