<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblDataTime = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnsMenu = New System.Windows.Forms.MenuStrip()
        Me.tsmQuanLi = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSanPham = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmKhachHang = New System.Windows.Forms.ToolStripMenuItem()
        Me.DữLiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSP = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmKH = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(9, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "By: Trần Tấn Phong"
        '
        'lblDataTime
        '
        Me.lblDataTime.AutoSize = True
        Me.lblDataTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblDataTime.ForeColor = System.Drawing.Color.Red
        Me.lblDataTime.Location = New System.Drawing.Point(365, 25)
        Me.lblDataTime.Name = "lblDataTime"
        Me.lblDataTime.Size = New System.Drawing.Size(49, 16)
        Me.lblDataTime.TabIndex = 7
        Me.lblDataTime.Text = "Ngày:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PS01408_QLCuaHangGo.My.Resources.Resources.logogiuongngu
        Me.PictureBox1.Location = New System.Drawing.Point(0, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 297)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'mnsMenu
        '
        Me.mnsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmQuanLi, Me.DữLiệuToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.mnsMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnsMenu.Name = "mnsMenu"
        Me.mnsMenu.Size = New System.Drawing.Size(526, 24)
        Me.mnsMenu.TabIndex = 5
        '
        'tsmQuanLi
        '
        Me.tsmQuanLi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSanPham, Me.tsmKhachHang})
        Me.tsmQuanLi.Name = "tsmQuanLi"
        Me.tsmQuanLi.Size = New System.Drawing.Size(63, 20)
        Me.tsmQuanLi.Text = "Quản Lý"
        '
        'tsmSanPham
        '
        Me.tsmSanPham.Name = "tsmSanPham"
        Me.tsmSanPham.Size = New System.Drawing.Size(152, 22)
        Me.tsmSanPham.Text = "Sản phẩm"
        '
        'tsmKhachHang
        '
        Me.tsmKhachHang.Name = "tsmKhachHang"
        Me.tsmKhachHang.Size = New System.Drawing.Size(152, 22)
        Me.tsmKhachHang.Text = "Khách hàng"
        '
        'DữLiệuToolStripMenuItem
        '
        Me.DữLiệuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSP, Me.tsmKH})
        Me.DữLiệuToolStripMenuItem.Name = "DữLiệuToolStripMenuItem"
        Me.DữLiệuToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.DữLiệuToolStripMenuItem.Text = "Tìm Kiếm Dữ liệu"
        '
        'tsmSP
        '
        Me.tsmSP.Name = "tsmSP"
        Me.tsmSP.Size = New System.Drawing.Size(152, 22)
        Me.tsmSP.Text = "Sản phẩm"
        '
        'tsmKH
        '
        Me.tsmKH.Name = "tsmKH"
        Me.tsmKH.Size = New System.Drawing.Size(152, 22)
        Me.tsmKH.Text = "Khách hàng"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.ThoátToolStripMenuItem.Text = "Thoát ứng dụng"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 349)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDataTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mnsMenu)
        Me.Name = "frmMain"
        Me.Text = "Chào mừng bạn đến với ứng dụng"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsMenu.ResumeLayout(False)
        Me.mnsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDataTime As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents mnsMenu As MenuStrip
    Friend WithEvents tsmQuanLi As ToolStripMenuItem
    Friend WithEvents tsmSanPham As ToolStripMenuItem
    Friend WithEvents tsmKhachHang As ToolStripMenuItem
    Friend WithEvents DữLiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmSP As ToolStripMenuItem
    Friend WithEvents tsmKH As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
End Class
