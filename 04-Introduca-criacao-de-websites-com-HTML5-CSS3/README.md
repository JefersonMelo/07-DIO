<div>
<h1 style="margin-left:0cm; margin-right:0cm">HTML5</h1>

<h2 style="margin-left:0cm; margin-right:0cm">Definição e estrutura básica</h2>

<p style="margin-left:0cm; margin-right:0cm">Em 1991 Tim Berners-Lee criou essa linguagem de marcação para melhorar
a comunicação entre ele e seus colegas de trabalho no CERN, desde então já surgiram 5 versões e o HTML se tornou
a base da web.</p>

<p style="margin-left:0cm; margin-right:0cm">Com o HTML definimos o significado e a estrutura do conteúdo da web e,
além de texto, nossas páginas precisam de imagens, vídeos e vários outros formatos e para isso temos os
elementos HTML.</p>

<p style="margin-left:0cm; margin-right:0cm">Um elemento HTML é formado pela tag de abertura e seus atributos, o
conteúdo e uma tag de fechamento. E mais a frente veremos que existem elementos que não tem tag de fechamento.
</p>

<p style="margin-left:0cm; margin-right:0cm">Com esses elementos podemos agrupar tipos de conteúdo, alterar tamanho
e forma de fontes e adicionar diferentes mídias ao nossa página na web.</p>

<p style="margin-left:0cm; margin-right:0cm">E agora podemos ver como é a estrutura básica de um arquivo HTML.</p>

<p style="margin-left:0cm; margin-right:0cm">A primeira linha do documento deve ser o &lt;!DOCTYPE html&gt;, apesar
de parecer um elemento HTML ela apenas diz ao navegador que ele está lidando com um arquivo do tipo HTML5. Os
elementos HTML vem logo abaixo.</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;html&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">A tag html é a raiz do seu documento, todos os elementos HTML devem
estar dentro dela. E nela nós informamos ao navegador qual é o idioma desse nosso documento, através do atributo
lang, para o português brasileiro usamos pt-BR.</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;head&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">A tag head contém elementos que serão lidos pelo navegador, como os
metadados - um exemplo é o charset, que é a codificação de caracteres e a mais comum é a UTF-8, o JavaScript com
a tag script, o CSS através das tags style e link - veremos a diferença quando falarmos sobre CSS - e o título
da página com a tag title.</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;body&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">E dentro da tag body colocamos todo o conteúdo visível ao usuário:
textos, imagens, vídeos.</p>

<h2 style="margin-left:0cm; margin-right:0cm"><span style="color:null">Prática</span></h2>

<p style="margin-left:0cm; margin-right:0cm">Como exercício para esse curso iremos construir um site pessoal, e
precisamos começar com a estrutura básica que acabamos de ver.</p>

<p style="margin-left:0cm; margin-right:0cm">Vamos criar um arquivo index.html e adicionar o doctype e os elementos
html, head e body.</p>

<p style="margin-left:0cm; margin-right:0cm">Depois adicionaremos os elementos meta e title, no primeiro adicionamos
o atributo charset com o valor UTF-8 para dizer ao navegador qual é a codificação dos caracteres e no segundo
podemos colocar nosso nome.</p>

<p style="margin-left:0cm; margin-right:0cm">E por último escreveremos nosso nome dentro do elemento body apenas
para enxergarmos isso no navegador.</p>

<h2 style="margin-left:0cm; margin-right:0cm">Semântica</h2>

<p style="margin-left:0cm; margin-right:0cm">Durante muitos anos o elemento padrão no HTML era a div, construíamos
nosso conteúdo todo baseado nela, e assim nascia a sopa de divs.</p>

<p style="margin-left:0cm; margin-right:0cm">Mas em 2014 saiu a quinta versão do HTML, e com ela vieram vários
mudanças importantes, como performance e acessibilidade, mas nesse curso introdutório vamos focar na semântica.
</p>

