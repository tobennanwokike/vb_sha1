Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim algohmacsha1 As New HMACSHA1(Encoding.ASCII.GetBytes(TextBox1.Text))
        Dim algohashValue As Byte() = algohmacsha1.ComputeHash(Encoding.ASCII.GetBytes(TextBox2.Text))
        TextBox3.Text = GetBytesToHexadeciString(algohashValue)
        algohmacsha1.Clear()
    End Sub

    Private Function GetBytesToHexadeciString(ByVal bytes As Byte()) As String
        Dim output As String = String.Empty
        Dim i As Integer = 0
        Do While i < bytes.Length
            output += bytes(i).ToString("X2")
            i += 1
        Loop
        Return output.ToLower
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
