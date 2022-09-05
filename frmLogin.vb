
Public Class frmLogin
    'Declares number of tries as 0
    Dim Tries As Integer = 0
    'Sub-routine that validates username and password
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        'Selection mechanism that validates username and password
        If txtUserName.Text = "Secretary Maal" And txtPassword.Text = "12345678" Then
            'Sets globalvariable depending on the user that logs in, closes login form and shows the main menu.
            GlobalVariables.AccessLevel = "2"
            GlobalVariables.LoggedUser = "Secretary Maal"
            frmMainMenu.Show()
            Me.Close()
        ElseIf txtUserName.Text = "Missionary" And txtPassword.Text = "12345678" Then
            'Sets globalvariable depending on the user that logs in, closes login form and shows the main menu.
            GlobalVariables.AccessLevel = "2"
            GlobalVariables.LoggedUser = "Missionary"
            frmMainMenu.Show()
            Me.Close()
        ElseIf txtUserName.Text = "Volunteer" And txtPassword.Text = "12345678" Then
            'Sets globalvariable depending on the user that logs in, closes login form and shows the main menu.
            GlobalVariables.AccessLevel = "1"
            GlobalVariables.LoggedUser = "Volunteer"
            frmMainMenu.Show()
            Me.Close()
        Else
            'If incorrect username or password is input, then increase the no. of tries by one and reset username and password fields.
            Tries = Tries + 1
            txtUserName.Text = ""
            txtPassword.Text = ""
        End If
        'Sets text to show no. of tries left.
        txtIncorrect.Text = "Incorrect Username or Password. You have " & 3 - Tries & " tries left."
        'Shuts down program if tries are more than 3.
        If Tries = 3 Then
            MsgBox("Incorect password entered. Application quiting...", MsgBoxStyle.OkOnly)
            Me.Close()
        End If
    End Sub

    'Closes form if the custom close button is pressed.
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Close()
    End Sub
    'Closes form if cancel button is pressed.
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
        Close()
    End Sub
End Class
