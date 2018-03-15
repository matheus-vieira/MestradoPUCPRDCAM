# Anota��es da aula

Informa��es anotadas no dia

## O que s�o dados

* Cole��o de dados e seus atributos
* Um atributo � uma propriedade ou caracter�stica de um objeto
 * Exemplos: cor dos olhos de uma pessoa, temperatura, etc.
 * Atributo tamb�m � conhecido como vari�vel, campo ou caracter�stica
* Uma cole��o de atributos descreve um objeto
 * Objeto tamb�m � conhecido como registro, ponto, caso, amostra, entidade ou inst�ncia

Como a receita separa um grupo de usu�rio para verificar se foi feita corretamente a declara��o.\
Utilizando um modelo para classificar.\
Assim podendo verificar se consegue realizar identificar pessoas baseados em atributos.

## Valores de atributos

* Valores de atributos s�o n�meros ou s�mbolos assinalados a um atributo.
* Distin��o entre atributos e valores de atributos
 * Um mesmo atributo pode ser mapeado em diferentes valores de atributos
  * Exemplo: altura pode ser medida em p�s ou metros
 * Diferentes atributos podem ser mapeados no mesmo conjunto de valores
  * Exemplo Valores de atributo para ID e idade ds�o inteiros
  * Mas propriedades dis vallores dos atributos podem ser diferentes
   * Id n�o tem limite mas idade tem um valor m�ximo e um m�nimo

Sempre busque imforma��es sobre seus dados, quem criou, documenta��o sobre os dados.

### Medidas de comprimento

A Forma com que se mede um atibuto pode, �s vezes, n�o estar de acordo com as propriedade dos atributos.

### Tipos de atributos

* H� diferentes tipos de atrbutos
 * Nominal
  * Tipo que informa uma singularidade
  * Exemplos: n�meros de Id, cor dos olhos, c�digos de CEP
 * Ordinal
  * Tipo que informa uma singularidade com alguma ordem
  * Exemplos: ordem (e.g., gosto de batata frita em uma escala entre 1-10), graus, altura em {alto, m�dio, baixo}
 * Intervalar
  * Tipo que informa uma escala
  * Exemplos: datas de calend�rio, temperaturas em C�lsius ou Farenheit 
 * Raz�o
  * Temos uma possibilidade de propor��o
  * Exemplos: temperatura em Kelvin, comprimento, tempo, contagem

### Atributos Discretos e Cont�nuos

* Atributo Discreto
 * Conjunto finito de valores
 * Exemplos: CEP, contagens, n�meros de palabras
* Atributos Cont�nuos
 * Conjunto de valores varia�veis
 * Exemplos: temperatura, altura ou peso

## Tipos de conjuntos de dados

Da onde v�m meus dados

* Registros
* Grafo
*Ordenados

## Caracter�sticas importantes

Dimensionabilidade

## Dados de Registros

* Dados que consistem ede uma cole��o de registros, cada um dos quans consiste de um conjunto fixode atributos.
 * Em outras palavras registros de um banco de dados

## Dados Matriciais

* Se os objetos de dados tem o mesmo conjuntos fixo de atributos
 * tamb�m representado por tabelas

## Dados de Documentos

* Cada documento torna-se um vetor de "termos"
 * cada tempo � um componente (atributo) do vetor
 * O valor de cada componente � um n�mero de vezes que o temp corresponde ocorre no documento

Como representar em formato de tabela, cuidado para n�o perder a sequ�ncia

## Dados de Transa��es


* S�o dados de registro de um tipo especial, em que:

 * cada registro (transa��o) encolve um conjunto de itens.
 * Por exemplo, considere um supoermercado. O conjunto de produtos compados por um cliente � uma transa��o

## Dados de Grafos

* Exemplos: Grafos gen�ricos e links HTML

## Dados Qu�micos

* Mol�cula de Benzeno: C<sub>6</sub><sub>H6</sub> H~2~O C~6H~6

