DECLARE @Tc CHAR(11), @barkod CHAR(13), @sgk varchar(20), @bfiyat money, @miktar smallint 

	DECLARE hesaplama CURSOR FOR
	
	select Hasta.TC_No,Ilac.Barkod,SGK,Birim_Fiyat,Miktar from Hasta 
inner join  Hasta_Satilan_Ilac on Hasta.TC_No=Hasta_Satilan_Ilac.TC_No
inner join Ilac on Hasta_Satilan_Ilac.Barkod= Ilac.Barkod

	OPEN hesaplama 

	FETCH NEXT FROM hesaplama INTO @Tc, @barkod,@sgk,@bfiyat,@miktar 

	WHILE @@FETCH_STATUS =0
		BEGIN
			
			 IF @sgk =' Yok'
              UPDATE Hasta_Satilan_Ilac SET Odenecek_Tutar = (@bfiyat*@miktar) 
              WHERE CURRENT OF hesaplama
        ELSE 
              UPDATE Hasta_Satilan_Ilac SET Odenecek_Tutar = (@bfiyat*@miktar /5) 
              WHERE CURRENT OF hesaplama 

			FETCH NEXT FROM hesaplama INTO @Tc, @barkod,@sgk,@bfiyat,@miktar
		END

	CLOSE hesaplama

	DEALLOCATE hesaplama
