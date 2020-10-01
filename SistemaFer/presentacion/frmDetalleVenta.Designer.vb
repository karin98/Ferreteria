<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleVenta))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextPresentacion = New System.Windows.Forms.TextBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.TextCodDV = New System.Windows.Forms.TextBox()
        Me.TextStock2 = New System.Windows.Forms.TextBox()
        Me.TextCantidad2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextPrecio = New System.Windows.Forms.TextBox()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnCodigoProd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextCodigoProd = New System.Windows.Forms.TextBox()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextNumDoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textcodigoVenta = New System.Windows.Forms.TextBox()
        Me.textcodigoTrab = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SinDatos = New System.Windows.Forms.LinkLabel()
        Me.DgvDetalleVenta = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvDetalleVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.TextPresentacion)
        Me.Panel1.Controls.Add(Me.BtnImprimir)
        Me.Panel1.Controls.Add(Me.btnValidar)
        Me.Panel1.Controls.Add(Me.TextCodDV)
        Me.Panel1.Controls.Add(Me.TextStock2)
        Me.Panel1.Controls.Add(Me.TextCantidad2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TextPrecio)
        Me.Panel1.Controls.Add(Me.BtnVenta)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.BtnCodigoProd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextCodigoProd)
        Me.Panel1.Controls.Add(Me.cbTipoDoc)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.TextNumDoc)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Btnguardar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextCodigoCliente)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.textcodigoVenta)
        Me.Panel1.Controls.Add(Me.textcodigoTrab)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 369)
        Me.Panel1.TabIndex = 2
        '
        'TextPresentacion
        '
        Me.TextPresentacion.Location = New System.Drawing.Point(139, 265)
        Me.TextPresentacion.Name = "TextPresentacion"
        Me.TextPresentacion.Size = New System.Drawing.Size(76, 20)
        Me.TextPresentacion.TabIndex = 49
        '
        'BtnImprimir
        '
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(207, 323)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(50, 42)
        Me.BtnImprimir.TabIndex = 48
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'btnValidar
        '
        Me.btnValidar.FlatAppearance.BorderSize = 0
        Me.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.Image = CType(resources.GetObject("btnValidar.Image"), System.Drawing.Image)
        Me.btnValidar.Location = New System.Drawing.Point(288, 230)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(63, 35)
        Me.btnValidar.TabIndex = 47
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'TextCodDV
        '
        Me.TextCodDV.Location = New System.Drawing.Point(288, 21)
        Me.TextCodDV.Name = "TextCodDV"
        Me.TextCodDV.Size = New System.Drawing.Size(30, 20)
        Me.TextCodDV.TabIndex = 46
        Me.TextCodDV.Visible = False
        '
        'TextStock2
        '
        Me.TextStock2.Location = New System.Drawing.Point(236, 239)
        Me.TextStock2.Name = "TextStock2"
        Me.TextStock2.Size = New System.Drawing.Size(52, 20)
        Me.TextStock2.TabIndex = 45
        Me.TextStock2.Text = "1"
        '
        'TextCantidad2
        '
        Me.TextCantidad2.Location = New System.Drawing.Point(139, 238)
        Me.TextCantidad2.Name = "TextCantidad2"
        Me.TextCantidad2.Size = New System.Drawing.Size(45, 20)
        Me.TextCantidad2.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(63, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 19)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Precio:"
        '
        'TextPrecio
        '
        Me.TextPrecio.Location = New System.Drawing.Point(139, 291)
        Me.TextPrecio.Name = "TextPrecio"
        Me.TextPrecio.Size = New System.Drawing.Size(76, 20)
        Me.TextPrecio.TabIndex = 42
        '
        'BtnVenta
        '
        Me.BtnVenta.FlatAppearance.BorderSize = 0
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.Image = CType(resources.GetObject("BtnVenta.Image"), System.Drawing.Image)
        Me.BtnVenta.Location = New System.Drawing.Point(221, 15)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(61, 29)
        Me.BtnVenta.TabIndex = 41
        Me.BtnVenta.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(190, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Stock:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 19)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Cantidad:"
        '
        'BtnCodigoProd
        '
        Me.BtnCodigoProd.FlatAppearance.BorderSize = 0
        Me.BtnCodigoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCodigoProd.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCodigoProd.Image = CType(resources.GetObject("BtnCodigoProd.Image"), System.Drawing.Image)
        Me.BtnCodigoProd.Location = New System.Drawing.Point(221, 205)
        Me.BtnCodigoProd.Name = "BtnCodigoProd"
        Me.BtnCodigoProd.Size = New System.Drawing.Size(49, 29)
        Me.BtnCodigoProd.TabIndex = 35
        Me.BtnCodigoProd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Codigo Producto:"
        '
        'TextCodigoProd
        '
        Me.TextCodigoProd.Location = New System.Drawing.Point(139, 211)
        Me.TextCodigoProd.Name = "TextCodigoProd"
        Me.TextCodigoProd.Size = New System.Drawing.Size(76, 20)
        Me.TextCodigoProd.TabIndex = 34
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cbTipoDoc.Location = New System.Drawing.Point(139, 151)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(163, 21)
        Me.cbTipoDoc.TabIndex = 32
        Me.cbTipoDoc.Text = "Boleta"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(139, 125)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(163, 20)
        Me.DtpFecha.TabIndex = 31
        '
        'TextNumDoc
        '
        Me.TextNumDoc.Location = New System.Drawing.Point(139, 175)
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
        'Btnguardar
        '
        Me.Btnguardar.FlatAppearance.BorderSize = 0
        Me.Btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnguardar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Image = Global.SistemaFer.My.Resources.Resources.save
        Me.Btnguardar.Location = New System.Drawing.Point(94, 323)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(50, 42)
        Me.Btnguardar.TabIndex = 25
        Me.Btnguardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nº_ Documento:"
        '
        'TextCodigoCliente
        '
        Me.TextCodigoCliente.Location = New System.Drawing.Point(139, 92)
        Me.TextCodigoCliente.Name = "TextCodigoCliente"
        Me.TextCodigoCliente.Size = New System.Drawing.Size(76, 20)
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
        Me.textcodigoVenta.Location = New System.Drawing.Point(139, 22)
        Me.textcodigoVenta.Name = "textcodigoVenta"
        Me.textcodigoVenta.Size = New System.Drawing.Size(76, 20)
        Me.textcodigoVenta.TabIndex = 4
        '
        'textcodigoTrab
        '
        Me.textcodigoTrab.Location = New System.Drawing.Point(139, 54)
        Me.textcodigoTrab.Name = "textcodigoTrab"
        Me.textcodigoTrab.Size = New System.Drawing.Size(76, 20)
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
        'btncancelar
        '
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Image = Global.SistemaFer.My.Resources.Resources.cancel
        Me.btncancelar.Location = New System.Drawing.Point(266, 293)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(152, 47)
        Me.btncancelar.TabIndex = 30
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.btncancelar)
        Me.Panel2.Controls.Add(Me.SinDatos)
        Me.Panel2.Controls.Add(Me.DgvDetalleVenta)
        Me.Panel2.Location = New System.Drawing.Point(393, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 369)
        Me.Panel2.TabIndex = 3
        '
        'btnEliminar
        '
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.SistemaFer.My.Resources.Resources.trash
        Me.btnEliminar.Location = New System.Drawing.Point(108, 291)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 50)
        Me.btnEliminar.TabIndex = 31
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Text", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(158, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(222, 28)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "LISTA DE PRODUCTOS"
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
        'DgvDetalleVenta
        '
        Me.DgvDetalleVenta.AllowUserToAddRows = False
        Me.DgvDetalleVenta.AllowUserToDeleteRows = False
        Me.DgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleVenta.Location = New System.Drawing.Point(18, 65)
        Me.DgvDetalleVenta.Name = "DgvDetalleVenta"
        Me.DgvDetalleVenta.ReadOnly = True
        Me.DgvDetalleVenta.Size = New System.Drawing.Size(502, 225)
        Me.DgvDetalleVenta.TabIndex = 0
        '
        'frmDetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(938, 386)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDetalleVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleVenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgvDetalleVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbTipoDoc As ComboBox
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents btncancelar As Button
    Friend WithEvents TextNumDoc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btnguardar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextCodigoCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textcodigoVenta As TextBox
    Friend WithEvents textcodigoTrab As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnCodigoProd As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextCodigoProd As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SinDatos As LinkLabel
    Friend WithEvents DgvDetalleVenta As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnVenta As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TextPrecio As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents TextCantidad2 As TextBox
    Friend WithEvents TextStock2 As TextBox
    Friend WithEvents TextCodDV As TextBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents TextPresentacion As TextBox
End Class
