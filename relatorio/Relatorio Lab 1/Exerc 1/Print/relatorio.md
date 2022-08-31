# Enunciado <h2>

Alguns números de quatro algarismos possuem uma característica particular. Se separamos esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
 
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
 
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.
 
 
 # Resolução <h2>
 
 Para este exercício pensei como primeiro passo, dividir o número em duas partes (Os primeiros dois algarismos que chamei de primeira metade, e os dois últimos que chamei de segunda metade). Para fazer isto, fiz a conversão do número em string e utilizei o metódo (substring). Pós isto foi necessário criar uma váriavel soma para guardar a soma deste dois grupos e verificar se o quadrado dele é igual ao número inicial. Diante disso foi necessário so criar uma estrutura de repetição simples para verificar o intervalo de números pedido no exercício.


