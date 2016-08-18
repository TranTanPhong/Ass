Imports System.Data.SqlClient

Public Class frmQLSanPham
    Dim DB As New DataTable
    Dim lienket As String = "workstation id=Phongttps01408.mssql.somee.com;packet size=4096;user id=PS01408_SQLLogin_1;pwd=rcispqr46g;data source=Phongttps01408.mssql.somee.com;persist security info=False;initial catalog=Phongttps01408"
    Dim conn As SqlConnection = New SqlConnection(lienket)

    Private Sub loadData()
        Dim conn As SqlConnection = New SqlConnection(lienket)
        conn.Open()
        Dim lKH As New SqlDataAdapter("Select Ma_SP as 'Mã SP', Ten_SP as 'Tên SP', SoLuong as 'Số Lượng', Ma_Loai as 'Mã Loại', Ten_Loai as 'Tên loại' from QLSan_Pham", conn)
        DB.Clear()
        lKH.Fill(DB)
        dgvSP.DataSource = DB.DefaultView
        conn.Close()
    End Sub

    Private Sub frmQLSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub tbnThem_Click(sender As Object, e As EventArgs) Handles tbnThem.Click
        txtMaSP.Text = ""
        txtTenSP.Text = ""
        txtMaLoai.Text = ""
        txtSoLuong.Text = ""
        txtTenLoai.Text = ""
        txtMaSP.Focus()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim conn As SqlConnection = New SqlConnection(lienket)
        Dim Query As String = "update QLSan_Pham set Ma_SP = @Ma_SP, Ten_SP = @Ten_SP, SoLuong = @SoLuong, Ma_Loai = @Ma_Loai, Ten_Loai = @Ten_Loai where Ma_SP = @Ma_SP "
        Dim Save As SqlCommand = New SqlCommand(Query, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Or txtTenSP.Text = "" Or txtMaLoai.Text = "" Or txtSoLuong.Text = "" Or txtTenLoai.Text = "" Then
                MessageBox.Show("Bạn phải nhập tất cả không để trống!")
            Else
                Save.Parameters.AddWithValue("@Ma_SP", txtMaSP.Text)
                Save.Parameters.AddWithValue("@Ten_SP", txtTenSP.Text)
                Save.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
                Save.Parameters.AddWithValue("@Ma_Loai", txtMaLoai.Text)
                Save.Parameters.AddWithValue("@Ten_Loai", txtTenLoai.Text)
                Save.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Sửa thành công!")
                txtMaSP.Text = Nothing
                txtTenSP.Text = Nothing
                txtMaLoai.Text = Nothing
                txtTenSP.Text = Nothing
                txtSoLuong.Text = Nothing
                txtTenLoai.Text = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công!")
        End Try
        DB.Clear()
        dgvSP.DataSource = DB
        dgvSP.DataSource = Nothing
        loadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Bạn phải chọn mã sản phẩm cần xóa")
            txtMaSP.Focus()
        Else
            Dim DeleteQR As String = "Delete from QLSan_Pham where Ma_SP = @Ma_SP"
            Dim delete As SqlCommand = New SqlCommand(DeleteQR, conn)
            Dim RS As DialogResult = MessageBox.Show("Bạn có muốn xóa thông tin khách hàng nào không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If RS = DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@Ma_SP", txtMaSP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Dữ liệu đã xóa thành công!")
                loadData()
            End If
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaSP.Text = "" Or txtTenSP.Text = "" Or txtMaLoai.Text = "" Or txtSoLuong.Text = "" Or txtTenLoai.Text = "" Then
            MessageBox.Show("Bạn không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim CN As SqlConnection = New SqlConnection(lienket)
            Dim insert As String = "Insert into QLSan_Pham Values(@Ma_SP,@Ten_SP,@SoLuong,@Ma_Loai, @Ten_Loai)"
            Dim Save As SqlCommand = New SqlCommand(insert, CN)
            CN.Open()
            Save.Parameters.AddWithValue("@Ma_SP", txtMaSP.Text)
            Save.Parameters.AddWithValue("@Ten_SP", txtTenSP.Text)
            Save.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            Save.Parameters.AddWithValue("@Ma_Loai", txtMaLoai.Text)
            Save.Parameters.AddWithValue("@Ten_Loai", txtTenLoai.Text)
            Save.ExecuteNonQuery()
            CN.Close()
            MessageBox.Show("Lưu thành công!")
            loadData()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub dgvSP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSP.CellContentClick
        Dim Click As Integer = dgvSP.CurrentCell.RowIndex
        txtMaSP.Text = dgvSP.Item(0, Click).Value
        txtTenSP.Text = dgvSP.Item(1, Click).Value
        txtSoLuong.Text = dgvSP.Item(2, Click).Value
        txtMaLoai.Text = dgvSP.Item(4, Click).Value
        txtTenLoai.Text = dgvSP.Item(3, Click).Value
    End Sub
End Class