<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LineasDePedidoClientes
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
        Me.TxtIDPedidoClienteEx = New System.Windows.Forms.TextBox()
        Me.PedidoID = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.ProductoID = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.DtgProductos = New System.Windows.Forms.DataGridView()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CmbIDProducto_P = New System.Windows.Forms.ComboBox()
        CType(Me.DtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtIDPedidoClienteEx
        '
        Me.TxtIDPedidoClienteEx.Location = New System.Drawing.Point(155, 23)
        Me.TxtIDPedidoClienteEx.MaxLength = 50
        Me.TxtIDPedidoClienteEx.Name = "TxtIDPedidoClienteEx"
        Me.TxtIDPedidoClienteEx.Size = New System.Drawing.Size(232, 20)
        Me.TxtIDPedidoClienteEx.TabIndex = 111
        '
        'PedidoID
        '
        Me.PedidoID.Location = New System.Drawing.Point(12, 23)
        Me.PedidoID.Name = "PedidoID"
        Me.PedidoID.Size = New System.Drawing.Size(126, 13)
        Me.PedidoID.TabIndex = 110
        Me.PedidoID.Text = "ID del Pedido:"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(155, 54)
        Me.TxtCantidad.MaxLength = 50
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.ReadOnly = True
        Me.TxtCantidad.Size = New System.Drawing.Size(232, 20)
        Me.TxtCantidad.TabIndex = 101
        Me.TxtCantidad.TabStop = False
        Me.TxtCantidad.Text = "1"
        '
        'ProductoID
        '
        Me.ProductoID.Location = New System.Drawing.Point(12, 92)
        Me.ProductoID.Name = "ProductoID"
        Me.ProductoID.Size = New System.Drawing.Size(117, 13)
        Me.ProductoID.TabIndex = 99
        Me.ProductoID.Text = "ID del Producto:"
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(12, 57)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(117, 13)
        Me.Cantidad.TabIndex = 98
        Me.Cantidad.Text = "Cantidad:"
        '
        'DtgProductos
        '
        Me.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgProductos.Location = New System.Drawing.Point(15, 127)
        Me.DtgProductos.Name = "DtgProductos"
        Me.DtgProductos.ReadOnly = True
        Me.DtgProductos.Size = New System.Drawing.Size(372, 148)
        Me.DtgProductos.TabIndex = 113
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(221, 298)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 49)
        Me.BtnCancelar.TabIndex = 115
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(85, 298)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 49)
        Me.BtnAceptar.TabIndex = 114
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CmbIDProducto_P
        '
        Me.CmbIDProducto_P.FormattingEnabled = True
        Me.CmbIDProducto_P.Location = New System.Drawing.Point(155, 89)
        Me.CmbIDProducto_P.Name = "CmbIDProducto_P"
        Me.CmbIDProducto_P.Size = New System.Drawing.Size(232, 21)
        Me.CmbIDProducto_P.TabIndex = 116
        '
        'LineasDePedidoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 361)
        Me.Controls.Add(Me.CmbIDProducto_P)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.DtgProductos)
        Me.Controls.Add(Me.TxtIDPedidoClienteEx)
        Me.Controls.Add(Me.PedidoID)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.ProductoID)
        Me.Controls.Add(Me.Cantidad)
        Me.Name = "LineasDePedidoClientes"
        Me.Text = "LineasDePedidoClientes"
        CType(Me.DtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtIDPedidoClienteEx As System.Windows.Forms.TextBox
    Friend WithEvents PedidoID As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents ProductoID As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.Label
    Friend WithEvents DtgProductos As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents CmbIDProducto_P As System.Windows.Forms.ComboBox
End Class
