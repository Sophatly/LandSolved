Imports System.Data.SqlClient
Imports System.IO
Public Class frmDocument

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Dim frmL As New frmLandInfo
        frmL.MdiParent = Main
        frmL.WindowState = FormWindowState.Maximized
        Close()
        frmL.Show()
    End Sub

    Private Sub frmDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryPeopleSearch' table. You can move, or remove it, as needed.
        Dim t As New Land
        t.DBCon()
        QryPeopleSearchTableAdapter.Connection.ConnectionString = t.cnnstr
        QryPeopleSearchTableAdapter.Connection.Open()
        QryPeopleSearchTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryPeopleSearch)
        QryPeopleSearchTableAdapter.Connection.Close()

        t.LoadDoc(cboPeopleDoc)
        t.LoadOfficerName(cboPeopleOfficerName)
        t.LoadDoc(cboDocSolved)
        t.LoadOfficerName(cboOfficerNameSolved)
        t.LoadPeopleName(cboPeopleSearch)

        DataGridView1.Font = New Font("Khmer OS System", 9)

    End Sub

    Private Sub cboPeopleSearch_TextChanged(sender As Object, e As EventArgs) Handles cboPeopleSearch.TextChanged
        Dim t As New Land
        t.DBCon()
        QryPeopleSearchTableAdapter.Connection.ConnectionString = t.cnnstr
        QryPeopleSearchTableAdapter.Connection.Open()
        QryPeopleSearchTableAdapter.FillByPeopleName(PeopleLandSolveDataSet.qryPeopleSearch, cboPeopleSearch.Text & "%")
        QryPeopleSearchTableAdapter.Connection.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim intIndex As Integer
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        intIndex = e.RowIndex
        DataGridView1.Rows(intIndex).Selected = True
        txtLandID.Text = DataGridView1.Rows(intIndex).Cells(0).Value
    End Sub

    
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtLandID.Text = String.Empty Then
            MsgBox("សូមជ្រើសរើសលេខកូដក្បាលដីដីជាមុន")
            Exit Sub
        End If
        Dim sqlcom As New SqlCommand
        Dim sqlstr As String
        Dim t As New Land
        t.DBCon()
        Try
            sqlstr = "INSERT INTO tblDocument(LandID,DocName,DocNum,YearDoc,OfficerName,IRCNum) VALUES(@LandID," & _
                "@DocName,@DocNum,@YearDoc,@OfficerName,@IRCNum)"
            sqlcom = New SqlCommand(sqlstr, t.cnn)
            t.cnn.Open()
            sqlcom.Parameters.AddWithValue("@LandID", txtLandID.Text)
            sqlcom.Parameters.AddWithValue("@DocName", cboDocSolved.SelectedValue)
            sqlcom.Parameters.AddWithValue("@DocNum", txtDocNum.Text)
            sqlcom.Parameters.AddWithValue("@YearDoc", txtYearDoc.Text)
            sqlcom.Parameters.AddWithValue("@OfficerName", cboOfficerNameSolved.SelectedValue)
            sqlcom.Parameters.AddWithValue("@IRCNum", txtIRCNum.Text)
            sqlcom.ExecuteNonQuery()
            MsgBox("ព័ត៌មានឯកសារដីដោះស្រាយគោលនយោបាយត្រូវបានបញ្ចូលរួច")
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub BtnSavePeopleDoc_Click(sender As Object, e As EventArgs) Handles BtnSavePeopleDoc.Click
        If txtLandID.Text = String.Empty Then
            MsgBox("សូមជ្រើសរើសលេខកូដក្បាលដីដីជាមុន")
            Exit Sub
        End If
        Dim sqlcom As New SqlCommand
        Dim sqlstr As String
        Dim t As New Land
        t.DBCon()
        Try
            sqlstr = "INSERT INTO tblDocPeople(LandID,DocPeopleName,DocPeopleNum,YearPeopleDoc,DocOfficerName) VALUES(@LandID," & _
                "@DocPeopleName,@DocPeopleNum,@YearPeopleDoc,@DocOfficerName)"
            sqlcom = New SqlCommand(sqlstr, t.cnn)
            t.cnn.Open()
            sqlcom.Parameters.AddWithValue("@LandID", txtLandID.Text)
            sqlcom.Parameters.AddWithValue("@DocPeopleName", cboPeopleDoc.SelectedValue)
            sqlcom.Parameters.AddWithValue("@DocPeopleNum", txtPeopleDocNum.Text)
            sqlcom.Parameters.AddWithValue("@YearPeopleDoc", txtYearPeopleDoc.Text)
            sqlcom.Parameters.AddWithValue("@DocOfficerName", cboPeopleOfficerName.SelectedValue)
            sqlcom.ExecuteNonQuery()
            MsgBox("ព័ត៌មានឯកសាររបស់ម្ចាស់បណ្តឹងត្រូវបានបញ្ចូលរួច")
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class