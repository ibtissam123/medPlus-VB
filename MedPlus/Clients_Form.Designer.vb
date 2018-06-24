<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients_Form
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.combo_client = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nom_client = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_produits = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_mdp_client = New System.Windows.Forms.TextBox()
        Me.txt_ndc_client = New System.Windows.Forms.TextBox()
        Me.txt_adresse_client = New System.Windows.Forms.TextBox()
        Me.txt_age_client = New System.Windows.Forms.TextBox()
        Me.txt_prenom_client = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmd_nom_produit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_price_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_quantity_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_totalprice_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_checked_product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idproduct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcommande = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_commandes = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'combo_client
        '
        Me.combo_client.FormattingEnabled = True
        Me.combo_client.Location = New System.Drawing.Point(36, 63)
        Me.combo_client.Name = "combo_client"
        Me.combo_client.Size = New System.Drawing.Size(312, 21)
        Me.combo_client.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom"
        '
        'txt_nom_client
        '
        Me.txt_nom_client.Location = New System.Drawing.Point(27, 48)
        Me.txt_nom_client.Name = "txt_nom_client"
        Me.txt_nom_client.Size = New System.Drawing.Size(225, 20)
        Me.txt_nom_client.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Séléctionnez un client :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btn_produits)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_mdp_client)
        Me.GroupBox1.Controls.Add(Me.txt_ndc_client)
        Me.GroupBox1.Controls.Add(Me.txt_adresse_client)
        Me.GroupBox1.Controls.Add(Me.txt_age_client)
        Me.GroupBox1.Controls.Add(Me.txt_prenom_client)
        Me.GroupBox1.Controls.Add(Me.txt_nom_client)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 438)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations Client"
        '
        'btn_produits
        '
        Me.btn_produits.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_produits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_produits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_produits.FlatAppearance.BorderSize = 0
        Me.btn_produits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_produits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_produits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_produits.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btn_produits.Location = New System.Drawing.Point(17, 354)
        Me.btn_produits.Name = "btn_produits"
        Me.btn_produits.Size = New System.Drawing.Size(252, 33)
        Me.btn_produits.TabIndex = 5
        Me.btn_produits.Text = "Enregistrer Modifications"
        Me.btn_produits.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Mot de passe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nom de compte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Adresse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prenom"
        '
        'txt_mdp_client
        '
        Me.txt_mdp_client.Location = New System.Drawing.Point(27, 319)
        Me.txt_mdp_client.Name = "txt_mdp_client"
        Me.txt_mdp_client.Size = New System.Drawing.Size(225, 20)
        Me.txt_mdp_client.TabIndex = 3
        '
        'txt_ndc_client
        '
        Me.txt_ndc_client.Location = New System.Drawing.Point(27, 267)
        Me.txt_ndc_client.Name = "txt_ndc_client"
        Me.txt_ndc_client.Size = New System.Drawing.Size(225, 20)
        Me.txt_ndc_client.TabIndex = 3
        '
        'txt_adresse_client
        '
        Me.txt_adresse_client.Location = New System.Drawing.Point(27, 213)
        Me.txt_adresse_client.Name = "txt_adresse_client"
        Me.txt_adresse_client.Size = New System.Drawing.Size(225, 20)
        Me.txt_adresse_client.TabIndex = 3
        '
        'txt_age_client
        '
        Me.txt_age_client.Location = New System.Drawing.Point(27, 157)
        Me.txt_age_client.Name = "txt_age_client"
        Me.txt_age_client.Size = New System.Drawing.Size(225, 20)
        Me.txt_age_client.TabIndex = 3
        '
        'txt_prenom_client
        '
        Me.txt_prenom_client.Location = New System.Drawing.Point(27, 105)
        Me.txt_prenom_client.Name = "txt_prenom_client"
        Me.txt_prenom_client.Size = New System.Drawing.Size(225, 20)
        Me.txt_prenom_client.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cmd_nom_produit, Me.cmd_price_product, Me.cmd_quantity_product, Me.cmd_totalprice_product, Me.cmd_checked_product, Me.idproduct, Me.idcommande})
        Me.DataGridView1.Location = New System.Drawing.Point(334, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 421)
        Me.DataGridView1.TabIndex = 5
        '
        'cmd_nom_produit
        '
        Me.cmd_nom_produit.HeaderText = "Nom de produit"
        Me.cmd_nom_produit.Name = "cmd_nom_produit"
        Me.cmd_nom_produit.ReadOnly = True
        Me.cmd_nom_produit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmd_price_product
        '
        Me.cmd_price_product.HeaderText = "Prix Unitaire "
        Me.cmd_price_product.Name = "cmd_price_product"
        Me.cmd_price_product.ReadOnly = True
        Me.cmd_price_product.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmd_quantity_product
        '
        Me.cmd_quantity_product.HeaderText = "Quantité"
        Me.cmd_quantity_product.Name = "cmd_quantity_product"
        Me.cmd_quantity_product.ReadOnly = True
        Me.cmd_quantity_product.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmd_totalprice_product
        '
        Me.cmd_totalprice_product.HeaderText = "Prix Total"
        Me.cmd_totalprice_product.Name = "cmd_totalprice_product"
        Me.cmd_totalprice_product.ReadOnly = True
        Me.cmd_totalprice_product.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'cmd_checked_product
        '
        Me.cmd_checked_product.HeaderText = "Payé"
        Me.cmd_checked_product.Name = "cmd_checked_product"
        Me.cmd_checked_product.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cmd_checked_product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'idproduct
        '
        Me.idproduct.HeaderText = "Id du Produit"
        Me.idproduct.Name = "idproduct"
        Me.idproduct.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'idcommande
        '
        Me.idcommande.HeaderText = "Id du Commande"
        Me.idcommande.Name = "idcommande"
        Me.idcommande.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(692, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Commandes"
        '
        'btn_commandes
        '
        Me.btn_commandes.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_commandes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_commandes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_commandes.FlatAppearance.BorderSize = 0
        Me.btn_commandes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_commandes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_commandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_commandes.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_commandes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btn_commandes.Location = New System.Drawing.Point(828, 550)
        Me.btn_commandes.Name = "btn_commandes"
        Me.btn_commandes.Size = New System.Drawing.Size(252, 33)
        Me.btn_commandes.TabIndex = 6
        Me.btn_commandes.Text = "Enregistrer Modifications"
        Me.btn_commandes.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(331, 550)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(351, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "NB :  Changez la valeur de la case ""Payé"" en 1 si c'est payé sinon en 0 ."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(61, 569)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Retourner en arrière"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(17, 393)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(252, 33)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Supprimer Client"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Clients_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 608)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_commandes)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.combo_client)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Clients_Form"
        Me.ShowIcon = False
        Me.Text = "Mes Clients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo_client As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nom_client As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_mdp_client As TextBox
    Friend WithEvents txt_ndc_client As TextBox
    Friend WithEvents txt_adresse_client As TextBox
    Friend WithEvents txt_age_client As TextBox
    Friend WithEvents txt_prenom_client As TextBox
    Friend WithEvents btn_produits As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_commandes As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cmd_nom_produit As DataGridViewTextBoxColumn
    Friend WithEvents cmd_price_product As DataGridViewTextBoxColumn
    Friend WithEvents cmd_quantity_product As DataGridViewTextBoxColumn
    Friend WithEvents cmd_totalprice_product As DataGridViewTextBoxColumn
    Friend WithEvents cmd_checked_product As DataGridViewTextBoxColumn
    Friend WithEvents idproduct As DataGridViewTextBoxColumn
    Friend WithEvents idcommande As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
