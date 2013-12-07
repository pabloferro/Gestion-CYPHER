



go
create function CIPHER.enElMismoAnoYMes(@fecha1 Datetime,@fecha2 Datetime)
returns bit
as
begin
if(YEAR(@fecha1)=YEAR(@fecha2) and MONTH(@fecha1)=MONTH(@fecha2))
	return 1

return 0
end

go
create procedure top5BonosFVencidos(@fecha DateTime)
as
begin
	select top 5 
	(select count(*) 
	 from CIPHER.COMPRA join CIPHER.BONOFARMACIA on 
		  BONF_COMPRA=COMP_CODIGO and COMP_AFILIADO=AFIL_NROAFILIADO and BONF_AFILIADOCONSUMIO is null 
     where BONF_FECHAVENCIMIENTO>GETDATE() and CIPHER.enElMismoAnoYMes(BONF_FECHAVENCIMIENTO,@fecha)=1),
	AFIL_NOMBRE,AFIL_APELLIDO
	from CIPHER.AFILIADO 
	order by 1 desc
end
go