<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimKH
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
        Me.dgvTimKH = New System.Windows.Forms.DataGridView()
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.btnTim = New System.Windows.Forms.Button()
        Me.txtTimKiemSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvTimKH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTimKH
        '
        Me.dgvTimKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimKH.Location = New System.Drawing.Point(12, 110)
        Me.dgvTimKH.Name = "dgvTimKH"
        Me.dgvTimKH.Size = New System.Drawing.Size(506, 206)
        Me.dgvTimKH.TabIndex = 52
        '
        'btnQuayLai
        '
        Me.btnQuayLai.Location = New System.Drawing.Point(274, 81)
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(96, 23)
        Me.btnQuayLai.TabIndex = 51
        Me.btnQuayLai.Text = "Quay Lại"
        Me.btnQuayLai.UseVisualStyleBackColor = True
        '
        'btnTim
        '
        Me.btnTim.Location = New System.Drawing.Point(155, 81)
        Me.btnTim.Name = "btnTim"
        Me.btnTim.Size = New System.Drawing.Size(96, 23)
        Me.btnTim.TabIndex = 50
        Me.btnTim.Text = "Tìm"
        Me.btnTim.UseVisualStyleBackColor = True
        '
        'txtTimKiemSP
        '
        Me.txtTimKiemSP.Location = New System.Drawing.Point(155, 45)
        Me.txtTimKiemSP.Name = "txtTimKiemSP"
        Me.txtTimKiemSP.Size = New System.Drawing.Size(209, 20)
        Me.txtTimKiemSP.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(150, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 25)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Tìm kiếm Sản Phẩm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'frmTimKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 323)
        Me.Controls.Add(Me.dgvTimKH)
        Me.Controls.Add(Me.btnQuayLai)
        Me.Controls.Add(Me.btnTim)
        Me.Controls.Add(Me.txtTimKiemSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTimKH"
        Me.Text = "Tìm kiếm thông tin khách hàng"
        CType(Me.dgvTimKH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTimKH As DataGridView
    Friend WithEvents btnQuayLai As Button
    Friend WithEvents btnTim As Button
    Friend WithEvents txtTimKiemSP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
