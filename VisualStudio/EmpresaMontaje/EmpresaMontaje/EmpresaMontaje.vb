Imports MySql.Data.MySqlClient

Public Class EmpresaMontaje

    Public CnnEmpresaMontaje As MySqlConnection 'Declaramos una variable que va a contener la conexion a la bbdd.

    Dim FrmClientes As Clientes 'Declaramos una variable con la conexion al formulario.
    Dim FrmProveedores As Proveedores 'Declaramos una variable con la conexion al formulario.
    Dim FrmProductos As Productos 'Declaramos una variable con la conexion al formulario.
    Dim FrmComponentes As Componentes 'Declaramos una variable con la conexion al formulario.
    Dim FrmPedidosProveedores As PedidosProveedores 'Declaramos una variable con la conexion al formulario.
    Dim FrmPedidosClientes As PedidosClientes 'Declaramos una variable con la conexion al formulario.

    Private Sub EmpresaMontaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Nos conectamos a la bbdd.
        CnnEmpresaMontaje = New MySqlConnection("user id=root;password=abc123.;server=localhost;port=3307;database=empresademontaje")
    End Sub

    'Metodo para cuando clicamos en el boton Clientes.
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        FrmClientes = New Clientes 'Creamos el formulario.

        If FrmClientes.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub 'Salimos.
        End If
    End Sub

    'Metodo para cuando clicamos en el boton Proveedores.
    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        FrmProveedores = New Proveedores 'Creamos el formulario.

        If FrmProveedores.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub 'Salimos.
        End If
    End Sub

    'Metodo para cuando clicamos en el boton Productos.
    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        FrmProductos = New Productos 'Creamos el formulario.

        If FrmProductos.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub 'Salimos.
        End If
    End Sub

    'Metodo para cuando clicamos en el boton Componentes.
    Private Sub BtnComponentes_Click(sender As Object, e As EventArgs) Handles BtnComponentes.Click
        FrmComponentes = New Componentes 'Creamos el formulario.

        If FrmComponentes.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub 'Salimos.
        End If
    End Sub

    'Metodo para cuando clicamos en el boton PedidosProveedores.
    Private Sub BtnPedidosProveedores_Click(sender As Object, e As EventArgs) Handles BtnPedidosProveedores.Click
        FrmPedidosProveedores = New PedidosProveedores 'Creamos el formulario.

        If FrmPedidosProveedores.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub 'Salimos.
        End If
    End Sub

    'Metodo para cuando clicamos en el boton PedidosClientes.
    Private Sub BtnPedidosClientes_Click(sender As Object, e As EventArgs) Handles BtnPedidosClientes.Click
        FrmPedidosClientes = New PedidosClientes 'Creamos el formulario.

        If FrmPedidosClientes.ShowDialog = Windows.Forms.DialogResult.Cancel Then 'Condicion para cuando usuario pulsa calcelar.
            Exit Sub 'Salimos.
        End If
    End Sub
End Class
