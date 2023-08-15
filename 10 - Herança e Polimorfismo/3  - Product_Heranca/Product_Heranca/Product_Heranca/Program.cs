class Contribuinte:
    def __init__(self, nome, renda_anual):
        self.nome = nome
        self.renda_anual = renda_anual

class PessoaFisica(Contribuinte):
    def __init__(self, nome, renda_anual, gastos_saude):
        super().__init__(nome, renda_anual)
        self.gastos_saude = gastos_saude

    def calcula_imposto(self):
        if self.renda_anual < 20000:
            return self.renda_anual * 0.15 - self.gastos_saude * 0.5
        else:
            return self.renda_anual * 0.25 - self.gastos_saude * 0.5

class PessoaJuridica(Contribuinte):
    def __init__(self, nome, renda_anual, num_funcionarios):
        super().__init__(nome, renda_anual)
        self.num_funcionarios = num_funcionarios

    def calcula_imposto(self):
        if self.num_funcionarios > 10:
            return self.renda_anual * 0.14
        else:
            return self.renda_anual * 0.16

# Programa principal
n = int(input("Digite o número de contribuintes: "))
contribuintes = []
total_imposto_arrecadado = 0

for i in range(n):
    print(f"\nDados do contribuinte {i+1}:")
    tipo = input("Pessoa física ou jurídica? (F/J): ")
    nome = input("Nome: ")
    renda_anual = float(input("Renda anual: "))
    if tipo == 'F':
        gastos_saude = float(input("Gastos com saúde: "))
        contribuinte = PessoaFisica(nome, renda_anual, gastos_saude)
    else:
        num_funcionarios = int(input("Número de funcionários: "))
        contribuinte = PessoaJuridica(nome, renda_anual, num_funcionarios)
    contribuintes.append(contribuinte)
    imposto = contribuinte.calcula_imposto()
    print(f"Imposto a ser pago pelo(a) contribuinte {nome}: R$ {imposto:.2f}")
    total_imposto_arrecadado += imposto

print(f"\nTotal de imposto arrecadado: R$ {total_imposto_arrecadado:.2f}")
