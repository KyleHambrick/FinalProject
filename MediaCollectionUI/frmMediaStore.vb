Public Class frmMediaStore
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VideoToolStripMenuItem.Click
        frmVideo.Show()
    End Sub

    Private Sub ImagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagesToolStripMenuItem.Click
        frmImage.Show()
    End Sub

    Private Sub AlbumsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlbumsToolStripMenuItem.Click
        frmAlbum.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        frmCheckout.Show()
    End Sub
End Class