<p style="margin-left:0cm; margin-right:0cm">A semântica nos permite descrever mais precisamente o nosso conteúdo,
agora um bloco de texto não é apenas uma div, agora é um article e tem mais significado assim. E temos vários
elementos para ressignificar as divs:</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;section&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">Representa uma seção genérica de conteúdo quando não houver um elemento
mais específico para isso.</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;header&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">É o cabeçalho da página ou de uma seção da página e normalmente contém
logotipos, menus, campos de busca.</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;article&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">Representa um conteúdo independente e de maior relevância dentro de uma
página, como um post de blog, uma notícia em uma barra lateral ou um bloco de comentários. Um article pode
conter outros elementos, como header, cabeçalhos, parágrafos e imagens.</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;aside&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">É uma seção que engloba conteúdos relacionados ao conteúdo principal,
como artigos relacionados, biografia do autor e publicidade. Normalmente são representadas como barras laterais.
</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;footer&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">Esse elemento representa o rodapé do conteúdo ou de parte dele, pois
ele é aceito dentro de vários elementos, como article e section e até do body. Exemplos de conteúdo de um
&lt;footer&gt; são informações de autor e <em>links</em> relacionados.</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>&lt;h1&gt;</strong>-<strong>&lt;h6&gt;</strong></p>

<p style="margin-left:0cm; margin-right:0cm">Eles não foram criados na versão 5 do HTML e nem são específicos para
semântica, mas servem para esse propósito. São utilizados para marcar a importância dos títulos, sendo
&lt;h1&gt; o mais importante e &lt;h6&gt; o menos. Uma dica: use apenas um &lt;h1&gt; por página, pois ele
representa o objetivo da sua página.</p>

<h2 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Prática</span></h2>

<p style="margin-left:0cm; margin-right:0cm">Dando continuidade ao nosso site iremos montar sua estrutura. Pensei em
adicionarmos um cabeçalho com nosso nome, uma lista de posts (como um blog) e um rodapé para nossos contatos.
</p>

<p style="margin-left:0cm; margin-right:0cm">Vamos abrir nosso arquivo index.html e começar pelo cabeçalho: criamos
um &lt;header&gt; logo abaixo do &lt;body&gt; e colocamos o título da nossa página dentro de um &lt;h1&gt;.</p>

<p style="margin-left:0cm; margin-right:0cm">Depois criaremos a lista de postagens: abrimos um elemento section e
dentro dele adicionamos outro &lt;header&gt; contendo um &lt;h2&gt;. Notem que eu posso ter mais de um
&lt;header&gt; na página.</p>

<p style="margin-left:0cm; margin-right:0cm">Para criar nossa postagem adicionamos um &lt;article&gt; com um
&lt;header&gt; e um &lt;h3&gt;.</p>

<p style="margin-left:0cm; margin-right:0cm">O último passo desta etapa é criar um rodapé para nossas informações de
contato: crie um elemento footer antes de fechar o &lt;/body&gt;.</p>

<p style="margin-left:0cm; margin-right:0cm">Não se preocupe com o layout e com conteúdo da página, nós vamos tratar
isso mais a frente.</p>

<h2 style="margin-left:0cm; margin-right:0cm">Textos e links</h2>

<p style="margin-left:0cm; margin-right:0cm">A criação do HTML foi motivada pela necessidade de compartilhar textos
e documentos, e mesmo depois de quase 30 anos, com toda a evolução da web, isso ainda representa uma boa parte
do conteúdo da web.</p>

<p style="margin-left:0cm; margin-right:0cm">Já falamos anteriormente sobre os elementos h1-h6 e, eles são
essenciais para nos indicar visualmente a importância e localização de seções de texto na página, mas para
textos maiores e mais densos usamos o elemento p.</p>

<p style="margin-left:0cm; margin-right:0cm">O &lt;p&gt; representa um parágrafo, mas ele não suporta apenas texto,
podemos adicionar imagens, código, vídeos e vários outros tipos de conteúdo dentro dele.</p>

<p style="margin-left:0cm; margin-right:0cm">Um outro elemento interessante e extremamente necessário na web é o
&lt;a&gt; - que significa anchor/âncora, ele representa um hyperlink, é ele que interliga vários conteúdos e
páginas na web.</p>

<p style="margin-left:0cm; margin-right:0cm">O elemento a tem vários atributos, mas vamos focar em dois, o href e o
target.</p>

