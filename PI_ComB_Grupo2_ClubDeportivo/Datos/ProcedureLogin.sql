delimiter //  
create procedure IngresoLogin(in Usu varchar(20),in Pass varchar(15))
begin

  select NombreUsu, NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass
			and Activo = 1; 
end 
//


