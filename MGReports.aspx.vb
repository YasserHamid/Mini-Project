Imports System.Data.SqlClient
Imports System.Web.UI.DataVisualization.Charting

Public Class WebForm16
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim con As SqlConnection

        'Dim cmd As String
        'Dim da As SqlDataAdapter
        'Dim ds As DataSet


        'Dim texter As String = ""

        'con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        'con.Open()

        'cmd = "SELECT COUNT(BookingID)AS BookingsIn2018 FROM [1v1Booking] WHERE Start > 01/01/2018"
        'da = New SqlDataAdapter(cmd, con)

        'ds = New DataSet()
        'da.Fill(ds)

        'GridView1.DataSource = ds
        'GridView1.DataBind()

        'con.Close()

        loadResults()

        'loadBookings()
    End Sub

    Protected Sub loadResults()
        Dim con2 As SqlConnection

        Dim cmd2 As String
        Dim da2 As SqlDataAdapter
        Dim ds2 As DataSet


        Dim texter As String = ""

        con2 = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        con2.Open()

        cmd2 = "SELECT * FROM [1v1Result]"
        da2 = New SqlDataAdapter(cmd2, con2)

        ds2 = New DataSet()
        da2.Fill(ds2)

        GridView1.DataSource = ds2
        GridView1.DataBind()

        con2.Close()
    End Sub


    Protected Sub loadBookings()
        Dim con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)

        ' Dim conn As New SqlConnection(strConn)

        Dim sqlProducts As String = "SELECT Venue, COUNT(BookingID) AS nMatches FROM [1v1Booking] GROUP BY Venue"
        Dim da As New SqlDataAdapter(sqlProducts, con)
        Dim ds As New DataSet()
        da.Fill(ds, "[1v1Booking]")

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


        Chart1.Series("Series1").XValueMember = "Venue"
        Chart1.Series("Series1").AxisLabel = "Venue"
        Chart1.Series("Series1").YValueMembers = "nMatches"

        Chart1.DataSource = ds.Tables("1v1Booking")
    End Sub

End Class