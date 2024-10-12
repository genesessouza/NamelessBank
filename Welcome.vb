Public Class Welcome

    Sub Inicializar()
        FormatarCamposDeSaldo(TxtBoxSaldo_Main, "100000")
        LabelAgenciaValor_Sidebar.Text = "0001"
        LabelContaValor_Sidebar.Text = "01"
        TxtBoxSaldo_TransfPage.Text = TxtBoxSaldo_Main.Text
        TxtBoxValor_TransfPage.Text = "0"
        SidebarPanel.Visible = False
    End Sub

    Sub RealizarTransferencia()
        Dim saldoATransferir As Decimal
        Dim saldoFinal As Decimal
        Dim agenciaDoRemetente As Integer
        Dim contaDoRemetente As Integer
        Dim agenciaDoDestinatario As Integer
        Dim contaDoDestinatario As Integer

        agenciaDoRemetente = Integer.Parse(LabelAgenciaValor_Sidebar.Text)
        contaDoRemetente = Integer.Parse(LabelContaValor_Sidebar.Text)

        agenciaDoDestinatario = Integer.Parse(TxtBoxAgDest_TransfPage.Text)
        contaDoDestinatario = Integer.Parse(TxtBoxContaDest_TransfPage.Text)

        saldoATransferir = TxtBoxValor_TransfPage.Text
        saldoFinal = TxtBoxSaldo_TransfPage.Text - saldoATransferir

        If agenciaDoDestinatario Or contaDoDestinatario < 1 Then
            MessageBox.Show("Dados de destinatário inválidos")
        End If

        If contaDoDestinatario = contaDoRemetente Then
            MessageBox.Show("Não pode transferir para a própria conta")
        End If

        If saldoFinal < saldoATransferir Then
            MessageBox.Show("Saldo insuficiente")
        Else
            TxtBoxSaldo_Main.Text = saldoFinal
            FormatarCamposDeSaldo(TxtBoxSaldo_Main, TxtBoxSaldo_Main.Text)

            TxtBoxSaldo_TransfPage.Text = TxtBoxSaldo_Main.Text
            FormatarCamposDeSaldo(TxtBoxSaldo_TransfPage, TxtBoxSaldo_TransfPage.Text)
        End If
    End Sub

    Private Sub FormatarCamposDeSaldo(campo As TextBox, saldo As String)
        campo.Text = String.Format("{0:n}", CDec(saldo))
    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub ButtonSideBarToggle_Click(sender As Object, e As EventArgs) Handles ButtonSidebarToggle.Click
        SidebarPanel.Visible = Not SidebarPanel.Visible
    End Sub

    Private Sub ButtonTransfer_Sidebar_Click(sender As Object, e As EventArgs) Handles ButtonTransfer_Sidebar.Click
        PanelTransferencia.Visible = True
        TxtBoxAgDest_TransfPage.Text = "0000"
        TxtBoxContaDest_TransfPage.Text = "0"
    End Sub

    Private Sub BttnFecharTransf_TransfPage_Click(sender As Object, e As EventArgs) Handles BttnFecharTransf_TransfPage.Click
        PanelTransferencia.Visible = False
    End Sub

    Private Sub BttnTransferir_TransfPage_Click(sender As Object, e As EventArgs) Handles BttnTransferir_TransfPage.Click
        RealizarTransferencia()
    End Sub

    Private Sub TxtBoxValor_TransfPage_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxValor_TransfPage.TextChanged
        FormatarCamposDeSaldo(TxtBoxValor_TransfPage, TxtBoxValor_TransfPage.Text)
    End Sub
End Class