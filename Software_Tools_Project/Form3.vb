Public Class Form3
    Private Sub AttendanceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AttendanceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AttendanceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProjectDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.attendance' table. You can move, or remove it, as needed.
        Me.AttendanceTableAdapter.Fill(Me.ProjectDataSet.attendance)

    End Sub

    Private Sub AttendanceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AttendanceDataGridView.CellContentClick

    End Sub
End Class