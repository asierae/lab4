Imports System.Data.SqlClient
Imports accesoBD.GestBD

Public Class TareasProfesor1

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("username") = "vadillo@ehu.es" ''BORRAR!

    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("/InsertarTarea.aspx")
    End Sub
End Class