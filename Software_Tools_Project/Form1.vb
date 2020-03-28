Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Call notfound()
            Exit Sub
        Else
            Form2.AttendanceBindingSource.Filter = "(Convert  ( ENROLLMENT_NUMBER , ' System.String') LIKE '" & TextBox1.Text & "') "
        End If
        Form2.Show()

    End Sub
    Private Sub notfound()

    End Sub
End Class
