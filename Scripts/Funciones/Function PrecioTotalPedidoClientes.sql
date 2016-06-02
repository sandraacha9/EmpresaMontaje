-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$

CREATE DEFINER=`root`@`localhost` FUNCTION `precioTotalPedidoClientesFuncion`(id BIGINT) RETURNS double
BEGIN
	declare total double;
	set total = 0.0;
	select sum(PrecioProducto) into total from Productos p
	inner join lineasdepedidoclientes lpdc on p.idProductos = lpdc.Productos_idProductos
	and lpdc.PedidosClientes_idPedidosClientes = id;
    set total = total * (1);
RETURN total;
END