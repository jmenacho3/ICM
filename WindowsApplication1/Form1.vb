Public Class Form1

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        Dim IMC As Double
        Dim pesoKG As Double = txtpeso.Text
        Dim alturaMt As Double = txtalt.Text
        IMC = pesoKG / (alturaMt * alturaMt)

        If IMC >= 18.5 And IMC <= 24.9 Then
            lblmsg.Text = "Promedio"
        ElseIf IMC >= 25 And IMC <= 29.9 Then
            lblmsg.Text = "Aumentado"
        ElseIf IMC >= 30 And IMC <= 34.9 Then
            lblmsg.Text = "Moderado"
        ElseIf IMC >= 35 And IMC <= 39.9 Then
            lblmsg.Text = "Severo"
        ElseIf IMC >= 40 Then
            lblmsg.Text = "Muy Severo"
        End If
        lblres.Text = IMC
    End Sub
End Class
