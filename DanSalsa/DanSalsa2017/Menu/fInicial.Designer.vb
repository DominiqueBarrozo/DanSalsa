<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fInicial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fInicial))
        Me.pFondo = New System.Windows.Forms.PictureBox()
        CType(Me.pFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pFondo
        '
        Me.pFondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pFondo.Image = CType(resources.GetObject("pFondo.Image"), System.Drawing.Image)
        Me.pFondo.Location = New System.Drawing.Point(0, 0)
        Me.pFondo.Name = "pFondo"
        Me.pFondo.Size = New System.Drawing.Size(915, 526)
        Me.pFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pFondo.TabIndex = 15
        Me.pFondo.TabStop = False
        '
        'fInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 526)
        Me.Controls.Add(Me.pFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fInicial"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "fInicial"
        CType(Me.pFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pFondo As PictureBox
End Class
