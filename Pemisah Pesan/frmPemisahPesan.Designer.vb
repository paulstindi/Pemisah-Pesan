<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPemisahPesan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPesanOringinal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaxKarater = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lsvDaftarPesan = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblKet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Isi Pesan :"
        '
        'txtPesanOringinal
        '
        Me.txtPesanOringinal.Location = New System.Drawing.Point(13, 37)
        Me.txtPesanOringinal.Multiline = True
        Me.txtPesanOringinal.Name = "txtPesanOringinal"
        Me.txtPesanOringinal.Size = New System.Drawing.Size(671, 136)
        Me.txtPesanOringinal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Batas Panjang Karakter Per Pesan :"
        '
        'txtMaxKarater
        '
        Me.txtMaxKarater.Location = New System.Drawing.Point(281, 205)
        Me.txtMaxKarater.Name = "txtMaxKarater"
        Me.txtMaxKarater.Size = New System.Drawing.Size(70, 26)
        Me.txtMaxKarater.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 70)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Pisahkan Pesan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lsvDaftarPesan
        '
        Me.lsvDaftarPesan.Location = New System.Drawing.Point(17, 256)
        Me.lsvDaftarPesan.Name = "lsvDaftarPesan"
        Me.lsvDaftarPesan.Size = New System.Drawing.Size(666, 137)
        Me.lsvDaftarPesan.TabIndex = 5
        Me.lsvDaftarPesan.UseCompatibleStateImageBehavior = False
        Me.lsvDaftarPesan.View = System.Windows.Forms.View.List
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Daftar Pesan Yang Dipisahkan :"
        '
        'lblKet
        '
        Me.lblKet.AutoSize = True
        Me.lblKet.Location = New System.Drawing.Point(13, 182)
        Me.lblKet.Name = "lblKet"
        Me.lblKet.Size = New System.Drawing.Size(262, 20)
        Me.lblKet.TabIndex = 7
        Me.lblKet.Text = "Batas Panjang Karakter Per Pesan :"
        '
        'frmPemisahPesan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 459)
        Me.Controls.Add(Me.lblKet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lsvDaftarPesan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMaxKarater)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPesanOringinal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPemisahPesan"
        Me.Text = "Contoh Pemisah Pesan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPesanOringinal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaxKarater As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lsvDaftarPesan As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblKet As Label
End Class
