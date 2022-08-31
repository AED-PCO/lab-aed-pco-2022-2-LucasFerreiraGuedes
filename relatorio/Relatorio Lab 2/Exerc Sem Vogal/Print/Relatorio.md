# Enunciado <h2>

Escreva um método recursivo que receba uma frase e retorne a mesma frase, sem nenhuma vogal. 
	
# Resolução <h2>

Para a resolução deste problema, eu recebo a frase como parâmetro na função, e verifico se sua última letra utilizando o metódo (frase[frase.lenght - 1]) é alguma vogal, se for eu retiro esta letra utilizando o metódo (substring0, frase.lenght - 1) e chamo a função novamente para a verificação. Se caso não for encontrado alguma vogal na posição que está sendo verificada eu chamo a função novamente da mesma forma somado a letra que não é vogal, para que na desempilhação da função só aparecça a palavra sem vogais. Meu metódo de parada é quando a string estiver vazia, já que a cada chamada de função eu estou cortando a string em, sua última posição.
