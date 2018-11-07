Imports System.Data.SqlClient
Imports System.Web.UI.DataVisualization.Charting

Public Class WebForm17
    Inherits System.Web.UI.Page


    Protected Sub Chart1_Load(sender As Object, e As EventArgs) Handles Chart1.Load

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim con As SqlConnection

        'Dim cmd As String
        'Dim da As SqlDataAdapter
        'Dim ds As DataSet


        'Dim texter As String = ""

        'con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        'con.Open()

        'cmd = "SELECT COUNT(pID)AS NumberOfPlayers FROM Players"
        'da = New SqlDataAdapter(cmd, con)

        'ds = New DataSet()
        'da.Fill(ds)

        'GridView1.DataSource = ds
        'GridView1.DataBind()

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)

        ' Dim conn As New SqlConnection(strConn)

        Dim sqlProducts As String = "SELECT COUNT(pID) AS TOTALPLAYERS FROM Players"
        Dim da As New SqlDataAdapter(sqlProducts, con)
        Dim ds As New DataSet()
        da.Fill(ds, "Players")

        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        Dim Chart1 = New Chart()
        Me.Controls.Add(Chart1)

        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)


        'Chart1.NamingContainer = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)


        Chart1.TabIndex = 0


        'Chart1.Series("Series1").XValueMember = "ProductName"
        Chart1.Series("Series1").AxisLabel = "nPlayers"
        Chart1.Series("Series1").YValueMembers = "TOTALPLAYERS"

        Chart1.DataSource = ds.Tables("Players")

    End Sub




End Class