delimiter //
create procedure GetSocio(in identificacion int unsigned, in esDni bool, out IdSocio int unsigned, out n varchar(30), out a varchar(40), out DNI int unsigned, out activo bool, out fIngreso datetime, out apto bool, out med bool, out enf varchar(25), out obs varchar(25))
begin
if esDNI = true then
	SELECT 
    socios.IdSocio,
    socios.Nombre,
    socios.Apellido,
    socios.DNI,
    socios.Activo,
    socios.FechaIngreso,
    fichaMedica.PuedeRealizarActividadFisica,
    fichaMedica.ConsumeMedicamentos,
    fichaMedica.enfPreex,
    fichaMedica.Observaciones
    INTO
    IdSocio,
    n,
    a,
    DNI,
    activo,
    fIngreso,
    apto,
    med,
    enf,
    obs
	FROM socios LEFT JOIN  fichaMedica ON  socios.DNI = fichaMedica.DNI
    WHERE socios.DNI = identificacion;
else
	SELECT 
    socios.IdSocio,
    socios.Nombre,
    socios.Apellido,
    socios.DNI,
    socios.Activo,
    socios.FechaIngreso,
    fichaMedica.PuedeRealizarActividadFisica,
    fichaMedica.ConsumeMedicamentos,
    fichaMedica.enfPreex,
    fichaMedica.Observaciones
    INTO
    IdSocio,
    n,
    a,
    DNI,
    activo,
    fIngreso,
    apto,
    med,
    enf,
    obs
	FROM socios LEFT JOIN  fichaMedica ON  socios.DNI = fichaMedica.DNI
    WHERE socios.IdSocio = identificacion;
end if;
end
//




