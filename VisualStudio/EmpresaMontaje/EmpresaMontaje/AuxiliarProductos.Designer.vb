<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuxiliarProductos
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
        Me.TxtDescProducto = New System.Windows.Forms.TextBox()
        Me.TxtNombreProducto = New System.Windows.Forms.TextBox()
        Me.DescProducto = New System.Windows.Forms.Label()
        Me.NombreProducto = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtDescProducto
        '
        Me.TxtDescProducto.Location = New System.Drawing.Point(153, 51)
        Me.TxtDescProducto.MaxLength = 500
        Me.TxtDescProducto.Multiline = True
        Me.TxtDescProducto.Name = "TxtDescProducto"
        Me.TxtDescProducto.Size = New System.Drawing.Size(232, 108)
        Me.TxtDescProducto.TabIndex = 83
        '
        'TxtNombreProducto
        '
        Me.TxtNombreProducto.Location = New System.Drawing.Point(153, 22)
        Me.TxtNombreProducto.MaxLength = 50
        Me.TxtNombreProducto.Name = "TxtNombreProducto"
        Me.TxtNombreProducto.Size = New System.Drawing.Size(232, 20)
        Me.TxtNombreProducto.TabIndex = 82
        '
        'DescProducto
        '
        Me.DescProducto.Location = New System.Drawing.Point(10, 51)
        Me.DescProducto.Name = "DescProducto"
        Me.DescProducto.Size = New System.Drawing.Size(117, 13)
        Me.DescProducto.TabIndex = 81
        Me.DescProducto.Text = "Descripcion:"
        '
        'NombreProducto
        '
        Me.NombreProducto.Location = New System.Drawing.Point(10, 25)
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.Size = New System.Drawing.Size(117, 13)
        Me.NombreProducto.TabIndex = 79
        Me.NombreProducto.Text = "Nombre:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(78, 175)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 49)
        Me.BtnAceptar.TabIndex = 100
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(214, 175)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 49)
        Me.BtnCancelar.TabIndex = 101
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'AuxiliarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 236)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtDescProducto)
        Me.Controls.Add(Me.TxtNombreProducto)
        Me.Controls.Add(Me.DescProducto)
        Me.Controls.Add(Me.NombreProducto)
        Me.Name = "AuxiliarProductos"
        Me.Text = "AuxiliarProductos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDescProducto As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents DescProducto As System.Windows.Forms.Label
    Friend WithEvents NombreProducto As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
