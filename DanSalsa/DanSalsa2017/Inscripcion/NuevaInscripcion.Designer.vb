<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_Inscripcion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nueva_Inscripcion))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lb_nombre = New System.Windows.Forms.Label()
        Me.Lbl_LegajoAlumno = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.g_Inscripciones = New System.Windows.Forms.DataGridView()
        Me.ClaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bs_Incripciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_Clases = New System.Windows.Forms.ComboBox()
        Me.bs_Clase = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.g_Inscripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_Incripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs_Clase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Legajo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombre:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 347)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(753, 51)
        Me.Panel2.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btCancelar)
        Me.Panel3.Controls.Add(Me.btGuardar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(552, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 51)
        Me.Panel3.TabIndex = 5
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Purple
        Me.btCancelar.Location = New System.Drawing.Point(110, 9)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(82, 32)
        Me.btCancelar.TabIndex = 6
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.UseVisualStyleBackColor = False
        '
        'btGuardar
        '
        Me.btGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btGuardar.ForeColor = System.Drawing.Color.Purple
        Me.btGuardar.Location = New System.Drawing.Point(9, 9)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(82, 32)
        Me.btGuardar.TabIndex = 5
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(753, 54)
        Me.Panel1.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Lb_nombre
        '
        Me.Lb_nombre.AutoSize = True
        Me.Lb_nombre.Location = New System.Drawing.Point(393, 102)
        Me.Lb_nombre.Name = "Lb_nombre"
        Me.Lb_nombre.Size = New System.Drawing.Size(82, 13)
        Me.Lb_nombre.TabIndex = 38
        Me.Lb_nombre.Text = "Nombre Alumno"
        '
        'Lbl_LegajoAlumno
        '
        Me.Lbl_LegajoAlumno.AutoSize = True
        Me.Lbl_LegajoAlumno.Location = New System.Drawing.Point(393, 69)
        Me.Lbl_LegajoAlumno.Name = "Lbl_LegajoAlumno"
        Me.Lbl_LegajoAlumno.Size = New System.Drawing.Size(77, 13)
        Me.Lbl_LegajoAlumno.TabIndex = 39
        Me.Lbl_LegajoAlumno.Text = "Legajo Alumno"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.g_Inscripciones)
        Me.Panel5.Location = New System.Drawing.Point(343, 161)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(393, 162)
        Me.Panel5.TabIndex = 40
        '
        'g_Inscripciones
        '
        Me.g_Inscripciones.AllowUserToAddRows = False
        Me.g_Inscripciones.AllowUserToDeleteRows = False
        Me.g_Inscripciones.AutoGenerateColumns = False
        Me.g_Inscripciones.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.g_Inscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.g_Inscripciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClaseDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.IdClaseDataGridViewTextBoxColumn, Me.IdAlumnoDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn})
        Me.g_Inscripciones.DataSource = Me.bs_Incripciones
        Me.g_Inscripciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_Inscripciones.Location = New System.Drawing.Point(0, 0)
        Me.g_Inscripciones.Name = "g_Inscripciones"
        Me.g_Inscripciones.ReadOnly = True
        Me.g_Inscripciones.Size = New System.Drawing.Size(393, 162)
        Me.g_Inscripciones.TabIndex = 0
        '
        'ClaseDataGridViewTextBoxColumn
        '
        Me.ClaseDataGridViewTextBoxColumn.DataPropertyName = "clase"
        Me.ClaseDataGridViewTextBoxColumn.HeaderText = "clase"
        Me.ClaseDataGridViewTextBoxColumn.Name = "ClaseDataGridViewTextBoxColumn"
        Me.ClaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdClaseDataGridViewTextBoxColumn
        '
        Me.IdClaseDataGridViewTextBoxColumn.DataPropertyName = "idClase"
        Me.IdClaseDataGridViewTextBoxColumn.HeaderText = "idClase"
        Me.IdClaseDataGridViewTextBoxColumn.Name = "IdClaseDataGridViewTextBoxColumn"
        Me.IdClaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdClaseDataGridViewTextBoxColumn.Visible = False
        '
        'IdAlumnoDataGridViewTextBoxColumn
        '
        Me.IdAlumnoDataGridViewTextBoxColumn.DataPropertyName = "idAlumno"
        Me.IdAlumnoDataGridViewTextBoxColumn.HeaderText = "idAlumno"
        Me.IdAlumnoDataGridViewTextBoxColumn.Name = "IdAlumnoDataGridViewTextBoxColumn"
        Me.IdAlumnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdAlumnoDataGridViewTextBoxColumn.Visible = False
        '
        'ActivoDataGridViewTextBoxColumn
        '
        Me.ActivoDataGridViewTextBoxColumn.DataPropertyName = "activo"
        Me.ActivoDataGridViewTextBoxColumn.HeaderText = "activo"
        Me.ActivoDataGridViewTextBoxColumn.Name = "ActivoDataGridViewTextBoxColumn"
        Me.ActivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActivoDataGridViewTextBoxColumn.Visible = False
        '
        'bs_Incripciones
        '
        Me.bs_Incripciones.DataSource = GetType(DanSalsa2017.eInscripcion)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Clase:"
        '
        'cb_Clases
        '
        Me.cb_Clases.DataSource = Me.bs_Clase
        Me.cb_Clases.FormattingEnabled = True
        Me.cb_Clases.Location = New System.Drawing.Point(396, 127)
        Me.cb_Clases.Name = "cb_Clases"
        Me.cb_Clases.Size = New System.Drawing.Size(170, 21)
        Me.cb_Clases.TabIndex = 42
        '
        'bs_Clase
        '
        Me.bs_Clase.DataSource = GetType(DanSalsa2017.eClase)
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agregar.ForeColor = System.Drawing.Color.Purple
        Me.btn_Agregar.Location = New System.Drawing.Point(614, 127)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(72, 21)
        Me.btn_Agregar.TabIndex = 43
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(315, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(137, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Nueva_Inscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(753, 398)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.cb_Clases)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Lbl_LegajoAlumno)
        Me.Controls.Add(Me.Lb_nombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Nueva_Inscripcion"
        Me.Text = "Nueva_Inscripcion"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.g_Inscripciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_Incripciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs_Clase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btCancelar As System.Windows.Forms.Button
    Friend WithEvents btGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lb_nombre As System.Windows.Forms.Label
    Friend WithEvents Lbl_LegajoAlumno As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents g_Inscripciones As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_Clases As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents bs_Clase As System.Windows.Forms.BindingSource
    Friend WithEvents bs_Incripciones As System.Windows.Forms.BindingSource
    Friend WithEvents ClaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdClaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
