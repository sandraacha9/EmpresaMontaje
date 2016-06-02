Imports MySql.Data.MySqlClient

Public Class Clientes

    Dim DtaClientes As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsClientes As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaClientes As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmNuevo As AuxiliarClientes 'Creamos una variable con la conexion al formulario auxiliar.
    Dim FrmModificar As AuxiliarClientes 'Declaramos una variable con la conexion al formulario auxiliar.
    Dim posicion As Integer 'Declaramos una variable para guardar la posicion marcada en el datagrid.

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles Me.Load 'Metodo que se ejecuta cuando cargas el formulario.
        CargarLoad()
        EnlazarControles() 'Llamamos al metodo EnlazarControles.
    End Sub

    Private Sub CargarLoad()
        DtaClientes = New MySqlDataAdapter("select * from clientes", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaClientes.Fill(DtsClientes, "clientes") 'Para guardar la consulta en la tabla "Clientes" del dataset.
        Dim CbClientes As New MySqlCommandBuilder(DtaClientes) 'Para poder realizar operaciones en la bbdd.
    End Sub

    Public Sub EnlazarControles() 'Metodo para controlar los controles del formulario.

        'Enlazamos el texto del Txt con el campo indicado de la tabla del dataset indicado.
        TxtIDCliente.DataBindings.Add("Text", DtsClientes.Tables("Clientes"), "idClientes")
        TxtDNICliente.DataBindings.Add("Text", DtsClientes.Tables("Clientes"), "Dni")
        TxtNombreCiente.DataBindings.Add("Text", DtsClientes.Tables("Clientes"), "Nombre")
        TxtApellidosCliente.DataBindings.Add("Text", DtsClientes.Tables("Clientes"), "Apellidos")
        TxtTelefonoFijo.DataBindings.Add("Text", DtsClientes.Tables("Clientes"), "TelefonoFijo")
        TxtTelefonoMovil.DataBindings.Add("Text", DtsClientes.Tables("Clientes"), "TelefonoMovil")
        TxtDirCliente.DataBindings.Add("Text", DtsClientes.Tables("Clientes"), "Direccion")
        TxtEmailCliente.DataBindings.Add("Text", DtsClientes.Tables("Clientes"), "CorreoElectronico")

        DtgClientes.DataSource = DtsClientes.Tables("Clientes") 'Tabla que quiero seleccionar para mostrar en la tabla.
        CmbDNICliente.DataSource = DtsClientes.Tables("Clientes") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbDNICliente.DisplayMember = "Dni" 'Campo que quiero visualizar en el comboBox.

    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles TsPrimero.Click 'Metodo para cuando se clica en el boton Primero.

        'Seleccionamos los campos de la fila de la primera posicion, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsClientes.Tables("Clientes")).Position = 0

    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles TsAnterior.Click 'Metodo para cuando se clica en el boton Anterior.

        'Seleccionamos los campos de la fila de la posicion siguiente a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsClientes.Tables("Clientes")).Position -= 1

    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles TsSiguiente.Click 'Metodo para cuando se clica en el boton Siguiente.

        'Seleccionamos los campos de la fila de la posicion anterior a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsClientes.Tables("Clientes")).Position += 1

    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles TsUltimo.Click 'Metodo para cuando se clica en el boton Ultimo.

        'Seleccionamos los campos de la fila de la ultima posicion contando las filas menos 1 porque empieza en 0, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsClientes.Tables("Clientes")).Position = DtsClientes.Tables("Clientes").Rows.Count - 1

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles TsSalir.Click 'Metodo para salir de la aplicacion.
        Me.Close() 'Cerramos la aplicacion = formulario.
        End 'Terminamos.
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles TsBorrar.Click 'Metodo para borrar un cliente.
        'Condicion para las respuestas de un cuadro de mensaje, el mensaje muestra una exclamacion, dos mensajes y un boton aceptar y uno cancelar.
        If MsgBox("Desea borrar el cliente con id " & TxtIDCliente.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atencion") = MsgBoxResult.No Then 'Si le damos a enter es como si pulsaramos NO.
            Exit Sub 'Salimos del metodo.
        End If
        Try
            posicion = Me.BindingContext(DtsClientes.Tables("Clientes")).Position 'Seleccionamos la posicion del enlace actual de Clientes = BindingContext.
            filaClientes = DtsClientes.Tables("Clientes").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.
            filaClientes.Delete() 'Borramos la fila seleccionada del data set.
            DtaClientes.Update(DtsClientes, "Clientes") 'Cargamos el dataset con los cambios en la bbdd.
            DtsClientes.AcceptChanges() 'Aceptamos los cambios.
            MsgBox("Borrado Correctamente", MsgBoxStyle.Information, "Cliente Borrado") 'Mostramos un mensage informativo.
        Catch
            MsgBox("NO SE PUEDE BORRAR PORQUE EL DATO ESTA REFERENCIADO", MsgBoxStyle.Exclamation, "ERROR") 'Mostramos un mensaje de error.
        End Try
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles TsModificar.Click 'Metodo para modificar los datos del cliente.

        FrmModificar = New AuxiliarClientes 'Creamos una variable con la conexion al formulario auxiliar.

        With FrmModificar
            .Text = "Modificar cliente" 'Cambiamos el titulo del formulario auxiliar.
            .TxtNombreCiente.TabStop = False 'No dejamos que el tabulador nos lleve a ese edittext.
            .TxtNombreCiente.ReadOnly = True 'Bloqueamos el cuadro de texto de nombre en el formulario auxiliar para que no se pueda cambiar.
            .TxtDNICliente.TabStop = False 'No dejamos que el tabulador nos lleve a ese edittext.
            .TxtDNICliente.ReadOnly = True 'Bloqueamos el cuadro de texto de dni en el formulario auxiliar para que no se pueda cambiar.
        End With

        PasarDatos() 'Llamamos al metodo PasarDatos.

        If FrmModificar.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        End If

        posicion = Me.BindingContext(DtsClientes.Tables("Clientes")).Position 'Seleccionamos las tablas de la bbdd y guardamos su posicion.
        filaClientes = DtsClientes.Tables("Clientes").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.

        filaClientes.BeginEdit() 'Le indicamos que comenzamos a editar.
        LlenarFila(FrmModificar) 'Llamamos al metodo LlenarFila.
        filaClientes.EndEdit() 'Le indicamos que terminamos de editar.

        DtaClientes.Update(DtsClientes, "Clientes") 'Actualizamos.
        DtsClientes.AcceptChanges() 'Aceptamos los cambios.

    End Sub

    'Metodo que pasa los datos de un cliente del formulario principal al auxiliar para que se muestren.
    Public Sub PasarDatos()
        With FrmModificar
            .TxtNombreCiente.Text = TxtNombreCiente.Text
            .TxtDNICliente.Text = TxtDNICliente.Text
            .TxtApellidosCliente.Text = TxtApellidosCliente.Text
            .TxtTelefonoFijo.Text = TxtTelefonoFijo.Text
            .TxtTelefonoMovil.Text = TxtTelefonoMovil.Text
            .TxtDirCliente.Text = TxtDirCliente.Text
            .TxtEmailCliente.Text = TxtEmailCliente.Text
        End With
    End Sub

    Private Sub NuevoCliente_Click(sender As Object, e As EventArgs) Handles TsNuevoCliente.Click 'Metodo para crear un nuevo Cliente.

        FrmNuevo = New AuxiliarClientes 'Creamos una variable con la conexion al formulario auxiliar.

        FrmNuevo.Text = "Nuevo Cliente" 'Cambiamos el titulo del formulario auxiliar.
        FrmNuevo.TxtNombreCiente.ReadOnly = False 'Cambiamos la propiedad del textBox de nombre para que permita escribir.
        FrmNuevo.TxtDNICliente.ReadOnly = False 'Cambiamos la propiedad del textBox de dni para que permita escribir.
        FrmNuevo.TxtApellidosCliente.ReadOnly = False 'Cambiamos la propiedad del textBox de apellidos para que permita escribir.

        If FrmNuevo.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.
            filaClientes = DtsClientes.Tables("Clientes").NewRow 'Declaramos una row en blanco de la tabla Clientes que va a estar guardada en filaClientes.
            LlenarFila(FrmNuevo) 'Llamamos al metodo LlenarFila.
            DtsClientes.Tables("Clientes").Rows.Add(filaClientes) 'Añadimos la fila rellenada en el DataRow.
            DtaClientes.Update(DtsClientes, "Clientes") 'Actualizamos la base de datos.
            DtsClientes.AcceptChanges() 'Aceptamos los cambios.
        End If
        CargarLoad()
    End Sub

    Public Sub LlenarFila(Frm As AuxiliarClientes) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaClientes.
        With Frm
            filaClientes("Nombre") = .TxtNombreCiente.Text
            filaClientes("Dni") = .TxtDNICliente.Text
            filaClientes("Apellidos") = .TxtApellidosCliente.Text
            filaClientes("TelefonoFijo") = .TxtTelefonoFijo.Text
            filaClientes("TelefonoMovil") = .TxtTelefonoMovil.Text
            filaClientes("Direccion") = .TxtDirCliente.Text
            filaClientes("CorreoElectronico") = .TxtEmailCliente.Text

        End With
    End Sub
End Class