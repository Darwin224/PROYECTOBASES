-- Procedimientos Almacenados para la Tabla TIENDA

-- Crear tienda
CREATE PROCEDURE CrearTienda
    @nombre VARCHAR(50),
    @horario VARCHAR(50)
AS
BEGIN
    INSERT INTO TIENDA (nombre, horario)
    VALUES (@nombre, @horario);
END;
GO

-- Actualizar tienda
CREATE PROCEDURE ActualizarTienda
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

-- Eliminar tienda
CREATE PROCEDURE EliminarTienda
    @id INT
AS
BEGIN
    DELETE FROM TIENDA
    WHERE id = @id;
END;
GO

-- Procedimientos Almacenados para la Tabla CLIENTE

-- Crear cliente
CREATE PROCEDURE CrearCliente
    @Nombre VARCHAR(50),
    @Correo VARCHAR(50),
    @Contraseña VARCHAR(50)
AS
BEGIN
    INSERT INTO CLIENTE (Nombre, Correo, contraseña)
    VALUES (@Nombre, @Correo, @Contraseña);
END;
GO

-- Actualizar cliente
CREATE PROCEDURE ActualizarCliente
    @id INT,
    @Nombre VARCHAR(50),
    @Correo VARCHAR(50),
    @Contraseña VARCHAR(50)
AS
BEGIN
    UPDATE CLIENTE
    SET Nombre = @Nombre,
        Correo = @Correo,
        contraseña = @Contraseña
    WHERE id = @id;
END;
GO

-- Eliminar cliente
CREATE PROCEDURE EliminarCliente
    @id INT
AS
BEGIN
    DELETE FROM CLIENTE
    WHERE id = @id;
END;
GO

-- Procedimientos Almacenados para la Tabla FACTURA

-- Crear factura
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

-- Actualizar factura
CREATE PROCEDURE ActualizarFactura
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

-- Eliminar factura
CREATE PROCEDURE EliminarFactura
    @numero INT
AS
BEGIN
    DELETE FROM FACTURA
    WHERE numero = @numero;
END;
GO

-- Procedimientos Almacenados para la Tabla PRODUCTO

-- Crear producto
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

-- Actualizar producto
CREATE PROCEDURE ActualizarProducto
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

-- Eliminar producto
CREATE PROCEDURE EliminarProducto
    @id INT
AS
BEGIN
    DELETE FROM PRODUCTO
    WHERE id = @id;
END;
GO

-- Procedimientos Almacenados para la Tabla VENDEDOR

-- Crear vendedor
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

-- Actualizar vendedor
CREATE PROCEDURE ActualizarVendedor
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

-- Eliminar vendedor
CREATE PROCEDURE EliminarVendedor
    @id INT
AS
BEGIN
    DELETE FROM VENDEDOR
    WHERE id = @id;
END;
GO
