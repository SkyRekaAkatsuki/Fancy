USE [FancyStore]
GO

/****** Object:  View [dbo].[VW_EW_ProductColor]    Script Date: 2019/6/8 ¤U¤È 04:54:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[VW_EW_ProductColor]
as
select pc.ProductColorID, c.ColorName
from ProductColor as pc
join Color as c on pc.ColorID = c.ColorID
GO