## Dados Ordenados

* Sequ�ncia de transa��es

Transformar para representar a sequ�ncia

Se ocorreu A e B ent�o � prov�vel que ocorra C.

* Dados de seuencia gen�mica

```
GGTTCCGC
GGAAGCGC
GGTTCCGC
```

* Dados Espa�o-Temporais

Temperatura m�dia mensal das terras e oceanos, baseado no tempo

## Qualidade dos Dados

* Que tipo de problemas de qualidade de dados?
* Como se pode detectar problemas nos dados
* O que se pode fazer a respeito destes problemas

* Exemplos 
 * Ruidos 
 * dados faltantes
 * dados duplicados

### Ru�dos

* Refere-se � modifica��o de valores originais
 * Exemplos de distor��o da voz de uma pessoa falando

H� algor�tmos que sogfrem com o ru�do

### Outliers


Valor de uma vari�vel, inesperado, que est� muito fora do padr�o

* Outliers s�o objetos de dados com caracter�sticas que s�o consideravelmente diferentes da maioria dos objetos de dados no conjunto de dados

### Valores Faltantes


* Raz�es para valores faltantes
 * Informa��o n�o coletada
  * pessoas n�o fornecem sua idade e peso
 * Atribusots podem ser aplic�veis a todos os casos
  * sal�rio anual n�o aplic�vel a crian�as
* Manipulando valores faltantes
 * Eliminar objetos de dados
 * Estimar alores faltantes
 * Ignorar valores faltantes durante an�lise
 * Substituir por todos os valores poss�vel (poderados por suas probabilidades)

### Dados Duplicados

* conjuntos de dados pode incluir objetos de dados que s�o cuplicatas, ou quase duplicadas de outros
 * Grade problema quando unindo dados de fontes heterog�neas
 * Exemplos
  * Mesma pessoa com m�ltiplos endere�os de e-mail
 * Limpeza dos dados
  * Processo de trabalho com dados duplicados

Cuidar com repeti��o, podem ser dados duplicados.

### Agraga��o

* Combinar dois ou mais atributos (ou objetos) em um �nico atributo (ou objeto)
* Finalidade
 * Redu��o de dados
  * Reduzir o n�mero de atributos ou objetos
 * Altera��o de escala
  * Cidaddes agregadas em regi�es, estados, pa�ses, etc.
 * Dados mais "est�veis"
  * Dados agregados tendem a ter menos variabilidade

### Amostragem

* Amostragem � a principal t�cnica empregada na sele��o de dados
 * Usada frequentemente tanto para investiga��o preliminar dos dados

#### Tipos de amostragem

 * Amostragem simples aleat�ria
 * Amostragem sem reposi��o
  * N�o pode ser escolhido novamente
 * Amostragem com reposi��o
  * Pode ser escolhido novamente
 * Amostragem estratificadad
  * Diivide os dados em parti��es; retira ent�o amostras aleat�rias de cada uma das parti��es
  * A cada nova amostragem, manter as propriedades

### Maldi��o da Dimensionalidade

* Quando a dimensionalidade aumenta, os dados tornam-se muitos esparsos, no espa�o que ocupam
* Defini��es de densidade e dist�ncia entre pontos, que s�o cr�ticas para agrupamento e detec��o de outliers, passam a ter menos significado

Dif�cil conseguir dados por causa dessa maldi��o

### Redu��o da Dimensionalidade

* Finalidade
 * Reduzir a maldi��o da dimensionalidade
 * Reduz a quantidade de tempo e mem�ria necess�rias pelos algor�tmos de minera��o de dados
 * Permitir que os dados sejam mais facilmente visualizados
 * Ajudar a eliminar caracter�sticas irrelavantes ou a reduzir o ru�do
* T�cnicas
 * An�lise de Componentes Principais - PCA
 * Singular Value Decomposition - SVD
 * Outros: t�cnicas supervisionadas e n�o-lineares