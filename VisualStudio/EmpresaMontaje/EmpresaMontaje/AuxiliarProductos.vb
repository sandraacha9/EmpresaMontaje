Imports MySql.Data.MySqlClient

Public Class AuxiliarProductos

    Dim DtaAuxiliarProductos As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsAuxiliarProductos As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaAuxiliarProductos As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmProducto_Componente As Producto_Componente 'Declaramos una variable con la conexion al formulario auxiliar.

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click 'Metodo para cuando clicamos en el boton aceptar.
        If TxtNombreProducto.Text = "" Then 'Condicion para cuando falta alguno de estos datos.
            MsgBox("FALTAN DATOS", MsgBoxStyle.Exclamation, "NO SE PUEDE GUARDAR") 'Mostramos un mensaje de error.
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK 'Le indicamos el valor del boton con su accion.
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click 'Metodo para cuando clicamos en el boton cancelar.
        Me.DialogResult = Windows.Forms.DialogResult.Cancel 'Le indicamos el valor del boton con su accion.
    End Sub

    Private Sub BtnAgregarComponente_Click(sender As Object, e As EventArgs)
        FrmProducto_Componente = New Producto_Componente 'Creamos él formulario.
        FrmProducto_Componente.Text = "Agregar Componente al Producto" 'Cambiamos el titulo del formulario.

        If FrmProducto_Componente.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.
            filaAuxiliarProductos = DtsAuxiliarProductos.Tables("ComponentesDeProducto").NewRow 'Declaramos una row en blanco de la tabla ComponentesDeProducto que va a estar guardada en filaClientes.
            LlenarFila(FrmProducto_Componente) 'Llamamos al metodo LlenarFila.
            DtsAuxiliarProductos.Tables("ComponentesDeProducto").Rows.Add(filaAuxiliarProductos) 'Añadimos la fila rellenada en el DataRow.
            DtaAuxiliarProductos.Update(DtsAuxiliarProductos, "ComponentesDeProducto") 'Actualizamos la base de datos.
            DtsAuxiliarProductos.AcceptChanges() 'Aceptamos los cambios.
        End If
    End Sub

    Public Sub LlenarFila(Frm As Producto_Componente) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaAuxiliarProductos.
        With Frm
            filaAuxiliarProductos("idProductos") = .TxtIDProducto_C.Text
            filaAuxiliarProductos("idComponentes") = .CmbIDComponente_C.Text
        End With
    End Sub
End Class