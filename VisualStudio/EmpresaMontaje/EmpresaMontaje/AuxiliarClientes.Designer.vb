<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuxiliarClientes
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
        Me.TxtEmailCliente = New System.Windows.Forms.TextBox()
        Me.TxtDirCliente = New System.Windows.Forms.TextBox()
        Me.EmailCliente = New System.Windows.Forms.Label()
        Me.DireccionCliente = New System.Windows.Forms.Label()
        Me.TxtTelefonoMovil = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoFijo = New System.Windows.Forms.TextBox()
        Me.TxtApellidosCliente = New System.Windows.Forms.TextBox()
        Me.TxtDNICliente = New System.Windows.Forms.TextBox()
        Me.TxtNombreCiente = New System.Windows.Forms.TextBox()
        Me.TelefMovil = New System.Windows.Forms.Label()
        Me.TelefFijo = New System.Windows.Forms.Label()
        Me.ApellidosCliente = New System.Windows.Forms.Label()
        Me.DNICliente = New System.Windows.Forms.Label()
        Me.NombreCliente = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtEmailCliente
        '
        Me.TxtEmailCliente.Location = New System.Drawing.Point(155, 183)
        Me.TxtEmailCliente.MaxLength = 50
        Me.TxtEmailCliente.Name = "TxtEmailCliente"
        Me.TxtEmailCliente.Size = New System.Drawing.Size(232, 20)
        Me.TxtEmailCliente.TabIndex = 65
        '
        'TxtDirCliente
        '
        Me.TxtDirCliente.Location = New System.Drawing.Point(155, 157)
        Me.TxtDirCliente.MaxLength = 50
        Me.TxtDirCliente.Name = "TxtDirCliente"
        Me.TxtDirCliente.Size = New System.Drawing.Size(232, 20)
        Me.TxtDirCliente.TabIndex = 64
        '
        'EmailCliente
        '
        Me.EmailCliente.Location = New System.Drawing.Point(12, 183)
        Me.EmailCliente.Name = "EmailCliente"
        Me.EmailCliente.Size = New System.Drawing.Size(117, 13)
        Me.EmailCliente.TabIndex = 63
        Me.EmailCliente.Text = "Correo Electronico:"
        '
        'DireccionCliente
        '
        Me.DireccionCliente.Location = New System.Drawing.Point(12, 157)
        Me.DireccionCliente.Name = "DireccionCliente"
        Me.DireccionCliente.Size = New System.Drawing.Size(117, 13)
        Me.DireccionCliente.TabIndex = 62
        Me.DireccionCliente.Text = "Direccion:"
        '
        'TxtTelefonoMovil
        '
        Me.TxtTelefonoMovil.Location = New System.Drawing.Point(155, 129)
        Me.TxtTelefonoMovil.MaxLength = 9
        Me.TxtTelefonoMovil.Name = "TxtTelefonoMovil"
        Me.TxtTelefonoMovil.Size = New System.Drawing.Size(232, 20)
        Me.TxtTelefonoMovil.TabIndex = 61
        '
        'TxtTelefonoFijo
        '
        Me.TxtTelefonoFijo.Location = New System.Drawing.Point(155, 103)
        Me.TxtTelefonoFijo.MaxLength = 9
        Me.TxtTelefonoFijo.Name = "TxtTelefonoFijo"
        Me.TxtTelefonoFijo.Size = New System.Drawing.Size(232, 20)
        Me.TxtTelefonoFijo.TabIndex = 60
        '
        'TxtApellidosCliente
        '
        Me.TxtApellidosCliente.Location = New System.Drawing.Point(155, 75)
        Me.TxtApellidosCliente.MaxLength = 5
        Me.TxtApellidosCliente.Name = "TxtApellidosCliente"
        Me.TxtApellidosCliente.ReadOnly = True
        Me.TxtApellidosCliente.Size = New System.Drawing.Size(232, 20)
        Me.TxtApellidosCliente.TabIndex = 59
        '
        'TxtDNICliente
        '
        Me.TxtDNICliente.Location = New System.Drawing.Point(155, 46)
        Me.TxtDNICliente.MaxLength = 50
        Me.TxtDNICliente.Name = "TxtDNICliente"
        Me.TxtDNICliente.ReadOnly = True
        Me.TxtDNICliente.Size = New System.Drawing.Size(232, 20)
        Me.TxtDNICliente.TabIndex = 58
        '
        'TxtNombreCiente
        '
        Me.TxtNombreCiente.Location = New System.Drawing.Point(155, 17)
        Me.TxtNombreCiente.MaxLength = 50
        Me.TxtNombreCiente.Name = "TxtNombreCiente"
        Me.TxtNombreCiente.ReadOnly = True
        Me.TxtNombreCiente.Size = New System.Drawing.Size(232, 20)
        Me.TxtNombreCiente.TabIndex = 57
        '
        'TelefMovil
        '
        Me.TelefMovil.Location = New System.Drawing.Point(12, 129)
        Me.TelefMovil.Name = "TelefMovil"
        Me.TelefMovil.Size = New System.Drawing.Size(117, 13)
        Me.TelefMovil.TabIndex = 56
        Me.TelefMovil.Text = "Telefono Movil:"
        '
        'TelefFijo
        '
        Me.TelefFijo.Location = New System.Drawing.Point(12, 103)
        Me.TelefFijo.Name = "TelefFijo"
        Me.TelefFijo.Size = New System.Drawing.Size(117, 13)
        Me.TelefFijo.TabIndex = 55
        Me.TelefFijo.Text = "Telefono Fijo:"
        '
        'ApellidosCliente
        '
        Me.ApellidosCliente.Location = New System.Drawing.Point(12, 75)
        Me.ApellidosCliente.Name = "ApellidosCliente"
        Me.ApellidosCliente.Size = New System.Drawing.Size(117, 13)
        Me.ApellidosCliente.TabIndex = 54
        Me.ApellidosCliente.Text = "Apellidos:"
        '
        'DNICliente
        '
        Me.DNICliente.Location = New System.Drawing.Point(12, 49)
        Me.DNICliente.Name = "DNICliente"
        Me.DNICliente.Size = New System.Drawing.Size(117, 13)
        Me.DNICliente.TabIndex = 53
        Me.DNICliente.Text = "DNI:"
        '
        'NombreCliente
        '
        Me.NombreCliente.Location = New System.Drawing.Point(12, 20)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(117, 13)
        Me.NombreCliente.TabIndex = 52
        Me.NombreCliente.Text = "Nombre:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(85, 221)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(85, 49)
        Me.BtnAceptar.TabIndex = 68
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(221, 221)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(85, 49)
        Me.BtnCancelar.TabIndex = 69
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'AuxiliarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 285)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtEmailCliente)
        Me.Controls.Add(Me.TxtDirCliente)
        Me.Controls.Add(Me.EmailCliente)
        Me.Controls.Add(Me.DireccionCliente)
        Me.Controls.Add(Me.TxtTelefonoMovil)
        Me.Controls.Add(Me.TxtTelefonoFijo)
        Me.Controls.Add(Me.TxtApellidosCliente)
        Me.Controls.Add(Me.TxtDNICliente)
        Me.Controls.Add(Me.TxtNombreCiente)
        Me.Controls.Add(Me.TelefMovil)
        Me.Controls.Add(Me.TelefFijo)
        Me.Controls.Add(Me.ApellidosCliente)
        Me.Controls.Add(Me.DNICliente)
        Me.Controls.Add(Me.NombreCliente)
        Me.Name = "AuxiliarClientes"
        Me.Text = "AuxiliarClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtEmailCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtDirCliente As System.Windows.Forms.TextBox
    Friend WithEvents EmailCliente As System.Windows.Forms.Label
    Friend WithEvents DireccionCliente As System.Windows.Forms.Label
    Friend WithEvents TxtTelefonoMovil As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefonoFijo As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellidosCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtDNICliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreCiente As System.Windows.Forms.TextBox
    Friend WithEvents TelefMovil As System.Windows.Forms.Label
    Friend WithEvents TelefFijo As System.Windows.Forms.Label
    Friend WithEvents ApellidosCliente As System.Windows.Forms.Label
    Friend WithEvents DNICliente As System.Windows.Forms.Label
    Friend WithEvents NombreCliente As System.Windows.Forms.Label
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
End Class
