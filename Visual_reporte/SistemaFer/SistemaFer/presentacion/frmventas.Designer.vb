<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmventas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextFlag = New System.Windows.Forms.TextBox()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btncliente = New System.Windows.Forms.Button()
        Me.TextNumDoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textcodigoVenta = New System.Windows.Forms.TextBox()
        Me.btnbuscarcat = New System.Windows.Forms.Button()
        Me.textcodigoTrab = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textbuscar = New System.Windows.Forms.TextBox()
        Me.SinDatos = New System.Windows.Forms.LinkLabel()
        Me.DgvVenta = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextFlag)
        Me.Panel1.Controls.Add(Me.cbTipoDoc)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.btncancelar)
        Me.Panel1.Controls.Add(Me.btncliente)
        Me.Panel1.Controls.Add(Me.TextNumDoc)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.btneditar)
        Me.Panel1.Controls.Add(Me.Btnguardar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextCodigoCliente)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.textcodigoVenta)
        Me.Panel1.Controls.Add(Me.btnbuscarcat)
        Me.Panel1.Controls.Add(Me.textcodigoTrab)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 270)
        Me.Panel1.TabIndex = 1
        '
        'TextFlag
        '
        Me.TextFlag.Location = New System.Drawing.Point(319, 21)
        Me.TextFlag.Name = "TextFlag"
        Me.TextFlag.Size = New System.Drawing.Size(29, 20)
        Me.TextFlag.TabIndex = 33
        Me.TextFlag.Text = "0"
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cbTipoDoc.Location = New System.Drawing.Point(150, 151)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(163, 21)
        Me.cbTipoDoc.TabIndex = 32
        Me.cbTipoDoc.Text = "Boleta"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(150, 125)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(163, 20)
        Me.DtpFecha.TabIndex = 31
        '
        'btncancelar
        '
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Image = Global.SistemaFer.My.Resources.Resources.cancel
        Me.btncancelar.Location = New System.Drawing.Point(247, 212)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(74, 33)
        Me.btncancelar.TabIndex = 30
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btncliente
        '
        Me.btncliente.FlatAppearance.BorderSize = 0
        Me.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncliente.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncliente.Image = CType(resources.GetObject("btncliente.Image"), System.Drawing.Image)
        Me.btncliente.Location = New System.Drawing.Point(319, 89)
        Me.btncliente.Name = "btncliente"
        Me.btncliente.Size = New System.Drawing.Size(49, 29)
        Me.btncliente.TabIndex = 29
        Me.btncliente.UseVisualStyleBackColor = True
        '
        'TextNumDoc
        '
        Me.TextNumDoc.Location = New System.Drawing.Point(150, 175)
        Me.TextNumDoc.Name = "TextNumDoc"
        Me.TextNumDoc.Size = New System.Drawing.Size(163, 20)
        Me.TextNumDoc.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Codigo Cliente:"
        '
        'btneliminar
        '
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Image = Global.SistemaFer.My.Resources.Resources.trash
        Me.btneliminar.Location = New System.Drawing.Point(166, 212)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 33)
        Me.btneliminar.TabIndex = 27
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.FlatAppearance.BorderSize = 0
        Me.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneditar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneditar.Image = Global.SistemaFer.My.Resources.Resources.edit
        Me.btneditar.Location = New System.Drawing.Point(95, 212)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(65, 36)
        Me.btneditar.TabIndex = 26
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'Btnguardar
        '
        Me.Btnguardar.FlatAppearance.BorderSize = 0
        Me.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnguardar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Image = Global.SistemaFer.My.Resources.Resources.save
        Me.Btnguardar.Location = New System.Drawing.Point(14, 212)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(79, 36)
        Me.Btnguardar.TabIndex = 25
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nº_ Documento:"
        '
        'TextCodigoCliente
        '
        Me.TextCodigoCliente.Location = New System.Drawing.Point(150, 92)
        Me.TextCodigoCliente.Name = "TextCodigoCliente"
        Me.TextCodigoCliente.Size = New System.Drawing.Size(163, 20)
        Me.TextCodigoCliente.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha de Venta:"
        '
        'textcodigoVenta
        '
        Me.textcodigoVenta.Location = New System.Drawing.Point(150, 22)
        Me.textcodigoVenta.Name = "textcodigoVenta"
        Me.textcodigoVenta.Size = New System.Drawing.Size(76, 20)
        Me.textcodigoVenta.TabIndex = 4
        '
        'btnbuscarcat
        '
        Me.btnbuscarcat.FlatAppearance.BorderSize = 0
        Me.btnbuscarcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarcat.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarcat.Image = CType(resources.GetObject("btnbuscarcat.Image"), System.Drawing.Image)
        Me.btnbuscarcat.Location = New System.Drawing.Point(319, 51)
        Me.btnbuscarcat.Name = "btnbuscarcat"
        Me.btnbuscarcat.Size = New System.Drawing.Size(49, 29)
        Me.btnbuscarcat.TabIndex = 3
        Me.btnbuscarcat.UseVisualStyleBackColor = True
        '
        'textcodigoTrab
        '
        Me.textcodigoTrab.Location = New System.Drawing.Point(150, 54)
        Me.textcodigoTrab.Name = "textcodigoTrab"
        Me.textcodigoTrab.Size = New System.Drawing.Size(132, 20)
        Me.textcodigoTrab.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Codigo Trabajador:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Venta:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.textbuscar)
        Me.Panel2.Controls.Add(Me.SinDatos)
        Me.Panel2.Controls.Add(Me.DgvVenta)
        Me.Panel2.Location = New System.Drawing.Point(393, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 270)
        Me.Panel2.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 19)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Buscar:"
        '
        'textbuscar
        '
        Me.textbuscar.Location = New System.Drawing.Point(81, 26)
        Me.textbuscar.Name = "textbuscar"
        Me.textbuscar.Size = New System.Drawing.Size(400, 20)
        Me.textbuscar.TabIndex = 3
        '
        'SinDatos
        '
        Me.SinDatos.AutoSize = True
        Me.SinDatos.Location = New System.Drawing.Point(239, 145)
        Me.SinDatos.Name = "SinDatos"
        Me.SinDatos.Size = New System.Drawing.Size(59, 13)
        Me.SinDatos.TabIndex = 1
        Me.SinDatos.TabStop = True
        Me.SinDatos.Text = "LinkLabel1"
        '
        'DgvVenta
        '
        Me.DgvVenta.AllowUserToAddRows = False
        Me.DgvVenta.AllowUserToDeleteRows = False
        Me.DgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVenta.Location = New System.Drawing.Point(19, 52)
        Me.DgvVenta.Name = "DgvVenta"
        Me.DgvVenta.ReadOnly = True
        Me.DgvVenta.Size = New System.Drawing.Size(502, 196)
        Me.DgvVenta.TabIndex = 0
        '
        'frmventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(937, 301)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btneliminar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextCodigoCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textcodigoVenta As TextBox
    Friend WithEvents btnbuscarcat As Button
    Friend WithEvents textcodigoTrab As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents textbuscar As TextBox
    Friend WithEvents SinDatos As LinkLabel
    Friend WithEvents DgvVenta As DataGridView
    Friend WithEvents btncliente As Button
    Friend WithEvents TextNumDoc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btncancelar As Button
    Friend WithEvents cbTipoDoc As ComboBox
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents TextFlag As TextBox
End Class
