<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.histoclinDataSet = New prueba_histoclin_consola.histoclinDataSet()
        Me.bt_canc_dosisunitariaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_canc_dosisunitariaTableAdapter = New prueba_histoclin_consola.histoclinDataSetTableAdapters.bt_canc_dosisunitariaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.histoclinDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bt_canc_dosisunitariaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 182)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Arteaga"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(24, 102)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 21)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Hinojosa"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Edgar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.bt_canc_dosisunitariaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "prueba_histoclin_consola.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(234, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(946, 632)
        Me.ReportViewer1.TabIndex = 1
        '
        'histoclinDataSet
        '
        Me.histoclinDataSet.DataSetName = "histoclinDataSet"
        Me.histoclinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bt_canc_dosisunitariaBindingSource
        '
        Me.bt_canc_dosisunitariaBindingSource.DataMember = "bt_canc_dosisunitaria"
        Me.bt_canc_dosisunitariaBindingSource.DataSource = Me.histoclinDataSet
        '
        'bt_canc_dosisunitariaTableAdapter
        '
        Me.bt_canc_dosisunitariaTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 695)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Descargando Edgar..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.histoclinDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bt_canc_dosisunitariaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents bt_canc_dosisunitariaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents histoclinDataSet As prueba_histoclin_consola.histoclinDataSet
    Friend WithEvents bt_canc_dosisunitariaTableAdapter As prueba_histoclin_consola.histoclinDataSetTableAdapters.bt_canc_dosisunitariaTableAdapter
End Class
