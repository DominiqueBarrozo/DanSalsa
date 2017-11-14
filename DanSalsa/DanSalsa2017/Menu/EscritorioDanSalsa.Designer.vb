<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EscritorioDanSalsa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EscritorioDanSalsa))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_Asistencia = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btRitmo = New System.Windows.Forms.Button()
        Me.btUsuarios = New System.Windows.Forms.Button()
        Me.btn_inscripcion = New System.Windows.Forms.Button()
        Me.btn_informe = New System.Windows.Forms.Button()
        Me.btn_profesor = New System.Windows.Forms.Button()
        Me.btn_alumnos = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 535)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(717, 56)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_salir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(575, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(142, 56)
        Me.Panel2.TabIndex = 6
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.ForeColor = System.Drawing.Color.Purple
        Me.btn_salir.Location = New System.Drawing.Point(20, 3)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(102, 50)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_Asistencia
        '
        Me.btn_Asistencia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Asistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Asistencia.ForeColor = System.Drawing.Color.Purple
        Me.btn_Asistencia.Location = New System.Drawing.Point(12, 367)
        Me.btn_Asistencia.Name = "btn_Asistencia"
        Me.btn_Asistencia.Size = New System.Drawing.Size(96, 50)
        Me.btn_Asistencia.TabIndex = 15
        Me.btn_Asistencia.Text = "ASISTENCIA"
        Me.btn_Asistencia.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_Asistencia)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btRitmo)
        Me.Panel3.Controls.Add(Me.btUsuarios)
        Me.Panel3.Controls.Add(Me.btn_inscripcion)
        Me.Panel3.Controls.Add(Me.btn_informe)
        Me.Panel3.Controls.Add(Me.btn_profesor)
        Me.Panel3.Controls.Add(Me.btn_alumnos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(123, 535)
        Me.Panel3.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Purple
        Me.Button2.Location = New System.Drawing.Point(12, 479)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 50)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "ESTADISTICA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Purple
        Me.Button1.Location = New System.Drawing.Point(12, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 50)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CLASES"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btRitmo
        '
        Me.btRitmo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btRitmo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRitmo.ForeColor = System.Drawing.Color.Purple
        Me.btRitmo.Location = New System.Drawing.Point(12, 176)
        Me.btRitmo.Name = "btRitmo"
        Me.btRitmo.Size = New System.Drawing.Size(96, 50)
        Me.btRitmo.TabIndex = 12
        Me.btRitmo.Text = "RITMOS"
        Me.btRitmo.UseVisualStyleBackColor = False
        '
        'btUsuarios
        '
        Me.btUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUsuarios.ForeColor = System.Drawing.Color.Purple
        Me.btUsuarios.Location = New System.Drawing.Point(12, 8)
        Me.btUsuarios.Name = "btUsuarios"
        Me.btUsuarios.Size = New System.Drawing.Size(96, 50)
        Me.btUsuarios.TabIndex = 11
        Me.btUsuarios.Text = "USUARIOS"
        Me.btUsuarios.UseVisualStyleBackColor = False
        '
        'btn_inscripcion
        '
        Me.btn_inscripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_inscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inscripcion.ForeColor = System.Drawing.Color.Purple
        Me.btn_inscripcion.Location = New System.Drawing.Point(13, 311)
        Me.btn_inscripcion.Name = "btn_inscripcion"
        Me.btn_inscripcion.Size = New System.Drawing.Size(96, 50)
        Me.btn_inscripcion.TabIndex = 10
        Me.btn_inscripcion.Text = "INSCRIPCIÓN"
        Me.btn_inscripcion.UseVisualStyleBackColor = False
        '
        'btn_informe
        '
        Me.btn_informe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_informe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_informe.ForeColor = System.Drawing.Color.Purple
        Me.btn_informe.Location = New System.Drawing.Point(12, 423)
        Me.btn_informe.Name = "btn_informe"
        Me.btn_informe.Size = New System.Drawing.Size(96, 50)
        Me.btn_informe.TabIndex = 9
        Me.btn_informe.Text = "INFORMES"
        Me.btn_informe.UseVisualStyleBackColor = False
        '
        'btn_profesor
        '
        Me.btn_profesor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_profesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_profesor.ForeColor = System.Drawing.Color.Purple
        Me.btn_profesor.Location = New System.Drawing.Point(13, 120)
        Me.btn_profesor.Name = "btn_profesor"
        Me.btn_profesor.Size = New System.Drawing.Size(96, 50)
        Me.btn_profesor.TabIndex = 7
        Me.btn_profesor.Text = "PROFESOR"
        Me.btn_profesor.UseVisualStyleBackColor = False
        '
        'btn_alumnos
        '
        Me.btn_alumnos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_alumnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alumnos.ForeColor = System.Drawing.Color.Purple
        Me.btn_alumnos.Location = New System.Drawing.Point(13, 64)
        Me.btn_alumnos.Name = "btn_alumnos"
        Me.btn_alumnos.Size = New System.Drawing.Size(96, 50)
        Me.btn_alumnos.TabIndex = 6
        Me.btn_alumnos.Text = "ALUMNOS"
        Me.btn_alumnos.UseVisualStyleBackColor = False
        '
        'EscritorioDanSalsa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 591)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Purple
        Me.IsMdiContainer = True
        Me.Name = "EscritorioDanSalsa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escritorio DanSalsa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_salir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_inscripcion As Button
    Friend WithEvents btn_informe As Button
    Friend WithEvents btn_profesor As Button
    Friend WithEvents btn_alumnos As Button
    Friend WithEvents btUsuarios As Button
    Friend WithEvents btRitmo As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_Asistencia As System.Windows.Forms.Button
End Class
