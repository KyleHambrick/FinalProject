﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class MediaStoreEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=MediaStoreEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Artists() As DbSet(Of Artist)
    Public Overridable Property Genres() As DbSet(Of Genre)
    Public Overridable Property OrderDetails() As DbSet(Of OrderDetail)
    Public Overridable Property Orders() As DbSet(Of Order)
    Public Overridable Property Products() As DbSet(Of Product)

End Class
