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
End Class
