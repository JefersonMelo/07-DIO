# [Programa para Validação de Notas](https://github.com/JefersonMelo/07-DIO/tree/master/03-.Net_Fundamentals/03-Solucao_De_Problemas_Com_.NET/01-Programa_Para_Validacao_De_Notas/Program.cs)

<div><div>
<h2>Desafio</h2>

<p>O calendário escolar está passando bem rápido, devido a isso, as professoras de uma escola estão com dificuldade para calcular as notas dos alunos. Visando em resolver a situação, a diretora da escola contratou você para desenvolver&nbsp;um programa que leia as notas da primeira e da segunda avaliação de um aluno. Calcule e imprima a média semestral.</p>

<p>O programa só aceitará&nbsp;notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.</p>

<p>No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando as professoras&nbsp;que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.</p>
</div>

<h2>Entrada</h2>

<div>
<p>O arquivo de entrada contém vários valores reais, positivos ou negativos. Quando forem lidas duas notas válidas, deve ser lido um valor inteiro <strong> X </strong>. O programa deve parar quando o valor lido para este <strong>X</strong> for igual a 2.</p>
</div>

<h2>Saída</h2>

<div>
<p>Se uma nota inválida for lida, deve ser impressa a mensagem “nota invalida”. Quando duas notas válidas forem lidas, deve ser impressa a mensagem “media = ” seguido do valor do cálculo.</p>

<p>Antes da leitura de <strong>X</strong> deve ser impressa a mensagem "novo calculo (1-sim 2-nao)" e esta mensagem deve ser apresentada novamente se o valor da entrada padrão para <strong>X</strong> for menor do que 1 ou maior do que 2, conforme o exemplo abaixo.</p>

<p>A média deve ser impressa com dois dígitos após o ponto decimal.</p>
</div>

<div>&nbsp;</div>

<table>
	<thead>
		<tr>
			<td>Exemplo de Entrada</td>
			<td>Exemplo de Saída</td>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>
			<p>-3.5<br>
			3.5<br>
			11.0<br>
			10.0<br>
			4<br>
			1<br>
			8.0<br>
			9.0<br>
			2</p>
			</td>
			<td>
			<p>nota invalida<br>
			nota invalida<br>
			media = 6.75<br>
			novo calculo (1-sim 2-nao)<br>
			novo calculo (1-sim 2-nao)<br>
			media = 8.50<br>
			novo calculo (1-sim 2-nao)</p>
			</td>
		</tr>
	</tbody>
</table> <br><br></div>