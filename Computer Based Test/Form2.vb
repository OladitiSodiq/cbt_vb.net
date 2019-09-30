Public Class Form2

    Private Sub SSS1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim lbl1, lbl3, lbl4, lbl5, lbl6, lbl8, lbl9, lbl10, lbl11, lbl13, lbl14, lbl16, lbl18, lbl19, lbl20, lbl22, lbl23, lbl24, lbl26, lbl27, lbl28, lbl29, lbl31, lbl32, lbl33, lbl34, lbl35, lbl37, lbl39, lbl40, lbl42, lbl43, lbl44, lbl45, lbl46, lbl48, lbl49, lbl50, lbl52, lbl53, lbl54, lbl55, lbl57, lbl58, lbl60 As String


        lbl1 = radiobu1.Checked

        lbl3 = radiobu3.Checked
        lbl4 = radiobu4.Checked
        lbl5 = radiobu5.Checked
        lbl6 = radiobu6.Checked
        lbl8 = radiobu8.Checked
        lbl9 = radiobu9.Checked
        lbl10 = radiobu10.Checked
        lbl11 = radiobu11.Checked

        lbl13 = radiobu13.Checked
        lbl14 = radiobu14.Checked

        lbl16 = radiobu16.Checked

        lbl18 = radiobu18.Checked
        lbl19 = radiobu19.Checked
        lbl20 = radiobu20.Checked

        lbl22 = radiobu22.Checked
        lbl23 = radiobu23.Checked
        lbl24 = radiobu24.Checked

        lbl26 = radiobu26.Checked
        lbl27 = radiobu27.Checked
        lbl28 = radiobu28.Checked
        lbl29 = radiobu29.Checked

        lbl31 = radiobu31.Checked
        lbl32 = radiobu32.Checked
        lbl33 = radiobu33.Checked
        lbl34 = radiobu34.Checked
        lbl35 = radiobu35.Checked

        lbl37 = radiobu37.Checked

        lbl39 = radiobu39.Checked
        lbl40 = radiobu40.Checked

        lbl42 = radiobu42.Checked
        lbl43 = radiobu43.Checked
        lbl44 = radiobu44.Checked
        lbl45 = radiobu45.Checked
        lbl46 = radiobu46.Checked

        lbl48 = radiobu48.Checked
        lbl49 = radiobu49.Checked
        lbl50 = radiobu50.Checked

        lbl52 = radiobu52.Checked
        lbl53 = radiobu53.Checked
        lbl54 = radiobu54.Checked
        lbl55 = radiobu55.Checked

        lbl57 = radiobu57.Checked
        lbl58 = radiobu58.Checked

        lbl60 = radiobu60.Checked



        Dim lblsurn, lblfirst, lbllast, lblclass As String

        lblsurn = txts.Text
        lblfirst = txtf.Text
        lbllast = txtl.Text
        lblclass = txtclass.Text


        If lblsurn = "" Or lblfirst = "" Or lbllast = "" Or lblclass = "" Then
            MsgBox("Please fill ur information ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        Else
            Dim lbl2 As String
            lbl2 = radiobu2.Checked

            If lbl2 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            Dim lbl7 As String
            lbl7 = radiobu7.Checked
            If lbl7 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If

            Dim lbl12 As String
            lbl12 = radiobu12.Checked

            If lbl12 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            Dim lbl15 As String
            lbl15 = radiobu15.Checked
            If lbl15 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            Dim lbl17 As String
            lbl17 = radiobu17.Checked

            If lbl17 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            Dim lbl21 As String
            lbl21 = radiobu21.Checked
            If lbl21 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If

            Dim lbl25 As String
            lbl25 = radiobu25.Checked

            If lbl25 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            Dim lbl30 As String
            lbl30 = radiobu30.Checked
            If lbl30 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If

            Dim lbl36 As String
            lbl36 = radiobu36.Checked

            If lbl36 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            Dim lbl38 As String
            lbl38 = radiobu38.Checked
            If lbl38 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If

            Dim lbl41 As String
            lbl41 = radiobu41.Checked
            If lbl41 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If

            Dim lbl47 As String
            lbl47 = radiobu47.Checked

            If lbl47 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If
            Dim lbl51 As String
            lbl51 = radiobu51.Checked
            If lbl51 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If

            Dim lbl56 As String
            lbl56 = radiobu56.Checked
            If lbl56 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If

            Dim lbl59 As String
            lbl59 = radiobu59.Checked
            If lbl59 = True Then
                Score.lblright.Text = Score.lblright.Text + 1
            Else
                Score.lblwrong.Text = Score.lblwrong.Text - 1
            End If


            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source=|DataDirectory|\SS1Math.accdb")
            Dim com As New System.Data.OleDb.OleDbCommand("insert into SS1Mathematics  values ('" + lblsurn + "','" + lblfirst + "','" + lbllast + "','" + lblclass + "','" + Score.lblright.Text + "','" + Score.lblwrong.Text + "')", con)
            Try

                Dim rs As New DialogResult
                rs = MsgBox("Are you true with ur question", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                If Convert.ToBoolean(rs.ToString() = "Yes") Then
                    con.Open()
                    com.ExecuteNonQuery()
                    MsgBox("suseccfllly")
                    con.Close()
                    txts.Clear()
                    txtl.Clear()
                    txtf.Clear()
                    radiobu1.Checked = False
                    radiobu2.Checked = False
                    radiobu3.Checked = False
                    radiobu4.Checked = False
                    radiobu5.Checked = False
                    radiobu6.Checked = False
                    radiobu7.Checked = False
                    radiobu8.Checked = False
                    radiobu9.Checked = False
                    radiobu10.Checked = False
                    radiobu11.Checked = False
                    radiobu12.Checked = False
                    radiobu13.Checked = False
                    radiobu14.Checked = False
                    radiobu15.Checked = False
                    radiobu16.Checked = False
                    radiobu17.Checked = False
                    radiobu18.Checked = False
                    radiobu19.Checked = False
                    radiobu20.Checked = False
                    radiobu21.Checked = False
                    radiobu22.Checked = False
                    radiobu23.Checked = False
                    radiobu24.Checked = False
                    radiobu25.Checked = False
                    radiobu26.Checked = False

                    radiobu27.Checked = False
                    radiobu28.Checked = False
                    radiobu29.Checked = False
                    radiobu30.Checked = False
                    radiobu31.Checked = False
                    radiobu32.Checked = False
                    radiobu33.Checked = False
                    radiobu34.Checked = False
                    radiobu35.Checked = False
                    radiobu36.Checked = False
                    radiobu38.Checked = False
                    radiobu39.Checked = False
                    radiobu40.Checked = False
                    radiobu41.Checked = False
                    radiobu42.Checked = False
                    radiobu43.Checked = False
                    radiobu44.Checked = False
                    radiobu45.Checked = False
                    radiobu46.Checked = False
                    radiobu47.Checked = False
                    radiobu48.Checked = False
                    radiobu49.Checked = False
                    radiobu50.Checked = False
                    radiobu51.Checked = False
                    radiobu52.Checked = False
                    radiobu53.Checked = False
                    radiobu54.Checked = False
                    radiobu55.Checked = False
                    radiobu56.Checked = False
                    radiobu57.Checked = False
                    radiobu58.Checked = False
                    radiobu59.Checked = False
                    radiobu60.Checked = False

                Else

                    MsgBox("not sucessfull")
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try
        End If
        Dim Form2 As New Score
        Score.Show()





    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub radiobu54_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radiobu54.CheckedChanged

    End Sub
End Class