<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnaForm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HastaListeleButton = New System.Windows.Forms.Button()
        Me.IlacListeleButton = New System.Windows.Forms.Button()
        Me.IlacEkleButton = New System.Windows.Forms.Button()
        Me.HastaEkleButton = New System.Windows.Forms.Button()
        Me.SatisYapButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(675, 426)
        Me.DataGridView1.TabIndex = 8
        '
        'HastaListeleButton
        '
        Me.HastaListeleButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HastaListeleButton.Location = New System.Drawing.Point(727, 12)
        Me.HastaListeleButton.Name = "HastaListeleButton"
        Me.HastaListeleButton.Size = New System.Drawing.Size(115, 72)
        Me.HastaListeleButton.TabIndex = 9
        Me.HastaListeleButton.Text = "Hastaları Listele"
        Me.HastaListeleButton.UseVisualStyleBackColor = False
        '
        'IlacListeleButton
        '
        Me.IlacListeleButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IlacListeleButton.Location = New System.Drawing.Point(727, 90)
        Me.IlacListeleButton.Name = "IlacListeleButton"
        Me.IlacListeleButton.Size = New System.Drawing.Size(115, 72)
        Me.IlacListeleButton.TabIndex = 10
        Me.IlacListeleButton.Text = "İlaçları Listele"
        Me.IlacListeleButton.UseVisualStyleBackColor = False
        '
        'IlacEkleButton
        '
        Me.IlacEkleButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.IlacEkleButton.Location = New System.Drawing.Point(727, 353)
        Me.IlacEkleButton.Name = "IlacEkleButton"
        Me.IlacEkleButton.Size = New System.Drawing.Size(115, 36)
        Me.IlacEkleButton.TabIndex = 11
        Me.IlacEkleButton.Text = "İlaç Ekle"
        Me.IlacEkleButton.UseVisualStyleBackColor = False
        '
        'HastaEkleButton
        '
        Me.HastaEkleButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.HastaEkleButton.Location = New System.Drawing.Point(727, 311)
        Me.HastaEkleButton.Name = "HastaEkleButton"
        Me.HastaEkleButton.Size = New System.Drawing.Size(115, 36)
        Me.HastaEkleButton.TabIndex = 12
        Me.HastaEkleButton.Text = "Hasta Ekle"
        Me.HastaEkleButton.UseVisualStyleBackColor = False
        '
        'SatisYapButton
        '
        Me.SatisYapButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SatisYapButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SatisYapButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SatisYapButton.Location = New System.Drawing.Point(727, 269)
        Me.SatisYapButton.Name = "SatisYapButton"
        Me.SatisYapButton.Size = New System.Drawing.Size(115, 36)
        Me.SatisYapButton.TabIndex = 13
        Me.SatisYapButton.Text = "Satış Yap"
        Me.SatisYapButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(749, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Uygulamayı Kapat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 451)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SatisYapButton)
        Me.Controls.Add(Me.HastaEkleButton)
        Me.Controls.Add(Me.IlacEkleButton)
        Me.Controls.Add(Me.IlacListeleButton)
        Me.Controls.Add(Me.HastaListeleButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AnaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eczane Otomasyonu | Furkan EROĞLU"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HastaListeleButton As Button
    Friend WithEvents IlacListeleButton As Button
    Friend WithEvents IlacEkleButton As Button
    Friend WithEvents HastaEkleButton As Button
    Friend WithEvents SatisYapButton As Button
    Friend WithEvents Button1 As Button
End Class
