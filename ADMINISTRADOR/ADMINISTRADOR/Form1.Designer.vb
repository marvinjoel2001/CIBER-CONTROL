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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBoxPUERTO1 = New System.Windows.Forms.TextBox()
        Me.NumH1 = New System.Windows.Forms.NumericUpDown()
        Me.NumM1 = New System.Windows.Forms.NumericUpDown()
        Me.ButtonBLOQUEO = New System.Windows.Forms.Button()
        Me.ButtonAPAGAR = New System.Windows.Forms.Button()
        Me.ButtonINICIAR = New System.Windows.Forms.Button()
        Me.TextBoxMENSAJES1 = New System.Windows.Forms.TextBox()
        Me.ButtonAÑADIR = New System.Windows.Forms.Button()
        Me.ButtonCERRAR = New System.Windows.Forms.Button()
        Me.ButtonREINICIAR = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.compu2 = New System.Windows.Forms.Button()
        Me.DOS = New System.Windows.Forms.Label()
        CType(Me.NumH1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumM1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxPUERTO1
        '
        Me.TextBoxPUERTO1.BackColor = System.Drawing.Color.Black
        Me.TextBoxPUERTO1.ForeColor = System.Drawing.Color.Cyan
        Me.TextBoxPUERTO1.Location = New System.Drawing.Point(867, 39)
        Me.TextBoxPUERTO1.Name = "TextBoxPUERTO1"
        Me.TextBoxPUERTO1.Size = New System.Drawing.Size(140, 22)
        Me.TextBoxPUERTO1.TabIndex = 5
        Me.TextBoxPUERTO1.Text = "55555"
        Me.TextBoxPUERTO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumH1
        '
        Me.NumH1.BackColor = System.Drawing.Color.Black
        Me.NumH1.ForeColor = System.Drawing.Color.Cyan
        Me.NumH1.Location = New System.Drawing.Point(12, 146)
        Me.NumH1.Name = "NumH1"
        Me.NumH1.Size = New System.Drawing.Size(60, 22)
        Me.NumH1.TabIndex = 7
        Me.NumH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumM1
        '
        Me.NumM1.BackColor = System.Drawing.Color.Black
        Me.NumM1.ForeColor = System.Drawing.Color.Cyan
        Me.NumM1.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumM1.Location = New System.Drawing.Point(105, 146)
        Me.NumM1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumM1.Name = "NumM1"
        Me.NumM1.Size = New System.Drawing.Size(60, 22)
        Me.NumM1.TabIndex = 8
        Me.NumM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumM1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ButtonBLOQUEO
        '
        Me.ButtonBLOQUEO.BackColor = System.Drawing.Color.Black
        Me.ButtonBLOQUEO.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonBLOQUEO.Location = New System.Drawing.Point(305, 443)
        Me.ButtonBLOQUEO.Name = "ButtonBLOQUEO"
        Me.ButtonBLOQUEO.Size = New System.Drawing.Size(140, 40)
        Me.ButtonBLOQUEO.TabIndex = 10
        Me.ButtonBLOQUEO.Text = "BLOQUEO"
        Me.ButtonBLOQUEO.UseVisualStyleBackColor = False
        '
        'ButtonAPAGAR
        '
        Me.ButtonAPAGAR.BackColor = System.Drawing.Color.Black
        Me.ButtonAPAGAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonAPAGAR.Location = New System.Drawing.Point(846, 324)
        Me.ButtonAPAGAR.Name = "ButtonAPAGAR"
        Me.ButtonAPAGAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonAPAGAR.TabIndex = 11
        Me.ButtonAPAGAR.Text = "APAGAR REMOTO"
        Me.ButtonAPAGAR.UseVisualStyleBackColor = False
        '
        'ButtonINICIAR
        '
        Me.ButtonINICIAR.BackColor = System.Drawing.Color.Black
        Me.ButtonINICIAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonINICIAR.Location = New System.Drawing.Point(559, 443)
        Me.ButtonINICIAR.Name = "ButtonINICIAR"
        Me.ButtonINICIAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonINICIAR.TabIndex = 12
        Me.ButtonINICIAR.Text = "INICIAR"
        Me.ButtonINICIAR.UseVisualStyleBackColor = False
        '
        'TextBoxMENSAJES1
        '
        Me.TextBoxMENSAJES1.BackColor = System.Drawing.Color.Black
        Me.TextBoxMENSAJES1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMENSAJES1.ForeColor = System.Drawing.Color.Yellow
        Me.TextBoxMENSAJES1.Location = New System.Drawing.Point(221, 221)
        Me.TextBoxMENSAJES1.Multiline = True
        Me.TextBoxMENSAJES1.Name = "TextBoxMENSAJES1"
        Me.TextBoxMENSAJES1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMENSAJES1.Size = New System.Drawing.Size(566, 216)
        Me.TextBoxMENSAJES1.TabIndex = 13
        Me.TextBoxMENSAJES1.Text = "MENSAJES"
        '
        'ButtonAÑADIR
        '
        Me.ButtonAÑADIR.BackColor = System.Drawing.Color.Black
        Me.ButtonAÑADIR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonAÑADIR.Location = New System.Drawing.Point(12, 221)
        Me.ButtonAÑADIR.Name = "ButtonAÑADIR"
        Me.ButtonAÑADIR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonAÑADIR.TabIndex = 24
        Me.ButtonAÑADIR.Text = "AÑADIR TIEMPO"
        Me.ButtonAÑADIR.UseVisualStyleBackColor = False
        '
        'ButtonCERRAR
        '
        Me.ButtonCERRAR.BackColor = System.Drawing.Color.Black
        Me.ButtonCERRAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonCERRAR.Location = New System.Drawing.Point(846, 177)
        Me.ButtonCERRAR.Name = "ButtonCERRAR"
        Me.ButtonCERRAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonCERRAR.TabIndex = 25
        Me.ButtonCERRAR.Text = "CERRAR APLICACION"
        Me.ButtonCERRAR.UseVisualStyleBackColor = False
        '
        'ButtonREINICIAR
        '
        Me.ButtonREINICIAR.BackColor = System.Drawing.Color.Black
        Me.ButtonREINICIAR.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonREINICIAR.Location = New System.Drawing.Point(846, 491)
        Me.ButtonREINICIAR.Name = "ButtonREINICIAR"
        Me.ButtonREINICIAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonREINICIAR.TabIndex = 26
        Me.ButtonREINICIAR.Text = "REINICIAR REMOTO"
        Me.ButtonREINICIAR.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.Yellow
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"PC-1", "PC-2", "PC-3", "PC-4"})
        Me.ComboBox1.Location = New System.Drawing.Point(409, 146)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 24)
        Me.ComboBox1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(883, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "PUERTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(101, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "seg"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 140)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Azure
        Me.Label3.Location = New System.Drawing.Point(12, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 24)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "min"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(47, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "TIEMPO"
        '
        'compu2
        '
        Me.compu2.BackgroundImage = CType(resources.GetObject("compu2.BackgroundImage"), System.Drawing.Image)
        Me.compu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.compu2.Enabled = False
        Me.compu2.Location = New System.Drawing.Point(429, 51)
        Me.compu2.Name = "compu2"
        Me.compu2.Size = New System.Drawing.Size(96, 89)
        Me.compu2.TabIndex = 34
        Me.compu2.UseVisualStyleBackColor = True
        '
        'DOS
        '
        Me.DOS.AutoSize = True
        Me.DOS.BackColor = System.Drawing.Color.Transparent
        Me.DOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOS.ForeColor = System.Drawing.Color.White
        Me.DOS.Location = New System.Drawing.Point(379, 173)
        Me.DOS.Name = "DOS"
        Me.DOS.Size = New System.Drawing.Size(190, 33)
        Me.DOS.TabIndex = 38
        Me.DOS.Text = "Elige una Pc"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1019, 692)
        Me.Controls.Add(Me.DOS)
        Me.Controls.Add(Me.compu2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonREINICIAR)
        Me.Controls.Add(Me.ButtonCERRAR)
        Me.Controls.Add(Me.ButtonAÑADIR)
        Me.Controls.Add(Me.TextBoxMENSAJES1)
        Me.Controls.Add(Me.ButtonINICIAR)
        Me.Controls.Add(Me.ButtonAPAGAR)
        Me.Controls.Add(Me.ButtonBLOQUEO)
        Me.Controls.Add(Me.NumM1)
        Me.Controls.Add(Me.NumH1)
        Me.Controls.Add(Me.TextBoxPUERTO1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRADOR"
        CType(Me.NumH1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumM1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxPUERTO1 As System.Windows.Forms.TextBox
    Friend WithEvents NumH1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumM1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonBLOQUEO As System.Windows.Forms.Button
    Friend WithEvents ButtonAPAGAR As System.Windows.Forms.Button
    Friend WithEvents ButtonINICIAR As System.Windows.Forms.Button
    Friend WithEvents TextBoxMENSAJES1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAÑADIR As System.Windows.Forms.Button
    Friend WithEvents ButtonCERRAR As System.Windows.Forms.Button
    Friend WithEvents ButtonREINICIAR As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents compu2 As Button
    Friend WithEvents DOS As Label
End Class
