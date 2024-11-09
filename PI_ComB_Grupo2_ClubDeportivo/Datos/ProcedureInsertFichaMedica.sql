delimiter //
create procedure IntroducirFicha(in dni int unsigned, in apto bool, in med bool, in enf varchar(40), in obs varchar(40), out rta varchar(100))
begin
	declare socio_existe int;
    select COUNT(*) into socio_existe from socios where socios.DNI = dni;

    if socio_existe > 0 then
        insert into fichaMedica (DNI, PuedeRealizarActividadFisica, ConsumeMedicamentos, enfPreex, Observaciones)
        values(dni,apto,med,enf,obs);
		set rta = 'Ficha Medica Cargada Correctamente.';
	else
        set rta = 'El socio no se encuentra registrado en la base de datos.';		
	end if;
end
//