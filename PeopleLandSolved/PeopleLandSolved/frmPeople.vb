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
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnPeopleID_Click(sender As Object, e As EventArgs) Handles BtnPeopleID.Click
        Dim t As New Land
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim sqlstr As String
        Dim i As Integer
        Try
            t.DBCon()
            sqlstr = "Select PeopleID from tblPeople"
            da = New SqlDataAdapter(sqlstr, t.cnn)
            t.cnn.Open()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count + 1
                    i = i + 1
                Next i
            End If
            txtPeopleID.Text = i
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class