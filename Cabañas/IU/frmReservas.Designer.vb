<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReservas))
        Me.lblId = New System.Windows.Forms.Label
        Me.lblIdHuesped = New System.Windows.Forms.Label
        Me.lblFechaIngreso = New System.Windows.Forms.Label
        Me.lblFechaSalidad = New System.Windows.Forms.Label
        Me.lblIdIdCabania = New System.Windows.Forms.Label
        Me.lblNroPasajeros = New System.Windows.Forms.Label
        Me.lblSenia = New System.Windows.Forms.Label
        Me.lblCheckIn = New System.Windows.Forms.Label
        Me.lblCheckOut = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtNumeroPasajeros = New System.Windows.Forms.TextBox
        Me.txtSenia = New System.Windows.Forms.TextBox
        Me.chkConSenia = New System.Windows.Forms.CheckBox
        Me.txtIdHuesped = New System.Windows.Forms.TextBox
        Me.btnBuscarHuesped = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker
        Me.dtpCheckin = New System.Windows.Forms.DateTimePicker
        Me.dtpCheckout = New System.Windows.Forms.DateTimePicker
        Me.cmbIdCabania = New System.Windows.Forms.ComboBox
        Me.txtNombreHuesped = New System.Windows.Forms.TextBox
        Me.dgvServiciosAdicionales = New System.Windows.Forms.DataGridView
        Me.lblServiciosAdicionales = New System.Windows.Forms.Label
        Me.txtCostoEstadia = New System.Windows.Forms.TextBox
        Me.txtCostoAdicionales = New System.Windows.Forms.TextBox
        Me.txtCostoTotal = New System.Windows.Forms.TextBox
        Me.lblCostoEstadia = New System.Windows.Forms.Label
        Me.lblCostoAdicionales = New System.Windows.Forms.Label
        Me.lblCostoTotal = New System.Windows.Forms.Label
        Me.lblReembolso = New System.Windows.Forms.Label
        Me.txtReembolso = New System.Windows.Forms.TextBox
        Me.lblReservaCancelada = New System.Windows.Forms.Label
        Me.dtpFechaReserva = New System.Windows.Forms.DateTimePicker
        Me.lblFechaReserva = New System.Windows.Forms.Label
        Me.lblImporteSenia = New System.Windows.Forms.Label
        Me.dtpFechaPagoSenia = New System.Windows.Forms.DateTimePicker
        Me.lblFechaSenia = New System.Windows.Forms.Label
        Me.txtFaltaDePagar = New System.Windows.Forms.TextBox
        Me.lblFaltaPAgar = New System.Windows.Forms.Label
        Me.btnDetalleCancelacion = New System.Windows.Forms.Button
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape9 = New Cabañas.BotonDetalleCancReserva
        Me.RectangleShape8 = New Cabañas.BotonConsulCostos
        Me.RectangleShape7 = New Cabañas.BotonCancelarRes
        Me.RectangleShape6 = New Cabañas.BotonCerrar
        Me.RectangleShape5 = New Cabañas.BotonCancelar
        Me.RectangleShape4 = New Cabañas.BotonAceptar
        Me.RectangleShape3 = New Cabañas.BotonPagos
        Me.RectangleShape2 = New Cabañas.BotonEliminarFrm
        Me.RectangleShape1 = New Cabañas.BotonAgregarFrm
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServiciosAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(12, 9)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id:"
        '
        'lblIdHuesped
        '
        Me.lblIdHuesped.AutoSize = True
        Me.lblIdHuesped.BackColor = System.Drawing.Color.Transparent
        Me.lblIdHuesped.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdHuesped.ForeColor = System.Drawing.Color.White
        Me.lblIdHuesped.Location = New System.Drawing.Point(12, 70)
        Me.lblIdHuesped.Name = "lblIdHuesped"
        Me.lblIdHuesped.Size = New System.Drawing.Size(76, 13)
        Me.lblIdHuesped.TabIndex = 1
        Me.lblIdHuesped.Text = "Id Huesped:"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.ForeColor = System.Drawing.Color.White
        Me.lblFechaIngreso.Location = New System.Drawing.Point(12, 104)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(92, 13)
        Me.lblFechaIngreso.TabIndex = 2
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'lblFechaSalidad
        '
        Me.lblFechaSalidad.AutoSize = True
        Me.lblFechaSalidad.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaSalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSalidad.ForeColor = System.Drawing.Color.White
        Me.lblFechaSalidad.Location = New System.Drawing.Point(12, 137)
        Me.lblFechaSalidad.Name = "lblFechaSalidad"
        Me.lblFechaSalidad.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaSalidad.TabIndex = 3
        Me.lblFechaSalidad.Text = "Fecha Salida:"
        '
        'lblIdIdCabania
        '
        Me.lblIdIdCabania.AutoSize = True
        Me.lblIdIdCabania.BackColor = System.Drawing.Color.Transparent
        Me.lblIdIdCabania.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdIdCabania.ForeColor = System.Drawing.Color.White
        Me.lblIdIdCabania.Location = New System.Drawing.Point(12, 170)
        Me.lblIdIdCabania.Name = "lblIdIdCabania"
        Me.lblIdIdCabania.Size = New System.Drawing.Size(69, 13)
        Me.lblIdIdCabania.TabIndex = 4
        Me.lblIdIdCabania.Text = "Id Cabaña:"
        '
        'lblNroPasajeros
        '
        Me.lblNroPasajeros.AutoSize = True
        Me.lblNroPasajeros.BackColor = System.Drawing.Color.Transparent
        Me.lblNroPasajeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroPasajeros.ForeColor = System.Drawing.Color.White
        Me.lblNroPasajeros.Location = New System.Drawing.Point(270, 9)
        Me.lblNroPasajeros.Name = "lblNroPasajeros"
        Me.lblNroPasajeros.Size = New System.Drawing.Size(113, 13)
        Me.lblNroPasajeros.TabIndex = 5
        Me.lblNroPasajeros.Text = "Numero Pasajeros:"
        '
        'lblSenia
        '
        Me.lblSenia.AutoSize = True
        Me.lblSenia.BackColor = System.Drawing.Color.Transparent
        Me.lblSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenia.ForeColor = System.Drawing.Color.White
        Me.lblSenia.Location = New System.Drawing.Point(272, 40)
        Me.lblSenia.Name = "lblSenia"
        Me.lblSenia.Size = New System.Drawing.Size(40, 13)
        Me.lblSenia.TabIndex = 6
        Me.lblSenia.Text = "Seña:"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckIn.ForeColor = System.Drawing.Color.White
        Me.lblCheckIn.Location = New System.Drawing.Point(272, 105)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(58, 13)
        Me.lblCheckIn.TabIndex = 8
        Me.lblCheckIn.Text = "CheckIn:"
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOut.ForeColor = System.Drawing.Color.White
        Me.lblCheckOut.Location = New System.Drawing.Point(270, 138)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(67, 13)
        Me.lblCheckOut.TabIndex = 9
        Me.lblCheckOut.Text = "CheckOut:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(127, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 10
        '
        'txtNumeroPasajeros
        '
        Me.txtNumeroPasajeros.Location = New System.Drawing.Point(381, 6)
        Me.txtNumeroPasajeros.Name = "txtNumeroPasajeros"
        Me.txtNumeroPasajeros.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroPasajeros.TabIndex = 4
        Me.txtNumeroPasajeros.Tag = "*"
        '
        'txtSenia
        '
        Me.txtSenia.Enabled = False
        Me.txtSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenia.Location = New System.Drawing.Point(15, 527)
        Me.txtSenia.Multiline = True
        Me.txtSenia.Name = "txtSenia"
        Me.txtSenia.Size = New System.Drawing.Size(100, 25)
        Me.txtSenia.TabIndex = 5
        Me.txtSenia.Tag = "*"
        Me.txtSenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkConSenia
        '
        Me.chkConSenia.AutoSize = True
        Me.chkConSenia.BackColor = System.Drawing.Color.Transparent
        Me.chkConSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConSenia.ForeColor = System.Drawing.Color.White
        Me.chkConSenia.Location = New System.Drawing.Point(381, 39)
        Me.chkConSenia.Name = "chkConSenia"
        Me.chkConSenia.Size = New System.Drawing.Size(81, 17)
        Me.chkConSenia.TabIndex = 6
        Me.chkConSenia.Text = "Con Seña"
        Me.chkConSenia.UseVisualStyleBackColor = False
        '
        'txtIdHuesped
        '
        Me.txtIdHuesped.Enabled = False
        Me.txtIdHuesped.Location = New System.Drawing.Point(127, 67)
        Me.txtIdHuesped.Name = "txtIdHuesped"
        Me.txtIdHuesped.Size = New System.Drawing.Size(100, 20)
        Me.txtIdHuesped.TabIndex = 24
        '
        'btnBuscarHuesped
        '
        Me.btnBuscarHuesped.Location = New System.Drawing.Point(233, 65)
        Me.btnBuscarHuesped.Name = "btnBuscarHuesped"
        Me.btnBuscarHuesped.Size = New System.Drawing.Size(34, 23)
        Me.btnBuscarHuesped.TabIndex = 25
        Me.btnBuscarHuesped.Text = "..."
        Me.btnBuscarHuesped.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(127, 104)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaIngreso.TabIndex = 1
        Me.dtpFechaIngreso.Tag = "*"
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalida.Location = New System.Drawing.Point(127, 137)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaSalida.TabIndex = 2
        Me.dtpFechaSalida.Tag = "*"
        '
        'dtpCheckin
        '
        Me.dtpCheckin.Enabled = False
        Me.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheckin.Location = New System.Drawing.Point(381, 99)
        Me.dtpCheckin.Name = "dtpCheckin"
        Me.dtpCheckin.Size = New System.Drawing.Size(100, 20)
        Me.dtpCheckin.TabIndex = 7
        '
        'dtpCheckout
        '
        Me.dtpCheckout.Enabled = False
        Me.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCheckout.Location = New System.Drawing.Point(381, 132)
        Me.dtpCheckout.Name = "dtpCheckout"
        Me.dtpCheckout.Size = New System.Drawing.Size(100, 20)
        Me.dtpCheckout.TabIndex = 8
        '
        'cmbIdCabania
        '
        Me.cmbIdCabania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdCabania.FormattingEnabled = True
        Me.cmbIdCabania.Location = New System.Drawing.Point(127, 167)
        Me.cmbIdCabania.Name = "cmbIdCabania"
        Me.cmbIdCabania.Size = New System.Drawing.Size(100, 21)
        Me.cmbIdCabania.TabIndex = 3
        '
        'txtNombreHuesped
        '
        Me.txtNombreHuesped.Enabled = False
        Me.txtNombreHuesped.Location = New System.Drawing.Point(127, 67)
        Me.txtNombreHuesped.Name = "txtNombreHuesped"
        Me.txtNombreHuesped.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreHuesped.TabIndex = 0
        Me.txtNombreHuesped.Tag = "*"
        '
        'dgvServiciosAdicionales
        '
        Me.dgvServiciosAdicionales.AllowUserToAddRows = False
        Me.dgvServiciosAdicionales.AllowUserToDeleteRows = False
        Me.dgvServiciosAdicionales.AllowUserToResizeColumns = False
        Me.dgvServiciosAdicionales.AllowUserToResizeRows = False
        Me.dgvServiciosAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiciosAdicionales.Location = New System.Drawing.Point(12, 226)
        Me.dgvServiciosAdicionales.MultiSelect = False
        Me.dgvServiciosAdicionales.Name = "dgvServiciosAdicionales"
        Me.dgvServiciosAdicionales.ReadOnly = True
        Me.dgvServiciosAdicionales.RowHeadersVisible = False
        Me.dgvServiciosAdicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiciosAdicionales.Size = New System.Drawing.Size(401, 206)
        Me.dgvServiciosAdicionales.TabIndex = 26
        '
        'lblServiciosAdicionales
        '
        Me.lblServiciosAdicionales.AutoSize = True
        Me.lblServiciosAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.lblServiciosAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiciosAdicionales.ForeColor = System.Drawing.Color.White
        Me.lblServiciosAdicionales.Location = New System.Drawing.Point(12, 202)
        Me.lblServiciosAdicionales.Name = "lblServiciosAdicionales"
        Me.lblServiciosAdicionales.Size = New System.Drawing.Size(132, 13)
        Me.lblServiciosAdicionales.TabIndex = 29
        Me.lblServiciosAdicionales.Text = "Servicios Adicionales:"
        '
        'txtCostoEstadia
        '
        Me.txtCostoEstadia.Enabled = False
        Me.txtCostoEstadia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoEstadia.Location = New System.Drawing.Point(15, 467)
        Me.txtCostoEstadia.Multiline = True
        Me.txtCostoEstadia.Name = "txtCostoEstadia"
        Me.txtCostoEstadia.Size = New System.Drawing.Size(100, 25)
        Me.txtCostoEstadia.TabIndex = 31
        Me.txtCostoEstadia.Tag = "*"
        Me.txtCostoEstadia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostoAdicionales
        '
        Me.txtCostoAdicionales.Enabled = False
        Me.txtCostoAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoAdicionales.Location = New System.Drawing.Point(121, 467)
        Me.txtCostoAdicionales.Multiline = True
        Me.txtCostoAdicionales.Name = "txtCostoAdicionales"
        Me.txtCostoAdicionales.Size = New System.Drawing.Size(100, 25)
        Me.txtCostoAdicionales.TabIndex = 32
        Me.txtCostoAdicionales.Tag = "*"
        Me.txtCostoAdicionales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostoTotal
        '
        Me.txtCostoTotal.Enabled = False
        Me.txtCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotal.Location = New System.Drawing.Point(231, 467)
        Me.txtCostoTotal.Multiline = True
        Me.txtCostoTotal.Name = "txtCostoTotal"
        Me.txtCostoTotal.Size = New System.Drawing.Size(100, 25)
        Me.txtCostoTotal.TabIndex = 33
        Me.txtCostoTotal.Tag = "*"
        Me.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostoEstadia
        '
        Me.lblCostoEstadia.AutoSize = True
        Me.lblCostoEstadia.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoEstadia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoEstadia.ForeColor = System.Drawing.Color.White
        Me.lblCostoEstadia.Location = New System.Drawing.Point(12, 449)
        Me.lblCostoEstadia.Name = "lblCostoEstadia"
        Me.lblCostoEstadia.Size = New System.Drawing.Size(106, 13)
        Me.lblCostoEstadia.TabIndex = 35
        Me.lblCostoEstadia.Text = "Costo de estadia:"
        '
        'lblCostoAdicionales
        '
        Me.lblCostoAdicionales.AutoSize = True
        Me.lblCostoAdicionales.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoAdicionales.ForeColor = System.Drawing.Color.White
        Me.lblCostoAdicionales.Location = New System.Drawing.Point(118, 449)
        Me.lblCostoAdicionales.Name = "lblCostoAdicionales"
        Me.lblCostoAdicionales.Size = New System.Drawing.Size(129, 13)
        Me.lblCostoAdicionales.TabIndex = 36
        Me.lblCostoAdicionales.Text = "Costo de adicionales:"
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoTotal.ForeColor = System.Drawing.Color.White
        Me.lblCostoTotal.Location = New System.Drawing.Point(228, 449)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(76, 13)
        Me.lblCostoTotal.TabIndex = 37
        Me.lblCostoTotal.Text = "Costo Total:"
        '
        'lblReembolso
        '
        Me.lblReembolso.AutoSize = True
        Me.lblReembolso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReembolso.ForeColor = System.Drawing.Color.Red
        Me.lblReembolso.Location = New System.Drawing.Point(47, 532)
        Me.lblReembolso.Name = "lblReembolso"
        Me.lblReembolso.Size = New System.Drawing.Size(0, 25)
        Me.lblReembolso.TabIndex = 40
        '
        'txtReembolso
        '
        Me.txtReembolso.Enabled = False
        Me.txtReembolso.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReembolso.Location = New System.Drawing.Point(200, 526)
        Me.txtReembolso.Multiline = True
        Me.txtReembolso.Name = "txtReembolso"
        Me.txtReembolso.Size = New System.Drawing.Size(131, 30)
        Me.txtReembolso.TabIndex = 41
        Me.txtReembolso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtReembolso.Visible = False
        '
        'lblReservaCancelada
        '
        Me.lblReservaCancelada.AutoSize = True
        Me.lblReservaCancelada.BackColor = System.Drawing.Color.Transparent
        Me.lblReservaCancelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservaCancelada.ForeColor = System.Drawing.Color.Red
        Me.lblReservaCancelada.Location = New System.Drawing.Point(46, 480)
        Me.lblReservaCancelada.Name = "lblReservaCancelada"
        Me.lblReservaCancelada.Size = New System.Drawing.Size(261, 31)
        Me.lblReservaCancelada.TabIndex = 42
        Me.lblReservaCancelada.Text = "Reserva Cancelada!"
        Me.lblReservaCancelada.Visible = False
        '
        'dtpFechaReserva
        '
        Me.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReserva.Location = New System.Drawing.Point(127, 36)
        Me.dtpFechaReserva.Name = "dtpFechaReserva"
        Me.dtpFechaReserva.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaReserva.TabIndex = 44
        Me.dtpFechaReserva.Tag = "*"
        '
        'lblFechaReserva
        '
        Me.lblFechaReserva.AutoSize = True
        Me.lblFechaReserva.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaReserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaReserva.ForeColor = System.Drawing.Color.White
        Me.lblFechaReserva.Location = New System.Drawing.Point(12, 36)
        Me.lblFechaReserva.Name = "lblFechaReserva"
        Me.lblFechaReserva.Size = New System.Drawing.Size(110, 13)
        Me.lblFechaReserva.TabIndex = 45
        Me.lblFechaReserva.Text = "Fecha de reserva:"
        '
        'lblImporteSenia
        '
        Me.lblImporteSenia.AutoSize = True
        Me.lblImporteSenia.BackColor = System.Drawing.Color.Transparent
        Me.lblImporteSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteSenia.ForeColor = System.Drawing.Color.White
        Me.lblImporteSenia.Location = New System.Drawing.Point(12, 510)
        Me.lblImporteSenia.Name = "lblImporteSenia"
        Me.lblImporteSenia.Size = New System.Drawing.Size(102, 13)
        Me.lblImporteSenia.TabIndex = 46
        Me.lblImporteSenia.Text = "Importe de seña:"
        '
        'dtpFechaPagoSenia
        '
        Me.dtpFechaPagoSenia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPagoSenia.Location = New System.Drawing.Point(131, 527)
        Me.dtpFechaPagoSenia.Name = "dtpFechaPagoSenia"
        Me.dtpFechaPagoSenia.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaPagoSenia.TabIndex = 47
        Me.dtpFechaPagoSenia.Tag = "*"
        '
        'lblFechaSenia
        '
        Me.lblFechaSenia.AutoSize = True
        Me.lblFechaSenia.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaSenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSenia.ForeColor = System.Drawing.Color.White
        Me.lblFechaSenia.Location = New System.Drawing.Point(131, 510)
        Me.lblFechaSenia.Name = "lblFechaSenia"
        Me.lblFechaSenia.Size = New System.Drawing.Size(105, 13)
        Me.lblFechaSenia.TabIndex = 48
        Me.lblFechaSenia.Text = "Fecha pago seña"
        '
        'txtFaltaDePagar
        '
        Me.txtFaltaDePagar.Enabled = False
        Me.txtFaltaDePagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaltaDePagar.Location = New System.Drawing.Point(338, 661)
        Me.txtFaltaDePagar.Multiline = True
        Me.txtFaltaDePagar.Name = "txtFaltaDePagar"
        Me.txtFaltaDePagar.Size = New System.Drawing.Size(150, 25)
        Me.txtFaltaDePagar.TabIndex = 34
        '
        'lblFaltaPAgar
        '
        Me.lblFaltaPAgar.AutoSize = True
        Me.lblFaltaPAgar.Location = New System.Drawing.Point(335, 643)
        Me.lblFaltaPAgar.Name = "lblFaltaPAgar"
        Me.lblFaltaPAgar.Size = New System.Drawing.Size(78, 13)
        Me.lblFaltaPAgar.TabIndex = 38
        Me.lblFaltaPAgar.Text = "Falta de pagar:"
        '
        'btnDetalleCancelacion
        '
        Me.btnDetalleCancelacion.Location = New System.Drawing.Point(372, 496)
        Me.btnDetalleCancelacion.Name = "btnDetalleCancelacion"
        Me.btnDetalleCancelacion.Size = New System.Drawing.Size(114, 23)
        Me.btnDetalleCancelacion.TabIndex = 50
        Me.btnDetalleCancelacion.Text = "Detalle cancelacion"
        Me.btnDetalleCancelacion.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(514, 626)
        Me.ShapeContainer1.TabIndex = 52
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape9
        '
        Me.RectangleShape9.BackgroundImage = CType(resources.GetObject("RectangleShape9.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape9.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape9.CornerRadius = 13
        Me.RectangleShape9.Location = New System.Drawing.Point(380, 546)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.BackgroundImage = CType(resources.GetObject("RectangleShape8.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape8.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape8.CornerRadius = 13
        Me.RectangleShape8.Location = New System.Drawing.Point(387, 458)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BackgroundImage = CType(resources.GetObject("RectangleShape7.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape7.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape7.CornerRadius = 13
        Me.RectangleShape7.Location = New System.Drawing.Point(398, 173)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(90, 30)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BackgroundImage = CType(resources.GetObject("RectangleShape6.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape6.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape6.CornerRadius = 17
        Me.RectangleShape6.Location = New System.Drawing.Point(386, 583)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(122, 35)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackgroundImage = CType(resources.GetObject("RectangleShape5.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape5.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape5.CornerRadius = 13
        Me.RectangleShape5.Location = New System.Drawing.Point(266, 583)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackgroundImage = CType(resources.GetObject("RectangleShape4.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape4.CornerRadius = 13
        Me.RectangleShape4.Location = New System.Drawing.Point(172, 583)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackgroundImage = CType(resources.GetObject("RectangleShape3.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.CornerRadius = 11
        Me.RectangleShape3.Location = New System.Drawing.Point(424, 340)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(75, 23)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = CType(resources.GetObject("RectangleShape2.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.CornerRadius = 15
        Me.RectangleShape2.Location = New System.Drawing.Point(416, 271)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(90, 30)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 15
        Me.RectangleShape1.Location = New System.Drawing.Point(416, 223)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(90, 30)
        '
        'frmReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(514, 626)
        Me.Controls.Add(Me.btnDetalleCancelacion)
        Me.Controls.Add(Me.dtpFechaPagoSenia)
        Me.Controls.Add(Me.lblFechaSenia)
        Me.Controls.Add(Me.lblImporteSenia)
        Me.Controls.Add(Me.dtpFechaReserva)
        Me.Controls.Add(Me.lblFechaReserva)
        Me.Controls.Add(Me.lblReservaCancelada)
        Me.Controls.Add(Me.txtReembolso)
        Me.Controls.Add(Me.lblReembolso)
        Me.Controls.Add(Me.lblFaltaPAgar)
        Me.Controls.Add(Me.lblCostoTotal)
        Me.Controls.Add(Me.lblCostoAdicionales)
        Me.Controls.Add(Me.lblCostoEstadia)
        Me.Controls.Add(Me.txtFaltaDePagar)
        Me.Controls.Add(Me.txtCostoTotal)
        Me.Controls.Add(Me.txtCostoAdicionales)
        Me.Controls.Add(Me.txtCostoEstadia)
        Me.Controls.Add(Me.lblServiciosAdicionales)
        Me.Controls.Add(Me.dgvServiciosAdicionales)
        Me.Controls.Add(Me.txtNombreHuesped)
        Me.Controls.Add(Me.cmbIdCabania)
        Me.Controls.Add(Me.dtpCheckout)
        Me.Controls.Add(Me.dtpCheckin)
        Me.Controls.Add(Me.dtpFechaSalida)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.btnBuscarHuesped)
        Me.Controls.Add(Me.txtIdHuesped)
        Me.Controls.Add(Me.chkConSenia)
        Me.Controls.Add(Me.txtSenia)
        Me.Controls.Add(Me.txtNumeroPasajeros)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.lblCheckIn)
        Me.Controls.Add(Me.lblSenia)
        Me.Controls.Add(Me.lblNroPasajeros)
        Me.Controls.Add(Me.lblIdIdCabania)
        Me.Controls.Add(Me.lblFechaSalidad)
        Me.Controls.Add(Me.lblFechaIngreso)
        Me.Controls.Add(Me.lblIdHuesped)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReservas"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServiciosAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblIdHuesped As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblFechaSalidad As System.Windows.Forms.Label
    Friend WithEvents lblIdIdCabania As System.Windows.Forms.Label
    Friend WithEvents lblNroPasajeros As System.Windows.Forms.Label
    Friend WithEvents lblSenia As System.Windows.Forms.Label
    Friend WithEvents lblCheckIn As System.Windows.Forms.Label
    Friend WithEvents lblCheckOut As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNumeroPasajeros As System.Windows.Forms.TextBox
    Friend WithEvents txtSenia As System.Windows.Forms.TextBox
    Friend WithEvents chkConSenia As System.Windows.Forms.CheckBox
    Friend WithEvents txtIdHuesped As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarHuesped As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbIdCabania As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombreHuesped As System.Windows.Forms.TextBox
    Friend WithEvents lblServiciosAdicionales As System.Windows.Forms.Label
    Friend WithEvents dgvServiciosAdicionales As System.Windows.Forms.DataGridView
    Friend WithEvents txtCostoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoAdicionales As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoEstadia As System.Windows.Forms.TextBox
    Friend WithEvents lblCostoEstadia As System.Windows.Forms.Label
    Friend WithEvents lblCostoTotal As System.Windows.Forms.Label
    Friend WithEvents lblCostoAdicionales As System.Windows.Forms.Label
    Friend WithEvents lblReembolso As System.Windows.Forms.Label
    Friend WithEvents txtReembolso As System.Windows.Forms.TextBox
    Friend WithEvents lblReservaCancelada As System.Windows.Forms.Label
    Friend WithEvents dtpFechaReserva As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaReserva As System.Windows.Forms.Label
    Friend WithEvents lblImporteSenia As System.Windows.Forms.Label
    Friend WithEvents dtpFechaPagoSenia As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaSenia As System.Windows.Forms.Label
    Friend WithEvents lblFaltaPAgar As System.Windows.Forms.Label
    Friend WithEvents txtFaltaDePagar As System.Windows.Forms.TextBox
    Friend WithEvents btnDetalleCancelacion As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Cabañas.BotonAgregarFrm
    Friend WithEvents RectangleShape2 As Cabañas.BotonEliminarFrm
    Friend WithEvents RectangleShape3 As Cabañas.BotonPagos
    Friend WithEvents RectangleShape4 As Cabañas.BotonAceptar
    Friend WithEvents RectangleShape5 As Cabañas.BotonCancelar
    Friend WithEvents RectangleShape6 As Cabañas.BotonCerrar
    Friend WithEvents RectangleShape7 As Cabañas.BotonCancelarRes
    Friend WithEvents RectangleShape8 As Cabañas.BotonConsulCostos
    Friend WithEvents RectangleShape9 As Cabañas.BotonDetalleCancReserva
End Class
