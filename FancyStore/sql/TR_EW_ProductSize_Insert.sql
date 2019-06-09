USE [FancyStore]
GO

/****** Object:  Trigger [dbo].[TR_EW_ProductSize_Insert]    Script Date: 2019/6/7 上午 11:40:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create TRIGGER [dbo].[TR_EW_ProductSize_Insert]
   ON [dbo].[ProductSize]
   after Insert
AS
	declare @countTemp int; --計算筆數
	declare @prodID int
	declare @prodSizeID int
	declare @prodColorID int

	--建立temp Table
	create table #tempProducutStock
	(ProductID int,
	ProductSizeID int,
	ProductColorID int
	);
	
	select @countTemp = count(*) from [dbo].[ProductColor] as pc
									join [dbo].[ProductSize] as ps
									on pc.ProductID = ps.ProductID
									join inserted as i
									on ps.ProductID = i.ProductID;
    if (@countTemp > 0)
	begin
			--將Insert建立的ProductID全部的color和Size寫入temptable中
			insert into #tempProducutStock
			select pc.ProductID,ps.ProductSizeID,pc.ProductColorID
			from [dbo].[ProductColor] as pc
			join [dbo].[ProductSize] as ps
			on pc.ProductID = ps.ProductID
			join inserted as i
			on ps.ProductID = i.ProductID;

			select @countTemp = count(*) from #tempProducutStock;
   
			while(@countTemp > 0)
			begin
					set rowcount 1
					select @prodID = tps.ProductID,
							@prodSizeID = tps.ProductSizeID,
							@prodColorID = tps.ProductColorID
						from #tempProducutStock tps;

					--To Something
					if not exists(select ProductID from [dbo].[ProductStock] as ps 
									where ps.ProductID = @prodID 
									and ps.ProductSizeID = @prodSizeID
									and ps.ProductColorID = @prodColorID )
					begin
							insert into [dbo].[ProductStock]
							values (@prodID,@prodSizeID, @prodColorID,10,10,getdate());
					end

					--因為set rowcount 1的關係，所以一次只會刪一筆
					delete from #tempProducutStock

					--計算還剩幾筆，@countTemp > 0 繼續
					select @countTemp = count(*) from #tempProducutStock
			end
	end

	--##tempProducutStock功成身退，你可以死了
	drop table #tempProducutStock   
GO

ALTER TABLE [dbo].[ProductSize] ENABLE TRIGGER [TR_EW_ProductSize_Insert]
GO


