Imports System.Data.SqlClient
Public Class frmEditDocSolved

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub frmEditDocSolved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Land
        t.DBCon()
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryEditDocSolved' table. You can move, or remove it, as needed.
        QryEditDocSolvedTableAdapter.Connection.ConnectionString = t.cnnstr
        QryEditDocSolvedTableAdapter.Connection.Open()
        Me.QryEditDocSolvedTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryEditDocSolved)
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryPeopleSearch' table. You can move, or remove it, as needed.
        QryEditDocSolvedTableAdapter.Connection.Close()

        t.LoadPeopleName(cboPeopleName)
        t.LoadOfficerName(cboOfficerName)
        t.LoadDocument(cboPeopleDoc)

        QryPeopleSearchTableAdapter.Connection.ConnectionString = t.cnnstr
        QryPeopleSearchTableAdapter.Connection.Open()
        Me.QryPeopleSearchTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryPeopleSearch)
        QryPeopleSearchTableAdapter.Connection.Close()

        DataGridView1.Font = New Font("Khmer OS System", 9)
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        DataGridView2.Font = New Font("Khmer OS System", 9)
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub cboPeopleName_TextChanged(sender As Object, e As EventArgs) Handles cboPeopleName.TextChanged
        Dim t As New Land
        t.DBCon()
        QryPeopleSearchTableAdapter.Connection.ConnectionString = t.cnnstr
        QryPeopleSearchTableAdapter.Connection.Open()
        QryPeopleSearchTableAdapter.FillByPeopleName(PeopleLandSolveDataSet.qryPeopleSearch, cboPeopleName.Text & "%")
        QryPeopleSearchTableAdapter.Connection.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim intIndex As Integer
        Dim t As New Land
        intIndex = e.RowIndex
        DataGridView1.Rows(intIndex).Selected = True
        txtLandID.Text = DataGridView1.Rows(intIndex).Cells(0).Value

        Try
            t.DBCon()
            QryEditDocSolvedTableAdapter.Connection.ConnectionString = t.cnnstr
            QryEditDocSolvedTableAdapter.Connection.Open()
            QryEditDocSolvedTableAdapter.FillByDocID(PeopleLandSolveDataSet.qryEditDocSolved, txtLandID.Text)
            QryEditDocSolvedTableAdapter.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim t As New Land
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim sqlstr As String
        Dim intIndex As Integer
        intIndex = e.RowIndex
        If intIndex < 0 Then
            Exit Sub
        End If
        DataGridView2.Rows(e.RowIndex).Selected = True
        txtDocID.Text = DataGridView2.Rows(intIndex).Cells(0).Value
        t.DBCon()
        Try
            sqlstr = "Select * from tblDocument Where DocID=" & txtDocID.Text
            da = New SqlDataAdapter(sqlstr, t.cnn)
            t.cnn.Open()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cboPeopleDoc.SelectedValue = dt(0)("DocName")
                txtPeopleDocNum.Text = dt(0)("DocNum")
                txtPeopleYearDoc.Text = dt(0)("YearDoc")
                cboOfficerName.SelectedValue = dt(0)("OfficerName")
                txtIRCNum.Text = dt(0)("IRCNum")
            End If
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim t As New Land
        Dim sqlcom As New SqlCommand
        Dim sqlstr As String
        Try
            t.DBCon()
            sqlstr = "UPDATE tblDocument SET DocName=@DocName,DocNum=@DocNum,YearDoc=@YearDoc,OfficerName=@OfficerName," & _
                "IRCNum=@IRCNum Where DocID=" & txtDocID.Text
            sqlcom = New SqlCommand(sqlstr, t.cnn)
            t.cnn.Open()
            sqlcom.Parameters.AddWithValue("@DocName", cboPeopleDoc.SelectedValue)
            sqlcom.Parameters.AddWithValue("@DocNum", txtPeopleDocNum.Text)
            sqlcom.Parameters.AddWithValue("@YearDoc", txtPeopleYearDoc.Text)
            sqlcom.Parameters.AddWithValue("@OfficerName", cboOfficerName.SelectedValue)
            sqlcom.Parameters.AddWithValue("@IRCNum", txtIRCNum.Text)
            sqlcom.ExecuteNonQuery()
            MsgBox("ព័ត៌មានត្រូវបានក្រែប្រែរួលរាល់")
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class