DECLARE @stok int,@Islemtur int,@Miktar int

	DECLARE Stok_Kullan�m� CURSOR FOR
	
	SELECT St�.IslemTur,st�.Miktar from STI 
 
	OPEN Stok_Kullan�m�
 
	FETCH NEXT FROM Stok_Kullan�m� INTO @IslemTur,@miktar 
   set @stok=0
	WHILE @@FETCH_STATUS =0
		BEGIN
		 
			If @Islemtur=0
			begin
		    set @stok=@stok+@Miktar
			 end
			 else
			 set @stok=@stok-@miktar
			
			 print @stok
			FETCH NEXT FROM Stok_Kullan�m� INTO @IslemTur,@miktar
 
		END
 
	CLOSE Stok_Kullan�m� 
 
	DEALLOCATE Stok_Kullan�m� 
 