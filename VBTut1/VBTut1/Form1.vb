Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        txtName.Text = "Hello " & txtName.Text

    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        MessageBox.Show("Hello " & txtName.Text,
                         "This is the Title")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click
        Try
            Dim firstNum As Integer = CInt(txtAddVal1.Text) 'CInt is when casting to integer, textbox feeds always strings
            Dim secondNum As Integer = CInt(txtAddVal2.Text)
            Dim sum = firstNum + secondNum

            txtSumAnswer.Text = CStr(sum)       'convert back into a string befor storing

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers to add", "Error")

            Console.WriteLine("This message desplays in the console, helpful for debugging")

        Catch ex As Exception

            MessageBox.Show("An unknown error occurred", "!!ERROR!!")

        End Try
    End Sub

    Private Sub btnSubtractVal_Click(sender As Object, e As EventArgs) Handles btnSubtractVal.Click

        Try
            Dim firstNum As Integer = CInt(txtSubVal1.Text)
            Dim secondNum As Integer = CInt(txtSubVal2.Text)
            Dim sum = firstNum - secondNum

            subtractTxtBoxAnswer.Text = CStr(sum)       'convert back into a string befor storing

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers to Subtract", "Error")

        Catch ex As Exception

            MessageBox.Show("An unknown error occurred", "!!ERROR!!")

        End Try

    End Sub

    Private Sub btnDivideVal_Click(sender As Object, e As EventArgs) Handles btnDivideVal.Click
        Try
            Dim firstNum As Decimal = CDec(txtDivideVal1.Text)
            Dim secondNum As Decimal = CDec(txtDivideVal2.Text)
            divideTxtBoxAnswer.Text = CStr(CType(firstNum / secondNum, Decimal))

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers to Divide", "Error")

        Catch ex As Exception

            MessageBox.Show("An unknown error occurred", "!!ERROR!!")

        End Try
    End Sub

    Private Sub btnMultVal_Click(sender As Object, e As EventArgs) Handles btnMultVal.Click
        Try
            Dim firstNum As Integer = CInt(txtMultVal1.Text)
            Dim secondNum As Integer = CInt(txtMultVal2.Text)
            multTxtBoxAnswer.Text = CStr(CType(firstNum * secondNum, Integer))

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers to Multiply", "Error")

        Catch ex As Exception

            MessageBox.Show("An unknown error occurred", "!!ERROR!!")

        End Try
    End Sub

    Private Sub btnPowVal_Click(sender As Object, e As EventArgs) Handles btnPowVal.Click
        Try
            Dim firstNum As Integer = CInt(txtPowVal1.Text)
            Dim secondNum As Integer = CInt(txtPowVal2.Text)
            Dim sum As Long = firstNum ^ secondNum

            powTxtBoxAnswer.Text = CStr(sum)       'convert back into a string befor storing

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers to get the power off", "Error")

        Catch ex As Exception

            MessageBox.Show("The number is too large", "!!ERROR!!")

        End Try
    End Sub

    Private Sub btnSqrtVal_Click(sender As Object, e As EventArgs) Handles btnSqrtVal.Click
        Try
            Dim firstNum As Integer = CInt(txtSqrtVal.Text)
            sqrtTxtBoxAnswer.Text = CStr(CType(System.Math.Sqrt(firstNum), Decimal))   'using math library for square root

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers to get the square root off", "Error")

        Catch ex As Exception

            MessageBox.Show("Unknown Error", "!!ERROR!!")

        End Try
    End Sub
End Class

