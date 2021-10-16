Imports _2___ByteBank.BiteBank

Public Class Frm_Principal_02

    Dim ContadaGabriela As New ContaCorrente(1000)
    Dim ContadoBruno As New ContaCorrente(500)
    'Dim Gabriela As New Cliente
    Dim Bruno As New Cliente("Bruno", "18769787832")
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "02 - BiteBank"
        Lbl_Principal_02.Text = "02 - BiteBank"

        ' Inicialização dos textos da Gabriela

        Lbl_Valor_Gabriela.Text = "Valor a ser depositado ou sacado"
        Btm_Depositar_Gabriela.Text = "Efetuar Depósito"
        Btm_Sacar_Gabriela.Text = "Efetuar Saque"
        Btm_Transferir_Gabriela.Text = "Efetuar Transferência"
        Lbl_Saldo_Gabriela.Text = "Novo Saldo"
        Lbl_Resultado_Gabriela.Text = "Resultado do Saque"
        Lbl_SaldoAtual_Gabriela.Text = "Saldo Atual"
        Grp_Gabriela.Text = "Gabriela"
        Txt_SaldoAtual_Gabriela.ReadOnly = True
        Txt_Saldo_Gabriela.ReadOnly = True
        Txt_Resultado_Gabriela.ReadOnly = True
        Txt_Extrato_Gabriela.ReadOnly = True
        Lbl_Nome_Gabriela.Text = "Nome"
        Btm_Nome_Gabriela.Text = "..."


        ' Inicialização dos textos do Bruno

        Lbl_Valor_Bruno.Text = "Valor a ser depositado ou sacado"
        Btm_Depositar_Bruno.Text = "Efetuar Depósito"
        Btm_Sacar_Bruno.Text = "Efetuar Saque"
        Btm_Transferir_Bruno.Text = "Efetuar Transferência"
        Lbl_Saldo_Bruno.Text = "Novo Saldo"
        Lbl_Resultado_Bruno.Text = "Resultado do Saque"
        Lbl_SaldoAtual_Bruno.Text = "Saldo Atual"
        Grp_Bruno.Text = "Gabriela"
        Txt_SaldoAtual_Bruno.ReadOnly = True
        Txt_Saldo_Bruno.ReadOnly = True
        Txt_Resultado_Bruno.ReadOnly = True
        Txt_Extrato_Bruno.ReadOnly = True
        Lbl_Nome_Bruno.Text = "Nome"
        Btm_Nome_Bruno.Text = "..."

        ' Inicializar os dados da classe da Gabriela

        ContadaGabriela.Titular = New Cliente("Gabriela", "18769787832")
        'ContadaGabriela.Titular.Nome = "Gabriela"
        'ContadaGabriela.Titular.CPF = "18769787832"
        ContadaGabriela.Titular.Profissão = "Analista de Sistemas"
        ContadaGabriela.Titular.Cidade = "Rio de Janeiro"

        ContadaGabriela.Agencia = 863
        ContadaGabriela.Conta = 863141

        Lbl_BemVindo_Gabriela.Text = "Bem vindo " + ContadaGabriela.Titular.Nome + " Agência: " + ContadaGabriela.Agencia.ToString +
            " Conta: " + ContadaGabriela.Conta.ToString + " CPF: " + ContadaGabriela.Titular.CPF.ToString
        Txt_SaldoAtual_Gabriela.Text = ContadaGabriela.Saldo.ToString

        ' Inicializar os dados da classe do Bruno

        Bruno.Nome = "Bruno"
        Bruno.CPF = "18769787832"
        Bruno.Profissão = "Advogado"
        Bruno.Cidade = "São Paulo"

        ContadoBruno.Titular = Bruno
        ContadoBruno.Agencia = 863
        ContadoBruno.Conta = 863224

        Lbl_BemVindo_Bruno.Text = "Bem vindo " + ContadoBruno.Titular.Nome + " Agência: " + ContadoBruno.Agencia.ToString +
            " Conta: " + ContadoBruno.Conta.ToString + " CPF: " + ContadoBruno.Titular.CPF.ToString
        Txt_SaldoAtual_Bruno.Text = ContadoBruno.Saldo.ToString

        Lbl_Numero_Clientes.Text = "O número de clientes é: " + Cliente.NumeroClientes.ToString

    End Sub

    Private Sub Btm_Depositar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Depositar_Gabriela.Click

        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorDepositar As Double = Val(Txt_Valor_Gabriela.Text)
        ContadaGabriela.Depositar(ValorDepositar)

        Txt_Saldo_Gabriela.Text = ContadaGabriela.Saldo.ToString
        Txt_Resultado_Gabriela.Text = "Depósito efetuado com sucesso!"
        Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text

        ContadaGabriela.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString + " saldo " + ContadaGabriela.Saldo.ToString + vbCrLf

        Txt_Extrato_Gabriela.Text = ContadaGabriela.Extrato

    End Sub

    Private Sub Btm_Sacar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Sacar_Gabriela.Click

        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorSacar As Double = Val(Txt_Valor_Gabriela.Text)
        Dim RetornoSaque As Boolean = ContadaGabriela.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Gabriela.Text = "Não há saldo suficiente para o saque!"
        Else
            Txt_Saldo_Gabriela.Text = ContadaGabriela.Saldo.ToString
            Txt_Resultado_Gabriela.Text = "Saque efetuado com sucesso!"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            ContadaGabriela.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " saldo " + ContadaGabriela.Saldo.ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContadaGabriela.Extrato
        End If

    End Sub

    Private Sub Btm_Transferir_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Transferir_Gabriela.Click

        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_Gabriela.Text)
        Dim RetornoTransferencia As Boolean = ContadaGabriela.Transferir(ValorTransferir, ContadoBruno)

        If RetornoTransferencia = False Then
            Txt_Resultado_Gabriela.Text = "Não há saldo suficiente para o saque!"
        Else
            Txt_Saldo_Gabriela.Text = ContadaGabriela.Saldo.ToString
            Txt_Saldo_Bruno.Text = ContadoBruno.Saldo.ToString

            Txt_Resultado_Gabriela.Text = "Transferencia efetuada com sucesso!"

            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContadaGabriela.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString + " saldo " + ContadaGabriela.Saldo.ToString + vbCrLf
            ContadoBruno.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString + " saldo " + ContadoBruno.Saldo.ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContadaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContadoBruno.Extrato
        End If

    End Sub

    Private Sub Btm_Depositar_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Depositar_Bruno.Click

        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorDepositar As Double = Val(Txt_Valor_Bruno.Text)
        ContadoBruno.Depositar(ValorDepositar)

        Txt_Saldo_Bruno.Text = ContadoBruno.Saldo.ToString
        Txt_Resultado_Bruno.Text = "Depósito efetuado com sucesso!"
        Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

        ContadoBruno.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString + " saldo " + ContadoBruno.Saldo.ToString + vbCrLf

        Txt_Extrato_Bruno.Text = ContadoBruno.Extrato

    End Sub

    Private Sub Btm_Sacar_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Sacar_Bruno.Click

        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorSacar As Double = Val(Txt_Valor_Bruno.Text)
        Dim RetornoSaque As Boolean = ContadoBruno.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Bruno.Text = "Não há saldo suficiente para o saque!"
        Else
            Txt_Saldo_Bruno.Text = ContadoBruno.Saldo.ToString
            Txt_Resultado_Bruno.Text = "Saque efetuado com sucesso!"
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text
            ContadoBruno.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " saldo " + ContadoBruno.Saldo.ToString + vbCrLf

            Txt_Extrato_Bruno.Text = ContadoBruno.Extrato
        End If

    End Sub

    Private Sub Btm_Transferir_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Transferir_Bruno.Click

        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_Bruno.Text)
        Dim RetornoTransferencia As Boolean = ContadoBruno.Transferir(ValorTransferir, ContadaGabriela)

        If RetornoTransferencia = False Then
            Txt_Resultado_Bruno.Text = "Não há saldo suficiente para o saque!"
        Else
            Txt_Saldo_Gabriela.Text = ContadaGabriela.Saldo.ToString
            Txt_Saldo_Bruno.Text = ContadoBruno.Saldo.ToString

            Txt_Resultado_Bruno.Text = "Transferencia efetuada com sucesso!"

            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContadaGabriela.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString + " saldo " + ContadaGabriela.Saldo.ToString + vbCrLf
            ContadoBruno.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString + " saldo " + ContadoBruno.Saldo.ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContadaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContadoBruno.Extrato
        End If

    End Sub

    Private Sub Btm_Nome_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Nome_Gabriela.Click

        Dim vNome As String = Txt_Nome_Gabriela.Text
        ContadaGabriela.Titular.Nome = vNome
        Lbl_BemVindo_Gabriela.Text = "Bem vindo " + ContadaGabriela.Titular.Nome + " Agência: " + ContadaGabriela.Agencia.ToString + " Conta: " + ContadaGabriela.Conta.ToString

    End Sub

    Private Sub Btm_Nome_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Nome_Bruno.Click

        Dim vNome As String = Txt_Nome_Bruno.Text
        Bruno.Nome = vNome
        Lbl_BemVindo_Bruno.Text = "Bem vindo " + ContadoBruno.Titular.Nome + " Agência: " + ContadoBruno.Agencia.ToString + " Conta: " + ContadoBruno.Conta.ToString

    End Sub
End Class
