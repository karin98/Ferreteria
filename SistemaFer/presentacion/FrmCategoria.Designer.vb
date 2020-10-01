<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoria))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.textflag = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.DgvCategoria = New System.Windows.Forms.DataGridView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.lbInexistente = New System.Windows.Forms.LinkLabel()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Textnombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Textcodigo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 96)
        Me.Panel1.TabIndex = 0
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(92, 45)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(170, 20)
        Me.Textnombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Textcodigo
        '
        Me.Textcodigo.Location = New System.Drawing.Point(91, 9)
        Me.Textcodigo.Name = "Textcodigo"
        Me.Textcodigo.Size = New System.Drawing.Size(171, 20)
        Me.Textcodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'BtnEditar
        '
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = Global.SistemaFer.My.Resources.Resources.edit
        Me.BtnEditar.Location = New System.Drawing.Point(286, 49)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(72, 35)
        Me.BtnEditar.TabIndex = 6
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.SistemaFer.My.Resources.Resources.save
        Me.BtnGuardar.Location = New System.Drawing.Point(286, 3)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(72, 40)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'textflag
        '
        Me.textflag.Location = New System.Drawing.Point(286, 9)
        Me.textflag.Name = "textflag"
        Me.textflag.Size = New System.Drawing.Size(19, 20)
        Me.textflag.TabIndex = 7
        Me.textflag.Text = "0"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.SistemaFer.My.Resources.Resources.cancel
        Me.BtnNuevo.Location = New System.Drawing.Point(259, 66)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(81, 47)
        Me.BtnNuevo.TabIndex = 7
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'DgvCategoria
        '
        Me.DgvCategoria.AllowUserToAddRows = False
        Me.DgvCategoria.AllowUserToDeleteRows = False
        Me.DgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCategoria.Location = New System.Drawing.Point(3, 50)
        Me.DgvCategoria.Name = "DgvCategoria"
        Me.DgvCategoria.ReadOnly = True
        Me.DgvCategoria.Size = New System.Drawing.Size(235, 150)
        Me.DgvCategoria.TabIndex = 1
        '
        'BtnEliminar
        '
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Sitka Text", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.SistemaFer.My.Resources.Resources.trash
        Me.BtnEliminar.Location = New System.Drawing.Point(259, 119)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(81, 52)
        Me.BtnEliminar.TabIndex = 7
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnBuscar)
        Me.Panel3.Controls.Add(Me.textflag)
        Me.Panel3.Controls.Add(Me.BtnEliminar)
        Me.Panel3.Controls.Add(Me.BtnNuevo)
        Me.Panel3.Controls.Add(Me.lbInexistente)
        Me.Panel3.Controls.Add(Me.DgvCategoria)
        Me.Panel3.Controls.Add(Me.TextBuscar)
        Me.Panel3.Location = New System.Drawing.Point(12, 114)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(373, 219)
        Me.Panel3.TabIndex = 3
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.Location = New System.Drawing.Point(11, 9)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(56, 35)
        Me.BtnBuscar.TabIndex = 9
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'lbInexistente
        '
        Me.lbInexistente.AutoSize = True
        Me.lbInexistente.Location = New System.Drawing.Point(69, 111)
        Me.lbInexistente.Name = "lbInexistente"
        Me.lbInexistente.Size = New System.Drawing.Size(53, 13)
        Me.lbInexistente.TabIndex = 8
        Me.lbInexistente.TabStop = True
        Me.lbInexistente.Text = "Sin Datos"
        '
        'TextBuscar
        '
        Me.TextBuscar.Location = New System.Drawing.Point(74, 9)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(188, 20)
        Me.TextBuscar.TabIndex = 5
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(397, 348)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Categorias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvCategoria As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents lbInexistente As LinkLabel
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents textflag As TextBox
    Friend WithEvents BtnBuscar As Button
End Class
