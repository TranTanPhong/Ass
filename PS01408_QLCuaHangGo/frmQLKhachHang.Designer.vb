<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLKhachHang
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
        Me.dgvKH = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCuoi = New System.Windows.Forms.Button()
        Me.btnLui = New System.Windows.Forms.Button()
        Me.btnTien = New System.Windows.Forms.Button()
        Me.btnDau = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.tbnThem = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bsKH = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKH
        '
        Me.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKH.Location = New System.Drawing.Point(12, 261)
        Me.dgvKH.Name = "dgvKH"
        Me.dgvKH.Size = New System.Drawing.Size(423, 150)
        Me.dgvKH.TabIndex = 78
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 196)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 23)
        Me.btnBack.TabIndex = 77
        Me.btnBack.Text = "Quay lại"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCuoi
        '
        Me.btnCuoi.Location = New System.Drawing.Point(290, 196)
        Me.btnCuoi.Name = "btnCuoi"
        Me.btnCuoi.Size = New System.Drawing.Size(58, 23)
        Me.btnCuoi.TabIndex = 76
        Me.btnCuoi.Text = ">>"
        Me.btnCuoi.UseVisualStyleBackColor = True
        '
        'btnLui
        '
        Me.btnLui.Location = New System.Drawing.Point(229, 196)
        Me.btnLui.Name = "btnLui"
        Me.btnLui.Size = New System.Drawing.Size(55, 23)
        Me.btnLui.TabIndex = 75
        Me.btnLui.Text = ">"
        Me.btnLui.UseVisualStyleBackColor = True
        '
        'btnTien
        '
        Me.btnTien.Location = New System.Drawing.Point(165, 196)
        Me.btnTien.Name = "btnTien"
        Me.btnTien.Size = New System.Drawing.Size(58, 23)
        Me.btnTien.TabIndex = 74
        Me.btnTien.Text = "<"
        Me.btnTien.UseVisualStyleBackColor = True
        '
        'btnDau
        '
        Me.btnDau.Location = New System.Drawing.Point(101, 196)
        Me.btnDau.Name = "btnDau"
        Me.btnDau.Size = New System.Drawing.Size(58, 23)
        Me.btnDau.TabIndex = 73
        Me.btnDau.Text = "<<"
        Me.btnDau.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(340, 232)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(96, 23)
        Me.btnLuu.TabIndex = 72
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(230, 232)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(96, 23)
        Me.btnXoa.TabIndex = 71
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(120, 232)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(96, 23)
        Me.btnSua.TabIndex = 70
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'tbnThem
        '
        Me.tbnThem.Location = New System.Drawing.Point(12, 232)
        Me.tbnThem.Name = "tbnThem"
        Me.tbnThem.Size = New System.Drawing.Size(96, 23)
        Me.tbnThem.TabIndex = 69
        Me.tbnThem.Text = "Thêm"
        Me.tbnThem.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(114, 160)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(209, 20)
        Me.txtEmail.TabIndex = 68
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(114, 134)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(209, 20)
        Me.txtSDT.TabIndex = 67
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(114, 107)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(209, 20)
        Me.txtDiaChi.TabIndex = 66
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(114, 79)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(209, 20)
        Me.txtTenKH.TabIndex = 65
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(114, 52)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(209, 20)
        Me.txtMaKH.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Số Điện Thoại:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Địa Chỉ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(101, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Quản Lý Khách Hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Tên Khách Hàng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Mã Khách Hàng:"
        '
        'frmQLKhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 423)
        Me.Controls.Add(Me.dgvKH)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCuoi)
        Me.Controls.Add(Me.btnLui)
        Me.Controls.Add(Me.btnTien)
        Me.Controls.Add(Me.btnDau)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.tbnThem)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLKhachHang"
        Me.Text = "Quản lý khách hàng"
        CType(Me.dgvKH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvKH As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCuoi As Button
    Friend WithEvents btnLui As Button
    Friend WithEvents btnTien As Button
    Friend WithEvents btnDau As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents tbnThem As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtTenKH As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bsKH As BindingSource
End Class
