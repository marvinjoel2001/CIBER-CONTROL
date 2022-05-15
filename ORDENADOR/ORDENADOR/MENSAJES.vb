Public Class MENSAJES

    Private Sub MENSAJES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        Me.TopMost = True
        TextBoxMENSAJES.ReadOnly = True
        Label1.Focus()
    End Sub
End Class