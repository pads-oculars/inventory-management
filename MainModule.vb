' MainModule.vb

Module MainModule
    Sub Main()
        ' Create products
        Dim product1 As New Product(1, "Laptop", 1200.0)
        Dim product2 As New Product(2, "Smartphone", 800.0)

        ' Create an order
        Dim order As New Order(101)

        ' Add products to the order
        order.AddProduct(product1)
        order.AddProduct(product2)

        ' Display order details
        order.Display()

        Console.ReadLine()
    End Sub
End Module
