# Plano_de_Testes
Documento para planejamento de um teste de unidade, para o projeto de uma calculadora de IMC, que produz o cálculo do IMC e a classificação de acordo com a Abeso.





PLANO DE TESTE
 
Tabela de Conteúdos

INTRODUÇÃO	3
1.1	OBJETIVOS	3
1.2	MEMBROS	3
2	ESCOPO	3
3	SUPOSIÇÕES / RISCOS	4
3.1	SUPOSIÇÕES	4
4	ABORDAGEM DE TESTE	4
4.1	AUTOMAÇÃO DE TESTE	4
5	AMBIENTE DE TESTE	5
6	MARCOS / ENTREGAS	5
6.1	CRONOGRAMA DE TESTE	5
6.2	ENTREGAS	5
 
Introdução
O Plano de Teste foi criado para comunicar a abordagem de teste aos membros da equipe. Inclui os objetivos, escopo, cronograma, riscos e abordagem.  Este documento identificará claramente quais serão os resultados do teste e o que é considerado dentro e fora do escopo.

1.1	Objetivos
A Testful é uma empresa de desenvolvimento de software focada em testes para garantir a segurança, confiabilidade e consistência dos seus softwares e implementações, bem como os resultados da execução desses testes.  Esta ferramenta é um produto escrito com C#. A equipe de teste é composta por um desenvolvedor.
1.2	Membros da equipe
Nome do recurso	Papel
Jullys Alisson	Desenvolvedor / Testes

2	Escopo
A fase inicial incluirá todos os requisitos. 
Como a equipe trabalha com o produto, eles definirão as necessidades para a segunda fase.
Suposições / Riscos
2.1	Suposições
Esta seção lista suposições que são específicas neste projeto.
1.	A entrega do produto está em formato que a equipe de teste pode conferi-lo no MVS.

3	Abordagem de teste
O projeto está utilizando uma abordagem ágil, com iterações diárias. Ao final de cada dia, os requisitos identificados para essa iteração serão testados. 

3.1	Automação de testes
Testes automatizados de unidade e testes funcionais automatizados fazem parte do processo de desenvolvimento.

4	 Ambiente de teste
Os testes ocorrerão no sistema Windows, Utilizando o software Microsoft Visual Studio.
4.1	Teste unitário 

Definição:

Testa componentes de forma individual, dessa forma cada parte do sistema é analisado independente dos demais. Os testes Unitários foram realizados utilizando o MSTEST, através do MVS, onde foi gerado um código para realização dos testes utilizando as dependências do sistema e referenciando os projetos a serem testados.

4.2	Testes de sistema e integração 

Definição:

Os testes de integração verifica se todos os módulos do sistema funcionam bem juntos. Os testes de integração foram realizados através do MVS, onde foi gerado um código para realização dos testes utilizando as dependências do sistema e referenciando os projetos a serem testados.


5	Marcos / Entregas
5.1	Cronograma de testes
O cronograma inicial do teste segue..........

Nome da tarefa	Começar	Acabar 	Esforço
Planejamento de testes	01/10	01/10	
   Documentos de requisitos de revisão	02/10	03/10	2 d
Implantar o ambiente de teste de QA	03/10	04/10	1 d
Teste funcional – Iteração 1	05/10	05/10	1 d
Implantar para ambiente de teste de QA	06/10	06/10	1 d
Teste funcional – Iteração 2	07/10	07/10	1 d
Teste do sistema	08/10	08/10	1 d
Resolução de defeitos finais e testes finais de construção	09/10	10/10	2 d
Teste de desempenho	11/10	11/10	1 d
Lançamento para Produção	12/10	12/10	1 d


6	Plano de teste

ID de teste	Descrição	Resultados esperados	Resultados reais
1	Testes realizados apresentaram falhas programadas e sucessos esperados	Satisfatórios	Software pronto e atendendo todos os requisitos


 






7	Relatório Final

Teste Unitário

O Planejamento ocorreu dentro do cronograma previsto, documentação gerada de acordo com os requisitos do sistema proposto.
Após o inicio dos testes foram necessárias alterações no código original, ao final tivemos os seguintes resultados.

IMC_Teste_MStest
  Testes em grupo: 4
   Duração total: 63 ms

Resultados
   1 Aprovado
   3 Falhas


 



Testes integração

Os testes de integração ocorreram em um Sistema mais amplo com vários arquivos para serem submetidos aos testes, após realizadas todas a referências necessárias e incluídos todas a dependências os testes ocorreram como esperado.

TesteIntegracao
  Testes em grupo: 2
   Duração total: 255 ms

Resultados
   1 Aprovado
   1 Falha