<p style="margin-left:0cm; margin-right:0cm">O href representa o <em>hyperlink</em> para onde sua âncora aponta,
pode ser uma página do seu ou de outro site, um e-mail e até mesmo um telefone, os dois últimos precisam dos
prefixos tel: e mailto:, respectivamente.</p>

<p style="margin-left:0cm; margin-right:0cm">O target neste momento vai servir para nos ajudar a abrir nossos links
em outra aba do navegador usando o valor _blank.</p>

<h2 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Prática</span></h2>

<p style="margin-left:0cm; margin-right:0cm">Vamos adicionar um texto fictício a nossa postagem: logo após o
fechamento do &lt;/header&gt; vamos adicionar um elemento p e inserir um texto que vamos retirar do site<a
href="https://lipsum.com"> </a><a href="https://lipsum.com"><span
style="color:#1155cc">lipsum.com</span></a></p>

<p style="margin-left:0cm; margin-right:0cm">E em alguma parte deste texto vamos adicionar um <em>hiperlink</em>
para outra página e um para nosso e-mail.</p>

<p style="margin-left:0cm; margin-right:0cm">Criarei um <em>hyperlink</em> para meu perfil no <em>LinkedIn:</em>
adicione o <em>hyperlink</em> no atributo href e o valor _blank no atributo target, assim o <em>link</em> será
aberto em outra aba. E em algum outro lugar do texto adicionarei meu e-mail e um link para ele, desta forma:
&lt;a href="mailto:lucas@vilaboim.com" target="_blank"&gt;lucas@vilaboim.com&lt;/a&gt;</p>

<h2 style="margin-left:0cm; margin-right:0cm">Imagens</h2>

<p style="margin-left:0cm; margin-right:0cm">A web também é feita de imagens e para representá-las temos o elemento
&lt;img&gt;, ele é um daqueles elementos sem tag de fechamento.</p>

<p style="margin-left:0cm; margin-right:0cm">O elemento img é bem simples, contendo apenas 2 atributos próprios, o
src e o alt.</p>

<p style="margin-left:0cm; margin-right:0cm">O src é obrigatório e guarda o caminho para a imagem que você quer
mostrar na página.</p>

<p style="margin-left:0cm; margin-right:0cm">O alt não é obrigatório mas é altamente recomendado por melhorar a
acessibilidade, ele mostra a descrição da imagem caso ela não carregue e leitores de tela usam esse atributo
para descrever a imagem para o usuário saber o que ela significa.</p>

<h2 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Prática</span></h2>

<p style="margin-left:0cm; margin-right:0cm">Vamos adicionar uma imagem ao cabeçalho da página e uma imagem a
postagem.</p>

<p style="margin-left:0cm; margin-right:0cm">Primeiro vamos colocar as imagens na pasta do nosso projeto. Para a
imagem do cabeçalho eu escolhi uma foto minha com 100 <em>pixels</em> de largura e 100 <em>pixels</em> de altura
e para a imagem da postagem eu procurei por <em>html code</em> no site Unsplash, escolhi uma das imagens e
deixei ela com 960 <em>pixels</em> de largura por 322 <em>pixels</em> de altura.</p>

<p style="margin-left:0cm; margin-right:0cm">Dentro do primeiro &lt;header&gt; da página e antes do &lt;h1&gt;
iremos adicionar um elemento img e no atributo src colocamos o caminho para a nossa foto, /lucas-vilaboim.jpg, e
o atributo alt deve conter um significado para a imagem, como no meu caso é uma ilustração, colocarei
<em>Ilustração do rosto de Lucas Vilaboim</em>.</p>

<p style="margin-left:0cm; margin-right:0cm">E dentro do &lt;header&gt; do &lt;article&gt; vamos fazer a mesma
coisa, mas agora depois do &lt;h3&gt;, e no atributo alt colocaremos <em>Editor de texto mostrando códigos
HTML</em>.</p>

<h2 style="margin-left:0cm; margin-right:0cm">Listas</h2>

<p style="margin-left:0cm; margin-right:0cm">Os últimos elementos que veremos neste módulo são os relacionados a
listas: &lt;ul&gt;, &lt;ol&gt; e &lt;li&gt;.</p>

