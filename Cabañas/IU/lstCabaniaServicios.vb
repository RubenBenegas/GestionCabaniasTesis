Public Class lstCabaniaServicios

    Private idCabania_ As Integer

    Public Property idCabania() As Integer
        Get
            Return idCabania_
        End Get
        Set(ByVal value As Integer)
            idCabania_ = value
        End Set
    End Property

    Dim cabania As New Cabanias
    Dim servicio As New Servicios

    Private Sub lstCabaniaServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cabania.BuscarServicio(dgvCabaniaServicios)

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        servicio.Id = dgvCabaniaServicios.Item("id", dgvCabaniaServicios.CurrentRow.Index).Value
        cabania.CabaniaServCargar(idCabania, servicio.Id)
        cabania.CabaniaServCarga(idCabania, frmCabania.dgvCabaniaServicios)
        Close()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Close()
    End Sub
End Class