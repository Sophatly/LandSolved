Imports System.Data.SqlClient
Public Class frmPeople

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
        Dim frmC As New frmLandInfo
        frmC.MdiParent = Main
        frmC.WindowState = FormWindowState.Maximized
        frmC.Show()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim t As New Land
        Dim sqlcom As New SqlCommand
        t.DBCon()
        Dim sqlstr As String
        sqlstr = "Insert into tblPeople(PeopleID,PeopleName) Values(@PeopleID,@PeopleName)"
        t.cnn.Open()
        Try
            sqlcom = New SqlCommand(sqlstr, t.cnn)
            sqlcom.Parameters.AddWithValue("@PeopleID", txtPeopleID.Text)
            sqlcom.Parameters.AddWithValue("@PeopleName", txtPeopleName.Text)
            sqlcom.ExecuteNonQuery()
            MsgBox("ឈ្មោះម្ចាស់បណ្តឹងត្រូវបានបញ្ចូលដោយជោគជ័យ")
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
        End Try

    End Sub
End Class