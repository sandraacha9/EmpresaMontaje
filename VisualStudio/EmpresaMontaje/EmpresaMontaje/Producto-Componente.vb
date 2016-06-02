Imports MySql.Data.MySqlClient

Public Class Producto_Componente

    Dim DtaProducto_Componente As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Dim posicion As Integer 'Declaramos una variable para guardar la posicion marcada en el datagrid.

    Private Sub Producto_Componente_Load(sender As Object, e As EventArgs) Handles Me.Load 'Metodo que se ejecuta cuando cargas el formulario.

        EmpresaMontaje.CnnEmpresaMontaje.Close()
        EmpresaMontaje.CnnEmpresaMontaje.Open()

        DtaProducto_Componente = New MySqlDataAdapter("select * from Componentes", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaProducto_Componente.Fill(Componentes.DtsComponentes, "Componentes") 'Para guardar la consulta en la tabla "Componentes" del dataset.
        Dim CbProducto_Componente As New MySqlCommandBuilder(Componentes.DtaComponentes) 'Para poder realizar operaciones en la bbdd.
        EnlazarControles() 'Llamamos al metodo EnlazarControles.

    End Sub

    Public Sub EnlazarControles() 'Metodo para controlar los controles del formulario.

        'Enlazamos el texto del Txt con el campo indicado de la tabla del dataset indicado.
        CmbIDComponente_C.DataSource = Componentes.DtsComponentes.Tables("Componentes") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbIDComponente_C.DisplayMember = "idComponentes" 'Campo que quiero visualizar en el comboBox.
        DtgProductoComponente.DataSource = Componentes.DtsComponentes.Tables("Componentes") 'Tabla que quiero seleccionar para mostrar en la tabla.

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click 'Metodo para cuando clicamos en el boton aceptar.
        If TxtIDProducto_C.Text = "" Or CmbIDComponente_C.Text = "" Then 'Condicion para cuando falta alguno de estos datos.
            MsgBox("NO SE PUEDE GUARDAR", MsgBoxStyle.Exclamation, "FALTAN DATOS") 'Mostramos un mensaje de error.
            Exit Sub 'Salimos.
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK 'Le indicamos el valor del boton con su accion.
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click 'Metodo para cuando clicamos en el boton cancelar.
        Me.DialogResult = Windows.Forms.DialogResult.Cancel 'Le indicamos el valor del boton con su accion.
    End Sub
End Class