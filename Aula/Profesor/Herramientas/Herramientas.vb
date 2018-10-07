Imports System.Globalization
Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.XtraEditors
Module Herramientas
#Region "Enums"
    Public Enum enumFormatoFecha
        dmy
        mdy
        ymd
    End Enum
    Public Enum enumFormatoDecimal
        ComaPunto
        PuntoComa
    End Enum
#End Region
#Region "Constantes"
    Public eFormatoFecha As enumFormatoFecha = enumFormatoFecha.dmy
    Public eFormatoDecimal As enumFormatoDecimal = enumFormatoDecimal.ComaPunto
#End Region

    ''' <summary>
    ''' Regresa una cadena con las horas y Minutos de diferencia, no mas de 23:59 hrs.
    ''' </summary>
    ''' <param name="FechaInicio">Fecha inicial</param>
    ''' <param name="FechaFin">FEcha Final</param>
    ''' <returns>Cadena con formato 00:00 de Hora</returns>
    Public Function GetDiferenciaFechas(ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime) As String
        Dim Hora As String = ""
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim difMin As Long = DateDiff(DateInterval.Minute, FechaInicio, FechaFin)

            Dim Tiempo = String.Format("{0:N0}:{1:N0} hrs", difMin / 60, difMin Mod 60)

            Hora = EvaluaHora(Tiempo)

        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
        Return Hora
    End Function

    ''' <summary>
    ''' Convierte un objeto (que generalmente es un texto) en un numero de precisión doble,
    ''' si el objeto no es un numero valido, entonces regresa un valor por Default  
    ''' </summary>
    ''' <param name="tNumero">El objeto (texto) que se va a evaluar como numero</param>
    ''' <param name="nDefault">El valor por default que utiliza em caso que el objewto no sea un numero valido</param>
    ''' <returns>Valor numerico del objeto evaluado</returns>
    Public Function EvaluaNumero(tNumero As String, nDefault As Double) As Double

        Dim bNumeroNegativo As Boolean = False
        If String.IsNullOrEmpty(tNumero) Then
            tNumero = ""
        End If

        ' Si el Numero se encuentra entre parentesis, es porque se tarat de un numero negativo...
        If tNumero.IndexOf("(") > -1 Then

            tNumero = tNumero.Replace("(", "")
            tNumero = tNumero.Replace(")", "")


            bNumeroNegativo = True
        End If

        Dim nNumero As Double = nDefault

        If String.IsNullOrEmpty(tNumero) Then


            nNumero = nDefault
        Else

            If Not Double.TryParse(tNumero, nNumero) Then
                nNumero = nDefault

            End If
        End If

        ' Aqui debo de multiplicar el valor absoluto, para que siempre quede negativo
        If bNumeroNegativo Then
            nNumero = nNumero * -1
        End If


        Return nNumero

    End Function

    ''' <summary>
    ''' Evalua el valor de Verdad de un texto indicado, considera "1", "TRUE", "T", "VERDADERO", "V", "SI" 
    ''' y "S" como verdaderos y cualquier otra cosa como falso
    ''' </summary>
    ''' <param name="tSiNo">El texto que se va a evaluar como un valor verdadero</param>
    ''' <returns>Valor de verdad del objeto evaluado</returns>
    Public Function EvaluaSiNo(tSiNo As String) As Boolean

        Dim bSiNo As Boolean = False

        Try

            Select Case tSiNo.ToUpper().Trim()

                Case "1", "TRUE", "T", "VERDADERO", "V", "SI",
                "S"

                    bSiNo = True
                    Exit Select
                Case Else


                    bSiNo = False
                    Exit Select


            End Select
        Catch


            bSiNo = False
        End Try

        Return bSiNo
    End Function

    ''' <summary>
    ''' Valida la Hora indicada
    ''' </summary>
    ''' <param name="tHora">El texto que se va a evaluar como una Hora</param>
    ''' <returns>La hora correspondiente al texto evaluado, expresada como un string con el formato correcto</returns>
    Public Function EvaluaHora(tHora As String) As String

        Dim tHoraEvaluada As String = "00:00"
        Dim tHoras As String = ""
        Dim tMinutos As String = ""

        Dim nHoras As Integer = 0
        Dim nMinutos As Integer = 0

        ' Primero determino en que logar estan los dos puntos...
        Dim nDosPuntos As Integer = tHora.IndexOf(":")

        If nDosPuntos > -1 Then

            ' Selecciono uno o dos lugares antes de los dos puntos para la hora
            If nDosPuntos = 1 Then
                tHoras = tHora.Substring(0, 1)
            Else

                tHoras = tHora.Substring(nDosPuntos - 2, 2)
            End If

            ' Selecciono uno o dos lugares despues de los dos puntos para los Minutos                
            If (tHora.Length - nDosPuntos) > 2 Then
                tMinutos = tHora.Substring(nDosPuntos + 1, 2)
            Else

                tMinutos = tHora.Substring(nDosPuntos + 1, 1)
            End If


            nHoras = CInt(EvaluaNumero(tHoras, 0))
            nMinutos = CInt(EvaluaNumero(tMinutos, 0))

            If nHoras > 23 Then
                nHoras = 0
            End If

            If nMinutos > 59 Then
                nMinutos = 0
            End If

            tHoras = nHoras.ToString().Trim()
            tMinutos = nMinutos.ToString().Trim()

            tHoras = (tHoras).PadLeft(2, "0")
            tMinutos = (tMinutos).PadLeft(2, "0")


            tHoraEvaluada = Convert.ToString(tHoras & Convert.ToString(":")) & tMinutos
        End If

        Return tHoraEvaluada

    End Function

    ''' <summary>
    ''' Convierte el un texto con el formato definido en Constantes.eFormatoFecha a la fecha correspondiente, 
    ''' si el texto tiene un valor de fecha invalido, entonces regresa un valor null
    ''' </summary>
    ''' <param name="tFecha">El Texto que se va a evaluar como una fecha</param>
    ''' <returns>La fecha correspondiengte al texto evaluado, expresada como un string con el formato correcto</returns>
    Public Function EvaluaFecha(tFecha As String) As String

        Dim fFecha As DateTime = Date.Now
        Dim tEvaluaFecha As String = ""

        Dim tFechaFormatoCorrecto As String = tFecha.Replace("-", "/").Trim()
        tFechaFormatoCorrecto = tFechaFormatoCorrecto.Replace(" ", "")

        ' Cuando mucho pueden ser 10 caracteres, si son mas, es porque tiene la hora tambien
        If tFechaFormatoCorrecto.Length > 10 Then
            tFechaFormatoCorrecto = tFechaFormatoCorrecto.Substring(0, 10)
        End If

        ' Ahora si tiene un slash entonces a huevo debe tener dos y solo dos
        If tFechaFormatoCorrecto.IndexOf("/") > -1 Then

            Dim iPrimerSlash As Integer = tFechaFormatoCorrecto.IndexOf("/")
            Dim iSegundoSlash As Integer = tFechaFormatoCorrecto.IndexOf("/", iPrimerSlash + 1)
            Dim iTercerSlash As Integer = tFechaFormatoCorrecto.IndexOf("/", iSegundoSlash + 1)

            Dim tDigito1 As String = ""
            Dim tDigito2 As String = ""
            Dim tDigito3 As String = ""

            If iPrimerSlash > -1 AndAlso iSegundoSlash > -1 AndAlso iTercerSlash = -1 Then

                tDigito1 = tFechaFormatoCorrecto.Substring(0, iPrimerSlash)
                tDigito2 = tFechaFormatoCorrecto.Substring(iPrimerSlash + 1, iSegundoSlash - iPrimerSlash - 1)

                tDigito3 = tFechaFormatoCorrecto.Substring(iSegundoSlash + 1)
            End If

            If String.IsNullOrEmpty(tDigito1) OrElse String.IsNullOrEmpty(tDigito2) Then


                tFechaFormatoCorrecto = ""
            Else

                Select Case eFormatoFecha

                    Case enumFormatoFecha.dmy, enumFormatoFecha.mdy

                        If tDigito1.Length = 1 Then
                            tDigito1 = Convert.ToString("0") & tDigito1
                        End If

                        If tDigito2.Length = 1 Then
                            tDigito2 = Convert.ToString("0") & tDigito2
                        End If

                        If String.IsNullOrEmpty(tDigito3) Then
                            tDigito3 = DateTime.Now.Year.ToString()
                        End If

                        If tDigito3.Length = 2 Then
                            tDigito3 = Convert.ToString("20") & tDigito3
                        End If

                        If tDigito1.Length = 2 AndAlso tDigito2.Length = 2 AndAlso tDigito3.Length = 4 Then
                            tFechaFormatoCorrecto = Convert.ToString(tDigito1 & tDigito2) & tDigito3
                        Else

                            tFechaFormatoCorrecto = ""
                        End If

                        Exit Select

                    Case enumFormatoFecha.ymd

                        If tDigito2.Length = 1 Then
                            tDigito2 = Convert.ToString("0") & tDigito1
                        End If

                        If tDigito3.Length = 1 Then
                            tDigito3 = Convert.ToString("0") & tDigito2
                        End If

                        If String.IsNullOrEmpty(tDigito1) Then
                            tDigito1 = DateTime.Now.Year.ToString()
                        End If

                        If tDigito1.Length = 2 Then
                            tDigito1 = Convert.ToString("20") & tDigito1
                        End If

                        If tDigito1.Length = 4 AndAlso tDigito2.Length = 2 AndAlso tDigito3.Length = 2 Then
                            tFechaFormatoCorrecto = Convert.ToString(tDigito1 & tDigito2) & tDigito3
                        Else

                            tFechaFormatoCorrecto = ""
                        End If

                        Exit Select


                End Select

            End If
        End If

        ' Aqui a la brava ya le quite los slash....
        If Not String.IsNullOrEmpty(tFechaFormatoCorrecto) Then

            ' Si no tiene slash, entonces el largo debe de ser 4, 6 u 8 a huevo!
            If tFechaFormatoCorrecto.Length = 4 OrElse tFechaFormatoCorrecto.Length = 6 OrElse tFechaFormatoCorrecto.Length = 8 Then

                ' Dependiendo del formato de fecha tomo los primeros 
                ' dos digitos como dia o como mes.
                Dim tMes As String = ""
                Dim tDia As String = ""
                Dim tAno As String = ""

                Select Case eFormatoFecha

                    Case enumFormatoFecha.dmy

                        Select Case tFechaFormatoCorrecto.Length

                            Case 4

                                ' solo contiene dia y mes
                                tDia = tFechaFormatoCorrecto.Substring(0, 2)
                                tMes = tFechaFormatoCorrecto.Substring(2, 2)
                                tAno = DateTime.Now.Year.ToString()

                                Exit Select

                            Case 6

                                ' dia mes y año con dos caracteres
                                tDia = tFechaFormatoCorrecto.Substring(0, 2)
                                tMes = tFechaFormatoCorrecto.Substring(2, 2)
                                tAno = "20" + tFechaFormatoCorrecto.Substring(4, 2)
                                Exit Select

                            Case 8

                                ' dia mes y año con cuatro caracteres
                                tDia = tFechaFormatoCorrecto.Substring(0, 2)
                                tMes = tFechaFormatoCorrecto.Substring(2, 2)
                                tAno = tFechaFormatoCorrecto.Substring(4, 4)
                                Exit Select

                        End Select

                        tFechaFormatoCorrecto = Convert.ToString((Convert.ToString(tDia & Convert.ToString("/")) & tMes) + "/") & tAno
                        Exit Select

                    Case enumFormatoFecha.mdy

                        Select Case tFechaFormatoCorrecto.Length

                            Case 4

                                ' solo contiene mes y dia
                                tMes = tFechaFormatoCorrecto.Substring(0, 2)
                                tDia = tFechaFormatoCorrecto.Substring(2, 2)
                                tAno = DateTime.Now.Year.ToString()

                                Exit Select

                            Case 6

                                ' mes, dia y año con dos caracteres
                                tMes = tFechaFormatoCorrecto.Substring(0, 2)
                                tDia = tFechaFormatoCorrecto.Substring(2, 2)
                                tAno = "20" + tFechaFormatoCorrecto.Substring(4, 2)
                                Exit Select

                            Case 8

                                ' mes, dia y año con cuatro caracteres
                                tMes = tFechaFormatoCorrecto.Substring(0, 2)
                                tDia = tFechaFormatoCorrecto.Substring(2, 2)
                                tAno = tFechaFormatoCorrecto.Substring(4, 4)
                                Exit Select

                        End Select

                        tFechaFormatoCorrecto = Convert.ToString((Convert.ToString(tMes & Convert.ToString("/")) & tDia) + "/") & tAno

                        Exit Select

                    Case enumFormatoFecha.ymd

                        Select Case tFechaFormatoCorrecto.Length

                            Case 4

                                ' solo contiene mes y dia
                                tMes = tFechaFormatoCorrecto.Substring(0, 2)
                                tDia = tFechaFormatoCorrecto.Substring(2, 2)
                                tAno = DateTime.Now.Year.ToString()

                                Exit Select

                            Case 6

                                ' año, mes y dia con dos caracteres
                                tAno = "20" + tFechaFormatoCorrecto.Substring(0, 2)
                                tMes = tFechaFormatoCorrecto.Substring(2, 2)
                                tDia = tFechaFormatoCorrecto.Substring(4, 2)

                                Exit Select

                            Case 8

                                ' año, mes y dia con cuatro caracteres
                                tAno = tFechaFormatoCorrecto.Substring(0, 4)
                                tMes = tFechaFormatoCorrecto.Substring(4, 2)
                                tDia = tFechaFormatoCorrecto.Substring(6, 2)

                                Exit Select

                        End Select

                        tFechaFormatoCorrecto = Convert.ToString((Convert.ToString(tAno & Convert.ToString("/")) & tMes) + "/") & tDia

                        Exit Select


                End Select
            Else


                tFechaFormatoCorrecto = ""

            End If
        End If

        Dim ciMexico As New CultureInfo("es-MX")
        Dim ciUsa As New CultureInfo("en-US")

        Select Case eFormatoFecha

            Case enumFormatoFecha.dmy

                If DateTime.TryParseExact(tFechaFormatoCorrecto, "dd/MM/yyyy", ciMexico, DateTimeStyles.None, fFecha) Then
                    tEvaluaFecha = fFecha.ToString("dd/MM/yyyy")
                Else

                    tEvaluaFecha = ""
                End If

                Exit Select

            Case enumFormatoFecha.mdy

                If DateTime.TryParseExact(tFechaFormatoCorrecto, "MM/dd/yyyy", ciUsa, DateTimeStyles.None, fFecha) Then
                    tEvaluaFecha = fFecha.ToString("MM/dd/yyyy")
                Else

                    tEvaluaFecha = ""
                End If

                Exit Select

            Case enumFormatoFecha.ymd

                If DateTime.TryParseExact(tFechaFormatoCorrecto, "yyyy/MM/dd", ciUsa, DateTimeStyles.None, fFecha) Then
                    tEvaluaFecha = fFecha.ToString("yyyy/MM/dd")
                Else

                    tEvaluaFecha = ""
                End If

                Exit Select

        End Select

        Return tEvaluaFecha

    End Function

    ''' <summary>
    ''' Convierte el un texto con el formato definido en eFormatoFecha a la fecha / Hora correspondiente, si 
    ''' el texto tiene un valor de fecha invalido, entonces regresa un valor null
    ''' </summary>
    ''' <param name="tFecha">El Texto que se va a evaluar como una fecha</param>
    ''' <returns>La fecha correspondiengte al texto evaluado, expresada como DateTime</returns>
    Public Function EvaluaFechaHora(tFecha As String) As Nullable(Of DateTime)

        Dim fFecha As DateTime = DateTime.Now
        Dim bOk As Boolean = False

        ' Esto esta fijo para Hora DD/MM/YY, pero de momento ya neta me da hueva!

        Dim tFechaModificada As String = tFecha.ToUpper().Replace("T", " ")

        ' switch (tFechaModificada.Length)
        ' {




        ' }

        If tFecha.ToUpper().IndexOf("M") > -1 Then


            'Const t As String = "KKCK"
        End If


        Dim ciMexico As New CultureInfo("es-MX")
        Dim ciUsa As New CultureInfo("en-US")

        Select Case eFormatoFecha

            Case enumFormatoFecha.dmy

                Select Case tFechaModificada.Length

                    Case 10

                        tFechaModificada += " 00:00:00"
                        Exit Select

                    Case 16

                        tFechaModificada += ":00"
                        Exit Select

                End Select

                bOk = DateTime.TryParseExact(tFechaModificada, "dd/MM/yyyy HH:mm:ss", ciMexico, DateTimeStyles.None, fFecha)
                Exit Select

            Case enumFormatoFecha.mdy

                bOk = DateTime.TryParseExact(tFecha, "MM/dd/yyyy", ciUsa, DateTimeStyles.None, fFecha)
                Exit Select

            Case enumFormatoFecha.ymd

                bOk = DateTime.TryParseExact(tFecha, "yyyy/MM/dd", ciUsa, DateTimeStyles.None, fFecha)
                Exit Select

        End Select

        ' Si no la encontro, entonces trato de interpretarla como pueda
        If Not bOk Then
            bOk = DateTime.TryParse(tFecha, fFecha)
        End If

        If bOk Then
            Return fFecha
        Else

            Return Nothing
        End If

    End Function

    Public Function ValidaColor(ByVal pColor As String, Optional ByVal pTransparencia As Integer = 255) As Color
        Dim ColorRetorno As Color = Color.White
        Try
            Cursor.Current = Cursors.WaitCursor
            ' Ahora si tiene punto y coma (;) entonces a huevo debe tener dos y solo dos
            If pColor.IndexOf(";") > -1 Then
                Dim iPrimerPuntoComa As Integer = pColor.IndexOf(";")
                Dim iSegundoPuntoComa As Integer = pColor.IndexOf(";", iPrimerPuntoComa + 1)
                Dim iTercerPuntoComa As Integer = pColor.IndexOf(";", iSegundoPuntoComa + 1)
                Dim iCuartoPuntoComa As Integer = pColor.IndexOf(";", iTercerPuntoComa + 1)

                Dim tDigito1 As String = ""
                Dim tDigito2 As String = ""
                Dim tDigito3 As String = ""
                Dim tDigito4 As String = ""

                If iPrimerPuntoComa > -1 AndAlso iSegundoPuntoComa > -1 AndAlso iTercerPuntoComa > -1 AndAlso iCuartoPuntoComa = -1 Then
                    tDigito1 = pColor.Substring(0, iPrimerPuntoComa)
                    tDigito2 = pColor.Substring(iPrimerPuntoComa + 1, iSegundoPuntoComa - iPrimerPuntoComa - 1)
                    tDigito3 = pColor.Substring(iSegundoPuntoComa + 1, iTercerPuntoComa - iSegundoPuntoComa - 1)
                    tDigito4 = pColor.Substring(iTercerPuntoComa + 1)
                End If

                tDigito1 = tDigito1.Trim()
                tDigito2 = tDigito2.Trim()
                tDigito3 = tDigito3.Trim()
                tDigito4 = tDigito4.Trim()

                If pTransparencia < 255 And pTransparencia >= 0 Then
                    tDigito1 = pTransparencia
                End If

                ColorRetorno = Color.FromArgb(tDigito1, tDigito2, tDigito3, tDigito4)
            End If
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
        Return ColorRetorno
    End Function

    Function ColorContraste(ByVal pColor As Color) As Color
        Dim ColorRetorno As Color = Color.Black
        Try

            Dim media As Integer = (Int(pColor.R) + Int(pColor.G) + Int(pColor.B)) / 3
            If media < (255 / 2) Then
                Return Color.White
            Else
                Return Color.Black
            End If
            'Cursor.Current = Cursors.WaitCursor
            '' Ahora si tiene punto y coma (;) entonces a huevo debe tener dos y solo dos
            'If pColor.IndexOf(";") > -1 Then
            '    Dim iPrimerPuntoComa As Integer = pColor.IndexOf(";")
            '    Dim iSegundoPuntoComa As Integer = pColor.IndexOf(";", iPrimerPuntoComa + 1)
            '    Dim iTercerPuntoComa As Integer = pColor.IndexOf(";", iSegundoPuntoComa + 1)
            '    Dim iCuartoPuntoComa As Integer = pColor.IndexOf(";", iTercerPuntoComa + 1)

            '    Dim tDigito1 As String = ""
            '    Dim tDigito2 As String = ""
            '    Dim tDigito3 As String = ""
            '    Dim tDigito4 As String = ""

            '    If iPrimerPuntoComa > -1 AndAlso iSegundoPuntoComa > -1 AndAlso iTercerPuntoComa > -1 AndAlso iCuartoPuntoComa = -1 Then
            '        tDigito1 = pColor.Substring(0, iPrimerPuntoComa)
            '        tDigito2 = pColor.Substring(iPrimerPuntoComa + 1, iSegundoPuntoComa - iPrimerPuntoComa - 1)
            '        tDigito3 = pColor.Substring(iSegundoPuntoComa + 1, iTercerPuntoComa - iSegundoPuntoComa - 1)
            '        tDigito4 = pColor.Substring(iTercerPuntoComa + 1)
            '    End If

            '    tDigito1 = tDigito1.Trim()
            '    tDigito2 = tDigito2.Trim()
            '    tDigito3 = tDigito3.Trim()
            '    tDigito4 = tDigito4.Trim()

            '    If pTransparencia < 255 And pTransparencia >= 0 Then
            '        tDigito1 = pTransparencia
            '    End If

            '    ColorRetorno = Color.FromArgb(tDigito1, tDigito2, tDigito3, tDigito4)
            'End If
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
        Return ColorRetorno
    End Function

End Module