<p style="margin-left:0cm; margin-right:0cm">Listas servem para agrupar uma coleção de itens, como uma lista de
ingredientes ou, como será no nosso caso, uma lista com contatos.</p>

<p style="margin-left:0cm; margin-right:0cm">O elemento ul cria uma lista não ordenada, onde a ordem dos elementos
não é importante, e é representada com pontos, círculos ou quadrados.</p>

<p style="margin-left:0cm; margin-right:0cm">O &lt;ol&gt; serve para criar lista ordenadas, nessas a ordem importa,
portanto elas são representadas com números, algarismos romanos ou letras.</p>

<p style="margin-left:0cm; margin-right:0cm">E o elemento li é um item dentro de uma dessas listas. Um &lt;li&gt;
pode conter vários tipos de conteúdos, como parágrafos, imagens e até outras listas.</p>

<h2 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Prática</span></h2>

<p style="margin-left:0cm; margin-right:0cm">Adicionaremos uma lista de contatos ao rodapé da nossa página, e para
isso usaremos também o elemento <em>a</em> que vimos anteriormente.</p>

<p style="margin-left:0cm; margin-right:0cm">Crie um elemento ul e dentro dele adicione um &lt;li&gt; com um
elemento a, no atributo href adicione o <em>link</em> de alguma rede social que você mantenha e, no conteúdo da
âncora coloque o nome dessa rede.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>
</div>




<div>
<h1 style="margin-left:0cm; margin-right:0cm">CSS 3</h1>

<h2 style="margin-left:0cm; margin-right:0cm">Definição e seletores</h2>

<p style="margin-left:0cm; margin-right:0cm">Após a criação do HTML a necessidade de formatar as páginas ficou
evidente, assim, em 1996, foi criada a linguagem de estilo que conhecemos por CSS.</p>

<p style="margin-left:0cm; margin-right:0cm">A sintaxe é bem simples e pode ser explicada com a frase "você cria
regras de estilo para elementos ou grupos de elementos".</p>

<p style="margin-left:0cm; margin-right:0cm">Vamos usar um elemento HTML que vimos anteriormente, a âncora
&lt;a&gt;, para exemplificar.</p>

<p style="margin-left:0cm; margin-right:0cm">Uma regra CSS é representada por um seletor ou um grupo de seletores,
no nosso caso é o &lt;a&gt;, então dentro de um par de chaves adicionamos as declarações, no exemplo acima
estamos alterando cor e tamanho da fonte dessa âncora, as declarações são formadas por uma propriedade e um
valor.</p>

<p style="margin-left:0cm; margin-right:0cm">Percebam que podemos colocar vários seletores em uma regra separando-os
por vírgula.</p>

<p style="margin-left:0cm; margin-right:0cm">E há um último detalhe nesse exemplo: a pseudo-classe. Elementos HTML
sofrem alterações causadas pela interação do usuário, como mover o mouse por cima ou clicar nesse elemento.</p>

<p style="margin-left:0cm; margin-right:0cm">O <em>a:hover</em> do exemplo significa que a âncora também terá essa
aparência quando o usuário passar o mouse por cima de um <em>hyperlink</em>.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h2 style="margin-left:0cm; margin-right:0cm">ID x Classe</h2>

<p style="margin-left:0cm; margin-right:0cm">No exemplo anterior criamos uma regra que altera um elemento HTML
diretamente, mas isso significa que todos os elementos &lt;a&gt; ficarão com aquela aparência, e normalmente
temos sites mais complexos que precisam de várias regras diferentes para elementos iguais.</p>

<p style="margin-left:0cm; margin-right:0cm">Para ficar mais tangível vamos relembrar um pouco o site que começamos
a fazer no módulo passado, ele tinha vários elementos header, mas não vamos querer que o header principal tenha
a mesma formatação que o header de uma postagem, é aí que entram os IDs e Classes.</p>

<p style="margin-left:0cm; margin-right:0cm">O seletor que vimos no primeiro exemplo é um seletor de tipo, pois ele
representa um elemento HTML, e com IDs e Classes podemos representar qualquer tipo de elemento mas há algumas
diferenças entre eles:</p>

