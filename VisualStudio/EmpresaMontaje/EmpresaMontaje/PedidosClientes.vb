Imports MySql.Data.MySqlClient

Public Class PedidosClientes

    Dim DtaPedidosClientes As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsPedidosClientes As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaPedidosClientes As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmNuevo As AuxiliarPedidosClientes 'Creamos una variable con la conexion al formulario auxiliar.
    Dim FrmModificar As AuxiliarPedidosClientes 'Declaramos una variable con la conexion al formulario auxiliar.
    Dim DtaLineasPedidosClientes As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsLineasPedidosClientes As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim DtaProveedores As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsProveedores As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaLineasPedidosClientes As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmLineasDePedidoClientes As LineasDePedidoClientes 'Declaramos una variable con la conexion al formulario LineasDePedidoClientes.
    Dim DtaComponentesPorId As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsComponentesPorId As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim DtaComponentesDeProductoPorIdProducto As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsComponentesDeProductoPorIdProducto As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim DtaComponentes As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsComponentes As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim DtaComponentes2 As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsComponentes2 As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Public DtaLineasPedidosClientesInicial As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Dim DtaUltimaLinea As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsUltimaLinea As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim posicion As Integer 'Declaramos una variable para guardar la posicion marcada en el datagrid.
    Dim pos As Integer 'Declaramos una variable para guardar la posicion marcada en el datagrid.
    Public DataRowComponentes As DataRow
    Public DataRowComponentes2 As DataRow
    Public DataRowUltimaLinea As DataRow

    Private Sub PedidosClientes_Load(sender As Object, e As EventArgs) Handles Me.Load 'Metodo que se ejecuta cuando cargas el formulario.
        CargarLoad()
        EnlazarControles() 'Llamamos al metodo EnlazarControles.
    End Sub

    Public Sub CargarLoad()
        DtsPedidosClientes.Clear() 'Borramos el datagrid.

        DtaPedidosClientes = New MySqlDataAdapter("select * from PedidosClientes", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaPedidosClientes.Fill(DtsPedidosClientes, "PedidosClientes") 'Para guardar la consulta en la tabla "PedidosClientes" del dataset.
        Dim CbPedidosClientes As New MySqlCommandBuilder(DtaPedidosClientes) 'Para poder realizar operaciones en la bbdd.
    End Sub

    Public Sub LineasPedidosClientesDataGrid() 'Metodo para llenar el datagrid LineasPedidosClientes con el id correspondiente del pedido.

        Dim num As Integer

        If TxtIDPedidoCliente.Text <> "" = True Then
            num = CInt(TxtIDPedidoCliente.Text)
        End If

        DtsLineasPedidosClientes.Clear() 'Borramos el datagrid.
        DtaLineasPedidosClientes = New MySqlDataAdapter("select * from LineasDePedidoClientes where PedidosClientes_idPedidosClientes like " & num, EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaLineasPedidosClientes.Fill(DtsLineasPedidosClientes, "LineasDePedidoClientes") 'Para guardar la consulta en la tabla "LineasDePedidoClientes" del dataset.
        Dim CbLineasPedidosProveedores As New MySqlCommandBuilder(DtaLineasPedidosClientes) 'Para poder realizar operaciones en la bbdd.

        DtgLineaPedidosClientes.DataSource = DtsLineasPedidosClientes.Tables("LineasDePedidoClientes") 'Tabla que quiero seleccionar para mostrar en la tabla.
    End Sub

    Public Sub EnlazarControles() 'Metodo para controlar los controles del formulario.

        'Enlazamos el texto del Txt con el campo indicado de la tabla del dataset indicado.
        TxtIDPedidoCliente.DataBindings.Add("Text", DtsPedidosClientes.Tables("PedidosClientes"), "idPedidosClientes")
        TxtFechaInicioPedido.DataBindings.Add("Text", DtsPedidosClientes.Tables("PedidosClientes"), "FechaInicioPedido")
        TxtFechaFinPedido.DataBindings.Add("Text", DtsPedidosClientes.Tables("PedidosClientes"), "FechaFinPedido")
        TxtEstado.DataBindings.Add("Text", DtsPedidosClientes.Tables("PedidosClientes"), "EstadoPedido")
        TxtPrecioTotPedidoCliente.DataBindings.Add("Text", DtsPedidosClientes.Tables("PedidosClientes"), "PrecioTotalPedidoCliente")
        TxtIDCliente.DataBindings.Add("Text", DtsPedidosClientes.Tables("PedidosClientes"), "Clientes_idClientes")

        DtgPedidosClientes.DataSource = DtsPedidosClientes.Tables("PedidosClientes") 'Tabla que quiero seleccionar para mostrar en la tabla.
        CmbIDPedidoCliente.DataSource = DtsPedidosClientes.Tables("PedidosClientes") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbIDPedidoCliente.DisplayMember = "idPedidosClientes" 'Campo que quiero visualizar en el comboBox.
    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles TsPrimero.Click 'Metodo para cuando se clica en el boton Primero.

        'Seleccionamos los campos de la fila de la primera posicion, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsPedidosClientes.Tables("PedidosClientes")).Position = 0

    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles TsAnterior.Click 'Metodo para cuando se clica en el boton Anterior.

        'Seleccionamos los campos de la fila de la posicion siguiente a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsPedidosClientes.Tables("PedidosClientes")).Position -= 1

    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles TsSiguiente.Click 'Metodo para cuando se clica en el boton Siguiente.

        'Seleccionamos los campos de la fila de la posicion anterior a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsPedidosClientes.Tables("PedidosClientes")).Position += 1

    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles TsUltimo.Click 'Metodo para cuando se clica en el boton Ultimo.

        'Seleccionamos los campos de la fila de la ultima posicion contando las filas menos 1 porque empieza en 0, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsPedidosClientes.Tables("PedidosClientes")).Position = DtsPedidosClientes.Tables("PedidosClientes").Rows.Count - 1

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles TsSalir.Click 'Metodo para salir de la aplicacion.
        Me.Close() 'Cerramos la aplicacion = formulario.
        End 'Terminamos.
    End Sub

    Private Sub NuevoPedidoCliente_Click(sender As Object, e As EventArgs) Handles TsNuevoPedidoCliente.Click 'Metodo para crear un nuevo PedidoCliente.

        FrmNuevo = New AuxiliarPedidosClientes 'Creamos una variable con la conexion al formulario auxiliar.

        FrmNuevo.Text = "Nuevo PedidoCliente" 'Cambiamos el titulo del formulario auxiliar.
        If FrmNuevo.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.

            Dim CbPedidosClientes As New MySqlCommandBuilder(DtaPedidosClientes) 'Para poder realizar operaciones en la bbdd.

            filaPedidosClientes = DtsPedidosClientes.Tables("PedidosClientes").NewRow 'Declaramos una row en blanco de la tabla PedidosClientes que va a estar guardada en filaPedidosProveedores.
            LlenarFila(FrmNuevo) 'Llamamos al metodo LlenarFila.
            DtsPedidosClientes.Tables("PedidosClientes").Rows.Add(filaPedidosClientes) 'Añadimos la fila rellenada en el DataRow.
            DtaPedidosClientes.Update(DtsPedidosClientes, "PedidosClientes") 'Actualizamos la base de datos.
            DtsPedidosClientes.AcceptChanges() 'Aceptamos los cambios.

            CargarLoad()
        End If
    End Sub

    Private Sub CmbIDPedidoCliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbIDPedidoCliente.SelectedValueChanged 'Metodo para cuando cambia el id.
        LineasPedidosClientesDataGrid()
    End Sub

    Public Sub LlenarFila(Frm As AuxiliarPedidosClientes) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaPedidosClientes.
        With Frm
            filaPedidosClientes("Clientes_idClientes") = .CmbIDCientes_C.Text
        End With
    End Sub

    'Metodo para cuando clicamos en el boton AgregarLineasDePedidosClientes.
    Private Sub AgregarLineasDePedidosClientes_Click(sender As Object, e As EventArgs) Handles AgregarLineasDePedidosClientes.Click
        FrmLineasDePedidoClientes = New LineasDePedidoClientes 'Creamos el formulario.

        FrmLineasDePedidoClientes.Text = "Agregar Linea de Pedido al PedidoCliente" 'Cambiamos el titulo del formulario.

        With FrmLineasDePedidoClientes
            .TxtIDPedidoClienteEx.TabStop = False 'No dejamos que el tabulador nos lleve a ese edittext.
            .TxtIDPedidoClienteEx.ReadOnly = True 'Bloqueamos el cuadro de texto de nombre en el formulario auxiliar para que no se pueda cambiar.
        End With

        PasarDatos() 'Llamamos al metodo PasarDatos.

        If FrmLineasDePedidoClientes.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.
            If TxtEstado.Text = "Registrado" Or TxtEstado.Text = "Montado" Then 'Controlamos que para añadir lineas solo pueda estar en estado Registrado.
                filaLineasPedidosClientes = Nothing
                filaLineasPedidosClientes = DtsLineasPedidosClientes.Tables("LineasDePedidoClientes").NewRow 'Declaramos una row en blanco de la tabla Clientes que va a estar guardada en filaClientes.
                LlenarFila(FrmLineasDePedidoClientes) 'Llamamos al metodo LlenarFila.
                DtsLineasPedidosClientes.Tables("LineasDePedidoClientes").Rows.Add(filaLineasPedidosClientes) 'Añadimos la fila rellenada en el DataRow.

                DtaLineasPedidosClientes.Update(DtsLineasPedidosClientes, "LineasDePedidoClientes") 'Actualizamos la base de datos.
                DtsLineasPedidosClientes.AcceptChanges() 'Aceptamos los cambios.

            Else 'Si no mostramos un mensaje de error y cerramos el formulario LineasDePedidoClientes.
                MsgBox("ESTE PEDIDO YA ESTA TERMINADO", MsgBoxStyle.Exclamation, "ERROR") 'Mostramos un mensaje de error.
                Exit Sub
            End If
        End If

        RecalcularPrecioPedidoCliente()

    End Sub

    Public Sub RecalcularPrecioPedidoCliente()
        Dim num As Integer

        If TxtIDPedidoCliente.Text <> "" = True Then
            num = CInt(TxtIDPedidoCliente.Text)
        End If

        'Realizamos el update del precio.
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim SQL As String
        myCommand.Connection = EmpresaMontaje.CnnEmpresaMontaje
        myAdapter.SelectCommand = myCommand
        SQL = "update pedidosclientes set PrecioTotalPedidoCliente = (select sum(PrecioProducto) from Productos p inner join lineasdepedidoclientes lpdc on p.idProductos = lpdc.Productos_idProductos and lpdc.PedidosClientes_idPedidosClientes = " & num & ") where pedidosclientes.idPedidosClientes = " & num & ";"
        myCommand.CommandText = SQL
        myCommand.ExecuteNonQuery()
    End Sub

    'Metodo que va a restar la cantidad pedida del componente al stock de este. (SIN PROBAR).
    Public Sub RestarStock()

        'Guardamos la posicion de la lineaDePedido marcada.
        Dim indice As Integer
        indice = DtgLineaPedidosClientes.CurrentRow.Index

        'Guardamos esa fila en un DataRow.
        Dim DataRowPedido As DataRow = DtsLineasPedidosClientes.Tables("LineasDePedidoClientes").Rows(indice)

        'Declaramos una variable integer para guardar el valor de la columna de la fila guardada en el datarow.
        Dim LineaCantidad As Integer
        LineaCantidad = 1
        Dim LineaIdProducto As Integer
        LineaIdProducto = DataRowPedido.Item(4)

        DtaComponentesDeProductoPorIdProducto = New MySqlDataAdapter("select * from ComponentesDeProducto where Productos_idProductos = " & LineaIdProducto, EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaComponentesDeProductoPorIdProducto.Fill(DtsComponentesDeProductoPorIdProducto, "ComponentesDeProducto") 'Para guardar la consulta de la tabla "ComponentesDeProducto" del dataset.
        Dim CbComponentesDeProductoPorIdProducto As New MySqlCommandBuilder(DtaComponentesDeProductoPorIdProducto) 'Para poder realizar operaciones en la bbdd.

        'Guardamos esa fila en un DataTable.
        Dim DataTableComponentesDeProductos As DataTable = DtsComponentesDeProductoPorIdProducto.Tables("ComponentesDeProducto")

        ' Recorremos todas las filas existentes en el objeto DataTable
        For Each row As DataRow In DataTableComponentesDeProductos.Rows
            Dim LineaIdComponente As Integer
            LineaIdComponente = CInt(row("Componentes_idComponentes")) 'Cojemos el valor de la columna Componentes_idComponente

            DtsComponentes.Clear()

            DtaComponentes = New MySqlDataAdapter("select * from Componentes where idComponentes = " & LineaIdComponente, EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
            DtaComponentes.Fill(DtsComponentes, "Componentes") 'Para guardar la consulta de la tabla "ComponentesDeProducto" del dataset.
            Dim CbComponentes As New MySqlCommandBuilder(DtaComponentes) 'Para poder realizar operaciones en la bbdd.

            'Guardamos esa fila en un DataRow.
            DataRowComponentes = DtsComponentes.Tables("Componentes").Rows(0)

            Dim stock As Integer
            stock = DataRowComponentes.Item(3) 'Cojemos el valor de la columna 3
            Dim stockMin As Integer
            stockMin = DataRowComponentes.Item(4) 'Cojemos el valor de la columna 3

            'Calculamos el stock nuevo restandole la cantidad al que habia.
            Dim stockN As Integer
            stockN = stock - LineaCantidad

            DataRowComponentes.BeginEdit() 'Le indicamos que comenzamos a editar.
            DataRowComponentes("Stock") = stockN
            DataRowComponentes.EndEdit() 'Le indicamos que terminamos de editar.

            DtaComponentes.Update(DtsComponentes, "Componentes") 'Actualizamos.
            DtsComponentes.AcceptChanges() 'Aceptamos los cambios.

            If stockN < stockMin = True Then
                RealizarPedidoProveedor(LineaIdComponente, stockN)
            End If

        Next
    End Sub

    'Metodo que pasa los datos de un cliente del formulario principal al auxiliar para que se muestren.
    Public Sub PasarDatos()
        With FrmLineasDePedidoClientes
            .TxtIDPedidoClienteEx.Text = TxtIDPedidoCliente.Text
        End With
    End Sub

    Public Sub LlenarFila(Frm As LineasDePedidoClientes) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaLineasPedidosClientes.
        With Frm
            filaLineasPedidosClientes("Cantidad") = .TxtCantidad.Text
            filaLineasPedidosClientes("Productos_idProductos") = .CmbIDProducto_P.Text
            filaLineasPedidosClientes("PedidosClientes_idPedidosClientes") = .TxtIDPedidoClienteEx.Text
        End With
    End Sub

    'Metodo para cuando clicamos en el boton Informe del Menu.
    'Private Sub TsInforme_Click(sender As Object, e As EventArgs) Handles TsInforme.Click
    '   InformePedidosClientes.Show() 'Abrimos el formulario InformePedidosClientes.
    'End Sub

    'Metodo que al clicar en el boton TerminarLinea terminara la LineaDePedido marcada y comprobara el estado de todas las lineas del pedido marcado.
    Private Sub BtnTerminarLinea_Click(sender As Object, e As EventArgs) Handles BtnTerminarLinea.Click

        'Guardamos la posicion de la lineaDePedido marcada.
        Dim indice As Integer
        indice = DtgLineaPedidosClientes.CurrentRow.Index

        'Guardamos esa fila en un DataRow.
        Dim DataRowPedido As DataRow = DtsLineasPedidosClientes.Tables("LineasDePedidoClientes").Rows(indice)

        'Declaramos una variable boolean para guardar el valor de la columna de la fila guardada en el datarow.
        Dim LineaTerminada As Boolean
        LineaTerminada = DataRowPedido.Item(2)

        'Condicion que comprueva si el estado de la linea es false.
        If LineaTerminada = False Then
            'Si lo es, lo cambiamos a true.
            DataRowPedido.BeginEdit() 'Le indicamos que comenzamos a editar.
            LineaTerminada = True
            DataRowPedido("Terminado") = LineaTerminada
            DataRowPedido.EndEdit() 'Le indicamos que terminamos de editar.

            DtaLineasPedidosClientes.Update(DtsLineasPedidosClientes, "LineasDePedidoClientes") 'Actualizamos.
            DtsLineasPedidosClientes.AcceptChanges() 'Aceptamos los cambios.
        Else 'Si no es falso, lo indicamos.
            MsgBox("LA LINEA DE PEDIDO SELECCIONNADA YA ESTA TERMINADA", MsgBoxStyle.Exclamation, "ERROR") 'Mostramos un mensaje de error.
        End If

        'Comprobamos si todas las lineas de ese pedido estan terminadas llamando a la funcion ComprobarTerminadoLineasPedido.
        'Si devuelve true cambiamos el estado del pedido a "Montado".
        If ComprobarTerminadoLineasPedido() = True Then
            If TxtEstado.Text = "Registrado" Then

                Dim estadoN As String
                posicion = Me.BindingContext(DtsPedidosClientes.Tables("PedidosClientes")).Position 'Seleccionamos las tablas de la bbdd y guardamos su posicion.
                filaPedidosClientes = DtsPedidosClientes.Tables("PedidosClientes").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.

                filaPedidosClientes.BeginEdit() 'Le indicamos que comenzamos a editar.
                estadoN = "Montado"
                TxtEstado.Text = estadoN
                filaPedidosClientes("EstadoPedido") = estadoN
                filaPedidosClientes.EndEdit() 'Le indicamos que terminamos de editar.

                DtaPedidosClientes.Update(DtsPedidosClientes, "PedidosClientes") 'Actualizamos.
                DtsPedidosClientes.AcceptChanges() 'Aceptamos los cambios.

                RestarStock()
            End If
        End If
    End Sub

    'Metodo para cuando clicamos en el boton EnviarPedido.
    Private Sub BtnEnviarPedido_Click(sender As Object, e As EventArgs) Handles BtnEnviarPedido.Click
        If TxtEstado.Text = "Montado" Then 'Comprobamos si el estado actual del producto es montado.

            Dim estadoN As String
            posicion = Me.BindingContext(DtsPedidosClientes.Tables("PedidosClientes")).Position 'Seleccionamos las tablas de la bbdd y guardamos su posicion.
            filaPedidosClientes = DtsPedidosClientes.Tables("PedidosClientes").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.

            filaPedidosClientes.BeginEdit() 'Le indicamos que comenzamos a editar.
            estadoN = "Servido"
            TxtEstado.Text = estadoN
            filaPedidosClientes("FechaFinPedido") = Now() 'Le añadimos en FechaFinPedido la fecha y hora actual.
            filaPedidosClientes("EstadoPedido") = estadoN 'Le cambiamos el EstadoPedido a "Servido".
            filaPedidosClientes.EndEdit() 'Le indicamos que terminamos de editar.

            DtaPedidosClientes.Update(DtsPedidosClientes, "PedidosClientes") 'Actualizamos.
            DtsPedidosClientes.AcceptChanges() 'Aceptamos los cambios.
        End If
    End Sub

    'Funcion para comprobar si todas las lineas de un pedido tienen el estado Terminado = true que devolvera un boolean.
    Public Function ComprobarTerminadoLineasPedido() As Boolean
        'Variable que se va a devolver segun el resultado de la consulta
        Dim ComprobarLineas As Boolean
        ComprobarLineas = True 'Indicamos por defecto que este en true.

        'Guardamos el numero de LineasDePedido que tiene el Pedido seleccionado.
        Dim cantidad As Integer
        cantidad = DtsLineasPedidosClientes.Tables("LineasDePedidoClientes").Rows.Count - 1 'Restamos 1 porque los indices empiezan en 0 y el count en 1.

        'Bucle que va a ejecutarse tantas veces como lineas hemos contado comenzando en 0.
        For i As Integer = 0 To cantidad
            Dim DataRowPos As DataRow = DtsLineasPedidosClientes.Tables("LineasDePedidoClientes").Rows(i) 'Recorremos los registros uno a uno.
            If DataRowPos.Item("Terminado") = False Then 'Indicamos el campo que queremos seleccionar y si algun Terminado es false.
                ComprobarLineas = False 'Cambiamos el valor a false porque no todas estan terminadas.
                Exit For
            Else
                'Si todas estan terminadas no hacemos nada.
            End If
        Next
        Return ComprobarLineas 'Retornamos el valor del boolean ComprobarLineas.
    End Function

    'Metodo para cuando el stock es inferior al stock minimo, para realizar un pedido al proveedor correspondiente de ese componente.
    Public Sub RealizarPedidoProveedor(id As Integer, stockN As Integer)

        Dim numeroDeProveedores As Integer

        'Contamos cuantos Proveedores hay en la bbdd.
        DtaProveedores = New MySqlDataAdapter("select count(*) from Proveedores", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaProveedores.Fill(DtsProveedores, "Proveedores") 'Para guardar la consulta en la tabla "PedidosClientes" del dataset.
        numeroDeProveedores = CInt(DtsProveedores.Tables("Proveedores").Rows(0).Item(0).ToString)
        'Para guardar cuantos registros hay en los "Proveedores" del dataset.

        'Generamos un numero aleatorio que coincidira con algun idProveedor.
        Dim value As Integer = CInt(Int((numeroDeProveedores * Rnd()) + 1))

        Dim cantidad As Integer
        cantidad = 1

        'Realizamos el insert del pedido al proveedor.
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim SQL As String
        myCommand.Connection = EmpresaMontaje.CnnEmpresaMontaje
        myAdapter.SelectCommand = myCommand
        SQL = "INSERT INTO `pedidosproveedores` (`Proveedores_idProveedor`) VALUES (" & value & ");"
        myCommand.CommandText = SQL
        myCommand.ExecuteNonQuery()

        Dim myCommand3 As New MySqlCommand
        Dim myAdapter3 As New MySqlDataAdapter
        Dim SQL3 As String
        myCommand3.Connection = EmpresaMontaje.CnnEmpresaMontaje
        SQL3 = "SELECT @@identity AS id from pedidosproveedores"
        myCommand3.CommandText = SQL3
        myCommand.ExecuteNonQuery()

        'Realizamos el insert de la linea de pedido al proveedor.
        Dim myCommand2 As New MySqlCommand
        Dim myAdapter2 As New MySqlDataAdapter
        Dim SQL2 As String
        myCommand2.Connection = EmpresaMontaje.CnnEmpresaMontaje
        myAdapter2.SelectCommand = myCommand2
        SQL2 = "INSERT INTO `lineasdepedidoproveedores` (`Cantidad`,`Componentes_idComponentes`,`PedidosProveedores_idPedidosProveedores`) VALUES (" & cantidad & ", " & id & " ,last_insert_id());"
        myCommand2.CommandText = SQL2
        myCommand2.ExecuteNonQuery()

        RecalcularPrecioPedidoProveedor()
        SumarStockPedidoNuevo(id, cantidad)
    End Sub

    'Sumar las unidades pedidas a los componentes pedidos.
    Public Sub SumarStockPedidoNuevo(id As Integer, cantidad As Integer)
        DtsComponentes2.Clear()

        DtaComponentes2 = New MySqlDataAdapter("select * from Componentes where idComponentes = " & id, EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaComponentes2.Fill(DtsComponentes2, "Componentes") 'Para guardar la consulta de la tabla "ComponentesDeProducto" del dataset.
        Dim CbComponentes2 As New MySqlCommandBuilder(DtaComponentes2) 'Para poder realizar operaciones en la bbdd.

        'Guardamos esa fila en un DataRow.
        DataRowComponentes2 = DtsComponentes2.Tables("Componentes").Rows(0)

        Dim stock As Integer
        stock = DataRowComponentes2.Item(3) 'Cojemos el valor de la columna 3

        'Calculamos el stock nuevo sumandole la cantidad al que habia.
        Dim stockNuevo As Integer
        stockNuevo = stock + cantidad

        DataRowComponentes2.BeginEdit() 'Le indicamos que comenzamos a editar.
        DataRowComponentes2("Stock") = stockNuevo
        DataRowComponentes2.EndEdit() 'Le indicamos que terminamos de editar.

        DtaComponentes2.Update(DtsComponentes2, "Componentes") 'Actualizamos.
        DtsComponentes2.AcceptChanges() 'Aceptamos los cambios.
    End Sub

    Public Sub RecalcularPrecioPedidoProveedor()
        DtaUltimaLinea = New MySqlDataAdapter("select * from lineasdepedidoproveedores where idLineasDePedidoProveedores = last_insert_id()", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaUltimaLinea.Fill(DtsUltimaLinea, "lineasdepedidoproveedores") 'Para guardar la consulta de la tabla "ComponentesDeProducto" del dataset.
        Dim CbUltimaLinea As New MySqlCommandBuilder(DtaUltimaLinea) 'Para poder realizar operaciones en la bbdd.

        'Guardamos esa fila en un DataRow.
        DataRowUltimaLinea = DtsUltimaLinea.Tables("lineasdepedidoproveedores").Rows(0)

        Dim idPedidoProveedorUltimaLinea As Integer
        idPedidoProveedorUltimaLinea = DataRowUltimaLinea.Item(3) 'Cojemos el valor de la columna 3

            'Realizamos el update del precio.
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim SQL As String
        myCommand.Connection = EmpresaMontaje.CnnEmpresaMontaje
        myAdapter.SelectCommand = myCommand
        SQL = "update pedidosproveedores set PrecioTotalPedidoProveedor = (select sum(PrecioComponente) from Componentes c inner join lineasdepedidoproveedores lpdp on c.idComponentes = lpdp.Componentes_idComponentes and lpdp.PedidosProveedores_idPedidosProveedores = " & idPedidoProveedorUltimaLinea & ") where idPedidosProveedores = " & idPedidoProveedorUltimaLinea & ";"
        myCommand.CommandText = SQL
        myCommand.ExecuteNonQuery()
    End Sub
End Class