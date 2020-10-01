<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmventa
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.chkeliminar = New System.Windows.Forms.CheckBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbcampo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.chkeliminar)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbcampo)
        Me.GroupBox2.Location = New System.Drawing.Point(276, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 300)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTADO DE VENTAS "
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(97, 164)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(57, 13)
        Me.inexistente.TabIndex = 18
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "inexistente"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(25, 261)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'chkeliminar
        '
        Me.chkeliminar.AutoSize = True
        Me.chkeliminar.Location = New System.Drawing.Point(7, 56)
        Me.chkeliminar.Name = "chkeliminar"
        Me.chkeliminar.Size = New System.Drawing.Size(62, 17)
        Me.chkeliminar.TabIndex = 11
        Me.chkeliminar.Text = "Eliminar"
        Me.chkeliminar.UseVisualStyleBackColor = True
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(16, 93)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(416, 150)
        Me.datalistado.TabIndex = 10
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(233, 28)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(199, 20)
        Me.txtbuscar.TabIndex = 9
        '
        'cbcampo
        '
        Me.cbcampo.FormattingEnabled = True
        Me.cbcampo.Items.AddRange(New Object() {"NOMBRE", "APELLIDO", "DNI", "TELEFONO"})
        Me.cbcampo.Location = New System.Drawing.Point(6, 28)
        Me.cbcampo.Name = "cbcampo"
        Me.cbcampo.Size = New System.Drawing.Size(178, 21)
        Me.cbcampo.TabIndex = 0
        Me.cbcampo.Text = "DNI"
        '
        'frmventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 481)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmventa"
        Me.Text = "frmventa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents chkeliminar As CheckBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbcampo As ComboBox
End Class
