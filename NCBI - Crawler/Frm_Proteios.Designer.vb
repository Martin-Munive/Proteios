<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_NCBI_SCRP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Txt_Cod_Ver = New System.Windows.Forms.TextBox()
        Me.Lbl_ID = New System.Windows.Forms.Label()
        Me.Cbx_Tip_Ver = New System.Windows.Forms.ComboBox()
        Me.Btn_Get_data = New System.Windows.Forms.Button()
        Me.Rtb_Pagina_con = New System.Windows.Forms.RichTextBox()
        Me.Lbl_Source_con = New System.Windows.Forms.Label()
        Me.Lbl_Source_lbl = New System.Windows.Forms.Label()
        Me.Lbl_DB = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Custom_con = New System.Windows.Forms.Label()
        Me.Lbl_Custom_cod = New System.Windows.Forms.Label()
        Me.Rtb_Sequence_con = New System.Windows.Forms.RichTextBox()
        Me.Lbl_Sequence_lbl = New System.Windows.Forms.Label()
        Me.Lbl_Organism_lbl = New System.Windows.Forms.Label()
        Me.Lbl_Organism_con = New System.Windows.Forms.Label()
        Me.Lbl_Version_lbl = New System.Windows.Forms.Label()
        Me.Lbl_Version_con = New System.Windows.Forms.Label()
        Me.Lbl_Definition_lbl = New System.Windows.Forms.Label()
        Me.Lbl_Definition_con = New System.Windows.Forms.Label()
        Me.Fox = New System.Windows.Forms.Label()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Tbc_General = New System.Windows.Forms.TabControl()
        Me.Tab_Primera = New System.Windows.Forms.TabPage()
        Me.Tab_Segunda = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Source_doc = New System.Windows.Forms.Label()
        Me.Lbl_Percent = New System.Windows.Forms.Label()
        Me.Lbl_Location_con = New System.Windows.Forms.Label()
        Me.Lbl_TotFil_con = New System.Windows.Forms.Label()
        Me.Lbl_Location = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_SourDoc_con = New System.Windows.Forms.Label()
        Me.Lbl_Total_src = New System.Windows.Forms.Label()
        Me.Lbl_FiltDoc_con = New System.Windows.Forms.Label()
        Me.Lbl_TotSrc_con = New System.Windows.Forms.Label()
        Me.Lbl_Final_fil = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Btn_Load_file = New System.Windows.Forms.Button()
        Me.Btn_Generate_Fil = New System.Windows.Forms.Button()
        Me.Btn_Process = New System.Windows.Forms.Button()
        Me.Btn_Merge_Fil = New System.Windows.Forms.Button()
        Me.Txt_Ruta = New System.Windows.Forms.TextBox()
        Me.Txt_Directorio = New System.Windows.Forms.TextBox()
        Me.Txt_Final_Dir = New System.Windows.Forms.TextBox()
        Me.Img_GenLog = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Tbc_General.SuspendLayout()
        Me.Tab_Primera.SuspendLayout()
        Me.Tab_Segunda.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Img_GenLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Cod_Ver
        '
        Me.Txt_Cod_Ver.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Txt_Cod_Ver.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cod_Ver.ForeColor = System.Drawing.Color.Azure
        Me.Txt_Cod_Ver.Location = New System.Drawing.Point(9, 86)
        Me.Txt_Cod_Ver.Name = "Txt_Cod_Ver"
        Me.Txt_Cod_Ver.Size = New System.Drawing.Size(203, 22)
        Me.Txt_Cod_Ver.TabIndex = 0
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Lbl_ID.Location = New System.Drawing.Point(8, 67)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(19, 15)
        Me.Lbl_ID.TabIndex = 1
        Me.Lbl_ID.Text = "ID"
        '
        'Cbx_Tip_Ver
        '
        Me.Cbx_Tip_Ver.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Cbx_Tip_Ver.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Tip_Ver.ForeColor = System.Drawing.Color.Azure
        Me.Cbx_Tip_Ver.FormattingEnabled = True
        Me.Cbx_Tip_Ver.Items.AddRange(New Object() {"pubmed", "protein", "nuccore", "ipg", "nucleotide", "nucgss", "nucest", "structure", "sparcle", "genome", "annotinfo", "assembly", "bioproject", "biosample", "blastdbinfo", "books", "cdd", "clinvar", "clone", "gap", "gapplus", "grasp", "dbvar", "gene", "gds", "geoprofiles", "homologene", "medgen", "mesh", "ncbisearch", "nlmcatalog", "omim", "orgtrack", "pmc", "popset", "probe", "proteinclusters", "pcassay", "biosystems", "pccompound", "pcsubstance", "seqannot", "snp", "sra", "taxonomy", "biocollections", "unigene", "gencoll", "gtr"})
        Me.Cbx_Tip_Ver.Location = New System.Drawing.Point(221, 85)
        Me.Cbx_Tip_Ver.Name = "Cbx_Tip_Ver"
        Me.Cbx_Tip_Ver.Size = New System.Drawing.Size(145, 22)
        Me.Cbx_Tip_Ver.TabIndex = 3
        Me.Cbx_Tip_Ver.Text = "protein"
        '
        'Btn_Get_data
        '
        Me.Btn_Get_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Get_data.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Get_data.ForeColor = System.Drawing.Color.Azure
        Me.Btn_Get_data.Location = New System.Drawing.Point(379, 83)
        Me.Btn_Get_data.Name = "Btn_Get_data"
        Me.Btn_Get_data.Size = New System.Drawing.Size(102, 23)
        Me.Btn_Get_data.TabIndex = 4
        Me.Btn_Get_data.Text = "GET"
        Me.Btn_Get_data.UseVisualStyleBackColor = True
        '
        'Rtb_Pagina_con
        '
        Me.Rtb_Pagina_con.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Rtb_Pagina_con.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Rtb_Pagina_con.ForeColor = System.Drawing.Color.Azure
        Me.Rtb_Pagina_con.Location = New System.Drawing.Point(379, 54)
        Me.Rtb_Pagina_con.Name = "Rtb_Pagina_con"
        Me.Rtb_Pagina_con.Size = New System.Drawing.Size(210, 23)
        Me.Rtb_Pagina_con.TabIndex = 5
        Me.Rtb_Pagina_con.Text = ""
        Me.Rtb_Pagina_con.Visible = False
        '
        'Lbl_Source_con
        '
        Me.Lbl_Source_con.AutoSize = True
        Me.Lbl_Source_con.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Source_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_Source_con.Location = New System.Drawing.Point(6, 116)
        Me.Lbl_Source_con.Name = "Lbl_Source_con"
        Me.Lbl_Source_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_Source_con.TabIndex = 6
        Me.Lbl_Source_con.Text = "..."
        '
        'Lbl_Source_lbl
        '
        Me.Lbl_Source_lbl.AutoSize = True
        Me.Lbl_Source_lbl.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Source_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Source_lbl.Location = New System.Drawing.Point(6, 102)
        Me.Lbl_Source_lbl.Name = "Lbl_Source_lbl"
        Me.Lbl_Source_lbl.Size = New System.Drawing.Size(46, 15)
        Me.Lbl_Source_lbl.TabIndex = 7
        Me.Lbl_Source_lbl.Text = "Source"
        '
        'Lbl_DB
        '
        Me.Lbl_DB.AutoSize = True
        Me.Lbl_DB.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Lbl_DB.Location = New System.Drawing.Point(221, 67)
        Me.Lbl_DB.Name = "Lbl_DB"
        Me.Lbl_DB.Size = New System.Drawing.Size(61, 15)
        Me.Lbl_DB.TabIndex = 8
        Me.Lbl_DB.Text = "Data Base"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Lbl_Custom_con)
        Me.GroupBox1.Controls.Add(Me.Lbl_Custom_cod)
        Me.GroupBox1.Controls.Add(Me.Rtb_Sequence_con)
        Me.GroupBox1.Controls.Add(Me.Lbl_Sequence_lbl)
        Me.GroupBox1.Controls.Add(Me.Lbl_Organism_lbl)
        Me.GroupBox1.Controls.Add(Me.Lbl_Organism_con)
        Me.GroupBox1.Controls.Add(Me.Lbl_Version_lbl)
        Me.GroupBox1.Controls.Add(Me.Lbl_Version_con)
        Me.GroupBox1.Controls.Add(Me.Lbl_Definition_lbl)
        Me.GroupBox1.Controls.Add(Me.Lbl_Definition_con)
        Me.GroupBox1.Controls.Add(Me.Lbl_Source_lbl)
        Me.GroupBox1.Controls.Add(Me.Lbl_Source_con)
        Me.GroupBox1.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 355)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Sumary"
        '
        'Lbl_Custom_con
        '
        Me.Lbl_Custom_con.AutoSize = True
        Me.Lbl_Custom_con.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Custom_con.ForeColor = System.Drawing.Color.Khaki
        Me.Lbl_Custom_con.Location = New System.Drawing.Point(540, 42)
        Me.Lbl_Custom_con.Name = "Lbl_Custom_con"
        Me.Lbl_Custom_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_Custom_con.TabIndex = 23
        Me.Lbl_Custom_con.Text = "..."
        '
        'Lbl_Custom_cod
        '
        Me.Lbl_Custom_cod.AutoSize = True
        Me.Lbl_Custom_cod.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Custom_cod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Lbl_Custom_cod.Location = New System.Drawing.Point(538, 27)
        Me.Lbl_Custom_cod.Name = "Lbl_Custom_cod"
        Me.Lbl_Custom_cod.Size = New System.Drawing.Size(80, 15)
        Me.Lbl_Custom_cod.TabIndex = 22
        Me.Lbl_Custom_cod.Text = "Custom Code"
        '
        'Rtb_Sequence_con
        '
        Me.Rtb_Sequence_con.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Rtb_Sequence_con.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rtb_Sequence_con.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtb_Sequence_con.ForeColor = System.Drawing.Color.Azure
        Me.Rtb_Sequence_con.Location = New System.Drawing.Point(9, 194)
        Me.Rtb_Sequence_con.Name = "Rtb_Sequence_con"
        Me.Rtb_Sequence_con.Size = New System.Drawing.Size(701, 150)
        Me.Rtb_Sequence_con.TabIndex = 15
        Me.Rtb_Sequence_con.Text = "..."
        '
        'Lbl_Sequence_lbl
        '
        Me.Lbl_Sequence_lbl.AutoSize = True
        Me.Lbl_Sequence_lbl.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sequence_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Sequence_lbl.Location = New System.Drawing.Point(7, 175)
        Me.Lbl_Sequence_lbl.Name = "Lbl_Sequence_lbl"
        Me.Lbl_Sequence_lbl.Size = New System.Drawing.Size(62, 15)
        Me.Lbl_Sequence_lbl.TabIndex = 14
        Me.Lbl_Sequence_lbl.Text = "Sequence"
        '
        'Lbl_Organism_lbl
        '
        Me.Lbl_Organism_lbl.AutoSize = True
        Me.Lbl_Organism_lbl.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Organism_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Organism_lbl.Location = New System.Drawing.Point(6, 138)
        Me.Lbl_Organism_lbl.Name = "Lbl_Organism_lbl"
        Me.Lbl_Organism_lbl.Size = New System.Drawing.Size(60, 15)
        Me.Lbl_Organism_lbl.TabIndex = 13
        Me.Lbl_Organism_lbl.Text = "Organism"
        '
        'Lbl_Organism_con
        '
        Me.Lbl_Organism_con.AutoSize = True
        Me.Lbl_Organism_con.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Organism_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_Organism_con.Location = New System.Drawing.Point(6, 152)
        Me.Lbl_Organism_con.Name = "Lbl_Organism_con"
        Me.Lbl_Organism_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_Organism_con.TabIndex = 12
        Me.Lbl_Organism_con.Text = "..."
        '
        'Lbl_Version_lbl
        '
        Me.Lbl_Version_lbl.AutoSize = True
        Me.Lbl_Version_lbl.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Version_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Version_lbl.Location = New System.Drawing.Point(6, 65)
        Me.Lbl_Version_lbl.Name = "Lbl_Version_lbl"
        Me.Lbl_Version_lbl.Size = New System.Drawing.Size(48, 15)
        Me.Lbl_Version_lbl.TabIndex = 11
        Me.Lbl_Version_lbl.Text = "Version"
        '
        'Lbl_Version_con
        '
        Me.Lbl_Version_con.AutoSize = True
        Me.Lbl_Version_con.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Version_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_Version_con.Location = New System.Drawing.Point(6, 80)
        Me.Lbl_Version_con.Name = "Lbl_Version_con"
        Me.Lbl_Version_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_Version_con.TabIndex = 10
        Me.Lbl_Version_con.Text = "..."
        '
        'Lbl_Definition_lbl
        '
        Me.Lbl_Definition_lbl.AutoSize = True
        Me.Lbl_Definition_lbl.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Definition_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Definition_lbl.Location = New System.Drawing.Point(6, 27)
        Me.Lbl_Definition_lbl.Name = "Lbl_Definition_lbl"
        Me.Lbl_Definition_lbl.Size = New System.Drawing.Size(62, 15)
        Me.Lbl_Definition_lbl.TabIndex = 9
        Me.Lbl_Definition_lbl.Text = "Definition"
        '
        'Lbl_Definition_con
        '
        Me.Lbl_Definition_con.AutoSize = True
        Me.Lbl_Definition_con.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Definition_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_Definition_con.Location = New System.Drawing.Point(6, 42)
        Me.Lbl_Definition_con.Name = "Lbl_Definition_con"
        Me.Lbl_Definition_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_Definition_con.TabIndex = 8
        Me.Lbl_Definition_con.Text = "..."
        '
        'Fox
        '
        Me.Fox.AutoSize = True
        Me.Fox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Fox.Location = New System.Drawing.Point(682, 65)
        Me.Fox.Name = "Fox"
        Me.Fox.Size = New System.Drawing.Size(27, 12)
        Me.Fox.TabIndex = 17
        Me.Fox.Text = "-Fox-"
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(12, 12)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(211, 36)
        Me.Lbl_Titulo.TabIndex = 18
        Me.Lbl_Titulo.Text = "FOX - PROTEIOS"
        '
        'Tbc_General
        '
        Me.Tbc_General.Controls.Add(Me.Tab_Primera)
        Me.Tbc_General.Controls.Add(Me.Tab_Segunda)
        Me.Tbc_General.Controls.Add(Me.TabPage1)
        Me.Tbc_General.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbc_General.Location = New System.Drawing.Point(9, 114)
        Me.Tbc_General.Name = "Tbc_General"
        Me.Tbc_General.SelectedIndex = 0
        Me.Tbc_General.Size = New System.Drawing.Size(741, 402)
        Me.Tbc_General.TabIndex = 16
        '
        'Tab_Primera
        '
        Me.Tab_Primera.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Tab_Primera.Controls.Add(Me.GroupBox1)
        Me.Tab_Primera.Location = New System.Drawing.Point(4, 23)
        Me.Tab_Primera.Name = "Tab_Primera"
        Me.Tab_Primera.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Primera.Size = New System.Drawing.Size(733, 375)
        Me.Tab_Primera.TabIndex = 1
        Me.Tab_Primera.Text = "DB Search"
        '
        'Tab_Segunda
        '
        Me.Tab_Segunda.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Tab_Segunda.Controls.Add(Me.GroupBox2)
        Me.Tab_Segunda.Location = New System.Drawing.Point(4, 23)
        Me.Tab_Segunda.Name = "Tab_Segunda"
        Me.Tab_Segunda.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Segunda.Size = New System.Drawing.Size(733, 375)
        Me.Tab_Segunda.TabIndex = 2
        Me.Tab_Segunda.Text = "Sequence Filter"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Lbl_Source_doc)
        Me.GroupBox2.Controls.Add(Me.Lbl_Percent)
        Me.GroupBox2.Controls.Add(Me.Lbl_Location_con)
        Me.GroupBox2.Controls.Add(Me.Lbl_TotFil_con)
        Me.GroupBox2.Controls.Add(Me.Lbl_Location)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Lbl_SourDoc_con)
        Me.GroupBox2.Controls.Add(Me.Lbl_Total_src)
        Me.GroupBox2.Controls.Add(Me.Lbl_FiltDoc_con)
        Me.GroupBox2.Controls.Add(Me.Lbl_TotSrc_con)
        Me.GroupBox2.Controls.Add(Me.Lbl_Final_fil)
        Me.GroupBox2.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(716, 355)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Sumary"
        '
        'Lbl_Source_doc
        '
        Me.Lbl_Source_doc.AutoSize = True
        Me.Lbl_Source_doc.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Lbl_Source_doc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Source_doc.Location = New System.Drawing.Point(6, 29)
        Me.Lbl_Source_doc.Name = "Lbl_Source_doc"
        Me.Lbl_Source_doc.Size = New System.Drawing.Size(106, 15)
        Me.Lbl_Source_doc.TabIndex = 22
        Me.Lbl_Source_doc.Text = "Source document"
        '
        'Lbl_Percent
        '
        Me.Lbl_Percent.AutoSize = True
        Me.Lbl_Percent.Font = New System.Drawing.Font("Candara", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Lbl_Percent.Location = New System.Drawing.Point(477, 222)
        Me.Lbl_Percent.Name = "Lbl_Percent"
        Me.Lbl_Percent.Size = New System.Drawing.Size(0, 97)
        Me.Lbl_Percent.TabIndex = 29
        '
        'Lbl_Location_con
        '
        Me.Lbl_Location_con.AutoSize = True
        Me.Lbl_Location_con.Font = New System.Drawing.Font("Candara", 9.0!)
        Me.Lbl_Location_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_Location_con.Location = New System.Drawing.Point(6, 149)
        Me.Lbl_Location_con.Name = "Lbl_Location_con"
        Me.Lbl_Location_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_Location_con.TabIndex = 19
        Me.Lbl_Location_con.Text = "..."
        '
        'Lbl_TotFil_con
        '
        Me.Lbl_TotFil_con.AutoSize = True
        Me.Lbl_TotFil_con.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TotFil_con.Font = New System.Drawing.Font("Candara", 9.0!)
        Me.Lbl_TotFil_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_TotFil_con.Location = New System.Drawing.Point(7, 253)
        Me.Lbl_TotFil_con.Name = "Lbl_TotFil_con"
        Me.Lbl_TotFil_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_TotFil_con.TabIndex = 28
        Me.Lbl_TotFil_con.Text = "..."
        '
        'Lbl_Location
        '
        Me.Lbl_Location.AutoSize = True
        Me.Lbl_Location.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Lbl_Location.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Location.Location = New System.Drawing.Point(6, 133)
        Me.Lbl_Location.Name = "Lbl_Location"
        Me.Lbl_Location.Size = New System.Drawing.Size(54, 15)
        Me.Lbl_Location.TabIndex = 20
        Me.Lbl_Location.Text = "Location"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Total sequences (Filtered document)"
        '
        'Lbl_SourDoc_con
        '
        Me.Lbl_SourDoc_con.AutoSize = True
        Me.Lbl_SourDoc_con.Font = New System.Drawing.Font("Candara", 9.0!)
        Me.Lbl_SourDoc_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_SourDoc_con.Location = New System.Drawing.Point(6, 46)
        Me.Lbl_SourDoc_con.Name = "Lbl_SourDoc_con"
        Me.Lbl_SourDoc_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_SourDoc_con.TabIndex = 21
        Me.Lbl_SourDoc_con.Text = "..."
        '
        'Lbl_Total_src
        '
        Me.Lbl_Total_src.AutoSize = True
        Me.Lbl_Total_src.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Lbl_Total_src.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Total_src.Location = New System.Drawing.Point(6, 183)
        Me.Lbl_Total_src.Name = "Lbl_Total_src"
        Me.Lbl_Total_src.Size = New System.Drawing.Size(207, 15)
        Me.Lbl_Total_src.TabIndex = 26
        Me.Lbl_Total_src.Text = "Total sequences (Source document)"
        '
        'Lbl_FiltDoc_con
        '
        Me.Lbl_FiltDoc_con.AutoSize = True
        Me.Lbl_FiltDoc_con.Font = New System.Drawing.Font("Candara", 9.0!)
        Me.Lbl_FiltDoc_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_FiltDoc_con.Location = New System.Drawing.Point(6, 100)
        Me.Lbl_FiltDoc_con.Name = "Lbl_FiltDoc_con"
        Me.Lbl_FiltDoc_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_FiltDoc_con.TabIndex = 23
        Me.Lbl_FiltDoc_con.Text = "..."
        '
        'Lbl_TotSrc_con
        '
        Me.Lbl_TotSrc_con.AutoSize = True
        Me.Lbl_TotSrc_con.Font = New System.Drawing.Font("Candara", 9.0!)
        Me.Lbl_TotSrc_con.ForeColor = System.Drawing.Color.Azure
        Me.Lbl_TotSrc_con.Location = New System.Drawing.Point(6, 199)
        Me.Lbl_TotSrc_con.Name = "Lbl_TotSrc_con"
        Me.Lbl_TotSrc_con.Size = New System.Drawing.Size(16, 14)
        Me.Lbl_TotSrc_con.TabIndex = 25
        Me.Lbl_TotSrc_con.Text = "..."
        '
        'Lbl_Final_fil
        '
        Me.Lbl_Final_fil.AutoSize = True
        Me.Lbl_Final_fil.Font = New System.Drawing.Font("Candara", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Lbl_Final_fil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Lbl_Final_fil.Location = New System.Drawing.Point(6, 83)
        Me.Lbl_Final_fil.Name = "Lbl_Final_fil"
        Me.Lbl_Final_fil.Size = New System.Drawing.Size(110, 15)
        Me.Lbl_Final_fil.TabIndex = 24
        Me.Lbl_Final_fil.Text = "Filtered document"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(733, 375)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Multiplex"
        '
        'Btn_Load_file
        '
        Me.Btn_Load_file.Enabled = False
        Me.Btn_Load_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Load_file.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Load_file.ForeColor = System.Drawing.Color.Azure
        Me.Btn_Load_file.Location = New System.Drawing.Point(487, 83)
        Me.Btn_Load_file.Name = "Btn_Load_file"
        Me.Btn_Load_file.Size = New System.Drawing.Size(102, 23)
        Me.Btn_Load_file.TabIndex = 19
        Me.Btn_Load_file.Text = "LOAD FILE"
        Me.Btn_Load_file.UseVisualStyleBackColor = True
        '
        'Btn_Generate_Fil
        '
        Me.Btn_Generate_Fil.Enabled = False
        Me.Btn_Generate_Fil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Generate_Fil.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Generate_Fil.ForeColor = System.Drawing.Color.Azure
        Me.Btn_Generate_Fil.Location = New System.Drawing.Point(536, 526)
        Me.Btn_Generate_Fil.Name = "Btn_Generate_Fil"
        Me.Btn_Generate_Fil.Size = New System.Drawing.Size(102, 23)
        Me.Btn_Generate_Fil.TabIndex = 21
        Me.Btn_Generate_Fil.Text = "GENERATE FILE"
        Me.Btn_Generate_Fil.UseVisualStyleBackColor = True
        '
        'Btn_Process
        '
        Me.Btn_Process.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Process.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Process.ForeColor = System.Drawing.Color.Azure
        Me.Btn_Process.Location = New System.Drawing.Point(428, 526)
        Me.Btn_Process.Name = "Btn_Process"
        Me.Btn_Process.Size = New System.Drawing.Size(102, 23)
        Me.Btn_Process.TabIndex = 20
        Me.Btn_Process.Text = "PROCESS"
        Me.Btn_Process.UseVisualStyleBackColor = True
        Me.Btn_Process.Visible = False
        '
        'Btn_Merge_Fil
        '
        Me.Btn_Merge_Fil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Merge_Fil.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Merge_Fil.ForeColor = System.Drawing.Color.Azure
        Me.Btn_Merge_Fil.Location = New System.Drawing.Point(644, 526)
        Me.Btn_Merge_Fil.Name = "Btn_Merge_Fil"
        Me.Btn_Merge_Fil.Size = New System.Drawing.Size(102, 23)
        Me.Btn_Merge_Fil.TabIndex = 22
        Me.Btn_Merge_Fil.Text = "MERGE FILES"
        Me.Btn_Merge_Fil.UseVisualStyleBackColor = True
        Me.Btn_Merge_Fil.Visible = False
        '
        'Txt_Ruta
        '
        Me.Txt_Ruta.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Txt_Ruta.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Ruta.ForeColor = System.Drawing.Color.Azure
        Me.Txt_Ruta.Location = New System.Drawing.Point(379, 30)
        Me.Txt_Ruta.Name = "Txt_Ruta"
        Me.Txt_Ruta.Size = New System.Drawing.Size(210, 22)
        Me.Txt_Ruta.TabIndex = 23
        Me.Txt_Ruta.Visible = False
        '
        'Txt_Directorio
        '
        Me.Txt_Directorio.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Txt_Directorio.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Directorio.ForeColor = System.Drawing.Color.Azure
        Me.Txt_Directorio.Location = New System.Drawing.Point(379, 7)
        Me.Txt_Directorio.Name = "Txt_Directorio"
        Me.Txt_Directorio.Size = New System.Drawing.Size(210, 22)
        Me.Txt_Directorio.TabIndex = 24
        Me.Txt_Directorio.Visible = False
        '
        'Txt_Final_Dir
        '
        Me.Txt_Final_Dir.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Txt_Final_Dir.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Final_Dir.ForeColor = System.Drawing.Color.Azure
        Me.Txt_Final_Dir.Location = New System.Drawing.Point(379, 108)
        Me.Txt_Final_Dir.Name = "Txt_Final_Dir"
        Me.Txt_Final_Dir.Size = New System.Drawing.Size(210, 22)
        Me.Txt_Final_Dir.TabIndex = 25
        Me.Txt_Final_Dir.Visible = False
        '
        'Img_GenLog
        '
        Me.Img_GenLog.Image = Global.NCBI___Crawler.My.Resources.Resources._001
        Me.Img_GenLog.Location = New System.Drawing.Point(640, -13)
        Me.Img_GenLog.Name = "Img_GenLog"
        Me.Img_GenLog.Size = New System.Drawing.Size(110, 95)
        Me.Img_GenLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Img_GenLog.TabIndex = 16
        Me.Img_GenLog.TabStop = False
        '
        'Frm_NCBI_SCRP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(757, 561)
        Me.Controls.Add(Me.Txt_Final_Dir)
        Me.Controls.Add(Me.Txt_Directorio)
        Me.Controls.Add(Me.Txt_Ruta)
        Me.Controls.Add(Me.Btn_Merge_Fil)
        Me.Controls.Add(Me.Btn_Generate_Fil)
        Me.Controls.Add(Me.Btn_Process)
        Me.Controls.Add(Me.Btn_Load_file)
        Me.Controls.Add(Me.Tbc_General)
        Me.Controls.Add(Me.Lbl_Titulo)
        Me.Controls.Add(Me.Fox)
        Me.Controls.Add(Me.Img_GenLog)
        Me.Controls.Add(Me.Lbl_DB)
        Me.Controls.Add(Me.Rtb_Pagina_con)
        Me.Controls.Add(Me.Btn_Get_data)
        Me.Controls.Add(Me.Cbx_Tip_Ver)
        Me.Controls.Add(Me.Lbl_ID)
        Me.Controls.Add(Me.Txt_Cod_Ver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_NCBI_SCRP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FOX - PROTEIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tbc_General.ResumeLayout(False)
        Me.Tab_Primera.ResumeLayout(False)
        Me.Tab_Segunda.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Img_GenLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Cod_Ver As TextBox
    Friend WithEvents Lbl_ID As Label
    Friend WithEvents Cbx_Tip_Ver As ComboBox
    Friend WithEvents Btn_Get_data As Button
    Friend WithEvents Rtb_Pagina_con As RichTextBox
    Friend WithEvents Lbl_Source_con As Label
    Friend WithEvents Lbl_Source_lbl As Label
    Friend WithEvents Lbl_DB As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Lbl_Definition_lbl As Label
    Friend WithEvents Lbl_Definition_con As Label
    Friend WithEvents Lbl_Version_lbl As Label
    Friend WithEvents Lbl_Version_con As Label
    Friend WithEvents Lbl_Organism_lbl As Label
    Friend WithEvents Lbl_Organism_con As Label
    Friend WithEvents Rtb_Sequence_con As RichTextBox
    Friend WithEvents Lbl_Sequence_lbl As Label
    Friend WithEvents Fox As Label
    Friend WithEvents Img_GenLog As PictureBox
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Tbc_General As TabControl
    Friend WithEvents Tab_Primera As TabPage
    Friend WithEvents Tab_Segunda As TabPage
    Friend WithEvents Btn_Load_file As Button
    Friend WithEvents Btn_Generate_Fil As Button
    Friend WithEvents Btn_Process As Button
    Friend WithEvents Lbl_Custom_con As Label
    Friend WithEvents Lbl_Custom_cod As Label
    Friend WithEvents Btn_Merge_Fil As Button
    Friend WithEvents Txt_Ruta As TextBox
    Friend WithEvents Txt_Directorio As TextBox
    Friend WithEvents Txt_Final_Dir As TextBox
    Friend WithEvents Lbl_TotFil_con As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Total_src As Label
    Friend WithEvents Lbl_TotSrc_con As Label
    Friend WithEvents Lbl_Final_fil As Label
    Friend WithEvents Lbl_FiltDoc_con As Label
    Friend WithEvents Lbl_Source_doc As Label
    Friend WithEvents Lbl_SourDoc_con As Label
    Friend WithEvents Lbl_Location As Label
    Friend WithEvents Lbl_Location_con As Label
    Friend WithEvents Lbl_Percent As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabPage1 As TabPage
End Class
