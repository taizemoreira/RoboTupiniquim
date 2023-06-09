<h1 align="center">
🤖<br>
Robô Tupiniquim<br>
Utilizando a Linguagem C#
</a>
</h1>

### 1 - SOBRE O SISTEMA
A área escolhida para análise é curiosamente retangular e os robôs devem andar por ela com suas câmeras ligadas coletando todo tipo de informação.<br> 
A posição de um robô é representada por uma combinação de coordenadas X e Y e também uma letra representando a direção que ele está olhando.<br>
A área é dividida em um grid para simplificar a navegação.<br>
Um exemplo de posição poderia ser: 0,0,N, significando o robô está na parte inferior esquerda com a face para o norte. <br>
Use as orientações: N =norte, S = sul, L = leste, O = oeste.<br>
Para controlar o robô, a AEB envia simples strings com os comandos. Letras possíveis são: E, D e M.<br>
As letras E e D fazem o robô virar 90 graus para esquerda e direita respectivamente, sem sair do lugar.<br>
A letra M significa se mover uma posição no grid para frente, mantendo a mesma direção.<br>
Assuma que mover o robô para frente, significa mover sua posição de (X, Y) para (X, Y+1).<br>
Por exemplo, um robô na posição (0,0) com a face para o norte, ao se mover uma posição, vai parar em (0,1).

### 2 - ENTRADA
O programa deve possuir os seguintes parâmetros:<br>
- Aprimeira linha deve ser as coordenadas do canto superior direito da área. O canto inferior esquerdo é sempre (0,0).<br>
- O resto das entradas deve ser os comandos que o robô deve executar.<br>
- Cada comando deve ser enviado em 2 partes: a primeira parte é a posição inicial do robô e a segunda uma série de instruções que aquele robô deve seguir para explorar a área.<br>
- A posição é dada com 2 inteiros e uma letra, separados por espaços, correspondendo pelas coordenadas X e Y e a orientação do robô.<br>
Cada robô vai executar as instruções de forma sequencial: o segundo robô só iniciará suas ações quando o primeiro terminar.<br>

### 3 - SAÍDA
Para cada robô, a posição final e sua orientação depois de executada as instruções.

