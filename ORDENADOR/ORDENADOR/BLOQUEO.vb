Public Class BLOQUEO

    Public DESBLOQUEO As Boolean = False

    Private Sub BLOQUEO_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If DESBLOQUEO = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BLOQUEO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.TopMost = True
        LabelCERRAR.Text = ""
        Label1.Text = "ESTE ORDENADOR ESTA BLOQUEADO" & vbCrLf & "INTRODUZCA LA CONTRASEÑA O" & vbCrLf & "SOLICITE AYUDA AL ENCARGADO"
        Label1.Location = New Point(Me.Width / 2 - Label1.Width / 2, Me.Height / 2 - Label1.Height / 2)
        TextBoxCONTRASEÑA.Location = New Point(Me.Width / 2 - TextBoxCONTRASEÑA.Width / 2, Label1.Location.Y + Label1.Height + 50)
    End Sub

    Private Sub TextBoxCONTRASEÑA_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxCONTRASEÑA.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBoxCONTRASEÑA.Text = Form1.TextBoxCONTRASEÑA.Text Then
                e.SuppressKeyPress = True
                DESBLOQUEO = True
                Me.Close()
                Form1.Show()
            Else
                MsgBox("CONTRASEÑA  ERRONEA")
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles LabelCERRAR.Click
        DESBLOQUEO = True
        Me.Close()
        Form1.Show()
    End Sub
End Class