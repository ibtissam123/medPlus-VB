<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_Compte
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_adresse_medecin = New System.Windows.Forms.TextBox()
        Me.txt_prenom_medecin = New System.Windows.Forms.TextBox()
        Me.txt_nom_medecin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_mdp_medecin = New System.Windows.Forms.TextBox()
        Me.txt_ndc_medecin = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Adresse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prenom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom"
        '
        'txt_adresse_medecin
        '
        Me.txt_adresse_medecin.Location = New System.Drawing.Point(27, 184)
        Me.txt_adresse_medecin.Name = "txt_adresse_medecin"
        Me.txt_adresse_medecin.Size = New System.Drawing.Size(225, 20)
        Me.txt_adresse_medecin.TabIndex = 3
        '
        'txt_prenom_medecin
        '
        Me.txt_prenom_medecin.Location = New System.Drawing.Point(27, 132)
        Me.txt_prenom_medecin.Name = "txt_prenom_medecin"
        Me.txt_prenom_medecin.Size = New System.Drawing.Size(225, 20)
        Me.txt_prenom_medecin.TabIndex = 3
        '
        'txt_nom_medecin
        '
        Me.txt_nom_medecin.Location = New System.Drawing.Point(27, 80)
        Me.txt_nom_medecin.Name = "txt_nom_medecin"
        Me.txt_nom_medecin.Size = New System.Drawing.Size(225, 20)
        Me.txt_nom_medecin.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_mdp_medecin)
        Me.GroupBox1.Controls.Add(Me.txt_ndc_medecin)
        Me.GroupBox1.Controls.Add(Me.txt_adresse_medecin)
        Me.GroupBox1.Controls.Add(Me.txt_prenom_medecin)
        Me.GroupBox1.Controls.Add(Me.txt_nom_medecin)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 419)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations de Compte"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(15, 335)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(252, 33)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "Enregistrer Modifications"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Mot de passe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Nom de compte"
        '
        'txt_mdp_medecin
        '
        Me.txt_mdp_medecin.Location = New System.Drawing.Point(27, 290)
        Me.txt_mdp_medecin.Name = "txt_mdp_medecin"
        Me.txt_mdp_medecin.Size = New System.Drawing.Size(225, 20)
        Me.txt_mdp_medecin.TabIndex = 3
        '
        'txt_ndc_medecin
        '
        Me.txt_ndc_medecin.Location = New System.Drawing.Point(27, 238)
        Me.txt_ndc_medecin.Name = "txt_ndc_medecin"
        Me.txt_ndc_medecin.Size = New System.Drawing.Size(225, 20)
        Me.txt_ndc_medecin.TabIndex = 3
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
        Me.Button1.Location = New System.Drawing.Point(15, 374)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Retourner en arrière"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Info_Compte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Info_Compte"
        Me.Text = "Info_Compte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_adresse_medecin As TextBox
    Friend WithEvents txt_prenom_medecin As TextBox
    Friend WithEvents txt_nom_medecin As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_mdp_medecin As TextBox
    Friend WithEvents txt_ndc_medecin As TextBox
    Friend WithEvents Button1 As Button
End Class
