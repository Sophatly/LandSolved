Public Class frmBySuggestion

    Private Sub frmBySuggestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Land
        t.DBCon()
        qryBySuggestionTableAdapter.Connection.ConnectionString = t.cnnstr
        qryBySuggestionTableAdapter.Connection.Open()
        Me.qryBySuggestionTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryBySuggestion)
        Me.ReportViewer1.RefreshReport()
        qryBySuggestionTableAdapter.Connection.Close()
    End Sub
End Class