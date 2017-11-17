Public Class grafReservas

    Private Sub grafReservas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i As Integer = flpContenedor.Controls.Count - 1 To 0 Step -1
            flpContenedor.Controls.Item(i).Dispose()
        Next

        For i As Integer = flpCabanias.Controls.Count - 1 To 0 Step -1
            flpCabanias.Controls.Item(i).Dispose()
        Next
    End Sub

    Private Sub Alquileres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        flpContenedor.Controls.Clear()
        'dtpfechaDesde.Value = Today.Date.AddDays(-10)
        'dtpFechaHasta.Value = Today.Date.AddDays(10)
        ActualizarGrafico()
    End Sub

    'Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    '    frmReservas.modificar = False
    '    frmReservas.RectangleShape6.Visible = False
    '    frmReservas.idReserva = 0
    '    frmReservas.ShowDialog()
    'End Sub

    Public Sub ActualizarGrafico()

        Dim cab As New Cabanias
        Dim dtc As New Data.DataTable
        dtc = cab.DataTableCabanias

        Dim res As New Reservas
        Dim dt As New Data.DataTable
        dt = res.DataTableReservas(dtpfechaDesde.Value, dtpFechaHasta.Value)

        Dim posX As Integer = 0
        Dim posY As Integer = 0
        Dim anchoDia As Integer = 30
        Dim btnReserva As BotonReservas
        Dim flpHabitacion As FlpCabanias
        Dim flpSuperior1 As New FlpCabanias
        Dim flpSuperior2 As New FlpCabanias
        Dim ttReserva As New ToolTip

        Dim btnCabania As New Huecos(1, flpCabanias.Width)
        btnCabania.BackColor = Color.Transparent
        btnCabania.ForeColor = Color.White
        btnCabania.Enabled = False
        Dim mrg As Padding = btnCabania.Margin
        btnCabania.Margin = New Padding(mrg.Left, 3, mrg.Right, 3)
        flpCabanias.Controls.Add(btnCabania)

        Dim btnCabania2 As New Huecos(1, flpCabanias.Width)
        btnCabania2.BackColor = Color.Transparent
        btnCabania2.ForeColor = Color.White
        btnCabania2.Enabled = False
        btnCabania2.Margin = New Padding(mrg.Left, 3, mrg.Right, 3)
        flpCabanias.Controls.Add(btnCabania2)

        For Each row As DataRow In dtc.Rows
            btnCabania = New Huecos(1, flpCabanias.Width)
            btnCabania.BackColor = Color.Maroon
            btnCabania.ForeColor = Color.White
            btnCabania.Margin = New Padding(mrg.Left, 3, mrg.Right, 3)
            btnCabania.Text = row.Item("id")
            flpCabanias.Controls.Add(btnCabania)
        Next

        flpSuperior1.BackColor = Color.White
        flpSuperior1.Width = anchoDia * (DateDiff(DateInterval.Day, dtpfechaDesde.Value, dtpFechaHasta.Value) + 1)
        flpSuperior1.Height = 32
        flpSuperior1.FlowDirection = FlowDirection.LeftToRight
        flpContenedor.Controls.Add(flpSuperior1)

        Dim diasMes As Integer = 0
        Dim mesAnterior As Integer = Month(dtpfechaDesde.Value)
        For i As Integer = 0 To DateDiff(DateInterval.Day, dtpfechaDesde.Value, dtpFechaHasta.Value)
            If Month(DateAdd(DateInterval.Day, i, dtpfechaDesde.Value)) = mesAnterior Then
                diasMes += 1
            Else
                Dim btnMes As New Huecos(diasMes, anchoDia)
                btnMes.BackColor = Color.Maroon
                btnMes.ForeColor = Color.White
                Dim tituloMes As String = MonthName(mesAnterior)
                btnMes.Text = tituloMes.ToUpper
                flpContenedor.Controls.Item(0).Controls.Add(btnMes)
                mesAnterior = Month(DateAdd(DateInterval.Day, i, dtpfechaDesde.Value))
                diasMes = 1
            End If
        Next
        If diasMes > 0 Then
            Dim btnMes As New Huecos(diasMes, anchoDia)
            btnMes.BackColor = Color.Maroon
            btnMes.ForeColor = Color.White
            Dim tituloMes As String = MonthName(mesAnterior)
            btnMes.Text = tituloMes.ToUpper
            flpContenedor.Controls.Item(0).Controls.Add(btnMes)
            mesAnterior = Month(DateAdd(DateInterval.Day, DateDiff(DateInterval.Day, dtpfechaDesde.Value, dtpFechaHasta.Value), dtpfechaDesde.Value))
        End If

        flpSuperior2.BackColor = Color.White
        flpSuperior2.Width = anchoDia * (DateDiff(DateInterval.Day, dtpfechaDesde.Value, dtpFechaHasta.Value) + 1)
        flpSuperior2.Height = 32
        flpSuperior2.FlowDirection = FlowDirection.LeftToRight
        flpContenedor.Controls.Add(flpSuperior2)

        Dim tituloDia As Date = dtpfechaDesde.Value
        For i As Integer = 1 To DateDiff(DateInterval.Day, dtpfechaDesde.Value, dtpFechaHasta.Value) + 1
            Dim btnDia As New Huecos(1, anchoDia)
            btnDia.BackColor = Color.Maroon
            btnDia.ForeColor = Color.White
            btnDia.Text = tituloDia.Day.ToString
            flpContenedor.Controls.Item(1).Controls.Add(btnDia)
            tituloDia = tituloDia.AddDays(1)
        Next

        For Each row As DataRow In dtc.Rows
            flpHabitacion = New FlpCabanias
            flpHabitacion.BackColor = Color.White
            flpHabitacion.Width = anchoDia * (DateDiff(DateInterval.Day, dtpfechaDesde.Value, dtpFechaHasta.Value) + 1)
            flpHabitacion.Height = 32
            flpHabitacion.FlowDirection = FlowDirection.LeftToRight
            flpHabitacion.id = row.Item("id")
            flpContenedor.Controls.Add(flpHabitacion)
        Next

        For Each row As DataRow In dt.Rows
            btnReserva = New BotonReservas
            btnReserva.Left = posX
            btnReserva.Top = posY
            btnReserva.BackColor = Color.SkyBlue
            btnReserva.ForeColor = Color.Transparent
            btnReserva.id = row.Item("id")
            btnReserva.Width = row.Item("dias") * anchoDia
            ttReserva.SetToolTip(btnReserva, row.Item("nombre"))

            Dim res2 As Reservas
            res2 = res.RecuperarReserva(btnReserva.id)
            btnReserva.fIngreso = res2.fIngreso
            btnReserva.fSalida = res2.fSalida
            btnReserva.idCabania = res2.IdCabania
            btnReserva.idEstado = res2.IdEstado

            If btnReserva.idEstado = 1 Then
                btnReserva.BackColor = Color.Orange
            End If
            If btnReserva.idEstado = 2 Then
                btnReserva.BackColor = Color.Violet
            End If
            If btnReserva.idEstado = 3 Then
                btnReserva.BackColor = Color.Yellow
            End If
            If btnReserva.idEstado = 4 Then
                btnReserva.BackColor = Color.Green
            End If
            If btnReserva.idEstado = 5 Then
                btnReserva.BackColor = Color.Red
            End If

            For i As Integer = 2 To flpContenedor.Controls.Count
                Dim idHabitacion As Integer = DirectCast(flpContenedor.Controls.Item(i), FlpCabanias).id
                If row.Item("idCabania") = idHabitacion Then
                    If flpContenedor.Controls.Item(i).Controls.Count > 0 Then
                        Dim fechaActual As Date = btnReserva.fIngreso
                        Dim anterior As Integer = flpContenedor.Controls.Item(i).Controls.Count - 1
                        Dim fechaAnterior As Date = DirectCast(flpContenedor.Controls.Item(i).Controls.Item(anterior), BotonReservas).fSalida
                        Dim cantDias As Integer = DateDiff(DateInterval.Day, fechaAnterior, fechaActual)
                        Dim hueco As New Huecos(cantDias, anchoDia)
                        flpContenedor.Controls.Item(i).Controls.Add(hueco)
                    Else
                        Dim fechaActual As Date = btnReserva.fIngreso
                        Dim fechaInicial As Date = dtpfechaDesde.Value
                        Dim cantDias As Integer
                        If fechaActual > fechaInicial Then
                            cantDias = DateDiff(DateInterval.Day, fechaInicial, fechaActual) + 1
                            Dim hueco As New Huecos(cantDias, anchoDia)
                            flpContenedor.Controls.Item(i).Controls.Add(hueco)
                        End If
                    End If
                    flpContenedor.Controls.Item(i).Controls.Add(btnReserva)
                    Exit For
                End If
            Next
            btnReserva.Show()
            posY += 20
        Next
    End Sub

    'Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
    '    flpCabanias.Controls.Clear()
    '    flpContenedor.Controls.Clear()
    '    ActualizarGrafico()
    'End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmReservas.modificar = False
        frmReservas.RectangleShape6.Visible = False
        frmReservas.idReserva = 0
        frmReservas.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        flpCabanias.Controls.Clear()
        flpContenedor.Controls.Clear()
        ActualizarGrafico()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        frmListadoReservas.rptListadoReservas1.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmListadoReservas.ShowDialog()

    End Sub
End Class