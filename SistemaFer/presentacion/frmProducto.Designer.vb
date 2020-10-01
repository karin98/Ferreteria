<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextFlag = New System.Windows.Forms.TextBox()
        Me.textpresentacion = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textstock = New System.Windows.Forms.TextBox()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.textmarcap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textpreciop = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textnombrep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textcodigoprod = New System.Windows.Forms.TextBox()
        Me.btnbuscarcat = New System.Windows.Forms.Button()
        Me.textnombrecat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.SinDatos = New System.Windows.Forms.LinkLabel()
        Me.Dgvproducto = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgvproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextFlag)
        Me.Panel1.Controls.Add(Me.textpresentacion)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btneditar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.textstock)
        Me.Panel1.Controls.Add(Me.Btnguardar)
        Me.Panel1.Controls.Add(Me.textmarcap)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.textpreciop)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.textnombrep)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.textcodigoprod)
        Me.Panel1.Controls.Add(Me.btnbuscarcat)
        Me.Panel1.Controls.Add(Me.textnombrecat)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 145)
        Me.Panel1.TabIndex = 0
        '
        'TextFlag
        '
        Me.TextFlag.Location = New System.Drawing.Point(213, 12)
        Me.TextFlag.Name = "TextFlag"
        Me.TextFlag.Size = New System.Drawing.Size(38, 20)
        Me.TextFlag.TabIndex = 28
        Me.TextFlag.Text = "0"
        '
        'textpresentacion
        '
        Me.textpresentacion.ForeColor = System.Drawing.Color.YellowGreen
        Me.textpresentacion.Location = New System.Drawing.Point(439, 40)
        Me.textpresentacion.Name = "textpresentacion"
        Me.textpresentacion.Size = New System.Drawing.Size(163, 20)
        Me.textpresentacion.TabIndex = 23
        '
        'btneliminar
        '
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Image = Global.SistemaFer.My.Resources.Resources.trash
        Me.btneliminar.Location = New System.Drawing.Point(420, 93)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(52, 39)
        Me.btneliminar.TabIndex = 27
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(327, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 19)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Presentación:"
        '
        'btneditar
        '
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.Image = Global.SistemaFer.My.Resources.Resources.edit
        Me.btneditar.Location = New System.Drawing.Point(367, 96)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(47, 36)
        Me.btneditar.TabIndex = 26
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(381, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 19)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Stock:"
        '
        'textstock
        '
        Me.textstock.Location = New System.Drawing.Point(439, 67)
        Me.textstock.Name = "textstock"
        Me.textstock.Size = New System.Drawing.Size(74, 20)
        Me.textstock.TabIndex = 19
        '
        'Btnguardar
        '
        Me.Btnguardar.FlatAppearance.BorderSize = 0
        Me.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnguardar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Image = Global.SistemaFer.My.Resources.Resources.save
        Me.Btnguardar.Location = New System.Drawing.Point(313, 94)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(48, 36)
        Me.Btnguardar.TabIndex = 25
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'textmarcap
        '
        Me.textmarcap.Location = New System.Drawing.Point(131, 69)
        Me.textmarcap.Name = "textmarcap"
        Me.textmarcap.Size = New System.Drawing.Size(163, 20)
        Me.textmarcap.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Marca:"
        '
        'textpreciop
        '
        Me.textpreciop.Location = New System.Drawing.Point(131, 95)
        Me.textpreciop.Name = "textpreciop"
        Me.textpreciop.Size = New System.Drawing.Size(163, 20)
        Me.textpreciop.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio:"
        '
        'textnombrep
        '
        Me.textnombrep.Location = New System.Drawing.Point(131, 38)
        Me.textnombrep.Name = "textnombrep"
        Me.textnombrep.Size = New System.Drawing.Size(163, 20)
        Me.textnombrep.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre:"
        '
        'textcodigoprod
        '
        Me.textcodigoprod.Location = New System.Drawing.Point(131, 11)
        Me.textcodigoprod.Name = "textcodigoprod"
        Me.textcodigoprod.Size = New System.Drawing.Size(76, 20)
        Me.textcodigoprod.TabIndex = 4
        '
        'btnbuscarcat
        '
        Me.btnbuscarcat.FlatAppearance.BorderSize = 0
        Me.btnbuscarcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarcat.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarcat.Image = CType(resources.GetObject("btnbuscarcat.Image"), System.Drawing.Image)
        Me.btnbuscarcat.Location = New System.Drawing.Point(601, 8)
        Me.btnbuscarcat.Name = "btnbuscarcat"
        Me.btnbuscarcat.Size = New System.Drawing.Size(48, 31)
        Me.btnbuscarcat.TabIndex = 3
        Me.btnbuscarcat.UseVisualStyleBackColor = True
        '
        'textnombrecat
        '
        Me.textnombrecat.Location = New System.Drawing.Point(439, 15)
        Me.textnombrecat.Name = "textnombrecat"
        Me.textnombrecat.Size = New System.Drawing.Size(163, 20)
        Me.textnombrecat.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo Categoria:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Producto:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.textbuscar)
        Me.Panel2.Controls.Add(Me.SinDatos)
        Me.Panel2.Controls.Add(Me.Dgvproducto)
        Me.Panel2.Location = New System.Drawing.Point(12, 163)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 184)
        Me.Panel2.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Buscar:"
        '
        'textbuscar
        '
        Me.textbuscar.Location = New System.Drawing.Point(81, 10)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(213, 20)
        Me.textbuscar.TabIndex = 3
        '
        'SinDatos
        '
        Me.SinDatos.AutoSize = True
        Me.SinDatos.Location = New System.Drawing.Point(310, 127)
        Me.SinDatos.Name = "SinDatos"
        Me.SinDatos.Size = New System.Drawing.Size(59, 13)
        Me.SinDatos.TabIndex = 1
        Me.SinDatos.TabStop = True
        Me.SinDatos.Text = "LinkLabel1"
        '
        'Dgvproducto
        '
        Me.Dgvproducto.AllowUserToAddRows = False
        Me.Dgvproducto.AllowUserToDeleteRows = False
        Me.Dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvproducto.Location = New System.Drawing.Point(22, 36)
        Me.Dgvproducto.Name = "Dgvproducto"
        Me.Dgvproducto.ReadOnly = True
        Me.Dgvproducto.Size = New System.Drawing.Size(719, 136)
        Me.Dgvproducto.TabIndex = 0
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(768, 348)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmProducto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Dgvproducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents textcodigoprod As TextBox
    Friend WithEvents btnbuscarcat As Button
    Friend WithEvents textnombrecat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textmarcap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textpreciop As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textnombrep As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textpresentacion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents textstock As TextBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dgvproducto As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents textbuscar As TextBox
    Friend WithEvents SinDatos As LinkLabel
    Friend WithEvents TextFlag As TextBox
End Class
