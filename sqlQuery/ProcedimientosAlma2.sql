-- Procedimientos Almacenados para la tabla TIENDA
CREATE PROCEDURE CrearTienda
    @nombre VARCHAR(50),
    @horario VARCHAR(50)
AS
BEGIN
    INSERT INTO TIENDA (nombre, horario)
    VALUES (@nombre, @horario);
END;
GO

CREATE PROCEDURE ModificarTienda
    @id INT,
    @nombre VARCHAR(50),
    @horario VARCHAR(50)
AS
BEGIN
    UPDATE TIENDA
    SET nombre = @nombre,
        horario = @horario
    WHERE id = @id;
END;
GO

CREATE PROCEDURE EliminarTienda
    @id INT
AS
BEGIN
    DELETE FROM TIENDA
    WHERE id = @id;
END;
GO

-- Procedimientos Almacenados para la tabla UBICACIONES
CREATE PROCEDURE CrearUbicacion
    @pais VARCHAR(50),
    @ciudad VARCHAR(50),
    @direccion VARCHAR(50),
    @idTienda INT
AS
BEGIN
    INSERT INTO UBICACIONES (pais, ciudad, direccion, idTienda)
    VALUES (@pais, @ciudad, @direccion, @idTienda);
END;
GO

CREATE PROCEDURE ModificarUbicacion
    @pais VARCHAR(50),
    @ciudad VARCHAR(50),
    @direccion VARCHAR(50),
    @idTienda INT
AS
BEGIN
    UPDATE UBICACIONES
    SET pais = @pais,
        ciudad = @ciudad
    WHERE idTienda = @idTienda AND direccion = @direccion;
END;
GO

CREATE PROCEDURE EliminarUbicacion
    @idTienda INT,
    @direccion VARCHAR(50)
AS
BEGIN
    DELETE FROM UBICACIONES
    WHERE idTienda = @idTienda AND direccion = @direccion;
END;
GO

-- Procedimientos Almacenados para la tabla CLIENTE
CREATE PROCEDURE CrearCliente
    @Nombre VARCHAR(50),
    @Correo VARCHAR(50),
    @contraseña VARCHAR(50)
AS
BEGIN
    INSERT INTO CLIENTE (Nombre, Correo, contraseña)
    VALUES (@Nombre, @Correo, @contraseña);
END;
GO

CREATE PROCEDURE ModificarCliente
    @id INT,
    @Nombre VARCHAR(50),
    @Correo VARCHAR(50),
    @contraseña VARCHAR(50)
AS
BEGIN
    UPDATE CLIENTE
    SET Nombre = @Nombre,
        Correo = @Correo,
        contraseña = @contraseña
    WHERE id = @id;
END;
GO

CREATE PROCEDURE EliminarCliente
    @id INT
AS
BEGIN
    DELETE FROM CLIENTE
    WHERE id = @id;
END;
GO

-- Procedimientos Almacenados para la tabla FACTURA
CREATE PROCEDURE CrearFactura
    @fecha DATE,
    @subtotal DECIMAL(10,2),
    @total DECIMAL(10,2),
    @idTienda INT,
    @idCliente INT
AS
BEGIN
    INSERT INTO FACTURA (fecha, subtotal, total, idTienda, idCliente)
    VALUES (@fecha, @subtotal, @total, @idTienda, @idCliente);
END;
GO

CREATE PROCEDURE ModificarFactura
    @numero INT,
    @fecha DATE,
    @subtotal DECIMAL(10,2),
    @total DECIMAL(10,2),
    @idTienda INT,
    @idCliente INT
AS
BEGIN
    UPDATE FACTURA
    SET fecha = @fecha,
        subtotal = @subtotal,
        total = @total,
        idTienda = @idTienda,
        idCliente = @idCliente
    WHERE numero = @numero;
END;
GO

CREATE PROCEDURE EliminarFactura
    @numero INT
AS
BEGIN
    DELETE FROM FACTURA
    WHERE numero = @numero;
END;
GO

-- Procedimientos Almacenados para la tabla PRODUCTO
CREATE PROCEDURE CrearProducto
    @nombre VARCHAR(50),
    @tamaño VARCHAR(50),
    @marca VARCHAR(50)
AS
BEGIN
    INSERT INTO PRODUCTO (nombre, tamaño, marca)
    VALUES (@nombre, @tamaño, @marca);
END;
GO

CREATE PROCEDURE ModificarProducto
    @id INT,
    @nombre VARCHAR(50),
    @tamaño VARCHAR(50),
    @marca VARCHAR(50)
AS
BEGIN
    UPDATE PRODUCTO
    SET nombre = @nombre,
        tamaño = @tamaño,
        marca = @marca
    WHERE id = @id;
END;
GO

CREATE PROCEDURE EliminarProducto
    @id INT
AS
BEGIN
    DELETE FROM PRODUCTO
    WHERE id = @id;
END;
GO

-- Procedimientos Almacenados para la tabla DETALLE_FACTURA
CREATE PROCEDURE CrearDetalleFactura
    @idFactura INT,
    @idProducto INT
