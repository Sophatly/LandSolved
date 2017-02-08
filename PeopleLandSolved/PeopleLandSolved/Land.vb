Imports System.Data.SqlClient
Public Class Land
    Public cnn As New SqlConnection
    Public cnnstr As String
    Public Shared GetUserName As String
    Public Shared GetUserPassword As String
    Public Function LandUserPassword(UserName As String, UserPassword As String)
        GetUserName = UserName
        GetUserPassword = UserPassword
        Return 0
    End Function
    Public Function DBCon()
        Dim a As String
        Dim b As String
        a = "sa"
        b = "092737375lsp"
        If GetUserName = String.Empty Then
            GetUserName = a
        End If
        If GetUserPassword = String.Empty Then
            GetUserPassword = b
        End If
        cnnstr = "Data Source=SP-PC;Initial Catalog=PeopleLandSolve;User ID='" & GetUserName & "';Password='" & GetUserPassword & "'"
        cnn.ConnectionString = cnnstr
        Return 0
    End Function
    Public Function LoadProvince(Province As ComboBox)
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        DBCon()
        Try
            sqlstr = "Select * from tblProvince Where ProvinceID=17"
            da = New SqlDataAdapter(sqlstr, cnn)
            cnn.Open()
            da.Fill(dt)
            Province.DataSource = dt
            Province.DisplayMember = "ProvinceName"
            Province.ValueMember = "ProvinceID"
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
        End Try
        Return 0
    End Function
    Public Function LoadDistrict(District As ComboBox)
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        DBCon()
        Try
            sqlstr = "Select * from tblDistrict Where ProvinceID=17 and DistrictID In(1709,1710,1702)"
            da = New SqlDataAdapter(sqlstr, cnn)
            cnn.Open()
            da.Fill(dt)
            District.DataSource = dt
            District.DisplayMember = "DistrictName"
            District.ValueMember = "DistrictID"
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
        End Try
        Return 0
    End Function
    Public Function LoadCommune(Commune As ComboBox)
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        DBCon()
        Try
            sqlstr = "Select * from tblCommune Where DistrictID=1710 and CommuneID In(171001,171005,171011)"
            da = New SqlDataAdapter(sqlstr, cnn)
            cnn.Open()
            da.Fill(dt)
            Commune.DataSource = dt
            Commune.DisplayMember = "CommuneName"
            Commune.ValueMember = "CommuneID"
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
        End Try
        Return 0
    End Function
    Public Function LoadEvalucation(Evaluation As ComboBox)
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        DBCon()
        Try
            sqlstr = "Select * from tblEvaluation"
            da = New SqlDataAdapter(sqlstr, cnn)
            cnn.Open()
            da.Fill(dt)
            Evaluation.DataSource = dt
            Evaluation.DisplayMember = "EvaluationName"
            Evaluation.ValueMember = "EvaluationID"
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
        End Try
        Return 0
    End Function
    Public Function LoadSuggestion(Suggestion As ComboBox)
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        DBCon()
        Try
            sqlstr = "Select * from tblSuggestion"
            da = New SqlDataAdapter(sqlstr, cnn)
            cnn.Open()
            da.Fill(dt)
            Suggestion.DataSource = dt
            Suggestion.DisplayMember = "SuggestionName"
            Suggestion.ValueMember = "SuggestionID"
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
        End Try
        Return 0
    End Function
    Public Function LoadPeopleName(PeopleName As ComboBox)
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Try
            DBCon()
            sqlstr = "Select PeopleID,PeopleName from tblPeople"
            da = New SqlDataAdapter(sqlstr, cnn)
            cnn.Open()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                PeopleName.DataSource = dt
                PeopleName.DisplayMember = "PeopleName"
                PeopleName.ValueMember = "PeopleID"
            End If
            PeopleName.AutoCompleteMode = AutoCompleteMode.Suggest
            PeopleName.AutoCompleteSource = AutoCompleteSource.ListItems
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function
    Public Function LoadVillage(Village As ComboBox)
        Dim sqlstr As String
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        DBCon()
        Try
            sqlstr = "Select * from tblVillage Where CommuneID In(171001,171005,171011)"
            da = New SqlDataAdapter(sqlstr, cnn)
            cnn.Open()
            da.Fill(dt)
            Village.DataSource = dt
            Village.DisplayMember = "VillageName"
            Village.ValueMember = "VillageID"
            cnn.Close()
        Catch ex As Exception
            cnn.Close()
        End Try
        Return 0
    End Function
End Class
