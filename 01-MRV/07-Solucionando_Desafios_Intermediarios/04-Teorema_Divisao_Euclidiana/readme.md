<h1>Teorema da Divisão Euclidiana</h1>

<div><div>
<h2>Desafio</h2>

<p>Você recebeu desafio de desenvolver&nbsp;um programa que calcule o quociente e o resto da divisão de dois números inteiros. Não se esqueça&nbsp;que o quociente e o resto da divisão de um inteiro <strong>a</strong> por um inteiro não-nulo <strong>b</strong> são respectivamente os únicos inteiros <strong>q</strong> e <strong>r</strong> tais que:</p>

<p>0 ≤ <strong>r</strong> &lt; |<strong>b</strong>|</p>

<p>Se r &lt; 0:<strong>&nbsp;r = r - </strong>|<strong>b</strong>|</p>

<p><strong>a</strong> = <strong>b</strong> × <strong>q</strong> + <strong>r</strong></p>

<p><strong>q = ( a - r ) / b</strong></p>

<p>Caso você não saiba, o teorema que garante a existência e a unicidade dos inteiros <strong>q</strong> e <strong>r</strong> é conhecido como ‘Teorema da Divisão Euclidiana’ ou ‘Algoritmo da Divisão’.<br>
<br>
**&nbsp;&nbsp;|<strong>b</strong>|<strong> (Módulo / Valor absoluto):&nbsp;</strong>É o valor representado de forma positiva;</p>
</div>

<h2>Entrada</h2>

<div>
<p>A entrada é composta por dois números inteiros <strong>a</strong> e <strong>b</strong> (-1.000 ≤ <strong>a</strong>, <strong>b</strong> &lt; 1.000).</p>
</div>

<h2>Saída</h2>

<div>
<p>Imprima o quociente <strong>q</strong> seguido pelo resto <strong>r</strong> da divisão de <strong>a</strong> por <strong>b</strong>, considerando as regras apresentadas a cima.</p>
</div>

<div>&nbsp;</div>

<table>
	<thead>
		<tr>
			<td>Exemplos de Entrada</td>
			<td>Exemplos de Saída</td>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>
			<p>7 3</p>
			</td>
			<td>
			<p>2 1</p>
			</td>
		</tr>
	</tbody>
</table>

<table>
	<thead>
	</thead>
	<tbody>
		<tr>
			<td>
			<p>7 -3</p>
			</td>
			<td>
			<p>-2 1</p>
			</td>
		</tr>
	</tbody>
</table>

<table>
	<thead>
	</thead>
	<tbody>
		<tr>
			<td>
			<p>-7 -3</p>
			</td>
			<td>
			<p>3 2</p>
			</td>
		</tr>
	</tbody>
</table> <br><br></div>