AS
BEGIN
    INSERT INTO DETALLE_FACTURA (idFactura, idProducto)
    VALUES (@idFactura, @idProducto);
END;
GO

CREATE PROCEDURE ModificarDetalleFactura
    @idFactura INT,
    @idProducto INT,
    @nuevoIdProducto INT
AS
BEGIN
    UPDATE DETALLE_FACTURA
    SET idProducto = @nuevoIdProducto
    WHERE idFactura = @idFactura AND idProducto = @idProducto;
END;
GO

CREATE PROCEDURE EliminarDetalleFactura
    @idFactura INT,
    @idProducto INT
AS
BEGIN
    DELETE FROM DETALLE_FACTURA
    WHERE idFactura = @idFactura AND idProducto = @idProducto;
END;
GO

-- Procedimientos Almacenados para la tabla TIPO_PRODUCTO
CREATE PROCEDURE CrearTipoProducto
    @nombre VARCHAR(50),
    @idProducto INT
AS
BEGIN
    INSERT INTO TIPO_PRODUCTO (nombre, idProducto)
    VALUES (@nombre, @idProducto);
END;
GO

CREATE PROCEDURE ModificarTipoProducto
    @idTipoProducto INT,
    @nombre VARCHAR(50),
    @idProducto INT
AS
BEGIN
    UPDATE TIPO_PRODUCTO
    SET nombre = @nombre,
        idProducto = @idProducto
    WHERE idTipoProducto = @idTipoProducto;
END;
GO

CREATE PROCEDURE EliminarTipoProducto
    @idTipoProducto INT
AS
BEGIN
    DELETE FROM TIPO_PRODUCTO
    WHERE idTipoProducto = @idTipoProducto;
END;
GO

-- Procedimientos Almacenados para la tabla TIENDA_PRODUCTO
CREATE PROCEDURE CrearTiendaProducto
    @idTienda INT,
    @idProducto INT,
    @precio DECIMAL(10,2),
    @Reorden INT,
    @Cantidad INT
AS
BEGIN
    INSERT INTO TIENDA_PRODUCTO (idTienda, idProducto, precio, Reorden, Cantidad)
    VALUES (@idTienda, @idProducto, @precio, @Reorden, @Cantidad);
END;
GO

CREATE PROCEDURE ModificarTiendaProducto
    @idTienda INT,
    @idProducto INT,
    @precio DECIMAL(10,2),
    @Reorden INT,
    @Cantidad INT
AS
BEGIN
    UPDATE TIENDA_PRODUCTO
    SET precio = @precio,
        Reorden = @Reorden,
        Cantidad = @Cantidad
    WHERE idTienda = @idTienda AND idProducto = @idProducto;
END;
GO

CREATE PROCEDURE EliminarTiendaProducto
    @idTienda INT,
    @idProducto INT
AS
BEGIN
    DELETE FROM TIENDA_PRODUCTO
    WHERE idTienda = @idTienda AND idProducto = @idProducto;
END;
GO

-- Procedimientos Almacenados para la tabla VENDEDOR
CREATE PROCEDURE CrearVendedor
    @nombre VARCHAR(50),
    @correo VARCHAR(50),
    @telefono VARCHAR(50)
AS
BEGIN
    INSERT INTO VENDEDOR (nombre, correo, telefono)
    VALUES (@nombre, @correo, @telefono);
END;
GO

CREATE PROCEDURE ModificarVendedor
    @id INT,
    @nombre VARCHAR(50),
    @correo VARCHAR(50),
    @telefono VARCHAR(50)
AS
BEGIN
    UPDATE VENDEDOR
    SET nombre = @nombre,
        correo = @correo,
        telefono = @telefono
    WHERE id = @id;
END;
GO

CREATE PROCEDURE EliminarVendedor
    @id INT
AS
BEGIN
    DELETE FROM VENDEDOR
    WHERE id = @id;
END;
GO

-- Procedimientos Almacenados para la tabla PRODUCTO_VENDEDOR
CREATE PROCEDURE CrearProductoVendedor
    @idProducto INT,
    @idVendedor INT
AS
BEGIN
    INSERT INTO PRODUCTO_VENDEDOR (idProducto, idVendedor)
    VALUES (@idProducto, @idVendedor);
END;
GO

CREATE PROCEDURE ModificarProductoVendedor
    @idProducto INT,
    @idVendedor INT,
    @nuevoIdVendedor INT
AS
BEGIN
    UPDATE PRODUCTO_VENDEDOR
    SET idVendedor = @nuevoIdVendedor
    WHERE idProducto = @idProducto AND idVendedor = @idVendedor;
END;
GO

CREATE PROCEDURE EliminarProductoVendedor
    @idProducto INT,
    @idVendedor INT
AS
BEGIN
    DELETE FROM PRODUCTO_VENDEDOR
    WHERE idProducto = @idProducto AND idVendedor = @idVendedor;
END;
GO
``
