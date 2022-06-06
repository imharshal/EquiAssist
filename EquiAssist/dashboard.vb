Public Class dashboard


 
    Private Sub btnDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoctor.Click
        pnlDoctor.Visible = True
        pnlGridview.Visible = False
        pnlPatient.Visible = False
    End Sub

    Private Sub btnPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPatient.Click
        pnlDoctor.Visible = False
        pnlGridview.Visible = False
        pnlPatient.Visible = True

    End Sub

    Private Sub btnGridview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGridview.Click
        pnlDoctor.Visible = False
        pnlGridview.Visible = True
        pnlPatient.Visible = False
    End Sub
End Class