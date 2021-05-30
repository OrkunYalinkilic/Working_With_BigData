create database BuyukDatalarIleCalismak
use BuyukDatalarIleCalismak

create table Kisiler
(
ID int identity(1,1) primary key,
isim nvarchar(30),
soyisim nvarchar(30),
EmailAdres nvarchar(60),
TelefonNumarasi nvarchar(20),
Resim varbinary(max)
)

alter proc KisiEkle
(
@isim nvarchar(30),
@soyisim nvarchar(30),
@EmailAdres nvarchar(60),
@TelefonNumarasi nvarchar(20),
@Resim varbinary(max) 
)
as
begin
insert into Kisiler (isim,soyisim,EmailAdres,TelefonNumarasi,Resim)
values(@isim,@soyisim,@EmailAdres,@TelefonNumarasi,@Resim)
end

select *from Kisiler where ID=@id

select *from Kisiler 