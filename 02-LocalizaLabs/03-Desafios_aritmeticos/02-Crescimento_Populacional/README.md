<h1>Crescimento Populacional</h1>

<div><div>
<h2>Desafio</h2>

<p>O Governador do Estado quer saber sobre as taxas de crescimento das cidades. De acordo com dados&nbsp;da&nbsp;população e a taxa de crescimento de duas cidades quaisquer (A e B), ele quer que você calcule quantos anos levará para que a cidade menor (A) cresça mais em população que a cidade maior (B).</p>

<p>Claro que o Governador&nbsp;quer saber apenas para as cidades cuja taxa de crescimento da cidade A é maior do que a taxa de crescimento da cidade B, portanto, previamente já separou para você apenas os casos de teste que tem a taxa de crescimento maior para a cidade A.</p>

<p>Desenvolva um programa que apresente o tempo, em anos, para cada caso.</p>

<p>Porém, em alguns casos o tempo pode ser muito grande, e o Governador não se interessa em saber exatamente o tempo para estes casos, já que ele pode não estar mais eleito. Basta que você informe, nesta situação, a mensagem "Mais de 1 século.".</p>
</div>

<h2>Entrada</h2>

<div>
<p>A primeira linha da entrada contém um único inteiro <strong>T</strong>, indicando o número de casos de teste (1 ≤ <strong>T</strong> ≤ 3000). Cada caso de teste contém 4 números: dois inteiros <strong>PA</strong> e <strong>PB</strong> (100 ≤ <strong>PA</strong> &lt; 1000000, <strong>PA</strong> &lt; <strong>PB</strong> ≤ 1000000) indicando respectivamente a população de A e B, e dois valores <strong>G1</strong> e <strong>G2</strong> (0.1 ≤ <strong>G1</strong> ≤ 10.0, 0.0 ≤ <strong>G2</strong> ≤ 10.0, <strong>G2</strong> &lt; <strong>G1</strong>) com um digito após o ponto decimal cada, indicando respectivamente o crescimento populacional de A e B (em percentual).</p>

<p><strong>Atenção:</strong> A população é sempre um valor inteiro, portanto, um crescimento de 2.5 % sobre uma população de 100 pessoas resultará em 102 pessoas, e não 102.5 pessoas, enquanto um crescimento de 2.5% sobre uma população de 1000 pessoas resultará em 1025 pessoas. Além disso, não utilize variáveis de precisão simples para as taxas de crescimento.</p>
</div>

<h2>Saída</h2>

<div>
<p>Imprima, para cada caso de teste, quantos anos levará para que a cidade A ultrapasse a cidade B em número de habitantes. Obs.: se o tempo for mais do que 100 anos o programa deve apresentar a mensagem: Mais de 1 seculo. Neste caso, é melhor interromper o programa imediatamente após passar de 100 anos, caso contrário você poderá receber como resposta da submissão deste problema "Time Limit Exceeded".</p>
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
			<p>6<br>
			100 150 1.0 0<br>
			90000 120000 5.5 3.5<br>
			56700 72000 5.2 3.0<br>
			123 2000 3.0 2.0<br>
			100000 110000 1.5 0.5<br>
			62422 484317 3.1 1.0</p>
			</td>
			<td>
			<p>51 anos.<br>
			16 anos.<br>
			12 anos.<br>
			Mais de 1 seculo.<br>
			10 anos.<br>
			100 anos.</p>
			</td>
		</tr>
	</tbody>
</table> <br><br></div>