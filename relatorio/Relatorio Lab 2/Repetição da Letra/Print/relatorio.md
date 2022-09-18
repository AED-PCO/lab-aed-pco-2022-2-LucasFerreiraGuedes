# Enunciado <h2>

Escreva um método recursivo que receba uma frase e uma letra como parâmetros. Este método deve retornar a quantidade de ocorrências desta letra nesta frase.
  
# Resolução <h2>
  
Para a resoução deste problema eu recebo uma frase e uma letra como parâmetro da função. e vou verififcando se a última posição daquela frase (frase[frase.lenght-1] é igual a letra, caso seja eu coloco 1 + a chamada da função substraindo na frase seu último caractere pelo metódo (substring(0,frase.lenght-1) já que eu já verifiquei esta posição. Caso a posição que esteja sendo verificada não seja igual a letra eu so chamo a função retirando esta posição. Enquanto a frase não estiver vazia que é meu ponto de parada, eu vou chamando a função. Ao final no desempilhamento eu retorno um valor inteiro que mostrará quantas ocorrências desta letra tem na frase.
