<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HastaEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HastaEkle))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AraTextBox = New System.Windows.Forms.TextBox()
        Me.AraButton = New System.Windows.Forms.Button()
        Me.DuzenleButton = New System.Windows.Forms.Button()
        Me.SilButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SoyadiTextBox = New System.Windows.Forms.TextBox()
        Me.AdiTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.İlaçKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HastaKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaydetButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TCTextBox = New System.Windows.Forms.TextBox()
        Me.CepTelTextBox = New System.Windows.Forms.TextBox()
        Me.DogumDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CinsiyetComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Hasta TC:"
        '
        'AraTextBox
        '
        Me.AraTextBox.Location = New System.Drawing.Point(71, 36)
        Me.AraTextBox.Name = "AraTextBox"
        Me.AraTextBox.Size = New System.Drawing.Size(298, 20)
        Me.AraTextBox.TabIndex = 35
        '
        'AraButton
        '
        Me.AraButton.Location = New System.Drawing.Point(389, 28)
        Me.AraButton.Name = "AraButton"
        Me.AraButton.Size = New System.Drawing.Size(95, 35)
        Me.AraButton.TabIndex = 34
        Me.AraButton.Text = "Ara"
        Me.AraButton.UseVisualStyleBackColor = True
        '
        'DuzenleButton
        '
        Me.DuzenleButton.Location = New System.Drawing.Point(881, 310)
        Me.DuzenleButton.Name = "DuzenleButton"
        Me.DuzenleButton.Size = New System.Drawing.Size(99, 35)
        Me.DuzenleButton.TabIndex = 33
        Me.DuzenleButton.Text = "Düzenle"
        Me.DuzenleButton.UseVisualStyleBackColor = True
        '
        'SilButton
        '
        Me.SilButton.Location = New System.Drawing.Point(789, 310)
        Me.SilButton.Name = "SilButton"
        Me.SilButton.Size = New System.Drawing.Size(86, 35)
        Me.SilButton.TabIndex = 32
        Me.SilButton.Text = "Sil"
        Me.SilButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(788, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Doğum Tarihi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(788, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "TC Kimlik:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(770, 369)
        Me.DataGridView1.TabIndex = 26
        '
        'SoyadiTextBox
        '
        Me.SoyadiTextBox.Location = New System.Drawing.Point(847, 121)
        Me.SoyadiTextBox.Name = "SoyadiTextBox"
        Me.SoyadiTextBox.Size = New System.Drawing.Size(133, 20)
        Me.SoyadiTextBox.TabIndex = 24
        '
        'AdiTextBox
        '
        Me.AdiTextBox.Location = New System.Drawing.Point(847, 95)
        Me.AdiTextBox.Name = "AdiTextBox"
        Me.AdiTextBox.Size = New System.Drawing.Size(133, 20)
        Me.AdiTextBox.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(788, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cep Tel:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(788, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Soyadı:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(788, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Adı:"
        '
        'İlaçKaydıToolStripMenuItem
        '
        Me.İlaçKaydıToolStripMenuItem.Name = "İlaçKaydıToolStripMenuItem"
        Me.İlaçKaydıToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.İlaçKaydıToolStripMenuItem.Text = "İlaçlar"
        '
        'HastaKaydıToolStripMenuItem
        '
        Me.HastaKaydıToolStripMenuItem.Name = "HastaKaydıToolStripMenuItem"
        Me.HastaKaydıToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.HastaKaydıToolStripMenuItem.Text = "Formu Kapat"
        '
        'KaydetButton
        '
        Me.KaydetButton.Location = New System.Drawing.Point(791, 269)
        Me.KaydetButton.Name = "KaydetButton"
        Me.KaydetButton.Size = New System.Drawing.Size(189, 35)
        Me.KaydetButton.TabIndex = 25
        Me.KaydetButton.Text = "Kaydet"
        Me.KaydetButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HastaKaydıToolStripMenuItem, Me.İlaçKaydıToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1004, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TCTextBox
        '
        Me.TCTextBox.Location = New System.Drawing.Point(847, 69)
        Me.TCTextBox.Name = "TCTextBox"
        Me.TCTextBox.Size = New System.Drawing.Size(133, 20)
        Me.TCTextBox.TabIndex = 37
        '
        'CepTelTextBox
        '
        Me.CepTelTextBox.Location = New System.Drawing.Point(847, 174)
        Me.CepTelTextBox.Name = "CepTelTextBox"
        Me.CepTelTextBox.Size = New System.Drawing.Size(133, 20)
        Me.CepTelTextBox.TabIndex = 38
        '
        'DogumDateTimePicker
        '
        Me.DogumDateTimePicker.Location = New System.Drawing.Point(865, 200)
        Me.DogumDateTimePicker.Name = "DogumDateTimePicker"
        Me.DogumDateTimePicker.Size = New System.Drawing.Size(115, 20)
        Me.DogumDateTimePicker.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(788, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Cinsiyet:"
        '
        'CinsiyetComboBox
        '
        Me.CinsiyetComboBox.FormattingEnabled = True
        Me.CinsiyetComboBox.Items.AddRange(New Object() {"E", "K"})
        Me.CinsiyetComboBox.Location = New System.Drawing.Point(865, 147)
        Me.CinsiyetComboBox.Name = "CinsiyetComboBox"
        Me.CinsiyetComboBox.Size = New System.Drawing.Size(115, 21)
        Me.CinsiyetComboBox.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(847, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Listele"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HastaEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CinsiyetComboBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CepTelTextBox)
        Me.Controls.Add(Me.TCTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AraTextBox)
        Me.Controls.Add(Me.AraButton)
        Me.Controls.Add(Me.DuzenleButton)
        Me.Controls.Add(Me.SilButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DogumDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SoyadiTextBox)
        Me.Controls.Add(Me.AdiTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KaydetButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HastaEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Hasta Ekle"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents AraTextBox As TextBox
    Friend WithEvents AraButton As Button
    Friend WithEvents DuzenleButton As Button
    Friend WithEvents SilButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SoyadiTextBox As TextBox
    Friend WithEvents AdiTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents İlaçKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HastaKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaydetButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TCTextBox As TextBox
    Friend WithEvents CepTelTextBox As TextBox
    Friend WithEvents DogumDateTimePicker As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents CinsiyetComboBox As ComboBox
    Friend WithEvents Button1 As Button
End Class
