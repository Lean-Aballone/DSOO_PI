delimiter //
create procedure IntroducirSocio(in nom varchar(30), in ape varchar(40), in dni int unsigned, out rta varchar(50))
begin
	declare socio_existe int;
    select COUNT(*) into socio_existe from socios where socios.DNI = dni;
    
    if socio_existe > 0 then
		set rta = 'El socio ya existe';
	else
		insert into socios(Nombre,Apellido,DNI) values (nom,ape,dni);
		set rta = 'Socio ingresado correctamente';
	end if;
end
//

SELECT * FROM socios WHERE DNI = 999 //