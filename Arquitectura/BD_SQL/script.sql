create database bd_usuariostest;
use bd_usuariostest;

create table Usuario (
    dni VARCHAR(8) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    correo VARCHAR(50) NOT NULL,
    nombreUsuario VARCHAR(50) NOT NULL,
    password VARCHAR(64) NOT NULL,
    bloqueo BIT NOT NULL,
    activo BIT NOT NULL,
    cantIntentos TINYINT not null,
    CONSTRAINT PK_usuario PRIMARY KEY (dni),
);

select * from usuario;