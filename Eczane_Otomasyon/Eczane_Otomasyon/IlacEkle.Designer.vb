<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IlacEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IlacEkle))
        Me.FiyatTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxAra = New System.Windows.Forms.TextBox()
        Me.AraButton = New System.Windows.Forms.Button()
        Me.DuzenleButton = New System.Windows.Forms.Button()
        Me.SilButton = New System.Windows.Forms.Button()
        Me.HastaKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.İlaçKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AdiTextBox = New System.Windows.Forms.TextBox()
        Me.BarkodTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KaydetButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MiktarNUD = New System.Windows.Forms.NumericUpDown()
        Me.ListeleButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MiktarNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FiyatTextBox
        '
        Me.FiyatTextBox.Location = New System.Drawing.Point(775, 131)
        Me.FiyatTextBox.Name = "FiyatTextBox"
        Me.FiyatTextBox.Size = New System.Drawing.Size(133, 20)
        Me.FiyatTextBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Barkod:"
        '
        'TextBoxAra
        '
        Me.TextBoxAra.Location = New System.Drawing.Point(71, 36)
        Me.TextBoxAra.Name = "TextBoxAra"
        Me.TextBoxAra.Size = New System.Drawing.Size(298, 20)
        Me.TextBoxAra.TabIndex = 53
        '
        'AraButton
        '
        Me.AraButton.Location = New System.Drawing.Point(389, 28)
        Me.AraButton.Name = "AraButton"
        Me.AraButton.Size = New System.Drawing.Size(95, 35)
        Me.AraButton.TabIndex = 52
        Me.AraButton.Text = "Ara"
        Me.AraButton.UseVisualStyleBackColor = True
        '
        'DuzenleButton
        '
        Me.DuzenleButton.Location = New System.Drawing.Point(808, 299)
        Me.DuzenleButton.Name = "DuzenleButton"
        Me.DuzenleButton.Size = New System.Drawing.Size(95, 35)
        Me.DuzenleButton.TabIndex = 5
        Me.DuzenleButton.Text = "Düzenle"
        Me.DuzenleButton.UseVisualStyleBackColor = True
        '
        'SilButton
        '
        Me.SilButton.Location = New System.Drawing.Point(707, 299)
        Me.SilButton.Name = "SilButton"
        Me.SilButton.Size = New System.Drawing.Size(95, 35)
        Me.SilButton.TabIndex = 4
        Me.SilButton.Text = "Sil"
        Me.SilButton.UseVisualStyleBackColor = True
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
        Me.İlaçKaydıToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.İlaçKaydıToolStripMenuItem.Text = "Hastalar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(706, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Fiyat:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(674, 369)
        Me.DataGridView1.TabIndex = 46
        '
        'AdiTextBox
        '
        Me.AdiTextBox.Location = New System.Drawing.Point(775, 105)
        Me.AdiTextBox.Name = "AdiTextBox"
        Me.AdiTextBox.Size = New System.Drawing.Size(133, 20)
        Me.AdiTextBox.TabIndex = 0
        '
        'BarkodTextBox
        '
        Me.BarkodTextBox.Location = New System.Drawing.Point(775, 185)
        Me.BarkodTextBox.Name = "BarkodTextBox"
        Me.BarkodTextBox.Size = New System.Drawing.Size(133, 20)
        Me.BarkodTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(704, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Miktar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(706, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "İlaç Adı:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(704, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "İlaç Barkod:"
        '
        'KaydetButton
        '
        Me.KaydetButton.Location = New System.Drawing.Point(707, 258)
        Me.KaydetButton.Name = "KaydetButton"
        Me.KaydetButton.Size = New System.Drawing.Size(196, 35)
        Me.KaydetButton.TabIndex = 6
        Me.KaydetButton.Text = "Kaydet"
        Me.KaydetButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HastaKaydıToolStripMenuItem, Me.İlaçKaydıToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(920, 24)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MiktarNUD
        '
        Me.MiktarNUD.Location = New System.Drawing.Point(775, 159)
        Me.MiktarNUD.Name = "MiktarNUD"
        Me.MiktarNUD.Size = New System.Drawing.Size(63, 20)
        Me.MiktarNUD.TabIndex = 2
        '
        'ListeleButton
        '
        Me.ListeleButton.Location = New System.Drawing.Point(775, 340)
        Me.ListeleButton.Name = "ListeleButton"
        Me.ListeleButton.Size = New System.Drawing.Size(75, 23)
        Me.ListeleButton.TabIndex = 55
        Me.ListeleButton.Text = "Listele"
        Me.ListeleButton.UseVisualStyleBackColor = True
        '
        'IlacEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 450)
        Me.Controls.Add(Me.ListeleButton)
        Me.Controls.Add(Me.MiktarNUD)
        Me.Controls.Add(Me.FiyatTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxAra)
        Me.Controls.Add(Me.AraButton)
        Me.Controls.Add(Me.DuzenleButton)
        Me.Controls.Add(Me.SilButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AdiTextBox)
        Me.Controls.Add(Me.BarkodTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KaydetButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IlacEkle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "İlaç Ekle"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MiktarNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FiyatTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxAra As TextBox
    Friend WithEvents AraButton As Button
    Friend WithEvents DuzenleButton As Button
    Friend WithEvents SilButton As Button
    Friend WithEvents HastaKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents İlaçKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents AdiTextBox As TextBox
    Friend WithEvents BarkodTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents KaydetButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MiktarNUD As NumericUpDown
    Friend WithEvents ListeleButton As Button
End Class
