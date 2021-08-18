Imports DataBaseLib.DatosTallerDataSetTableAdapters
Imports System.Drawing

Public Module BaseDatosTaller

    Public dsDatos As New DatosTallerDataSet
    Public da As New DatosTallerDataSetTableAdapters.TableAdapterManager
    Private query As New QueriesTableAdapter
    Public dsImg As New ImgData
    Public dtImagenes As New DataTable

#Region "Imagenes"

    Public Sub IniciarImagenes()
        If My.Computer.FileSystem.FileExists(GetRowOpciones.RutaBaseDatosFotos) Then
            dsImg.ImagenHistorial.Clear()
            dsImg.ImagenHistorial.ReadXml(GetRowOpciones.RutaBaseDatosFotos)
        Else
            GuardarImagenHistorial()
        End If
    End Sub

    Public Function GetRowImagenHistorial(ByVal index As Integer) As ImgData.ImagenHistorialRow
        Return dsImg.ImagenHistorial.Rows(index)
    End Function

    Public Function BuscarImagenHistorial(ByVal IDHistorial As Integer) As ImgData.ImagenHistorialRow()
        Return dsImg.ImagenHistorial.Select("IDHistorial=" + IDHistorial.ToString)
    End Function

    Public Function BuscarImagenHistorial(ByVal IDImagenHistorial As Integer, ByVal IDHistorial As Integer) As ImgData.ImagenHistorialRow
        Return dsImg.ImagenHistorial.Select("IDHistorial=" + IDHistorial.ToString + " and IDImagenHistorial=" + IDImagenHistorial.ToString)(0)
    End Function

    Public Sub BorrarImagenHistorial(ByVal IDImagenHistorial As Integer, ByVal IDHistorial As Integer)
        dsImg.ImagenHistorial.RemoveImagenHistorialRow(BuscarImagenHistorial(IDImagenHistorial, IDHistorial))
    End Sub

    Public Sub GuardarImagenHistorial()
        Try
            dsImg.ImagenHistorial.WriteXml(GetRowOpciones.RutaBaseDatosFotos)
        Catch ex As Exception
            If ex.Message.StartsWith("El proceso no puede obtener acceso al archivo") Then
                EsperarSegundos(1)
                GuardarImagenHistorial()
            End If
        End Try
    End Sub

#End Region

#Region "Opciones"

    Public Sub Fuente(ByVal frm As Windows.Forms.Form)
        If frm.Font.Size = 12 Then
            frm.Font = New Font(frm.Font.FontFamily, GetRowOpciones.tamGrande, frm.Font.Style, frm.Font.Unit)
        ElseIf frm.Font.Size = 10 Then
            frm.Font = New Font(frm.Font.FontFamily, GetRowOpciones.tamMediana, frm.Font.Style, frm.Font.Unit)
        ElseIf frm.Font.Size = 9 Then
            frm.Font = New Font(frm.Font.FontFamily, GetRowOpciones.tamPequeña, frm.Font.Style, frm.Font.Unit)
        End If
    End Sub

    Public Sub IniciarOpciones()

        If (My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\opc.xml")) Then
            dsDatos.Opciones.ReadXml("opc.xml")
        Else
            dsDatos.Opciones.AddOpcionesRow(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), Environment.CurrentDirectory + "\Img\car6.jpg", "StretchImage", "", "", "", "", Environment.CurrentDirectory + "\DataImg.ryc", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "12pt", "9pt", "11pt", "11pt", "12pt", "11pt", "12pt", "10pt", 0, 0, 0, 0, 100, 0, 0, "Observaciones: 3 Meses de Garantía", 12, 10, 9, 0)
            GuardarOpciones()
        End If
    End Sub

    Public Function GetRowOpciones() As DatosTallerDataSet.OpcionesRow
        Try
            Return dsDatos.Opciones.Rows(0)
        Catch ex As Exception
            If dsDatos.Opciones.Rows.Count = 0 Then
                IniciarOpciones()
                Return dsDatos.Opciones.Rows(0)
            End If
        End Try
        Return Nothing
    End Function

    Public Sub GuardarOpciones()
        While dsDatos.Opciones.Rows.Count > 1
            dsDatos.Opciones.Rows.RemoveAt(1)
        End While
        dsDatos.Opciones.WriteXml("opc.xml")
    End Sub


#End Region

