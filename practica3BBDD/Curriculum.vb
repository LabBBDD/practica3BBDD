Public Class Curriculum
    Private Sub Curriculum_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim investigador As New Investigadores(practica3BBDD.Menu.ListBoxInvestigadores.SelectedItem.ToString)

        readInvestigador(investigador)
        lblNombreCV.Text = investigador.Nombre_Invest
        lblApellidosCV.Text = investigador.Apellido_Invest
        lblDespachoCV.Text = investigador.nombre_Despacho
        lblEdificioCV.Text = investigador.nombre_Edificio
        lblDepartamentoCV.Text = investigador.nombre_Departamento
        lblTelefonoCV.Text = investigador.num_Telefono
        lblEmailT.Text = investigador.direccion_email

        Dim asiste As New Asiste
        asiste.miidinvestigador = investigador.ListBoxInvestigadores.SelectedItem.ToString
        asiste.leerAsistentes()
        Dim textoconferencias As String = ""
        Dim conferencia As Conferencia

        For Each asist In asiste.migestor.milistaAsistentes
            conferencia = New Conferencia(asist)
            conferencia.leer()
            textoconferencias = textoconferencias & " " & conferencia.nombre_siglas & " " & conferencia.nombre_ & " " & conferencia.nombre_lugar & " " &
             conferencia.fechainicio & " " & conferencia.fechafin & vbCrLf
        Next

        lblConferenciasT.Text = textoconferencias

        Dim textoarticulos As String = ""
        Dim autor As New Autores(investigador.lstInvestigadores.SelectedItem.ToString)
        autor.leerArticulos()

        Dim autor2 As Autores
        Dim researcher As Investigadores
        Dim articulo As Articulos
        Dim conferen As Conferencia

        For Each art In autor.migestor.milistaAutores
            autor2 = New Autores()
            autor2.miidarticulo = art
            autor2.leerInvestigadores()
            For Each inv In autor2.migestor.milistaAutores
                researcher = New Investigadores(inv)
                researcher.leer()
                textoarticulos &= researcher.miapellido & "  " & researcher.minombre & ", "
            Next
            articulo = New Articulos(art)
            articulo.leer()
            textoarticulos &= articulo.nombre_titulo & ". "
            conferen = New Conferencia(articulo.miconferencia)
            conferen.leer()
            textoarticulos &= conferen.nombre_ & "(" & conferen.nombre_siglas & ")" & ". pp. " & articulo.num_pag_inicio & "-" & articulo.num_pag_fin & "." &
                              conferen.nombre_lugar & ". " & Year(conferen.fechainicio) & "."
            textoarticulos &= vbCrLf
        Next

        lblArticulosPublicadosCV.Text = textoarticulos
    End Sub



    End Sub
End Class