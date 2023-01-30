Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Imports EJERCICIO_1
'Primero Insertamos las Librerías a usar'
Public Class Form1
    'Luego hacemos la respectiva conexion'
    Dim con As SqlConnection = New SqlConnection(My.Settings.Conexion)
    Dim conexion As CONEXION = New CONEXION

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Botón en Función del Login'
    Private Sub BTN_ingresar_Click(sender As Object, e As EventArgs) Handles BTN_ingresar.Click
        'Declaración de Variables'
        Dim f2 = Administrador
        'Funcion que realizara para confirmar el login'
        Dim verificar As String = "Update ROL set Rol=Rol where NOMBRE_USUARIO = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROL= 'Administrador'"
        Dim verificar2 As String = "Update ROL set Rol=Rol where NOMBRE_USUARIO = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROL= 'Usuario'"
        Dim verificar3 As String = "Update ROL set Rol=Rol where NOMBRE_USUARIO = '" + txt_usuario.Text + "' AND CONTRASEÑA = '" + txt_contraseña.Text + "' and ROL= 'Secretariado'"
        'If en función del Login para verificar en que rango y posición esta'
        If conexion.Verificacion(verificar) Then

            Me.Hide()
            f2.Show()
            txt_contraseña.Text = ""
            txt_usuario.Text = ""

        Else

            If conexion.Verificacion(verificar2) Then

                Me.Hide()
                MsgBox("Usuario")
                f2.Show()
                'En caso del usuario le ocultamos todos los datos que se le dan al administrador'

                f2.Label2.Visible = False
                f2.Label3.Visible = False
                f2.Label4.Visible = False
                f2.Label4.Visible = False
                f2.Label5.Visible = False
                f2.Label6.Visible = False
                f2.Label7.Visible = False
                f2.Label8.Visible = False
                f2.Label9.Visible = False
                f2.txt_id.Visible = False
                f2.txt_nombre.Visible = False
                f2.txt_apellido.Visible = False
                f2.txt_correo.Visible = False
                f2.txt_edad.Visible = False
                f2.txt_usuario.Visible = False
                f2.txt_contraseña.Visible = False
                f2.txt_rol.Visible = False
                f2.btn_borrar.Visible = False
                f2.btn_insertar.Visible = False
                f2.btn_cargar.Visible = False
                f2.btn_editar.Visible = False
                f2.DataGridView1.Enabled = False
                txt_contraseña.Text = ""
                txt_usuario.Text = ""

            Else

                If conexion.Verificacion(verificar3) Then

                    Me.Hide()
                    MsgBox("Secretariado")
                    f2.Show()
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""
                    f2.btn_borrar.Visible = False
                    f2.btn_editar.Visible = False

                Else

                    MsgBox("La contraseña o usuario son incorrectos intentelo nuevamente")
                    txt_contraseña.Text = ""
                    txt_usuario.Text = ""

                End If
            End If

        End If








    End Sub
End Class
