delimiter //
create procedure IntroducirSocio(in nom varchar(30), in ape varchar(40), in dni int unsigned, in fp varchar(40), out rta varchar(50))
begin
	declare socio_existe int;
    declare id int;
    declare vencimiento datetime;
    declare monto double;
    set vencimiento = case
		when fp = 'Mensual' then DATE_ADD(CURDATE(), INTERVAL 1 MONTH)
		when fp = 'Diario' then DATE_ADD(CURDATE(), INTERVAL 1 DAY)
	end;
    set vencimiento = DATE_ADD(vencimiento, interval 23 HOUR);
    set vencimiento = DATE_ADD(vencimiento, interval 59 MINUTE);
    set vencimiento = DATE_ADD(vencimiento, interval 59 SECOND);
    set monto = case
		when fp = 'Mensual' then 10000
		when fp = 'Diario' then 400
	end;
		
    select COUNT(*) into socio_existe from socios where socios.DNI = dni;
    
    if socio_existe > 0 then
		set rta = 'El socio ya existe';
	else
		insert into socios(Nombre,Apellido,DNI) values (nom,ape,dni);
        select IdSocio into id from socios order by IdSocio DESC limit 1;
        insert into formaDePago(IdSocio,Cobro) values (id, fp);
        insert into cuota(IdSocio,Monto,Vencimiento) values (id,monto,vencimiento);
		set rta = 'Socio ingresado correctamente';
	end if;
end
//