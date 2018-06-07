
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.EntrySys = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TEMPuser = New System.Windows.Forms.CheckBox()
        Me.Boption = New System.Windows.Forms.Button()
        Me.Cclose = New System.Windows.Forms.Button()
        Me.config = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Cserver = New System.Windows.Forms.TextBox()
        Me.Cdata = New System.Windows.Forms.TextBox()
        Me.Cpass = New System.Windows.Forms.TextBox()
        Me.Cuser = New System.Windows.Forms.TextBox()
        Me.Gconex = New System.Windows.Forms.Button()
        Me.Tconex = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.passwork = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.config.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EntrySys
        '
        Me.EntrySys.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntrySys.Location = New System.Drawing.Point(88, 157)
        Me.EntrySys.Name = "EntrySys"
        Me.EntrySys.Size = New System.Drawing.Size(83, 23)
        Me.EntrySys.TabIndex = 4
        Me.EntrySys.Text = "&Aceptar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IVASAE.My.Resources.Resources.logo_imacasa
        Me.PictureBox1.Location = New System.Drawing.Point(88, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'TEMPuser
        '
        Me.TEMPuser.AutoSize = True
        Me.TEMPuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEMPuser.Location = New System.Drawing.Point(235, 135)
        Me.TEMPuser.Name = "TEMPuser"
        Me.TEMPuser.Size = New System.Drawing.Size(101, 17)
        Me.TEMPuser.TabIndex = 22
        Me.TEMPuser.Text = "Recordar Datos"
        Me.TEMPuser.UseVisualStyleBackColor = True
        '
        'Boption
        '
        Me.Boption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boption.Location = New System.Drawing.Point(263, 157)
        Me.Boption.Name = "Boption"
        Me.Boption.Size = New System.Drawing.Size(80, 23)
        Me.Boption.TabIndex = 21
        Me.Boption.Text = "Opcion >>"
        Me.Boption.UseVisualStyleBackColor = True
        '
        'Cclose
        '
        Me.Cclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cclose.Location = New System.Drawing.Point(177, 157)
        Me.Cclose.Name = "Cclose"
        Me.Cclose.Size = New System.Drawing.Size(80, 23)
        Me.Cclose.TabIndex = 20
        Me.Cclose.Text = "Cerrar"
        Me.Cclose.UseVisualStyleBackColor = True
        '
        'config
        '
        Me.config.Controls.Add(Me.TabPage1)
        Me.config.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.config.Location = New System.Drawing.Point(10, 250)
        Me.config.Name = "config"
        Me.config.SelectedIndex = 0
        Me.config.Size = New System.Drawing.Size(340, 224)
        Me.config.TabIndex = 18
        Me.config.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Cserver)
        Me.TabPage1.Controls.Add(Me.Cdata)
        Me.TabPage1.Controls.Add(Me.Cpass)
        Me.TabPage1.Controls.Add(Me.Cuser)
        Me.TabPage1.Controls.Add(Me.Gconex)
        Me.TabPage1.Controls.Add(Me.Tconex)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(332, 198)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Conexion"
        '
        'Cserver
        '
        Me.Cserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cserver.Location = New System.Drawing.Point(117, 46)
        Me.Cserver.Name = "Cserver"
        Me.Cserver.Size = New System.Drawing.Size(177, 20)
        Me.Cserver.TabIndex = 7
        '
        'Cdata
        '
        Me.Cdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cdata.Location = New System.Drawing.Point(117, 127)
        Me.Cdata.Name = "Cdata"
        Me.Cdata.Size = New System.Drawing.Size(177, 20)
        Me.Cdata.TabIndex = 14
        '
        'Cpass
        '
        Me.Cpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpass.Location = New System.Drawing.Point(117, 100)
        Me.Cpass.Name = "Cpass"
        Me.Cpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Cpass.Size = New System.Drawing.Size(177, 20)
        Me.Cpass.TabIndex = 12
        '
        'Cuser
        '
        Me.Cuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuser.Location = New System.Drawing.Point(117, 73)
        Me.Cuser.Name = "Cuser"
        Me.Cuser.Size = New System.Drawing.Size(177, 20)
        Me.Cuser.TabIndex = 9
        '
        'Gconex
        '
        Me.Gconex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gconex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Gconex.Location = New System.Drawing.Point(218, 166)
        Me.Gconex.Name = "Gconex"
        Me.Gconex.Size = New System.Drawing.Size(93, 23)
        Me.Gconex.TabIndex = 16
        Me.Gconex.Text = "Guardar"
        Me.Gconex.UseVisualStyleBackColor = True
        '
        'Tconex
        '
        Me.Tconex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tconex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tconex.Location = New System.Drawing.Point(100, 166)
        Me.Tconex.Name = "Tconex"
        Me.Tconex.Size = New System.Drawing.Size(103, 23)
        Me.Tconex.TabIndex = 15
        Me.Tconex.Text = "Test Conexion"
        Me.Tconex.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(31, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(31, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(31, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(31, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Server Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.passwork)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Usuario)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 64)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'passwork
        '
        Me.passwork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwork.Location = New System.Drawing.Point(87, 38)
        Me.passwork.Name = "passwork"
        Me.passwork.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwork.Size = New System.Drawing.Size(164, 20)
        Me.passwork.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Password"
        '
        'Usuario
        '
        Me.Usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario.Location = New System.Drawing.Point(87, 13)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(164, 20)
        Me.Usuario.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Usuario"
        '
        'Login
        '
        Me.AcceptButton = Me.EntrySys
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(362, 478)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TEMPuser)
        Me.Controls.Add(Me.Boption)
        Me.Controls.Add(Me.Cclose)
        Me.Controls.Add(Me.config)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.EntrySys)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.config.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EntrySys As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TEMPuser As System.Windows.Forms.CheckBox
    Friend WithEvents Boption As System.Windows.Forms.Button
    Friend WithEvents Cclose As System.Windows.Forms.Button
    Friend WithEvents config As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Cserver As System.Windows.Forms.TextBox
    Friend WithEvents Cdata As System.Windows.Forms.TextBox
    Friend WithEvents Cpass As System.Windows.Forms.TextBox
    Friend WithEvents Cuser As System.Windows.Forms.TextBox
    Friend WithEvents Gconex As System.Windows.Forms.Button
    Friend WithEvents Tconex As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents passwork As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
