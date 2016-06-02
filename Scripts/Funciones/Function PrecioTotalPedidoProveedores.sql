-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$

CREATE DEFINER=`root`@`localhost` FUNCTION `precioTotalPedidoProveedoresFuncion` (id BIGINT) RETURNS double
BEGIN
	declare total double;
	set total = 0.0;
	select sum(PrecioComponente) into total from Componentes c
	inner join lineasdepedidoproveedores lpdp on c.idComponentes = lpdp.Componentes_idComponentes
	and lpdp.PedidosProveedores_idPedidosProveedores = id;
    set total = total * (1);
RETURN total;
END