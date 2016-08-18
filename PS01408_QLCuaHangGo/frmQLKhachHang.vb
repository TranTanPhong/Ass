Imports System.Data.SqlClient

Public Class frmQLKhachHang
    Dim DB As New DataTable
    Dim lienket As String = "workstation id=Phongttps01408.mssql.somee.com;packet size=4096;user id=PS01408_SQLLogin_1;pwd=rcispqr46g;data source=Phongttps01408.mssql.somee.com;persist security info=False;initial catalog=Phongttps01408"
    Dim conn As SqlConnection = New SqlConnection(lienket)

    Private Sub frmQLKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData()
        Dim conn As SqlConnection = New SqlConnection(lienket)
        conn.Open()
        Dim lKH As New SqlDataAdapter("Select Ma_KH as 'Mã KH', Ten_KH as 'Tên KH', DiaChi as 'Địa Chỉ', SDT as 'SĐT', Email from Khach_Hang", conn)
        DB.Clear()
        lKH.Fill(DB)
        dgvKH.DataSource = DB.DefaultView
        conn.Close()
    End Sub

    Private Sub tbnThem_Click(sender As Object, e As EventArgs) Handles tbnThem.Click
        txtDiaChi.Text = ""
        txtEmail.Text = ""
        txtSDT.Text = ""
        txtTenKH.Text = ""
        txtMaKH.Focus()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim conn As SqlConnection = New SqlConnection(lienket)
        Dim Query As String = "update Khach_Hang set Ma_KH = @MaKH, Ten_KH = @TenKH, DiaChi = @DiaChi, SDT = @SDT, Email = @Email where Ma_KH =@MaKH"
        Dim Save As SqlCommand = New SqlCommand(Query, conn)
        conn.Open()
        Try
            txtMaKH.Focus()
            If txtMaKH.Text = "" Or txtTenKH.Text = "" Or txtDiaChi.Text = "" Or txtSDT.Text = "" Or txtEmail.Text = "" Then
                MessageBox.Show("Bạn phải nhập tất cả không để trống!")
            Else
                Save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                Save.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
                Save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                Save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                Save.Parameters.AddWithValue("@Email", txtEmail.Text)
                Save.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Sửa thành công!")
                txtMaKH.Text = Nothing
                txtTenKH.Text = Nothing
                txtDiaChi.Text = Nothing
                txtSDT.Text = Nothing
                txtEmail.Text = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công!")
        End Try
        DB.Clear()
        dgvKH.DataSource = DB
        dgvKH.DataSource = Nothing
        loadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Bạn phải chọn mã khách hàng cần xóa")
            txtMaKH.Focus()
        Else
            Dim DeleteQR As String = "delete from Khach_Hang where Ma_KH = @MaKH"
            Dim delete As SqlCommand = New SqlCommand(DeleteQR, conn)
            Dim RS As DialogResult = MessageBox.Show("Bạn có muốn xóa thông tin khách hàng nào không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If RS = DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Dữ liệu đã xóa thành công!")
                loadData()
            End If
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaKH.Text = "" Or txtTenKH.Text = "" Or txtDiaChi.Text = "" Or txtEmail.Text = "" Or txtSDT.Text = "" Then
            MessageBox.Show("Bạn không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim CN As SqlConnection = New SqlConnection(lienket)
            Dim insert As String = "Insert into Khach_Hang Values(@MaKH, @TenKH, @DiaChi, @SDT, @Email)"
            Dim Save As SqlCommand = New SqlCommand(insert, CN)
            CN.Open()
            Save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            Save.Parameters.AddWithValue("@TenKH", txtTenKH.Text)
            Save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            Save.Parameters.AddWithValue("@SDT", txtSDT.Text)
            Save.Parameters.AddWithValue("@Email", txtEmail.Text)
            Save.ExecuteNonQuery()
            CN.Close()
            MessageBox.Show("Lưu thành công!")
            loadData()
        End If
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim Click As Integer = dgvKH.CurrentCell.RowIndex
        txtMaKH.Text = dgvKH.Item(0, Click).Value
        txtTenKH.Text = dgvKH.Item(1, Click).Value
        txtDiaChi.Text = dgvKH.Item(2, Click).Value
        txtEmail.Text = dgvKH.Item(4, Click).Value
        txtSDT.Text = dgvKH.Item(3, Click).Value
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()
    End Sub
End Class