<p style="margin-left:0cm; margin-right:0cm">ID: é representado pelo símbolo # (hash) seguido de um nome para esse
ID.</p>

<p style="margin-left:0cm; margin-right:0cm">Classe: a classe é representada de forma parecida do ID, mas é
precedida por um ponto em vez do hash.</p>

<p style="margin-left:0cm; margin-right:0cm">E a diferença mais importante entre eles é a forma como devem ser
usados: o ID só pode ser usado uma vez em uma página HTML enquanto a classe não tem restrições.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Exercício</span></h3>

<p style="margin-left:0cm; margin-right:0cm">Vamos adicionar algumas classes no nosso site e alterar alguns
elementos, mas antes precisamos adicionar um arquivo CSS a nossa página.</p>

<p style="margin-left:0cm; margin-right:0cm">No módulo de HTML descobrimos que podemos adicionar CSS de duas formas,
com o elemento <em>style</em>, e assim suas regras ficarão no arquivo HTML, ou podemos criar um arquivo CSS e
adicioná-lo na página através do elemento <em>link</em>, e é essa forma que usaremos.</p>

<p style="margin-left:0cm; margin-right:0cm">Crie um elemento <em>link</em> dentro do head do seu arquivo e adicione
os atributos <em>rel="stylesheet"</em> e <em>href="style.css"</em>, o <em>rel</em> denota o tipo de arquivo que
estamos incluindo na página e o <em>href</em> é o caminho para o arquivo. E na mesma pasta do arquivo
<em>HTML</em> crie um arquivo chamado <em>style.css</em>.</p>

<p style="margin-left:0cm; margin-right:0cm">Agora sim vamos ao CSS, adicione um ID #title ao h1 da página, pois
queremos que ele seja único, e depois adicione as classes .subtitle e .post_title ao h2 e h3, respectivamente.
</p>

<p style="margin-left:0cm; margin-right:0cm">No arquivo CSS vamos mudar a cor desses três títulos, e depois alterar
o tamanho da fonte do título da postagem.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h2 style="margin-left:0cm; margin-right:0cm">Box-model</h2>

<p style="margin-left:0cm; margin-right:0cm">Quando estamos criando o layout de um site o navegador representa cada
elemento HTML&nbsp; como uma caixa retangular, isso é o box-model. E com CSS nós alteramos a aparência dessa
caixa (largura, altura, cor de fundo, etc.). Essa caixa é composta por 4 áreas: o conteúdo, o padding, a borda e
a margem.</p>

<ul>
<li>As margens (margin) são espaçamentos entre elementos;</li>
<li>As bordas (border) ;</li>
<li>O padding é um espaçamento entre as bordas e o conteúdo, a diferença para as margens é que declarações de
imagem de fundo funcionam nele;</li>
<li>O conteúdo (content) é o que o seu bloco representa, um texto, uma imagem, um vídeo;</li>
</ul>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Exercício</span></h3>

<p style="margin-left:0cm; margin-right:0cm">Para enxergamos o box-model vamos adicionar cores e bordas a alguns
elementos.</p>

<p style="margin-left:0cm; margin-right:0cm">Primeiro adicionaremos uma cor de fundo para a visualização ficar mais
fácil, usaremos a propriedade <em>background</em> com o valor <em>#fcfcfc</em> no elemento <em>body</em>.</p>

<p style="margin-left:0cm; margin-right:0cm">Depois vamos adicionar uma classe ao &lt;article&gt;, pode ser .post, e
então vamos colocar a cor branca de fundo com a propriedade <em>background</em> e o valor <em>#FFF</em>. Agora
conseguimos enxergar o <em>content</em> do <em>box-model</em>.</p>

<p style="margin-left:0cm; margin-right:0cm">Vamos adicionar um <em>padding</em> de 10 pixels neste mesmo
<em>article</em>. Perceberam o espaçamento que surgiu em volta do nosso conteúdo?</p>

<p style="margin-left:0cm; margin-right:0cm">Agora adicionamos um borda mais escura a ele com a propriedade border.
Vou falar mais detalhadamente sobre border mais a frente, mas por enquanto vamos deixar essa borda com 3 pixels
de largura, o contorno sólido e a cor azul.</p>

