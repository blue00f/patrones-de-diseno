create database bd_bitacoracambios;
use bd_bitacoracambios;

create table Producto(
	Cod_Prod varchar(10) not null,
	Nombre varchar(100) not null,
	Existencia int not null,
	Descripcion varchar(255),
	Activo bit not null default 1,
	constraint pk_producto primary key(Cod_Prod)
);

create table Producto_C(
	Id_C int identity(1,1) not null,
	Cod_Prod varchar(10) not null,
	Nombre varchar(100) not null,
	Existencia int not null,
	Descripcion varchar(255),
	EstadoProducto bit not null default 1,
	FechaHora datetime2 not null default getdate(),
	Activo bit not null default 0,
	constraint pk_producto_c primary key(Id_C),
	constraint fk_producto foreign key(Cod_Prod) references Producto(Cod_Prod)
);

create trigger producto_actualizado
on Producto
after insert, update
as
begin
    set nocount on;
    if (cast(session_context(N'origen_bitacora') as bit) = 1)
        return;

    update pc set pc.Activo = 0 from Producto_C pc
    inner join inserted i on pc.Cod_Prod = i.Cod_Prod
    where pc.Activo = 1;

    insert into Producto_C (Cod_Prod, Nombre, Existencia, Descripcion, EstadoProducto, Activo)
    select Cod_Prod, Nombre, Existencia, Descripcion, i.Activo, 1
    from inserted i;
end;

create trigger producto_c_actualizado
on Producto_C
after update
as
begin
    set nocount on;
    if not update(Activo)
        return;
    if not exists (select 1 from inserted i where i.Activo = 1)
        return;
    exec sp_set_session_context 'origen_bitacora', 1;

    update pc set pc.Activo = 0 from Producto_C pc
    inner join inserted i on pc.Cod_Prod = i.Cod_Prod
    where i.Activo = 1 and pc.Id_C <> i.Id_C and pc.Activo = 1;

    update p
    set p.Nombre = i.Nombre,
        p.Existencia = i.Existencia,
        p.Descripcion = i.Descripcion,
        p.Activo = i.EstadoProducto
    from Producto p
    inner join inserted i on p.Cod_Prod = i.Cod_Prod
    where i.Activo = 1;

    exec sp_set_session_context 'origen_bitacora', 0;
end;


/*
    PRUEBAS
*/

-- Ingreso un registro en Producto (se tiene que crear un registro en la tabla copia)
insert into Producto(Cod_Prod, Nombre, Existencia, Descripcion)
values('P-001', 'Mouse óptico', 50, 'Mouse USB básico');

-- Modifico un registro en Producto (se tiene que crear un registro en la tabla copia, el anterior insert queda con Activo=0)
update Producto set Existencia = 45 where Cod_Prod = 'P-001';


-- De la tabla copia, cambio el valor Activo = 1 al primer registro ingresado, es decir, restauro al primer producto
update Producto_C set Activo = 1 where Id_C = 3;


update Producto set Existencia = 60 where Cod_Prod = 'P-001';

update Producto set Activo = 0 where Cod_Prod = 'P-001';
select * from Producto;
select * from Producto_C;
