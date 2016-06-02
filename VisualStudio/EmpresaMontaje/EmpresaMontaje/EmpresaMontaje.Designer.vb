<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpresaMontaje
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpresaMontaje))
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnComponentes = New System.Windows.Forms.Button()
        Me.BtnPedidosClientes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPedidosProveedores = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClientes
        '
        Me.BtnClientes.Location = New System.Drawing.Point(12, 35)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(112, 83)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnProveedores
        '
        Me.BtnProveedores.Location = New System.Drawing.Point(12, 162)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(112, 83)
        Me.BtnProveedores.TabIndex = 1
        Me.BtnProveedores.Text = "Proveedores"
        Me.BtnProveedores.UseVisualStyleBackColor = True
        '
        'BtnProductos
        '
        Me.BtnProductos.Location = New System.Drawing.Point(409, 35)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(112, 83)
        Me.BtnProductos.TabIndex = 2
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = True
        '
        'BtnComponentes
        '
        Me.BtnComponentes.Location = New System.Drawing.Point(409, 162)
        Me.BtnComponentes.Name = "BtnComponentes"
        Me.BtnComponentes.Size = New System.Drawing.Size(112, 83)
        Me.BtnComponentes.TabIndex = 3
        Me.BtnComponentes.Text = "Componentes"
        Me.BtnComponentes.UseVisualStyleBackColor = True
        '
        'BtnPedidosClientes
        '
        Me.BtnPedidosClientes.Location = New System.Drawing.Point(153, 191)
        Me.BtnPedidosClientes.Name = "BtnPedidosClientes"
        Me.BtnPedidosClientes.Size = New System.Drawing.Size(112, 83)
        Me.BtnPedidosClientes.TabIndex = 4
        Me.BtnPedidosClientes.Text = "     Pedidos        Clientes"
        Me.BtnPedidosClientes.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(177, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 129)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BtnPedidosProveedores
        '
        Me.BtnPedidosProveedores.Location = New System.Drawing.Point(281, 191)
        Me.BtnPedidosProveedores.Name = "BtnPedidosProveedores"
        Me.BtnPedidosProveedores.Size = New System.Drawing.Size(112, 83)
        Me.BtnPedidosProveedores.TabIndex = 6
        Me.BtnPedidosProveedores.Text = "Pedidos Proveedores"
        Me.BtnPedidosProveedores.UseVisualStyleBackColor = True
        '
        'EmpresaMontaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 292)
        Me.Controls.Add(Me.BtnPedidosProveedores)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnPedidosClientes)
        Me.Controls.Add(Me.BtnComponentes)
        Me.Controls.Add(Me.BtnProductos)
        Me.Controls.Add(Me.BtnProveedores)
        Me.Controls.Add(Me.BtnClientes)
        Me.Name = "EmpresaMontaje"
        Me.Text = "Empresa De Montaje"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents BtnProveedores As System.Windows.Forms.Button
    Friend WithEvents BtnProductos As System.Windows.Forms.Button
    Friend WithEvents BtnComponentes As System.Windows.Forms.Button
    Friend WithEvents BtnPedidosClientes As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnPedidosProveedores As System.Windows.Forms.Button

End Class
