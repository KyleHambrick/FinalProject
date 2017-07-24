Module modQueries
    Dim cx As New MediaStoreEntities

    Public Sub AddArtist()
        Dim objQuery As IQueryable(Of Artist) = From m In cx.Artists
                                                Order By m.ArtistId
                                                Select m

        Dim objArtist As New Artist
        objArtist.ArtistId = objQuery.Count() + 1
        objArtist.ArtistName = UI.txtNewArtistName.Text

        cx.Artists.Add(objArtist)
        cx.SaveChanges()
    End Sub

    Public Sub AddGenre()
        Dim objQuery As IQueryable(Of Genre) = From m In cx.Genres
                                               Order By m.GenreId
                                               Select m

        Dim objGenre As New Genre
        objGenre.GenreId = objQuery.Count() + 1
        objGenre.GenreName = UI.txtNewGenreName.Text
        objGenre.Description = UI.txtNewGenreDesc.Text


        MsgBox("Invalid Genre Name", 0, "Error")
        Return
    End Sub

    Public Sub AddProduct()
        Dim objQuery As IQueryable(Of Artist) = From m In cx.Artists
                                                Order By m.ArtistId
                                                Select m

        Dim objArtQuery As IQueryable(Of Artist) = From m In cx.Artists
                                                   Order By m.ArtistId
                                                   Select m

        Dim objGenQuery As IQueryable(Of Genre) = From m In cx.Genres
                                                  Order By m.GenreId
                                                  Select m

        Dim objArtist As New Artist
        objArtist.ArtistName = UI.txtNewArtistName.Text

        Dim objGenre As New Genre
        objGenre.GenreName = UI.txtNewGenreName.Text

        Dim objProduct As New Product
        objProduct.ProductId = objQuery.Count() + 1
        objProduct.Name = UI.txtNewProductName.Text
        objProduct.ArtistId = UI.txtNewProductArtist.Text

        cx.SaveChanges()
    End Sub
End Module
