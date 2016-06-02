<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuxiliarProveedores
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
        Me.TxtEmailEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtDirEmpresa = New System.Windows.Forms.TextBox()
        Me.EmailEmpresa = New System.Windows.Forms.Label()
        Me.DireccionEmpresa = New System.Windows.Forms.Label()
        Me.TxtTelefEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.TxtTelefProveedor = New System.Windows.Forms.TextBox()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.TelefEmpresa = New System.Windows.Forms.Label()
        Me.TelefProveedor = New System.Windows.Forms.Label()
        Me.NombreEmpresa = New System.Windows.Forms.Label()
        Me.NombreProveedor = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtEmailEmpresa
        '
        Me.TxtEmailEmpresa.Location = New System.Drawing.Point(155, 159)
        Me.TxtEmailEmpresa.MaxLength = 50
        Me.TxtEmailEmpresa.Name = "TxtEmailEmpresa"
        Me.TxtEmailEmpresa.Size = New System.Drawing.Size(232, 20)
        Me.TxtEmailEmpresa.TabIndex = 83
        '
        'TxtDirEmpresa
        '
        Me.TxtDirEmpresa.Location = New System.Drawing.Point(155, 133)
        Me.TxtDirEmpresa.MaxLength = 50
        Me.TxtDirEmpresa.Name = "TxtDirEmpresa"
        Me.TxtDirEmpresa.Size = New System.Drawing.Size(232, 20)
        Me.TxtDirEmpresa.TabIndex = 82
        '
        'EmailEmpresa
        '
        Me.EmailEmpresa.Location = New System.Drawing.Point(12, 159)
        Me.EmailEmpresa.Name = "EmailEmpresa"
        Me.EmailEmpresa.Size = New System.Drawing.Size(117, 13)
        Me.EmailEmpresa.TabIndex = 81
        Me.EmailEmpresa.Text = "Correo Electronico:"
        '
        'DireccionEmpresa
        '
        Me.DireccionEmpresa.Location = New System.Drawing.Point(12, 133)
        Me.DireccionEmpresa.Name = "DireccionEmpresa"
        Me.DireccionEmpresa.Size = New System.Drawing.Size(117, 13)
        Me.DireccionEmpresa.TabIndex = 80
        Me.DireccionEmpresa.Text = "Direccion:"
        '
        'TxtTelefEmpresa
        '
        Me.TxtTelefEmpresa.Location = New System.Drawing.Point(155, 105)
        Me.TxtTelefEmpresa.MaxLength = 9
        Me.TxtTelefEmpresa.Name = "TxtTelefEmpresa"
        Me.TxtTelefEmpresa.Size = New System.Drawing.Size(232, 20)
        Me.TxtTelefEmpresa.TabIndex = 79
        '
        'TxtNombreEmpresa
        '
        Me.TxtNombreEmpresa.Location = New System.Drawing.Point(155, 79)
        Me.TxtNombreEmpresa.MaxLength = 25
        Me.TxtNombreEmpresa.Name = "TxtNombreEmpresa"
        Me.TxtNombreEmpresa.ReadOnly = True
        Me.TxtNombreEmpresa.Size = New System.Drawing.Size(232, 20)
        Me.TxtNombreEmpresa.TabIndex = 78
        '
        'TxtTelefProveedor
        '
        Me.TxtTelefProveedor.Location = New System.Drawing.Point(155, 47)
        Me.TxtTelefProveedor.MaxLength = 9
        Me.TxtTelefProveedor.Name = "TxtTelefProveedor"
        Me.TxtTelefProveedor.Size = New System.Drawing.Size(232, 20)
        Me.TxtTelefProveedor.TabIndex = 77
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(155, 18)
        Me.TxtNombreProveedor.MaxLength = 50
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.ReadOnly = True
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(232, 20)
        Me.TxtNombreProveedor.TabIndex = 76
        '
        'TelefEmpresa
        '
        Me.TelefEmpresa.Location = New System.Drawing.Point(12, 105)
        Me.TelefEmpresa.Name = "TelefEmpresa"
        Me.TelefEmpresa.Size = New System.Drawing.Size(117, 13)
        Me.TelefEmpresa.TabIndex = 75
        Me.TelefEmpresa.Text = "Telefono Empresa:"
        '
        'TelefProveedor
        '
        Me.TelefProveedor.Location = New System.Drawing.Point(12, 47)
        Me.TelefProveedor.Name = "TelefProveedor"
        Me.TelefProveedor.Size = New System.Drawing.Size(117, 13)
        Me.TelefProveedor.TabIndex = 74
        Me.TelefProveedor.Text = "Telefono Proveedor:"
        '
        'NombreEmpresa
        '
        Me.NombreEmpresa.Location = New System.Drawing.Point(12, 79)
        Me.NombreEmpresa.Name = "NombreEmpresa"
        Me.NombreEmpresa.Size = New System.Drawing.Size(117, 13)
        Me.NombreEmpresa.TabIndex = 73
        Me.NombreEmpresa.Text = "Nombre Empresa:"
        '
        'NombreProveedor
        '
        Me.NombreProveedor.Location = New System.Drawing.Point(12, 21)
        Me.NombreProveedor.Name = "NombreProveedor"
        Me.NombreProveedor.Size = New System.Drawing.Size(117, 13)
        Me.NombreProveedor.TabIndex = 72
        Me.NombreProveedor.Text = "Nombre Proveedor:"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(211, 202)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 49)
        Me.BtnCancelar.TabIndex = 87
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(75, 202)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 49)
        Me.BtnAceptar.TabIndex = 86
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'AuxiliarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 262)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtEmailEmpresa)
        Me.Controls.Add(Me.TxtDirEmpresa)
        Me.Controls.Add(Me.EmailEmpresa)
        Me.Controls.Add(Me.DireccionEmpresa)
        Me.Controls.Add(Me.TxtTelefEmpresa)
        Me.Controls.Add(Me.TxtNombreEmpresa)
        Me.Controls.Add(Me.TxtTelefProveedor)
        Me.Controls.Add(Me.TxtNombreProveedor)
        Me.Controls.Add(Me.TelefEmpresa)
        Me.Controls.Add(Me.TelefProveedor)
        Me.Controls.Add(Me.NombreEmpresa)
        Me.Controls.Add(Me.NombreProveedor)
        Me.Name = "AuxiliarProveedores"
        Me.Text = "AuxiliarProveedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtEmailEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtDirEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents EmailEmpresa As System.Windows.Forms.Label
    Friend WithEvents DireccionEmpresa As System.Windows.Forms.Label
    Friend WithEvents TxtTelefEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TelefEmpresa As System.Windows.Forms.Label
    Friend WithEvents TelefProveedor As System.Windows.Forms.Label
    Friend WithEvents NombreEmpresa As System.Windows.Forms.Label
    Friend WithEvents NombreProveedor As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
End Class
