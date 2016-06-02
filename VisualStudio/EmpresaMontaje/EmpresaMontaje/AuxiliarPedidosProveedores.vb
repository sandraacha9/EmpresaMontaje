Imports MySql.Data.MySqlClient

Public Class AuxiliarPedidosProveedores

    Dim DtaAuxiliarPedidosProveedores As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.

    Private Sub AuxiliarPedidosProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DtaAuxiliarPedidosProveedores = New MySqlDataAdapter("select * from Proveedores", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaAuxiliarPedidosProveedores.Fill(Proveedores.DtsProveedores, "Proveedores") 'Para guardar la consulta en la tabla "Componentes" del dataset.

        CmbIDProveedores_P.DataSource = Proveedores.DtsProveedores.Tables("Proveedores") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbIDProveedores_P.DisplayMember = "idProveedor" 'Campo que quiero visualizar en el comboBox.

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click 'Metodo para cuando clicamos en el boton aceptar.
        If CmbIDProveedores_P.Text = "" Then 'Condicion para cuando falta alguno de estos datos.
            MsgBox("FALTAN DATOS", MsgBoxStyle.Exclamation, "NO SE PUEDE GUARDAR") 'Mostramos un mensaje de error.
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK 'Le indicamos el valor del boton con su accion.
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click 'Metodo para cuando clicamos en el boton cancelar.
        Me.DialogResult = Windows.Forms.DialogResult.Cancel 'Le indicamos el valor del boton con su accion.
    End Sub
End Class