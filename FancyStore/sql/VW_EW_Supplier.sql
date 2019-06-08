USE [FancyStore]
GO

/****** Object:  View [dbo].[VW_EW_Supplier]    Script Date: 2019/6/8 ¤U¤È 04:55:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[VW_EW_Supplier]
as
select s.SupplierID,s.SupplierName
from Supplier as s
GO


