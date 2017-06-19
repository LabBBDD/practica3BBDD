Imports System.Data.OleDb

Public Class AgenteBD
    Private Shared CadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared mConexion As OleDbConnection
    Private Shared instanciaAgente As AgenteBD

    Private Sub New(ruta As String)
        mConexion = New OleDbConnection
        mConexion.ConnectionString = (CadConexion + ruta)
        Try
            mConexion.Open()
        Catch excepcion As Exception
            MessageBox.Show("Error al conectar con datos" & ControlChars.CrLf & excepcion.Message & ControlChars.CrLf & excepcion.Source())
        End Try
    End Sub

    Public Shared Function getAgente()

        If instanciaAgente Is Nothing Then
            instanciaAgente = New AgenteBD(Menu.abrirBD())
        End If

        Return instanciaAgente

    End Function

    Public Function read(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()
    End Function

    Public Function create(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function

    Public Function update(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function

    Public Function delete(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function
End Class
