<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administrador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.txt_edad = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.btn_cargar = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_rol = New System.Windows.Forms.TextBox()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(229, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BIENVENIDO "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 341)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(595, 223)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NOMBRE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "APELLIDO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "CORREO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "EDAD: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "USUARIO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "CONTRASEÑA:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(131, 71)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(201, 20)
        Me.txt_id.TabIndex = 9
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(130, 101)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(201, 20)
        Me.txt_nombre.TabIndex = 10
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(131, 131)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(201, 20)
        Me.txt_apellido.TabIndex = 11
        '
        'txt_correo
        '
        Me.txt_correo.Location = New System.Drawing.Point(130, 163)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(201, 20)
        Me.txt_correo.TabIndex = 12
        '
        'txt_edad
        '
        Me.txt_edad.Location = New System.Drawing.Point(130, 193)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(201, 20)
        Me.txt_edad.TabIndex = 13
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(130, 220)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(201, 20)
        Me.txt_usuario.TabIndex = 14
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(130, 249)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(201, 20)
        Me.txt_contraseña.TabIndex = 15
        '
        'btn_insertar
        '
        Me.btn_insertar.Location = New System.Drawing.Point(391, 67)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(75, 23)
        Me.btn_insertar.TabIndex = 16
        Me.btn_insertar.Text = "INSERTAR"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(488, 67)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cargar.TabIndex = 17
        Me.btn_cargar.Text = "CARGAR"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.Location = New System.Drawing.Point(391, 124)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar.TabIndex = 18
        Me.btn_borrar.Text = "BORRAR"
        Me.btn_borrar.UseVisualStyleBackColor = True
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(488, 124)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 23)
        Me.btn_editar.TabIndex = 19
        Me.btn_editar.Text = "EDITAR"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(92, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ROL:"
        '
        'txt_rol
        '
        Me.txt_rol.Location = New System.Drawing.Point(130, 278)
        Me.txt_rol.Name = "txt_rol"
        Me.txt_rol.Size = New System.Drawing.Size(201, 20)
        Me.txt_rol.TabIndex = 21
        '
        'btn_regresar
        '
        Me.btn_regresar.Location = New System.Drawing.Point(444, 177)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(75, 23)
        Me.btn_regresar.TabIndex = 23
        Me.btn_regresar.Text = "REGRESAR"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(130, 309)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(201, 20)
        Me.txt_buscar.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 576)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.txt_rol)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_edad)
        Me.Controls.Add(Me.txt_correo)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Administrador"
        Me.Text = "Administrador"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_edad As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents btn_insertar As Button
    Friend WithEvents btn_cargar As Button
    Friend WithEvents btn_borrar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_rol As TextBox
    Friend WithEvents btn_regresar As Button
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Button1 As Button
End Class
