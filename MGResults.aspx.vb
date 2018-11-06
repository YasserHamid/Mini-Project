Imports System.Data.SqlClient

Public Class WebForm15
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim constr As String = ConfigurationManager.ConnectionStrings("myCS").ConnectionString
            Using con As New SqlConnection(constr)
                Using cmd3 As New SqlCommand("SELECT Name FROM Venues WHERE mID=" & Integer.Parse(Session("MGID")))
                    cmd3.CommandType = CommandType.Text
                    cmd3.Connection = con
                    con.Open()
                    ddv.DataSource = cmd3.ExecuteReader()
                    ddv.DataTextField = "Name"
                    ddv.DataValueField = "Name"
                    ddv.DataBind()
                    con.Close()

                End Using
            End Using

            ddv.Items.Insert(0, New ListItem("--Select Venue--", "0"))
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection

        Dim cmd As String
        Dim dsql As SqlDataAdapter
        Dim dz As DataSet
        'Dim ven = ddv.SelectedItem.Text


        Dim texter As String = ""

        connection = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        connection.Open()

        cmd = "SELECT * FROM [1v1Booking] WHERE Venue='" & ddv.SelectedItem.Text & "' AND Complete=0"
        dsql = New SqlDataAdapter(cmd, connection)

        dz = New DataSet()
        dsql.Fill(dz)

        GridView1.DataSource = dz
        GridView1.DataBind()

        Dim constr As String = ConfigurationManager.ConnectionStrings("myCS").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd3 As New SqlCommand("SELECT BookingID FROM [1v1Booking] WHERE Complete = 0")
                cmd3.CommandType = CommandType.Text
                cmd3.Connection = con
                con.Open()
                ddl.DataSource = cmd3.ExecuteReader()
                ddl.DataTextField = "BookingID"
                ddl.DataValueField = "BookingID"
                ddl.DataBind()
                con.Close()

            End Using
        End Using

        ddl.Items.Insert(0, New ListItem("--Select BookingID--", "0"))

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim reader As SqlDataReader


        Dim cmd As String = "SELECT pUsername1, pUsername2 FROM [1v1Booking] WHERE BookingID=" & ddl.SelectedItem.Text

        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        sqlcmd = New SqlCommand(cmd, con)

        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection.Open()
        sqlcmd.ExecuteNonQuery()

        reader = sqlcmd.ExecuteReader
        reader.Read()

        Label1.Text = reader("pUsername1")
        Label2.Text = reader("pUsername2")


        reader.Close()
        con.Close()
        con.Dispose()

        sqlcmd.Connection.Close()
        sqlcmd.Connection.Dispose()
        sqlcmd.Dispose()
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim cmd As String
        Dim dt As DateTime = DateTime.Now
        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        Dim def As Integer = 0
        Dim p1 As Integer = Convert.ToInt32(TextBox1.Text)
        Dim p2 As Integer = Convert.ToInt32(TextBox2.Text)

        cmd = "Insert INTO [1v1Result] VALUES (@1v1ResultID ,@pUsername1, @pUsername2, @Date, @Player1Score, @Player2Score)"


        sqlcmd = New SqlCommand(cmd, con)
        sqlcmd.CommandType = CommandType.Text
        con.Open()
        sqlcmd.Parameters.AddWithValue("@1v1ResultID", ddl.SelectedItem.Text)
        sqlcmd.Parameters.AddWithValue("@pUsername1", Label1.Text)
        sqlcmd.Parameters.AddWithValue("@pUsername2", Label2.Text)
        sqlcmd.Parameters.AddWithValue("@Date", dt)
        sqlcmd.Parameters.AddWithValue("@Player1Score", p1)
        sqlcmd.Parameters.AddWithValue("@Player2Score", p2)




        sqlcmd.ExecuteNonQuery()
        con.Close()
        sqlcmd.Dispose()

        playerDets()


        Server.Transfer("~/MGResults.aspx")


    End Sub


    Protected Sub playerDets()
        Dim con2 As SqlConnection
        Dim sqlcmd2 As SqlCommand




        Dim cmd2 As String = "UPDATE [1v1Booking] SET [Complete]=1 WHERE BookingID=" & ddl.SelectedItem.Text

        con2 = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)
        sqlcmd2 = New SqlCommand(cmd2, con2)
        Try
            sqlcmd2.Connection.Open()
            sqlcmd2.ExecuteNonQuery()
            sqlcmd2.Connection.Close()
            sqlcmd2.Connection.Dispose()
            con2.Close()
            con2.Dispose()

        Catch ex As Exception
            Label3.Text = "Failed"
        End Try



    End Sub

End Class