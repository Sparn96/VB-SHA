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

    Public Function HASHthis(ByVal pass As String, Optional ByVal salt As String = "")

        Dim mySHA As SHA256 = SHA256.Create()
        Dim hashValue As Byte

        hashValue = mySHA.ComputeHash(pass)  'THIS IS NOT GOING TO WORK

        Dim Result As String

        Result = salt + pass

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
            GlobalVariables.hash_f = HASHthis(PASS_tb.Text, GlobalVariables.SALT_G)
            Result_tb.Text = GlobalVariables.hash_f

        End Sub

        Private Sub PASS_tb_TextChanged(sender As Object, e As EventArgs) Handles PASS_tb.TextChanged

        End Sub

        Private Sub Result_tb_TextChanged(sender As Object, e As EventArgs) Handles Result_tb.TextChanged

        End Sub

        Private Sub CopyToClip_Click(sender As Object, e As EventArgs) Handles CopyToClip.Click
            My.Computer.Clipboard.SetText(Result_tb.Text)
        End Sub
    End Class
