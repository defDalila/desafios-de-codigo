# :dart: Desafio:  Idade em Dias

Você terá o desafio de ler um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

*Obs.:* apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364.

### **Entrada**

O arquivo de entrada contém um valor inteiro.

### **Saída**

Imprima a saída conforme exemplo fornecido.

<table>
	<thead>
  <tr>
			<td><strong>Exemplo de Entrada</strong></td>
			<td><strong>Exemplo de Saída</strong></td>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>400</td>
			<td>1 ano(s)<br>
			1 mes(es)<br>
			5 dia(s)</td>
		</tr>
		<tr>
			<td>800</td>
			<td>2 ano(s)<br>
			2 mes(es)<br>
			10 dia(s)</td>
		</tr>
		<tr>
			<td>30</td>
			<td>0 ano(s)<br>
			1 mes(es)<br>
			0 dia(s)</td>
		</tr>
	</tbody>
</table>


# :dart: Desafio:  Conversão de Tempo

Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

## Entrada

O arquivo de entrada contém um valor inteiro N.

Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.


|Entrada  |Saida  |
|---------|---------|
|556|0:9:16|
|1 |0:0:1|


# :dart: Desafio: Tempo do Dobby

Para dar conta de toda a fabricação dos presentes de Natal, por várias vezes os elfos precisam ficar até tarde trabalhando para que tudo possa ser terminado a tempo.

Para melhor gerenciar seus cronogramas, os elfos estipularam quantos minutos são necessários para fabricar cada presente.

Já está quase no final do expediente, e um dos elfos pediu sua ajuda.

Faltam N minutos para a hora de ir embora, e restam dois presentes para o elfo Dobby fabricar. Ajude-o a descobrir se ele consegui

## Entrada

Cada caso de teste inicia com um inteiro N, indicando quantos minutos faltam para o final do expediente `(2 <= N <= 100)`.

Em seguida haverá dois inteiros A e B, indicando quantos minutos são necessários para fabricar os dois presentes que Dobby precisa fabricar `(1 <= A, B <= 100)`.

## Saída

Imprima uma linha, contendo a frase "Farei hoje!" caso seja possível fabricar os dois presentes antes do final do expediente, ou "Deixa para amanha!" caso contrário.

<table>
	<thead>
		<tr>
			<td><strong>Exemplos de Entrada</strong></td>
			<td><strong>Exemplos de Saída</strong></td>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>20<br>
			15 6</td>
			<td>Deixa para amanha!</td>
		</tr>
		<tr>
			<td>20<br>
			10 10</td>
			<td>Farei hoje!</td>
		</tr>
	</tbody>
</table>