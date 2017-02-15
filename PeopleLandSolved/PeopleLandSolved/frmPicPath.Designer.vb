<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicPath
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPicName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPeopleName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LandIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeopleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandSizeTrueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QryPeopleSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleLandSolveDataSet = New PeopleLandSolved.PeopleLandSolveDataSet()
        Me.QryPeopleSearchTableAdapter = New PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryPeopleSearchTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPrintMap = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryPeopleSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 503)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(51, 43)
        Me.ListBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(522, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "បើកផែនទី"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPicName
        '
        Me.txtPicName.Location = New System.Drawing.Point(384, 12)
        Me.txtPicName.Name = "txtPicName"
        Me.txtPicName.Size = New System.Drawing.Size(98, 20)
        Me.txtPicName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "បញ្ចូលឈ្មោះម្ចាស់បណ្តឹង"
        '
        'txtPeopleName
        '
        Me.txtPeopleName.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeopleName.Location = New System.Drawing.Point(161, 12)
        Me.txtPeopleName.Name = "txtPeopleName"
        Me.txtPeopleName.Size = New System.Drawing.Size(181, 29)
        Me.txtPeopleName.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LandIDDataGridViewTextBoxColumn, Me.PeopleNameDataGridViewTextBoxColumn, Me.LandSizeDataGridViewTextBoxColumn, Me.LandSizeTrueDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QryPeopleSearchBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(495, 450)
        Me.DataGridView1.TabIndex = 4
        '
        'LandIDDataGridViewTextBoxColumn
        '
        Me.LandIDDataGridViewTextBoxColumn.DataPropertyName = "LandID"
        Me.LandIDDataGridViewTextBoxColumn.HeaderText = "លេខក្បាលដី"
        Me.LandIDDataGridViewTextBoxColumn.Name = "LandIDDataGridViewTextBoxColumn"
        Me.LandIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeopleNameDataGridViewTextBoxColumn
        '
        Me.PeopleNameDataGridViewTextBoxColumn.DataPropertyName = "PeopleName"
        Me.PeopleNameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះម្ចាស់ដើមបណ្តឹង"
        Me.PeopleNameDataGridViewTextBoxColumn.Name = "PeopleNameDataGridViewTextBoxColumn"
        Me.PeopleNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PeopleNameDataGridViewTextBoxColumn.Width = 170
        '
        'LandSizeDataGridViewTextBoxColumn
        '
        Me.LandSizeDataGridViewTextBoxColumn.DataPropertyName = "LandSize"
        Me.LandSizeDataGridViewTextBoxColumn.HeaderText = "ទំហំដីបណ្តឹង"
        Me.LandSizeDataGridViewTextBoxColumn.Name = "LandSizeDataGridViewTextBoxColumn"
        Me.LandSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LandSizeTrueDataGridViewTextBoxColumn
        '
        Me.LandSizeTrueDataGridViewTextBoxColumn.DataPropertyName = "LandSizeTrue"
        Me.LandSizeTrueDataGridViewTextBoxColumn.HeaderText = "ទំហំវាស់ជាក់ស្តែង"
        Me.LandSizeTrueDataGridViewTextBoxColumn.Name = "LandSizeTrueDataGridViewTextBoxColumn"
        Me.LandSizeTrueDataGridViewTextBoxColumn.ReadOnly = True
        Me.LandSizeTrueDataGridViewTextBoxColumn.Width = 110
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
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(522, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(787, 444)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BtnPrintMap
        '
        Me.BtnPrintMap.Font = New System.Drawing.Font("Khmer OS System", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintMap.Location = New System.Drawing.Point(644, 3)
        Me.BtnPrintMap.Name = "BtnPrintMap"
        Me.BtnPrintMap.Size = New System.Drawing.Size(116, 39)
        Me.BtnPrintMap.TabIndex = 6
        Me.BtnPrintMap.Text = "បោះពុម្ពផែនទី"
        Me.BtnPrintMap.UseVisualStyleBackColor = True
        '
        'frmPicPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 563)
        Me.Controls.Add(Me.BtnPrintMap)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPeopleName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPicName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "frmPicPath"
        Me.Text = "បញ្ចូលទីតាំងរូបភាពក្បាលដីម្ចាស់បណ្តឹង"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryPeopleSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPicName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPeopleName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PeopleLandSolveDataSet As PeopleLandSolved.PeopleLandSolveDataSet
    Friend WithEvents QryPeopleSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QryPeopleSearchTableAdapter As PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryPeopleSearchTableAdapter
    Friend WithEvents LandIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeopleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LandSizeTrueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnPrintMap As System.Windows.Forms.Button
End Class
