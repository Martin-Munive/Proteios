Imports System
Imports System.IO
Imports System.Text
Imports System.Net
'*********************************************************************************************************
'//////////////////////////////////////////VARIABLES GLOBALES/////////////////////////////////////////////
'*********************************************************************************************************
Public Class Frm_NCBI_SCRP
    'LA  VARIABLE DEL TRIAL
    Public TrialTime As DateTime

    '*********************************************************************************************************
    '//////////////////////////////CAPTURAR XML DESDE NCBI Y CARGAR LABELS////////////////////////////////////
    '*********************************************************************************************************
    'El codigo siguiente utiliza las herramientas de eutils ofrecidas por el mismo NCBI, hace una llamada a partir
    'del comando efetch pero no descarga un FASTA, descarga un XML, lo carga en una caja de texto enriquecido y usa
    'las etiquetas de XML para buscar las cadenas necesarias y llenar los Labels que se usaran para crear el TXT.
    Private Sub Btn_Get_Data_Click(sender As Object, e As EventArgs) Handles Btn_Get_data.Click
        Direccion = "https://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=" + Cbx_Tip_Ver.Text + "&id=" + Txt_Cod_Ver.Text + "&rettype=gp&retmode=xml"
        'DEFINIENDO LIMITES DE TEXTO
        Dim Definition_H As Long
        Dim Definition_T As Long

        Dim Version_H As Long
        Dim Version_T As Long

        Dim Source_H As Long
        Dim Source_T As Long

        Dim Organism_H As Long
        Dim Organism_T As Long

        Dim Sequence_H As Long
        Dim Sequence_T As Long

        'CAPTURANDO ERROR PARA BASE DE DATOS EQUIVOCADA
        Try
            'CREANDO EL ACCESO A LA PAGINA
            Dim Solicitud As WebRequest = WebRequest.Create(Direccion)
            Dim Respuesta As HttpWebResponse = CType(Solicitud.GetResponse(), HttpWebResponse)
            Dim Flujo_datos As Stream = Respuesta.GetResponseStream
            Dim Lector As New StreamReader(Flujo_datos)
            Cadena_Datos = Lector.ReadToEnd

            'LLENA EL TEXTBOX CON LA BUSQUEDA
            Rtb_Pagina_con.Text = Cadena_Datos

        Catch ex As Exception
            MsgBox("Can't access the server." _
                        & vbNewLine & " " & vbNewLine & "Check if you choosed the right DB.", MsgBoxStyle.Critical, "Somethin is wrong!")
        End Try

        'MSGBOX PARA VERIFICAR LLENADO DE CASILLAS
        Try

            'PASA LOS DATOS A LAS ETIQUETAS
            Definition_H = InStr(Cadena_Datos, "<GBSeq_definition>")
            Definition_T = InStr(Cadena_Datos, "</GBSeq_definition>")
            Lbl_Definition_con.Text = Cadena_Datos.Substring(Definition_H + 17, Definition_T - Definition_H - 18)
            'Variable para escribir
            Definicion = Lbl_Definition_con.Text

            Version_H = InStr(Cadena_Datos, "<GBSeq_accession-version>")
            Version_T = InStr(Cadena_Datos, "</GBSeq_accession-version>")
            Lbl_Version_con.Text = Cadena_Datos.Substring(Version_H + 24, Version_T - Version_H - 25)
            'Variable para escribir
            Version = Lbl_Version_con.Text

            Source_H = InStr(Cadena_Datos, "<GBSeq_source>")
            Source_T = InStr(Cadena_Datos, "</GBSeq_source>")
            Lbl_Source_con.Text = Cadena_Datos.Substring(Source_H + 13, Source_T - Source_H - 14)
            'Variable para escribir
            Fuente = Lbl_Source_con.Text

            Organism_H = InStr(Cadena_Datos, "<GBSeq_organism>")
            Organism_T = InStr(Cadena_Datos, "</GBSeq_organism>")
            Lbl_Organism_con.Text = Cadena_Datos.Substring(Organism_H + 15, Organism_T - Organism_H - 16)
            'Variable para escribir
            Organismo = Lbl_Organism_con.Text

            Sequence_H = InStr(Cadena_Datos, "<GBSeq_sequence>")
            Sequence_T = InStr(Cadena_Datos, "</GBSeq_sequence>")
            Dim Sequence As String = Cadena_Datos.Substring(Sequence_H + 15, Sequence_T - Sequence_H - 16)
            Sequence = Sequence.ToUpper()
            Rtb_Sequence_con.Text = Sequence
            'Variable para escribir
            Secuencia = Rtb_Sequence_con.Text

        Catch ex As Exception
            If Txt_Cod_Ver.Text = "" Then
                MsgBox("Can't access the server." _
                        & vbNewLine & " " & vbNewLine & "Check if the ID Box is empty.", MsgBoxStyle.Critical, "Somethin is wrong!")
            End If
        End Try


        'CREACION DEL CODIGO PERSONALIZADO
        Dim Version_Sin_Punto As String = Lbl_Version_con.Text.Replace(".", "-")
        Lbl_Custom_con.Text = Mid(Lbl_Organism_con.Text, 1, 3) + "_" + Version_Sin_Punto
        'Variable para escribir
        Codigo_FM = Mid(Lbl_Organism_con.Text, 1, 3) + "_" + Version_Sin_Punto

        'ACTIVAR BOTON DE GENERAR ARCHIVO
        Btn_Generate_Fil.Enabled = True

        'COLOREADO DE TEXTO EN EL RICHTEXTBOX
        'Dim Words As New List(Of String)
        'Words.Add("<GBSeq_sequence>")
        'Words.Add("<GBSeq_organism>")
        'Words.Add("<GBSeq_source>")
        'For i As Integer = 0 To Words.Count - 1
        '    Color_Word(Rtb_Pagina_con, Color.Red, Words.Item(i))
        'Next

    End Sub

    'FOCO EN SEGUNDA PESTAÑA PARA BOTON LOAD
    Private Sub Tab_Primera_Enter(sender As Object, e As EventArgs) Handles Tab_Primera.Enter
        If Btn_Load_file.Enabled = True Then
            Btn_Load_file.Enabled = False
        End If

        If Btn_Get_data.Enabled = False Then
            Btn_Get_data.Enabled = True
        End If
    End Sub
    '...
    Private Sub Tab_Segunda_Enter(sender As Object, e As EventArgs) Handles Tab_Segunda.Enter
        If Btn_Load_file.Enabled = False Then
            Btn_Load_file.Enabled = True
        End If

        If Btn_Get_data.Enabled = True Then
            Btn_Get_data.Enabled = False
        End If
    End Sub
    '*********************************************************************************************************
    '/////////////////////////////CARGAR ARCHIVO EN RICHTEXTBOX ORIGIN////////////////////////////////////////
    '*********************************************************************************************************
    Private Sub Btn_Load_file_Click(sender As Object, e As EventArgs) Handles Btn_Load_file.Click
        'CONTROL CAJAS DE TEXTO
        Txt_Directorio.Text = ""
        Txt_Final_Dir.Text = ""
        Txt_Ruta.Text = ""

        'LLENA LAS ETIQUETAS DE FIN DE TRABAJO
        Lbl_SourDoc_con.Text = ""
        Lbl_FiltDoc_con.Text = ""
        Lbl_Location_con.Text = ""
        Lbl_TotSrc_con.Text = ""
        Lbl_TotFil_con.Text = ""

        '-----------------------------------------------------------------------------------------------------
        'PROCESO
        Dim Datos As Stream = Nothing
        Dim Abrir As New OpenFileDialog()
        Dim Ruta_Archivo As String

        'Abre el cuadro de dialogos directamente en el escritorio.
        Abrir.InitialDirectory = (System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop))

        'Tipos de archivos que mostrara para abrir.
        Abrir.Filter = "txt files (*.txt)|*.txt | FASTA files (*.FASTA)|*.FASTA"
        Abrir.FilterIndex = 2
        Abrir.RestoreDirectory = True

        '-----------------------------------------------------------------------------------------------------
        'ABRIR EL FORMULARIO DE SECUENCIA OBJETIVO
        Dim Form As New Frm_Target
        Form = Frm_Target
        Frm_Target.ShowDialog()

        '-----------------------------------------------------------------------------------------------------
        'ADQUIRIR CADENAS DE RUTAS
        If Abrir.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Datos = Abrir.OpenFile()
                If (Datos IsNot Nothing) Then
                    'Obtener la ruta del archivo y colocarla en el Txt.
                    Txt_Ruta.Text = Abrir.FileName
                    'Obtener unicamente el Directorio sin el nombre del archivo.
                    Ruta_Archivo = Path.GetDirectoryName(Abrir.FileName)
                    'Pasar el Directorio a una etiqueta
                    Txt_Directorio.Text = Ruta_Archivo
                    'Habilitar Botones de Aplicacion
                    'Btn_Translate.Enabled = True

                    ' Load the contents of the file into the RichTextBox.
                    'Rtb_Source_con.LoadFile(Abrir.FileName,
                    'RichTextBoxStreamType.PlainText)

                End If
                'Catch Ex As Exception
                '    MessageBox.Show("No es posible leer desde el disco: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (Datos IsNot Nothing) Then
                    Datos.Close()
                End If
            End Try
        End If
        '-----------------------------------------------------------------------------------------------------

        'Pasar la ruta del archivo a una variable.
        Dim Ruta_de_Archivo As String = Txt_Ruta.Text

        'Extraer el nombre del archivo.
        Dim Nombre_de_Archivo As String = Ruta_de_Archivo.Substring(InStrRev(Ruta_de_Archivo, "\"))
        'Esta es una variable GLOBAL para imprimir este nombre en la CABECERA
        Nombre_Archivo_Cabecera = Nombre_de_Archivo

        'Obtener unicamente el Directorio sin el nombre del archivo de la etiqueta.
        Dim Directorio_de_Archivo As String = Txt_Directorio.Text

        'Extraer el nombre del archivo sin extension.
        Dim Nombre_del_Archivo As String = Path.GetFileNameWithoutExtension(Txt_Ruta.Text)

        'Esta ruta es temporal para el proceso de Traduccion.
        Dim Ruta_copia As String = Ruta_de_Archivo & "Resultado.txt"

        'Ruta y Nombre final que se utilizara para crear el archivo traducido.
        Dim Ruta_Final As String = Directorio_de_Archivo & "\" & Nombre_del_Archivo & " - " & Secuencia_Target & " - Filtered.txt"

        '-----------------------------------------------------------------------------------------------------
        'CONTAR LA CANTIDAD DE SECUENCIAS A PARTIR DE LOS ">"
        'LECTOR Y ESCRITOR DEL ARCHIVO

        'Crear un lector
        Dim Leer As StreamReader
        'Crea un escritor
        Dim Agregar As StreamWriter

        'INICIO DEL CATCH PARA CUANDO NO SE SELECCIONA ARCHIVO
        Try
            'Leer el archivo por la ruta
            Leer = New StreamReader(Ruta_de_Archivo)
            Txt_Final_Dir.Text = Ruta_Final

            'Escribe el archivo de la ruta
            Agregar = New StreamWriter(Ruta_Final)

            'Variable con nombre y ruta de la copia
            Dim Copia_Temporal As String = Ruta_copia
            'Variable con el numero de lineas del archivo
            Dim nLineas As Integer = File.ReadAllLines(Ruta_de_Archivo).Length

            'COMENZAR A LEER
            'Comprobando si existe el archivo
            If File.Exists(Copia_Temporal) = False Then
                'Variable de control para leer la primera linea

                ' *** PROCESO PRINCIPAL ***
                'Leer linea a linea hasta el final
                While Contador_Lineas <= nLineas And Not Leer.EndOfStream
                    Dim Linea As String = Leer.ReadLine
                    'Etiqueta de la Barra de Progreso

                    'Para identificar las cabeceras >
                    Dim Primera As String
                    Dim Cabecera As String
                    Primera = Mid(Linea, 1, 1)

                    'Para Saltarse las Cabeceras
                    If Primera = ">" Then
                        Contador_Secuencias = Contador_Secuencias + 1
                        Cabecera = Linea

                        'Copia las secuencias 
                    ElseIf String.IsNullOrEmpty(Linea) = False And Linea <> ">" Then
                        Secuencia_Acumulada = Secuencia_Acumulada + Linea

                        'Un espacio en blanco es el final de una secuencia
                    ElseIf String.IsNullOrEmpty(Linea) Then
                        'Se crea una variable para verificar la existencia de la secuencia objetivo
                        Dim Confirmar_Target As Integer = Secuencia_Acumulada.IndexOf(Secuencia_Target)
                        'Se crean acciones si la secuencia no está
                        If Confirmar_Target = -1 Then
                            'MsgBox("NO")
                        Else
                            'MsgBox("SI")
                            Contador_Targets = Contador_Targets + 1
                            Agregar.WriteLine(Cabecera)
                            Agregar.WriteLine(Secuencia_Acumulada)
                            Agregar.WriteLine("")

                        End If
                        'MsgBox(Contador_Secuencias & vbNewLine & Secuencia_Target & vbNewLine & Secuencia_Acumulada, , )
                        Secuencia_Acumulada = ""
                        Continue While
                    End If

                End While
                Agregar.Close()
                'LLENA LAS ETIQUETAS DE FIN DE TRABAJO
                Lbl_SourDoc_con.Text = Nombre_del_Archivo
                Lbl_FiltDoc_con.Text = Nombre_del_Archivo & " - " & Secuencia_Target & " - Filtered.txt"
                Lbl_Location_con.Text = Ruta_Archivo
                Lbl_TotSrc_con.Text = Contador_Secuencias
                Lbl_TotFil_con.Text = Contador_Targets
                Dim Porcentaje As Integer = (Contador_Targets * 100) / Contador_Secuencias
                Lbl_Percent.Text = Porcentaje & " %"
                MsgBox("The file has been created!" _
                       & vbNewLine & " " & vbNewLine & "The file is in the source file's folder.", MsgBoxStyle.Information, "Done!")
            End If
            'FIN DEL CATCH PARA CUANDO NO SE SELECCIONA ARCHIVO
        Catch
            MsgBox("Can't find a file path!" _
                       & vbNewLine & " " & vbNewLine & "You must select a file.", MsgBoxStyle.Critical, "Somethin is wrong!")
        End Try
    End Sub
    '*********************************************************************************************************
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '*********************************************************************************************************
    Private Sub Btn_Process_Click(sender As Object, e As EventArgs) Handles Btn_Process.Click
        'Dim Sequence_Filter As String = Rtb_Source_con.Text
        'Rtb_Filter_con.Text = Sequence_Filter
    End Sub
    '*********************************************************************************************************
    '///////////////////////////////GENERAR ARCHIVOS DE SUMARIO//////////////////////////////////////////////
    '*********************************************************************************************************
    Private Sub Btn_Generate_Fil_Click(sender As Object, e As EventArgs) Handles Btn_Generate_Fil.Click
        'ELECCION DEL TIPO DE ARCHIVO
        'MENSAJE DE EXITO
        ' Initializes variables to pass to the MessageBox.Show method.

        Dim Message As String = "Make a FASTA file for filter process?" & vbNewLine & " " & vbNewLine & "Yes for FASTA file, No for TXT file."
        Dim Caption As String = "Choose Filetype!"
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim Result As DialogResult

        'Displays the MessageBox
        Result = MessageBox.Show(Message, Caption, Buttons, MessageBoxIcon.Question)

        ' Gets the result of the MessageBox display.
        If Result = System.Windows.Forms.DialogResult.Yes Then
            'Establecer la ruta (Escritorio)
            Dim Escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim Ruta As String = Escritorio + "\" + Lbl_Custom_con.Text + ".FASTA"

            ''Crear el archivo
            'Dim Archivo As FileStream = File.Create(Ruta)

            'Agregar lineas al archivo
            Dim Escribir = New StreamWriter(Ruta)
            Escribir.WriteLine(">" + Codigo_FM)
            Escribir.WriteLine(Secuencia)
            Escribir.Close()

            'MENSAJE DE EXITO
            MsgBox("Done." _
                        & vbNewLine & " " & vbNewLine & "The file is in your Desktop.", MsgBoxStyle.Information, "Success!")

            'DESACTIVAR BOTON DE GENERAR ARCHIVO
            Btn_Generate_Fil.Enabled = False
        Else
            'Establecer la ruta (Escritorio)
            Dim Escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim Ruta As String = Escritorio + "\" + Lbl_Custom_con.Text + ".txt"

            ''Crear el archivo
            'Dim Archivo As FileStream = File.Create(Ruta)

            'Agregar lineas al archivo
            Dim Escribir = New StreamWriter(Ruta)
            Escribir.WriteLine(Codigo_FM + "," + Version + "," + Definicion + "," + Organismo + "," + Secuencia)
            Escribir.Close()

            'MENSAJE DE EXITO
            MsgBox("Done." _
                            & vbNewLine & " " & vbNewLine & "The file is in your Desktop.", MsgBoxStyle.Information, "Success!")

            'DESACTIVAR BOTON DE GENERAR ARCHIVO
            Btn_Generate_Fil.Enabled = False

        End If

    End Sub
    '*********************************************************************************************************
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////
    '*********************************************************************************************************
    'UNIR MULTIPLES DOCUMENTOS
    Private Sub Btn_Merge_Fil_Click(sender As Object, e As EventArgs) Handles Btn_Merge_Fil.Click
        Dim Paths() As String = Directory.GetFiles("C:\Users\Lex\Desktop\Proyecto - Uni Job\Cine y Cuentos\001\Nueva carpeta", "*.txt")

    End Sub

    '*********************************************************************************************************
    '//////////////////////////////AL CARGAR FORMULARIO SE EVALUA EL TRIAL////////////////////////////////////
    '*********************************************************************************************************
    Private Sub Frm_NCBI_SCRP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '******************************************************
        'SE SUPONE QUE EL TRIAL
        '******************************************************
        TrialTime = DateTime.Now

        If Not My.Settings.Checked Then
            My.Settings.TrialTime = TrialTime
            My.Settings.Checked = True
        Else
            If My.Settings.TrialTime.Add(New TimeSpan(360, 0, 0, 0)) > DateTime.Now Then
                'No pasa nada, sigue activo el tiempo.
            Else
                Me.Tbc_General.Enabled = False
                Me.Txt_Cod_Ver.Enabled = False
                Me.Btn_Get_data.Enabled = False
                'Me.Btn_Load_file.Enabled = False
                Me.Btn_Generate_Fil.Enabled = False
                Me.Btn_Process.Enabled = False
                Me.Btn_Merge_Fil.Enabled = False
                Me.Cbx_Tip_Ver.Enabled = False
            End If
        End If

        '*********************************************************
    End Sub

    '*********************************************************************************************************
    '/////////////////////////////////////////LLAMADA AL ABOUT////////////////////////////////////////////////
    '*********************************************************************************************************
    Private Sub Img_GenLog_Click(sender As Object, e As EventArgs) Handles Img_GenLog.Click
        Dim Form As New Frm_About
        Form = Frm_About
        Frm_About.ShowDialog()
    End Sub
End Class
