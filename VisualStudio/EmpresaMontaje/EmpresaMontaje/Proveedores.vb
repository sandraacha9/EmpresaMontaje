Imports MySql.Data.MySqlClient

Public Class Proveedores

    Dim DtaProveedores As MySqlDataAdapter 'Declaramos una variable con un adaptador de la bbdd, para poder acceder a los datos de una tabla de la bbdd.
    Public DtsProveedores As New DataSet 'Subconjunto que almacena datos de la bbdd que vamos a necesitar. Public para poder referenciarlo desde cualquier formulario del proyecto.
    Dim filaProveedores As DataRow 'Creamos una variable para contener datos de una fila de la bbdd.
    Dim FrmNuevo As AuxiliarProveedores 'Creamos una variable con la conexion al formulario auxiliar.
    Dim FrmModificar As AuxiliarProveedores 'Declaramos una variable con la conexion al formulario auxiliar.
    Dim posicion As Integer 'Declaramos una variable para guardar la posicion marcada en el datagrid.

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles Me.Load 'Metodo que se ejecuta cuando cargas el formulario.
        CargarLoad()
        EnlazarControles() 'Llamamos al metodo EnlazarControles.
    End Sub

    Public Sub CargarLoad()
        DtaProveedores = New MySqlDataAdapter("select * from Proveedores", EmpresaMontaje.CnnEmpresaMontaje) 'Guardamos la consulta que queremos realizar en la base de datos.
        DtaProveedores.Fill(DtsProveedores, "Proveedores") 'Para guardar la consulta en la tabla "Proveedores" del dataset.
        Dim CbProveedores As New MySqlCommandBuilder(DtaProveedores) 'Para poder realizar operaciones en la bbdd.
    End Sub

    Public Sub EnlazarControles() 'Metodo para controlar los controles del formulario.

        'Enlazamos el texto del Txt con el campo indicado de la tabla del dataset indicado.
        TxtIDProveedor.DataBindings.Add("Text", DtsProveedores.Tables("Proveedores"), "idProveedor")
        TxtNombreProveedor.DataBindings.Add("Text", DtsProveedores.Tables("Proveedores"), "NombreProveedor")
        TxtTelefProveedor.DataBindings.Add("Text", DtsProveedores.Tables("Proveedores"), "TelefonoProveedor")
        TxtNombreEmpresa.DataBindings.Add("Text", DtsProveedores.Tables("Proveedores"), "NombreEmpresa")
        TxtTelefEmpresa.DataBindings.Add("Text", DtsProveedores.Tables("Proveedores"), "TelefonoEmpresa")
        TxtDirEmpresa.DataBindings.Add("Text", DtsProveedores.Tables("Proveedores"), "DireccionEmpresa")
        TxtEmailEmpresa.DataBindings.Add("Text", DtsProveedores.Tables("Proveedores"), "CorreoElectronicoEmpresa")

        DtgProveedores.DataSource = DtsProveedores.Tables("Proveedores") 'Tabla que quiero seleccionar para mostrar en la tabla.
        CmbNombreProveedor.DataSource = DtsProveedores.Tables("Proveedores") 'Tabla que quiero seleccionar para mostrar en el combobox.
        CmbNombreProveedor.DisplayMember = "NombreProveedor" 'Campo que quiero visualizar en el comboBox.

    End Sub

    Private Sub Primero_Click(sender As Object, e As EventArgs) Handles TsPrimero.Click 'Metodo para cuando se clica en el boton Primero.

        'Seleccionamos los campos de la fila de la primera posicion, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsProveedores.Tables("Proveedores")).Position = 0

    End Sub

    Private Sub Anterior_Click(sender As Object, e As EventArgs) Handles TsAnterior.Click 'Metodo para cuando se clica en el boton Anterior.

        'Seleccionamos los campos de la fila de la posicion siguiente a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsProveedores.Tables("Proveedores")).Position -= 1

    End Sub

    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles TsSiguiente.Click 'Metodo para cuando se clica en el boton Siguiente.

        'Seleccionamos los campos de la fila de la posicion anterior a la actual, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsProveedores.Tables("Proveedores")).Position += 1

    End Sub

    Private Sub Ultimo_Click(sender As Object, e As EventArgs) Handles TsUltimo.Click 'Metodo para cuando se clica en el boton Ultimo.

        'Seleccionamos los campos de la fila de la ultima posicion contando las filas menos 1 porque empieza en 0, cambiando la seleccion DataBildings.
        Me.BindingContext(DtsProveedores.Tables("Proveedores")).Position = DtsProveedores.Tables("Proveedores").Rows.Count - 1

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles TsSalir.Click 'Metodo para salir de la aplicacion.
        Me.Close() 'Cerramos la aplicacion = formulario.
        End 'Terminamos.
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles TsBorrar.Click 'Metodo para borrar un proveedor.
        'Condicion para las respuestas de un cuadro de mensaje, el mensaje muestra una exclamacion, dos mensajes y un boton aceptar y uno cancelar.
        If MsgBox("Desea borrar el Proveedor con id " & TxtIDProveedor.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Atencion") = MsgBoxResult.No Then 'Si le damos a enter es como si pulsaramos NO.
            Exit Sub 'Salimos del metodo.
        End If
        Try
            posicion = Me.BindingContext(DtsProveedores.Tables("Proveedores")).Position 'Seleccionamos la posicion del enlace actual de Proveedores = BindingContext.
            filaProveedores = DtsProveedores.Tables("Proveedores").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.
            filaProveedores.Delete() 'Borramos la fila seleccionada del data set.
            DtaProveedores.Update(DtsProveedores, "Proveedores") 'Cargamos el dataset con los cambios en la bbdd.
            DtsProveedores.AcceptChanges() 'Aceptamos los cambios.
            MsgBox("Borrado Correctamente", MsgBoxStyle.Information, "Proveedor Borrado") 'Mostramos un mensage informativo.
        Catch
            MsgBox("NO SE PUEDE BORRAR PORQUE EL DATO ESTA REFERENCIADO", MsgBoxStyle.Exclamation, "ERROR") 'Mostramos un mensaje de error.
        End Try
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles TsModificar.Click 'Metodo para modificar los datos del Proveedor.

        FrmModificar = New AuxiliarProveedores 'Creamos una variable con la conexion al formulario auxiliar.

        With FrmModificar
            .Text = "Modificar Proveedor" 'Cambiamos el titulo del formulario auxiliar.
            .TxtNombreProveedor.TabStop = False 'No dejamos que el tabulador nos lleve a ese edittext.
            .TxtNombreProveedor.ReadOnly = True 'Bloqueamos el cuadro de texto de id en el formulario auxiliar para que no se pueda cambiar.
            .TxtNombreEmpresa.TabStop = False 'No dejamos que el tabulador nos lleve a ese edittext.
            .TxtNombreEmpresa.ReadOnly = True 'Bloqueamos el cuadro de texto de nombre en el formulario auxiliar para que no se pueda cambiar.
        End With

        PasarDatos() 'Llamamos al metodo PasarDatos.

        If FrmModificar.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        End If

        posicion = Me.BindingContext(DtsProveedores.Tables("Proveedores")).Position 'Seleccionamos las tablas de la bbdd y guardamos su posicion.
        filaProveedores = DtsProveedores.Tables("Proveedores").Rows(posicion) 'Seleccionamos la fila que tiene esa posicion.

        filaProveedores.BeginEdit() 'Le indicamos que comenzamos a editar.
        LlenarFila(FrmModificar) 'Llamamos al metodo LlenarFila.
        filaProveedores.EndEdit() 'Le indicamos que terminamos de editar.

        DtaProveedores.Update(DtsProveedores, "Proveedores") 'Actualizamos.
        DtsProveedores.AcceptChanges() 'Aceptamos los cambios.

    End Sub

    'Metodo que pasa los datos de un proveedor del formulario principal al auxiliar para que se muestren.
    Public Sub PasarDatos()
        With FrmModificar
            .TxtNombreProveedor.Text = TxtNombreProveedor.Text
            .TxtTelefProveedor.Text = TxtTelefProveedor.Text
            .TxtNombreEmpresa.Text = TxtNombreEmpresa.Text
            .TxtTelefEmpresa.Text = TxtTelefEmpresa.Text
            .TxtDirEmpresa.Text = TxtDirEmpresa.Text
            .TxtEmailEmpresa.Text = TxtEmailEmpresa.Text
        End With
    End Sub

    Private Sub NuevoProveedor_Click(sender As Object, e As EventArgs) Handles TsNuevoProveedor.Click 'Metodo para crear un nuevo Proveedor.

        FrmNuevo = New AuxiliarProveedores 'Creamos una variable con la conexion al formulario auxiliar.

        FrmNuevo.Text = "Nuevo Proveedor" 'Cambiamos el titulo del formulario auxiliar.
        FrmNuevo.TxtNombreProveedor.ReadOnly = False 'Cambiamos la propiedad del textBox de nombre para que permita escribir.
        FrmNuevo.TxtNombreEmpresa.ReadOnly = False 'Cambiamos la propiedad del textBox de dni para que permita escribir.

        If FrmNuevo.ShowDialog = Windows.Forms.DialogResult.Cancel = True Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub
        Else 'Si pulsa aceptar.
            filaProveedores = DtsProveedores.Tables("Proveedores").NewRow 'Declaramos una row en blanco de la tabla Proveedores que va a estar guardada en filaProveedores.
            LlenarFila(FrmNuevo) 'Llamamos al metodo LlenarFila.
            DtsProveedores.Tables("Proveedores").Rows.Add(filaProveedores) 'Añadimos la fila rellenada en el DataRow.
            DtaProveedores.Update(DtsProveedores, "Proveedores") 'Actualizamos la base de datos.
            DtsProveedores.AcceptChanges() 'Aceptamos los cambios.
        End If
        CargarLoad()
    End Sub

    Public Sub LlenarFila(Frm As AuxiliarProveedores) 'Metodo que va a rellenar una row con los datos correspondientes.
        'Recojemos los valores de los textView y lo guardamos en filaProveedores.
        With Frm
            filaProveedores("NombreProveedor") = .TxtNombreProveedor.Text
            filaProveedores("TelefonoProveedor") = .TxtTelefProveedor.Text
            filaProveedores("NombreEmpresa") = .TxtNombreEmpresa.Text
            filaProveedores("TelefonoEmpresa") = .TxtTelefEmpresa.Text
            filaProveedores("DireccionEmpresa") = .TxtDirEmpresa.Text
            filaProveedores("CorreoElectronicoEmpresa") = .TxtEmailEmpresa.Text

        End With
    End Sub
End Class