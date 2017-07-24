'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Product
    Public Property ProductId As Integer
    Public Property ArtistId As Nullable(Of Integer)
    Public Property Name As String
    Public Property ProductType As String
    Public Property GenreId As Nullable(Of Integer)
    Public Property Price As Nullable(Of Decimal)

    Public Overridable Property Artist As Artist
    Public Overridable Property Genre As Genre
    Public Overridable Property Orders As ICollection(Of Order) = New HashSet(Of Order)

End Class
