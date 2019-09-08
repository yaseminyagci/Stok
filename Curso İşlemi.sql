DECLARE @stok int,@Islemtur int,@Miktar int

	DECLARE Stok_Kullanýmý CURSOR FOR
	
	SELECT Stý.IslemTur,stý.Miktar from STI 
 
	OPEN Stok_Kullanýmý
 
	FETCH NEXT FROM Stok_Kullanýmý INTO @IslemTur,@miktar 
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
			FETCH NEXT FROM Stok_Kullanýmý INTO @IslemTur,@miktar
 
		END
 
	CLOSE Stok_Kullanýmý 
 
	DEALLOCATE Stok_Kullanýmý 
 