# CP01-2TDSPJ.NET-jogos

Projeto CP1 + CP2 - Modelagem MER e Persistência com EF Core

## Integrantes
Felipe Augusto Lopes Ferreira — RM563982  
Kaique Mascarenhas dos Santos — RM565802  

## Domínio
Biblioteca de Jogos  
Sistema para gerenciamento de jogos, usuários e suas bibliotecas, incluindo controle de gêneros, desenvolvedoras, publishers e conquistas.

## Arquitetura
O projeto segue os princípios de Clean Architecture, dividido em camadas:  
Domain → Entidades do sistema  
Application → Interfaces (contratos de repositório)  
Infrastructure → Persistência com Entity Framework Core  
API → Configuração, execução e exposição da aplicação  

## Entidades Modeladas
Usuário  
Biblioteca  
Jogo  
Gênero  
Desenvolvedora  
Publisher  
Conquista  

## Relacionamentos
Usuário (1) → (N) Biblioteca  
Um usuário pode possuir vários jogos na sua biblioteca  

Biblioteca (N) → (1) Jogo  
Cada registro representa um jogo específico  

Jogo (N) → (1) Gênero  
Um jogo pertence a um gênero  

Jogo (N) → (1) Desenvolvedora  
Um jogo é desenvolvido por uma desenvolvedora  

Jogo (N) → (1) Publisher  
Um jogo possui uma publisher  

Jogo (1) → (N) Conquista  
Um jogo pode possuir várias conquistas  

## Persistência de Dados (CP2)

### Tecnologias
.NET 9  
Entity Framework Core  
SQL Server (LocalDB)  

### DbContext
Implementado na camada Infrastructure:  
AppDbContext  

DbSets:  
Usuarios  
Jogos  
Bibliotecas  
Generos  
Desenvolvedoras  
Publishers  
Conquistas  

### Mapeamento (Fluent API)
Implementação com IEntityTypeConfiguration<T>  

Configuração de:  
Chaves primárias (PK)  
Chaves estrangeiras (FK)  
Relacionamentos (1:N e N:N)  
Restrições e propriedades obrigatórias  

### Repositórios

Interfaces (Application):  
IUsuarioRepository  
IJogoRepository  
IBibliotecaRepository  

Implementações (Infrastructure):  
UsuarioRepository  
JogoRepository  
BibliotecaRepository  

### Injeção de Dependência
Configurada no Program.cs:  
AddDbContext  
Registro dos repositórios  

### Migrations
Migration criada: InitialCreate  
Banco gerado automaticamente via EF Core  

### Banco de Dados
Nome: BibliotecaJogos  
Provider: SQL Server  
Execução validada via SQL Server Management Studio (SSMS)  

## Como Executar o Projeto

1️⃣ Clonar o repositório  
git clone <URL_DO_REPOSITORIO>  

2️⃣ Acessar a pasta da API  
cd src/Projeto.Api/Projeto.Api  

3️⃣ Restaurar pacotes  
dotnet restore  

4️⃣ Executar migrations  
dotnet ef database update --project ../Projeto.Infrastructure --startup-project .  

5️⃣ Rodar a aplicação  
dotnet run  

## Configuração

Arquivo appsettings.json:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BibliotecaJogos;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}

## Evidências
Pasta /docs contém:  
Print das tabelas do banco  
Estrutura das entidades  
(Opcional) Diagrama do banco  

## Status do Projeto
✔ Projeto compila sem erros  
✔ DbContext implementado  
✔ Mapeamentos completos  
✔ Relacionamentos configurados  
✔ Migration criada e aplicada  
✔ Banco de dados funcional  
✔ Repositórios implementados  
✔ Injeção de dependência configurada  

## Observações
Nenhuma credencial sensível foi versionada  
Foco do projeto: persistência, mapeamento e organização em camadas

## MER

![MER](mer.pdf)
