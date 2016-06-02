<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LineaDePedidoProveedores
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
        Me.TxtIDPedidoProveedorEx = New System.Windows.Forms.TextBox()
        Me.PedidoID = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.ComponenteID = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.DtgComponentes = New System.Windows.Forms.DataGridView()
        Me.CmbIDComponentes_C = New System.Windows.Forms.ComboBox()
        CType(Me.DtgComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtIDPedidoProveedorEx
        '
        Me.TxtIDPedidoProveedorEx.Location = New System.Drawing.Point(155, 25)
        Me.TxtIDPedidoProveedorEx.MaxLength = 50
        Me.TxtIDPedidoProveedorEx.Name = "TxtIDPedidoProveedorEx"
        Me.TxtIDPedidoProveedorEx.Size = New System.Drawing.Size(232, 20)
        Me.TxtIDPedidoProveedorEx.TabIndex = 124
        '
        'PedidoID
        '
        Me.PedidoID.Location = New System.Drawing.Point(12, 25)
        Me.PedidoID.Name = "PedidoID"
        Me.PedidoID.Size = New System.Drawing.Size(126, 13)
        Me.PedidoID.TabIndex = 123
        Me.PedidoID.Text = "ID del Pedido:"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(155, 57)
        Me.TxtCantidad.MaxLength = 50
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.ReadOnly = True
        Me.TxtCantidad.Size = New System.Drawing.Size(232, 20)
        Me.TxtCantidad.TabIndex = 115
        Me.TxtCantidad.TabStop = False
        Me.TxtCantidad.Text = "1"
        '
        'ComponenteID
        '
        Me.ComponenteID.Location = New System.Drawing.Point(12, 91)
        Me.ComponenteID.Name = "ComponenteID"
        Me.ComponenteID.Size = New System.Drawing.Size(117, 13)
        Me.ComponenteID.TabIndex = 114
        Me.ComponenteID.Text = "ID del Componente:"
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(12, 60)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(117, 13)
        Me.Cantidad.TabIndex = 113
        Me.Cantidad.Text = "Cantidad:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(211, 299)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 49)
        Me.BtnCancelar.TabIndex = 126
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(75, 299)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 49)
        Me.BtnAceptar.TabIndex = 125
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'DtgComponentes
        '
        Me.DtgComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgComponentes.Location = New System.Drawing.Point(12, 128)
        Me.DtgComponentes.Name = "DtgComponentes"
        Me.DtgComponentes.ReadOnly = True
        Me.DtgComponentes.Size = New System.Drawing.Size(375, 148)
        Me.DtgComponentes.TabIndex = 127
        '
        'CmbIDComponentes_C
        '
        Me.CmbIDComponentes_C.FormattingEnabled = True
        Me.CmbIDComponentes_C.Location = New System.Drawing.Point(155, 91)
        Me.CmbIDComponentes_C.Name = "CmbIDComponentes_C"
        Me.CmbIDComponentes_C.Size = New System.Drawing.Size(232, 21)
        Me.CmbIDComponentes_C.TabIndex = 128
        '
        'LineaDePedidoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 362)
        Me.Controls.Add(Me.CmbIDComponentes_C)
        Me.Controls.Add(Me.DtgComponentes)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtIDPedidoProveedorEx)
        Me.Controls.Add(Me.PedidoID)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.ComponenteID)
        Me.Controls.Add(Me.Cantidad)
        Me.Name = "LineaDePedidoProveedores"
        Me.Text = "LineaDePedidoProveedores"
        CType(Me.DtgComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtIDPedidoProveedorEx As System.Windows.Forms.TextBox
    Friend WithEvents PedidoID As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents ComponenteID As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents DtgComponentes As System.Windows.Forms.DataGridView
    Friend WithEvents CmbIDComponentes_C As System.Windows.Forms.ComboBox
End Class
