<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGantiPassword
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtPBaru = New DevExpress.XtraEditors.TextEdit()
        Me.txtUlangiPBaru = New DevExpress.XtraEditors.TextEdit()
        Me.txtPLama = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.txtPBaru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUlangiPBaru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPLama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 115)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(95, 29)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "Simpan"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(177, 115)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(95, 29)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Batal"
        '
        'txtPBaru
        '
        Me.txtPBaru.Location = New System.Drawing.Point(135, 38)
        Me.txtPBaru.Name = "txtPBaru"
        Me.txtPBaru.Size = New System.Drawing.Size(137, 20)
        Me.txtPBaru.TabIndex = 1
        '
        'txtUlangiPBaru
        '
        Me.txtUlangiPBaru.Location = New System.Drawing.Point(135, 64)
        Me.txtUlangiPBaru.Name = "txtUlangiPBaru"
        Me.txtUlangiPBaru.Size = New System.Drawing.Size(137, 20)
        Me.txtUlangiPBaru.TabIndex = 2
        '
        'txtPLama
        '
        Me.txtPLama.Location = New System.Drawing.Point(135, 12)
        Me.txtPLama.Name = "txtPLama"
        Me.txtPLama.Size = New System.Drawing.Size(137, 20)
        Me.txtPLama.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Password Lama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password Baru :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ulangi Password Baru :"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(12, 90)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Tampilkan Password"
        Me.CheckEdit1.Size = New System.Drawing.Size(122, 19)
        Me.CheckEdit1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(141, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 9
        '
        'frmGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 156)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPLama)
        Me.Controls.Add(Me.txtUlangiPBaru)
        Me.Controls.Add(Me.txtPBaru)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "frmGantiPassword"
        CType(Me.txtPBaru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUlangiPBaru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPLama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPBaru As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUlangiPBaru As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPLama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
