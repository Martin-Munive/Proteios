Module Variables_Globales

    'Dirección de la página
    Public Direccion As String
    Public Cadena_Datos As String

    'Variables a Escribir en archivo
    Public Definicion As String
    Public Version As String
    Public Fuente As String
    Public Organismo As String
    Public Secuencia As String
    Public Codigo_FM As String

    'Variables adquirir archivo para filtrar
    Public Ruta_Archivo_I As String = ""
    Public Ruta_Archivo_II As String = ""
    Public Nombre_Archivo_Cabecera As String = ""

    'Variables de Lectura del archivo a Filtrar
    Public Contador_Lineas As Integer = 0
    Public Contador_Secuencias As Integer = 0
    Public Contador_Targets As Integer = 0
    Public Secuencia_Acumulada As String = ""
    Public Secuencia_Target As String = ""

End Module
