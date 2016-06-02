Imports MySql.Data.MySqlClient

Public Class Componentes

    Public DtaComponentes As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsComponentes As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaComponentes As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmNuevo As AuxiliarComponentes 'Creamos una variable con la conexion al formulario auxiliar.
    Dim FrmModificar As AuxiliarComponentes 'Declaramos una variable con la conexion al formulario auxiliar.
    Dim posicion As Integer 'Declaramos una variable para guardar la posicion marcada en el datagrid.

    Private Sub Componentes_Load(sender As Object, e As EventArgs) Handles Me.Load 'Metodo que se ejecuta cuando cargas el formulario.
        CargarLoad()
        EnlazarControles() 'Llamamos al metodo EnlazarControles.
    End Sub

    Public Sub CargarLoad()
        DtaComponentes = New MySqlDataAdapter("select * from Componentes", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaComponentes.Fill(DtsComponentes, "Componentes") 'Para guardar la consulta en la tabla "Componentes" del dataset.
        Dim CbProveedores As New MySqlCommandBuilder(DtaComponentes) 'Para poder realizar operaciones en la bbdd.
    End Sub

    Public Sub EnlazarControles() 'Metodo para controlar los controles del formulario.

        'Enlazamos el texto del Txt con el campo indicado de la tabla del dataset indicado.
        TxtIDComponente.DataBindings.Add("Text", DtsComponentes.Tables("Componentes"), "idComponentes")
        TxtNombreComponente.DataBindings.Add("Text", DtsComponentes.Tables("Componentes"), "Nombre")
        TxtDescComponente.DataBindings.Add("Text", DtsComponentes.Tables("Componentes"), "Descripcion")
        TxtStock.DataBindings.Add("Text", DtsComponentes.Tables("Componentes"), "Stock")
        TxtStockMin.DataBindings.Add("Text", DtsComponentes.Tables("Componentes"), "StockMinimo")
        TxtPrecioComponente.DataBindings.Add("Text", DtsComponentes.Tables("Componentes"), "PrecioComponente")

        DtgComponentes.DataSource = DtsComponentes.Tables("Componentes") 'Tabla que quiero seleccionar para mostrar en la tabla.
        CmbNombreComponente.DataSource = DtsComponentes.Tables("Componentes") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbNombreComponente.DisplayMember = "Nombre" 'Campo que quiero visualizar en el comboBox.

    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles TsPrimero.Click 'Metodo para cuando se clica en el boton Primero.

        'Seleccionamos los campos de la fila de la primera posicion, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsComponentes.Tables("Componentes")).Position = 0

    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles TsAnterior.Click 'Metodo para cuando se clica en el boton Anterior.

        'Seleccionamos los campos de la fila de la posicion siguiente a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsComponentes.Tables("Componentes")).Position -= 1

    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles TsSiguiente.Click 'Metodo para cuando se clica en el boton Siguiente.

        'Seleccionamos los campos de la fila de la posicion anterior a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsComponentes.Tables("Componentes")).Position += 1

    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles TsUltimo.Click 'Metodo para cuando se clica en el boton Ultimo.

        'Seleccionamos los campos de la fila de la ultima posicion contando las filas menos 1 porque empieza en 0, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsComponentes.Tables("Componentes")).Position = DtsComponentes.Tables("Componentes").Rows.Count - 1

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles TsSalir.Click 'Metodo para salir de la aplicacion.
        Me.Close() 'Cerramos la aplicacion = formulario.
        End 'Terminamos.
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles TsBorrar.Click 'Metodo para borrar un Componente.
        'Condicion para las respuestas de un cuadro de mensaje, el mensaje muestra una exclamacion, dos mensajes y un boton aceptar y uno cancelar.
        If MsgBox("Desea borrar el Componente con id " & TxtIDComponente.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atencion") = MsgBoxResult.No Then 'Si le damos a enter es como si pulsaramos NO.
            Exit Sub 'Salimos del metodo.
        End If
        Try
            posicion = Me.BindingContext(DtsComponentes.Tables("Componentes")).Position 'Seleccionamos la posicion del enlace actual de Componentes = BindingContext.
            filaComponentes = DtsComponentes.Tables("Componentes").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.
            filaComponentes.Delete() 'Borramos la fila seleccionada del data set.
            DtaComponentes.Update(DtsComponentes, "Componentes") 'Cargamos el dataset con los cambios en la bbdd.
            DtsComponentes.AcceptChanges() 'Aceptamos los cambios.
            MsgBox("Borrado Correctamente", MsgBoxStyle.Information, "Componente Borrado") 'Mostramos un mensage informativo.
        Catch
            MsgBox("NO SE PUEDE BORRAR PORQUE EL DATO ESTA REFERENCIADO", MsgBoxStyle.Exclamation, "ERROR") 'Mostramos un mensaje de error.
        End Try
    End Sub

    Private Sub NuevoComponente_Click(sender As Object, e As EventArgs) Handles TsNuevoComponente.Click 'Metodo para crear un nuevo Componente.

        FrmNuevo = New AuxiliarComponentes 'Creamos una variable con la conexion al formulario auxiliar.

        FrmNuevo.Text = "Nuevo Componente" 'Cambiamos el titulo del formulario auxiliar.
        If FrmNuevo.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.
            filaComponentes = DtsComponentes.Tables("Componentes").NewRow 'Declaramos una row en blanco de la tabla Componentes que va a estar guardada en filaComponentes.
            LlenarFila(FrmNuevo) 'Llamamos al metodo LlenarFila.
            DtsComponentes.Tables("Componentes").Rows.Add(filaComponentes) 'Añadimos la fila rellenada en el DataRow.
            DtaComponentes.Update(DtsComponentes, "Componentes") 'Actualizamos la base de datos.
            DtsComponentes.AcceptChanges() 'Aceptamos los cambios.
        End If
        CargarLoad()
    End Sub

    Public Sub LlenarFila(Frm As AuxiliarComponentes) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaComponentes.
        With Frm
            filaComponentes("Nombre") = .TxtNombreComponente.Text
            filaComponentes("Descripcion") = .TxtDescComponente.Text
            filaComponentes("Stock") = .TxtStock.Text
            filaComponentes("StockMinimo") = .TxtStockMin.Text
            filaComponentes("PrecioComponente") = .TxtPrecioComponente.Text

        End With
    End Sub
End Class