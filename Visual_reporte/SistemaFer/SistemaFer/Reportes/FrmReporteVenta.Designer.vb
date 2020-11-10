<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteVenta
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
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BuscarDetalleVenta4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FerreteriasDataSet = New SistemaFer.FerreteriasDataSet()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BuscarDetalleVenta4TableAdapter = New SistemaFer.FerreteriasDataSetTableAdapters.BuscarDetalleVenta4TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.BuscarDetalleVenta4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FerreteriasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscarDetalleVenta4BindingSource
        '
        Me.BuscarDetalleVenta4BindingSource.DataMember = "BuscarDetalleVenta4"
        Me.BuscarDetalleVenta4BindingSource.DataSource = Me.FerreteriasDataSet
        '
        'FerreteriasDataSet
        '
        Me.FerreteriasDataSet.DataSetName = "FerreteriasDataSet"
        Me.FerreteriasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBuscar
        '
        Me.TextBuscar.Location = New System.Drawing.Point(224, 27)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(220, 20)
        Me.TextBuscar.TabIndex = 1
        '
        'ReportViewer1
        '
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.BuscarDetalleVenta4BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaFer.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(7, 75)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(703, 258)
        Me.ReportViewer1.TabIndex = 2
        '
        'BuscarDetalleVenta4TableAdapter
        '
        Me.BuscarDetalleVenta4TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo de Venta:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Image = Global.SistemaFer.My.Resources.Resources.search
        Me.BtnBuscar.Location = New System.Drawing.Point(450, 20)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(84, 33)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.SistemaFer.My.Resources.Resources.cancel
        Me.Button1.Location = New System.Drawing.Point(527, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmReporteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(727, 356)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.TextBuscar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "FrmReporteVenta"
        Me.Text = "FrmReporteVenta"
        CType(Me.BuscarDetalleVenta4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FerreteriasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BuscarDetalleVenta4BindingSource As BindingSource
    Friend WithEvents FerreteriasDataSet As FerreteriasDataSet
    Friend WithEvents BuscarDetalleVenta4TableAdapter As FerreteriasDataSetTableAdapters.BuscarDetalleVenta4TableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
