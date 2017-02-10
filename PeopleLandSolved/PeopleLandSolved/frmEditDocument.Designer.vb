<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditDocumentSolved
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPeopleName = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LandIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeopleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandSizeTrueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QryPeopleSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleLandSolveDataSet = New PeopleLandSolved.PeopleLandSolveDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DocPeopleID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentTypeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocPeopleNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearPeopleDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QryDocPeopleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QryPeopleSearchTableAdapter = New PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryPeopleSearchTableAdapter()
        Me.QryDocPeopleTableAdapter = New PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryDocPeopleTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLandID = New System.Windows.Forms.TextBox()
        Me.txtDocID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPeopleDoc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPeopleDocNum = New System.Windows.Forms.TextBox()
        Me.txtPeopleYearDoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboOfficerName = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryPeopleSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryDocPeopleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ឈ្មោះម្ចាស់បណ្តឹង"
        '
        'cboPeopleName
        '
        Me.cboPeopleName.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeopleName.FormattingEnabled = True
        Me.cboPeopleName.Location = New System.Drawing.Point(145, 12)
        Me.cboPeopleName.Name = "cboPeopleName"
        Me.cboPeopleName.Size = New System.Drawing.Size(257, 30)
        Me.cboPeopleName.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LandIDDataGridViewTextBoxColumn, Me.PeopleNameDataGridViewTextBoxColumn, Me.LandSizeDataGridViewTextBoxColumn, Me.LandSizeTrueDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QryPeopleSearchBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(510, 164)
        Me.DataGridView1.TabIndex = 2
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
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DocPeopleID, Me.DocumentTypeNameDataGridViewTextBoxColumn, Me.DocPeopleNumDataGridViewTextBoxColumn, Me.YearPeopleDocDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.QryDocPeopleBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(551, 48)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(633, 161)
        Me.DataGridView2.TabIndex = 3
        '
        'DocPeopleID
        '
        Me.DocPeopleID.DataPropertyName = "DocPeopleID"
        Me.DocPeopleID.HeaderText = "លេខឯកសារ"
        Me.DocPeopleID.Name = "DocPeopleID"
        Me.DocPeopleID.ReadOnly = True
        '
        'DocumentTypeNameDataGridViewTextBoxColumn
        '
        Me.DocumentTypeNameDataGridViewTextBoxColumn.DataPropertyName = "DocumentTypeName"
        Me.DocumentTypeNameDataGridViewTextBoxColumn.HeaderText = "ឯកសារកាន់កាប់ដីធ្លី"
        Me.DocumentTypeNameDataGridViewTextBoxColumn.Name = "DocumentTypeNameDataGridViewTextBoxColumn"
        Me.DocumentTypeNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.DocumentTypeNameDataGridViewTextBoxColumn.Width = 250
        '
        'DocPeopleNumDataGridViewTextBoxColumn
        '
        Me.DocPeopleNumDataGridViewTextBoxColumn.DataPropertyName = "DocPeopleNum"
        Me.DocPeopleNumDataGridViewTextBoxColumn.HeaderText = "លេខឯកសារ"
        Me.DocPeopleNumDataGridViewTextBoxColumn.Name = "DocPeopleNumDataGridViewTextBoxColumn"
        Me.DocPeopleNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YearPeopleDocDataGridViewTextBoxColumn
        '
        Me.YearPeopleDocDataGridViewTextBoxColumn.DataPropertyName = "YearPeopleDoc"
        Me.YearPeopleDocDataGridViewTextBoxColumn.HeaderText = "ឆ្នាំកាន់កាប់"
        Me.YearPeopleDocDataGridViewTextBoxColumn.Name = "YearPeopleDocDataGridViewTextBoxColumn"
        Me.YearPeopleDocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QryDocPeopleBindingSource
        '
        Me.QryDocPeopleBindingSource.DataMember = "qryDocPeople"
        Me.QryDocPeopleBindingSource.DataSource = Me.PeopleLandSolveDataSet
        '
        'QryPeopleSearchTableAdapter
        '
        Me.QryPeopleSearchTableAdapter.ClearBeforeFill = True
        '
        'QryDocPeopleTableAdapter
        '
        Me.QryDocPeopleTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "លេខក្បាលដី"
        '
        'txtLandID
        '
        Me.txtLandID.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLandID.Location = New System.Drawing.Point(145, 221)
        Me.txtLandID.Name = "txtLandID"
        Me.txtLandID.Size = New System.Drawing.Size(400, 29)
        Me.txtLandID.TabIndex = 5
        '
        'txtDocID
        '
        Me.txtDocID.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocID.Location = New System.Drawing.Point(644, 221)
        Me.txtDocID.Name = "txtDocID"
        Me.txtDocID.Size = New System.Drawing.Size(540, 29)
        Me.txtDocID.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(553, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "លេខឯកសារ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ឯកសារកាន់កាប់ដី"
        '
        'cboPeopleDoc
        '
        Me.cboPeopleDoc.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeopleDoc.FormattingEnabled = True
        Me.cboPeopleDoc.Location = New System.Drawing.Point(145, 256)
        Me.cboPeopleDoc.Name = "cboPeopleDoc"
        Me.cboPeopleDoc.Size = New System.Drawing.Size(1039, 32)
        Me.cboPeopleDoc.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "លេខឯកសារ"
        '
        'txtPeopleDocNum
        '
        Me.txtPeopleDocNum.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeopleDocNum.Location = New System.Drawing.Point(145, 297)
        Me.txtPeopleDocNum.Name = "txtPeopleDocNum"
        Me.txtPeopleDocNum.Size = New System.Drawing.Size(1039, 29)
        Me.txtPeopleDocNum.TabIndex = 11
        '
        'txtPeopleYearDoc
        '
        Me.txtPeopleYearDoc.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeopleYearDoc.Location = New System.Drawing.Point(145, 332)
        Me.txtPeopleYearDoc.Name = "txtPeopleYearDoc"
        Me.txtPeopleYearDoc.Size = New System.Drawing.Size(1039, 29)
        Me.txtPeopleYearDoc.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ឆ្នាំកាន់កាប់"
        '
        'cboOfficerName
        '
        Me.cboOfficerName.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOfficerName.FormattingEnabled = True
        Me.cboOfficerName.Location = New System.Drawing.Point(145, 367)
        Me.cboOfficerName.Name = "cboOfficerName"
        Me.cboOfficerName.Size = New System.Drawing.Size(1039, 32)
        Me.cboOfficerName.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 22)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "អាជ្ញាធរមូលដ្ឋាន"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(932, 405)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(123, 37)
        Me.BtnUpdate.TabIndex = 16
        Me.BtnUpdate.Text = "កែប្រែ"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(1061, 405)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(123, 37)
        Me.BtnCancel.TabIndex = 17
        Me.BtnCancel.Text = "ចាកចេញ"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'frmEditDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 612)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnUpdate)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cboPeopleName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEditDocument"
        Me.Text = "កែប្រែឯកសារដីម្ចាស់បណ្តឹង"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryPeopleSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryDocPeopleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPeopleName As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PeopleLandSolveDataSet As PeopleLandSolved.PeopleLandSolveDataSet
    Friend WithEvents QryPeopleSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryPeopleSearchTableAdapter As PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryPeopleSearchTableAdapter
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents QryDocPeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryDocPeopleTableAdapter As PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryDocPeopleTableAdapter
    Friend WithEvents LandIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeopleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandSizeTrueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocPeopleID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentTypeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocPeopleNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearPeopleDocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLandID As System.Windows.Forms.TextBox
    Friend WithEvents txtDocID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPeopleDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPeopleDocNum As System.Windows.Forms.TextBox
    Friend WithEvents txtPeopleYearDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboOfficerName As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
End Class
