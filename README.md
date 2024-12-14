Resumo:

Foi utilizado o Visual Studio 2022 como solicitado para o desenvolvimento, sendo a arquitetura escolhida por mim a MVC, essa IDE atende perfeitamente para a aplicação C# em um projeto com arquitetura MVC e para API web, além da integração com o GIT. Foi usado o pacote Newtonsoft.Json para deserialização no consumo da API

Foi criado um repositório público para versionamento do código no GitHub, assim, mantendo sempre o código atualizado.
Foi utilizado HttpClient para consumir a API, formulário de busca para compor a url final que gera a pesquisa do endpoint como no exemplo da página recebida 
info.dengue.mat.br/services/api/doc#Consulta-em-formato-JSON e em seguida 
consumida com os parâmetros recebidos.

As tabelas Solicitantes e Registros foram criadas separadas.
API criada de maneira pública, com acesso facilitado, apenas nome e cpf como 
uma ferramenta de utilidade pública.
