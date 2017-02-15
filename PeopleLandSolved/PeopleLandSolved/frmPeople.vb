Imports System.Data.SqlClient
Public Class frmPeople

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
        Dim frmC As New frmLandInfo
        frmC.MdiParent = Main
        frmC.WindowState = FormWindowState.Maximized
        frmC.cboPeopleName.SelectedValue = txtPeopleID.Text
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
        Dim j As Integer
        Try
            t.DBCon()
            sqlstr = "Select PeopleID from tblPeople"
            da = New SqlDataAdapter(sqlstr, t.cnn)
            t.cnn.Open()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtPeopleID.Text = dt(dt.Rows.Count - 1)("PeopleID") + 1
            End If
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
            txtPeopleID.Text = txtPeopleID.Text + 1
        End Try
    End Sub

    Private Sub frmPeople_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Land
        t.DBCon()
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryPeopleSearch' table. You can move, or remove it, as needed.
        QryPeopleTableAdapter.Connection.ConnectionString = t.cnnstr
        QryPeopleTableAdapter.Connection.Open()
        Me.QryPeopleTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryPeople)
        QryPeopleTableAdapter.Connection.Close()

        DataGridView1.Font = New Font("Khmer OS System", 9)
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        QryPeopleTableAdapter.FillByPeopleName(PeopleLandSolveDataSet.qryPeople, TextBox1.Text & "%")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim intIndex As Integer
        Dim i As Integer
        intIndex = e.RowIndex
        DataGridView1.Rows(intIndex).Selected = True
        i = DataGridView1.Rows(intIndex).Cells(0).Value
        txtPeopleID.Text = i

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim sqlcom As New SqlCommand
        Dim sqlstr As String
        Dim t As New Land
        Try
            t.DBCon()
            sqlstr = "UPDATE tblPeople SET PeopleName=@PeopleName Where PeopleID=" & txtPeopleID.Text
            sqlcom = New SqlCommand(sqlstr, t.cnn)
            t.cnn.Open()
            sqlcom.Parameters.AddWithValue("@PeopleName", txtPeopleName.Text)
            sqlcom.ExecuteNonQuery()
            MsgBox("ព័ត៌មានត្រូវបានកែប្រែរួចរាល់")
            t.cnn.Close()
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        Dim intIndex As Integer
        intIndex = e.RowIndex
        DataGridView1.Rows(intIndex).Selected = True
        i = DataGridView1.Rows(intIndex).Cells(0).Value
        txtPeopleID.Text = i

    End Sub
End Class