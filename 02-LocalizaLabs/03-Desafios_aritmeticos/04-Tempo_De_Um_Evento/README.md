<div class="tab-content"><div class="tab-pane p-0 active"><div style="overflow-y: scroll; height: 605.8px;"><div class="font-weight-bold row"><div class="col-md-5"><i style="font-size: 15px; color: rgb(250, 150, 42); font-family: MaterialCommunityIcons; font-weight: normal; font-style: normal;"></i> Intermediário</div><div class="col-md-7"><i style="font-size: 13px; color: rgb(250, 150, 42); font-family: MaterialCommunityIcons; font-weight: normal; font-style: normal;"></i> Princípios Básicos</div></div><hr><div><div>
<div>
<p>Pedrinho está organizando um evento em sua Universidade. O evento deverá ser no mês de Abril, iniciando e terminando dentro do mês. O problema é que Pedrinho quer calcular o tempo que o evento vai durar, uma vez que ele sabe quando inicia e quando termina o evento.</p>

<p>Sabendo que o evento pode durar de poucos segundos a vários dias, você deverá ajudar Pedrinho a calcular a duração deste evento.</p>
</div>

<h2>Entrada</h2>

<div>
<p>Como entrada, na primeira linha vai haver a descrição “Dia”, seguido de um espaço e o dia do mês no qual o evento vai começar. Na linha seguinte, será informado o momento no qual o evento vai iniciar, no formato <strong>hh : mm : ss</strong>. Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras linhas, indicando o término do evento.</p>
</div>

<h2>Saída</h2>

<div>
<p>Na saída, deve ser apresentada a duração do evento, no seguinte formato:<br>
<br>
W dia(s)<br>
X hora(s)<br>
Y minuto(s)<br>
Z segundo(s)<br>
<br>
<em>Obs: Considere que o evento do caso de teste para o problema tem duração mínima de 1 minuto.</em></p>
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
			<p>Dia 5<br>
			08 : 12 : 23<br>
			Dia 9<br>
			06 : 13 : 23</p>
			</td>
			<td>
			<p>3 dia(s)<br>
			22 hora(s)<br>
			1 minuto(s)<br>
			0 segundo(s)</p>
			</td>
		</tr>
	</tbody>
