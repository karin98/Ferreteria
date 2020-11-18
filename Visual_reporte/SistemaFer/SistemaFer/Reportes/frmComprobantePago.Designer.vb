<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComprobantePago
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FerreteriasDataSet2 = New SistemaFer.FerreteriasDataSet2()
        Me.generar_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.generar_comprobanteTableAdapter = New SistemaFer.FerreteriasDataSet2TableAdapters.generar_comprobanteTableAdapter()
        Me.textIdventa = New System.Windows.Forms.TextBox()
        CType(Me.FerreteriasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.generar_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaFer.rdpComprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(530, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'FerreteriasDataSet2
        '
        Me.FerreteriasDataSet2.DataSetName = "FerreteriasDataSet2"
        Me.FerreteriasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'generar_comprobanteBindingSource
        '
        Me.generar_comprobanteBindingSource.DataMember = "generar_comprobante"
        Me.generar_comprobanteBindingSource.DataSource = Me.FerreteriasDataSet2
        '
        'generar_comprobanteTableAdapter
        '
        Me.generar_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'textIdventa
        '
        Me.textIdventa.Location = New System.Drawing.Point(158, 50)
        Me.textIdventa.Name = "textIdventa"
        Me.textIdventa.Size = New System.Drawing.Size(100, 20)
        Me.textIdventa.TabIndex = 1
        Me.textIdventa.Visible = False
        '
        'frmComprobantePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 450)
        Me.Controls.Add(Me.textIdventa)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmComprobantePago"
        Me.Text = "frmComprobantePago"
        CType(Me.FerreteriasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_comprobanteBindingSource As BindingSource
    Friend WithEvents FerreteriasDataSet2 As FerreteriasDataSet2
    Friend WithEvents generar_comprobanteTableAdapter As FerreteriasDataSet2TableAdapters.generar_comprobanteTableAdapter
    Friend WithEvents textIdventa As TextBox
End Class
