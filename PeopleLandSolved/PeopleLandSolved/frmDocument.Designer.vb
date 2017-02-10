<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocument
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
        Me.txtLandID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboPeopleOfficerName = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtYearPeopleDoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPeopleDocNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPeopleDoc = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIRCNum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboOfficerNameSolved = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYearDoc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDocNum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboDocSolved = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPeopleSearch = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LandIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeopleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandSizeTrueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QryPeopleSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleLandSolveDataSet = New PeopleLandSolved.PeopleLandSolveDataSet()
        Me.QryPeopleSearchTableAdapter = New PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryPeopleSearchTableAdapter()
        Me.BtnSavePeopleDoc = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryPeopleSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "លេខកូដក្បាលដី"
        '
        'txtLandID
        '
        Me.txtLandID.Enabled = False
        Me.txtLandID.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLandID.Location = New System.Drawing.Point(120, 271)
        Me.txtLandID.Name = "txtLandID"
        Me.txtLandID.Size = New System.Drawing.Size(430, 32)
        Me.txtLandID.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPeopleOfficerName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtYearPeopleDoc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPeopleDocNum)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboPeopleDoc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 191)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ឯកសារម្ចាស់បណ្តឹង"
        '
        'cboPeopleOfficerName
        '
        Me.cboPeopleOfficerName.FormattingEnabled = True
        Me.cboPeopleOfficerName.Location = New System.Drawing.Point(162, 144)
        Me.cboPeopleOfficerName.Name = "cboPeopleOfficerName"
        Me.cboPeopleOfficerName.Size = New System.Drawing.Size(355, 30)
        Me.cboPeopleOfficerName.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ឈ្មោះអាជ្ញាធរមូលដ្ឋាន"
        '
        'txtYearPeopleDoc
        '
        Me.txtYearPeopleDoc.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearPeopleDoc.Location = New System.Drawing.Point(162, 106)
        Me.txtYearPeopleDoc.Name = "txtYearPeopleDoc"
        Me.txtYearPeopleDoc.Size = New System.Drawing.Size(355, 32)
        Me.txtYearPeopleDoc.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ឆ្នាំកាន់កាប់ដីធ្លី"
        '
        'txtPeopleDocNum
        '
        Me.txtPeopleDocNum.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeopleDocNum.Location = New System.Drawing.Point(162, 68)
        Me.txtPeopleDocNum.Name = "txtPeopleDocNum"
        Me.txtPeopleDocNum.Size = New System.Drawing.Size(355, 32)
        Me.txtPeopleDocNum.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "លេខឯកសារដីធ្លី"
        '
        'cboPeopleDoc
        '
        Me.cboPeopleDoc.FormattingEnabled = True
        Me.cboPeopleDoc.Location = New System.Drawing.Point(162, 32)
        Me.cboPeopleDoc.Name = "cboPeopleDoc"
        Me.cboPeopleDoc.Size = New System.Drawing.Size(355, 30)
        Me.cboPeopleDoc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ឯកសារកាន់កាប់ដីធ្លី"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIRCNum)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cboOfficerNameSolved)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtYearDoc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDocNum)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboDocSolved)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(556, 277)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 226)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ឯកសារដោះស្រាយគោលនយោបាយ"
        '
        'txtIRCNum
        '
        Me.txtIRCNum.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIRCNum.Location = New System.Drawing.Point(161, 32)
        Me.txtIRCNum.Name = "txtIRCNum"
        Me.txtIRCNum.Size = New System.Drawing.Size(469, 32)
        Me.txtIRCNum.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 22)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "ជាន់លេខ IRC"
        '
        'cboOfficerNameSolved
        '
        Me.cboOfficerNameSolved.FormattingEnabled = True
        Me.cboOfficerNameSolved.Location = New System.Drawing.Point(161, 182)
        Me.cboOfficerNameSolved.Name = "cboOfficerNameSolved"
        Me.cboOfficerNameSolved.Size = New System.Drawing.Size(469, 30)
        Me.cboOfficerNameSolved.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ឈ្មោះអាជ្ញាធរមូលដ្ឋាន"
        '
        'txtYearDoc
        '
        Me.txtYearDoc.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearDoc.Location = New System.Drawing.Point(161, 144)
        Me.txtYearDoc.Name = "txtYearDoc"
        Me.txtYearDoc.Size = New System.Drawing.Size(469, 32)
        Me.txtYearDoc.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ឆ្នាំកាន់កាប់ដីធ្លី"
        '
        'txtDocNum
        '
        Me.txtDocNum.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocNum.Location = New System.Drawing.Point(161, 106)
        Me.txtDocNum.Name = "txtDocNum"
        Me.txtDocNum.Size = New System.Drawing.Size(469, 32)
        Me.txtDocNum.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 22)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "លេខឯកសារដីធ្លី"
        '
        'cboDocSolved
        '
        Me.cboDocSolved.FormattingEnabled = True
        Me.cboDocSolved.Location = New System.Drawing.Point(161, 70)
        Me.cboDocSolved.Name = "cboDocSolved"
        Me.cboDocSolved.Size = New System.Drawing.Size(469, 30)
        Me.cboDocSolved.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 22)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "ឯកសារកាន់កាប់ដីធ្លី"
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(1062, 509)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(141, 39)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "រក្សាទុក"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(427, 10)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(141, 38)
        Me.BtnCancel.TabIndex = 14
        Me.BtnCancel.Text = "ចាកចេញ"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 22)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "ឈ្មោះម្ចាស់បណ្តឹង"
        '
        'cboPeopleSearch
        '
        Me.cboPeopleSearch.Font = New System.Drawing.Font("Khmer OS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeopleSearch.FormattingEnabled = True
        Me.cboPeopleSearch.Location = New System.Drawing.Point(133, 16)
        Me.cboPeopleSearch.Name = "cboPeopleSearch"
        Me.cboPeopleSearch.Size = New System.Drawing.Size(288, 32)
        Me.cboPeopleSearch.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LandIDDataGridViewTextBoxColumn, Me.PeopleNameDataGridViewTextBoxColumn, Me.LandSizeDataGridViewTextBoxColumn, Me.LandSizeTrueDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QryPeopleSearchBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(849, 202)
        Me.DataGridView1.TabIndex = 16
        '
        'LandIDDataGridViewTextBoxColumn
        '
        Me.LandIDDataGridViewTextBoxColumn.DataPropertyName = "LandID"
        Me.LandIDDataGridViewTextBoxColumn.HeaderText = "លេខកូដក្បាលដី"
        Me.LandIDDataGridViewTextBoxColumn.Name = "LandIDDataGridViewTextBoxColumn"
        Me.LandIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LandIDDataGridViewTextBoxColumn.Width = 150
        '
        'PeopleNameDataGridViewTextBoxColumn
        '
        Me.PeopleNameDataGridViewTextBoxColumn.DataPropertyName = "PeopleName"
        Me.PeopleNameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះម្ចាស់បណ្តឹង"
        Me.PeopleNameDataGridViewTextBoxColumn.Name = "PeopleNameDataGridViewTextBoxColumn"
        Me.PeopleNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeopleNameDataGridViewTextBoxColumn.Width = 200
        '
        'LandSizeDataGridViewTextBoxColumn
        '
        Me.LandSizeDataGridViewTextBoxColumn.DataPropertyName = "LandSize"
        Me.LandSizeDataGridViewTextBoxColumn.HeaderText = "ទំហំដីដាក់បណ្តឹង"
        Me.LandSizeDataGridViewTextBoxColumn.Name = "LandSizeDataGridViewTextBoxColumn"
        Me.LandSizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LandSizeDataGridViewTextBoxColumn.Width = 150
        '
        'LandSizeTrueDataGridViewTextBoxColumn
        '
        Me.LandSizeTrueDataGridViewTextBoxColumn.DataPropertyName = "LandSizeTrue"
        Me.LandSizeTrueDataGridViewTextBoxColumn.HeaderText = "ទំហំដីវាស់ជាក់ស្តែង"
        Me.LandSizeTrueDataGridViewTextBoxColumn.Name = "LandSizeTrueDataGridViewTextBoxColumn"
        Me.LandSizeTrueDataGridViewTextBoxColumn.ReadOnly = True
        Me.LandSizeTrueDataGridViewTextBoxColumn.Width = 200
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
        'BtnSavePeopleDoc
        '
        Me.BtnSavePeopleDoc.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavePeopleDoc.Location = New System.Drawing.Point(409, 506)
        Me.BtnSavePeopleDoc.Name = "BtnSavePeopleDoc"
        Me.BtnSavePeopleDoc.Size = New System.Drawing.Size(141, 39)
        Me.BtnSavePeopleDoc.TabIndex = 17
        Me.BtnSavePeopleDoc.Text = "រក្សាទុក"
        Me.BtnSavePeopleDoc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(885, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(465, 242)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSavePeopleDoc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cboPeopleSearch)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtLandID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDocument"
        Me.Text = "បញ្ចូលឯកសារដី"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryPeopleSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLandID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPeopleOfficerName As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtYearPeopleDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPeopleDocNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPeopleDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboOfficerNameSolved As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYearDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDocNum As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboDocSolved As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents txtIRCNum As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboPeopleSearch As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PeopleLandSolveDataSet As PeopleLandSolved.PeopleLandSolveDataSet
    Friend WithEvents QryPeopleSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryPeopleSearchTableAdapter As PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryPeopleSearchTableAdapter
    Friend WithEvents LandIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeopleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandSizeTrueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnSavePeopleDoc As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
