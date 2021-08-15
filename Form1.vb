Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim scrp As New Scraper()
        scrp.Scrape()
    End Sub
End Class
