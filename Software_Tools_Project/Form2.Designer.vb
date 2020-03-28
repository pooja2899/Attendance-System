<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Sl_NoLabel As System.Windows.Forms.Label
        Dim ENROLLMENT_NUMBERLabel As System.Windows.Forms.Label
        Dim STUDENT_NAMELabel As System.Windows.Forms.Label
        Dim ATTENDANCELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ProjectDataSet = New Software_Tools_Project.projectDataSet()
        Me.AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttendanceTableAdapter = New Software_Tools_Project.projectDataSetTableAdapters.attendanceTableAdapter()
        Me.TableAdapterManager = New Software_Tools_Project.projectDataSetTableAdapters.TableAdapterManager()
        Me.AttendanceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AttendanceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Sl_NoTextBox = New System.Windows.Forms.TextBox()
        Me.ENROLLMENT_NUMBERTextBox = New System.Windows.Forms.TextBox()
        Me.STUDENT_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.ATTENDANCETextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SlNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENROLLMENTNUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STUDENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ATTENDANCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Sl_NoLabel = New System.Windows.Forms.Label()
        ENROLLMENT_NUMBERLabel = New System.Windows.Forms.Label()
        STUDENT_NAMELabel = New System.Windows.Forms.Label()
        ATTENDANCELabel = New System.Windows.Forms.Label()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttendanceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttendanceBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sl_NoLabel
        '
        Sl_NoLabel.AutoSize = True
        Sl_NoLabel.Location = New System.Drawing.Point(293, 39)
        Sl_NoLabel.Name = "Sl_NoLabel"
        Sl_NoLabel.Size = New System.Drawing.Size(36, 13)
        Sl_NoLabel.TabIndex = 1
        Sl_NoLabel.Text = "Sl No:"
        '
        'ENROLLMENT_NUMBERLabel
        '
        ENROLLMENT_NUMBERLabel.AutoSize = True
        ENROLLMENT_NUMBERLabel.Location = New System.Drawing.Point(293, 65)
        ENROLLMENT_NUMBERLabel.Name = "ENROLLMENT_NUMBERLabel"
        ENROLLMENT_NUMBERLabel.Size = New System.Drawing.Size(134, 13)
        ENROLLMENT_NUMBERLabel.TabIndex = 3
        ENROLLMENT_NUMBERLabel.Text = "ENROLLMENT NUMBER:"
        '
        'STUDENT_NAMELabel
        '
        STUDENT_NAMELabel.AutoSize = True
        STUDENT_NAMELabel.Location = New System.Drawing.Point(293, 91)
        STUDENT_NAMELabel.Name = "STUDENT_NAMELabel"
        STUDENT_NAMELabel.Size = New System.Drawing.Size(96, 13)
        STUDENT_NAMELabel.TabIndex = 5
        STUDENT_NAMELabel.Text = "STUDENT NAME:"
        '
        'ATTENDANCELabel
        '
        ATTENDANCELabel.AutoSize = True
        ATTENDANCELabel.Location = New System.Drawing.Point(293, 117)
        ATTENDANCELabel.Name = "ATTENDANCELabel"
        ATTENDANCELabel.Size = New System.Drawing.Size(83, 13)
        ATTENDANCELabel.TabIndex = 7
        ATTENDANCELabel.Text = "ATTENDANCE:"
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "projectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AttendanceBindingSource
        '
        Me.AttendanceBindingSource.DataMember = "attendance"
        Me.AttendanceBindingSource.DataSource = Me.ProjectDataSet
        '
        'AttendanceTableAdapter
        '
        Me.AttendanceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.attendanceTableAdapter = Me.AttendanceTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Software_Tools_Project.projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AttendanceBindingNavigator
        '
        Me.AttendanceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AttendanceBindingNavigator.BindingSource = Me.AttendanceBindingSource
        Me.AttendanceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AttendanceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AttendanceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AttendanceBindingNavigatorSaveItem, Me.ToolStripLabel1})
        Me.AttendanceBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AttendanceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AttendanceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AttendanceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AttendanceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AttendanceBindingNavigator.Name = "AttendanceBindingNavigator"
        Me.AttendanceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AttendanceBindingNavigator.Size = New System.Drawing.Size(633, 25)
        Me.AttendanceBindingNavigator.TabIndex = 0
        Me.AttendanceBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AttendanceBindingNavigatorSaveItem
        '
        Me.AttendanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AttendanceBindingNavigatorSaveItem.Image = CType(resources.GetObject("AttendanceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AttendanceBindingNavigatorSaveItem.Name = "AttendanceBindingNavigatorSaveItem"
        Me.AttendanceBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AttendanceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(87, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'Sl_NoTextBox
        '
        Me.Sl_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AttendanceBindingSource, "Sl_No", True))
        Me.Sl_NoTextBox.Location = New System.Drawing.Point(433, 36)
        Me.Sl_NoTextBox.Name = "Sl_NoTextBox"
        Me.Sl_NoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Sl_NoTextBox.TabIndex = 2
        '
        'ENROLLMENT_NUMBERTextBox
        '
        Me.ENROLLMENT_NUMBERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AttendanceBindingSource, "ENROLLMENT_NUMBER", True))
        Me.ENROLLMENT_NUMBERTextBox.Location = New System.Drawing.Point(433, 62)
        Me.ENROLLMENT_NUMBERTextBox.Name = "ENROLLMENT_NUMBERTextBox"
        Me.ENROLLMENT_NUMBERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ENROLLMENT_NUMBERTextBox.TabIndex = 4
        '
        'STUDENT_NAMETextBox
        '
        Me.STUDENT_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AttendanceBindingSource, "STUDENT_NAME", True))
        Me.STUDENT_NAMETextBox.Location = New System.Drawing.Point(433, 88)
        Me.STUDENT_NAMETextBox.Name = "STUDENT_NAMETextBox"
        Me.STUDENT_NAMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.STUDENT_NAMETextBox.TabIndex = 6
        '
        'ATTENDANCETextBox
        '
        Me.ATTENDANCETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AttendanceBindingSource, "ATTENDANCE", True))
        Me.ATTENDANCETextBox.Location = New System.Drawing.Point(433, 114)
        Me.ATTENDANCETextBox.Name = "ATTENDANCETextBox"
        Me.ATTENDANCETextBox.Size = New System.Drawing.Size(100, 20)
        Me.ATTENDANCETextBox.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SlNoDataGridViewTextBoxColumn, Me.ENROLLMENTNUMBERDataGridViewTextBoxColumn, Me.STUDENTNAMEDataGridViewTextBoxColumn, Me.ATTENDANCEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AttendanceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(596, 289)
        Me.DataGridView1.TabIndex = 9
        '
        'SlNoDataGridViewTextBoxColumn
        '
        Me.SlNoDataGridViewTextBoxColumn.DataPropertyName = "Sl_No"
        Me.SlNoDataGridViewTextBoxColumn.HeaderText = "Sl_No"
        Me.SlNoDataGridViewTextBoxColumn.Name = "SlNoDataGridViewTextBoxColumn"
        '
        'ENROLLMENTNUMBERDataGridViewTextBoxColumn
        '
        Me.ENROLLMENTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "ENROLLMENT_NUMBER"
        Me.ENROLLMENTNUMBERDataGridViewTextBoxColumn.HeaderText = "ENROLLMENT_NUMBER"
        Me.ENROLLMENTNUMBERDataGridViewTextBoxColumn.Name = "ENROLLMENTNUMBERDataGridViewTextBoxColumn"
        Me.ENROLLMENTNUMBERDataGridViewTextBoxColumn.Width = 150
        '
        'STUDENTNAMEDataGridViewTextBoxColumn
        '
        Me.STUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_NAME"
        Me.STUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENT_NAME"
        Me.STUDENTNAMEDataGridViewTextBoxColumn.Name = "STUDENTNAMEDataGridViewTextBoxColumn"
        Me.STUDENTNAMEDataGridViewTextBoxColumn.Width = 150
        '
        'ATTENDANCEDataGridViewTextBoxColumn
        '
        Me.ATTENDANCEDataGridViewTextBoxColumn.DataPropertyName = "ATTENDANCE"
        Me.ATTENDANCEDataGridViewTextBoxColumn.HeaderText = "ATTENDANCE"
        Me.ATTENDANCEDataGridViewTextBoxColumn.Name = "ATTENDANCEDataGridViewTextBoxColumn"
        Me.ATTENDANCEDataGridViewTextBoxColumn.Width = 150
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 462)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Sl_NoLabel)
        Me.Controls.Add(Me.Sl_NoTextBox)
        Me.Controls.Add(ENROLLMENT_NUMBERLabel)
        Me.Controls.Add(Me.ENROLLMENT_NUMBERTextBox)
        Me.Controls.Add(STUDENT_NAMELabel)
        Me.Controls.Add(Me.STUDENT_NAMETextBox)
        Me.Controls.Add(ATTENDANCELabel)
        Me.Controls.Add(Me.ATTENDANCETextBox)
        Me.Controls.Add(Me.AttendanceBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "lab"
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttendanceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttendanceBindingNavigator.ResumeLayout(False)
        Me.AttendanceBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProjectDataSet As projectDataSet
    Friend WithEvents AttendanceBindingSource As BindingSource
    Friend WithEvents AttendanceTableAdapter As projectDataSetTableAdapters.attendanceTableAdapter
    Friend WithEvents TableAdapterManager As projectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AttendanceBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AttendanceBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Sl_NoTextBox As TextBox
    Friend WithEvents ENROLLMENT_NUMBERTextBox As TextBox
    Friend WithEvents STUDENT_NAMETextBox As TextBox
    Friend WithEvents ATTENDANCETextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SlNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ENROLLMENTNUMBERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STUDENTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ATTENDANCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
