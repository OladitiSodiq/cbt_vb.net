Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
       
        If sss1.Checked = True Then
            subjectss1.GroupBox1.Visible = True
        ElseIf sss2.Checked = True Then
            subjectss1.GroupBox2.Visible = True
        ElseIf sss3.Checked = True Then
            subjectss1.GroupBox3.Visible = True
        Else
            MsgBox("Select an option")

        End If
        Dim Form2 As New subjectss1
        subjectss1.Show()


    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
