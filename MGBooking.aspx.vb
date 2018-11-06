
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient


Public Class WebForm12
    Inherits System.Web.UI.Page




    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Me.Scheduler = New DHXScheduler()
        'Scheduler.InitialDate = New DateTime(2018, 1, 1)

        'Scheduler.Config.first_hour = 8
        'Scheduler.Config.last_hour = 18
        'Scheduler.Config.time_step = 15
        'Scheduler.Config.limit_time_select = True

        'Scheduler.DataAction = Me.ResolveUrl("~/Data.ashx")
        'Scheduler.SaveAction = Me.ResolveUrl("~/Save.ashx")
        'Scheduler.LoadData = True
        'Scheduler.EnableDataprocessor = True



        If Not Me.IsPostBack Then
            Dim constr As String = ConfigurationManager.ConnectionStrings("myCS").ConnectionString
            Using con As New SqlConnection(constr)
                Using cmd As New SqlCommand("SELECT pID, Username FROM Players")

                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    ddl.DataSource = cmd.ExecuteReader()
                    ddl.DataTextField = "Username"
                    ddl.DataValueField = "pID"
                    ddl.DataBind()

                    con.Close()




                End Using
            End Using

            Dim constr2 As String = ConfigurationManager.ConnectionStrings("myCS").ConnectionString
            Using con2 As New SqlConnection(constr)
                Using cmd2 As New SqlCommand("SELECT pID, Username FROM Players")
                    cmd2.CommandType = CommandType.Text
                    cmd2.Connection = con2
                    con2.Open()
                    ddl2.DataSource = cmd2.ExecuteReader()
                    ddl2.DataTextField = "Username"
                    ddl2.DataValueField = "pID"
                    ddl2.DataBind()
                    con2.Close()

                End Using
            End Using







            Using con As New SqlConnection(constr)
                Using cmd3 As New SqlCommand("SELECT Name FROM Venues WHERE mID =" & Integer.Parse(Session("MGID")))
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




            ddl.Items.Insert(0, New ListItem("--Select Player1--", "0"))
            ddl2.Items.Insert(0, New ListItem("--Select Player2--", "0"))
            ddv.Items.Insert(0, New ListItem("--Select Venue--", "0"))


        End If


        TextBox1.Text = "Kickoff @ "
        Label1.Text = ""
        If ddl.SelectedItem.Text = ddl2.SelectedItem.Text Then
            TextBox1.Text = "Error: "
            Label1.Text = " :( Cant select same user"
        End If


    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged


    End Sub

    Protected Sub Unnamed1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim day = Calendar1.SelectedDate

        'Dim dday = DateTime.Parse(TextBox1.Text.ToString())
        Dim dt As DateTime = DateTime.Now
        Dim dt2 As DateTime = dt.AddMinutes(15)
        Label1.Text = dt.ToString()

        Dim u1 As String = ddl.SelectedItem.ToString()

        Dim con As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim cmd As String
        Dim complete As String = 0
        con = New SqlConnection(ConfigurationManager.ConnectionStrings("myCS").ConnectionString)

        cmd = "Insert INTO [1v1Booking] VALUES (@Start, @End, @pUsername1, @pUsername2, @Venue, @Complete)"

        Try
            sqlcmd = New SqlCommand(cmd, con)
            sqlcmd.CommandType = CommandType.Text
            con.Open()

            sqlcmd.Parameters.AddWithValue("@Start", dt)
            sqlcmd.Parameters.AddWithValue("@End", dt2)
            sqlcmd.Parameters.AddWithValue("@pUsername1", ddl.SelectedItem.Text)
            sqlcmd.Parameters.AddWithValue("@pUsername2", ddl2.SelectedItem.Text)
            sqlcmd.Parameters.AddWithValue("@Venue", ddv.SelectedItem.Text)
            sqlcmd.Parameters.AddWithValue("@Complete", complete)

            sqlcmd.ExecuteNonQuery()
            con.Close()
            sqlcmd.Dispose()

            Server.Transfer("~/MGResults.aspx")

            Label1.Text = dt & " :D"
        Catch ex As Exception

        End Try

        'Label1.Text = u1



    End Sub


End Class