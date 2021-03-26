# [Validador de senhas com requisitos](https://github.com/JefersonMelo/07-DIO/tree/master/03-.Net_Fundamentals/03-Solucao_De_Problemas_Com_.NET/04-Validador_De_Senhas_Com_Requisitos/Program.cs)

<div><div>
<div>
<h2>Desafio</h2>

<p>Pedro e Fernando são os desenvolvedores em uma stratup e vão desenvolver o&nbsp;novo sistema de cadastro, e pediram a sua ajuda. Sua task é fazer o código que valide as senhas que são cadastradas, para isso você deve atentar aos requisitos a seguir:</p>

<ul>
	<li>A senha deve conter, no mínimo, uma letra maiúscula, uma letra minúscula e um número;</li>
	<li>A mesma não pode ter nenhum caractere de pontuação, acentuação ou espaço;</li>
	<li>Além disso, a senha pode ter de 6 a 32 caracteres.</li>
</ul>
</div>

<h2>Entrada</h2>

<div>
<p>A entrada contém vários casos de teste e termina com final de arquivo. Cada linha tem uma string <strong>S</strong>, correspondente a senha que é inserida pelo usuário no momento do cadastro.</p>
</div>

<h2>Saída</h2>

<div>
<p>A saída contém uma linha, que pode ser “Senha valida.”, caso a senha tenha cada item dos requisitos solicitados anteriormente, ou “Senha invalida.”, se um ou mais requisitos não forem atendidos.</p>
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
			<p>Digital Innovation One</p>
			<p>AbcdEfgh99</p>
			<p>DigitalInnovationOne123</p>
			<p>Digital Innovation One 123</p>
			<p>Aass9</p>
			<p>Aassd9</p>
			</td>
			<td>
			<p>Senha invalida.</p>
			<p>Senha valida.</p>
			<p>Senha valida.</p>
			<p>Senha invalida.</p>
			<p>Senha invalida.</p>
			<p>Senha valida.<br>
			&nbsp;</p>
			</td>
		</tr>
	</tbody>
</table>

<div>&nbsp;</div>

<p>&nbsp;</p>
</div> <br><br></div>