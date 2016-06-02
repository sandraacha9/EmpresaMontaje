Imports MySql.Data.MySqlClient

Public Class PedidosProveedores

    Dim DtaPedidosProveedores As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsPedidosProveedores As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim DtaComponentesPorId As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsComponentesPorId As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaPedidosProveedores As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmNuevo As AuxiliarPedidosProveedores 'Creamos una variable con la conexion al formulario auxiliar.
    Dim FrmModificar As AuxiliarPedidosProveedores 'Declaramos una variable con la conexion al formulario auxiliar.
    Dim DtaLineasPedidosProveedores As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsLineasPedidosProveedores As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaLineasPedidosProveedores As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmLineasDePedidoProveedores As LineaDePedidoProveedores
    Dim posicion As Integer 'Declaramos una variable para guardar la posicion marcada en el datagrid.

    Private Sub PedidosProveedores_Load(sender As Object, e As EventArgs) Handles Me.Load 'Metodo que se ejecuta cuando cargas el formulario.
        CargarLoad()
        EnlazarControles() 'Llamamos al metodo EnlazarControles.
    End Sub

    Public Sub CargarLoad()
        DtsPedidosProveedores.Clear() 'Borramos el datagrid.

        DtaPedidosProveedores = New MySqlDataAdapter("select * from PedidosProveedores", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaPedidosProveedores.Fill(DtsPedidosProveedores, "PedidosProveedores") 'Para guardar la consulta en la tabla "PedidosProveedores" del dataset.
        Dim CbPedidosProveedores As New MySqlCommandBuilder(DtaPedidosProveedores) 'Para poder realizar operaciones en la bbdd.
    End Sub

    Public Sub LineasPedidosProveedoresDataGrid() 'Metodo para llenar el datagrid LineasPedidosProveedores con el id correspondiente del pedido.

        Dim num As Integer

        If TxtIDPedidoProveedor.Text <> "" = True Then
            num = CInt(TxtIDPedidoProveedor.Text)
        End If

        DtsLineasPedidosProveedores.Clear() 'Borramos el datagrid.
        DtaLineasPedidosProveedores = New MySqlDataAdapter("select * from LineasDePedidoProveedores where PedidosProveedores_idPedidosProveedores like " & num, EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaLineasPedidosProveedores.Fill(DtsLineasPedidosProveedores, "LineasDePedidoProveedores") 'Para guardar la consulta en la tabla "Clientes" del dataset.
        Dim CbLineasPedidosProveedores As New MySqlCommandBuilder(DtaLineasPedidosProveedores) 'Para poder realizar operaciones en la bbdd.

        DtgLineasDePedidoProveedores.DataSource = DtsLineasPedidosProveedores.Tables("LineasDePedidoProveedores") 'Tabla que quiero seleccionar para mostrar en la tabla.
    End Sub

    Public Sub EnlazarControles() 'Metodo para controlar los controles del formulario.

        'Enlazamos el texto del Txt con el campo indicado de la tabla del dataset indicado.
        TxtIDPedidoProveedor.DataBindings.Add("Text", DtsPedidosProveedores.Tables("PedidosProveedores"), "idPedidosProveedores")
        TxtFechaPedido.DataBindings.Add("Text", DtsPedidosProveedores.Tables("PedidosProveedores"), "FechaPedido")
        TxtPrecioTotPedidoProveedor.DataBindings.Add("Text", DtsPedidosProveedores.Tables("PedidosProveedores"), "PrecioTotalPedidoProveedor")
        TxtIDProveedor.DataBindings.Add("Text", DtsPedidosProveedores.Tables("PedidosProveedores"), "Proveedores_idProveedor")

        DtgPedidosProveedores.DataSource = DtsPedidosProveedores.Tables("PedidosProveedores") 'Tabla que quiero seleccionar para mostrar en la tabla.
        CmbIDPedidoProveedor.DataSource = DtsPedidosProveedores.Tables("PedidosProveedores") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbIDPedidoProveedor.DisplayMember = "idPedidosProveedores" 'Campo que quiero visualizar en el comboBox.

    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles TsPrimero.Click 'Metodo para cuando se clica en el boton Primero.

        'Seleccionamos los campos de la fila de la primera posicion, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsPedidosProveedores.Tables("PedidosProveedores")).Position = 0

    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles TsAnterior.Click 'Metodo para cuando se clica en el boton Anterior.

        'Seleccionamos los campos de la fila de la posicion siguiente a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsPedidosProveedores.Tables("PedidosProveedores")).Position -= 1

    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles TsSiguiente.Click 'Metodo para cuando se clica en el boton Siguiente.

        'Seleccionamos los campos de la fila de la posicion anterior a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsPedidosProveedores.Tables("PedidosProveedores")).Position += 1

    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles TsUltimo.Click 'Metodo para cuando se clica en el boton Ultimo.

        'Seleccionamos los campos de la fila de la ultima posicion contando las filas menos 1 porque empieza en 0, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsPedidosProveedores.Tables("PedidosProveedores")).Position = DtsPedidosProveedores.Tables("PedidosProveedores").Rows.Count - 1

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles TsSalir.Click 'Metodo para salir de la aplicacion.
        Me.Close() 'Cerramos la aplicacion = formulario.
        End 'Terminamos.
    End Sub

    Private Sub NuevoPedidoProveedor_Click(sender As Object, e As EventArgs) Handles TsNuevoPedidoProveedor.Click 'Metodo para crear un nuevo PedidoProveedor.

        FrmNuevo = New AuxiliarPedidosProveedores 'Creamos una variable con la conexion al formulario auxiliar.

        FrmNuevo.Text = "Nuevo PedidoProveedor" 'Cambiamos el titulo del formulario auxiliar.
        If FrmNuevo.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.

            filaPedidosProveedores = DtsPedidosProveedores.Tables("PedidosProveedores").NewRow 'Declaramos una row en blanco de la tabla PedidosProveedores que va a estar guardada en filaPedidosProveedores.
            LlenarFila(FrmNuevo) 'Llamamos al metodo LlenarFila.
            DtsPedidosProveedores.Tables("PedidosProveedores").Rows.Add(filaPedidosProveedores) 'Añadimos la fila rellenada en el DataRow.
            DtaPedidosProveedores.Update(DtsPedidosProveedores, "PedidosProveedores") 'Actualizamos la base de datos.
            DtsPedidosProveedores.AcceptChanges() 'Aceptamos los cambios.

            CargarLoad()
        End If
    End Sub

    Private Sub CmbIDPedidoProveedor_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbIDPedidoProveedor.SelectedValueChanged 'Metodo para cuando cambia el id.
        LineasPedidosProveedoresDataGrid()
    End Sub

    Public Sub LlenarFila(Frm As AuxiliarPedidosProveedores) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaPedidosProveedores.
        With Frm
            filaPedidosProveedores("Proveedores_idProveedor") = .CmbIDProveedores_P.Text
           
        End With
    End Sub

    'Metodo para cuando clicamos en el boton AgregarLineasDePedidosProveedores.
    Private Sub AgregarLineasDePedidosProveedores_Click(sender As Object, e As EventArgs) Handles AgregarLineasDePedidosProveedores.Click
        FrmLineasDePedidoProveedores = New LineaDePedidoProveedores 'Creamos el formulario.

        FrmLineasDePedidoProveedores.Text = "Agregar Linea de Pedido al PedidoProveedor" 'Cambiamos el titulo del formulario.

        With FrmLineasDePedidoProveedores
            .TxtIDPedidoProveedorEx.TabStop = False 'No dejamos que el tabulador nos lleve a ese edittext.
            .TxtIDPedidoProveedorEx.ReadOnly = True 'Bloqueamos el cuadro de texto de nombre en el formulario auxiliar para que no se pueda cambiar.
        End With

        PasarDatos() 'Llamamos al metodo PasarDatos.

        If FrmLineasDePedidoProveedores.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.
            filaLineasPedidosProveedores = DtsLineasPedidosProveedores.Tables("LineasDePedidoProveedores").NewRow 'Declaramos una row en blanco de la tabla Clientes que va a estar guardada en filaClientes.
            LlenarFila(FrmLineasDePedidoProveedores) 'Llamamos al metodo LlenarFila.
            DtsLineasPedidosProveedores.Tables("LineasDePedidoProveedores").Rows.Add(filaLineasPedidosProveedores) 'Añadimos la fila rellenada en el DataRow.

            DtaLineasPedidosProveedores.Update(DtsLineasPedidosProveedores, "LineasDePedidoProveedores") 'Actualizamos la base de datos.
            DtsLineasPedidosProveedores.AcceptChanges() 'Aceptamos los cambios.
        End If

        RecalcularPrecioPedido()
        SumarStock()

    End Sub

    Public Sub RecalcularPrecioPedido()
        Dim num As Integer

        If TxtIDPedidoProveedor.Text <> "" = True Then
            num = CInt(TxtIDPedidoProveedor.Text)
        End If

        'Realizamos el update del precio.
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim SQL As String
        myCommand.Connection = EmpresaMontaje.CnnEmpresaMontaje
        myAdapter.SelectCommand = myCommand
        SQL = "update pedidosproveedores set PrecioTotalPedidoProveedor = (select sum(PrecioComponente) from Componentes c inner join lineasdepedidoproveedores lpdp on c.idComponentes = lpdp.Componentes_idComponentes and lpdp.PedidosProveedores_idPedidosProveedores = " & num & ") where pedidosproveedores.idPedidosProveedores = " & num & ";"
        myCommand.CommandText = SQL
        myCommand.ExecuteNonQuery()
    End Sub

    'Metodo que pasa los datos de un cliente del formulario principal al auxiliar para que se muestren.
    Public Sub PasarDatos()
        With FrmLineasDePedidoProveedores
            .TxtIDPedidoProveedorEx.Text = TxtIDPedidoProveedor.Text
        End With
    End Sub

    Public Sub LlenarFila(Frm As LineaDePedidoProveedores) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaLineasPedidosProveedores.
        With Frm
            filaLineasPedidosProveedores("Cantidad") = .TxtCantidad.Text
            filaLineasPedidosProveedores("Componentes_idComponentes") = .CmbIDComponentes_C.Text
            filaLineasPedidosProveedores("PedidosProveedores_idPedidosProveedores") = .TxtIDPedidoProveedorEx.Text
        End With
    End Sub

    'Metodo que va a sumar la cantidad pedida del componente al stock de este.
    Public Sub SumarStock()

        Dim cantidad As Integer
        Dim idComponente As Integer

        posicion = Me.BindingContext(DtsLineasPedidosProveedores.Tables("LineasDePedidoProveedores")).Position 'Seleccionamos las tablas de la bbdd y guardamos su posicion.
        filaLineasPedidosProveedores = DtsLineasPedidosProveedores.Tables("LineasDePedidoProveedores").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.

        'Cojemos el id y la cantidad de la LineaPedido marcada.
        idComponente = filaLineasPedidosProveedores.Item(2)
        cantidad = 1

        DtaComponentesPorId = New MySqlDataAdapter("select * from Componentes where idComponentes like " & idComponente, EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaComponentesPorId.Fill(DtsComponentesPorId, "Componentes") 'Para guardar la consulta de la tabla "Componentes" del dataset.
        Dim CbComponentesPorId As New MySqlCommandBuilder(DtaComponentesPorId) 'Para poder realizar operaciones en la bbdd.

        'Guardamos esa fila en un DataRow.
        Dim DataRowPedido As DataRow = DtsComponentesPorId.Tables("Componentes").Rows(0)

        'Declaramos una variable int para guardar el valor de la columna de la fila guardada en el datarow.
        Dim stock As Integer
        stock = DataRowPedido.Item(3) 'Cojemos el valor de la columna 3

        'Calculamos el stock nuevo sumandole la cantidad al que habia.
        Dim stockN As Integer
        stockN = stock + cantidad

        DataRowPedido.BeginEdit() 'Le indicamos que comenzamos a editar.
        DataRowPedido("Stock") = stockN
        DataRowPedido.EndEdit() 'Le indicamos que terminamos de editar.

        DtaComponentesPorId.Update(DtsComponentesPorId, "Componentes") 'Actualizamos.
        DtsComponentesPorId.AcceptChanges() 'Aceptamos los cambios.
    End Sub

    'Metodo para cuando clicamos en el boton Informe del Menu.
    'Private Sub TsInforme_Click(sender As Object, e As EventArgs) Handles TsInforme.Click
    'InformePedidosProveedores.Show() 'Abrimos el formulario InformePedidosProveedores.
    'End Sub
End Class