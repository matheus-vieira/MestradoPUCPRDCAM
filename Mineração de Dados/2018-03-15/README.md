# Anotações da aula

Informações anotadas no dia

## O que são dados

* Coleção de dados e seus atributos
* Um atributo é uma propriedade ou característica de um objeto
 * Exemplos: cor dos olhos de uma pessoa, temperatura, etc.
 * Atributo também é conhecido como variável, campo ou característica
* Uma coleção de atributos descreve um objeto
 * Objeto também é conhecido como registro, ponto, caso, amostra, entidade ou instância

Como a receita separa um grupo de usuário para verificar se foi feita corretamente a declaração.\
Utilizando um modelo para classificar.\
Assim podendo verificar se consegue realizar identificar pessoas baseados em atributos.

## Valores de atributos

* Valores de atributos são números ou símbolos assinalados a um atributo.
* Distinção entre atributos e valores de atributos
 * Um mesmo atributo pode ser mapeado em diferentes valores de atributos
  * Exemplo: altura pode ser medida em pés ou metros
 * Diferentes atributos podem ser mapeados no mesmo conjunto de valores
  * Exemplo Valores de atributo para ID e idade dsão inteiros
  * Mas propriedades dis vallores dos atributos podem ser diferentes
   * Id não tem limite mas idade tem um valor máximo e um mínimo

Sempre busque imformações sobre seus dados, quem criou, documentação sobre os dados.

### Medidas de comprimento

A Forma com que se mede um atibuto pode, às vezes, não estar de acordo com as propriedade dos atributos.

### Tipos de atributos

* Há diferentes tipos de atrbutos
 * Nominal
  * Tipo que informa uma singularidade
  * Exemplos: números de Id, cor dos olhos, códigos de CEP
 * Ordinal
  * Tipo que informa uma singularidade com alguma ordem
  * Exemplos: ordem (e.g., gosto de batata frita em uma escala entre 1-10), graus, altura em {alto, médio, baixo}
 * Intervalar
  * Tipo que informa uma escala
  * Exemplos: datas de calendário, temperaturas em Célsius ou Farenheit 
 * Razão
  * Temos uma possibilidade de proporção
  * Exemplos: temperatura em Kelvin, comprimento, tempo, contagem

### Atributos Discretos e Contínuos

* Atributo Discreto
 * Conjunto finito de valores
 * Exemplos: CEP, contagens, números de palabras
* Atributos Contínuos
 * Conjunto de valores variaáveis
 * Exemplos: temperatura, altura ou peso

## Tipos de conjuntos de dados

Da onde vêm meus dados

* Registros
* Grafo
*Ordenados

## Características importantes

Dimensionabilidade

## Dados de Registros

* Dados que consistem ede uma coleção de registros, cada um dos quans consiste de um conjunto fixode atributos.
 * Em outras palavras registros de um banco de dados

## Dados Matriciais

* Se os objetos de dados tem o mesmo conjuntos fixo de atributos
 * também representado por tabelas

## Dados de Documentos

* Cada documento torna-se um vetor de "termos"
 * cada tempo é um componente (atributo) do vetor
 * O valor de cada componente é um número de vezes que o temp corresponde ocorre no documento

Como representar em formato de tabela, cuidado para não perder a sequência

## Dados de Transações


* São dados de registro de um tipo especial, em que:

 * cada registro (transação) encolve um conjunto de itens.
 * Por exemplo, considere um supoermercado. O conjunto de produtos compados por um cliente é uma transação

## Dados de Grafos

* Exemplos: Grafos genéricos e links HTML

## Dados Químicos

* Molécula de Benzeno: C<sub>6</sub><sub>H6</sub> H~2~O C~6H~6

## Dados Ordenados

* Sequência de transações

Transformar para representar a sequência

Se ocorreu A e B então é provável que ocorra C.

* Dados de seuencia genômica

```
GGTTCCGC
GGAAGCGC
GGTTCCGC
```

* Dados Espaço-Temporais

Temperatura média mensal das terras e oceanos, baseado no tempo

## Qualidade dos Dados

* Que tipo de problemas de qualidade de dados?
* Como se pode detectar problemas nos dados
* O que se pode fazer a respeito destes problemas

* Exemplos 
 * Ruidos 
 * dados faltantes
 * dados duplicados

### Ruídos

* Refere-se à modificação de valores originais
 * Exemplos de distorção da voz de uma pessoa falando

Há algorítmos que sogfrem com o ruído

### Outliers


Valor de uma variável, inesperado, que está muito fora do padrão

* Outliers são objetos de dados com características que são consideravelmente diferentes da maioria dos objetos de dados no conjunto de dados

### Valores Faltantes


* Razões para valores faltantes
 * Informação não coletada
  * pessoas não fornecem sua idade e peso
 * Atribusots podem ser aplicáveis a todos os casos
  * salário anual não aplicável a crianças
* Manipulando valores faltantes
 * Eliminar objetos de dados
 * Estimar alores faltantes
 * Ignorar valores faltantes durante análise
 * Substituir por todos os valores possível (poderados por suas probabilidades)

### Dados Duplicados

* conjuntos de dados pode incluir objetos de dados que são cuplicatas, ou quase duplicadas de outros
 * Grade problema quando unindo dados de fontes heterogêneas
 * Exemplos
  * Mesma pessoa com múltiplos endereços de e-mail
 * Limpeza dos dados
  * Processo de trabalho com dados duplicados

Cuidar com repetição, podem ser dados duplicados.

### Agragação

* Combinar dois ou mais atributos (ou objetos) em um único atributo (ou objeto)
* Finalidade
 * Redução de dados
  * Reduzir o número de atributos ou objetos
 * Alteração de escala
  * Cidaddes agregadas em regiões, estados, países, etc.
 * Dados mais "estáveis"
  * Dados agregados tendem a ter menos variabilidade

### Amostragem

* Amostragem é a principal técnica empregada na seleção de dados
 * Usada frequentemente tanto para investigação preliminar dos dados

#### Tipos de amostragem

 * Amostragem simples aleatória
 * Amostragem sem reposição
  * Não pode ser escolhido novamente
 * Amostragem com reposição
  * Pode ser escolhido novamente
 * Amostragem estratificadad
  * Diivide os dados em partições; retira então amostras aleatórias de cada uma das partições
  * A cada nova amostragem, manter as propriedades

### Maldição da Dimensionalidade

* Quando a dimensionalidade aumenta, os dados tornam-se muitos esparsos, no espaço que ocupam
* Definições de densidade e distância entre pontos, que são críticas para agrupamento e detecção de outliers, passam a ter menos significado

Difícil conseguir dados por causa dessa maldição

### Redução da Dimensionalidade

* Finalidade
 * Reduzir a maldição da dimensionalidade
 * Reduz a quantidade de tempo e memória necessárias pelos algorítmos de mineração de dados
 * Permitir que os dados sejam mais facilmente visualizados
 * Ajudar a eliminar características irrelavantes ou a reduzir o ruído
* Técnicas
 * Análise de Componentes Principais - PCA
 * Singular Value Decomposition - SVD
 * Outros: técnicas supervisionadas e não-lineares