<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PruebaDs = New SistemaUCA.PruebaDs()
        Me.PruebaDsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadTableAdapter = New SistemaUCA.PruebaDsTableAdapters.CiudadTableAdapter()
        CType(Me.PruebaDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PruebaDsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CiudadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaUCA.RptCiudades.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'PruebaDs
        '
        Me.PruebaDs.DataSetName = "PruebaDs"
        Me.PruebaDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PruebaDsBindingSource
        '
        Me.PruebaDsBindingSource.DataSource = Me.PruebaDs
        Me.PruebaDsBindingSource.Position = 0
        '
        'CiudadBindingSource
        '
        Me.CiudadBindingSource.DataMember = "Ciudad"
        Me.CiudadBindingSource.DataSource = Me.PruebaDs
        '
        'CiudadTableAdapter
        '
        Me.CiudadTableAdapter.ClearBeforeFill = True
        '
        'FrmVistaPrevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FrmVistaPrevia"
        Me.Text = "Vista Previa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PruebaDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PruebaDsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PruebaDs As PruebaDs
    Friend WithEvents PruebaDsBindingSource As BindingSource
    Friend WithEvents CiudadBindingSource As BindingSource
    Friend WithEvents CiudadTableAdapter As PruebaDsTableAdapters.CiudadTableAdapter
End Class
