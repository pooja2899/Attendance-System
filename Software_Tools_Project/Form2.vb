
Public Class Form2

    Private Sub AttendanceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendanceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As String
        i = "present"
        'TODO: This line of code loads data into the 'ProjectDataSet.attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.ProjectDataSet.attendance)
        Me.ATTENDANCETextBox.Text = "present"
        MsgBox("Student marked present")
        AttendanceBindingSource.EndEdit()
        AttendanceTableAdapter.Update(ProjectDataSet.attendance)
        Form3.Show()


    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
    End Sub
End Class