Public Class frmTesting

    Private Sub frmTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Land
        t.DBCon()
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryReport' table. You can move, or remove it, as needed.
        qryReportTableAdapter.Connection.ConnectionString = t.cnnstr
        qryReportTableAdapter.Connection.Open()
        Me.qryReportTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryReport)

        Me.ReportViewer1.RefreshReport()
        qryReportTableAdapter.Connection.Close()
    End Sub
End Class