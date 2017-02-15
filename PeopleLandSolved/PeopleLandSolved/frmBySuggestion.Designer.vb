<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBySuggestion
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.qryBySuggestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeopleLandSolveDataSet = New PeopleLandSolved.PeopleLandSolveDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.qryBySuggestionTableAdapter = New PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryBySuggestionTableAdapter()
        CType(Me.qryBySuggestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'qryBySuggestionBindingSource
        '
        Me.qryBySuggestionBindingSource.DataMember = "qryBySuggestion"
        Me.qryBySuggestionBindingSource.DataSource = Me.PeopleLandSolveDataSet
        '
        'PeopleLandSolveDataSet
        '
        Me.PeopleLandSolveDataSet.DataSetName = "PeopleLandSolveDataSet"
        Me.PeopleLandSolveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.qryBySuggestionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PeopleLandSolved.rptbySuggestion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1083, 510)
        Me.ReportViewer1.TabIndex = 0
        '
        'qryBySuggestionTableAdapter
        '
        Me.qryBySuggestionTableAdapter.ClearBeforeFill = True
        '
        'frmBySuggestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 534)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmBySuggestion"
        Me.Text = "frmBySuggestion"
        CType(Me.qryBySuggestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeopleLandSolveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents qryBySuggestionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeopleLandSolveDataSet As PeopleLandSolved.PeopleLandSolveDataSet
    Friend WithEvents qryBySuggestionTableAdapter As PeopleLandSolved.PeopleLandSolveDataSetTableAdapters.qryBySuggestionTableAdapter
End Class
