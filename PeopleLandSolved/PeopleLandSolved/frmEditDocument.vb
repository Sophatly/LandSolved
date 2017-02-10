Imports System.Data.SqlClient

Public Class frmEditDocumentSolved

    Private Sub frmEditDocumentSolved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Land
        t.DBCon()
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryDocPeople' table. You can move, or remove it, as needed.
        QryPeopleSearchTableAdapter.Connection.ConnectionString = t.cnnstr
        QryPeopleSearchTableAdapter.Connection.Open()
        QryDocPeopleTableAdapter.Connection.ConnectionString = t.cnnstr
        QryDocPeopleTableAdapter.Connection.Open()
        Me.QryDocPeopleTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryDocPeople)
        QryDocPeopleTableAdapter.Connection.Close()
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryPeopleSearch' table. You can move, or remove it, as needed.
        Me.QryPeopleSearchTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryPeopleSearch)

        QryPeopleSearchTableAdapter.Connection.Close()

        t.LoadPeopleName(cboPeopleName)
        DataGridView1.Font = New Font("Khmer OS System", 9)
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        DataGridView2.Font = New Font("Khmer OS System", 9)
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        t.LoadOfficerName(cboOfficerName)
        t.LoadDocument(cboPeopleDoc)
    End Sub

    Private Sub cboPeopleName_TextChanged(sender As Object, e As EventArgs) Handles cboPeopleName.TextChanged
        Dim t As New Land
        t.DBCon()
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryPeopleSearch' table. You can move, or remove it, as needed.
        QryPeopleSearchTableAdapter.Connection.ConnectionString = t.cnnstr
        QryPeopleSearchTableAdapter.Connection.Open()
        QryPeopleSearchTableAdapter.FillByPeopleName(PeopleLandSolveDataSet.qryPeopleSearch, cboPeopleName.Text & "%")
        QryPeopleSearchTableAdapter.Connection.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim t As New Land
        Dim intIndex As Integer
        t.DBCon()
        QryDocPeopleTableAdapter.Connection.ConnectionString = t.cnnstr
        QryDocPeopleTableAdapter.Connection.Open()
        QryDocPeopleTableAdapter.FillByLandID(PeopleLandSolveDataSet.qryDocPeople, Val(txtLandID.Text))
        QryDocPeopleTableAdapter.Connection.Close()
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        intIndex = e.RowIndex
        DataGridView1.Rows(intIndex).Selected = True
        txtLandID.Text = DataGridView1.Rows(intIndex).Cells(0).Value

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim sqlstr As String
        Dim intIndex As Integer
        Dim t As New Land
        If e.RowIndex < 0 Then
            Exit Sub
        End If
        intIndex = e.RowIndex
        DataGridView2.Rows(intIndex).Selected = True
        txtDocID.Text = DataGridView2.Rows(intIndex).Cells(0).Value
        Try
            t.DBCon()
            sqlstr = "Select * from tblDocPeople Where DocPeopleID=" & txtDocID.Text
            da = New SqlDataAdapter(sqlstr, t.cnn)
            t.cnn.Open()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cboPeopleDoc.SelectedValue = dt(0)("DocPeopleName")
                txtPeopleDocNum.Text = dt(0)("DocPeopleNum")
                txtPeopleYearDoc.Text = dt(0)("YearPeopleDoc")
                cboOfficerName.SelectedValue = dt(0)("DocOfficerName")
            End If
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim sqlcom As SqlCommand
        Dim sqlstr As String
        Dim t As New Land
        t.DBCon()
        Try
            sqlstr = "UPDATE tblDocPeople SET DocPeopleName=@DocPeopleName,DocPeopleNum=@DocPeopleNum," & _
                "YearPeopleDoc=@YearPeopleDoc,DocOfficerName=@DocOfficerName Where DocPeopleID=" & txtDocID.Text
            sqlcom = New SqlCommand(sqlstr, t.cnn)
            t.cnn.Open()
            sqlcom.Parameters.AddWithValue("@DocPeopleName", cboPeopleDoc.SelectedValue)
            sqlcom.Parameters.AddWithValue("@DocPeopleNum", txtPeopleDocNum.Text)
            sqlcom.Parameters.AddWithValue("@YearPeopleDoc", txtPeopleYearDoc.Text)
            sqlcom.Parameters.AddWithValue("@DocOfficerName", cboOfficerName.SelectedValue)
            sqlcom.ExecuteNonQuery()
            MsgBox("ព័ត៌មានអំពីឯកសារកាន់កាប់ដីធ្លីរបស់ម្ចាស់បណ្តឹងត្រូវបានក្រែប្រែរួច")
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class