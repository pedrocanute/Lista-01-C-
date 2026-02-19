

## Exercicios C#

## 1. Olá, usuário!

Peça para o usuário digitar o nome e depois exiba uma mensagem de boas-vindas. 
📌 Exemplo: "Bem-vindo, João!"

## 2. Soma de dois números

Leia dois números inteiros e exiba a soma entre eles.

## 3. Média de notas

Leia 3 notas (double) e calcule a média. Depois exiba a média formatada com 2 casas decimais.

## 4. Conversor de temperatura

Leia uma temperatura em Celsius e converta para Fahrenheit usando: 

> 📌 F = (C * 9/5) + 32

## 5. Operações básicas

Leia dois números e mostre:
● soma
● subtração
● multiplicação
● divisão

## 6. Área de um retângulo

Leia base e altura e calcule a área. 

> Fórmula: área = base * altura

## 7. Operadores de resto

Leia um número inteiro e mostre se ele é par ou ímpar usando o operador %.

## 8. Concatenando Strings

Leia nome e sobrenome separadamente e depois exiba o nome completo em uma frase.
📌 Exemplo: "Seu nome completo é: João Silva"

## 9. Contagem de caracteres

Leia uma frase e exiba quantos caracteres ela possui usando .Length.

## 10. Manipulação simples de texto

Leia uma frase e exiba:
● ela em maiúsculo (ToUpper())
● ela em minúsculo (ToLower())
● a frase com espaços removidos no início e no fim (Trim())

## 11. Calculadora de salário líquido

Leia:
● nome do funcionário
● salário bruto (double)
● percentual de desconto (double)
Calcule o salário líquido e mostre uma frase completa.
📌 Fórmula:

> salarioLiquido = salarioBruto - (salarioBruto * percentual / 100)

## 12. Conversor de tempo (segundos para formato hh:mm:ss)

Leia um número inteiro representando segundos e converta para:
● horas
● minutos
● segundos restantes
📌 Exemplo: Entrada: 3665 Saída: 01:01:05
(use divisão inteira e %)

## 13. Cálculo de IMC com formatação

Leia:
● peso (double)
● altura (double)
Calcule o IMC:

> imc = peso / (altura * altura)

Exiba com 2 casas decimais e uma frase bem formatada.

## 14. Extraindo iniciais

Leia o nome completo de uma pessoa (ex: "João de Souza Silva") e exiba as iniciais.
📌 Saída esperada: M.T.S
(Dica: Split e concatenação)

## 15. Simulador de caixa registradora

Leia:
● nome do produto
● preço unitário
● quantidade
Calcule:
● subtotal
● desconto (10% se subtotal > 200)
● total final
Exiba tudo bem organizado.
📌 Dica: usar operador ternário ?:

## 16. Formatação de dados pessoais

Leia:
● nome
● idade
● cidade
● profissão
Exiba uma frase em formato de ficha:
📌 Exemplo: Nome: João | Idade: 22 | Cidade: São Paulo | Profissão: Programador

## 17. Separando parte inteira e decimal

Leia um número double e mostre:
● parte inteira
● parte decimal
📌 Exemplo: Entrada: 12.75 Saída: Inteiro: 12, Decimal: 0.75
(Dica: casting e subtração)

## 18. Cálculo de juros compostos

Leia:
● capital inicial
● taxa de juros mensal (%)
● número de meses
Calcule o montante usando:

> montante = capital * Math.Pow(1 + taxa/100, meses)

Exiba o resultado formatado em reais.

## 19. Gerador de e-mail corporativo

Leia:
● nome
● sobrenome
● empresa
Gere um e-mail no formato:

> nome.sobrenome@empresa.com

Tudo em minúsculo e sem espaços.
📌 Exemplo: Entrada: João / Silva / Senac Saída: joao.silva@senac.com

## 20. Verificador de senha simples

Leia uma senha e exiba:
● quantos caracteres tem
● se contém pelo menos 1 número
● se contém pelo menos 1 letra maiúscula
📌 Dica: usar .Any() e char.IsDigit, char.IsUpper
