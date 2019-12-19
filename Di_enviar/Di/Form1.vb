Imports System.IO


Public Class Form1
    Dim imagen As String
    Dim con As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And imagen <> "" Then

            Dim escribir As New StreamWriter("D:\KEVIN\VISIO I\diccionario.txt", True)
            escribir.WriteLine("PALABRA:" & vbTab & vbTab & vbTab & TextBox1.Text)
            escribir.Close()
            Dim esc As New StreamWriter("D:\KEVIN\VISIO I\diccionario.txt", True)

            esc.WriteLine("SIGNIFICADO: " & vbTab & vbTab & TextBox2.Text)

            esc.Close()
            Dim ima As New StreamWriter("D:\KEVIN\VISIO I\diccionario.txt", True)

            ima.WriteLine(imagen)

            ima.Close()
            Dim tod As New StreamWriter("D:\KEVIN\VISIO I\diccionario.txt", True)

            tod.WriteLine(con & "+" & TextBox1.Text & "+" & TextBox2.Text & "+" & imagen)

            tod.Close()

            Button3.Enabled = True
            TextBox1.Text = ""
            TextBox2.Text = ""
            con = con + 1
        Else
            MsgBox("ES NECESARIO LLENAR CADA ASPECTO")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form1.ActiveForm.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.InitialDirectory = "D:\KEVIN\VISIO I"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            imagen = OpenFileDialog1.FileName
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub
End Class