#Region "Comunes BaseDatos"

    Public Sub EsperarSegundos(ByVal nSecs As Double)

        Dim s As String = "0.00:00:" & nSecs.ToString.Replace(",", ".")
        Dim ts As TimeSpan = TimeSpan.Parse(s)
        Dim t1 As DateTime = DateTime.Now.Add(ts)
        Dim t2 As DateTime = DateTime.Now

        Do While t2 < t1
            System.Windows.Forms.Application.DoEvents()
            t2 = DateTime.Now
        Loop
    End Sub

    Public Function GuardarImg(ByVal img As Image) As IO.MemoryStream

        Dim men As New IO.MemoryStream
        Dim Info() As Drawing.Imaging.ImageCodecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
        Dim Params As Drawing.Imaging.EncoderParameters = New System.Drawing.Imaging.EncoderParameters(1)
        Params.Param(0) = New Drawing.Imaging.EncoderParameter(Drawing.Imaging.Encoder.Quality, 70L)

        img.Save(men, Info(1), Params)
        Return men
    End Function

    Public Function GuardarImg(ByVal ruta As String) As IO.MemoryStream

        Dim img As Image = System.Drawing.Image.FromFile(ruta)

        Dim men As New IO.MemoryStream
        Dim Info() As Drawing.Imaging.ImageCodecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
        Dim Params As Drawing.Imaging.EncoderParameters = New System.Drawing.Imaging.EncoderParameters(1)
        Params.Param(0) = New Drawing.Imaging.EncoderParameter(Drawing.Imaging.Encoder.Quality, 70L)

        img.Save(men, Info(1), Params)
        Return men
    End Function

    Public Sub Inicializar(ByVal Tablas As String)

        Try

            ' dsDatos = New DatosTallerDataSet

            da = New TableAdapterManager

            dsDatos.EnforceConstraints = False

            If Tablas.ToLower.Contains("agenda") Then
                dsDatos.AgendaTrabajo.Clear()

                da.AgendaTrabajoTableAdapter = New AgendaTrabajoTableAdapter
                da.AgendaTrabajoTableAdapter.Fill(dsDatos.AgendaTrabajo)
            End If

            If Tablas.ToLower.Contains("compras") Then
                dsDatos.Compras.Clear()

                da.ComprasTableAdapter = New ComprasTableAdapter
                da.ComprasTableAdapter.Fill(dsDatos.Compras)
            End If

            If Tablas.ToLower.Contains("cliente") Then
                dsDatos.Cliente.Clear()
                dsDatos.TelefonoCliente.Clear()

                da.ClienteTableAdapter = New ClienteTableAdapter
                da.TelefonoClienteTableAdapter = New TelefonoClienteTableAdapter

                da.ClienteTableAdapter.Fill(dsDatos.Cliente)
                da.TelefonoClienteTableAdapter.Fill(dsDatos.TelefonoCliente)
            End If

            If Tablas.ToLower.Contains("coche") Then
                dsDatos.Coche.Clear()

                da.CocheTableAdapter = New CocheTableAdapter

                da.CocheTableAdapter.Fill(dsDatos.Coche)
            End If

            If Tablas.ToLower.Contains("historial") Then
                dsDatos.Historial.Clear()

                da.HistorialTableAdapter = New HistorialTableAdapter
                da.HistorialTableAdapter.Fill(dsDatos.Historial)

                IniciarImagenes()

            End If

            If Tablas.ToLower.Contains("pof") Then
                dsDatos.POF.Clear()
                dsDatos.ArticuloPOF.Clear()

                da.POFTableAdapter = New POFTableAdapter
                da.ArticuloPOFTableAdapter = New ArticuloPOFTableAdapter

                da.POFTableAdapter.Fill(dsDatos.POF)
                da.ArticuloPOFTableAdapter.Fill(dsDatos.ArticuloPOF)
            End If
        Catch ex As SqlClient.SqlException
            EsperarSegundos(1)
            Inicializar(Tablas)
        End Try

    End Sub

    Public Sub Inicializar(ByVal Tablas As String, ByVal ds As DatosTallerDataSet)

        ds.EnforceConstraints = False

        If Tablas.ToLower.Contains("cliente") Then
            ds.Cliente.Clear()
            Dim dac As New ClienteTableAdapter
            dac.Fill(ds.Cliente)
        End If

        If Tablas.ToLower.Contains("coche") Then
            ds.Coche.Clear()

            Dim dac As New CocheTableAdapter
            dac.Fill(ds.Coche)
        End If

    End Sub

    Public Sub ActualizarBaseDatos()

        Try
            da.UpdateAll(dsDatos)

            dsDatos.AcceptChanges()

            If dsImg.ImagenHistorial.Rows.Count > 0 Then
                GuardarImagenHistorial()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CerrarBase()
        dsDatos.Cliente.Clear()
        dsDatos.TelefonoCliente.Clear()
        dsDatos.Coche.Clear()
        dsDatos.Historial.Clear()
        dsImg.ImagenHistorial.Rows.Clear()
        dsDatos.POF.Clear()
        dsDatos.ArticuloPOF.Clear()

        da.ClienteTableAdapter = Nothing
        da.TelefonoClienteTableAdapter = Nothing
        da.CocheTableAdapter = Nothing
        da.HistorialTableAdapter = Nothing
        da.POFTableAdapter = Nothing
        da.ArticuloPOFTableAdapter = Nothing
    End Sub

