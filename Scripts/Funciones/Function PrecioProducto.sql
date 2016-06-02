-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$

CREATE DEFINER=`root`@`localhost` FUNCTION `precioProductoFuncion`(id BIGINT) RETURNS double
BEGIN
	declare total double;
	set total=0.0;
	select sum(`PrecioComponente`) into total from `Componentes` c 
	inner join `ComponentesDeProducto` cp on c.idComponentes = cp.Componentes_idComponentes 
	and cp.Productos_idProductos = id;
	set total = total+150.0;
RETURN total;
END