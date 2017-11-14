<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscripcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inscripcion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txnombre = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.gAlumno = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroDocDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LegajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAlumno = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.gClases = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsInscripcion = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.gAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.gClases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInscripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txnombre)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 47)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre alumno:"
        '
        'txnombre
        '
        Me.txnombre.Location = New System.Drawing.Point(231, 12)
        Me.txnombre.Name = "txnombre"
        Me.txnombre.Size = New System.Drawing.Size(185, 20)
        Me.txnombre.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btBuscar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(422, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 47)
        Me.Panel3.TabIndex = 0
        '
        'btBuscar
        '
        Me.btBuscar.ForeColor = System.Drawing.Color.Purple
        Me.btBuscar.Location = New System.Drawing.Point(26, 8)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(82, 32)
        Me.btBuscar.TabIndex = 0
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 381)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(551, 49)
        Me.Panel2.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, -2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(551, 51)
        Me.Panel6.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btNuevo)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(350, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(201, 51)
        Me.Panel7.TabIndex = 5
        '
        'btNuevo
        '
        Me.btNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.ForeColor = System.Drawing.Color.Purple
        Me.btNuevo.Location = New System.Drawing.Point(52, 8)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(91, 40)
        Me.btNuevo.TabIndex = 5
        Me.btNuevo.Text = "Inscribir"
        Me.btNuevo.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.gAlumno)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(551, 181)
        Me.Panel4.TabIndex = 8
        '
        'gAlumno
        '
        Me.gAlumno.AllowUserToAddRows = False
        Me.gAlumno.AllowUserToDeleteRows = False
        Me.gAlumno.AutoGenerateColumns = False
        Me.gAlumno.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gAlumno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.TipoDocDataGridViewTextBoxColumn, Me.NroDocDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.LegajoDataGridViewTextBoxColumn, Me.NroDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn})
        Me.gAlumno.DataSource = Me.bsAlumno
        Me.gAlumno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gAlumno.Location = New System.Drawing.Point(0, 0)
        Me.gAlumno.Name = "gAlumno"
        Me.gAlumno.ReadOnly = True
        Me.gAlumno.Size = New System.Drawing.Size(551, 181)
        Me.gAlumno.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoDocDataGridViewTextBoxColumn
        '
        Me.TipoDocDataGridViewTextBoxColumn.DataPropertyName = "TipoDoc"
        Me.TipoDocDataGridViewTextBoxColumn.HeaderText = "TipoDoc"
        Me.TipoDocDataGridViewTextBoxColumn.Name = "TipoDocDataGridViewTextBoxColumn"
        Me.TipoDocDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDocDataGridViewTextBoxColumn.Visible = False
        '
        'NroDocDataGridViewTextBoxColumn
        '
        Me.NroDocDataGridViewTextBoxColumn.DataPropertyName = "NroDoc"
        Me.NroDocDataGridViewTextBoxColumn.HeaderText = "NroDoc"
        Me.NroDocDataGridViewTextBoxColumn.Name = "NroDocDataGridViewTextBoxColumn"
        Me.NroDocDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroDocDataGridViewTextBoxColumn.Visible = False
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Visible = False
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexoDataGridViewTextBoxColumn.Visible = False
        '
        'LegajoDataGridViewTextBoxColumn
        '
        Me.LegajoDataGridViewTextBoxColumn.DataPropertyName = "Legajo"
        Me.LegajoDataGridViewTextBoxColumn.HeaderText = "Legajo"
        Me.LegajoDataGridViewTextBoxColumn.Name = "LegajoDataGridViewTextBoxColumn"
        Me.LegajoDataGridViewTextBoxColumn.ReadOnly = True
        Me.LegajoDataGridViewTextBoxColumn.Visible = False
        '
        'NroDataGridViewTextBoxColumn
        '
        Me.NroDataGridViewTextBoxColumn.DataPropertyName = "Nro"
        Me.NroDataGridViewTextBoxColumn.HeaderText = "Nro"
        Me.NroDataGridViewTextBoxColumn.Name = "NroDataGridViewTextBoxColumn"
        Me.NroDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroDataGridViewTextBoxColumn.Visible = False
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "Calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        Me.CalleDataGridViewTextBoxColumn.Visible = False
        '
        'ActivoDataGridViewTextBoxColumn
        '
        Me.ActivoDataGridViewTextBoxColumn.DataPropertyName = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.Name = "ActivoDataGridViewTextBoxColumn"
        Me.ActivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActivoDataGridViewTextBoxColumn.Visible = False
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "FechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        Me.FechaNacDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaNacDataGridViewTextBoxColumn.Visible = False
        '
        'bsAlumno
        '
        Me.bsAlumno.DataSource = GetType(DanSalsa2017.eAlumnos)
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.gClases)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 228)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(551, 153)
        Me.Panel5.TabIndex = 9
        '
        'gClases
        '
        Me.gClases.AllowUserToAddRows = False
        Me.gClases.AllowUserToDeleteRows = False
        Me.gClases.AutoGenerateColumns = False
        Me.gClases.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gClases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.ClaseDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.IdClaseDataGridViewTextBoxColumn, Me.IdAlumnoDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn1})
        Me.gClases.DataSource = Me.bsInscripcion
        Me.gClases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gClases.Location = New System.Drawing.Point(0, 0)
        Me.gClases.Name = "gClases"
        Me.gClases.ReadOnly = True
        Me.gClases.Size = New System.Drawing.Size(551, 153)
        Me.gClases.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'ClaseDataGridViewTextBoxColumn
        '
        Me.ClaseDataGridViewTextBoxColumn.DataPropertyName = "clase"
        Me.ClaseDataGridViewTextBoxColumn.HeaderText = "Clase"
        Me.ClaseDataGridViewTextBoxColumn.Name = "ClaseDataGridViewTextBoxColumn"
        Me.ClaseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
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
        'ActivoDataGridViewTextBoxColumn1
        '
        Me.ActivoDataGridViewTextBoxColumn1.DataPropertyName = "activo"
        Me.ActivoDataGridViewTextBoxColumn1.HeaderText = "activo"
        Me.ActivoDataGridViewTextBoxColumn1.Name = "ActivoDataGridViewTextBoxColumn1"
        Me.ActivoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ActivoDataGridViewTextBoxColumn1.Visible = False
        '
        'bsInscripcion
        '
        Me.bsInscripcion.DataSource = GetType(DanSalsa2017.eInscripcion)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Inscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 430)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Inscripcion"
        Me.Text = "Inscripcion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.gAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.gClases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInscripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txnombre As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents gAlumno As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroDocDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LegajoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsAlumno As System.Windows.Forms.BindingSource
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents gClases As System.Windows.Forms.DataGridView
    Friend WithEvents bsInscripcion As System.Windows.Forms.BindingSource
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btNuevo As System.Windows.Forms.Button
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdClaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdAlumnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
