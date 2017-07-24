
Public Class UI
    Dim drag As Boolean

    Dim mousex As Integer

    Dim mousey As Integer

    Dim cartCount As Integer


    Private Sub UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pnlMain.Controls.Add(pnlProducts)
        'pnlMain.Controls.Add(pnlComplete)
        'pnlMain.Controls.Add(pnlFeatured)
    End Sub


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlToolbar.MouseDown


        ' If e.Button = MouseButtons.Left Then

        drag = True

        mousex = Cursor.Position.X - Me.Left

        mousey = Cursor.Position.Y - Me.Top

        ' End If

    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlToolbar.MouseMove

        If drag Then

            Me.Top = Cursor.Position.Y - mousey

            Me.Left = Cursor.Position.X - mousex

        End If

    End Sub


    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlToolbar.MouseUp

        drag = False

    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        lblTitle.Text = "Shopping Cart"
        lblSubtitle.Text = "View the contents of your shopping cart and complete purchase"
        pnlComplete.BringToFront()
    End Sub





    Private Sub CartAdd(count As Integer)
        cartCount += 1
        lblCartCount.Text = "(" + cartCount + ")"
    End Sub

    Private Sub CartRemove(count As Integer)
        If (cartCount > 0) Then
            cartCount += 1
            lblCartCount.Text = "(" + cartCount + ")"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnVideos.Click
        pnlProducts.BringToFront()
    End Sub

    Private Sub btnImages_Click(sender As Object, e As EventArgs) Handles btnImages.Click
        pnlProducts.BringToFront()
    End Sub

    Private Sub btnAlbums_Click(sender As Object, e As EventArgs) Handles btnAlbums.Click
        pnlProducts.BringToFront()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnEditInfo.Click
        pnlCheckout.BringToFront()
    End Sub

    Private Sub pbMainten_Click(sender As Object, e As EventArgs) Handles pbMainten.Click
        pnlAdd.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        pnlProducts.BringToFront()
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Me.Close()
    End Sub

    Private Sub btnNewProductSave_Click(sender As Object, e As EventArgs) Handles btnNewProductSave.Click
        AddProduct()
    End Sub

    Private Sub btnNewArtistSave_Click(sender As Object, e As EventArgs) Handles btnNewArtistSave.Click
        AddArtist()
    End Sub

    Private Sub btnNewGenreSave_Click(sender As Object, e As EventArgs) Handles btnNewGenreSave.Click
        AddGenre()
    End Sub

    Private Sub pbSelectedImage_Click(sender As Object, e As EventArgs) Handles pbSelectedImage.Click
        MsgBox("Click", 0, "Click")
    End Sub
End Class