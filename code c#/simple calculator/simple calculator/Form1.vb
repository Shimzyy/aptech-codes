Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Num9.Click
        Dim button As Button =
                   CType(sender, Button)

        If button.Name = "Num9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles division.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "division" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Multiplication" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Subtraction.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Subtraction" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Addition.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Addition" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Dec_point.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Dec_point" Then
            TextBox1.Text = TextBox1.Text + "."
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Num0.Click
        Dim button As Button =
                   CType(sender, Button)

        If button.Name = "Num0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Num1.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Num1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Num2.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Num2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Num3.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Num3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Num4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        Dim button As Button =
            CType(sender, Button)

        If button.Name = "Num5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Num6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Num7.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Num7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Num8.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Num8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Equals_to.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Equals_to" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Dim button As Button =
           CType(sender, Button)

        If button.Name = "Clear" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
