

CREATE VIEW Inventario_Productos AS
SELECT 
    T.id AS idTienda,
    T.nombre AS NombreTienda,
    P.id AS idProducto,
    P.nombre AS NombreProducto,
    TP.Cantidad AS Cantidad,
    TP.Reorden AS Reorden,
    TP.precio AS Precio
FROM 
    TIENDA T
JOIN 
    TIENDA_PRODUCTO TP ON T.id = TP.idTienda
JOIN 
    PRODUCTO P ON TP.idProducto = P.id;


	select * from ComprasPorCliente2;
	drop view if EXISTS ComprasPorCliente;


CREATE VIEW ComprasPorCliente AS
SELECT
    c.Nombre AS NombreCliente,
    COUNT(f.numero) AS NumeroDeCompras,  -- Contador de compras por cliente
    f.numero AS NumeroFactura,
    f.fecha AS FechaFactura,
    p.nombre AS NombreProducto,
    p.tamaño AS TamañoProducto,
    p.marca AS MarcaProducto,
    f.subtotal AS SubtotalFactura,
    f.total AS TotalFactura
FROM
    CLIENTE c
INNER JOIN
    FACTURA f ON c.id = f.idCliente
INNER JOIN
    DETALLE_FACTURA df ON f.numero = df.idFactura
INNER JOIN
    PRODUCTO p ON df.idProducto = p.id
GROUP BY
    c.Nombre, f.numero, f.fecha, p.nombre, p.tamaño, p.marca, f.subtotal, f.total;


	SELECT * FROM HistorialVentasPorTienda;

	CREATE VIEW ComprasPorCliente2 AS
SELECT
    c.Nombre AS NombreCliente,
    COUNT(f.numero) AS NumeroDeCompras,  -- Contador total de facturas por cliente
    f.numero AS NumeroFactura,
    f.fecha AS FechaFactura,
    f.subtotal AS SubtotalFactura,
    f.total AS TotalFactura
FROM
    CLIENTE c
INNER JOIN
    FACTURA f ON c.id = f.idCliente
GROUP BY
    c.Nombre, f.numero, f.fecha, f.subtotal, f.total;


	Drop view if exists HistorialVentasPortienda;

CREATE VIEW HistorialVentasPorTienda AS
SELECT
    t.id AS IdTienda,        -- Incluye el id de la tienda para facilitar el filtro
    t.nombre AS NombreTienda,
    f.numero AS NumeroFactura,
    f.fecha AS FechaFactura,
    f.subtotal AS SubtotalFactura,
    f.total AS TotalFactura
FROM
    TIENDA t
INNER JOIN
    FACTURA f ON t.id = f.idTienda;


	SELECT *
FROM HistorialVentasPorTienda
WHERE IdTienda = 6
ORDER BY NombreTienda, FechaFactura;

select * from TIENDA_PRODUCTO;

SELECT * FROM FACTURA WHERE idTienda = 8;