<p style="margin-left:0cm; margin-right:0cm">E por último vamos adicionar uma margem do lado de fora do post com a
propriedade <em>margin</em> e o valor 10 pixels.</p>

<p style="margin-left:0cm; margin-right:0cm">E agora inspecionando o nosso elemento conseguimos todas aquelas
camadas citadas antes: o conteúdo em azul, o <em>padding</em> em verde, as bordas em marrom e as margens em
laranja.</p>

<p style="margin-left:0cm; margin-right:0cm">E já que começamos a falar sobre bordas e cor de fundo, no próximo
vídeo vamos nos aprofundar nessas propriedades.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h2 style="margin-left:0cm; margin-right:0cm">Estilizando elementos</h2>

<p style="margin-left:0cm; margin-right:0cm">Agora que entendemos o box-model podemos focar em deixar nosso site
mais bonito, então vamos repassar pelas propriedades já citadas:</p>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Padding e Margin</span></h3>

<p style="margin-left:0cm; margin-right:0cm">Anteriormente usamos o <em>padding</em> e o <em>margin</em> da forma
mais básica, com apenas um valor, mas eles são mais poderosos que isso. Se quisermos atribuir tamanhos
diferentes para cada lado do <em>box</em> nós podemos, e vamos ver três formas de fazer isso.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm">A primeira é colocando um valor para as partes superior e inferior e
depois para os lados esquerdo e direito.</p>

<p style="margin-left:0cm; margin-right:0cm">O valor de 10 <em>pixels</em> se refere ao eixo Y, ou partes superior e
inferior, e os 5 <em>pixels</em> se referem aos lados esquerdo e direito.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm">A segunda forma é dando valores para cada lado do <em>box</em>.</p>

<p style="margin-left:0cm; margin-right:0cm">Então começamos pelo topo com 15 pixels, passamos o lado direito com 10
pixels, depois para a parte inferior com 5 pixels e por último o lado esquerdo com 0, e sempre nessa ordem.</p>

<p style="margin-left:0cm; margin-right:0cm">Uma boa dica também é que quando o valor for 0 não precisamos não
precisamos colocar a unidade.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm">A terceira forma é com as propriedades específicas para cada lado, até
agora tínhamos visto atalhos para essas propriedades.</p>

<p style="margin-left:0cm; margin-right:0cm">Essa opção é mais usada quando temos o mesmo valor para 3 lados, e o
quarto precisa ter um valor diferente, então usamos o padding com apenas um valor e uma dessas opções para
representar o lado diferente.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Background</span></h3>

<p style="margin-left:0cm; margin-right:0cm">A propriedade <em>background</em> também é um atalho para várias
propriedades, mas isso vocês podem absorver aos poucos, e uma boa opção de leitura é a documentação do MDN.</p>

<p style="margin-left:0cm; margin-right:0cm">Por enquanto veremos apenas como mudar a cor de fundo.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm">E aqui temos 3 formas de colocar uma cor de fundo, e ainda existem
outras.</p>

<p style="margin-left:0cm; margin-right:0cm">A primeira é pelo nome da cor em inglês, a segunda é pelo código
hexadecimal e a terceira é usando apenas o atalho <em>background</em>.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Border</span></h3>

<p style="margin-left:0cm; margin-right:0cm">Vimos que a propriedade <em>border</em> pode ter 3 valores: a largura,
a cor e o estilo, mas existem algumas particularidades nisso.</p>

<p style="margin-left:0cm; margin-right:0cm">A largura pode ser usada com várias unidades, como px, em e mm. A cor
pode ser atribuída pelo nome ou por um código hexadecimal, assim como fizemos com o <em>background</em>, e o
estilo é representada por palavras-chave, vamos ver algumas delas:</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>solid</strong>: mostra uma borda simples e reta;</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>dotted</strong>: são bolinhas com um pequeno espaçamento entre
elas;</p>

<p style="margin-left:0cm; margin-right:0cm"><strong>dashed</strong>: forma uma linha tracejada.</p>

<p style="margin-left:0cm; margin-right:0cm">E aproveitando que mostrei esse código temos que falar sobre como
separar a estilização dos lados de uma borda.</p>

