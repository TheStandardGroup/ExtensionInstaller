Public Class frmMain
    Dim dllName As String = ""
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BackColor = Color.FromArgb(28, 63, 119)
        btnAdd.BackColor = Color.FromArgb(231, 185, 1)
        btnQuit.BackColor = Color.FromArgb(231, 185, 1)
        Try
            Dim sr = New System.IO.StreamReader("DeployLoc.res")
            Dim line As String = sr.ReadLine()
            dllName = sr.ReadLine()
            sr.Close()
            Dim dirs() As String = System.IO.Directory.GetDirectories(line)
            'Dim dirs() As String = System.IO.Directory.GetDirectories("D:\Pageflex\Deployments")
            For Each adir In dirs
                chlbDeploys.Items.Add(adir)
            Next
        Catch ex As Exception
            MessageBox.Show("Error Reading the path", "Error")
        End Try
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Dispose()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim count = chlbDeploys.Items.Count
        Dim idx = 0
        Dim installList = New ArrayList
        While idx < count
            If (chlbDeploys.GetItemChecked(idx)) Then
                installList.Add(chlbDeploys.Text)
            End If
            idx += 1
        End While
        Dim failed As Boolean = False
        If (installList.Count <= 0) Then
            MessageBox.Show("Select the deployment to install", "Error")
            failed = True
        End If
        
        If Not failed Then
            Dim srcPath = System.IO.Directory.GetCurrentDirectory & "\installFiles\" & dllName
            
            Dim file = New System.IO.FileInfo(srcPath)
            For Each itm In installList
                Dim destPath As String = itm + "\WebPages\bin\Services"
                file.CopyTo(System.IO.Path.Combine(destPath, file.Name), True)
            Next
        End If
    End Sub

End Class
