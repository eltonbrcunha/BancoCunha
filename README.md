# BancoCunha


<h2>Apresentação  :speech_balloon:	</h2> 
Aplicação em .Net Core, para simular o funcionamento básico de um banco, com cadastro de correntista e funcionalidades de transferência de saldo, a ideia do projeto veio como forma de aplicar
os conceitos de REST, e aliar o conhecimento de TSQL para verificar o funcionamento das expressões em Lambda.

Seguindo os moldes de padrões de projetos.


<h2>Instruções de Uso :blue_book:	</h2>
A primeira Tela há a opção de cadastrar um novo correntista, sendo que para validar o acesso o sistema utiliza agência e conta, a agência é padrão 0001 e a conta é feita com base nos 
5 primeiros números do documento informado, por se tratar de uma aplicação não comercial, optei por não fazer validações de dados inseridos.
</br>

![alt text](https://github.com/eltonbrcunha/BancoCunha/blob/main/img/001.jpg)

<h2>Acesso ao banco</h2>
Ao informar os dados da conta, é feita a verificação do correntista e o saldo disponível para transações, que no caso por padrão é R$1000,00 
</br>

![alt text](https://github.com/eltonbrcunha/BancoCunha/blob/main/img/002.jpg)

<h2>Transferência Bancária</h2>
A Transferência é feita também informando os dados de agência e conta de outro correntista, haja vista que o sistema valida se a conta informada é válida, justamente para o processo
de [DÉBITO X CRÉDITO] ocorra.
A transação é feita via <strong>trigger</strong>, para aumento e redução do saldo dos correntistas.
</br>

![alt text](https://github.com/eltonbrcunha/BancoCunha/blob/main/img/003.jpg)


<h2>Observações</h2>
A abstração do banco de dados se encontra na tabela <strong>Models</strong>, onde as tabelas a serem replicadas para o banco destino se encontram lá, em anexo também está um script 
adicional para reprodução do banco completo, com <strong>triggers e procedures </strong>

<h2>Sobre a Tecnologia usada</h2>
:white_check_mark: <strong>Plataforma: ASP.NET Core </strong> </br>
:white_check_mark: <strong>Banco de Dados: Mysql Server 8.0 </strong> </br>

<h2>Conceitos Usados</h2>
- <strong>Padrão REST</strong> </br>
- Arquitetura SOLID </br>
- Design Patterns </br>

<h2>Atualizações</h2>
[20/09/2021] Update003
- Adição de API para envio de email </br>
- Atualização de layout para adaptação de imagens e labels </br>
- Aplicação de Clean Code para melhorar a legibilidade do código. </br>


<h2>Melhorias a serem feitas</h2>
:exclamation: Adicionar formas de pagamentos, como forma de fazer a movimentação do saldo bancário </br>
:exclamation: Apresentar a confirmação dos dados da conta de destino antes da transferência </br>
:exclamation: Solicitar a confirmação via PIN da transferência bancária</br>

<h2> Desenvolvedor :technologist:</h2>
Elto Brito
Linkedin: (https://www.linkedin.com/in/elton-cunha-87631056)
