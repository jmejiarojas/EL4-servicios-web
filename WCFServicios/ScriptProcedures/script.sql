USE NEGOCIOS2017
GO

CREATE PROCEDURE SP_LISTA_CLIENTES
AS
BEGIN
SELECT IdCliente, NomCliente, DirCliente, idpais, fonoCliente
FROM Ventas.clientes
END
GO

SELECT * FROM VENTAS.pedidoscabe
GO

CREATE PROCEDURE SP_LISTA_PEDIDOS
AS
BEGIN
SELECT P.IdPedido, P.FechaPedido, C.NomCliente, P.DirDestinatario, E.ApeEmpleado
FROM VENTAS.pedidoscabe P
JOIN VENTAS.clientes C ON C.IdCliente = P.IdCliente
JOIN RRHH.empleados E ON E.IdEmpleado = P.IdEmpleado
END
GO