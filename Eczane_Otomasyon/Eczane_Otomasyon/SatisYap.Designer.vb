<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SatisYap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SatisYap))
        Me.ListeleButton = New System.Windows.Forms.Button()
        Me.HastaKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.İlaçKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuzenleButton = New System.Windows.Forms.Button()
        Me.SilButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IslemDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SatButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HastalarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnaEkranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MiktarNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HastaTCTextBox = New System.Windows.Forms.TextBox()
        Me.IlacTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MiktarNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListeleButton
        '
        Me.ListeleButton.Location = New System.Drawing.Point(923, 306)
        Me.ListeleButton.Name = "ListeleButton"
        Me.ListeleButton.Size = New System.Drawing.Size(75, 23)
        Me.ListeleButton.TabIndex = 62
        Me.ListeleButton.Text = "Listele"
        Me.ListeleButton.UseVisualStyleBackColor = True
        '
        'HastaKaydıToolStripMenuItem
        '
        Me.HastaKaydıToolStripMenuItem.Name = "HastaKaydıToolStripMenuItem"
        Me.HastaKaydıToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.HastaKaydıToolStripMenuItem.Text = "Formu Kapat"
        '
        'İlaçKaydıToolStripMenuItem
        '
        Me.İlaçKaydıToolStripMenuItem.Name = "İlaçKaydıToolStripMenuItem"
        Me.İlaçKaydıToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.İlaçKaydıToolStripMenuItem.Text = "İlaçlar"
        '
        'DuzenleButton
        '
        Me.DuzenleButton.Location = New System.Drawing.Point(957, 265)
        Me.DuzenleButton.Name = "DuzenleButton"
        Me.DuzenleButton.Size = New System.Drawing.Size(99, 35)
        Me.DuzenleButton.TabIndex = 54
        Me.DuzenleButton.Text = "Düzenle"
        Me.DuzenleButton.UseVisualStyleBackColor = True
        '
        'SilButton
        '
        Me.SilButton.Location = New System.Drawing.Point(865, 265)
        Me.SilButton.Name = "SilButton"
        Me.SilButton.Size = New System.Drawing.Size(86, 35)
        Me.SilButton.TabIndex = 53
        Me.SilButton.Text = "Sil"
        Me.SilButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(864, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "İşlem Tarihi:"
        '
        'IslemDateTimePicker
        '
        Me.IslemDateTimePicker.Location = New System.Drawing.Point(945, 130)
        Me.IslemDateTimePicker.Name = "IslemDateTimePicker"
        Me.IslemDateTimePicker.Size = New System.Drawing.Size(115, 20)
        Me.IslemDateTimePicker.TabIndex = 51
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(846, 369)
        Me.DataGridView1.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(864, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Sosyal Güvenlik"
        '
        'SatButton
        '
        Me.SatButton.Location = New System.Drawing.Point(864, 224)
        Me.SatButton.Name = "SatButton"
        Me.SatButton.Size = New System.Drawing.Size(192, 35)
        Me.SatButton.TabIndex = 48
        Me.SatButton.Text = "Satış Yap"
        Me.SatButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HastaKaydıToolStripMenuItem, Me.İlaçKaydıToolStripMenuItem, Me.HastalarToolStripMenuItem, Me.AnaEkranToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1074, 24)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HastalarToolStripMenuItem
        '
        Me.HastalarToolStripMenuItem.Name = "HastalarToolStripMenuItem"
        Me.HastalarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.HastalarToolStripMenuItem.Text = "Hastalar"
        '
        'AnaEkranToolStripMenuItem
        '
        Me.AnaEkranToolStripMenuItem.Name = "AnaEkranToolStripMenuItem"
        Me.AnaEkranToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AnaEkranToolStripMenuItem.Text = "Ana Ekran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(864, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Miktar:"
        '
        'MiktarNUD
        '
        Me.MiktarNUD.Location = New System.Drawing.Point(945, 77)
        Me.MiktarNUD.Name = "MiktarNUD"
        Me.MiktarNUD.Size = New System.Drawing.Size(57, 20)
        Me.MiktarNUD.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(864, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "İlaç Adı:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(864, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Hasta TC:"
        '
        'HastaTCTextBox
        '
        Me.HastaTCTextBox.Location = New System.Drawing.Point(945, 24)
        Me.HastaTCTextBox.Name = "HastaTCTextBox"
        Me.HastaTCTextBox.Size = New System.Drawing.Size(115, 20)
        Me.HastaTCTextBox.TabIndex = 66
        '
        'IlacTextBox
        '
        Me.IlacTextBox.Location = New System.Drawing.Point(945, 50)
        Me.IlacTextBox.Name = "IlacTextBox"
        Me.IlacTextBox.Size = New System.Drawing.Size(115, 20)
        Me.IlacTextBox.TabIndex = 67
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SSK", "BAĞKUR"})
        Me.ComboBox1.Location = New System.Drawing.Point(945, 103)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox1.TabIndex = 68
        '
        'SatisYap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 418)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.IlacTextBox)
        Me.Controls.Add(Me.HastaTCTextBox)
        Me.Controls.Add(Me.MiktarNUD)
        Me.Controls.Add(Me.ListeleButton)
        Me.Controls.Add(Me.DuzenleButton)
        Me.Controls.Add(Me.SilButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IslemDateTimePicker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SatButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SatisYap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reçete Satışı"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MiktarNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListeleButton As Button
    Friend WithEvents HastaKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents İlaçKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DuzenleButton As Button
    Friend WithEvents SilButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents IslemDateTimePicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents SatButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HastalarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnaEkranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents MiktarNUD As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HastaTCTextBox As TextBox
    Friend WithEvents IlacTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
