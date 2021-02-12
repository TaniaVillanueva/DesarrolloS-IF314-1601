<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tarea1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAcum1 = New System.Windows.Forms.TextBox()
        Me.txtExam1 = New System.Windows.Forms.TextBox()
        Me.txtExam2 = New System.Windows.Forms.TextBox()
        Me.txtAcum2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAcum3 = New System.Windows.Forms.TextBox()
        Me.txtExam3 = New System.Windows.Forms.TextBox()
        Me.txtExam4 = New System.Windows.Forms.TextBox()
        Me.txtAcum4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtmin = New System.Windows.Forms.TextBox()
        Me.txtmax = New System.Windows.Forms.TextBox()
        Me.lbMensaje = New System.Windows.Forms.Label()
        Me.lstHistorial = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Alumno"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(92, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(213, 20)
        Me.txtNombre.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtExam4)
        Me.GroupBox1.Controls.Add(Me.txtAcum4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtExam3)
        Me.GroupBox1.Controls.Add(Me.txtAcum3)
        Me.GroupBox1.Controls.Add(Me.txtExam2)
        Me.GroupBox1.Controls.Add(Me.txtAcum2)
        Me.GroupBox1.Controls.Add(Me.txtExam1)
        Me.GroupBox1.Controls.Add(Me.txtAcum1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 327)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los Datos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Acumulativo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Examen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "I Parcial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "II Parcial"
        '
        'txtAcum1
        '
        Me.txtAcum1.Location = New System.Drawing.Point(92, 110)
        Me.txtAcum1.Name = "txtAcum1"
        Me.txtAcum1.Size = New System.Drawing.Size(62, 20)
        Me.txtAcum1.TabIndex = 7
        '
        'txtExam1
        '
        Me.txtExam1.Location = New System.Drawing.Point(181, 110)
        Me.txtExam1.Name = "txtExam1"
        Me.txtExam1.Size = New System.Drawing.Size(62, 20)
        Me.txtExam1.TabIndex = 8
        '
        'txtExam2
        '
        Me.txtExam2.Location = New System.Drawing.Point(181, 147)
        Me.txtExam2.Name = "txtExam2"
        Me.txtExam2.Size = New System.Drawing.Size(62, 20)
        Me.txtExam2.TabIndex = 10
        '
        'txtAcum2
        '
        Me.txtAcum2.Location = New System.Drawing.Point(92, 147)
        Me.txtAcum2.Name = "txtAcum2"
        Me.txtAcum2.Size = New System.Drawing.Size(62, 20)
        Me.txtAcum2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "III Parcial"
        '
        'txtAcum3
        '
        Me.txtAcum3.Location = New System.Drawing.Point(92, 184)
        Me.txtAcum3.Name = "txtAcum3"
        Me.txtAcum3.Size = New System.Drawing.Size(62, 20)
        Me.txtAcum3.TabIndex = 11
        '
        'txtExam3
        '
        Me.txtExam3.Location = New System.Drawing.Point(181, 184)
        Me.txtExam3.Name = "txtExam3"
        Me.txtExam3.Size = New System.Drawing.Size(62, 20)
        Me.txtExam3.TabIndex = 12
        '
        'txtExam4
        '
        Me.txtExam4.Location = New System.Drawing.Point(181, 222)
        Me.txtExam4.Name = "txtExam4"
        Me.txtExam4.Size = New System.Drawing.Size(62, 20)
        Me.txtExam4.TabIndex = 15
        '
        'txtAcum4
        '
        Me.txtAcum4.Location = New System.Drawing.Point(92, 222)
        Me.txtAcum4.Name = "txtAcum4"
        Me.txtAcum4.Size = New System.Drawing.Size(62, 20)
        Me.txtAcum4.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "III Parcial"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(127, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(127, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtPromedio
        '
        Me.txtPromedio.Location = New System.Drawing.Point(437, 25)
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(93, 20)
        Me.txtPromedio.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Promedio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(363, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Minimo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(509, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Maximo"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtmin
        '
        Me.txtmin.Location = New System.Drawing.Point(418, 94)
        Me.txtmin.Name = "txtmin"
        Me.txtmin.Size = New System.Drawing.Size(63, 20)
        Me.txtmin.TabIndex = 8
        '
        'txtmax
        '
        Me.txtmax.Location = New System.Drawing.Point(560, 94)
        Me.txtmax.Name = "txtmax"
        Me.txtmax.Size = New System.Drawing.Size(63, 20)
        Me.txtmax.TabIndex = 9
        '
        'lbMensaje
        '
        Me.lbMensaje.AutoSize = True
        Me.lbMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMensaje.Location = New System.Drawing.Point(379, 130)
        Me.lbMensaje.Name = "lbMensaje"
        Me.lbMensaje.Size = New System.Drawing.Size(83, 24)
        Me.lbMensaje.TabIndex = 10
        Me.lbMensaje.Text = "Label11"
        Me.lbMensaje.Visible = False
        '
        'lstHistorial
        '
        Me.lstHistorial.FormattingEnabled = True
        Me.lstHistorial.Location = New System.Drawing.Point(366, 218)
        Me.lstHistorial.Name = "lstHistorial"
        Me.lstHistorial.Size = New System.Drawing.Size(296, 121)
        Me.lstHistorial.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(366, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Historial"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 351)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lstHistorial)
        Me.Controls.Add(Me.lbMensaje)
        Me.Controls.Add(Me.txtmax)
        Me.Controls.Add(Me.txtmin)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Aplicaciòn Notas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtExam4 As TextBox
    Friend WithEvents txtAcum4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtExam3 As TextBox
    Friend WithEvents txtAcum3 As TextBox
    Friend WithEvents txtExam2 As TextBox
    Friend WithEvents txtAcum2 As TextBox
    Friend WithEvents txtExam1 As TextBox
    Friend WithEvents txtAcum1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPromedio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtmin As TextBox
    Friend WithEvents txtmax As TextBox
    Friend WithEvents lbMensaje As Label
    Friend WithEvents lstHistorial As ListBox
    Friend WithEvents Label11 As Label
End Class
