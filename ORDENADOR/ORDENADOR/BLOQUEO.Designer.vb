<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BLOQUEO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BLOQUEO))
        Me.TextBoxCONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCERRAR = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxCONTRASEÑA
        '
        Me.TextBoxCONTRASEÑA.Location = New System.Drawing.Point(415, 500)
        Me.TextBoxCONTRASEÑA.Name = "TextBoxCONTRASEÑA"
        Me.TextBoxCONTRASEÑA.Size = New System.Drawing.Size(172, 22)
        Me.TextBoxCONTRASEÑA.TabIndex = 0
        Me.TextBoxCONTRASEÑA.Text = "1234"
        Me.TextBoxCONTRASEÑA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxCONTRASEÑA.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(286, 447)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ORDENADOR  BLOQUEADO"
        '
        'LabelCERRAR
        '
        Me.LabelCERRAR.ForeColor = System.Drawing.Color.Cyan
        Me.LabelCERRAR.Location = New System.Drawing.Point(0, 0)
        Me.LabelCERRAR.Name = "LabelCERRAR"
        Me.LabelCERRAR.Size = New System.Drawing.Size(74, 71)
        Me.LabelCERRAR.TabIndex = 2
        Me.LabelCERRAR.Text = "CERRAR"
        Me.LabelCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BLOQUEO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1013, 684)
        Me.Controls.Add(Me.LabelCERRAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxCONTRASEÑA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BLOQUEO"
        Me.Text = "BLOQUEO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxCONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelCERRAR As System.Windows.Forms.Label
End Class
