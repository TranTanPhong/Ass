<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSanPham
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCuoi = New System.Windows.Forms.Button()
        Me.btnLui = New System.Windows.Forms.Button()
        Me.btnTien = New System.Windows.Forms.Button()
        Me.btnDau = New System.Windows.Forms.Button()
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.tbnThem = New System.Windows.Forms.Button()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bsSP = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(21, 186)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 23)
        Me.btnBack.TabIndex = 90
        Me.btnBack.Text = "Quay lại"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCuoi
        '
        Me.btnCuoi.Location = New System.Drawing.Point(299, 186)
        Me.btnCuoi.Name = "btnCuoi"
        Me.btnCuoi.Size = New System.Drawing.Size(58, 23)
        Me.btnCuoi.TabIndex = 89
        Me.btnCuoi.Text = ">>"
        Me.btnCuoi.UseVisualStyleBackColor = True
        '
        'btnLui
        '
        Me.btnLui.Location = New System.Drawing.Point(238, 186)
        Me.btnLui.Name = "btnLui"
        Me.btnLui.Size = New System.Drawing.Size(55, 23)
        Me.btnLui.TabIndex = 88
        Me.btnLui.Text = ">"
        Me.btnLui.UseVisualStyleBackColor = True
        '
        'btnTien
        '
        Me.btnTien.Location = New System.Drawing.Point(174, 186)
        Me.btnTien.Name = "btnTien"
        Me.btnTien.Size = New System.Drawing.Size(58, 23)
        Me.btnTien.TabIndex = 87
        Me.btnTien.Text = "<"
        Me.btnTien.UseVisualStyleBackColor = True
        '
        'btnDau
        '
        Me.btnDau.Location = New System.Drawing.Point(110, 186)
        Me.btnDau.Name = "btnDau"
        Me.btnDau.Size = New System.Drawing.Size(58, 23)
        Me.btnDau.TabIndex = 86
        Me.btnDau.Text = "<<"
        Me.btnDau.UseVisualStyleBackColor = True
        '
        'dgvSP
        '
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(16, 248)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.Size = New System.Drawing.Size(424, 150)
        Me.dgvSP.TabIndex = 85
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(344, 218)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(96, 23)
        Me.btnLuu.TabIndex = 84
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(231, 218)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(96, 23)
        Me.btnXoa.TabIndex = 83
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(118, 218)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(96, 23)
        Me.btnSua.TabIndex = 82
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'tbnThem
        '
        Me.tbnThem.Location = New System.Drawing.Point(16, 218)
        Me.tbnThem.Name = "tbnThem"
        Me.tbnThem.Size = New System.Drawing.Size(96, 23)
        Me.tbnThem.TabIndex = 81
        Me.tbnThem.Text = "Thêm"
        Me.tbnThem.UseVisualStyleBackColor = True
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(122, 103)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(209, 20)
        Me.txtSoLuong.TabIndex = 80
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(122, 76)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(209, 20)
        Me.txtTenSP.TabIndex = 78
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(122, 49)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(209, 20)
        Me.txtMaSP.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Số Lượng:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(117, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 25)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Quản Lý Sản Phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Tên Sản Phẩm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(122, 129)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.Size = New System.Drawing.Size(209, 20)
        Me.txtMaLoai.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Mã loại:"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(122, 155)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(209, 20)
        Me.txtTenLoai.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Tên loại:"
        '
        'frmQLSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 406)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCuoi)
        Me.Controls.Add(Me.btnLui)
        Me.Controls.Add(Me.btnTien)
        Me.Controls.Add(Me.btnDau)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.tbnThem)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLSanPham"
        Me.Text = "Quản Lí Sản Phẩm"
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnCuoi As Button
    Friend WithEvents btnLui As Button
    Friend WithEvents btnTien As Button
    Friend WithEvents btnDau As Button
    Friend WithEvents dgvSP As DataGridView
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents tbnThem As Button
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTenLoai As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bsSP As BindingSource
End Class
