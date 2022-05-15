<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENSAJES
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
        Me.TextBoxMENSAJES = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxMENSAJES
        '
        Me.TextBoxMENSAJES.BackColor = System.Drawing.Color.White
        Me.TextBoxMENSAJES.ForeColor = System.Drawing.Color.Black
        Me.TextBoxMENSAJES.Location = New System.Drawing.Point(12, 42)
        Me.TextBoxMENSAJES.Multiline = True
        Me.TextBoxMENSAJES.Name = "TextBoxMENSAJES"
        Me.TextBoxMENSAJES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMENSAJES.Size = New System.Drawing.Size(401, 168)
        Me.TextBoxMENSAJES.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "El Administrador dice:"
        '
        'MENSAJES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(426, 229)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxMENSAJES)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Aqua
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MENSAJES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENSAJES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxMENSAJES As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
