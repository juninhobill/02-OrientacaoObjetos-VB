Public Class Frm_Principal_01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "1 - Primeira Classe"
        Lbl_Principal.Text = "1 - Primeira Classe"
        Btm_Acao.Text = "Conta Gabriela"
        Btm_Acao2.Text = "Conta Bruno"
        Btm_valRef.Text = "Clique Aqui"
        Lbl_Saldo.Text = "Saldo"
        Lbl_Incremento.Text = "Incremento"

    End Sub

    Private Sub Btm_Acao_Click(sender As Object, e As EventArgs) Handles Btm_Acao.Click

        'Dim Titular As String = "Gabriela"
        'Dim Agencia As Integer = 863
        'Dim Conta As Integer = 863141
        'Dim Saldo As Double = 100

        'Dim Titular2 As String = "Bruno"
        'Dim Agencia2 As Integer = 863
        'Dim Conta2 As Integer = 863142
        'Dim Saldo2 As Double = 50

        Dim ContaDaGabriela As New ContaCorrente

        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141
        ContaDaGabriela.Saldo = Val(Txt_Saldo.Text)

        MsgBox("O saldo da " + ContaDaGabriela.Titular + " na C/C " + ContaDaGabriela.Agencia.ToString + " - " + ContaDaGabriela.Conta.ToString +
               " é: " + ContaDaGabriela.Saldo.ToString)

        Dim vIncremento As Double = Val(Txt_Incremento.Text)
        ContaDaGabriela.Saldo += vIncremento

        MsgBox("O saldo da " + ContaDaGabriela.Titular + " na C/C " + ContaDaGabriela.Agencia.ToString + " - " + ContaDaGabriela.Conta.ToString +
               " é: " + ContaDaGabriela.Saldo.ToString)

    End Sub

    Private Sub Btm_Acao2_Click(sender As Object, e As EventArgs) Handles Btm_Acao2.Click

        Dim ContaDoBruno As New ContaCorrente

        MsgBox(ContaDoBruno.Titular)
        MsgBox(ContaDoBruno.Agencia)
        MsgBox(ContaDoBruno.Conta)
        MsgBox(ContaDoBruno.Saldo)

        ContaDoBruno.Saldo += 100

    End Sub

    Private Sub Btm_valRef_Click(sender As Object, e As EventArgs) Handles Btm_valRef.Click

        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade

        MsgBox("Valor da idade " + idade.ToString + " idade2 " + idade2.ToString)

        idade = 30

        MsgBox("Valor da idade " + idade.ToString + " idade2 " + idade2.ToString)

        Dim ContadaGabriela As New ContaCorrente
        Dim ContadaGabrielaCosta As New ContaCorrente

        ContadaGabriela.Titular = "Gabriela"
        ContadaGabriela.Agencia = 863
        ContadaGabriela.Conta = 863141

        ContadaGabrielaCosta = ContadaGabriela

        MsgBox("Valor da contadagabriela " + ContadaGabriela.Saldo.ToString + " contadagabrielacosta " + ContadaGabrielaCosta.Saldo.ToString)

        ContadaGabriela.Saldo = 300

        MsgBox("Valor da contadagabriela " + ContadaGabriela.Saldo.ToString + " contadagabrielacosta " + ContadaGabrielaCosta.Saldo.ToString)

    End Sub
End Class
