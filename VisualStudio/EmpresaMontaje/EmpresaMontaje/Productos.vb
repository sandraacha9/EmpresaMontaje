Imports MySql.Data.MySqlClient

Public Class Productos

    Dim DtaProductos As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Dim DtaComponentesDeProducto As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsProductos As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Public DtsComponentesDeProducto As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaComponentesDeProducto As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim filaProductos As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmNuevo As AuxiliarProductos 'Creamos una variable con la conexion al formulario auxiliar.
    Dim FrmModificar As AuxiliarProductos 'Declaramos una variable con la conexion al formulario auxiliar.
    Dim FrmProducto_Componente As Producto_Componente 'Declaramos una variable con la conexion al formulario Producto_Componente.
    Dim posicion As Integer 'Declaramos una variable para guardar la posicion marcada en el datagrid.

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles Me.Load 'Metodo que se ejecuta cuando cargas el formulario.
        CargarLoad()
        EnlazarControles() 'Llamamos al metodo EnlazarControles.
    End Sub

    Public Sub CargarLoad()
        DtsProductos.Clear() 'Borramos el datagrid.

        DtaProductos = New MySqlDataAdapter("select * from Productos", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaProductos.Fill(DtsProductos, "Productos") 'Para guardar la consulta en la tabla "Productos" del dataset.
        Dim CbProductos As New MySqlCommandBuilder(DtaProductos) 'Para poder realizar operaciones en la bbdd.
    End Sub

    Public Sub EnlazarControles() 'Metodo para llenar los controles del formulario.

        'Enlazamos el texto del Txt con el campo indicado de la tabla del dataset indicado.
        TxtIDProducto.DataBindings.Add("Text", DtsProductos.Tables("Productos"), "idProductos")
        TxtNombreProducto.DataBindings.Add("Text", DtsProductos.Tables("Productos"), "Nombre")
        TxtDescProducto.DataBindings.Add("Text", DtsProductos.Tables("Productos"), "Descripcion")
        TxtPrecioProducto.DataBindings.Add("Text", DtsProductos.Tables("Productos"), "PrecioProducto")

        DtgProductos.DataSource = DtsProductos.Tables("Productos") 'Tabla que quiero seleccionar para mostrar en la tabla.
        'DtgComponentesProducto.DataSource = DtsComponentesDeProducto.Tables("ComponentesDeProducto") 'Tabla que quiero seleccionar para mostrar en la tabla.
        CmbNombreProducto.DataSource = DtsProductos.Tables("Productos") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbNombreProducto.DisplayMember = "Nombre" 'Campo que quiero visualizar en el comboBox.

    End Sub

    Public Sub ComponentesDeProductoDataGrid() 'Metodo para llenar el datagrid componentesDeProducto con el id correspondiente del producto.

        Dim num As Integer

        If TxtIDProducto.Text <> "" = True Then
            num = CInt(TxtIDProducto.Text) 'Guardamos el id del producto.
        End If

        DtsComponentesDeProducto.Clear() 'Borramos el datagrid.
        DtaComponentesDeProducto = New MySqlDataAdapter("select * from ComponentesDeProducto where Productos_idProductos like " & num, EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaComponentesDeProducto.Fill(DtsComponentesDeProducto, "ComponentesDeProducto") 'Para guardar la consulta en el dataset.
        Dim CbComponentesDeProducto As New MySqlCommandBuilder(DtaComponentesDeProducto) 'Para poder realizar operaciones en la bbdd.

        DtgComponentesProducto.DataSource = DtsComponentesDeProducto.Tables("ComponentesDeProducto") 'Tabla que quiero seleccionar para mostrar en la tabla.
    End Sub

    Private Sub CmbNombreProducto_SelectedValueChanged(sender As Object, e As EventArgs) Handles CmbNombreProducto.SelectedValueChanged 'Metodo para cuando cambia el id.
        ComponentesDeProductoDataGrid() 'Llamamos al metodo ComponentesDeProductoDataGrid.
    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles TsPrimero.Click 'Metodo para cuando se clica en el boton Primero.

        'Seleccionamos los campos de la fila de la primera posicion, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsProductos.Tables("Productos")).Position = 0

    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles TsAnterior.Click 'Metodo para cuando se clica en el boton Anterior.

        'Seleccionamos los campos de la fila de la posicion siguiente a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsProductos.Tables("Productos")).Position -= 1

    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles TsSiguiente.Click 'Metodo para cuando se clica en el boton Siguiente.

        'Seleccionamos los campos de la fila de la posicion anterior a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsProductos.Tables("Productos")).Position += 1

    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles TsUltimo.Click 'Metodo para cuando se clica en el boton Ultimo.

        'Seleccionamos los campos de la fila de la ultima posicion contando las filas menos 1 porque empieza en 0, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsProductos.Tables("Productos")).Position = DtsProductos.Tables("Productos").Rows.Count - 1

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles TsSalir.Click 'Metodo para salir de la aplicacion.
        Me.Close() 'Cerramos la aplicacion = formulario.
        End 'Terminamos.
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles TsBorrar.Click 'Metodo para borrar un Producto.
        'Condicion para las respuestas de un cuadro de mensaje, el mensaje muestra una exclamacion, dos mensajes y un boton aceptar y uno cancelar.
        If MsgBox("Desea borrar el Producto con id " & TxtIDProducto.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atencion") = MsgBoxResult.No Then 'Si le damos a enter es como si pulsaramos NO.
            Exit Sub 'Salimos del metodo.
        End If
        Try
            posicion = Me.BindingContext(DtsProductos.Tables("Productos")).Position 'Seleccionamos la posicion del enlace actual de Productos = BindingContext.
            filaProductos = DtsProductos.Tables("Productos").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.
            filaProductos.Delete() 'Borramos la fila seleccionada del data set.
            DtaProductos.Update(DtsProductos, "Productos") 'Cargamos el dataset con los cambios en la bbdd.
            DtsProductos.AcceptChanges() 'Aceptamos los cambios.
            MsgBox("Borrado Correctamente", MsgBoxStyle.Information, "Producto Borrado") 'Mostramos un mensage informativo.
        Catch
            MsgBox("NO SE PUEDE BORRAR PORQUE EL DATO ESTA REFERENCIADO", MsgBoxStyle.Exclamation, "ERROR") 'Mostramos un mensaje de error.
        End Try
    End Sub

    Private Sub NuevoProducto_Click(sender As Object, e As EventArgs) Handles TsNuevoProducto.Click 'Metodo para crear un nuevo Producto.

        FrmNuevo = New AuxiliarProductos 'Creamos una variable con la conexion al formulario auxiliar.

        FrmNuevo.Text = "Nuevo Producto" 'Cambiamos el titulo del formulario auxiliar.
        If FrmNuevo.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.
            filaProductos = DtsProductos.Tables("Productos").NewRow 'Declaramos una row en blanco de la tabla Productos que va a estar guardada en filaProductos.
            LlenarFila(FrmNuevo) 'Llamamos al metodo LlenarFila.
            DtsProductos.Tables("Productos").Rows.Add(filaProductos) 'Añadimos la fila rellenada en el DataRow.
            DtaProductos.Update(DtsProductos, "Productos") 'Actualizamos la base de datos.
            DtsProductos.AcceptChanges() 'Aceptamos los cambios.

            CargarLoad()
        End If
    End Sub

    Public Sub LlenarFila(Frm As AuxiliarProductos) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaProductos.
        With Frm
            filaProductos("Nombre") = .TxtNombreProducto.Text
            filaProductos("Descripcion") = .TxtDescProducto.Text

        End With
    End Sub

    'Metodo para cuando clicamos en el boton AgregarComponentesDeProductos.
    Private Sub AgregarComponentesDeProductos_Click(sender As Object, e As EventArgs) Handles AgregarComponentesDeProductos.Click
        FrmProducto_Componente = New Producto_Componente 'Creamos el formulario.

        FrmProducto_Componente.Text = "Agregar Componente al Producto" 'Cambiamos el titulo del formulario.

        With FrmProducto_Componente
            .TxtIDProducto_C.TabStop = False 'No dejamos que el tabulador nos lleve a ese edittext.
            .TxtIDProducto_C.ReadOnly = True 'Bloqueamos el cuadro de texto de nombre en el formulario auxiliar para que no se pueda cambiar.
        End With

        PasarDatos() 'Llamamos al metodo PasarDatos.

        If FrmProducto_Componente.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.
            filaComponentesDeProducto = DtsComponentesDeProducto.Tables("ComponentesDeProducto").NewRow 'Declaramos una row en blanco de la tabla Clientes que va a estar guardada en filaClientes.
            LlenarFila(FrmProducto_Componente) 'Llamamos al metodo LlenarFila.
            DtsComponentesDeProducto.Tables("ComponentesDeProducto").Rows.Add(filaComponentesDeProducto) 'Añadimos la fila rellenada en el DataRow.

            DtaComponentesDeProducto.Update(DtsComponentesDeProducto, "ComponentesDeProducto") 'Actualizamos la base de datos.
            DtsComponentesDeProducto.AcceptChanges() 'Aceptamos los cambios.
        End If

        RecalcularPrecioPedido()

    End Sub

    Public Sub RecalcularPrecioPedido()
        Dim num As Integer

        If TxtIDProducto.Text <> "" = True Then
            num = CInt(TxtIDProducto.Text)
        End If

        'Realizamos el update del precio.
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim SQL As String
        myCommand.Connection = EmpresaMontaje.CnnEmpresaMontaje
        myAdapter.SelectCommand = myCommand
        SQL = "update productos set PrecioProducto = ((select sum(PrecioComponente) from Componentes c inner join ComponentesDeProducto cp on c.idComponentes = cp.Componentes_idComponentes and cp.Productos_idProductos = " & num & ")+150) where idProductos = " & num & ";"
        myCommand.CommandText = SQL
        myCommand.ExecuteNonQuery()
    End Sub

    'Metodo que pasa los datos de un cliente del formulario principal al auxiliar para que se muestren.
    Public Sub PasarDatos()
        With FrmProducto_Componente
            .TxtIDProducto_C.Text = TxtIDProducto.Text
        End With
    End Sub

    Public Sub LlenarFila(Frm As Producto_Componente) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaComponentesDeProducto.
        With Frm
            filaComponentesDeProducto("Productos_idProductos") = .TxtIDProducto_C.Text
            filaComponentesDeProducto("Componentes_idComponentes") = .CmbIDComponente_C.Text
        End With
    End Sub
End Class