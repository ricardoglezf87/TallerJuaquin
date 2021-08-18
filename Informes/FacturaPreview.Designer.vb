<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaPreview
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaPreview))
        Me.BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpcionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteCocheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.BlancoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpcionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteCocheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlancoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BalanceBindingSource
        '
        Me.BalanceBindingSource.DataMember = "Balance"
        Me.BalanceBindingSource.DataSource = GetType(DataBaseLib.DatosTallerDataSet)
        '
        'OpcionesBindingSource
        '
        Me.OpcionesBindingSource.DataMember = "Opciones"
        Me.OpcionesBindingSource.DataSource = GetType(DataBaseLib.DatosTallerDataSet)
        '
        'ClienteCocheBindingSource
        '
        Me.ClienteCocheBindingSource.DataMember = "ClienteCoche"
        Me.ClienteCocheBindingSource.DataSource = GetType(DataBaseLib.DatosTallerDataSet)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DatosTallerDataSet_Balance"
        ReportDataSource1.Value = Me.BalanceBindingSource
        ReportDataSource2.Name = "DatosTallerDataSet_Opciones"
        ReportDataSource2.Value = Me.OpcionesBindingSource
        ReportDataSource3.Name = "DatosTallerDataSet_ClienteCoche"
        ReportDataSource3.Value = Me.ClienteCocheBindingSource
        ReportDataSource4.Name = "DatosTallerDataSet_Blanco"
        ReportDataSource4.Value = Me.BlancoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Reports.Fact.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(903, 413)
        Me.ReportViewer1.TabIndex = 0
        '
        'BlancoBindingSource
        '
        Me.BlancoBindingSource.DataMember = "Blanco"
        Me.BlancoBindingSource.DataSource = GetType(DataBaseLib.DatosTallerDataSet)
        '
        'FacturaPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 413)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FacturaPreview"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Previsualización Factura "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpcionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteCocheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlancoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpcionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteCocheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BlancoBindingSource As System.Windows.Forms.BindingSource

End Class
