Imports System.IO
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmPicPath

    Private Sub frmPicPath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New Land
        t.DBCon()
        QryPeopleSearchTableAdapter.Connection.ConnectionString = t.cnnstr
        QryPeopleSearchTableAdapter.Connection.Open()
        'TODO: This line of code loads data into the 'PeopleLandSolveDataSet.qryPeopleSearch' table. You can move, or remove it, as needed.
        Me.QryPeopleSearchTableAdapter.Fill(Me.PeopleLandSolveDataSet.qryPeopleSearch)
        QryPeopleSearchTableAdapter.Connection.Close()
        Dim Folder As New IO.DirectoryInfo(Application.StartupPath)
        For Each File As IO.FileInfo In Folder.GetFiles("*.jpg", IO.SearchOption.AllDirectories)
            ListBox1.Items.Add(File.FullName)
            Application.DoEvents()
        Next
        DataGridView1.Font = New Font("Khmer OS System", 9)
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        txtPicName.Visible = False
        ListBox1.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FullPath As String = String.Empty
        Try
            FullPath = Application.StartupPath & "\Solved\All\" & txtPicName.Text & "\" & txtPicName.Text & ".jpg"
            Process.Start(FullPath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim intIndex As Integer
        Dim str As String
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim sqlstr As String
        Dim i As Integer
        Dim t As New Land
        t.DBCon()
        intIndex = e.RowIndex
        DataGridView1.Rows(intIndex).Selected = True
        str = DataGridView1.Rows(intIndex).Cells(1).Value
        i = DataGridView1.Rows(intIndex).Cells(0).Value
        Try
            sqlstr = "select PicLand from tblland where landid=" & i
            da = New SqlDataAdapter(sqlstr, t.cnn)
            t.cnn.Open()
            da.Fill(dt)
            Dim img() As Byte
            img = dt(0)("PicLand")
            Dim ms As New MemoryStream(img)
            PictureBox1.Image = Image.FromStream(ms)
        Catch ex As Exception
            t.cnn.Close()
            MsgBox(ex.Message)
        End Try
        txtPicName.Text = str
    End Sub

    Private Sub txtPeopleName_TextChanged(sender As Object, e As EventArgs) Handles txtPeopleName.TextChanged
        QryPeopleSearchTableAdapter.FillByPeopleName(PeopleLandSolveDataSet.qryPeopleSearch, txtPeopleName.Text & "%")
    End Sub
End Class