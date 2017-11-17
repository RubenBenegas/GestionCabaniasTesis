Public Class lstGastos

    Private idCategoria_ As Integer
    Public Property idCategoria() As Integer
        Get
            Return idCategoria_
        End Get
        Set(ByVal value As Integer)
            idCategoria_ = value
        End Set
    End Property

    Dim Gastos As New Gastos


    Private Sub lstGastos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Gastos.verTodos(dgvGastos)
        Gastos.CargarComboCategoria(cmbCategoria)
        txtTotal.Text = Gastos.GastosCalcularTotal()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Editar()
        frmGastos.modificar = True
        If dgvGastos.Rows.Count <> 0 Then
            frmGastos.IdGasto = dgvGastos.Item("Id", dgvGastos.CurrentRow.Index).Value
            frmGastos.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If


    End Sub

    Private Sub dgvGasto_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGastos.CellDoubleClick
        Editar()

    End Sub

    Private Sub btnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        Gastos.verTodos(dgvGastos)
        txtTotal.Text = Gastos.GastosCalcularTotal
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmGastos.modificar = False
        frmGastos.IdGasto = 0
        frmGastos.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If dgvGastos.Rows.Count <> 0 Then
            Gastos.id = dgvGastos.Item("Id", dgvGastos.CurrentRow.Index).Value
            Dim mensaje As DialogResult = MessageBox.Show("¿Está seguro que quiere borrar?", "Advertencia", MessageBoxButtons.OKCancel)
            If mensaje = Windows.Forms.DialogResult.OK Then
                If Gastos.BorrarGasto(Gastos.id) Then
                    MessageBox.Show("El gasto se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Gastos.verTodos(dgvGastos)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape4.Click
        Close()
    End Sub

    Private Sub RectangleShape5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape5.Click

        Gastos.GastosFiltrarPorCategoria(cmbCategoria.SelectedValue, dgvGastos)
        txtTotal.Text = Gastos.GastosCalcularPorCategoria(cmbCategoria.SelectedValue)

    End Sub
End Class