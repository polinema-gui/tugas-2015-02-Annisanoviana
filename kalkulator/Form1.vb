Public Class Form1
    Dim y As String
    Dim jumlah As String
    Dim input As Integer

    
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub button_1_Click(sender As Object, e As EventArgs) Handles button_1.Click
        If (y = "0") Then
            y = "1"
        Else
            y &= "1"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_2_Click(sender As Object, e As EventArgs) Handles button_2.Click
        If (y = "0") Then
            y = "2"
        Else
            y &= "2"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_3_Click(sender As Object, e As EventArgs) Handles button_3.Click
        If (y = "0") Then
            y = "3"
        Else
            y &= "3"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_4_Click(sender As Object, e As EventArgs) Handles button_4.Click
        If (y = "0") Then
            y = "4"
        Else
            y &= "4"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_5_Click(sender As Object, e As EventArgs) Handles button_5.Click
        If (y = "0") Then
            y = "5"
        Else
            y &= "5"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_6_Click(sender As Object, e As EventArgs) Handles button_6.Click
        If (y = "0") Then
            y = "6"
        Else
            y &= "6"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_7_Click(sender As Object, e As EventArgs) Handles button_7.Click
        If (y = "0") Then
            y = "7"
        Else
            y &= "7"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_8_Click(sender As Object, e As EventArgs) Handles button_8.Click
        If (y = "0") Then
            y = "8"
        Else
            y &= "8"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_9_Click(sender As Object, e As EventArgs) Handles button_9.Click
        If (y = "0") Then
            y = "9"
        Else
            y &= "9"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_0_Click(sender As Object, e As EventArgs) Handles button_0.Click
        If (y = "0") Then
            y = "0"
        Else
            y &= "0"
        End If
        TextBox1.Text = y
    End Sub

    Private Sub button_Equals_Click(sender As Object, e As EventArgs) Handles button_Equals.Click
        Select Case Me.jumlah
            Case "jumlah1"
                TextBox1.Text = Convert.ToString(input + TextBox1.Text)
            Case "jumlah2"
                TextBox1.Text = Convert.ToString(input - TextBox1.Text)
        End Select
    End Sub

    Private Sub button_Positive_Click(sender As Object, e As EventArgs) Handles button_Positive.Click
        Me.jumlah = "jumlah1"
        Me.input = TextBox1.Text
        y = Nothing
    End Sub

    Private Sub button_Negatif_Click(sender As Object, e As EventArgs) Handles button_Negatif.Click
        Me.jumlah = "jumlah2"
        Me.input = TextBox1.Text
        y = Nothing
    End Sub

    Private Sub button_Clear_Click(sender As Object, e As EventArgs) Handles button_Clear.Click
        TextBox1.Text = "0"
        y = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "0"
    End Sub
End Class
