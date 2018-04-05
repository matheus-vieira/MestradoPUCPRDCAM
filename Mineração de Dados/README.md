 Sobre a Disciplina de Mineraçao de Dados

## Professor Júlio Cesar Nievola

[Email do Professor](mailto:nievola@ppgia.pucpr.br)

### Trabalho e provas

* Avalia��o dia 26/04/2018

* Apresenta��o do Trabalho na semana seguinte.

## Material

[Eureka](https://eureka.pucpr.br)

## Aula dia 08/03/2018

### Aprendizado de Máquina

Trabalhar com dados, prever dados a partir de um histórico e novas informações.\
Rearranjar/reorganização de dados\
Buscar padrões o que existe de comum.\
\
Mineração de dados é aprendizado de máquina com alguns requisitos a mais.
Resolver o problema e passar para um humano tomar decisão.\
Modelos auto explicativos, para facilitar a tomada de decisão.\
\
Premisas da Mineração de Dados:

* Compreensível pelo ser humano
* Tem que descobrir algo novo.

Requisito obrigatório:

* Ter dados

Verificar a qualidade dos dados.

#### Por quê minerar dados - Visão comercial

80-90 - Termo Mineração de dados

20-30 anos de trabalhos com mineração de dados

Há muitos dados disponíveis, é relativamente barato para armazenar dados

#### Por quê minerar dados - Visão científica

Sensores de satélites.

Ajudar cientistas.

* Classificando e seguimentando dados
* Formulando hipóteses

### Definição

* Extração não trivial de informação implícita, previamente desconhecia e potencialmente útil a partir dos dados
* Exploração & análise, por meios semi-automáticos de grandes quantidades de dados afim de descobriri padrões significativos

Dado e informação é pontual\
Conhecimento são padrões de comportamento\

Pré-processamento ->Processamento -> Transformação => Mineração de dados -> Avaliação dos modelos\
O processo acima é chamado de Descoberta de Conhecimento a Partir dos Dados.\
A mineração de dados é apenas um passo do processo.\

### O que (não) é Mineração de Dados

 O que não é Mineração de Dados
* Buscar um telefone em um catálogo
* Perguntar a um motor de busca por informação sobre "Amazon"

### Origens da Mineração

A mineração de dados é uma mistura de:

* Sistemas,
* bancos de dados,
* estatística/IA,
* Aprendizado de Máquina,
* Reconhecimento de Padrões

### Tarefas de Mineração de Dados

* Métodos Preditivos
  * Usa algumas variáveis para prever valores desconhecidos ou puturos de outras variáveis
    * Classificação
    * Regressão
    * Detecção de Desvios
* Métodos Descritivos
  * Encontra padrões compreensíveis por humanos para descrever dados
    * Agrupamento
    * Descoberta de Regras de Associação
    * Descoberta de Padrões Sequenciais

#### Classificação

* Dado um conjunto de registros (conjunto de treinamento)
  * Cada registro contém um conjunto de *atributos*, um dos atributos é a *classe*.
* Encontrar um modelo para o atributo classe como uma função dos valores dos outros atributos.
* Objetivo: a registros previamente não-usados deve ser assinalada uma classe tão precisamente quanto possível.
  * Um conjunto de testes é usando para determinar uma precisão do modelo. Usualmente, o conjunto de ddos é dividido em conjunto de treinamento e conjunto de testes, sendo o conjunto de treinamento usad para construir o modelo e o conjunto de testes usado para validá-lo

### Desafios em Mineração de Dados

* Escabilidade
* Dimensionalidade
* Dados Complexos e Heterogêneos
* Qualidade de Dados
* Propriedade e Distribuição dos Dados
* Preservação da Privacidade
* Fluxo de Dados