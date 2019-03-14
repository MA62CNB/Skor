Public Class Form1
    Const BJK As Double = 0.6
    Const GS As Double = 0.57
    Const FB As Double = 0.48

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rand(2) As Integer
        Dim j, home, away As Double
        Dim random As New Random
        For j = 0 To 2
            rand(j) = random.Next(1, 99)
        Next
        If ComboBox1.SelectedItem = "Beşiktaş" Then
            home = rand(1) * BJK / 100
            If ComboBox2.SelectedItem = "Fenerbahçe" Then
                away = rand(2) * FB / 100
            Else
                away = rand(2) * GS / 100
            End If
        ElseIf ComboBox1.SelectedItem = "Fenerbahçe" Then
            home = rand(1) * FB / 100
            If ComboBox2.SelectedItem = "Galatasaray" Then
                away = rand(2) * GS / 100
            Else
                away = rand(2) * BJK / 100
            End If
        ElseIf ComboBox1.SelectedItem = "Galatasaray" Then
            home = rand(1) * GS / 100
            If ComboBox2.SelectedItem = "Beşiktaş" Then
                away = rand(2) * BJK / 100
            Else
                away = rand(2) * FB / 100
            End If
        End If
        If home > away Then
            Label3.Text = 1
        Else
            Label4.Text = 1
        End If
    End Sub
End Class
