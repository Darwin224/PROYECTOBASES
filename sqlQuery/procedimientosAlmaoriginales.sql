sp_helptext CrearTienda;

-- Eliminar Tienda
CREATE PROCEDURE EliminarTienda
    @id INT
AS
BEGIN
    DELETE FROM TIENDA
    WHERE id = @id;
END;
GO

--Modificar Tienda--

CREATE PROCEDURE ModificarTiendaYUbicacion
    @id INT,
    @nombre VARCHAR(50),
    @horario VARCHAR(50),
    @pais VARCHAR(50),
    @ciudad VARCHAR(50),
    @direccion VARCHAR(50)
AS
BEGIN
    -- Actualizar la tienda
    UPDATE TIENDA
    SET nombre = @nombre,
        horario = @horario
    WHERE id = @id;

    -- Actualizar la ubicación
    UPDATE UBICACIONES
    SET pais = @pais,
        ciudad = @ciudad,
        direccion = @direccion
    WHERE idTienda = @id;
END;
GO

--Vendedor--

--Crear--
DROP PROCEDURE IF EXISTS CrearVendedor;


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

--Eliminar--
DROP PROCEDURE IF EXISTS EliminarVendedor;

CREATE PROCEDURE EliminarVendedor
    @id INT
AS
BEGIN
    -- Eliminar un vendedor. La eliminación se propagará a PRODUCTO_VENDEDOR debido al ON DELETE CASCADE
    DELETE FROM VENDEDOR
    WHERE id = @id;
END;
GO

--Modificar--
DROP PROCEDURE IF EXISTS ModificarVendedor;

CREATE PROCEDURE ModificarVendedor
    @id INT,
    @nombre VARCHAR(50),
    @correo VARCHAR(50),
    @telefono VARCHAR(50)
AS
BEGIN
    -- Actualizar un vendedor. La actualización se propagará a PRODUCTO_VENDEDOR debido al ON UPDATE CASCADE
    UPDATE VENDEDOR
    SET nombre = @nombre,
        correo = @correo,
        telefono = @telefono
    WHERE id = @id;
END;
GO


--Producto--

-- Crear procedimiento almacenado para insertar un producto, un tipo de producto y agregar el producto a una tienda

DROP PROCEDURE IF EXISTS CrearProductoYTipo; 


CREATE PROCEDURE CrearProductoYTipo
    @productoNombre VARCHAR(50),
    @productoTamaño VARCHAR(50),
    @productoMarca VARCHAR(50),
    @tipoNombre VARCHAR(50),
    @idTienda INT,
    @precio DECIMAL(10,2),
    @Reorden INT,
    @Cantidad INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Crear el producto
        DECLARE @productoId INT;
        INSERT INTO PRODUCTO (nombre, tamaño, marca)
        VALUES (@productoNombre, @productoTamaño, @productoMarca);

        -- Obtener el ID del producto recién creado
        SET @productoId = SCOPE_IDENTITY();

        -- Crear el tipo de producto asociado al producto
        INSERT INTO TIPO_PRODUCTO (nombre, idProducto)
        VALUES (@tipoNombre, @productoId);

        -- Agregar el producto a la tienda
        INSERT INTO TIENDA_PRODUCTO (idTienda, idProducto, precio, Reorden, Cantidad)
        VALUES (@idTienda, @productoId, @precio, @Reorden, @Cantidad);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;  -- Vuelve a lanzar la excepción para manejarla fuera del procedimiento
    END CATCH
END;
GO


-- Crear procedimiento almacenado para eliminar un producto
CREATE PROCEDURE EliminarProducto
    @id INT
AS
BEGIN
    DELETE FROM PRODUCTO
    WHERE id = @id;
END;
GO

-- Modificar--
CREATE PROCEDURE ModificarProductoYTipo
    @id INT,
    @nombre VARCHAR(50),
    @tamaño VARCHAR(50),
    @marca VARCHAR(50),
    @nombreTipoProducto VARCHAR(50)
AS
BEGIN
    -- Iniciar una transacción
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Actualizar el producto
        UPDATE PRODUCTO
        SET nombre = @nombre,
            tamaño = @tamaño,
            marca = @marca
        WHERE id = @id;

        -- Actualizar el tipo de producto
        UPDATE TIPO_PRODUCTO
        SET nombre = @nombreTipoProducto
        WHERE idProducto = @id;

        -- Confirmar la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- En caso de error, revertir la transacción
        ROLLBACK TRANSACTION;
        -- Lanza el error para manejarlo fuera del procedimiento
        THROW;
    END CATCH
END;
GO

select * from Inventario_Productos;

sp_helptext CrearTienda;


-- Llenar las tiendas con datos aleatorios


select * From TIENDA;