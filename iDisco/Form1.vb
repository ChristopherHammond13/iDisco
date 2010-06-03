Imports IWshRuntimeLibrary
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim RandomClass As New Random()
        Dim FirstNo As String
        Dim SecondNo As String
        Dim ThirdNo As String
        Dim noOfNumbers As Integer = Convert.ToInt32(TextBox1.Text)
        Dim loopNumbers = 0
        Do Until loopNumbers = noOfNumbers
            FirstNo = RandomClass.Next(1, 128).ToString()
            SecondNo = RandomClass.Next(1, 128).ToString()
            ThirdNo = RandomClass.Next(1, 128).ToString()
            Dim wshThisShell As WshShell
            Dim lngRet As Long
            Dim strShellCommand As String
            Dim strBatchPath As String
            wshThisShell = New WshShell
            strBatchPath = "random.bat"
            'the path for the batch file you're using
            strShellCommand = strBatchPath + " " + FirstNo + " " + SecondNo + " " + ThirdNo
            lngRet = wshThisShell.Run(strShellCommand, vbHide, vbTrue)
            loopNumbers += 1
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim wshThisShell As WshShell
        Dim lngRet As Long
        Dim strBatchPath As String
        wshThisShell = New WshShell
        strBatchPath = "enterrecovery.bat"
        lngRet = wshThisShell.Run(strBatchPath, vbHide, vbTrue)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RandomClass2 As New Random()
        Dim RandomBG As Integer = RandomClass2.Next(1, 5)
        Select Case RandomBG
            Case 1
                Me.BackColor = Color.Blue
            Case 2
                Me.BackColor = Color.Red
            Case 3
                Me.BackColor = Color.DarkSalmon
            Case 4
                Me.BackColor = Color.SkyBlue
            Case 5
                Me.BackColor = Color.Purple
            Case Else
                Me.BackColor = Color.DarkGray
        End Select
        MsgBox("Warning! blackthund3r will not take any responsibility for any harm or damage caused to you or your device. If you suffer from epilepsy or ay other kind of sensitivity to strobe lighting, do not use this application!", vbInformation + vbApplicationModal, "Disclaimer! Please Read!")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim wshThisShellexit As WshShell
        Dim lngRetexit As Long
        Dim strBatchPathexit As String
        wshThisShellexit = New WshShell
        strBatchPathexit = "Exit.bat"
        lngRetexit = wshThisShellexit.Run(strBatchPathexit, vbHide, vbTrue)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
