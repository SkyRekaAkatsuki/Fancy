USE [FancyStore]
GO

/****** Object:  View [dbo].[VW_EW_OrderDetail]    Script Date: 2019/6/7 ¤U¤È 12:17:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create view [dbo].[VW_EW_OrderDetail]
as
SELECT  ods.OrderID, p.ProductName, c.ColorName, s.SizeName, ods.OrderQTY, ISNULL(pds.StockQTY, 0) AS StockQTY, 
                   ISNULL(pds.StockQTY, 0) - ods.OrderQTY AS Balance, ods.ProductID, ods.ProductColorID, ods.ProductSizeID, 
                   ods.UnitPrice, ods.Amount
FROM      (SELECT od.OrderID, od.ProductID,od.ProductColorID, od.ProductSizeID, od.UnitPrice, SUM(od.OrderQTY) AS OrderQTY, 
                                      SUM(od.UnitPrice*od.OrderQTY) AS Amount
                   FROM       OrderDetail AS od		   
                   GROUP BY od.OrderID, od.ProductID, od.ProductColorID, od.ProductSizeID, UnitPrice) AS ods 
				   INNER JOIN  Product AS p ON ods.ProductID = p.ProductID 
				   INNER JOIN  ProductColor AS pc ON ods.ProductColorID = pc.ProductColorID 
				   inner join Color as c on pc.ColorID = c.ColorID
				   INNER JOIN  ProductSize AS ps ON ods.ProductSizeID = ps.ProductSizeID 
				   inner join Size as s on ps.SizeID = s.SizeID
				   LEFT OUTER JOIN ProductStock AS pds ON ods.ProductID = pds.ProductID AND ods.ProductColorID = pds.ProductColorID AND 
                   ods.ProductSizeID = pds.ProductSizeID
				   ;
GO


