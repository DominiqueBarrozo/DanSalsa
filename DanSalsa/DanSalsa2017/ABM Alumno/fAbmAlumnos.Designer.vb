<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fAbmAlumnos
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txApellido = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.gAlumnos = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btNuevo = New System.Windows.Forms.Button()
        Me.bsAlumno = New System.Windows.Forms.BindingSource(Me.components)
        Me.EAlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.gAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.bsAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EAlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txApellido)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 47)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apellido"
        '
        'txApellido
        '
        Me.txApellido.Location = New System.Drawing.Point(63, 13)
        Me.txApellido.Name = "txApellido"
        Me.txApellido.Size = New System.Drawing.Size(177, 20)
        Me.txApellido.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btBuscar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(620, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 47)
        Me.Panel3.TabIndex = 0
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.ForeColor = System.Drawing.Color.Purple
        Me.btBuscar.Location = New System.Drawing.Point(26, 8)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(82, 32)
        Me.btBuscar.TabIndex = 0
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'gAlumnos
        '
        Me.gAlumnos.AllowUserToAddRows = False
        Me.gAlumnos.AllowUserToDeleteRows = False
        Me.gAlumnos.AutoGenerateColumns = False
        Me.gAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.TipoDocDataGridViewTextBoxColumn, Me.NroDocDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.LegajoDataGridViewTextBoxColumn, Me.NroDataGridViewTextBoxColumn, Me.CalleDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn})
        Me.gAlumnos.DataSource = Me.bsAlumno
        Me.gAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gAlumnos.Location = New System.Drawing.Point(0, 47)
        Me.gAlumnos.Name = "gAlumnos"
        Me.gAlumnos.ReadOnly = True
        Me.gAlumnos.Size = New System.Drawing.Size(749, 412)
        Me.gAlumnos.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btModificar)
        Me.Panel2.Controls.Add(Me.btNuevo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 405)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(749, 54)
        Me.Panel2.TabIndex = 6
        '
        'btModificar
        '
        Me.btModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.ForeColor = System.Drawing.Color.Purple
        Me.btModificar.Location = New System.Drawing.Point(424, 10)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(82, 32)
        Me.btModificar.TabIndex = 2
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = False
        '
        'btNuevo
        '
        Me.btNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.ForeColor = System.Drawing.Color.Purple
        Me.btNuevo.Location = New System.Drawing.Point(283, 10)
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(82, 32)
        Me.btNuevo.TabIndex = 1
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.UseVisualStyleBackColor = False
        '
        'bsAlumno
        '
        Me.bsAlumno.DataSource = GetType(DanSalsa2017.eAlumnos)
        '
        'EAlumnosBindingSource
        '
        Me.EAlumnosBindingSource.DataSource = GetType(DanSalsa2017.nUsuario)
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
        '
        'NroDocDataGridViewTextBoxColumn
        '
        Me.NroDocDataGridViewTextBoxColumn.DataPropertyName = "NroDoc"
        Me.NroDocDataGridViewTextBoxColumn.HeaderText = "NroDoc"
        Me.NroDocDataGridViewTextBoxColumn.Name = "NroDocDataGridViewTextBoxColumn"
        Me.NroDocDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
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
        '
        'CalleDataGridViewTextBoxColumn
        '
        Me.CalleDataGridViewTextBoxColumn.DataPropertyName = "Calle"
        Me.CalleDataGridViewTextBoxColumn.HeaderText = "Calle"
        Me.CalleDataGridViewTextBoxColumn.Name = "CalleDataGridViewTextBoxColumn"
        Me.CalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivoDataGridViewTextBoxColumn
        '
        Me.ActivoDataGridViewTextBoxColumn.DataPropertyName = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.Name = "ActivoDataGridViewTextBoxColumn"
        Me.ActivoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "FechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        Me.FechaNacDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaNacDataGridViewTextBoxColumn.Visible = False
        '
        'fAbmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 459)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gAlumnos)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "fAbmAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alumnos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.gAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.bsAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EAlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txApellido As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btBuscar As Button
    Friend WithEvents gAlumnos As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btModificar As Button
    Friend WithEvents btNuevo As Button
    Friend WithEvents bsAlumno As BindingSource
    Friend WithEvents EAlumnosBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroDocDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LegajoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
