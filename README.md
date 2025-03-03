# SISTEMA_GERENCIADOR_DE_GARRAFEIRA_SSG
Documentação do Sistema de Gerenciamento de Garrafeira

1. Introdução

O sistema de gerenciamento de garrafeira foi desenvolvido para otimizar o controle de estoque e vendas de bebidas. Ele permite a administração eficiente dos produtos, categorias, clientes, fornecedores e usuários do sistema, garantindo um fluxo de trabalho organizado e seguro.

2. Objetivo

O principal objetivo do sistema é oferecer um ambiente de gestão simplificado e eficaz para estabelecimentos que comercializam bebidas, permitindo:

Controle de estoque detalhado, evitando desperdícios ou falta de produtos.

Registro de vendas, com emissão de recibos e acompanhamento do histórico de transações.

Gerenciamento de usuários, diferenciando permissões entre administradores e atendentes.

Organização de produtos e categorias, tornando as buscas mais rápidas e precisas.



---

3. Estrutura do Projeto

O sistema está estruturado da seguinte forma:

3.1. Arquivos e Diretórios

3.2. Banco de Dados

O sistema utiliza LINQ to SQL para gerenciar o banco de dados. O modelo de dados é definido nos arquivos:

conexaoDB/conexao.dbml → Mapeia as tabelas do banco de dados.

conexaoDB/conexao.designer.cs → Código gerado automaticamente para manipulação dos dados.


Principais tabelas do banco de dados:
| Tabela | Descrição | |--------|-----------| | Usuarios | Contém informações de login e permissões. | | Produtos | Armazena os dados das bebidas, incluindo preço, volume e tipo. | | Categorias | Classifica os produtos para facilitar a organização. | | Vendas | Registra todas as transações realizadas no sistema. | | Fornecedores | Guarda informações sobre os fornecedores das bebidas. | | Clientes | Lista os clientes cadastrados no sistema. |


---

4. Funcionalidades

4.1. Autenticação de Usuários

O sistema exige que o usuário faça login para acessar as funcionalidades. Há dois tipos de usuários:

Administrador: Gerencia produtos, categorias, vendas e usuários.

Atendente: Pode registrar vendas e consultar estoque.


4.2. Cadastro e Gerenciamento

4.2.1. Produtos

Os produtos podem ser adicionados, editados e removidos pelo administrador. Cada produto inclui:

Nome

Tipo (ex: vinho, cerveja, whisky)

Volume

Preço

Categoria


4.2.2. Categorias

Os produtos são organizados por categorias para facilitar a busca. O administrador pode criar, editar e excluir categorias.

4.2.3. Usuários

O administrador pode cadastrar novos usuários e definir suas permissões.

4.2.4. Clientes e Fornecedores

O sistema permite o registro de clientes e fornecedores para facilitar a gestão de compras e vendas.

4.3. Controle de Estoque

O atendente pode consultar o estoque e verificar a disponibilidade de produtos em tempo real.

4.4. Registro e Histórico de Vendas

Cada venda é registrada no sistema, permitindo:

Geração automática de recibos.

Consulta de vendas anteriores.

Relatórios de vendas filtrados por período.



---

5. Telas do Sistema

5.1. Tela de Login

Permite o acesso ao sistema mediante autenticação.


5.2. Menu do Administrador

Inclui opções para:

Cadastrar produtos

Gerenciar categorias

Gerenciar usuários

Consultar estoque

Acessar histórico de vendas


5.3. Menu do Atendente

Inclui funções de:

Registrar vendas

Consultar estoque

Emitir recibos



---

6. Tecnologias Utilizadas

Linguagem: C#

Framework: .NET

Interface: Windows Forms

Banco de Dados: LINQ to SQL


7. Como Executar o Projeto

1. Abra o Visual Studio.

2. Carregue o projeto (Garrafeira_1.csproj).

3. Certifique-se de que a conexão com o banco de dados está correta.

4. Compile e execute o programa.

8. Melhorias Futuras
Implementação de um dashboard com gráficos sobre vendas e estoque.
Integração com NFC-e para emissão de notas fiscais eletrônicas.
Suporte para vendas online e integração com pagamentos digitais.
