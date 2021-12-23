Public Class Form1
    Dim pdf As String = ""
    Dim path As String = ""

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        'Machines()
        'populate()
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "MachineManuals_v2"
        ListBox1.Items.Add("Grob")
        ListBox1.Items.Add("Mazak VTC")
        ListBox1.Items.Add("Okuma OSP100")
        ListBox1.Items.Add("Okuma OSP200")
        ListBox1.Items.Add("Starrag")
        ListBox1.Items.Add("Heckert 400D")
        ListBox1.Items.Add("Heckert 500D")
        ListBox1.Items.Add("Heckert H65")
        ListBox1.Items.Add("Mazak Integrex")
    End Sub

    Sub Machines()
        Select Case ListBox1.SelectedItem.ToString()
            Case "Mazak VTC"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\Mazak"
            Case "Grob"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\Grob"
            Case "Okuma OSP100"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\OkumaOSP100"
            Case "Okuma OSP200"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\OkumaOSP200"
            Case "Mazak Integrex"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\Integrex"
            Case "Heckert 400D"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\Heckert400D"
            Case "Heckert H65"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\HeckertH65"
            Case "Starrag"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\Starrag"
            Case "Heckert 500D"
                path = "C:\Users\sjouke.vanalthuis\Documents\MachineManuals\Heckert500D"
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pdf = ListBox2.SelectedItem.ToString()
        'MsgBox("You have selected " + ListBox1.SelectedItem.ToString())
        Process.Start(path & "\" & pdf & ".pdf")
    End Sub

    Private Sub populate()
        Try
            ListBox2.Items.Clear()
            For Each str As String In My.Computer.FileSystem.GetFiles(path)
                Dim itemdir() As String
                itemdir = Split(str, "\")
                Dim arrayLengthdir As Integer = itemdir.Length - 1

                Dim itemfile() As String
                itemfile = Split(itemdir(arrayLengthdir), ".pdf")

                ListBox2.Items.Add(itemfile(0))

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        Machines()
        Populate()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
