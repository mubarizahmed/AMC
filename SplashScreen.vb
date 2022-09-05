Partial Class SplashScreen
    'Timer sub-routine that shows the splash screen for a set number of seconds
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        frmLogin.Show()
        Me.Close()
        Timer1.Stop()
    End Sub
End Class
