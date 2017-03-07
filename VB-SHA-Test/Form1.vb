Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Forms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If SHA_cb.Items.Count > 0 Then SHA_cb.SelectedIndex = 0




    End Sub

    Public Class GlobalVariables
        Public Shared SALT_G As String
        Public Shared hash_f As String
    End Class

    Public Function HASHthis256(ByVal pass As String, Optional ByVal salt As String = "")

        Dim mySHA As SHA256 = SHA256Managed.Create()
        Dim hashValue() As Byte
        Dim passAsByte As Byte()

        passAsByte = System.Text.Encoding.Unicode.GetBytes(pass + salt)

        Dim ms As New MemoryStream(passAsByte)

        hashValue = mySHA.ComputeHash(ms)

        Dim Result As String = ""

        For i = 0 To hashValue.Length - 1
            Result += String.Format("{0:X2}", hashValue(i))

        Next i

        Return Result

    End Function

    Public Function HASHthis512(ByVal pass As String, Optional ByVal salt As String = "")

        Dim mySHA As SHA512 = SHA512Managed.Create()
        Dim hashValue() As Byte
        Dim passAsByte As Byte()

        passAsByte = System.Text.Encoding.Unicode.GetBytes(pass + salt)

        Dim ms As New MemoryStream(passAsByte)

        hashValue = mySHA.ComputeHash(ms)

        Dim Result As String = ""

        For i = 0 To hashValue.Length - 1
            Result += String.Format("{0:X2}", hashValue(i))

        Next i

        Return Result

    End Function


    Private Sub SALT_tb_TextChanged(sender As Object, e As EventArgs) Handles SALT_tb.TextChanged

            GlobalVariables.SALT_G = SALT_tb.Text()

        End Sub

        Private Sub SHA_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SHA_cb.SelectedIndexChanged



            If SHA_cb.Text() = "SHA-256" Then
                SALT_tb.Enabled = False

            ElseIf SHA_cb.Text() = "SHA-512" Then
                SALT_tb.Enabled = False

            Else
                SALT_tb.Enabled = True
            End If

        End Sub

    Private Sub Convert_b_Click(sender As Object, e As EventArgs) Handles Convert_b.Click
        If SHA_cb.Text() = "SHA-512" Then

            GlobalVariables.hash_f = HASHthis512(PASS_tb.Text, GlobalVariables.SALT_G)
        Else
            GlobalVariables.hash_f = HASHthis256(PASS_tb.Text, GlobalVariables.SALT_G)
        End If

        Result_tb.Text = GlobalVariables.hash_f

    End Sub

    Private Sub PASS_tb_TextChanged(sender As Object, e As EventArgs) Handles PASS_tb.TextChanged

        End Sub

        Private Sub Result_tb_TextChanged(sender As Object, e As EventArgs) Handles Result_tb.TextChanged

        End Sub

        Private Sub CopyToClip_Click(sender As Object, e As EventArgs) Handles CopyToClip.Click
            My.Computer.Clipboard.SetText(Result_tb.Text)
        End Sub

    Private Sub toCompare_CheckedChanged(sender As Object, e As EventArgs) Handles toCompare.CheckedChanged

        If toCompare.Enabled = True Then Compare1.Text = Result_tb.Text
        If toCompare.Enabled = False Then Compare1.Text = ""


    End Sub

    Private Sub CompareButton_Click(sender As Object, e As EventArgs) Handles CompareButton.Click

        If Compare1.Text = Compare2.Text Then
            Compare1.BackColor = Color.Green
            Compare2.BackColor = Color.Green
        Else
            Compare1.BackColor = Color.White
            Compare2.BackColor = Color.White
        End If

    End Sub
End Class
