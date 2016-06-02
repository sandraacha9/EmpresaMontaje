Imports MySql.Data.MySqlClient

Public Class AuxiliarComponentes

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click 'Metodo para cuando clicamos en el boton aceptar.
        'Condicion para cuando falta alguno de estos datos.
        If TxtNombreComponente.Text = "" Or TxtStock.Text = "" Or TxtStockMin.Text = "" Or TxtPrecioComponente.Text = "" Then
            MsgBox("FALTAN DATOS", MsgBoxStyle.Exclamation, "NO SE PUEDE GUARDAR") 'Mostramos un mensaje de error.
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK 'Le indicamos el valor del boton con su accion.
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click 'Metodo para cuando clicamos en el boton cancelar.
        Me.DialogResult = Windows.Forms.DialogResult.Cancel 'Le indicamos el valor del boton con su accion.
    End Sub

    'Metodo que comprueva cada letra introducida en el TextBox de Stock.
    Private Sub TxtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        Dim validos As String = "1234567890" & Chr(8) 'Solo se pueden introducir numeros y borrar.
        If validos.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    'Metodo que comprueva cada letra introducida en el TextBox de StockMin.
    Private Sub TxtStockMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStockMin.KeyPress
        Dim validos As String = "1234567890" & Chr(8) 'Solo se pueden introducir numeros y borrar.
        If validos.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub

    'Metodo que comprueva cada letra introducida en el TextBox de TxtPrecioComponente.
    Private Sub TxtPrecioComponente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecioComponente.KeyPress
        Dim validos As String = "1234567890." & Chr(8) 'Solo se pueden introducir numeros, el punto y borrar.
        If validos.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
    End Sub
End Class