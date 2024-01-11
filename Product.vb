' Product.vb

Public Class Product
    Private _productId As Integer
    Private _productName As String
    Private _price As Decimal

    Public Sub New(productId As Integer, productName As String, price As Decimal)
        _productId = productId
        _productName = productName
        _price = price
    End Sub

    Public Sub Display()
        Console.WriteLine($"Product ID: {_productId}, Name: {_productName}, Price: {_price:C}")
    End Sub
End Class
