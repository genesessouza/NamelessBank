<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        LabelBemvindo_Main = New Label()
        LabelNome_Main = New Label()
        LabelSaldo_Main = New Label()
        SidebarPanel = New FlowLayoutPanel()
        PanelConta_Sidebar = New Panel()
        LabelContaValor_Sidebar = New Label()
        LabelAgenciaValor_Sidebar = New Label()
        LabelConta_Sidebar = New Label()
        LabelAgencia_Sidebar = New Label()
        PanelOperacoes_Sidebar = New Panel()
        ButtonTransfer_Sidebar = New Button()
        ButtonDeposito_Sidebar = New Button()
        LabelOperacoes_Sidebar = New Label()
        ButtonSaque_Sidebar = New Button()
        PanelServicos_Sidebar = New Panel()
        ButtonConfiguracoes_Sidebar = New Button()
        PanelSair_Sidebar = New Panel()
        ButtonSair_Sidebar = New Button()
        ButtonTransferir = New Button()
        ButtonDepositar = New Button()
        ButtonSacar = New Button()
        PanelWelcome_Main = New Panel()
        PanelTransferencia = New Panel()
        TxtBoxAgDest_TransfPage = New TextBox()
        TxtBoxContaDest_TransfPage = New TextBox()
        TxtBoxValor_TransfPage = New TextBox()
        TxtBoxSaldo_TransfPage = New TextBox()
        LabelValorAtual_TransfPage = New Label()
        BttnTransferir_TransfPage = New Button()
        BttnFecharTransf_TransfPage = New Button()
        LabelValor_TransfPage = New Label()
        LabelContaDest_TransfPage = New Label()
        LabelAgDest_TransfPage = New Label()
        ButtonSidebarToggle = New Button()
        TxtBoxSaldo_Main = New TextBox()
        SidebarPanel.SuspendLayout()
        PanelConta_Sidebar.SuspendLayout()
        PanelOperacoes_Sidebar.SuspendLayout()
        PanelServicos_Sidebar.SuspendLayout()
        PanelSair_Sidebar.SuspendLayout()
        PanelWelcome_Main.SuspendLayout()
        PanelTransferencia.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelBemvindo_Main
        ' 
        LabelBemvindo_Main.Font = New Font("Segoe UI", 12F)
        LabelBemvindo_Main.ForeColor = Color.Green
        LabelBemvindo_Main.Location = New Point(55, 16)
        LabelBemvindo_Main.Name = "LabelBemvindo_Main"
        LabelBemvindo_Main.Size = New Size(96, 21)
        LabelBemvindo_Main.TabIndex = 0
        LabelBemvindo_Main.Text = "Bem-Vindo "
        LabelBemvindo_Main.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelNome_Main
        ' 
        LabelNome_Main.AutoSize = True
        LabelNome_Main.Font = New Font("Segoe UI", 12F)
        LabelNome_Main.ForeColor = Color.Green
        LabelNome_Main.Location = New Point(140, 16)
        LabelNome_Main.Name = "LabelNome_Main"
        LabelNome_Main.Size = New Size(135, 21)
        LabelNome_Main.TabIndex = 1
        LabelNome_Main.Text = "[Nome Completo]"
        LabelNome_Main.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelSaldo_Main
        ' 
        LabelSaldo_Main.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LabelSaldo_Main.AutoSize = True
        LabelSaldo_Main.Font = New Font("Segoe UI", 12F)
        LabelSaldo_Main.Location = New Point(333, 16)
        LabelSaldo_Main.Name = "LabelSaldo_Main"
        LabelSaldo_Main.Size = New Size(72, 21)
        LabelSaldo_Main.TabIndex = 2
        LabelSaldo_Main.Text = "Saldo R$"
        LabelSaldo_Main.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' SidebarPanel
        ' 
        SidebarPanel.BorderStyle = BorderStyle.FixedSingle
        SidebarPanel.Controls.Add(PanelConta_Sidebar)
        SidebarPanel.Controls.Add(PanelOperacoes_Sidebar)
        SidebarPanel.Controls.Add(PanelServicos_Sidebar)
        SidebarPanel.Controls.Add(PanelSair_Sidebar)
        SidebarPanel.Dock = DockStyle.Left
        SidebarPanel.Location = New Point(0, 0)
        SidebarPanel.Name = "SidebarPanel"
        SidebarPanel.Size = New Size(289, 450)
        SidebarPanel.TabIndex = 4
        ' 
        ' PanelConta_Sidebar
        ' 
        PanelConta_Sidebar.BorderStyle = BorderStyle.FixedSingle
        PanelConta_Sidebar.Controls.Add(LabelContaValor_Sidebar)
        PanelConta_Sidebar.Controls.Add(LabelAgenciaValor_Sidebar)
        PanelConta_Sidebar.Controls.Add(LabelConta_Sidebar)
        PanelConta_Sidebar.Controls.Add(LabelAgencia_Sidebar)
        PanelConta_Sidebar.Dock = DockStyle.Top
        PanelConta_Sidebar.Location = New Point(3, 3)
        PanelConta_Sidebar.Name = "PanelConta_Sidebar"
        PanelConta_Sidebar.Size = New Size(279, 44)
        PanelConta_Sidebar.TabIndex = 5
        ' 
        ' LabelContaValor_Sidebar
        ' 
        LabelContaValor_Sidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LabelContaValor_Sidebar.AutoSize = True
        LabelContaValor_Sidebar.Font = New Font("Segoe UI", 12F)
        LabelContaValor_Sidebar.Location = New Point(216, 7)
        LabelContaValor_Sidebar.Name = "LabelContaValor_Sidebar"
        LabelContaValor_Sidebar.Size = New Size(50, 21)
        LabelContaValor_Sidebar.TabIndex = 8
        LabelContaValor_Sidebar.Text = "[0,00]"
        LabelContaValor_Sidebar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelAgenciaValor_Sidebar
        ' 
        LabelAgenciaValor_Sidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LabelAgenciaValor_Sidebar.AutoSize = True
        LabelAgenciaValor_Sidebar.Font = New Font("Segoe UI", 12F)
        LabelAgenciaValor_Sidebar.Location = New Point(71, 7)
        LabelAgenciaValor_Sidebar.Name = "LabelAgenciaValor_Sidebar"
        LabelAgenciaValor_Sidebar.Size = New Size(50, 21)
        LabelAgenciaValor_Sidebar.TabIndex = 7
        LabelAgenciaValor_Sidebar.Text = "[0,00]"
        LabelAgenciaValor_Sidebar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelConta_Sidebar
        ' 
        LabelConta_Sidebar.AutoSize = True
        LabelConta_Sidebar.Font = New Font("Segoe UI", 9.75F)
        LabelConta_Sidebar.ForeColor = Color.Green
        LabelConta_Sidebar.Location = New Point(163, 10)
        LabelConta_Sidebar.Margin = New Padding(0)
        LabelConta_Sidebar.Name = "LabelConta_Sidebar"
        LabelConta_Sidebar.Size = New Size(42, 17)
        LabelConta_Sidebar.TabIndex = 6
        LabelConta_Sidebar.Text = "Conta"
        ' 
        ' LabelAgencia_Sidebar
        ' 
        LabelAgencia_Sidebar.AutoSize = True
        LabelAgencia_Sidebar.Font = New Font("Segoe UI", 9.75F)
        LabelAgencia_Sidebar.ForeColor = Color.Green
        LabelAgencia_Sidebar.Location = New Point(7, 10)
        LabelAgencia_Sidebar.Margin = New Padding(0)
        LabelAgencia_Sidebar.Name = "LabelAgencia_Sidebar"
        LabelAgencia_Sidebar.Size = New Size(54, 17)
        LabelAgencia_Sidebar.TabIndex = 5
        LabelAgencia_Sidebar.Text = "Agência"
        ' 
        ' PanelOperacoes_Sidebar
        ' 
        PanelOperacoes_Sidebar.BorderStyle = BorderStyle.FixedSingle
        PanelOperacoes_Sidebar.Controls.Add(ButtonTransfer_Sidebar)
        PanelOperacoes_Sidebar.Controls.Add(ButtonDeposito_Sidebar)
        PanelOperacoes_Sidebar.Controls.Add(LabelOperacoes_Sidebar)
        PanelOperacoes_Sidebar.Controls.Add(ButtonSaque_Sidebar)
        PanelOperacoes_Sidebar.Dock = DockStyle.Top
        PanelOperacoes_Sidebar.Location = New Point(3, 53)
        PanelOperacoes_Sidebar.Name = "PanelOperacoes_Sidebar"
        PanelOperacoes_Sidebar.Size = New Size(279, 186)
        PanelOperacoes_Sidebar.TabIndex = 7
        ' 
        ' ButtonTransfer_Sidebar
        ' 
        ButtonTransfer_Sidebar.Dock = DockStyle.Bottom
        ButtonTransfer_Sidebar.FlatAppearance.BorderColor = SystemColors.ActiveBorder
        ButtonTransfer_Sidebar.FlatStyle = FlatStyle.Flat
        ButtonTransfer_Sidebar.Font = New Font("Segoe UI", 9.75F)
        ButtonTransfer_Sidebar.Location = New Point(0, 38)
        ButtonTransfer_Sidebar.Margin = New Padding(0)
        ButtonTransfer_Sidebar.Name = "ButtonTransfer_Sidebar"
        ButtonTransfer_Sidebar.Size = New Size(277, 49)
        ButtonTransfer_Sidebar.TabIndex = 7
        ButtonTransfer_Sidebar.Tag = "3"
        ButtonTransfer_Sidebar.Text = "Transferir"
        ButtonTransfer_Sidebar.UseVisualStyleBackColor = True
        ' 
        ' ButtonDeposito_Sidebar
        ' 
        ButtonDeposito_Sidebar.Dock = DockStyle.Bottom
        ButtonDeposito_Sidebar.Enabled = False
        ButtonDeposito_Sidebar.FlatAppearance.BorderColor = SystemColors.ActiveBorder
        ButtonDeposito_Sidebar.FlatStyle = FlatStyle.Flat
        ButtonDeposito_Sidebar.Font = New Font("Segoe UI", 9.75F)
        ButtonDeposito_Sidebar.Location = New Point(0, 87)
        ButtonDeposito_Sidebar.Margin = New Padding(0)
        ButtonDeposito_Sidebar.Name = "ButtonDeposito_Sidebar"
        ButtonDeposito_Sidebar.Size = New Size(277, 48)
        ButtonDeposito_Sidebar.TabIndex = 6
        ButtonDeposito_Sidebar.Tag = "3"
        ButtonDeposito_Sidebar.Text = "Depositar"
        ButtonDeposito_Sidebar.UseVisualStyleBackColor = True
        ' 
        ' LabelOperacoes_Sidebar
        ' 
        LabelOperacoes_Sidebar.AutoSize = True
        LabelOperacoes_Sidebar.Font = New Font("Segoe UI", 9.75F)
        LabelOperacoes_Sidebar.ForeColor = Color.Green
        LabelOperacoes_Sidebar.Location = New Point(7, 9)
        LabelOperacoes_Sidebar.Margin = New Padding(0)
        LabelOperacoes_Sidebar.Name = "LabelOperacoes_Sidebar"
        LabelOperacoes_Sidebar.Size = New Size(72, 17)
        LabelOperacoes_Sidebar.TabIndex = 5
        LabelOperacoes_Sidebar.Text = "Operações"
        LabelOperacoes_Sidebar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ButtonSaque_Sidebar
        ' 
        ButtonSaque_Sidebar.AutoSize = True
        ButtonSaque_Sidebar.Dock = DockStyle.Bottom
        ButtonSaque_Sidebar.Enabled = False
        ButtonSaque_Sidebar.FlatAppearance.BorderColor = SystemColors.ActiveBorder
        ButtonSaque_Sidebar.FlatStyle = FlatStyle.Flat
        ButtonSaque_Sidebar.Font = New Font("Segoe UI", 9.75F)
        ButtonSaque_Sidebar.Location = New Point(0, 135)
        ButtonSaque_Sidebar.Margin = New Padding(0)
        ButtonSaque_Sidebar.Name = "ButtonSaque_Sidebar"
        ButtonSaque_Sidebar.Size = New Size(277, 49)
        ButtonSaque_Sidebar.TabIndex = 5
        ButtonSaque_Sidebar.Tag = "3"
        ButtonSaque_Sidebar.Text = "Sacar"
        ButtonSaque_Sidebar.UseVisualStyleBackColor = True
        ' 
        ' PanelServicos_Sidebar
        ' 
        PanelServicos_Sidebar.BorderStyle = BorderStyle.FixedSingle
        PanelServicos_Sidebar.Controls.Add(ButtonConfiguracoes_Sidebar)
        PanelServicos_Sidebar.Location = New Point(3, 245)
        PanelServicos_Sidebar.Name = "PanelServicos_Sidebar"
        PanelServicos_Sidebar.Size = New Size(279, 47)
        PanelServicos_Sidebar.TabIndex = 8
        ' 
        ' ButtonConfiguracoes_Sidebar
        ' 
        ButtonConfiguracoes_Sidebar.Dock = DockStyle.Top
        ButtonConfiguracoes_Sidebar.FlatAppearance.BorderColor = SystemColors.ActiveBorder
        ButtonConfiguracoes_Sidebar.FlatStyle = FlatStyle.Flat
        ButtonConfiguracoes_Sidebar.Font = New Font("Segoe UI", 9.75F)
        ButtonConfiguracoes_Sidebar.Location = New Point(0, 0)
        ButtonConfiguracoes_Sidebar.Margin = New Padding(0)
        ButtonConfiguracoes_Sidebar.Name = "ButtonConfiguracoes_Sidebar"
        ButtonConfiguracoes_Sidebar.Size = New Size(277, 46)
        ButtonConfiguracoes_Sidebar.TabIndex = 6
        ButtonConfiguracoes_Sidebar.Tag = "3"
        ButtonConfiguracoes_Sidebar.Text = "Configurações"
        ButtonConfiguracoes_Sidebar.UseVisualStyleBackColor = True
        ' 
        ' PanelSair_Sidebar
        ' 
        PanelSair_Sidebar.BorderStyle = BorderStyle.FixedSingle
        PanelSair_Sidebar.Controls.Add(ButtonSair_Sidebar)
        PanelSair_Sidebar.Location = New Point(3, 298)
        PanelSair_Sidebar.Name = "PanelSair_Sidebar"
        PanelSair_Sidebar.Size = New Size(279, 47)
        PanelSair_Sidebar.TabIndex = 9
        ' 
        ' ButtonSair_Sidebar
        ' 
        ButtonSair_Sidebar.Dock = DockStyle.Top
        ButtonSair_Sidebar.FlatAppearance.BorderColor = SystemColors.ActiveBorder
        ButtonSair_Sidebar.FlatStyle = FlatStyle.Flat
        ButtonSair_Sidebar.Font = New Font("Segoe UI", 9.75F)
        ButtonSair_Sidebar.Location = New Point(0, 0)
        ButtonSair_Sidebar.Margin = New Padding(0)
        ButtonSair_Sidebar.Name = "ButtonSair_Sidebar"
        ButtonSair_Sidebar.Size = New Size(277, 45)
        ButtonSair_Sidebar.TabIndex = 6
        ButtonSair_Sidebar.Tag = "3"
        ButtonSair_Sidebar.Text = "Sair"
        ButtonSair_Sidebar.UseVisualStyleBackColor = True
        ' 
        ' ButtonTransferir
        ' 
        ButtonTransferir.AutoSize = True
        ButtonTransferir.Dock = DockStyle.Top
        ButtonTransferir.Location = New Point(0, 0)
        ButtonTransferir.Name = "ButtonTransferir"
        ButtonTransferir.Size = New Size(277, 40)
        ButtonTransferir.TabIndex = 0
        ButtonTransferir.Text = "Transferir"
        ButtonTransferir.UseVisualStyleBackColor = True
        ' 
        ' ButtonDepositar
        ' 
        ButtonDepositar.AutoSize = True
        ButtonDepositar.Dock = DockStyle.Top
        ButtonDepositar.Location = New Point(0, 40)
        ButtonDepositar.Name = "ButtonDepositar"
        ButtonDepositar.Size = New Size(277, 42)
        ButtonDepositar.TabIndex = 1
        ButtonDepositar.Text = "Depositar"
        ButtonDepositar.UseVisualStyleBackColor = True
        ' 
        ' ButtonSacar
        ' 
        ButtonSacar.AutoSize = True
        ButtonSacar.Dock = DockStyle.Top
        ButtonSacar.Location = New Point(0, 82)
        ButtonSacar.Name = "ButtonSacar"
        ButtonSacar.Size = New Size(277, 44)
        ButtonSacar.TabIndex = 2
        ButtonSacar.Text = "Sacar"
        ButtonSacar.UseVisualStyleBackColor = True
        ' 
        ' PanelWelcome_Main
        ' 
        PanelWelcome_Main.BorderStyle = BorderStyle.FixedSingle
        PanelWelcome_Main.Controls.Add(PanelTransferencia)
        PanelWelcome_Main.Controls.Add(ButtonSidebarToggle)
        PanelWelcome_Main.Controls.Add(LabelNome_Main)
        PanelWelcome_Main.Controls.Add(LabelSaldo_Main)
        PanelWelcome_Main.Controls.Add(LabelBemvindo_Main)
        PanelWelcome_Main.Controls.Add(TxtBoxSaldo_Main)
        PanelWelcome_Main.Dock = DockStyle.Fill
        PanelWelcome_Main.Location = New Point(289, 0)
        PanelWelcome_Main.Name = "PanelWelcome_Main"
        PanelWelcome_Main.Size = New Size(511, 450)
        PanelWelcome_Main.TabIndex = 5
        ' 
        ' PanelTransferencia
        ' 
        PanelTransferencia.Controls.Add(TxtBoxAgDest_TransfPage)
        PanelTransferencia.Controls.Add(TxtBoxContaDest_TransfPage)
        PanelTransferencia.Controls.Add(TxtBoxValor_TransfPage)
        PanelTransferencia.Controls.Add(TxtBoxSaldo_TransfPage)
        PanelTransferencia.Controls.Add(LabelValorAtual_TransfPage)
        PanelTransferencia.Controls.Add(BttnTransferir_TransfPage)
        PanelTransferencia.Controls.Add(BttnFecharTransf_TransfPage)
        PanelTransferencia.Controls.Add(LabelValor_TransfPage)
        PanelTransferencia.Controls.Add(LabelContaDest_TransfPage)
        PanelTransferencia.Controls.Add(LabelAgDest_TransfPage)
        PanelTransferencia.Dock = DockStyle.Fill
        PanelTransferencia.Location = New Point(0, 0)
        PanelTransferencia.Name = "PanelTransferencia"
        PanelTransferencia.Size = New Size(509, 448)
        PanelTransferencia.TabIndex = 9
        PanelTransferencia.Visible = False
        ' 
        ' TxtBoxAgDest_TransfPage
        ' 
        TxtBoxAgDest_TransfPage.Location = New Point(16, 40)
        TxtBoxAgDest_TransfPage.Name = "TxtBoxAgDest_TransfPage"
        TxtBoxAgDest_TransfPage.Size = New Size(100, 23)
        TxtBoxAgDest_TransfPage.TabIndex = 22
        ' 
        ' TxtBoxContaDest_TransfPage
        ' 
        TxtBoxContaDest_TransfPage.Location = New Point(16, 107)
        TxtBoxContaDest_TransfPage.Name = "TxtBoxContaDest_TransfPage"
        TxtBoxContaDest_TransfPage.Size = New Size(100, 23)
        TxtBoxContaDest_TransfPage.TabIndex = 21
        ' 
        ' TxtBoxValor_TransfPage
        ' 
        TxtBoxValor_TransfPage.Location = New Point(16, 235)
        TxtBoxValor_TransfPage.Name = "TxtBoxValor_TransfPage"
        TxtBoxValor_TransfPage.Size = New Size(100, 23)
        TxtBoxValor_TransfPage.TabIndex = 20
        ' 
        ' TxtBoxSaldo_TransfPage
        ' 
        TxtBoxSaldo_TransfPage.Enabled = False
        TxtBoxSaldo_TransfPage.Location = New Point(16, 166)
        TxtBoxSaldo_TransfPage.Name = "TxtBoxSaldo_TransfPage"
        TxtBoxSaldo_TransfPage.Size = New Size(100, 23)
        TxtBoxSaldo_TransfPage.TabIndex = 19
        ' 
        ' LabelValorAtual_TransfPage
        ' 
        LabelValorAtual_TransfPage.AutoSize = True
        LabelValorAtual_TransfPage.Font = New Font("Segoe UI", 9.75F)
        LabelValorAtual_TransfPage.ForeColor = Color.Green
        LabelValorAtual_TransfPage.Location = New Point(16, 141)
        LabelValorAtual_TransfPage.Margin = New Padding(0)
        LabelValorAtual_TransfPage.Name = "LabelValorAtual_TransfPage"
        LabelValorAtual_TransfPage.Size = New Size(68, 17)
        LabelValorAtual_TransfPage.TabIndex = 18
        LabelValorAtual_TransfPage.Text = "Saldo (R$)"
        ' 
        ' BttnTransferir_TransfPage
        ' 
        BttnTransferir_TransfPage.Dock = DockStyle.Bottom
        BttnTransferir_TransfPage.FlatAppearance.BorderColor = SystemColors.ActiveBorder
        BttnTransferir_TransfPage.FlatStyle = FlatStyle.Flat
        BttnTransferir_TransfPage.Font = New Font("Segoe UI", 9.75F)
        BttnTransferir_TransfPage.Location = New Point(0, 350)
        BttnTransferir_TransfPage.Margin = New Padding(0)
        BttnTransferir_TransfPage.Name = "BttnTransferir_TransfPage"
        BttnTransferir_TransfPage.Size = New Size(509, 49)
        BttnTransferir_TransfPage.TabIndex = 17
        BttnTransferir_TransfPage.Tag = "3"
        BttnTransferir_TransfPage.Text = "Realizar Transferência"
        BttnTransferir_TransfPage.UseVisualStyleBackColor = True
        ' 
        ' BttnFecharTransf_TransfPage
        ' 
        BttnFecharTransf_TransfPage.Dock = DockStyle.Bottom
        BttnFecharTransf_TransfPage.FlatAppearance.BorderColor = SystemColors.ActiveBorder
        BttnFecharTransf_TransfPage.FlatStyle = FlatStyle.Flat
        BttnFecharTransf_TransfPage.Font = New Font("Segoe UI", 9.75F)
        BttnFecharTransf_TransfPage.Location = New Point(0, 399)
        BttnFecharTransf_TransfPage.Margin = New Padding(0)
        BttnFecharTransf_TransfPage.Name = "BttnFecharTransf_TransfPage"
        BttnFecharTransf_TransfPage.Size = New Size(509, 49)
        BttnFecharTransf_TransfPage.TabIndex = 16
        BttnFecharTransf_TransfPage.Tag = "3"
        BttnFecharTransf_TransfPage.Text = "Fechar"
        BttnFecharTransf_TransfPage.UseVisualStyleBackColor = True
        ' 
        ' LabelValor_TransfPage
        ' 
        LabelValor_TransfPage.AutoSize = True
        LabelValor_TransfPage.Font = New Font("Segoe UI", 9.75F)
        LabelValor_TransfPage.ForeColor = Color.Green
        LabelValor_TransfPage.Location = New Point(16, 205)
        LabelValor_TransfPage.Margin = New Padding(0)
        LabelValor_TransfPage.Name = "LabelValor_TransfPage"
        LabelValor_TransfPage.Size = New Size(135, 17)
        LabelValor_TransfPage.TabIndex = 10
        LabelValor_TransfPage.Text = "Valor a Transferir (R$)"
        ' 
        ' LabelContaDest_TransfPage
        ' 
        LabelContaDest_TransfPage.AutoSize = True
        LabelContaDest_TransfPage.Font = New Font("Segoe UI", 9.75F)
        LabelContaDest_TransfPage.ForeColor = Color.Green
        LabelContaDest_TransfPage.Location = New Point(16, 77)
        LabelContaDest_TransfPage.Margin = New Padding(0)
        LabelContaDest_TransfPage.Name = "LabelContaDest_TransfPage"
        LabelContaDest_TransfPage.Size = New Size(109, 17)
        LabelContaDest_TransfPage.TabIndex = 8
        LabelContaDest_TransfPage.Text = "Conta de Destino"
        ' 
        ' LabelAgDest_TransfPage
        ' 
        LabelAgDest_TransfPage.AutoSize = True
        LabelAgDest_TransfPage.Font = New Font("Segoe UI", 9.75F)
        LabelAgDest_TransfPage.ForeColor = Color.Green
        LabelAgDest_TransfPage.Location = New Point(16, 16)
        LabelAgDest_TransfPage.Margin = New Padding(0)
        LabelAgDest_TransfPage.Name = "LabelAgDest_TransfPage"
        LabelAgDest_TransfPage.Size = New Size(121, 17)
        LabelAgDest_TransfPage.TabIndex = 6
        LabelAgDest_TransfPage.Text = "Agência de Destino"
        ' 
        ' ButtonSidebarToggle
        ' 
        ButtonSidebarToggle.FlatAppearance.BorderColor = SystemColors.ActiveBorder
        ButtonSidebarToggle.FlatStyle = FlatStyle.Flat
        ButtonSidebarToggle.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonSidebarToggle.Image = CType(resources.GetObject("ButtonSidebarToggle.Image"), Image)
        ButtonSidebarToggle.Location = New Point(16, 14)
        ButtonSidebarToggle.Margin = New Padding(0)
        ButtonSidebarToggle.Name = "ButtonSidebarToggle"
        ButtonSidebarToggle.Size = New Size(31, 26)
        ButtonSidebarToggle.TabIndex = 8
        ButtonSidebarToggle.Tag = "3"
        ButtonSidebarToggle.UseVisualStyleBackColor = True
        ' 
        ' TxtBoxSaldo_Main
        ' 
        TxtBoxSaldo_Main.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TxtBoxSaldo_Main.Enabled = False
        TxtBoxSaldo_Main.Location = New Point(406, 17)
        TxtBoxSaldo_Main.Name = "TxtBoxSaldo_Main"
        TxtBoxSaldo_Main.Size = New Size(100, 23)
        TxtBoxSaldo_Main.TabIndex = 10
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(800, 450)
        Controls.Add(PanelWelcome_Main)
        Controls.Add(SidebarPanel)
        ForeColor = Color.Green
        Name = "Welcome"
        Text = "Welcome"
        SidebarPanel.ResumeLayout(False)
        PanelConta_Sidebar.ResumeLayout(False)
        PanelConta_Sidebar.PerformLayout()
        PanelOperacoes_Sidebar.ResumeLayout(False)
        PanelOperacoes_Sidebar.PerformLayout()
        PanelServicos_Sidebar.ResumeLayout(False)
        PanelSair_Sidebar.ResumeLayout(False)
        PanelWelcome_Main.ResumeLayout(False)
        PanelWelcome_Main.PerformLayout()
        PanelTransferencia.ResumeLayout(False)
        PanelTransferencia.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents LabelBemvindo_Main As Label
    Friend WithEvents LabelNome_Main As Label
    Friend WithEvents LabelSaldo_Main As Label
    Friend WithEvents SidebarPanel As FlowLayoutPanel
    Friend WithEvents PanelServicos_Sidebar As Panel
    Friend WithEvents PanelOperacoes_Sidebar As Panel
    Friend WithEvents LabelOperacoes_Sidebar As Label
    Friend WithEvents ButtonDepositar As Button
    Friend WithEvents ButtonTransferir As Button
    Friend WithEvents ButtonSacar As Button
    Friend WithEvents PanelConta_Sidebar As Panel
    Friend WithEvents LabelConta_Sidebar As Label
    Friend WithEvents LabelAgencia_Sidebar As Label
    Friend WithEvents ButtonTransfer_Sidebar As Button
    Friend WithEvents ButtonDeposito_Sidebar As Button
    Friend WithEvents ButtonSaque_Sidebar As Button
    Friend WithEvents PanelSair_Sidebar As Panel
    Friend WithEvents ButtonSair_Sidebar As Button
    Friend WithEvents ButtonConfiguracoes_Sidebar As Button
    Friend WithEvents PanelWelcome_Main As Panel
    Friend WithEvents ButtonSidebarToggle As Button
    Friend WithEvents PanelTransferencia As Panel
    Friend WithEvents LabelContaValor_Sidebar As Label
    Friend WithEvents LabelAgenciaValor_Sidebar As Label
    Friend WithEvents LabelAgDest_TransfPage As Label
    Friend WithEvents LabelContaDest_TransfPage As Label
    Friend WithEvents LabelValor_TransfPage As Label
    Friend WithEvents BttnFecharTransf_TransfPage As Button
    Friend WithEvents BttnTransferir_TransfPage As Button
    Friend WithEvents LabelValorAtual_TransfPage As Label
    Friend WithEvents TxtBoxSaldo_TransfPage As TextBox
    Friend WithEvents TxtBoxValor_TransfPage As TextBox
    Friend WithEvents TxtBoxContaDest_TransfPage As TextBox
    Friend WithEvents TxtBoxAgDest_TransfPage As TextBox
    Friend WithEvents TxtBoxSaldo_Main As TextBox
End Class
