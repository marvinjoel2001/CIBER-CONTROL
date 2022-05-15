Imports System.Net
Imports System.Net.Sockets
Imports System.Text.Encoding

Public Class Form1
    Dim ADMINISTRADOR As New UdpClient()
    Dim ORDENADOR As IPAddress

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        ComboBox1.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedItem.ToString
            Case "PC-1"
                ORDENADOR = IPAddress.Parse("192.168.56.1")
            Case "PC-2"
                ORDENADOR = IPAddress.Parse("192.168.56.1")
            Case "PC-3"
                ORDENADOR = IPAddress.Parse("192.168.56.1")
            Case "PC-4"
                ORDENADOR = IPAddress.Parse("192.168.56.1")
        End Select
    End Sub

    Private Sub ButtonINICIAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonINICIAR.Click
        Try
            Dim IP As IPEndPoint = New IPEndPoint(ORDENADOR, TextBoxPUERTO1.Text)
            Dim FRASE As String = "INICIAR:" & NumH1.Value & ":" & NumM1.Value
            Dim MENSAJE As Byte() = UTF7.GetBytes(FRASE)
            ADMINISTRADOR.Connect(IP)
            ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length)
            NumH1.Value = 0
            NumM1.Value = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonAÑADIR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAÑADIR.Click
        Try
            Dim IP As IPEndPoint = New IPEndPoint(ORDENADOR, TextBoxPUERTO1.Text)
            Dim FRASE As String = "AÑADIR:" & NumH1.Value & ":" & NumM1.Value
            Dim MENSAJE As Byte() = UTF7.GetBytes(FRASE)
            ADMINISTRADOR.Connect(IP)
            ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length)
            NumH1.Value = 0
            NumM1.Value = 0  
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBoxMENSAJES_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxMENSAJES1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBoxMENSAJES1.Text <> "" Then
                Try
                    Dim IP As IPEndPoint = New IPEndPoint(ORDENADOR, TextBoxPUERTO1.Text)
                    Dim FRASE As String = "MENSAJE:" & TextBoxMENSAJES1.Text & ":0"
                    Dim MENSAJE As Byte() = UTF7.GetBytes(FRASE)
                    ADMINISTRADOR.Connect(IP)
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length)
                    TextBoxMENSAJES1.Clear()
                    e.SuppressKeyPress = True
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ButtonBLOQUEO_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBLOQUEO.Click
        If MsgBox("BLOQUEA LA APLICACION REMOTA", MsgBoxStyle.OkCancel, "CONFIRMACION BLOQUEO") = MsgBoxResult.Ok Then
            Try
                Dim IP As IPEndPoint = New IPEndPoint(ORDENADOR, TextBoxPUERTO1.Text)
                Dim FRASE As String = "BLOQUEO:0:0"
                Dim MENSAJE As Byte() = UTF7.GetBytes(FRASE)
                ADMINISTRADOR.Connect(IP)
                ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonCERRAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCERRAR.Click
        If MsgBox("CIERRA LA APLICACION REMOTA", MsgBoxStyle.OkCancel, "CONFIRMACION CIERRE") = MsgBoxResult.Ok Then
            Try
                Dim IP As IPEndPoint = New IPEndPoint(ORDENADOR, TextBoxPUERTO1.Text)
                Dim FRASE As String = "CERRAR:0:0"
                Dim MENSAJE As Byte() = UTF7.GetBytes(FRASE)
                ADMINISTRADOR.Connect(IP)
                ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If     
    End Sub

    Private Sub ButtonREINICIAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonREINICIAR.Click
        If MsgBox("REINICIA EL ORDENADOR REMOTO", MsgBoxStyle.OkCancel, "CONFIRMACION REINICIO") = MsgBoxResult.Ok Then
            Try
                Dim IP As IPEndPoint = New IPEndPoint(ORDENADOR, TextBoxPUERTO1.Text)
                Dim FRASE As String = "REINICIAR:0:0"
                Dim MENSAJE As Byte() = UTF7.GetBytes(FRASE)
                ADMINISTRADOR.Connect(IP)
                ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ButtonAPAGAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAPAGAR.Click
        If MsgBox("APAGA EL ORDENADOR REMOTO", MsgBoxStyle.OkCancel, "CONFIRMACION APAGADO") = MsgBoxResult.Ok Then
            Try
                Dim IP As IPEndPoint = New IPEndPoint(ORDENADOR, TextBoxPUERTO1.Text)
                Dim FRASE As String = "APAGAR:0:0"
                Dim MENSAJE As Byte() = UTF7.GetBytes(FRASE)
                ADMINISTRADOR.Connect(IP)
                ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


End Class
