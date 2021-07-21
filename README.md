# DFS - Módulo 1
Repositório referente a implementação das rotas PUT, POST, DELETE e GET.

#### Configuração de máquina
  Para executar o projeto, deve-se ter instalado os seguintes itens:
  
  -[.Net 5.0 SDK](https://dotnet.microsoft.com/download/visual-studio-sdks)
  
  -[Postman](https://www.postman.com/downloads/)
  
  -[Visual Studio Code](https://code.visualstudio.com/download) ou [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/downloads/)
  
#### Extensões para o Visual Studio

  - [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
  - [Code Runner](https://marketplace.visualstudio.com/items?itemName=formulahendry.code-runner) 

#### Executando o projeto
  Para executar, basta abrir o terminal de sua IDE ou do SO, tendo a certeza de estar no díretório do projeto, e executar o comando 'dotnet run'. Podendo parar a execução a qualquer momento, pressionando 'Ctrl + C'. No Postman, as rotas podem ser testadas na aba "Requests" de sua Workspace, considerando  que os métodos PUT, POST, DELETE ou GET, devem estar selecionados e recebendo o endereço https://localhost:5001/api/Category como argumento. OBS: Ter certeza de desativar a verficação SSL para os testes pois esta pode interferir na execução, o Postman deve exibir essa recomendação no campo de resultados.
