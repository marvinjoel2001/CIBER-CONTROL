<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBoxPUERTO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TimerMENSAJES = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonINICIAR = New System.Windows.Forms.Button()
        Me.NumMENSAJES = New System.Windows.Forms.NumericUpDown()
        Me.NumPREAVISO = New System.Windows.Forms.NumericUpDown()
        Me.TimerMINUTOS = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonNOTSKMNGR = New System.Windows.Forms.Button()
        Me.ButtonSITSKMNGR = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.NumMENSAJES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPREAVISO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxPUERTO
        '
        Me.TextBoxPUERTO.BackColor = System.Drawing.Color.Black
        Me.TextBoxPUERTO.ForeColor = System.Drawing.Color.Cyan
        Me.TextBoxPUERTO.Location = New System.Drawing.Point(712, 15)
        Me.TextBoxPUERTO.Name = "TextBoxPUERTO"
        Me.TextBoxPUERTO.Size = New System.Drawing.Size(140, 22)
        Me.TextBoxPUERTO.TabIndex = 11
        Me.TextBoxPUERTO.Text = "55555"
        Me.TextBoxPUERTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(757, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "PUERTO"
        '
        'TextBoxCONTRASEÑA
        '
        Me.TextBoxCONTRASEÑA.BackColor = System.Drawing.Color.Black
        Me.TextBoxCONTRASEÑA.ForeColor = System.Drawing.Color.Cyan
        Me.TextBoxCONTRASEÑA.Location = New System.Drawing.Point(383, 127)
        Me.TextBoxCONTRASEÑA.Name = "TextBoxCONTRASEÑA"
        Me.TextBoxCONTRASEÑA.Size = New System.Drawing.Size(140, 22)
        Me.TextBoxCONTRASEÑA.TabIndex = 14
        Me.TextBoxCONTRASEÑA.Text = "1234"
        Me.TextBoxCONTRASEÑA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MintCream
        Me.Label1.Location = New System.Drawing.Point(163, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CONTRASEÑA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(251, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 31)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "T. MENSAJES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MintCream
        Me.Label4.Location = New System.Drawing.Point(256, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 31)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "T. PREAVISO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(642, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "SEG."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(646, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "MIN."
        '
        'TimerMENSAJES
        '
        '
        'ButtonINICIAR
        '
        Me.ButtonINICIAR.BackColor = System.Drawing.Color.Black
        Me.ButtonINICIAR.ForeColor = System.Drawing.Color.Aqua
        Me.ButtonINICIAR.Location = New System.Drawing.Point(367, 380)
        Me.ButtonINICIAR.Name = "ButtonINICIAR"
        Me.ButtonINICIAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonINICIAR.TabIndex = 23
        Me.ButtonINICIAR.Text = "INICIAR"
        Me.ButtonINICIAR.UseVisualStyleBackColor = False
        '
        'NumMENSAJES
        '
        Me.NumMENSAJES.BackColor = System.Drawing.Color.Black
        Me.NumMENSAJES.ForeColor = System.Drawing.Color.Aqua
        Me.NumMENSAJES.Location = New System.Drawing.Point(487, 224)
        Me.NumMENSAJES.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumMENSAJES.Name = "NumMENSAJES"
        Me.NumMENSAJES.Size = New System.Drawing.Size(140, 22)
        Me.NumMENSAJES.TabIndex = 24
        Me.NumMENSAJES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumMENSAJES.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NumPREAVISO
        '
        Me.NumPREAVISO.BackColor = System.Drawing.Color.Black
        Me.NumPREAVISO.ForeColor = System.Drawing.Color.Aqua
        Me.NumPREAVISO.Location = New System.Drawing.Point(487, 285)
        Me.NumPREAVISO.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumPREAVISO.Name = "NumPREAVISO"
        Me.NumPREAVISO.Size = New System.Drawing.Size(140, 22)
        Me.NumPREAVISO.TabIndex = 25
        Me.NumPREAVISO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumPREAVISO.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'TimerMINUTOS
        '
        '
        'ButtonNOTSKMNGR
        '
        Me.ButtonNOTSKMNGR.BackColor = System.Drawing.Color.Black
        Me.ButtonNOTSKMNGR.ForeColor = System.Drawing.Color.Aqua
        Me.ButtonNOTSKMNGR.Location = New System.Drawing.Point(302, 486)
        Me.ButtonNOTSKMNGR.Name = "ButtonNOTSKMNGR"
        Me.ButtonNOTSKMNGR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonNOTSKMNGR.TabIndex = 26
        Me.ButtonNOTSKMNGR.Text = "Bloquear"
        Me.ButtonNOTSKMNGR.UseVisualStyleBackColor = False
        '
        'ButtonSITSKMNGR
        '
        Me.ButtonSITSKMNGR.BackColor = System.Drawing.Color.Black
        Me.ButtonSITSKMNGR.ForeColor = System.Drawing.Color.Aqua
        Me.ButtonSITSKMNGR.Location = New System.Drawing.Point(458, 486)
        Me.ButtonSITSKMNGR.Name = "ButtonSITSKMNGR"
        Me.ButtonSITSKMNGR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonSITSKMNGR.TabIndex = 27
        Me.ButtonSITSKMNGR.Text = "Desbloquear"
        Me.ButtonSITSKMNGR.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MintCream
        Me.Label7.Location = New System.Drawing.Point(297, 454)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 29)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Administrador de Tareas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(864, 559)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ButtonSITSKMNGR)
        Me.Controls.Add(Me.ButtonNOTSKMNGR)
        Me.Controls.Add(Me.NumPREAVISO)
        Me.Controls.Add(Me.NumMENSAJES)
        Me.Controls.Add(Me.ButtonINICIAR)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxCONTRASEÑA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPUERTO)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Aqua
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONFIGURACION"
        CType(Me.NumMENSAJES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPREAVISO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPUERTO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TimerMENSAJES As System.Windows.Forms.Timer
    Friend WithEvents ButtonINICIAR As System.Windows.Forms.Button
    Friend WithEvents NumMENSAJES As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumPREAVISO As System.Windows.Forms.NumericUpDown
    Friend WithEvents TimerMINUTOS As System.Windows.Forms.Timer
    Friend WithEvents ButtonNOTSKMNGR As System.Windows.Forms.Button
    Friend WithEvents ButtonSITSKMNGR As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As Label
End Class
