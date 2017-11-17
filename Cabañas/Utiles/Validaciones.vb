Public Class Validaciones


    Public Function validarCampos(ByVal formulario As Form, ByVal controlador As ErrorProvider)
        Dim miControl As Control
        validarCampos = True
        For Each miControl In formulario.Controls
            If miControl.Tag = "*" Then

                If TypeOf (miControl) Is TextBox Then
                    Try
                        If miControl.Text.Length = 0 Then
                            Throw New Exception("Por favor, ingrese un valor.")
                        Else
                            controlador.SetError(miControl, "")
                        End If
                    Catch ex As Exception
                        controlador.SetError(miControl, ex.Message)
                        validarCampos = False
                    End Try

                ElseIf TypeOf (miControl) Is ComboBox Then
                    Try
                        If miControl.Text = "" Then
                            Throw New Exception("Por favor, ingrese un valor.")
                        Else
                            controlador.SetError(miControl, "")
                        End If
                    Catch ex As Exception
                        controlador.SetError(miControl, ex.Message)
                        validarCampos = False
                    End Try
                End If
            End If

        Next
    End Function










    Public Function validarNombre(ByVal MiTexto As String)

        MiTexto = MiTexto.Trim()

        Dim ape() As String

        ape = MiTexto.Split(" ")
        MiTexto = ""

        Dim x As Integer

        For x = 0 To ape.Length - 1
            ape(x) = ape(x).Substring(0, 1).ToUpper + ape(x).Substring(1).ToLower

            MiTexto = MiTexto + ape(x) + " "
        Next

        MiTexto = MiTexto.Trim()

        Return MiTexto
    End Function

    Public Function validarFecha(ByRef MiFecha As TextBox) As Boolean

        If MiFecha.Text = "" Then
            Return True
        End If

        If MiFecha.Text.Length < 9 Then
            MsgBox("Fecha Incompleta")
            MiFecha.Clear()
            Return False
        End If


        Dim fec() As String
        Dim dia, mes, año As Integer

        fec = MiFecha.Text.Split("/")

        dia = CInt(fec(0))
        mes = CInt(fec(1))
        año = CInt(fec(2))

        If año < 1900 Or año > 2100 Then
            MsgBox("Año Incorrecto.")
            MiFecha.Clear()
            Return False
        End If

        If mes < 1 Or mes > 12 Then
            MsgBox("Mes incorrecto.")
            MiFecha.Clear()
            Return False
        End If

        If mes = 2 Then
            If año Mod 4 = 0 Then
                If dia < 1 Or dia > 29 Then
                    MsgBox("El dia es incorrecto.")
                    MiFecha.Clear()
                    Return False
                End If

            Else
                If dia < 1 Or dia > 28 Then
                    MsgBox("El dia es incorrecto.")
                    MiFecha.Clear()
                    Return False
                End If

            End If
        End If

        If mes = 1 Or mes = 3 Or mes = 5 Or mes = 7 Or mes = 10 Or mes = 12 Then
            If dia < 1 Or dia > 31 Then
                MsgBox("Dia incorrecto.")
                MiFecha.Clear()
                Return False
            End If
        Else
            If dia < 1 Or dia > 30 Then
                MsgBox("Dia incorrecto.")
                MiFecha.Clear()
                Return False
            End If

        End If

        Return True

    End Function

    Public Function validarImporte(ByVal MiImporte As String)
        Dim nro As Decimal = Val(MiImporte)

        If nro < 0 Or nro > 9999999.99 Then

            MsgBox("Importe no valido." + " " + CStr(nro), MsgBoxStyle.Exclamation)

        End If

        Return MiImporte
    End Function

End Class
