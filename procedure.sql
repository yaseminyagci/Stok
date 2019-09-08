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
      when IslemTur=1 then '��k��'
	  end as 'IslemTur',
case when IslemTur=0 then Miktar
	else 0 end as 'GirisMiktar',
case when Islemtur=1 then Miktar
	else 0 end as 'CikisMiktar' 
from [dbo].[STI]  where MalKodu=@MalKodu

-- if exists komutu, parantez i�indeki sorgunun de�er d�nd�r�p d�nd�rmedi�ini kontrol eder. E�er sorgu bir sonu� k�mesi d�nd�r�yorsa @Sonuc parametresi 1 de�erine e�itleniyor. D�nd�rm�yorsa 0 de�erine e�itleniyor.
