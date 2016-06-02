<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto_Componente
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
        Me.IdComponente = New System.Windows.Forms.Label()
        Me.TxtIDProducto_C = New System.Windows.Forms.TextBox()
        Me.IdProducto = New System.Windows.Forms.Label()
        Me.DtgProductoComponente = New System.Windows.Forms.DataGridView()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CmbIDComponente_C = New System.Windows.Forms.ComboBox()
        CType(Me.DtgProductoComponente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdComponente
        '
        Me.IdComponente.Location = New System.Drawing.Point(21, 57)
        Me.IdComponente.Name = "IdComponente"
        Me.IdComponente.Size = New System.Drawing.Size(117, 13)
        Me.IdComponente.TabIndex = 94
        Me.IdComponente.Text = "ID Componente:"
        '
        'TxtIDProducto_C
        '
        Me.TxtIDProducto_C.Location = New System.Drawing.Point(164, 22)
        Me.TxtIDProducto_C.MaxLength = 50
        Me.TxtIDProducto_C.Name = "TxtIDProducto_C"
        Me.TxtIDProducto_C.Size = New System.Drawing.Size(232, 20)
        Me.TxtIDProducto_C.TabIndex = 93
        '
        'IdProducto
        '
        Me.IdProducto.Location = New System.Drawing.Point(21, 25)
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.Size = New System.Drawing.Size(117, 13)
        Me.IdProducto.TabIndex = 92
        Me.IdProducto.Text = "ID Producto:"
        '
        'DtgProductoComponente
        '
        Me.DtgProductoComponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgProductoComponente.Location = New System.Drawing.Point(24, 97)
        Me.DtgProductoComponente.Name = "DtgProductoComponente"
        Me.DtgProductoComponente.ReadOnly = True
        Me.DtgProductoComponente.Size = New System.Drawing.Size(372, 148)
        Me.DtgProductoComponente.TabIndex = 96
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(228, 274)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 49)
        Me.BtnCancelar.TabIndex = 98
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(92, 274)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 49)
        Me.BtnAceptar.TabIndex = 97
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CmbIDComponente_C
        '
        Me.CmbIDComponente_C.FormattingEnabled = True
        Me.CmbIDComponente_C.Location = New System.Drawing.Point(164, 57)
        Me.CmbIDComponente_C.Name = "CmbIDComponente_C"
        Me.CmbIDComponente_C.Size = New System.Drawing.Size(232, 21)
        Me.CmbIDComponente_C.TabIndex = 99
        '
        'Producto_Componente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 342)
        Me.Controls.Add(Me.CmbIDComponente_C)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.DtgProductoComponente)
        Me.Controls.Add(Me.IdComponente)
        Me.Controls.Add(Me.TxtIDProducto_C)
        Me.Controls.Add(Me.IdProducto)
        Me.Name = "Producto_Componente"
        Me.Text = "Producto_Componente"
        CType(Me.DtgProductoComponente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdComponente As System.Windows.Forms.Label
    Friend WithEvents TxtIDProducto_C As System.Windows.Forms.TextBox
    Friend WithEvents IdProducto As System.Windows.Forms.Label
    Friend WithEvents DtgProductoComponente As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents CmbIDComponente_C As System.Windows.Forms.ComboBox
End Class