</table>
</div> <br><br></div></div></div><div class="tab-pane p-0"><div style="overflow-y: scroll; height: 605.8px;"><div class="mb-3 row"><div class="col-md-12">Todas as entradas e saída dos algoritmos são utilizados o STDIN e STDOUT de cada linguagem, abaixo tem algumas dicas de como utilizar cada STDIN e STDOUT de cada linguagem.</div></div><hr><div class="row"><div class="col-md-12"><p class="mb-1"><strong>JavaScript</strong></p><p>Em JavaScript as funções de STDIN e STDOUT respectivamente são<strong>gets</strong> e <strong>console.log</strong>, a função gets é implementada internamente para auxiliar a entrada dos dados.</p><p class="mb-1"><strong class="mb-1">Exemplo:</strong><pre class="mb-0">let line = gets(); // Retorna a próxima linha de entrada</pre><pre>console.log(line); // Imprime o dado</pre></p></div></div><hr><div class="row"><div class="col-md-12"><p class="mb-1"><strong>Java</strong></p><p>Em Java existe várias formas de implementar o STDIN e STDOUT recomendamos utilizar <strong>BufferedReader</strong> para o STDIN e o <strong>System.out.println</strong> para o STDOUT.</p><p class="mb-1"><strong class="mb-1">Exemplo:</strong><pre class="mb-0">BufferedReader br = new BufferedReader(new InputStreamReader(System.in));</pre><pre class="mb-0">StringTokenizer st = new StringTokenizer(br.readLine()); // Lê a linha de entrada</pre><pre class="mb-0">int a = Integer.parseInt(st.nextToken());</pre><pre>System.out.println(a); // Imprime o dado</pre></p></div></div><hr><div class="row"><div class="col-md-12"><p class="mb-1"><strong>Python</strong></p><p>Em Python existe várias formas de implementar o STDIN e STDOUT recomendamos utilizar <strong>sys.stdin.readline</strong> para o STDIN e o <strong>print</strong> para o STDOUT.</p><p class="mb-1"><strong class="mb-1">Exemplo:</strong><pre class="mb-0">import sys</pre><pre class="mb-0">a = int(sys.stdin.readline()) // Lê a linha de entrada</pre><pre>print(a); // Imprime o dado</pre></p></div></div><hr><div> <br><br></div></div></div><div class="tab-pane p-0 faq"><div style="overflow-y: scroll; height: 605.8px;"><button type="button" class="font-weight-bold mb-3 btn btn-secondary btn-block">VISUALIZAR TOUR INTERATIVO</button><hr><div class="item-question my-2 card"><div id="toggler-question-0" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">Por que devo realizar esse desafio de código?</h6></div></div></div><div toggler="#toggler-question-0" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Esse desafio de código lhe ajudará a praticar e aplicar os conceitos apresentados nas aulas e exercícios. Para ter destaque na carreira de desenvolvimento de software é necessário praticar muito com algoritmos e projetos reais de mercado. Ambos disponíveis na Digital Innovation One.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-1" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">Como posso tirar dúvidas sobre esse desafio?</h6></div></div></div><div toggler="#toggler-question-1" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Para tirar dúvidas sobre esse desafio você deve acessar e interagir com os desenvolvedores de software da comunidade no Discord (<a href="https://discord.gg/MUdRyVg" target="_blank" class="font-weight-bold text-white">clique aqui para acessar</a>). A capacidade de aprendizagem colaborativa é uma das habilidades mais reconhecidas pelo mercado uma vez que as tecnologias estão em rápida evolução e o trabalho em equipe é uma atividade primordial.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-2" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">O que são os testes?</h6></div></div></div><div toggler="#toggler-question-2" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Os testes validam se o código desenvolvido atende todas as condições requeridas na descrição do desafio.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-3" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">O que são testes abertos?</h6></div></div></div><div toggler="#toggler-question-3" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Os testes abertos são exemplos que podem ser usados para avaliar alguns dos requisitos do código desenvolvido. Ao clicar sobre um teste aberto é possível verificar os parâmetros de entrada e as saídas esperadas. Para executar o teste aberto basta clicar sobre o botão azul “Executar Testes”.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-4" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">O que são testes ocultos?</h6></div></div></div><div toggler="#toggler-question-4" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Os testes ocultos validam se o código desenvolvido atende todos os requisitos da solução após você clicar sobre o botão verde “Entregar Desafio”.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-5" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">Quantos XP é possível ganhar caso o desafio entregue obtenha sucesso em todos os testes?</h6></div></div></div><div toggler="#toggler-question-5" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Ao concluir um desafio com sucesso você receberá 60 XP para desafios classificados como básico, 90 XP para intermediário e 120 XP para avançado.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-6" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">Caso eu entregue o desafio e não não tenha sucesso em um ou mais testes, o que acontece?</h6></div></div></div><div toggler="#toggler-question-6" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Para cada código desenvolvido e entregue sem sucesso você perde um heart.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-7" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">O que representam os hearts?</h6></div></div></div><div toggler="#toggler-question-7" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Os hearts representam a quantidade possível de soluções submetidas incorretas disponível para você, sendo no máximo 5. Servem para que haja maior atenção e pensamento crítico na entrega das atividades.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-8" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">Em quanto tempo é possível recuperar um heart perdido?</h6></div></div></div><div toggler="#toggler-question-8" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Um heart perdido é recuperado em 2 horas para membros FREE e em 6 minutos para membros DIO PRO.</div></div></div></div></div><div class="item-question my-2 card"><div id="toggler-question-9" class="py-2 card-header"><div class="d-flex align-items-center row"><div class="col-md-12"><h6 class="mb-0">Tenho que completar o desafio para concluir o bootcamp?</h6></div></div></div><div toggler="#toggler-question-9" class="collapse"><div class="py-0 card-body"><hr><div class="pb-3 row"><div class="col-md-12">Sim, para completar totalmente o bootcamp é necessário concluir todos os desafios.</div></div></div></div></div></div></div></div>