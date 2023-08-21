Imports System.Reflection
Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Dim list = New LinkedList
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim amount As Integer
        Dim quantity As Integer
        amount = txtAmount.Text
        quantity = nmcQuntity.Text
        list.add(amount, quantity)
        display()
        txtAmount.Text = ""
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        list.remove()
        display()
        txtAmount.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        list.clear()
        display()
        txtAmount.Text = ""
    End Sub
    Private Sub display()
        Dim result As String
        result = ""

        Dim temp = list.head
        Dim product As Integer
        product = 1

        While Not (temp Is Nothing)
            result = result & " Product" & product & " Price: " & temp.val & " Quantity: " & temp.quantity
            result = result & vbNewLine
            temp = temp.nextNode
            product += 1
        End While
        lblDisplay.Text = result
        txtTotalAmount.Text = list.totalAmount()
    End Sub


End Class
Public Class LinkedList
    Public Class Node
        Public val As Integer
        Public quantity As Integer
        Public nextNode As Node

        Public Sub New(ByVal Val As Integer, ByVal Quantity As Integer)
            Me.val = Val
            Me.quantity = Quantity
            nextNode = Nothing
        End Sub
    End Class

    Public head As Node
    Public Sub New()
        head = Nothing
    End Sub

    Public Sub add(data As Integer, quantity As Integer)
        Dim node As New Node(data, quantity)

        If head Is Nothing Then
            head = node
        Else
            Dim current = head
            While Not (current.nextNode Is Nothing)
                current = current.nextNode
            End While

            current.nextNode = node
        End If

    End Sub

    Public Sub remove()
        Dim temp = head
        Dim prev = Nothing
        While Not (temp.nextNode Is Nothing)
            prev = temp
            temp = temp.nextNode
        End While

        prev.nextNode = Nothing
    End Sub
    Public Sub clear()
        head = Nothing
    End Sub
    Public Function totalAmount() As String
        Dim total As Integer
        total = 0
        Dim temp = head
        While Not (temp Is Nothing)
            total = total + temp.val * temp.quantity
            temp = temp.nextNode
        End While
        Return total
    End Function

End Class