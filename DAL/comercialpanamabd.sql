create database comercialpanamabd; 
drop database comercialpanamabd; 

CREATE TABLE empleado(
  id_empleado varchar(15) NOT NULL,
  nombre_empleado varchar(60) NOT NULL,
  apellido_empleado varchar(60) NOT NULL,
  direccion_empleado varchar(100) NOT NULL,
  telefono_empleado varchar(15) NOT NULL,
  genero_empleado varchar(1) NOT NULL,
  fecha_ingreso_empleado datetime NOT NULL,
  foto_empleado blob NULL,
  correo_empleado varchar(45) NOT NULL,
PRIMARY KEY (id_empleado));

CREATE TABLE sede(
  nit_sede varchar(15) NOT NULL,
  nombre_sede varchar(60) NOT NULL,
  direccion_sede varchar(100) NOT NULL,
  telefono_sede varchar(15) NOT NULL,
  responsable_sede varchar(45) NOT NULL,
PRIMARY KEY (nit_sede),
FOREIGN KEY(responsable_sede) REFERENCES empleado(id_empleado));

CREATE TABLE categoria(
  id_categoria varchar(15) NOT NULL,
  nombre_categoria varchar(60)  NOT NULL,
PRIMARY KEY (id_categoria)); 

CREATE TABLE producto (
  id_producto varchar(45) NOT NULL,
  nombre_producto varchar(45) NOT NULL,
  precio_venta_producto decimal(7,3) NOT NULL,
  precio_compra_producto decimal(7,3) NOT NULL,
  fecha_ingreso_producto date NOT NULL,
  responsable_producto varchar(45) NOT NULL,
  nit_sede varchar(45) NOT NULL,
  id_producto varchar(45) NOT NULL,
PRIMARY KEY (id_producto),
FOREIGN KEY(responsable_producto) REFERENCES empleado(id_empleado),
FOREIGN KEY(nit_sede) REFERENCES sede(nit_sede),
FOREIGN KEY(id_categoria) REFERENCES categoria(id_categoria));

CREATE TABLE usuario (
  id_usuario varchar(15) NOT NULL,
  password varchar(45) NOT NULL,
  nombre_usuario varchar(60) NOT NULL,
  correo_usuario varchar(45) NOT NULL UNIQUE,
  id_empleado varchar(15) NOT NULL,
PRIMARY KEY (id_usuario),
FOREIGN KEY(id_empleado) REFERENCES empleado(id_empleado));
 
CREATE TABLE inicio_sesion_has_empleado(
  id_inicio_sesion varchar(15) NOT NULL,
  id_usuario varchar(15) NOT NULL,
FOREIGN KEY (id_inicio_sesion) REFERENCES inicio_sesion(usuario),
FOREIGN KEY (id_usuario) REFERENCES usuario(id_usuario));

CREATE TABLE inicio_sesion (
  usuario varchar(15) NOT NULL,
  password varchar(15) NOT NULL,
PRIMARY KEY (usuario)); 
  



