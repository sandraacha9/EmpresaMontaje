<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuxiliarPedidosClientes
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
        Me.ClienteID = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.CmbIDCientes_C = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ClienteID
        '
        Me.ClienteID.Location = New System.Drawing.Point(12, 20)
        Me.ClienteID.Name = "ClienteID"
        Me.ClienteID.Size = New System.Drawing.Size(117, 13)
        Me.ClienteID.TabIndex = 89
        Me.ClienteID.Text = "ID del Cliente:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(218, 59)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 49)
        Me.BtnCancelar.TabIndex = 104
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(82, 59)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 49)
        Me.BtnAceptar.TabIndex = 103
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CmbIDCientes_C
        '
        Me.CmbIDCientes_C.FormattingEnabled = True
        Me.CmbIDCientes_C.Location = New System.Drawing.Point(122, 20)
        Me.CmbIDCientes_C.Name = "CmbIDCientes_C"
        Me.CmbIDCientes_C.Size = New System.Drawing.Size(232, 21)
        Me.CmbIDCientes_C.TabIndex = 129
        '
        'AuxiliarPedidosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 129)
        Me.Controls.Add(Me.CmbIDCientes_C)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.ClienteID)
        Me.Name = "AuxiliarPedidosClientes"
        Me.Text = "AuxiliarPedidosClientes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClienteID As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents CmbIDCientes_C As System.Windows.Forms.ComboBox
End Class
