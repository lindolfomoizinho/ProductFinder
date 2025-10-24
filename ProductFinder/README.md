
-----

# ProductFinder

Este é um projeto Blazor Server (ASP.NET) configurado para rodar com um banco de dados MongoDB. O ambiente de desenvolvimento é totalmente gerenciado pelo Docker e Docker Compose, com comandos de conveniência disponíveis através de um `Makefile`.

## Pré-requisitos

Para rodar este projeto, você precisará ter instalado em sua máquina:

1.  **Docker** e **Docker Compose**
2.  **`make`** (Geralmente nativo no Linux/macOS. No Windows, pode ser usado via [Git Bash](https://git-scm.com/downloads), [WSL](https://learn.microsoft.com/pt-br/windows/wsl/install) ou [chocolatey](https://www.google.com/search?q=https://chocolatey.org/packages/make)).

## Como Rodar o Projeto

Este projeto utiliza um `Makefile` para simplificar os comandos do Docker Compose. Abra um terminal na raiz do projeto e execute os seguintes comandos:

### 1\. Iniciar o Ambiente (Comando Principal)

Este comando irá construir a imagem da aplicação .NET (baseado no `Dockerfile`) e iniciar os contêineres da aplicação e do banco de dados.

```bash
make up
```

(Se você executar apenas `make`, este é o comando padrão que será executado).

### 2\. Parar o Ambiente

Este comando irá parar e **remover** os contêineres, mas **manterá** os dados do seu banco de dados (armazenados no volume do Docker).

```bash
make down
```

### 3\. Apenas Parar (Pausar)

Se você quiser apenas parar os contêineres sem removê-los (para iniciá-los novamente mais rápido), use:

```bash
make stop
```

### 4\. Ver os Logs

Para monitorar os logs de ambos os contêineres (aplicação e banco de dados) em tempo real:

```bash
make logs
```

Pressione `Ctrl+C` para sair dos logs.

### 5\. Limpeza Total (Reset)

Este comando irá parar e remover os contêineres E **apagar o volume do banco de dados**.

**\!\! CUIDADO: ISSO APAGARÁ TODOS OS DADOS DO SEU MONGODB DE DESENVOLVIMENTO \!\!**

```bash
make clean
```

-----

## Acessando a Aplicação

Após rodar `make up`, os serviços estarão disponíveis nos seguintes endereços:

* **Aplicação Blazor (HTTP):** [http://localhost:8080](https://www.google.com/search?q=http://localhost:8080)
* **Aplicação Blazor (HTTPS):** [https://localhost:8081](https://www.google.com/search?q=https://localhost:8081)
* **Banco de Dados MongoDB:**
    * **Host:** `localhost:27017`
    * **String de Conexão:** `mongodb://<seu_usuario>:<sua_senha>@localhost:27017`
    * (Você pode usar esta string para se conectar a um cliente de banco de dados como o [MongoDB Compass](https://www.mongodb.com/products/compass)).