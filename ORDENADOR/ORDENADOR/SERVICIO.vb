Public Class SERVICIO

    Private Sub SERVICIO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 40, 50)
        Me.TopMost = True
        TimerSEGUNDOS.Interval = 1000
        TimerSEGUNDOS.Start()
    End Sub

    Private Sub TimerSEGUNDOS_Tick(sender As System.Object, e As System.EventArgs) Handles TimerSEGUNDOS.Tick
        LabelACTUAL.Text = DateTime.Now.ToLongTimeString
    End Sub
End Class