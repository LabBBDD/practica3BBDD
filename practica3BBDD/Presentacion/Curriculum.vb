Public Class Curriculum

    Dim invest As Investigadores
    Dim listaConferencias As Collection
    Dim listaArticulos As Collection

    Public Property listaConf As Collection

        Get
            Return listaConferencias
        End Get
        Set(value As Collection)
            listaConferencias = value
        End Set

    End Property

    Public Property listaArt As Collection

        Get
            Return listaArticulos
        End Get
        Set(value As Collection)
            listaArticulos = value
        End Set

    End Property

    Private Sub Curriculum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LBConf.Enabled = False
        LBArt.Enabled = False

        invest = practica3BBDD.Menu.getDatosCV()

        lblDatNombre.Text = invest.Nombre_Invest
        lblDatApellidos.Text = invest.Apellido_Invest
        lblDatDesp.Text = invest.nombre_Despacho
        lblDatEdificio.Text = invest.nombre_Edificio
        lblDatDep.Text = invest.nombre_Departamento
        lblDatTelefono.Text = invest.num_Telefono
        lblDatEmail.Text = invest.direccion_email

        listaConf = practica3BBDD.Menu.getGestAsiste().readConferencias(invest)
        listaArt = practica3BBDD.Menu.getGestAsiste().readArticulos(invest)
        For Each aux As Integer In listaConf
            LBConf.Items.Add(practica3BBDD.Menu.getGestConf().readIdConf(aux).nombre_)
        Next
        For Each aux As Integer In listaArt
            LBArt.Items.Add(practica3BBDD.Menu.getGestArt().readIdArt(aux).nombre_titulo)
        Next


    End Sub

End Class