#End Region

#Region "Buscar"

    Public Function CochesTieneUsuario(ByVal IDCliente As Integer) As Integer
        Return dsDatos.Coche.Select("IDCliente=" + IDCliente.ToString).Length - 1
    End Function

    Public Function BuscarHistorialCoche(ByVal IDCoche As Integer) As DatosTallerDataSet.HistorialDataTable

        da.HistorialTableAdapter = New HistorialTableAdapter
        Dim dt As New DatosTallerDataSet.HistorialDataTable

        da.HistorialTableAdapter.FillBy(dt, IDCoche)

        Return dt

    End Function

    Public Function BuscarIDClientebyIDCoche(ByVal IDCoche As Integer) As Integer
        Return da.CocheTableAdapter.ClientebyIDCoche(IDCoche)
    End Function

#End Region

#Region "Borrar"

    Public Sub BorrarCliente(ByVal IDCliente As Integer)

        For Each row As DatosTallerDataSet.CocheRow In dsDatos.Coche.Select("IDCliente=" + IDCliente.ToString)
            BorrarCoche(row.IDCoche)
        Next

        For Each row As DatosTallerDataSet.TelefonoClienteRow In dsDatos.TelefonoCliente.Select("IDCliente=" + IDCliente.ToString)
            BorrarTelefonoCliente(row.IDTelefonoCliente)
        Next

        query.BorrarCliente(IDCliente)
        ActualizarBaseDatos()
    End Sub

    Public Sub BorrarTelefonoCliente(ByVal IDTelefonoCliente As Integer)
        query.BorrarTelefonoCliente(IDTelefonoCliente)
        ActualizarBaseDatos()
    End Sub

    Public Sub BorrarTelefonosVacios()
        query.BorrarTelefonosVacios()
        ActualizarBaseDatos()
    End Sub

    Public Sub BorrarCoche(ByVal IDCoche As Integer)

        For Each row As DatosTallerDataSet.HistorialRow In dsDatos.Historial.Select("IDCoche=" + IDCoche.ToString)
            BorrarHistorial(row.IDHistorial)
        Next

        query.BorrarCoche(IDCoche)
        ActualizarBaseDatos()
    End Sub

    Public Sub BorrarImagenbyHistorial(ByVal IDHistorial As Integer)
        For Each row As ImgData.ImagenHistorialRow In BuscarImagenHistorial(IDHistorial)
            BorrarImagenHistorial(row.IDImagenHistorial, IDHistorial)
        Next
    End Sub

    Public Sub BorrarHistorial(ByVal IDHistorial As Integer)

        For Each row As ImgData.ImagenHistorialRow In BuscarImagenHistorial(IDHistorial)
            BorrarImagenHistorial(row.IDImagenHistorial, IDHistorial)            
        Next

        GuardarImagenHistorial()

        For Each row As DatosTallerDataSet.POFRow In dsDatos.POF.Select("IDHistorial=" + IDHistorial.ToString)
            BorrarPOF(row.IDHistorial)
        Next

        query.BorrarHistorial(IDHistorial)
        ActualizarBaseDatos()
    End Sub

    Public Sub BorrarPOF(ByVal IDPOF As Integer)

        For Each row As DatosTallerDataSet.ArticuloPOFRow In dsDatos.ArticuloPOF.Select("IDHistorial=" + IDPOF.ToString)
            BorrarArticuloPOF(row.IDArticuloPOF)
        Next

        query.BorrarPOF(IDPOF)
        ActualizarBaseDatos()
    End Sub

    Public Sub BorrarArticuloPOF(ByVal IDArticuloPOF As Integer)
        query.BorrarArticuloPOF(IDArticuloPOF)
        ActualizarBaseDatos()
    End Sub

#End Region

End Module
