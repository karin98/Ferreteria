<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrabajo))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Textcargo = New System.Windows.Forms.TextBox()
        Me.Textdni = New System.Windows.Forms.TextBox()
        Me.Textcelular = New System.Windows.Forms.TextBox()
        Me.Textemail = New System.Windows.Forms.TextBox()
        Me.Textdireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Textapellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cbtipousuario = New System.Windows.Forms.ComboBox()
        Me.Textpass = New System.Windows.Forms.TextBox()
        Me.Textusuario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.dgvTrabajador = New System.Windows.Forms.DataGridView()
        Me.lbldatos = New System.Windows.Forms.LinkLabel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.TextFlag = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Textcargo)
        Me.Panel1.Controls.Add(Me.Textdni)
        Me.Panel1.Controls.Add(Me.Textcelular)
        Me.Panel1.Controls.Add(Me.Textemail)
        Me.Panel1.Controls.Add(Me.Textdireccion)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Textapellido)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Textnombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextCodigo)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 177)
        Me.Panel1.TabIndex = 1
        '
        'Textcargo
        '
        Me.Textcargo.Location = New System.Drawing.Point(322, 82)
        Me.Textcargo.Name = "Textcargo"
        Me.Textcargo.Size = New System.Drawing.Size(100, 20)
        Me.Textcargo.TabIndex = 16
        '
        'Textdni
        '
        Me.Textdni.Location = New System.Drawing.Point(322, 48)
        Me.Textdni.Name = "Textdni"
        Me.Textdni.Size = New System.Drawing.Size(100, 20)
        Me.Textdni.TabIndex = 15
        '
        'Textcelular
        '
        Me.Textcelular.Location = New System.Drawing.Point(322, 9)
        Me.Textcelular.Name = "Textcelular"
        Me.Textcelular.Size = New System.Drawing.Size(100, 20)
        Me.Textcelular.TabIndex = 14
        '
        'Textemail
        '
        Me.Textemail.Location = New System.Drawing.Point(93, 113)
        Me.Textemail.Name = "Textemail"
        Me.Textemail.Size = New System.Drawing.Size(336, 20)
        Me.Textemail.TabIndex = 13
        '
        'Textdireccion
        '
        Me.Textdireccion.Location = New System.Drawing.Point(94, 150)
        Me.Textdireccion.Name = "Textdireccion"
        Me.Textdireccion.Size = New System.Drawing.Size(335, 20)
        Me.Textdireccion.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(262, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 19)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Cargo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(281, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Dni:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(255, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Celular:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Dirección:"
        '
        'Textapellido
        '
        Me.Textapellido.Location = New System.Drawing.Point(93, 79)
        Me.Textapellido.Name = "Textapellido"
        Me.Textapellido.Size = New System.Drawing.Size(130, 20)
        Me.Textapellido.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido:"
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(93, 45)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(130, 20)
        Me.Textnombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'TextCodigo
        '
        Me.TextCodigo.Location = New System.Drawing.Point(93, 12)
        Me.TextCodigo.Name = "TextCodigo"
        Me.TextCodigo.Size = New System.Drawing.Size(130, 20)
        Me.TextCodigo.TabIndex = 0
        Me.TextCodigo.Text = "F"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Cbtipousuario)
        Me.GroupBox1.Controls.Add(Me.Textpass)
        Me.GroupBox1.Controls.Add(Me.Textusuario)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(456, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 148)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creación de Credenciales"
        '
        'Cbtipousuario
        '
        Me.Cbtipousuario.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbtipousuario.FormattingEnabled = True
        Me.Cbtipousuario.Items.AddRange(New Object() {"ADMINISTRADOR", "VENTAS"})
        Me.Cbtipousuario.Location = New System.Drawing.Point(131, 114)
        Me.Cbtipousuario.Name = "Cbtipousuario"
        Me.Cbtipousuario.Size = New System.Drawing.Size(124, 27)
        Me.Cbtipousuario.TabIndex = 16
        Me.Cbtipousuario.Text = "VENTAS"
        '
        'Textpass
        '
        Me.Textpass.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textpass.Location = New System.Drawing.Point(131, 70)
        Me.Textpass.Name = "Textpass"
        Me.Textpass.Size = New System.Drawing.Size(124, 24)
        Me.Textpass.TabIndex = 15
        '
        'Textusuario
        '
        Me.Textusuario.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textusuario.Location = New System.Drawing.Point(131, 36)
        Me.Textusuario.Name = "Textusuario"
        Me.Textusuario.Size = New System.Drawing.Size(124, 24)
        Me.Textusuario.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 19)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Tipo de Usuario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(59, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 19)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Usuario:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 19)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Password:"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(456, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 22)
        Me.Button1.TabIndex = 17
        Me.Button1.UseVisualStyleBackColor = True
        '
        'textbuscar
        '
        Me.textbuscar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbuscar.Location = New System.Drawing.Point(519, 163)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(198, 24)
        Me.textbuscar.TabIndex = 18
        '
        'Btnguardar
        '
        Me.Btnguardar.FlatAppearance.BorderSize = 0
        Me.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnguardar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Image = Global.SistemaFer.My.Resources.Resources.save
        Me.Btnguardar.Location = New System.Drawing.Point(267, 198)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(60, 37)
        Me.Btnguardar.TabIndex = 20
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = Global.SistemaFer.My.Resources.Resources.edit
        Me.btnEditar.Location = New System.Drawing.Point(199, 198)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(62, 39)
        Me.btnEditar.TabIndex = 22
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'dgvTrabajador
        '
        Me.dgvTrabajador.AllowUserToAddRows = False
        Me.dgvTrabajador.AllowUserToDeleteRows = False
        Me.dgvTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrabajador.Location = New System.Drawing.Point(12, 247)
        Me.dgvTrabajador.Name = "dgvTrabajador"
        Me.dgvTrabajador.ReadOnly = True
        Me.dgvTrabajador.Size = New System.Drawing.Size(705, 150)
        Me.dgvTrabajador.TabIndex = 23
        '
        'lbldatos
        '
        Me.lbldatos.AutoSize = True
        Me.lbldatos.Location = New System.Drawing.Point(316, 292)
        Me.lbldatos.Name = "lbldatos"
        Me.lbldatos.Size = New System.Drawing.Size(59, 13)
        Me.lbldatos.TabIndex = 24
        Me.lbldatos.TabStop = True
        Me.lbldatos.Text = "LinkLabel1"
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.SistemaFer.My.Resources.Resources.trash
        Me.btnEliminar.Location = New System.Drawing.Point(398, 198)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(52, 39)
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Image = Global.SistemaFer.My.Resources.Resources.cancel
        Me.btncancelar.Location = New System.Drawing.Point(336, 204)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(56, 31)
        Me.btncancelar.TabIndex = 26
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'TextFlag
        '
        Me.TextFlag.Location = New System.Drawing.Point(40, 208)
        Me.TextFlag.Name = "TextFlag"
        Me.TextFlag.Size = New System.Drawing.Size(20, 20)
        Me.TextFlag.TabIndex = 27
        Me.TextFlag.Text = "0"
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SistemaFer.My.Resources.Resources._new
        Me.btnNuevo.Location = New System.Drawing.Point(138, 198)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(55, 37)
        Me.btnNuevo.TabIndex = 28
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(729, 397)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.TextFlag)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lbldatos)
        Me.Controls.Add(Me.dgvTrabajador)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Btnguardar)
        Me.Controls.Add(Me.textbuscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trabajador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Textdni As TextBox
    Friend WithEvents Textcelular As TextBox
    Friend WithEvents Textemail As TextBox
    Friend WithEvents Textdireccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Textapellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextCodigo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cbtipousuario As ComboBox
    Friend WithEvents Textpass As TextBox
    Friend WithEvents Textusuario As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents textbuscar As TextBox
    Friend WithEvents Btnguardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents dgvTrabajador As DataGridView
    Friend WithEvents lbldatos As LinkLabel
    Friend WithEvents Textcargo As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents TextFlag As TextBox
    Friend WithEvents btnNuevo As Button
End Class
