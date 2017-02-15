Imports System.Windows.Forms

Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmC As New frmLandInfo
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.Show()
    End Sub

    Private Sub TSMExit_Click(sender As Object, e As EventArgs) Handles TSMExit.Click
        Close()
    End Sub

    Private Sub TSBLand_Click(sender As Object, e As EventArgs) Handles TSBLand.Click
        Dim frmC As New frmLandInfo
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.Show()

    End Sub

    Private Sub TSBExit_Click(sender As Object, e As EventArgs) Handles TSBExit.Click
        Close()
    End Sub

   
    Private Sub TSBDocument_Click(sender As Object, e As EventArgs) Handles TSBDocument.Click
        Dim frmC As New frmDocument
        frmC.MdiParent = Me
        frmC.WindowState = FormWindowState.Maximized
        frmC.Show()
    End Sub

    Private Sub TSBReport_Click(sender As Object, e As EventArgs) Handles TSBReport.Click
        'Dim frmR As New frmReport
        'frmR.MdiParent = Me
        'frmR.WindowState = FormWindowState.Maximized
        'frmR.Show()
        'Dim frmRD As New frmReportDetail
        'frmRD.MdiParent = Me
        'frmRD.WindowState = FormWindowState.Maximized
        'frmRD.Show()
        Dim frmRT As New frmTesting
        frmRT.MdiParent = Me
        frmRT.WindowState = FormWindowState.Maximized
        frmRT.Show()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frmEDoc As New frmEditDocumentSolved
        frmEDoc.MdiParent = Me
        frmEDoc.WindowState = FormWindowState.Maximized
        frmEDoc.Show()
    End Sub

    Private Sub TBSEditDocSolved_Click(sender As Object, e As EventArgs) Handles TBSEditDocSolved.Click
        Dim frmEDocSolved As New frmEditDocSolved
        frmEDocSolved.MdiParent = Me
        frmEDocSolved.WindowState = FormWindowState.Maximized
        frmEDocSolved.Show()
    End Sub

    Private Sub TBSBySuggestion_Click(sender As Object, e As EventArgs) Handles TBSBySuggestion.Click
        Dim frmBySug As New frmBySuggestion
        frmBySug.MdiParent = Me
        frmBySug.WindowState = FormWindowState.Maximized
        frmBySug.Show()
    End Sub

    Private Sub TSBMapPath_Click(sender As Object, e As EventArgs) Handles TSBMapPath.Click
        Dim frmPicPath As New frmPicPath
        frmPicPath.MdiParent = Me
        frmPicPath.WindowState = FormWindowState.Maximized
        frmPicPath.Show()

    End Sub
End Class
