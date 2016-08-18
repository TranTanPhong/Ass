Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDataTime.Text = " Ngày: " & DateTime.Now.Date & Chr(10)
    End Sub

    Private Sub tsmKhachHang_Click(sender As Object, e As EventArgs) Handles tsmKhachHang.Click
        frmQLKhachHang.Show()
        Me.Hide()
    End Sub

    Private Sub tsmSanPham_Click(sender As Object, e As EventArgs) Handles tsmSanPham.Click
        frmQLSanPham.Show()
        Me.Hide()
    End Sub

    Private Sub tsmSP_Click(sender As Object, e As EventArgs) Handles tsmSP.Click

    End Sub

    Private Sub tsmKH_Click(sender As Object, e As EventArgs) Handles tsmKH.Click

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click

    End Sub
End Class
