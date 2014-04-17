Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ProgressBar1.Maximum = 100
        'Set the initial value of the progress bar to 0% completed
        ProgressBar1.Value = 0
        'If your progress bar is already visible you don't need this. But this is one of those objects I like to hide when I'm not using it
        ProgressBar1.Visible = True
        'This next line tells your application to wait or go to sleep for 1000ms / 1 second
        System.Threading.Thread.Sleep(1000)
        'Update the progress bar to 15% completed
        ProgressBar1.Value = 15
        'Wait for another second
        System.Threading.Thread.Sleep(1000)
        'Update to 30% complete
        ProgressBar1.Value = 30
        System.Threading.Thread.Sleep(1000)
        ProgressBar1.Value = 45
        System.Threading.Thread.Sleep(1000)
        ProgressBar1.Value = 60
        System.Threading.Thread.Sleep(1000)
        ProgressBar1.Value = 75
        System.Threading.Thread.Sleep(1000)
        ProgressBar1.Value = 90
        System.Threading.Thread.Sleep(3000)
        ProgressBar1.Value = 100
        If My.Computer.FileSystem.FileExists("C:\Program Files\Sims\FMSSQL\finance.exe") Then
            Process.Start("C:\Program Files\Sims\FMSSQL\finance.exe")
            'Process.Start("C:\Program Files (x86)\SIMS\Finance\Finance.exe")
            Me.Close()
        Else : MsgBox("FMS is not installed / 64bit system??")
            Me.Close()
        End If
        'MsgBox("Complete!")
        ProgressBar1.Visible = False
        '   System.Threading.Thread.Sleep(10000)


    End Sub
End Class
