<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ImprimirButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Texto = New System.Windows.Forms.Label()
        Me.EscCheckBox = New System.Windows.Forms.CheckBox()
        Me.CharNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImpresoraTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.CharNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImprimirButton
        '
        Me.ImprimirButton.Location = New System.Drawing.Point(70, 120)
        Me.ImprimirButton.Name = "ImprimirButton"
        Me.ImprimirButton.Size = New System.Drawing.Size(75, 23)
        Me.ImprimirButton.TabIndex = 0
        Me.ImprimirButton.Text = "Imprimir"
        Me.ImprimirButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Texto
        '
        Me.Texto.AutoSize = True
        Me.Texto.Location = New System.Drawing.Point(133, 64)
        Me.Texto.Name = "Texto"
        Me.Texto.Size = New System.Drawing.Size(34, 13)
        Me.Texto.TabIndex = 2
        Me.Texto.Text = "Texto"
        '
        'EscCheckBox
        '
        Me.EscCheckBox.AutoSize = True
        Me.EscCheckBox.Location = New System.Drawing.Point(9, 82)
        Me.EscCheckBox.Name = "EscCheckBox"
        Me.EscCheckBox.Size = New System.Drawing.Size(44, 17)
        Me.EscCheckBox.TabIndex = 3
        Me.EscCheckBox.Text = "Esc"
        Me.EscCheckBox.UseVisualStyleBackColor = True
        '
        'CharNumericUpDown
        '
        Me.CharNumericUpDown.Location = New System.Drawing.Point(59, 78)
        Me.CharNumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.CharNumericUpDown.Name = "CharNumericUpDown"
        Me.CharNumericUpDown.Size = New System.Drawing.Size(58, 20)
        Me.CharNumericUpDown.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Impresora"
        '
        'ImpresoraTextBox
        '
        Me.ImpresoraTextBox.Location = New System.Drawing.Point(45, 22)
        Me.ImpresoraTextBox.Name = "ImpresoraTextBox"
        Me.ImpresoraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImpresoraTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "prn"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ImpresoraTextBox)
        Me.Controls.Add(Me.CharNumericUpDown)
        Me.Controls.Add(Me.EscCheckBox)
        Me.Controls.Add(Me.Texto)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ImprimirButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CharNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImprimirButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Texto As Label
    Friend WithEvents EscCheckBox As CheckBox
    Friend WithEvents CharNumericUpDown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents ImpresoraTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
