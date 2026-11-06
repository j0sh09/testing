Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            MsgBox("Access denied", MsgBoxStyle.Critical)
        Else
            MsgBox("Access deniedsssss", MsgBoxStyle.Critical)
        End If






    End Sub
End Class
