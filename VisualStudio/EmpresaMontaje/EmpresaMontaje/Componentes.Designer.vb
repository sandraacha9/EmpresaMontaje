<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Componentes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Componentes))
        Me.TsComponentes = New System.Windows.Forms.ToolStrip()
        Me.TsNuevoComponente = New System.Windows.Forms.ToolStripButton()
        Me.TsBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsPrimero = New System.Windows.Forms.ToolStripButton()
        Me.TsAnterior = New System.Windows.Forms.ToolStripButton()
        Me.TsSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.TsUltimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbNombreComponente = New System.Windows.Forms.ComboBox()
        Me.DtgComponentes = New System.Windows.Forms.DataGridView()
        Me.TxtStockMin = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.StockMinimo = New System.Windows.Forms.Label()
        Me.Stock = New System.Windows.Forms.Label()
        Me.TxtDescComponente = New System.Windows.Forms.TextBox()
        Me.TxtNombreComponente = New System.Windows.Forms.TextBox()
        Me.DescComponente = New System.Windows.Forms.Label()
        Me.NombreComponente = New System.Windows.Forms.Label()
        Me.TxtPrecioComponente = New System.Windows.Forms.TextBox()
        Me.PrecioProducto = New System.Windows.Forms.Label()
        Me.TxtIDComponente = New System.Windows.Forms.TextBox()
        Me.IdComponente = New System.Windows.Forms.Label()
        Me.TsComponentes.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DtgComponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TsComponentes
        '
        Me.TsComponentes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsNuevoComponente, Me.TsBorrar, Me.ToolStripSeparator1, Me.TsPrimero, Me.TsAnterior, Me.TsSiguiente, Me.TsUltimo, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.TsSalir})
        Me.TsComponentes.Location = New System.Drawing.Point(0, 0)
        Me.TsComponentes.Name = "TsComponentes"
        Me.TsComponentes.Size = New System.Drawing.Size(585, 25)
        Me.TsComponentes.TabIndex = 64
        Me.TsComponentes.Text = "ToolStrip1"
        '
        'TsNuevoComponente
        '
        Me.TsNuevoComponente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsNuevoComponente.Image = CType(resources.GetObject("TsNuevoComponente.Image"), System.Drawing.Image)
        Me.TsNuevoComponente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsNuevoComponente.Name = "TsNuevoComponente"
        Me.TsNuevoComponente.Size = New System.Drawing.Size(23, 22)
        Me.TsNuevoComponente.Text = "Nuevo Componente"
        Me.TsNuevoComponente.ToolTipText = "Añadir un componente nuevo"
        '
        'TsBorrar
        '
        Me.TsBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsBorrar.Image = CType(resources.GetObject("TsBorrar.Image"), System.Drawing.Image)
        Me.TsBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsBorrar.Name = "TsBorrar"
        Me.TsBorrar.Size = New System.Drawing.Size(23, 22)
        Me.TsBorrar.Text = "Borrar Componente"
        Me.TsBorrar.ToolTipText = "Borrar el componente seleccionado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TsPrimero
        '
        Me.TsPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsPrimero.Image = CType(resources.GetObject("TsPrimero.Image"), System.Drawing.Image)
        Me.TsPrimero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsPrimero.Name = "TsPrimero"
        Me.TsPrimero.Size = New System.Drawing.Size(23, 22)
        Me.TsPrimero.Text = "Primero"
        Me.TsPrimero.ToolTipText = "Ir al primer componente"
        '
        'TsAnterior
        '
        Me.TsAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsAnterior.Image = CType(resources.GetObject("TsAnterior.Image"), System.Drawing.Image)
        Me.TsAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsAnterior.Name = "TsAnterior"
        Me.TsAnterior.Size = New System.Drawing.Size(23, 22)
        Me.TsAnterior.Text = "Anterior"
        Me.TsAnterior.ToolTipText = "Ir al componente anterior"
        '
        'TsSiguiente
        '
        Me.TsSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsSiguiente.Image = CType(resources.GetObject("TsSiguiente.Image"), System.Drawing.Image)
        Me.TsSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSiguiente.Name = "TsSiguiente"
        Me.TsSiguiente.Size = New System.Drawing.Size(23, 22)
        Me.TsSiguiente.Text = "Siguiente"
        Me.TsSiguiente.ToolTipText = "Ir al siguiente componente"
        '
        'TsUltimo
        '
        Me.TsUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsUltimo.Image = CType(resources.GetObject("TsUltimo.Image"), System.Drawing.Image)
        Me.TsUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsUltimo.Name = "TsUltimo"
        Me.TsUltimo.Size = New System.Drawing.Size(23, 22)
        Me.TsUltimo.Text = "Ultimo"
        Me.TsUltimo.ToolTipText = "Ir al ultimo componente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'TsSalir
        '
        Me.TsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsSalir.Image = CType(resources.GetObject("TsSalir.Image"), System.Drawing.Image)
        Me.TsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsSalir.Name = "TsSalir"
        Me.TsSalir.Size = New System.Drawing.Size(23, 22)
        Me.TsSalir.Text = "Salir"
        Me.TsSalir.ToolTipText = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbNombreComponente)
        Me.GroupBox1.Location = New System.Drawing.Point(412, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 62)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Componente"
        '
        'CmbNombreComponente
        '
        Me.CmbNombreComponente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNombreComponente.FormattingEnabled = True
        Me.CmbNombreComponente.Location = New System.Drawing.Point(16, 28)
        Me.CmbNombreComponente.Name = "CmbNombreComponente"
        Me.CmbNombreComponente.Size = New System.Drawing.Size(121, 21)
        Me.CmbNombreComponente.TabIndex = 0
        '
        'DtgComponentes
        '
        Me.DtgComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgComponentes.Location = New System.Drawing.Point(16, 262)
        Me.DtgComponentes.Name = "DtgComponentes"
        Me.DtgComponentes.ReadOnly = True
        Me.DtgComponentes.Size = New System.Drawing.Size(549, 175)
        Me.DtgComponentes.TabIndex = 62
        '
        'TxtStockMin
        '
        Me.TxtStockMin.Location = New System.Drawing.Point(159, 194)
        Me.TxtStockMin.MaxLength = 25
        Me.TxtStockMin.Name = "TxtStockMin"
        Me.TxtStockMin.ReadOnly = True
        Me.TxtStockMin.Size = New System.Drawing.Size(232, 20)
        Me.TxtStockMin.TabIndex = 60
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(159, 166)
        Me.TxtStock.MaxLength = 5
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(232, 20)
        Me.TxtStock.TabIndex = 59
        '
        'StockMinimo
        '
        Me.StockMinimo.Location = New System.Drawing.Point(16, 194)
        Me.StockMinimo.Name = "StockMinimo"
        Me.StockMinimo.Size = New System.Drawing.Size(117, 13)
        Me.StockMinimo.TabIndex = 54
        Me.StockMinimo.Text = "Stock Minimo:"
        '
        'Stock
        '
        Me.Stock.Location = New System.Drawing.Point(16, 166)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(117, 13)
        Me.Stock.TabIndex = 53
        Me.Stock.Text = "Stock:"
        '
        'TxtDescComponente
        '
        Me.TxtDescComponente.Location = New System.Drawing.Point(159, 97)
        Me.TxtDescComponente.MaxLength = 50
        Me.TxtDescComponente.Multiline = True
        Me.TxtDescComponente.Name = "TxtDescComponente"
        Me.TxtDescComponente.ReadOnly = True
        Me.TxtDescComponente.Size = New System.Drawing.Size(232, 57)
        Me.TxtDescComponente.TabIndex = 81
        '
        'TxtNombreComponente
        '
        Me.TxtNombreComponente.Location = New System.Drawing.Point(159, 68)
        Me.TxtNombreComponente.MaxLength = 50
        Me.TxtNombreComponente.Name = "TxtNombreComponente"
        Me.TxtNombreComponente.ReadOnly = True
        Me.TxtNombreComponente.Size = New System.Drawing.Size(232, 20)
        Me.TxtNombreComponente.TabIndex = 80
        '
        'DescComponente
        '
        Me.DescComponente.Location = New System.Drawing.Point(16, 97)
        Me.DescComponente.Name = "DescComponente"
        Me.DescComponente.Size = New System.Drawing.Size(117, 13)
        Me.DescComponente.TabIndex = 79
        Me.DescComponente.Text = "Descripcion:"
        '
        'NombreComponente
        '
        Me.NombreComponente.Location = New System.Drawing.Point(16, 71)
        Me.NombreComponente.Name = "NombreComponente"
        Me.NombreComponente.Size = New System.Drawing.Size(117, 13)
        Me.NombreComponente.TabIndex = 78
        Me.NombreComponente.Text = "Nombre:"
        '
        'TxtPrecioComponente
        '
        Me.TxtPrecioComponente.Location = New System.Drawing.Point(159, 227)
        Me.TxtPrecioComponente.MaxLength = 25
        Me.TxtPrecioComponente.Name = "TxtPrecioComponente"
        Me.TxtPrecioComponente.ReadOnly = True
        Me.TxtPrecioComponente.Size = New System.Drawing.Size(232, 20)
        Me.TxtPrecioComponente.TabIndex = 83
        '
        'PrecioProducto
        '
        Me.PrecioProducto.Location = New System.Drawing.Point(16, 227)
        Me.PrecioProducto.Name = "PrecioProducto"
        Me.PrecioProducto.Size = New System.Drawing.Size(117, 13)
        Me.PrecioProducto.TabIndex = 82
        Me.PrecioProducto.Text = "Precio:"
        '
        'TxtIDComponente
        '
        Me.TxtIDComponente.Location = New System.Drawing.Point(159, 37)
        Me.TxtIDComponente.MaxLength = 50
        Me.TxtIDComponente.Name = "TxtIDComponente"
        Me.TxtIDComponente.ReadOnly = True
        Me.TxtIDComponente.Size = New System.Drawing.Size(232, 20)
        Me.TxtIDComponente.TabIndex = 85
        '
        'IdComponente
        '
        Me.IdComponente.Location = New System.Drawing.Point(16, 40)
        Me.IdComponente.Name = "IdComponente"
        Me.IdComponente.Size = New System.Drawing.Size(117, 13)
        Me.IdComponente.TabIndex = 84
        Me.IdComponente.Text = "ID:"
        '
        'Componentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 449)
        Me.Controls.Add(Me.TxtIDComponente)
        Me.Controls.Add(Me.IdComponente)
        Me.Controls.Add(Me.TxtPrecioComponente)
        Me.Controls.Add(Me.PrecioProducto)
        Me.Controls.Add(Me.TxtDescComponente)
        Me.Controls.Add(Me.TxtNombreComponente)
        Me.Controls.Add(Me.DescComponente)
        Me.Controls.Add(Me.NombreComponente)
        Me.Controls.Add(Me.TsComponentes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgComponentes)
        Me.Controls.Add(Me.TxtStockMin)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.StockMinimo)
        Me.Controls.Add(Me.Stock)
        Me.Name = "Componentes"
        Me.Text = "Componentes"
        Me.TsComponentes.ResumeLayout(False)
        Me.TsComponentes.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DtgComponentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TsComponentes As System.Windows.Forms.ToolStrip
    Friend WithEvents TsNuevoComponente As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbNombreComponente As System.Windows.Forms.ComboBox
    Friend WithEvents DtgComponentes As System.Windows.Forms.DataGridView
    Friend WithEvents TxtStockMin As System.Windows.Forms.TextBox
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents StockMinimo As System.Windows.Forms.Label
    Friend WithEvents Stock As System.Windows.Forms.Label
    Friend WithEvents TxtDescComponente As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreComponente As System.Windows.Forms.TextBox
    Friend WithEvents DescComponente As System.Windows.Forms.Label
    Friend WithEvents NombreComponente As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioComponente As System.Windows.Forms.TextBox
    Friend WithEvents PrecioProducto As System.Windows.Forms.Label
    Friend WithEvents TxtIDComponente As System.Windows.Forms.TextBox
    Friend WithEvents IdComponente As System.Windows.Forms.Label
End Class
