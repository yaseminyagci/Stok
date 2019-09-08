USE [test]
GO
/****** Object:  StoredProcedure [dbo].[Mal_Procedure_]    Script Date: 7.09.2019 00:28:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[Mal_Procedure_]
(
@MalKodu NVARCHAR(400)
)
AS
select  Row_number() over (order by EvrakNo) as SiraNo ,EvrakNo,MalKodu,CONVERT(VARCHAR(15), CAST(STI.Tarih - 2 AS datetime), 104) as Tarih, 
case  when IslemTur=0 then 'Giris'
      when IslemTur=1 then 'Çýkýþ'
	  end as 'IslemTur',
case when IslemTur=0 then Miktar
	else 0 end as 'GirisMiktar',
case when Islemtur=1 then Miktar
	else 0 end as 'CikisMiktar' 
from [dbo].[STI]  where MalKodu=@MalKodu

-- if exists komutu, parantez içindeki sorgunun deðer döndürüp döndürmediðini kontrol eder. Eðer sorgu bir sonuç kümesi döndürüyorsa @Sonuc parametresi 1 deðerine eþitleniyor. Döndürmüyorsa 0 deðerine eþitleniyor.
