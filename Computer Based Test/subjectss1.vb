Imports System.Windows.Forms

Public Class subjectss1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim eng, mat, com, yor, phy, chem, ags, comm, acc, gov, bio, irs, crs, lie, eco, geo, fm, ce As String



        eng = ra1.Checked
        mat = ra2.Checked
        com = ra3.Checked
        yor = ra4.Checked
        phy = ra5.Checked
        chem = ra6.Checked
        ags = ra7.Checked
        comm = ra8.Checked
        acc = ra9.Checked
        gov = ra10.Checked
        bio = ra11.Checked
        irs = ra12.Checked
        crs = ra13.Checked
        lie = ra14.Checked
        eco = ra15.Checked
        geo = ra16.Checked
        fm = ra17.Checked
        ce = ra18.Checked

        If eng = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            AboutBox1.Show()

            Me.Hide()
        ElseIf mat = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("select the correct subject")

        End If

















    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click





    End Sub
End Class
