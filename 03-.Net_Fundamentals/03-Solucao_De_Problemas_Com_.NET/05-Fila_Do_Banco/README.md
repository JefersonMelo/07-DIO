# [Fila do Banco](https://github.com/JefersonMelo/07-DIO/tree/master/03-.Net_Fundamentals/03-Solucao_De_Problemas_Com_.NET/05-Fila_Do_Banco/Program.cs)

<div><div>
<h2>Desafio&nbsp;</h2>

<p>O banco que você trabalha sempre tem problemas para organizar as filas de atendimento dos clientes.</p>

<p>Após uma reunião com a gerência ficou decidido&nbsp;que os clientes ao chegar na agência receberão uma senha numérica em seu aparelho de celular via sms e que a ordem da fila será dada não pela ordem de chegada, mas sim pelo número recebido via sms. A ordem de atendimento será decrescente: aqueles que receberam&nbsp;número maior deverão ser atendidos primeiro.&nbsp;</p>

<p>Então, dada a ordem de chegada dos clientes reordene a fila de acordo com o número recebido via sms, e diga quantos clientes não precisaram trocar de lugar nessa reordenação.</p>

<h2>Entrada</h2>
</div>

<div>
<p>A primeira linha contém um inteiro <strong>N</strong>, indicando o número de casos de teste a seguir.</p>

<p>Cada caso de teste inicia com um inteiro <strong>M</strong> (1 ≤ <strong>M</strong> ≤ 1000), indicando o número de clientes. Em seguida haverá <strong>M</strong> inteiros distintos <strong>Pi</strong> (1 ≤ <strong>Pi</strong> ≤ 1000), onde o <strong>i</strong>-ésimo inteiro indica o número recebido via sms&nbsp;do <strong>i</strong>-ésimo cliente.</p>

<p>Os inteiros acima são dados em ordem de chegada, ou seja, o primeiro inteiro diz respeito ao primeiro cliente a chegar na fila, o segundo inteiro diz respeito ao segundo cliente, e assim sucessivamente.</p>
</div>

<h2>Saída</h2>

<div>
<p>Para cada caso de teste imprima uma linha, contendo um inteiro, indicando o número de clientes que não precisaram trocar de lugar mesmo após a fila ser reordenada.</p>
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
			<p>3<br>
			3<br>
			100 80 90<br>
			4<br>
			100 120 30 50<br>
			4<br>
			100 90 30 25</p>
			</td>
			<td>
			<p>1<br>
			0<br>
			4</p>
			</td>
		</tr>
	</tbody>
</table> <br><br></div>