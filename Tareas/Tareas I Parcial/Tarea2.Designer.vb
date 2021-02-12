<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tarea2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcentro = New System.Windows.Forms.TextBox()
        Me.txtclase = New System.Windows.Forms.TextBox()
        Me.txtCalumnos = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbAprobados = New System.Windows.Forms.ListBox()
        Me.lbReprobados = New System.Windows.Forms.ListBox()
        Me.lbExcelencia = New System.Windows.Forms.ListBox()
        Me.lbLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Centro Educativo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nombre de Clase"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad de alumnos"
        '
        'txtcentro
        '
        Me.txtcentro.Location = New System.Drawing.Point(201, 33)
        Me.txtcentro.Name = "txtcentro"
        Me.txtcentro.Size = New System.Drawing.Size(100, 20)
        Me.txtcentro.TabIndex = 3
        '
        'txtclase
        '
        Me.txtclase.Location = New System.Drawing.Point(201, 66)
        Me.txtclase.Name = "txtclase"
        Me.txtclase.Size = New System.Drawing.Size(100, 20)
        Me.txtclase.TabIndex = 4
        '
        'txtCalumnos
        '
        Me.txtCalumnos.Location = New System.Drawing.Point(201, 102)
        Me.txtCalumnos.Name = "txtCalumnos"
        Me.txtCalumnos.Size = New System.Drawing.Size(100, 20)
        Me.txtCalumnos.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbAprobados
        '
        Me.lbAprobados.FormattingEnabled = True
        Me.lbAprobados.Location = New System.Drawing.Point(12, 141)
        Me.lbAprobados.Name = "lbAprobados"
        Me.lbAprobados.Size = New System.Drawing.Size(555, 95)
        Me.lbAprobados.TabIndex = 7
        '
        'lbReprobados
        '
        Me.lbReprobados.FormattingEnabled = True
        Me.lbReprobados.Location = New System.Drawing.Point(12, 242)
        Me.lbReprobados.Name = "lbReprobados"
        Me.lbReprobados.Size = New System.Drawing.Size(555, 95)
        Me.lbReprobados.TabIndex = 8
        '
        'lbExcelencia
        '
        Me.lbExcelencia.FormattingEnabled = True
        Me.lbExcelencia.Location = New System.Drawing.Point(12, 343)
        Me.lbExcelencia.Name = "lbExcelencia"
        Me.lbExcelencia.Size = New System.Drawing.Size(555, 95)
        Me.lbExcelencia.TabIndex = 9
        '
        'lbLimpiar
        '
        Me.lbLimpiar.Location = New System.Drawing.Point(329, 85)
        Me.lbLimpiar.Name = "lbLimpiar"
        Me.lbLimpiar.Size = New System.Drawing.Size(101, 46)
        Me.lbLimpiar.TabIndex = 10
        Me.lbLimpiar.Text = "Limpiar"
        Me.lbLimpiar.UseVisualStyleBackColor = True
        '
        'Tarea2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 456)
        Me.Controls.Add(Me.lbLimpiar)
        Me.Controls.Add(Me.lbExcelencia)
        Me.Controls.Add(Me.lbReprobados)
        Me.Controls.Add(Me.lbAprobados)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCalumnos)
        Me.Controls.Add(Me.txtclase)
        Me.Controls.Add(Me.txtcentro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tarea2"
        Me.Text = "Clases y notas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcentro As TextBox
    Friend WithEvents txtclase As TextBox
    Friend WithEvents txtCalumnos As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbAprobados As ListBox
    Friend WithEvents lbReprobados As ListBox
    Friend WithEvents lbExcelencia As ListBox
    Friend WithEvents lbLimpiar As Button
End Class
