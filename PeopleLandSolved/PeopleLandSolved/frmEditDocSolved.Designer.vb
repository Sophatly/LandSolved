<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditDocSolved
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
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.cboOfficerName = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPeopleYearDoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPeopleDocNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPeopleDoc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDocID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLandID = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.cboPeopleName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LandIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeopleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandSizeTrueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QryPeopleSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleLandSolveDataSet = New PeopleLandSolved.PeopleLandSolveDataSet()
        Me.QryPeopleSearchTableAdapter = New PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryPeopleSearchTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.QryEditDocSolvedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QryEditDocSolvedTableAdapter = New PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryEditDocSolvedTableAdapter()
        Me.DocIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentTypeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IRCNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtIRCNum = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryPeopleSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryEditDocSolvedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(1189, 486)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(123, 37)
        Me.BtnCancel.TabIndex = 35
        Me.BtnCancel.Text = "ចាកចេញ"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'cboOfficerName
        '
        Me.cboOfficerName.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOfficerName.FormattingEnabled = True
        Me.cboOfficerName.Location = New System.Drawing.Point(138, 442)
        Me.cboOfficerName.Name = "cboOfficerName"
        Me.cboOfficerName.Size = New System.Drawing.Size(1174, 32)
        Me.cboOfficerName.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 445)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 22)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "អាជ្ញាធរមូលដ្ឋាន"
        '
        'txtPeopleYearDoc
        '
        Me.txtPeopleYearDoc.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeopleYearDoc.Location = New System.Drawing.Point(138, 407)
        Me.txtPeopleYearDoc.Name = "txtPeopleYearDoc"
        Me.txtPeopleYearDoc.Size = New System.Drawing.Size(1174, 29)
        Me.txtPeopleYearDoc.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "ឆ្នាំកាន់កាប់"
        '
        'txtPeopleDocNum
        '
        Me.txtPeopleDocNum.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeopleDocNum.Location = New System.Drawing.Point(138, 372)
        Me.txtPeopleDocNum.Name = "txtPeopleDocNum"
        Me.txtPeopleDocNum.Size = New System.Drawing.Size(1174, 29)
        Me.txtPeopleDocNum.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 22)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "លេខឯកសារ"
        '
        'cboPeopleDoc
        '
        Me.cboPeopleDoc.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeopleDoc.FormattingEnabled = True
        Me.cboPeopleDoc.Location = New System.Drawing.Point(138, 334)
        Me.cboPeopleDoc.Name = "cboPeopleDoc"
        Me.cboPeopleDoc.Size = New System.Drawing.Size(1174, 32)
        Me.cboPeopleDoc.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "ឯកសារកាន់កាប់ដី"
        '
        'txtDocID
        '
        Me.txtDocID.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocID.Location = New System.Drawing.Point(607, 261)
        Me.txtDocID.Name = "txtDocID"
        Me.txtDocID.Size = New System.Drawing.Size(705, 29)
        Me.txtDocID.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(516, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "លេខឯកសារ"
        '
        'txtLandID
        '
        Me.txtLandID.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLandID.Location = New System.Drawing.Point(138, 261)
        Me.txtLandID.Name = "txtLandID"
        Me.txtLandID.Size = New System.Drawing.Size(370, 29)
        Me.txtLandID.TabIndex = 23
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(1060, 486)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(123, 37)
        Me.BtnUpdate.TabIndex = 34
        Me.BtnUpdate.Text = "កែប្រែ"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'cboPeopleName
        '
        Me.cboPeopleName.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeopleName.FormattingEnabled = True
        Me.cboPeopleName.Location = New System.Drawing.Point(138, 29)
        Me.cboPeopleName.Name = "cboPeopleName"
        Me.cboPeopleName.Size = New System.Drawing.Size(257, 30)
        Me.cboPeopleName.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ឈ្មោះម្ចាស់បណ្តឹង"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LandIDDataGridViewTextBoxColumn, Me.PeopleNameDataGridViewTextBoxColumn, Me.LandSizeDataGridViewTextBoxColumn, Me.LandSizeTrueDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QryPeopleSearchBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(486, 164)
        Me.DataGridView1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "លេខក្បាលដី"
        '
        'LandIDDataGridViewTextBoxColumn
        '
        Me.LandIDDataGridViewTextBoxColumn.DataPropertyName = "LandID"
        Me.LandIDDataGridViewTextBoxColumn.HeaderText = "លេខក្បាលដី"
        Me.LandIDDataGridViewTextBoxColumn.Name = "LandIDDataGridViewTextBoxColumn"
        Me.LandIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LandIDDataGridViewTextBoxColumn.Width = 80
        '
        'PeopleNameDataGridViewTextBoxColumn
        '
        Me.PeopleNameDataGridViewTextBoxColumn.DataPropertyName = "PeopleName"
        Me.PeopleNameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះម្ចាស់បណ្តឹង"
        Me.PeopleNameDataGridViewTextBoxColumn.Name = "PeopleNameDataGridViewTextBoxColumn"
        Me.PeopleNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeopleNameDataGridViewTextBoxColumn.Width = 130
        '
        'LandSizeDataGridViewTextBoxColumn
        '
        Me.LandSizeDataGridViewTextBoxColumn.DataPropertyName = "LandSize"
        Me.LandSizeDataGridViewTextBoxColumn.HeaderText = "ទំហំដី"
        Me.LandSizeDataGridViewTextBoxColumn.Name = "LandSizeDataGridViewTextBoxColumn"
        Me.LandSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LandSizeTrueDataGridViewTextBoxColumn
        '
        Me.LandSizeTrueDataGridViewTextBoxColumn.DataPropertyName = "LandSizeTrue"
        Me.LandSizeTrueDataGridViewTextBoxColumn.HeaderText = "ទំហំដីជាក់ស្តែង"
        Me.LandSizeTrueDataGridViewTextBoxColumn.Name = "LandSizeTrueDataGridViewTextBoxColumn"
        Me.LandSizeTrueDataGridViewTextBoxColumn.ReadOnly = True
        Me.LandSizeTrueDataGridViewTextBoxColumn.Width = 120
        '
        'QryPeopleSearchBindingSource
        '
        Me.QryPeopleSearchBindingSource.DataMember = "qryPeopleSearch"
        Me.QryPeopleSearchBindingSource.DataSource = Me.PeopleLandSolveDataSet
        '
        'PeopleLandSolveDataSet
        '
        Me.PeopleLandSolveDataSet.DataSetName = "PeopleLandSolveDataSet"
        Me.PeopleLandSolveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QryPeopleSearchTableAdapter
        '
        Me.QryPeopleSearchTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocIDDataGridViewTextBoxColumn, Me.DocumentTypeNameDataGridViewTextBoxColumn, Me.DocNumDataGridViewTextBoxColumn, Me.YearDocDataGridViewTextBoxColumn, Me.IRCNumDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.QryEditDocSolvedBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(520, 86)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(792, 162)
        Me.DataGridView2.TabIndex = 37
        '
        'QryEditDocSolvedBindingSource
        '
        Me.QryEditDocSolvedBindingSource.DataMember = "qryEditDocSolved"
        Me.QryEditDocSolvedBindingSource.DataSource = Me.PeopleLandSolveDataSet
        '
        'QryEditDocSolvedTableAdapter
        '
        Me.QryEditDocSolvedTableAdapter.ClearBeforeFill = True
        '
        'DocIDDataGridViewTextBoxColumn
        '
        Me.DocIDDataGridViewTextBoxColumn.DataPropertyName = "DocID"
        Me.DocIDDataGridViewTextBoxColumn.HeaderText = "កូដឯកសារ"
        Me.DocIDDataGridViewTextBoxColumn.Name = "DocIDDataGridViewTextBoxColumn"
        Me.DocIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DocumentTypeNameDataGridViewTextBoxColumn
        '
        Me.DocumentTypeNameDataGridViewTextBoxColumn.DataPropertyName = "DocumentTypeName"
        Me.DocumentTypeNameDataGridViewTextBoxColumn.HeaderText = "ប្រភេទឯកសារ"
        Me.DocumentTypeNameDataGridViewTextBoxColumn.Name = "DocumentTypeNameDataGridViewTextBoxColumn"
        Me.DocumentTypeNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentTypeNameDataGridViewTextBoxColumn.Width = 150
        '
        'DocNumDataGridViewTextBoxColumn
        '
        Me.DocNumDataGridViewTextBoxColumn.DataPropertyName = "DocNum"
        Me.DocNumDataGridViewTextBoxColumn.HeaderText = "លេខឯកសារ"
        Me.DocNumDataGridViewTextBoxColumn.Name = "DocNumDataGridViewTextBoxColumn"
        Me.DocNumDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocNumDataGridViewTextBoxColumn.Width = 250
        '
        'YearDocDataGridViewTextBoxColumn
        '
        Me.YearDocDataGridViewTextBoxColumn.DataPropertyName = "YearDoc"
        Me.YearDocDataGridViewTextBoxColumn.HeaderText = "ឆ្នាំ"
        Me.YearDocDataGridViewTextBoxColumn.Name = "YearDocDataGridViewTextBoxColumn"
        Me.YearDocDataGridViewTextBoxColumn.ReadOnly = True
        Me.YearDocDataGridViewTextBoxColumn.Width = 80
        '
        'IRCNumDataGridViewTextBoxColumn
        '
        Me.IRCNumDataGridViewTextBoxColumn.DataPropertyName = "IRCNum"
        Me.IRCNumDataGridViewTextBoxColumn.HeaderText = "លេខ IRC"
        Me.IRCNumDataGridViewTextBoxColumn.Name = "IRCNumDataGridViewTextBoxColumn"
        Me.IRCNumDataGridViewTextBoxColumn.ReadOnly = True
        Me.IRCNumDataGridViewTextBoxColumn.Width = 150
        '
        'txtIRCNum
        '
        Me.txtIRCNum.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCNum.FormattingEnabled = True
        Me.txtIRCNum.Location = New System.Drawing.Point(138, 296)
        Me.txtIRCNum.Name = "txtIRCNum"
        Me.txtIRCNum.Size = New System.Drawing.Size(1174, 32)
        Me.txtIRCNum.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 22)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "លេខ IRC"
        '
        'frmEditDocSolved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 535)
        Me.Controls.Add(Me.txtIRCNum)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.cboOfficerName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPeopleYearDoc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPeopleDocNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboPeopleDoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDocID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLandID)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.cboPeopleName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmEditDocSolved"
        Me.Text = "កែប្រែឯកសារដោះស្រាយគោលនយោបាយ"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryPeopleSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryEditDocSolvedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents cboOfficerName As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPeopleYearDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPeopleDocNum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPeopleDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDocID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLandID As System.Windows.Forms.TextBox
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents cboPeopleName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PeopleLandSolveDataSet As PeopleLandSolved.PeopleLandSolveDataSet
    Friend WithEvents QryPeopleSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryPeopleSearchTableAdapter As PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryPeopleSearchTableAdapter
    Friend WithEvents LandIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeopleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandSizeTrueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents QryEditDocSolvedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryEditDocSolvedTableAdapter As PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryEditDocSolvedTableAdapter
    Friend WithEvents DocIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentTypeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IRCNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtIRCNum As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
