<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuxiliarComponentes
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
        Me.TxtPrecioComponente = New System.Windows.Forms.TextBox()
        Me.PrecioProducto = New System.Windows.Forms.Label()
        Me.TxtDescComponente = New System.Windows.Forms.TextBox()
        Me.TxtNombreComponente = New System.Windows.Forms.TextBox()
        Me.DescComponente = New System.Windows.Forms.Label()
        Me.NombreComponente = New System.Windows.Forms.Label()
        Me.TxtStockMin = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.StockMinimo = New System.Windows.Forms.Label()
        Me.Stock = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPrecioComponente
        '
        Me.TxtPrecioComponente.Location = New System.Drawing.Point(155, 213)
        Me.TxtPrecioComponente.MaxLength = 25
        Me.TxtPrecioComponente.Name = "TxtPrecioComponente"
        Me.TxtPrecioComponente.Size = New System.Drawing.Size(232, 20)
        Me.TxtPrecioComponente.TabIndex = 95
        '
        'PrecioProducto
        '
        Me.PrecioProducto.Location = New System.Drawing.Point(12, 213)
        Me.PrecioProducto.Name = "PrecioProducto"
        Me.PrecioProducto.Size = New System.Drawing.Size(117, 13)
        Me.PrecioProducto.TabIndex = 94
        Me.PrecioProducto.Text = "Precio:"
        '
        'TxtDescComponente
        '
        Me.TxtDescComponente.Location = New System.Drawing.Point(155, 45)
        Me.TxtDescComponente.MaxLength = 50
        Me.TxtDescComponente.Multiline = True
        Me.TxtDescComponente.Name = "TxtDescComponente"
        Me.TxtDescComponente.Size = New System.Drawing.Size(232, 91)
        Me.TxtDescComponente.TabIndex = 93
        '
        'TxtNombreComponente
        '
        Me.TxtNombreComponente.Location = New System.Drawing.Point(155, 16)
        Me.TxtNombreComponente.MaxLength = 50
        Me.TxtNombreComponente.Name = "TxtNombreComponente"
        Me.TxtNombreComponente.Size = New System.Drawing.Size(232, 20)
        Me.TxtNombreComponente.TabIndex = 92
        '
        'DescComponente
        '
        Me.DescComponente.Location = New System.Drawing.Point(12, 45)
        Me.DescComponente.Name = "DescComponente"
        Me.DescComponente.Size = New System.Drawing.Size(117, 13)
        Me.DescComponente.TabIndex = 91
        Me.DescComponente.Text = "Descripcion:"
        '
        'NombreComponente
        '
        Me.NombreComponente.Location = New System.Drawing.Point(12, 19)
        Me.NombreComponente.Name = "NombreComponente"
        Me.NombreComponente.Size = New System.Drawing.Size(117, 13)
        Me.NombreComponente.TabIndex = 90
        Me.NombreComponente.Text = "Nombre:"
        '
        'TxtStockMin
        '
        Me.TxtStockMin.Location = New System.Drawing.Point(155, 180)
        Me.TxtStockMin.MaxLength = 5
        Me.TxtStockMin.Name = "TxtStockMin"
        Me.TxtStockMin.Size = New System.Drawing.Size(232, 20)
        Me.TxtStockMin.TabIndex = 89
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(155, 152)
        Me.TxtStock.MaxLength = 5
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(232, 20)
        Me.TxtStock.TabIndex = 88
        '
        'StockMinimo
        '
        Me.StockMinimo.Location = New System.Drawing.Point(12, 180)
        Me.StockMinimo.Name = "StockMinimo"
        Me.StockMinimo.Size = New System.Drawing.Size(117, 13)
        Me.StockMinimo.TabIndex = 87
        Me.StockMinimo.Text = "Stock Minimo:"
        '
        'Stock
        '
        Me.Stock.Location = New System.Drawing.Point(12, 152)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(117, 13)
        Me.Stock.TabIndex = 86
        Me.Stock.Text = "Stock:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(220, 254)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 49)
        Me.BtnCancelar.TabIndex = 99
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(84, 254)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 49)
        Me.BtnAceptar.TabIndex = 98
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'AuxiliarComponentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 320)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtPrecioComponente)
        Me.Controls.Add(Me.PrecioProducto)
        Me.Controls.Add(Me.TxtDescComponente)
        Me.Controls.Add(Me.TxtNombreComponente)
        Me.Controls.Add(Me.DescComponente)
        Me.Controls.Add(Me.NombreComponente)
        Me.Controls.Add(Me.TxtStockMin)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.StockMinimo)
        Me.Controls.Add(Me.Stock)
        Me.Name = "AuxiliarComponentes"
        Me.Text = "AuxiliarComponentes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPrecioComponente As System.Windows.Forms.TextBox
    Friend WithEvents PrecioProducto As System.Windows.Forms.Label
    Friend WithEvents TxtDescComponente As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreComponente As System.Windows.Forms.TextBox
    Friend WithEvents DescComponente As System.Windows.Forms.Label
    Friend WithEvents NombreComponente As System.Windows.Forms.Label
    Friend WithEvents TxtStockMin As System.Windows.Forms.TextBox
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents StockMinimo As System.Windows.Forms.Label
    Friend WithEvents Stock As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
End Class
