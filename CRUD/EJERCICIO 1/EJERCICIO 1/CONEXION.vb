﻿Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class CONEXION

    Public Conexion As SqlConnection = New SqlConnection(My.Settings.Conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter = New SqlDataAdapter
    Public cmd As SqlCommand

    'Método - Consulta'
    Public Sub consulta(ByVal sql As String, ByVal tabla As String)

        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, Conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)

    End Sub

    'Metodo - Verificacion'
    Function Verificacion(ByVal sql)
        Conexion.Open()
        cmd = New SqlCommand(sql, Conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        Conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
