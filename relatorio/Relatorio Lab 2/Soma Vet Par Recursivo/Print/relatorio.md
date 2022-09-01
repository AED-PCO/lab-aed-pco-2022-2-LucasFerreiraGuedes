# Enunciado<h2>

Escreva um método recursivo que calcule a soma dos elementos de valor par de um vetor de números inteiros positivos.
  
# Resolução <h2>
  
Para este exercício verifico desde a última posição do vetor se o número em questão é par, se for eu pego este valor e somo a chamada da função decrementando a próxima posição. Caso o número a ser analisado não seja par, eu so chamo a função decrementando igualmente feito no passo anterior, já que números ímpares não me importam. O ponto de parada será quando a posição for (-1), o que vai me indicar que o vetor ja foi totalmente analisado.    
