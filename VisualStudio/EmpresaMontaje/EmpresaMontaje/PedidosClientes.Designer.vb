<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PedidosClientes))
        Me.TsClientes = New System.Windows.Forms.ToolStrip()
        Me.TsNuevoPedidoCliente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsPrimero = New System.Windows.Forms.ToolStripButton()
        Me.TsAnterior = New System.Windows.Forms.ToolStripButton()
        Me.TsSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.TsUltimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsInforme = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbIDPedidoCliente = New System.Windows.Forms.ComboBox()
        Me.DtgPedidosClientes = New System.Windows.Forms.DataGridView()
        Me.TxtIDPedidoCliente = New System.Windows.Forms.TextBox()
        Me.IDProveedor = New System.Windows.Forms.Label()
        Me.TxtIDCliente = New System.Windows.Forms.TextBox()
        Me.TxtPrecioTotPedidoCliente = New System.Windows.Forms.TextBox()
        Me.TxtFechaInicioPedido = New System.Windows.Forms.TextBox()
        Me.PrecioTotPedido = New System.Windows.Forms.Label()
        Me.ClienteID = New System.Windows.Forms.Label()
        Me.FechaInicioPedido = New System.Windows.Forms.Label()
        Me.TxtEstado = New System.Windows.Forms.TextBox()
        Me.TxtFechaFinPedido = New System.Windows.Forms.TextBox()
        Me.FechaFinPedido = New System.Windows.Forms.Label()
        Me.EstadoPedido = New System.Windows.Forms.Label()
        Me.AgregarLineasDePedidosClientes = New System.Windows.Forms.Button()
        Me.DtgLineaPedidosClientes = New System.Windows.Forms.DataGridView()
        Me.BtnTerminarLinea = New System.Windows.Forms.Button()
        Me.BtnEnviarPedido = New System.Windows.Forms.Button()
        Me.TsClientes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgPedidosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgLineaPedidosClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TsClientes
        '
        Me.TsClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevoPedidoCliente, Me.ToolStripSeparator1, Me.TsPrimero, Me.TsAnterior, Me.TsSiguiente, Me.TsUltimo, Me.ToolStripSeparator2, Me.TsInforme, Me.ToolStripSeparator3, Me.TsSalir})
        Me.TsClientes.Location = New System.Drawing.Point(0, 0)
        Me.TsClientes.Name = "TsClientes"
        Me.TsClientes.Size = New System.Drawing.Size(1000, 25)
        Me.TsClientes.TabIndex = 93
        Me.TsClientes.Text = "ToolStrip1"
        '
        'TsNuevoPedidoCliente
        '
        Me.TsNuevoPedidoCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsNuevoPedidoCliente.Image = CType(resources.GetObject("TsNuevoPedidoCliente.Image"), System.Drawing.Image)
        Me.TsNuevoPedidoCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevoPedidoCliente.Name = "TsNuevoPedidoCliente"
        Me.TsNuevoPedidoCliente.Size = New System.Drawing.Size(23, 22)
        Me.TsNuevoPedidoCliente.Text = "Nuevo Pedido Cliente"
        Me.TsNuevoPedidoCliente.ToolTipText = "Añadir un pedido nuevo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsPrimero
        '
        Me.TsPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsPrimero.Image = CType(resources.GetObject("TsPrimero.Image"), System.Drawing.Image)
        Me.TsPrimero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsPrimero.Name = "TsPrimero"
        Me.TsPrimero.Size = New System.Drawing.Size(23, 22)
        Me.TsPrimero.Text = "Primero"
        Me.TsPrimero.ToolTipText = "Ir al primer pedido"
        '
        'TsAnterior
        '
        Me.TsAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsAnterior.Image = CType(resources.GetObject("TsAnterior.Image"), System.Drawing.Image)
        Me.TsAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsAnterior.Name = "TsAnterior"
        Me.TsAnterior.Size = New System.Drawing.Size(23, 22)
        Me.TsAnterior.Text = "Anterior"
        Me.TsAnterior.ToolTipText = "Ir al pedido anterior"
        '
        'TsSiguiente
        '
        Me.TsSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsSiguiente.Image = CType(resources.GetObject("TsSiguiente.Image"), System.Drawing.Image)
        Me.TsSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSiguiente.Name = "TsSiguiente"
        Me.TsSiguiente.Size = New System.Drawing.Size(23, 22)
        Me.TsSiguiente.Text = "Siguiente"
        Me.TsSiguiente.ToolTipText = "Ir al siguiente pedido"
        '
        'TsUltimo
        '
        Me.TsUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsUltimo.Image = CType(resources.GetObject("TsUltimo.Image"), System.Drawing.Image)
        Me.TsUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsUltimo.Name = "TsUltimo"
        Me.TsUltimo.Size = New System.Drawing.Size(23, 22)
        Me.TsUltimo.Text = "Ultimo"
        Me.TsUltimo.ToolTipText = "Ir al ultimo pedido"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TsInforme
        '
        Me.TsInforme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsInforme.Image = CType(resources.GetObject("TsInforme.Image"), System.Drawing.Image)
        Me.TsInforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsInforme.Name = "TsInforme"
        Me.TsInforme.Size = New System.Drawing.Size(23, 22)
        Me.TsInforme.Text = "Informe Pedidos Clientes"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TsSalir
        '
        Me.TsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsSalir.Image = CType(resources.GetObject("TsSalir.Image"), System.Drawing.Image)
        Me.TsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSalir.Name = "TsSalir"
        Me.TsSalir.Size = New System.Drawing.Size(23, 22)
        Me.TsSalir.Text = "Salir"
        Me.TsSalir.ToolTipText = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbIDPedidoCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(413, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 62)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Pedido Cliente"
        '
        'CmbIDPedidoCliente
        '
        Me.CmbIDPedidoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIDPedidoCliente.FormattingEnabled = True
        Me.CmbIDPedidoCliente.Location = New System.Drawing.Point(16, 28)
        Me.CmbIDPedidoCliente.Name = "CmbIDPedidoCliente"
        Me.CmbIDPedidoCliente.Size = New System.Drawing.Size(121, 21)
        Me.CmbIDPedidoCliente.TabIndex = 0
        '
        'DtgPedidosClientes
        '
        Me.DtgPedidosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgPedidosClientes.Location = New System.Drawing.Point(14, 275)
        Me.DtgPedidosClientes.Name = "DtgPedidosClientes"
        Me.DtgPedidosClientes.ReadOnly = True
        Me.DtgPedidosClientes.Size = New System.Drawing.Size(552, 148)
        Me.DtgPedidosClientes.TabIndex = 91
        '
        'TxtIDPedidoCliente
        '
        Me.TxtIDPedidoCliente.Location = New System.Drawing.Point(154, 30)
        Me.TxtIDPedidoCliente.MaxLength = 50
        Me.TxtIDPedidoCliente.Name = "TxtIDPedidoCliente"
        Me.TxtIDPedidoCliente.ReadOnly = True
        Me.TxtIDPedidoCliente.Size = New System.Drawing.Size(232, 20)
        Me.TxtIDPedidoCliente.TabIndex = 90
        '
        'IDProveedor
        '
        Me.IDProveedor.Location = New System.Drawing.Point(11, 33)
        Me.IDProveedor.Name = "IDProveedor"
        Me.IDProveedor.Size = New System.Drawing.Size(117, 13)
        Me.IDProveedor.TabIndex = 89
        Me.IDProveedor.Text = "ID:"
        '
        'TxtIDCliente
        '
        Me.TxtIDCliente.Location = New System.Drawing.Point(154, 189)
        Me.TxtIDCliente.MaxLength = 25
        Me.TxtIDCliente.Name = "TxtIDCliente"
        Me.TxtIDCliente.ReadOnly = True
        Me.TxtIDCliente.Size = New System.Drawing.Size(232, 20)
        Me.TxtIDCliente.TabIndex = 88
        '
        'TxtPrecioTotPedidoCliente
        '
        Me.TxtPrecioTotPedidoCliente.Location = New System.Drawing.Point(154, 157)
        Me.TxtPrecioTotPedidoCliente.MaxLength = 50
        Me.TxtPrecioTotPedidoCliente.Name = "TxtPrecioTotPedidoCliente"
        Me.TxtPrecioTotPedidoCliente.ReadOnly = True
        Me.TxtPrecioTotPedidoCliente.Size = New System.Drawing.Size(232, 20)
        Me.TxtPrecioTotPedidoCliente.TabIndex = 87
        '
        'TxtFechaInicioPedido
        '
        Me.TxtFechaInicioPedido.Location = New System.Drawing.Point(154, 60)
        Me.TxtFechaInicioPedido.MaxLength = 50
        Me.TxtFechaInicioPedido.Name = "TxtFechaInicioPedido"
        Me.TxtFechaInicioPedido.ReadOnly = True
        Me.TxtFechaInicioPedido.Size = New System.Drawing.Size(232, 20)
        Me.TxtFechaInicioPedido.TabIndex = 86
        '
        'PrecioTotPedido
        '
        Me.PrecioTotPedido.Location = New System.Drawing.Point(11, 157)
        Me.PrecioTotPedido.Name = "PrecioTotPedido"
        Me.PrecioTotPedido.Size = New System.Drawing.Size(126, 13)
        Me.PrecioTotPedido.TabIndex = 85
        Me.PrecioTotPedido.Text = "Precio Total del Pedido:"
        '
        'ClienteID
        '
        Me.ClienteID.Location = New System.Drawing.Point(11, 189)
        Me.ClienteID.Name = "ClienteID"
        Me.ClienteID.Size = New System.Drawing.Size(117, 13)
        Me.ClienteID.TabIndex = 84
        Me.ClienteID.Text = "ID del Cliente:"
        '
        'FechaInicioPedido
        '
        Me.FechaInicioPedido.Location = New System.Drawing.Point(11, 63)
        Me.FechaInicioPedido.Name = "FechaInicioPedido"
        Me.FechaInicioPedido.Size = New System.Drawing.Size(117, 13)
        Me.FechaInicioPedido.TabIndex = 83
        Me.FechaInicioPedido.Text = "Fecha Inicio Pedido:"
        '
        'TxtEstado
        '
        Me.TxtEstado.Location = New System.Drawing.Point(154, 128)
        Me.TxtEstado.MaxLength = 25
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.ReadOnly = True
        Me.TxtEstado.Size = New System.Drawing.Size(232, 20)
        Me.TxtEstado.TabIndex = 97
        '
        'TxtFechaFinPedido
        '
        Me.TxtFechaFinPedido.Location = New System.Drawing.Point(154, 96)
        Me.TxtFechaFinPedido.MaxLength = 50
        Me.TxtFechaFinPedido.Name = "TxtFechaFinPedido"
        Me.TxtFechaFinPedido.ReadOnly = True
        Me.TxtFechaFinPedido.Size = New System.Drawing.Size(232, 20)
        Me.TxtFechaFinPedido.TabIndex = 96
        '
        'FechaFinPedido
        '
        Me.FechaFinPedido.Location = New System.Drawing.Point(11, 96)
        Me.FechaFinPedido.Name = "FechaFinPedido"
        Me.FechaFinPedido.Size = New System.Drawing.Size(126, 13)
        Me.FechaFinPedido.TabIndex = 95
        Me.FechaFinPedido.Text = "Fecha FinPedido:"
        '
        'EstadoPedido
        '
        Me.EstadoPedido.Location = New System.Drawing.Point(11, 128)
        Me.EstadoPedido.Name = "EstadoPedido"
        Me.EstadoPedido.Size = New System.Drawing.Size(117, 13)
        Me.EstadoPedido.TabIndex = 94
        Me.EstadoPedido.Text = "Estado:"
        '
        'AgregarLineasDePedidosClientes
        '
        Me.AgregarLineasDePedidosClientes.Location = New System.Drawing.Point(346, 232)
        Me.AgregarLineasDePedidosClientes.Name = "AgregarLineasDePedidosClientes"
        Me.AgregarLineasDePedidosClientes.Size = New System.Drawing.Size(220, 23)
        Me.AgregarLineasDePedidosClientes.TabIndex = 98
        Me.AgregarLineasDePedidosClientes.Text = "Agregar Lineas de Pedidos de los Clientes"
        Me.AgregarLineasDePedidosClientes.UseVisualStyleBackColor = True
        '
        'DtgLineaPedidosClientes
        '
        Me.DtgLineaPedidosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgLineaPedidosClientes.Location = New System.Drawing.Point(581, 30)
        Me.DtgLineaPedidosClientes.Name = "DtgLineaPedidosClientes"
        Me.DtgLineaPedidosClientes.ReadOnly = True
        Me.DtgLineaPedidosClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgLineaPedidosClientes.Size = New System.Drawing.Size(407, 345)
        Me.DtgLineaPedidosClientes.TabIndex = 107
        '
        'BtnTerminarLinea
        '
        Me.BtnTerminarLinea.Location = New System.Drawing.Point(590, 390)
        Me.BtnTerminarLinea.Name = "BtnTerminarLinea"
        Me.BtnTerminarLinea.Size = New System.Drawing.Size(169, 23)
        Me.BtnTerminarLinea.TabIndex = 108
        Me.BtnTerminarLinea.Text = "Terminar Linea de Pedido"
        Me.BtnTerminarLinea.UseVisualStyleBackColor = True
        '
        'BtnEnviarPedido
        '
        Me.BtnEnviarPedido.Location = New System.Drawing.Point(801, 390)
        Me.BtnEnviarPedido.Name = "BtnEnviarPedido"
        Me.BtnEnviarPedido.Size = New System.Drawing.Size(169, 23)
        Me.BtnEnviarPedido.TabIndex = 109
        Me.BtnEnviarPedido.Text = "Enviar Pedido"
        Me.BtnEnviarPedido.UseVisualStyleBackColor = True
        '
        'PedidosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 435)
        Me.Controls.Add(Me.BtnEnviarPedido)
        Me.Controls.Add(Me.BtnTerminarLinea)
        Me.Controls.Add(Me.DtgLineaPedidosClientes)
        Me.Controls.Add(Me.AgregarLineasDePedidosClientes)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.TxtFechaFinPedido)
        Me.Controls.Add(Me.FechaFinPedido)
        Me.Controls.Add(Me.EstadoPedido)
        Me.Controls.Add(Me.TsClientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgPedidosClientes)
        Me.Controls.Add(Me.TxtIDPedidoCliente)
        Me.Controls.Add(Me.IDProveedor)
        Me.Controls.Add(Me.TxtIDCliente)
        Me.Controls.Add(Me.TxtPrecioTotPedidoCliente)
        Me.Controls.Add(Me.TxtFechaInicioPedido)
        Me.Controls.Add(Me.PrecioTotPedido)
        Me.Controls.Add(Me.ClienteID)
        Me.Controls.Add(Me.FechaInicioPedido)
        Me.Name = "PedidosClientes"
        Me.Text = "PedidosClientes"
        Me.TsClientes.ResumeLayout(False)
        Me.TsClientes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgPedidosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgLineaPedidosClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TsClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents TsNuevoPedidoCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbIDPedidoCliente As System.Windows.Forms.ComboBox
    Friend WithEvents DtgPedidosClientes As System.Windows.Forms.DataGridView
    Friend WithEvents TxtIDPedidoCliente As System.Windows.Forms.TextBox
    Friend WithEvents IDProveedor As System.Windows.Forms.Label
    Friend WithEvents TxtIDCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecioTotPedidoCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtFechaInicioPedido As System.Windows.Forms.TextBox
    Friend WithEvents PrecioTotPedido As System.Windows.Forms.Label
    Friend WithEvents ClienteID As System.Windows.Forms.Label
    Friend WithEvents FechaInicioPedido As System.Windows.Forms.Label
    Friend WithEvents TxtEstado As System.Windows.Forms.TextBox
    Friend WithEvents TxtFechaFinPedido As System.Windows.Forms.TextBox
    Friend WithEvents FechaFinPedido As System.Windows.Forms.Label
    Friend WithEvents EstadoPedido As System.Windows.Forms.Label
    Friend WithEvents AgregarLineasDePedidosClientes As System.Windows.Forms.Button
    Friend WithEvents TsInforme As System.Windows.Forms.ToolStripButton
    Friend WithEvents DtgLineaPedidosClientes As System.Windows.Forms.DataGridView
    Friend WithEvents BtnTerminarLinea As System.Windows.Forms.Button
    Friend WithEvents BtnEnviarPedido As System.Windows.Forms.Button
End Class
