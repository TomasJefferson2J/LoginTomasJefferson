Imports System.ComponentModel.DataAnnotations

Public Class Form1
    Private Sub Buttoningresar_Click(sender As Object, e As EventArgs) Handles Buttoningresar.Click
        Dim email As String

        Dim contraseña As String

        email = Textemail.Text

        contraseña = Textcontrsaeña.Text
        If (email = "dd") And (contraseña = "111") Then

            MsgBox("Bienvenido")

            Close()



        Else
            MsgBox("email o contraseña incorrecta")




        End If


        Textemail.Text = ""

        Textcontrsaeña.Text = ""




    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Textcontrsaeña.UseSystemPasswordChar = False
        Else
            Textcontrsaeña.UseSystemPasswordChar = True
        End If

    End Sub
End Class
