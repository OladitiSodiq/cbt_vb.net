Public Class Home

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Dialog1.Show()
        ElseIf RadioButton2.Checked = True Then
            LoginResult.Show()
        Else
            MsgBox("Please Select Your Preferd Option", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        End If
    End Sub
End Class