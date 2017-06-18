Public Class Form1
    Private Sub Button1_Click() Handles Button1.Click
        Process.Start("D:\Steam\Steam.exe")
    End Sub

    Private Sub Button2_Click() Handles Button2.Click
        Process.Start("D:\Origin\Origin.exe")
    End Sub

    Private Sub Button3_Click() Handles Button3.Click
        Process.Start("D:\Battle.net\Battle.net Launcher.exe")
    End Sub

    Private Sub Button4_Click() Handles Button4.Click
        Process.Start("D:\Arc\Arc\ArcLauncher.exe")
    End Sub

    Private Sub Button5_Click() Handles Button5.Click
        Process.Start("D:\GameforgeLive\GameforgeLive.exe")
    End Sub

    Private Sub Button6_Click() Handles Button6.Click
        Process.Start("D:\Ubisoft Game Launcher\Uplay.exe")
    End Sub

    Private Sub Button7_Click() Handles Button7.Click
        Call Button1_Click()
        Call Button2_Click()
        Call Button3_Click()
        Call Button4_Click()
        Call Button5_Click()
        Call Button6_Click()
    End Sub

End Class
