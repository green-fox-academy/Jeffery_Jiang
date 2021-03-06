create procedure SubmitNewOrder 
	@customerName nvarchar(max),
	@execSuccess bit output,
	@orderId int output
AS
begin 
	begin transaction
		begin try 	
				

			insert into OrderHistory(OrderedAt,CustomerName)
			values(SYSDATETIME(),@customerName);

			select @orderId=MAX(OrderId)
				 from OrderHistory;

			insert into OrderItem(GoodId,Quantity,OrderId)
				select b.GoodId,b.Quantity,@orderId from BasketItem b;

			update Goods set Stock=Stock-Quantity
				from Goods 
				inner join BasketItem on Goods.GoodId= BasketItem.GoodId;

			set @execSuccess=1;
		
			commit
			
		end try
		begin catch
			set @execSuccess=0;
			rollback
		end catch
end	

declare @statu bit;

exec SubmitNewOrder 'Jeffery'