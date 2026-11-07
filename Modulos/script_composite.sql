create database script_composite;
use script_composite;

create table Usuario(
	idUsuario int identity(1,1) not null,
	nombre varchar(50) not null,
	constraint pk_usuario primary key (idUsuario)
);

create table Permiso(
	idPermiso int not null,
	descripcion varchar(50) not null,
	constraint pk_permiso primary key (idPermiso)
);

create table UsuarioXPermiso(
	idUsuario int not null,
	idPermiso int not null,
	constraint pk_usuarioxpermiso primary key (idUsuario,idPermiso),
	constraint fk_usuarioxpermiso_usuario foreign key (idUsuario) references Usuario(idUsuario),
	constraint fk_usuarioxpermiso_permiso foreign key (idPermiso) references Permiso(idPermiso)
);

create table Grupo(
	idGrupo int not null,
	idPermiso int not null,
	constraint pk_grupo primary key (idGrupo,idPermiso),
	constraint fk_grupog_permiso foreign key (idGrupo) references Permiso(idPermiso),
	constraint fk_grupop_permiso foreign key (idPermiso) references Permiso(idPermiso)
);

/*
	INSERT DE PRUEBAS
*/

insert into Usuario(nombre) values
('Christian'),
('Leonel'),
('Darío'),
('Iris'),
('Lucas');

insert into Permiso(idPermiso,descripcion) values
(1,'LOGIN'),
(2,'ALTA'),
(3,'BAJA'),
(4,'MODIFICACIÓN'),
(5,'REVISAR CELULAR'),
(6,'LLAMAR'),
(7,'GENERAR REPORTE VENTAS'),
(100,'USUARIOS'),
(101,'GERENTES'),
(102,'BDAs'),
(103,'ADMINISTRADORES');

insert into Grupo(idGrupo,idPermiso) values
(100,1),
(100,2),
(100,4),
(101,100),
(101,3),
(102,101),
(102,6),
(103,102),
(103,5);

insert into UsuarioXPermiso(idUsuario,idPermiso) values
(1,1),
(1,2),
(1,4),
(2,1),
(2,2),
(2,3),
(3,4),
(3,5),
(5,1),
(5,5),
(4,103),
(4,7);

/*
	CONSULTAS DE PRUEBAS
*/

-- traer a todos los usuarios que tengan permisos asociados
select u.idUsuario, u.nombre, p.descripcion
from Usuario u
inner join UsuarioXPermiso up on u.idUsuario=up.idUsuario
inner join Permiso p on up.idPermiso=p.idPermiso;

-- traer a todos los usuarios que tengan o no permisos asociados
select u.idUsuario, u.nombre, p.descripcion
from Usuario u
left join UsuarioXPermiso up on u.idUsuario=up.idUsuario
left join Permiso p on up.idPermiso=p.idPermiso;

-- traer todos los permisos del usuario con id=3 (forma performante)
select u.idUsuario, u.nombre, p.descripcion
from Usuario u
inner join UsuarioXPermiso up on u.idUsuario=up.idUsuario and u.idUsuario=3 -- este AND es mucho más performante que poner un WHERE al final
inner join Permiso p on up.idPermiso=p.idPermiso;


-- traer todos los permisos del usuario con id=3 (forma no performante - NO USARLO)
select u.idUsuario, u.nombre, p.descripcion
from Usuario u
inner join UsuarioXPermiso up on u.idUsuario=up.idUsuario
inner join Permiso p on up.idPermiso=p.idPermiso
where u.idUsuario=3;

-- traer los grupos de permisos
select distinct p.idPermiso, p.descripcion
from grupo g
inner join Permiso p on p.idPermiso=g.idGrupo

-- traer todos los permisos y grupos
select distinct p.idPermiso, p.descripcion, 'EsGrupo' = case when idGrupo is null then 'No' else 'Si' end
from Permiso p
left join Grupo g on g.idGrupo=p.idPermiso

--
--
--
-- Cambiá el @idUsuario deseado para probar
declare @idUsuario int = 4;

with PermisosRecursivos as (
    -- Permisos asignados directamente al usuario
    select p.idPermiso, p.descripcion
    from UsuarioXPermiso ux
    inner join Permiso p on p.idPermiso = ux.idPermiso
    where ux.idUsuario = @idUsuario

    union all

    -- Permisos contenidos dentro de los grupos
    select p.idPermiso, p.descripcion
    from PermisosRecursivos pr
    inner join Grupo g on g.idGrupo = pr.idPermiso
    inner join Permiso p on p.idPermiso = g.idPermiso
)
select distinct idPermiso, descripcion
from PermisosRecursivos
order by idPermiso
option (maxrecursion 100);