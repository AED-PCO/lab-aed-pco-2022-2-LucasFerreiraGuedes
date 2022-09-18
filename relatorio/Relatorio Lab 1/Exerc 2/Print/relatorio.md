# Enunciado <h2>

Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é Primo.
Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6.
Faça um programa que liste os números perfeitos de 1 a 1000.
  
  
  # Resolução <h2>
  
  Para verificar se o número era primo, eu o recebo como parâmetro na função e verifico todos os números a partir do 2 ate o valor dele subtraindo 1, caso algum número inserido neste intervalo seja um divisor deste número, ele não é primo.
  
  Para verificar se o número é perfeito, eu utilizei a mesma estrategia para a leitura de uma matriz, utilizando duas estruturas de repetição (For), para que "travasse" em cada valor pelo for mais externo, e o interno para testar cada número ate o valor se a soma de seus divisores é igual ao número, se sim ele irá escrever na tela, se não, ele so pula para o próximo.
