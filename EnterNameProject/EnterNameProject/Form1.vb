Imports System.Reflection.Metadata.Ecma335
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Dim index As Integer = 1
    Dim alpha = New AlphabetsAsterist
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.a(symbol))
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.b(symbol))
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.c(symbol))
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.d(symbol))
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.e(symbol))
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.f(symbol))
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.g(symbol))
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.h(symbol))
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.iAsterist(symbol))
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.jAsterist(symbol))
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.k(symbol))
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.l(symbol))
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.m(symbol))
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.n(symbol))
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.o(symbol))
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.p(symbol))
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.q(symbol))
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.r(symbol))
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.s(symbol))
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.t(symbol))
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.u(symbol))
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.v(symbol))
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.w(symbol))
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.x(symbol))
    End Sub
    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.y(symbol))
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        Dim symbol As String
        symbol = txtSymbol.Text
        display(alpha.z(symbol))
    End Sub
    Public Sub display(result As String)
        If index = 1 Then
            lblOutput1.Text = result
        ElseIf index = 2 Then
            lblOutput2.Text = result
        ElseIf index = 3 Then
            lblOutput3.Text = result
        ElseIf index = 4 Then
            lblOutput4.Text = result
        ElseIf index = 5 Then
            lblOutput5.Text = result
        ElseIf index = 6 Then
            lblOutput6.Text = result
        ElseIf index = 7 Then
            lblOutput7.Text = result
        ElseIf index = 8 Then
            lblOutput8.Text = result
        ElseIf index = 9 Then
            lblOutput9.Text = result
        ElseIf index = 10 Then
            lblOutput10.Text = result
        End If

        If index <= 10 Then
            index = index + 1
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If index > 1 Then
            index = index - 1
        End If

        If index = 1 Then
            lblOutput1.Text = ""
        ElseIf index = 2 Then
            lblOutput2.Text = ""
        ElseIf index = 3 Then
            lblOutput3.Text = ""
        ElseIf index = 4 Then
            lblOutput4.Text = ""
        ElseIf index = 5 Then
            lblOutput5.Text = ""
        ElseIf index = 6 Then
            lblOutput6.Text = ""
        ElseIf index = 7 Then
            lblOutput7.Text = ""
        ElseIf index = 8 Then
            lblOutput8.Text = ""
        ElseIf index = 9 Then
            lblOutput9.Text = ""
        ElseIf index = 10 Then
            lblOutput10.Text = ""
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput1.Text = ""
        lblOutput2.Text = ""
        lblOutput3.Text = ""
        lblOutput4.Text = ""
        lblOutput5.Text = ""
        lblOutput6.Text = ""
        lblOutput7.Text = ""
        lblOutput8.Text = ""
        lblOutput9.Text = ""
        lblOutput10.Text = ""
        index = 1
    End Sub
