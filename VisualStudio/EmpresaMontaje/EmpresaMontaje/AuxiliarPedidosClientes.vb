Imports MySql.Data.MySqlClient

Public Class AuxiliarPedidosClientes

    Dim DtaAuxiliarPedidosClientes As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.

    Private Sub AuxiliarPedidosClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DtaAuxiliarPedidosClientes = New MySqlDataAdapter("select * from Clientes", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaAuxiliarPedidosClientes.Fill(Clientes.DtsClientes, "Clientes") 'Para guardar la consulta en la tabla "Componentes" del dataset.

        CmbIDCientes_C.DataSource = Clientes.DtsClientes.Tables("Clientes") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbIDCientes_C.DisplayMember = "idClientes" 'Campo que quiero visualizar en el comboBox.

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click 'Metodo para cuando clicamos en el boton aceptar.
        If CmbIDCientes_C.Text = "" Then 'Condicion para cuando falta alguno de estos datos.
            MsgBox("FALTAN DATOS", MsgBoxStyle.Exclamation, "NO SE PUEDE GUARDAR") 'Mostramos un mensaje de error.
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK 'Le indicamos el valor del boton con su accion.
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click 'Metodo para cuando clicamos en el boton cancelar.
        Me.DialogResult = Windows.Forms.DialogResult.Cancel 'Le indicamos el valor del boton con su accion.
    End Sub
End Class