Public Class LOAD

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click

        Dim openfiledialog1 As New OpenFileDialog()
        openfiledialog1.DefaultExt = "|*rtf"
        openfiledialog1.Filter = "rtf files|*.rtf"
        ' Determine whether the user selected a file from the OpenFileDialog. 
        If (openfiledialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (openfiledialog1.FileName.Length > 0) Then
            ' Load the contents of the file into the RichTextBox.
            RichTextBox1.LoadFile(openfiledialog1.FileName)



        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim surname, firstname, lastname, classes, t As String
        Dim time As Integer
        surname = txtsurname.Text
        firstname = txtfirstname.Text
        lastname = txtlastname.Text
        classes = txtclasses.Text
        time = Duration.Text
        t = lbltime.Text
        If surname = "" Or firstname = "" Or lastname = "" Or classes = "" Then
            MsgBox("Please fill your informations ", MsgBoxStyle.Information)
        Else
            RichTextBox1.Visible = True
            Duration.Visible = True
            lbltime.Visible = True
        End If
        Duration.Text = 50
        Do Until (Duration.Text = 0)

        Loop
        Duration.Text = Date.Now.ToString("HH:MM:SS")
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click




        Dim surname, firstname, lastname, classes As String

        surname = txtsurname.Text
        firstname = txtfirstname.Text
        lastname = txtlastname.Text
        classes = txtclasses.Text

        If surname = "" Or firstname = "" Or lastname = "" Or classes = "" Then
            MsgBox("Please fill your informations ", MsgBoxStyle.Information)
        Else

            If radiobu1a.Checked = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            If radiobu2b.Checked = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            If radiobu3d.Checked = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            If radiobu31b.Checked = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If

            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source=|DataDirectory|\SS1Math.accdb")
            Dim com As New System.Data.OleDb.OleDbCommand("insert into SS1Mathematics  values ('" + surname + "','" + firstname + "','" + lastname + "','" + classes + "','" + Score.lblright.Text + "','" + Score.lblwrong.Text + "')", con)
            Try
                Dim rs As New DialogResult
                rs = MsgBox("Are you true with ur question", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If Convert.ToBoolean(rs.ToString() = "Yes") Then
                    con.Open()
                    com.ExecuteNonQuery()
                    MsgBox("suseccfllly")
                    con.Close()
                    Dim Form2 As New Score
                    Score.Show()
                Else
                    MsgBox("not sucessfull")
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End If


    End Sub

    Private Sub LOAD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class