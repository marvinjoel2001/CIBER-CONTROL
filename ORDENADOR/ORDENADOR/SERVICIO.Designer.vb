<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SERVICIO
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
        Me.components = New System.ComponentModel.Container()
        Me.TimerSEGUNDOS = New System.Windows.Forms.Timer(Me.components)
        Me.LabelACTUAL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelINICIO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelLIMITE = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TimerSEGUNDOS
        '
        '
        'LabelACTUAL
        '
        Me.LabelACTUAL.AutoSize = True
        Me.LabelACTUAL.ForeColor = System.Drawing.Color.Black
        Me.LabelACTUAL.Location = New System.Drawing.Point(122, 9)
        Me.LabelACTUAL.Name = "LabelACTUAL"
        Me.LabelACTUAL.Size = New System.Drawing.Size(20, 16)
        Me.LabelACTUAL.TabIndex = 0
        Me.LabelACTUAL.Text = " 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "H. ACTUAL: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "H. INICIO: "
        '
        'LabelINICIO
        '
        Me.LabelINICIO.AutoSize = True
        Me.LabelINICIO.ForeColor = System.Drawing.Color.Black
        Me.LabelINICIO.Location = New System.Drawing.Point(122, 34)
        Me.LabelINICIO.Name = "LabelINICIO"
        Me.LabelINICIO.Size = New System.Drawing.Size(20, 16)
        Me.LabelINICIO.TabIndex = 2
        Me.LabelINICIO.Text = " 0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "H. LIMITE: "
        '
        'LabelLIMITE
        '
        Me.LabelLIMITE.AutoSize = True
        Me.LabelLIMITE.ForeColor = System.Drawing.Color.Red
        Me.LabelLIMITE.Location = New System.Drawing.Point(122, 62)
        Me.LabelLIMITE.Name = "LabelLIMITE"
        Me.LabelLIMITE.Size = New System.Drawing.Size(20, 16)
        Me.LabelLIMITE.TabIndex = 4
        Me.LabelLIMITE.Text = " 0"
        '
        'SERVICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(222, 103)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelLIMITE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelINICIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelACTUAL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SERVICIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERVICIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerSEGUNDOS As System.Windows.Forms.Timer
    Friend WithEvents LabelACTUAL As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelINICIO As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelLIMITE As System.Windows.Forms.Label
End Class
