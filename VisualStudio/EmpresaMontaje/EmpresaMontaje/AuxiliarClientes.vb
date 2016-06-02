Imports MySql.Data.MySqlClient

Public Class AuxiliarClientes

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click 'Metodo para cuando clicamos en el boton aceptar.
        'Condicion para cuando falta alguno de estos datos.
        If TxtNombreCiente.Text = "" Or TxtDNICliente.Text = "" Or TxtApellidosCliente.Text = "" Or TxtTelefonoMovil.Text = "" Or TxtDirCliente.Text = "" Or TxtEmailCliente.Text = "" Then
            MsgBox("FALTAN DATOS", MsgBoxStyle.Exclamation, "NO SE PUEDE GUARDAR") 'Mostramos un mensaje de error.
            Exit Sub
        End If
            Me.DialogResult = Windows.Forms.DialogResult.OK 'Le indicamos el valor del boton con su accion.
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click 'Metodo para cuando clicamos en el boton cancelar.
        Me.DialogResult = Windows.Forms.DialogResult.Cancel 'Le indicamos el valor del boton con su accion.
    End Sub

    'Metodo que comprueva cada letra introducida en el TextBox de TelefonoFijo.
    Private Sub TxtTelefonoFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefonoFijo.KeyPress
        Dim validos As String = "1234567890" & Chr(8) 'Solo se pueden introducir numeros y borrar.
        If validos.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    'Metodo que comprueva cada letra introducida en el TextBox de TelefonoMovil.
    Private Sub TxtTelefonoMovil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefonoMovil.KeyPress
        Dim validos As String = "1234567890" & Chr(8) 'Solo se pueden introducir numeros y borrar.
        If validos.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub
End Class