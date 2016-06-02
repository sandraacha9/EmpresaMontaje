Imports MySql.Data.MySqlClient

Public Class LineaDePedidoProveedores

    Dim DtaComponentesDeProducto As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Dim filaComponentesDeProducto As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.

    Private Sub LineasPedidosProveedores_Load(sender As Object, e As EventArgs) Handles Me.Load 'Metodo que se ejecuta cuando cargas el formulario.

        EmpresaMontaje.CnnEmpresaMontaje.Close()
        EmpresaMontaje.CnnEmpresaMontaje.Open()

        DtaComponentesDeProducto = New MySqlDataAdapter("select * from Componentes", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaComponentesDeProducto.Fill(Componentes.DtsComponentes, "Componentes") 'Para guardar la consulta en la tabla "Componentes" del dataset.
        Dim CbComponentesDeProducto As New MySqlCommandBuilder(DtaComponentesDeProducto) 'Para poder realizar operaciones en la bbdd.
        EnlazarControles() 'Llamamos al metodo EnlazarControles.

    End Sub

    Public Sub EnlazarControles() 'Metodo para controlar los controles del formulario.

        'Enlazamos el texto del Txt con el campo indicado de la tabla del dataset indicado.
        CmbIDComponentes_C.DataSource = Componentes.DtsComponentes.Tables("Componentes") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbIDComponentes_C.DisplayMember = "idComponentes" 'Campo que quiero visualizar en el comboBox.
        DtgComponentes.DataSource = Componentes.DtsComponentes.Tables("Componentes") 'Tabla que quiero seleccionar para mostrar en la tabla.

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click 'Metodo para cuando clicamos en el boton aceptar.
        If TxtIDPedidoProveedorEx.Text = "" Or TxtCantidad.Text = "" Or CmbIDComponentes_C.Text = "" Then 'Condicion para cuando falta alguno de estos datos.
            MsgBox("NO SE PUEDE GUARDAR", MsgBoxStyle.Exclamation, "FALTAN DATOS") 'Mostramos un mensaje de error.
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK 'Le indicamos el valor del boton con su accion.
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click 'Metodo para cuando clicamos en el boton cancelar.
        Me.DialogResult = Windows.Forms.DialogResult.Cancel 'Le indicamos el valor del boton con su accion.
    End Sub
End Class