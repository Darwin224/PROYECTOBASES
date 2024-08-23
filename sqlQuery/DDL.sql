
CREATE TABLE TIENDA(
	id INT primary key IDENTITY(1,1),
	nombre varchar(50),
	horario varchar(50)
);


CREATE TABLE UBICACIONES (
    pais VARCHAR(50),
    ciudad VARCHAR(50),
    direccion VARCHAR(50),
    idTienda INT,
    PRIMARY KEY(idTienda, direccion),
    CONSTRAINT FK_TIENDA FOREIGN KEY (idTienda)
        REFERENCES TIENDA(id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);


Create table CLIENTE(
	id int identity(1,1) primary key,
	Nombre varchar(50),
	Correo varchar(50),
	contraseña varchar(50)
);


CREATE TABLE FACTURA(
    numero INT IDENTITY(1,1) PRIMARY KEY,
    fecha DATE,
    subtotal DECIMAL(10,2),
    total DECIMAL(10,2),
    idTienda INT,
    idCliente INT,
    CONSTRAINT FK_TIENDA_FACTURA FOREIGN KEY (idTienda) REFERENCES TIENDA(id),
    CONSTRAINT FK_CLIENTE_FACTURA FOREIGN KEY (idCliente) REFERENCES CLIENTE(id)
);


CREATE TABLE PRODUCTO(
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50),
    tamaño VARCHAR(50),
    marca VARCHAR(50)
);


CREATE TABLE DETALLE_FACTURA(
    idFactura INT,
	idProducto int,
    CONSTRAINT FK_FACTURA_DETALLE_FACTURA FOREIGN KEY (idFactura) REFERENCES FACTURA(numero)
	on delete cascade on update cascade,
	Constraint FK_FACTURA_DETALLE_PRODUCTO FOREIGN KEY (idProducto) REFERENCES PRODUCTO(id),
	primary key(idProducto, idFactura)
);

CREATE TABLE TIPO_PRODUCTO(
    idTipoProducto INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50),
    idProducto INT,
    CONSTRAINT FK_PRODUCTO_TIPO FOREIGN KEY (idProducto) REFERENCES PRODUCTO(id)
	on delete cascade
	on update cascade
);


CREATE TABLE TIENDA_PRODUCTO(
    idTienda INT,
    idProducto INT,
    precio DECIMAL(10,2),
    Reorden INT,
    Cantidad INT,
    CONSTRAINT FK_TIENDA_PRODUCTO_TIENDA FOREIGN KEY (idTienda) REFERENCES TIENDA(id),
    CONSTRAINT FK_TIENDA_PRODUCTO_PRODUCTO FOREIGN KEY (idProducto) REFERENCES PRODUCTO(id),
    PRIMARY KEY (idTienda, idProducto)
);


CREATE TABLE VENDEDOR(
    id INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(50),
    correo VARCHAR(50),
    telefono VARCHAR(50)
);


CREATE TABLE PRODUCTO_VENDEDOR(
    idProducto INT,
    idVendedor INT,
    CONSTRAINT FK_PRODUCTO_VENDEDOR_PRODUCTO FOREIGN KEY (idProducto) REFERENCES PRODUCTO(id),
    CONSTRAINT FK_PRODUCTO_VENDEDOR_VENDEDOR FOREIGN KEY (idVendedor) REFERENCES VENDEDOR(id),
    PRIMARY KEY (idProducto, idVendedor)
);