End Class
Class AlphabetsAsterist
    'this all the function that return the patters of alphabets
    Public Function a(symbol As String) As String
        Dim result As String
        Dim SIZE As Integer
        SIZE = 9
        result = ""

        For i = 0 To SIZE Step 1
            If i = 0 Or i = 4 Then
                For j = 0 To SIZE Step 1
                    If Not j = 0 And Not j = SIZE Then
                        result = result & symbol
                    Else
                        result = result & " "
                    End If
                Next
            Else
                For j = 0 To SIZE Step 1
                    If j = 0 Or j = SIZE Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            End If
            result = result & vbNewLine
        Next
        Return result
    End Function
    Public Function b(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 1 Or i = 5 Or i = 9 Then
                For j As Integer = 1 To 9
                    If j <> 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            End If
            result = result & vbNewLine
        Next i
        Return result
    End Function
    Public Function c(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 Or i = 9 Then
                For j As Integer = 1 To 9
                    If j <> 1 And j <> 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            ElseIf i = 2 Or i = 8 Then
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            End If
            result = result & vbNewLine
        Next i
        Return result
    End Function
    Public Function d(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 1 Or i = 9 Then
                For j As Integer = 1 To 9
                    If j <> 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            End If
            result = result & vbNewLine
        Next i
        Return result
    End Function
    Public Function e(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 Or i = 5 Or i = 9 Then
                For j As Integer = 1 To 9
                    result = result & symbol
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            End If
            result = result & vbNewLine
        Next i
        Return result
    End Function
    Public Function f(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 1 Or i = 5 Then
                For j As Integer = 1 To 9
                    result = result & symbol
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next j
            End If
            result = result & vbNewLine
        Next i
        Return result
    End Function
    Public Function g(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 1 OrElse i = 9 Then
                For j As Integer = 1 To 9
                    If j <> 1 AndAlso j <> 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 2 OrElse i = 3 OrElse i = 4 Then
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 5 Then
                For j As Integer = 1 To 9
                    If j <> 2 AndAlso j <> 3 AndAlso j <> 4 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            Else
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            End If
            result = result & vbNewLine
        Next
        Return result
    End Function
    Public Function h(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 5 Then
                For j As Integer = 1 To 9
                    result = result & symbol
                Next
            Else
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            End If
            result = result & vbNewLine
        Next
        Return result
    End Function
    Public Function iAsterist(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 Or i = 9 Then
                For J = 1 To 9
                    result &= symbol
                Next
            Else
                For J = 1 To 9
                    If J = 5 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next
            End If
            result = result & vbNewLine
        Next
        Return result
    End Function
    Public Function jAsterist(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 1 Then
                For j As Integer = 1 To 9
                    result = result & symbol
                Next
            ElseIf i = 2 OrElse i = 3 OrElse i = 4 Then
                For j As Integer = 1 To 9
                    If j = 5 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 5 OrElse i = 6 OrElse i = 7 OrElse i = 8 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 5 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            Else
                For j As Integer = 1 To 9
                    If j = 2 OrElse j = 3 OrElse j = 4 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            End If
            result = result & vbNewLine
        Next
        Return result
    End Function
    Public Function k(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 1 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 2 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 7 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 3 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 5 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 4 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 3 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 5 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 3 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 6 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 5 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 7 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 7 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            ElseIf i = 8 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            Else
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result = result & symbol
                    Else
                        result = result & "  "
                    End If
                Next
            End If
            result = result & vbNewLine
        Next
        Return result
    End Function
    Public Function l(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 9 Then
                For j As Integer = 1 To 9
                    result &= symbol
                Next
            Else
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result &= symbol
                    End If
                    result &= "  "
                Next
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function m(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 1 Then
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 2 Then
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Or j = 2 Or j = 8 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 3 Then
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Or j = 3 Or j = 7 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 4 Then
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Or j = 4 Or j = 6 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 5 Then
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Or j = 5 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If

            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function n(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 Or i = 9 Then
                For j As Integer = 1 To 9
                    If j = 1 Or j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If

                Next j
            ElseIf i >= 2 AndAlso i <= 8 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 OrElse j = i Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function o(symbol As String) As String
        Dim result As String
        result = ""
        For i As Integer = 1 To 9
            If i = 1 OrElse i = 9 Then
                For j As Integer = 1 To 9
                    If j <> 1 AndAlso j <> 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol

                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function p(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 OrElse i = 5 Then
                For j As Integer = 1 To 9
                    If j <> 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i >= 2 AndAlso i <= 4 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function q(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 Then
                For j As Integer = 1 To 9
                    If j <> 1 AndAlso j <> 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i <> 7 AndAlso i <> 8 AndAlso i <> 9 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 7 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 OrElse j = 3 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 8 Then
                For j As Integer = 1 To 9
                    If j <> 1 AndAlso j <> 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function r(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 OrElse i = 5 Then
                For j As Integer = 1 To 9
                    If j <> 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i >= 2 AndAlso i <= 4 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function s(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 OrElse i = 5 OrElse i = 9 Then
                For j As Integer = 1 To 9
                    If j <> 1 AndAlso j <> 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i >= 2 AndAlso i <= 4 Then
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function t(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 Then
                For j As Integer = 1 To 9
                    result &= symbol
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 5 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function u(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 9 Then
                For j As Integer = 1 To 9
                    If j <> 1 AndAlso j <> 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            Else
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function v(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 OrElse i = 2 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 3 OrElse i = 4 Then
                For j As Integer = 1 To 9
                    If j = 2 OrElse j = 8 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 5 OrElse i = 6 Then
                For j As Integer = 1 To 9
                    If j = 3 OrElse j = 7 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 7 OrElse i = 8 Then
                For j As Integer = 1 To 9
                    If j = 4 OrElse j = 6 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 9 Then
                For j As Integer = 1 To 9
                    If j = 5 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function w(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 OrElse i = 2 OrElse i = 3 OrElse i = 4 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 5 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 OrElse j = 5 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 6 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 OrElse j = 4 OrElse j = 6 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 7 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 OrElse j = 3 OrElse j = 7 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 8 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 OrElse j = 2 OrElse j = 8 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 9 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function x(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 2 Then
                For j As Integer = 1 To 9
                    If j = 2 OrElse j = 8 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 3 Then
                For j As Integer = 1 To 9
                    If j = 3 OrElse j = 7 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 4 Then
                For j As Integer = 1 To 9
                    If j = 4 OrElse j = 6 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 5 Then
                For j As Integer = 1 To 9
                    If j = 5 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 6 Then
                For j As Integer = 1 To 9
                    If j = 4 OrElse j = 6 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 7 Then
                For j As Integer = 1 To 9
                    If j = 3 OrElse j = 7 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 8 Then
                For j As Integer = 1 To 9
                    If j = 2 OrElse j = 8 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 9 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i
        Return result
    End Function
    Public Function y(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 Then
                For j As Integer = 1 To 9
                    If j = 1 OrElse j = 9 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 2 Then
                For j As Integer = 1 To 9
                    If j = 2 OrElse j = 8 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 3 Then
                For j As Integer = 1 To 9
                    If j = 3 OrElse j = 7 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 4 Then
                For j As Integer = 1 To 9
                    If j = 4 OrElse j = 6 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 5 Then
                For j As Integer = 1 To 9
                    If j = 5 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 6 Then
                For j As Integer = 1 To 9
                    If j = 4 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 7 Then
                For j As Integer = 1 To 9
                    If j = 3 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 8 Then
                For j As Integer = 1 To 9
                    If j = 2 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            ElseIf i = 9 Then
                For j As Integer = 1 To 9
                    If j = 1 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i

        Return result
    End Function
    Public Function z(symbol As String) As String
        Dim result As String
        result = ""

        For i As Integer = 1 To 9
            If i = 1 OrElse i = 9 Then
                For j As Integer = 1 To 9
                    result &= symbol
                Next j
            ElseIf i >= 2 AndAlso i <= 8 Then
                For j As Integer = 1 To 9
                    If j = 9 - i + 1 Then
                        result &= symbol
                    Else
                        result &= "  "
                    End If
                Next j
            End If
            result &= vbNewLine
        Next i

        Return result
    End Function
End Class