<p style="margin-left:0cm; margin-right:0cm">E se você não quiser usar a propriedade <em>border</em> existem as
propriedade específicas para cada aspecto de uma borda, são elas <em>border-width</em> para a largura,
<em>border-color</em> para a cor e <em>border-style</em> para o estilo.</p>

<p style="margin-left:0cm; margin-right:0cm">Aqui temos o mesmo código anterior de duas formas diferentes, a
primeira com o atalho <em>border</em> e a segunda com cada propriedade específica.</p>

<p style="margin-left:0cm; margin-right:0cm">E depois disso podemos juntar os lados com os aspectos de uma borda e
criar uma regra mais específica ainda.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<p style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Border-radius</span></p>

<p style="margin-left:0cm; margin-right:0cm">E a última propriedade é o <em>border-radius</em>, ele permite
arredondar os cantos de um elemento. Podemos usar várias unidades, mas as mais comuns são os pixels e a
porcentagem.</p>

<p style="margin-left:0cm; margin-right:0cm">Colocando apenas um valor mudamos todos os cantos do elemento, mas
seguindo aquela mesma ordem que vimos no <em>padding</em> e <em>margin</em> - topo, direita, inferior e esquerda
-&nbsp; conseguimos alterar cada canto separadamente.</p>

<h3 style="margin-left:0cm; margin-right:0cm">&nbsp;</h3>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">Exercício</span></h3>

<p style="margin-left:0cm; margin-right:0cm">Neste exercício vamos deixar o nosso site um pouco mais bonito usando
as propriedades que acabamos de ver.</p>

<p style="margin-left:0cm; margin-right:0cm">Vamos aumentar o padding para 15 pixels e colocar uma margem de também
de 15 pixels só na parte de baixo do post.</p>

<p style="margin-left:0cm; margin-right:0cm">Quando olhamos para os textos percebemos que os espaçamentos estão
diferentes do restante do post, então vamos padronizar isso.</p>

<p style="margin-left:0cm; margin-right:0cm">No título do post vamos retirar todas as margens para depois colocar
apenas uma margem inferior de 15 pixels. E no corpo do post precisamos adicionar uma classe e remover todas as
margens para depois adicionar uma margem superior de 15 pixels.</p>

<p style="margin-left:0cm; margin-right:0cm">Podemos manter o background branco, mas vamos diminuir a largura das
bordas para 2 pixels e mudar a cor para a mesma do texto - #505050 - e por último adicionaremos um
border-radius, 5 pixels são suficientes. Podemos adicionar esse mesmo de valor de border-radius na imagem, para
isso vamos acrescentar uma class a imagem antes.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h2 style="margin-left:0cm; margin-right:0cm">Estilizando textos</h2>

<p style="margin-left:0cm; margin-right:0cm">Já sabemos que podemos mudar cor e tamanho de algumas fontes, e agora
vamos nos aprofundar nisso.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">font-family</span></h3>

<p style="margin-left:0cm; margin-right:0cm">Com o font-family podemos alterar a fonte dos nossos textos, como uma
fonte da internet ou uma que esteja instalada no nosso computador, mas vamos nos ater às fontes seguras,
chamadas de web safe fonts.</p>

<p style="margin-left:0cm; margin-right:0cm">Essas fontes são chamadas assim pois são encontradas em quases todos os
sistemas e podem ser usadas sem preocupação.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">font-size</span></h3>

<p style="margin-left:0cm; margin-right:0cm">O font-size nos ajuda a mudar o tamanho do texto, existem algumas
unidades de medida para ele mas por enquanto os pixels são suficientes para nós.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>

<h3 style="margin-left:0cm; margin-right:0cm"><span style="color:#434343">font-style</span></h3>

<p style="margin-left:0cm; margin-right:0cm">Usamos o font-style para tornar um texto itálico, na maioria das vezes
você usará apenas o valor <em>italic</em> para ele, mas se precisar tirar o itálico de um texto você pode usar o
valor <em>normal</em>.</p>

<p style="margin-left:0cm; margin-right:0cm">&nbsp;</p>
</div>