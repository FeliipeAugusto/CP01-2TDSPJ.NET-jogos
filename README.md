# CP01-2TDSPJ.NET-jogos
Projeto CP1 - Modelagem MER e estrutura WebAPI em .NET

## Integrantes
Felipe Augusto Lopes Ferreira RM563982
Kaique Mascarenhas dos Santos RM565802

## Domínio
Biblioteca de Jogos

## Entidades Modeladas

- Usuário
- Biblioteca
- Jogo
- Gênero
- Desenvolvedora
- Publisher
- Conquista

## Relacionamentos

Usuário (1) -> (N) Biblioteca  
Um usuário pode possuir vários jogos na sua biblioteca.

Biblioteca (N) -> (1) Jogo  
Cada registro da biblioteca representa um jogo específico.

Jogo (N) -> (1) Gênero  
Um jogo pertence a um gênero.

Jogo (N) -> (1) Desenvolvedora  
Um jogo é desenvolvido por uma desenvolvedora.

Jogo (N) -> (1) Publisher  
Um jogo possui uma publisher.

Jogo (1) -> (N) Conquista  
Um jogo pode possuir várias conquistas.

## MER

![MER](mer.png)
