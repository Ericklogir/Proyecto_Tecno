Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
'Inserción de librerías'

Public Class Administrador
    'Conexión nuevamente en Administrador'
    Dim con As New SqlConnection(My.Settings.Conexion)
    Dim sen, mensa As String

    'elaboración de un sub que se usará para ejecutar'
    Sub Ejecutar(ByVal sql As String, ByVal msg As String)
        'Try catch'
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click




    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Botón para cargar info'
    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click

        Dim da As New SqlDataAdapter("Select * from INGRESO", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)

    End Sub
    'Botón para actualizar datos'
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click

        sen = "Update INGRESO set Nombre = '" + txt_nombre.Text + "', Apellido = '" + txt_apellido.Text + "', Correo = '" + txt_correo.Text + "', Edad = '" + txt_edad.Text + "', usuario = '" + txt_usuario.Text + "', contraseña = '" + txt_contraseña.Text + "', Rol = '" + txt_rol.Text + "' where ID = '" + txt_id.Text + "' "
        mensa = "Actualizacion"
        Ejecutar(sen, mensa)

        Try
            Dim da As New SqlDataAdapter("Select * from INGRESO", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try

    End Sub
    'Botón de Borrar'
    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click

        sen = "Delete INGRESO WHERE ID = '" + txt_id.Text + "'"
        mensa = " Usuario borrado "
        Ejecutar(sen, mensa)

        Try

            Dim da As New SqlDataAdapter("Select * from INGRESO", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    'Botón de regresar'
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Close()
        Form1.Show()

    End Sub
    'Boton de Buscar'
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim da As New SqlDataAdapter("Select * from INGRESO where Apellido = '" + txt_buscar.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)

    End Sub
    'Boton de insertar'
    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click

        sen = "Insert into INGRESO values ('" + txt_id.Text + "','" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_correo.Text + "','" + txt_edad.Text + "','" + txt_usuario.Text + "','" + txt_contraseña.Text + "','" + txt_rol.Text + "')"
        mensa = "Usuario ingresado "
        Ejecutar(sen, mensa)


        Try
            Dim da As New SqlDataAdapter("Select * from INGRESO", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try

    End Sub
End Class