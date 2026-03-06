# Hypesoft Challenge — Sistema de Gestão de Produtos

## Sobre o Projeto
Sistema de gestão de produtos desenvolvido como desafio técnico da Hypesoft. A aplicação permite criar, listar, editar e excluir produtos e categorias, com controle de estoque integrado.
O foco do desenvolvimento foi demonstrar conhecimento em arquitetura de software moderna, aplicando princípios de Clean Architecture, DDD e CQRS no backend.

## Tecnologias Utilizadas

.NET 10 com C#
Clean Architecture — separação em camadas Domain, Application, Infrastructure e API
DDD (Domain-Driven Design) — modelagem orientada ao domínio de negócio
CQRS com MediatR — separação de comandos e consultas
InMemory Repository — persistência em memória para demonstração da arquitetura
Docker + Docker Compose — containerização da aplicação


## Como Executar
### Pré-requisitos

- Docker Desktop instalado e rodando

### Execução
```bash
# Clone o repositório
git clone https://github.com/edvxndxvi/desafio1.git
cd hypesoft-challenge

# Suba a aplicação
docker-compose up --build
```
A API estará disponível em: http://localhost:5000

### Desenvolvimento local
```bash
cd backend/src/Hypesoft.API
dotnet run
```
A API estará disponível em: http://localhost:5115

## Endpoints da API

### Produtos

| Método | Endpoint | Descrição |
|--------|----------|-----------|
| GET | `/api/products` | Lista todos os produtos |
| GET | `/api/products/{id}` | Busca produto por ID |
| POST | `/api/products` | Cria um novo produto |
| PUT | `/api/products/{id}` | Atualiza um produto |
| DELETE | `/api/products/{id}` | Remove um produto |

**Exemplo de criação de produto:**
```json
{
  "name": "Notebook Gamer",
  "description": "Notebook com RTX 4060",
  "price": 4999.99,
  "categoryId": "id-da-categoria",
  "stockQuantity": 10
}
```

### Categorias

| Método | Endpoint | Descrição |
|--------|----------|-----------|
| GET | `/api/categories` | Lista todas as categorias |
| GET | `/api/categories/{id}` | Busca categoria por ID |
| POST | `/api/categories` | Cria uma nova categoria |
| PUT | `/api/categories/{id}` | Atualiza uma categoria |
| DELETE | `/api/categories/{id}` | Remove uma categoria |

**Exemplo de criação de categoria:**
```json
{
  "name": "Eletrônicos"
}
```

## Arquitetura
O projeto segue Clean Architecture com 4 camadas bem definidas:
```
Hypesoft.Domain          # Entidades e interfaces — núcleo da aplicação
Hypesoft.Application     # Commands, Queries e Handlers (CQRS + MediatR)
Hypesoft.Infrastructure  # Implementação dos repositórios
Hypesoft.API             # Controllers e configuração da aplicação
```

## Fluxo de uma requisição
```
Controller → MediatR → Handler → Repository → Retorno
```
O Controller não contém lógica de negócio — apenas recebe a requisição HTTP e delega ao MediatR, que encontra o Handler responsável.

## Decisões Técnicas

**Por que InMemory Repository?**
Com o prazo disponível, optar por persistência em memória permitiu focar na demonstração da arquitetura sem perder tempo com configuração de banco de dados. A troca para MongoDB ou outro banco exigiria apenas a implementação de novos repositórios, sem alterar nenhuma outra camada — o que demonstra o valor da arquitetura adotada.

## O que não foi implementado e por quê

Sem muita experiência em C#, optei por utilizar o período do desafio para estudar a linguagem a partir da minha base em Java e foquei na entrega da API para demonstrar na prática os conceitos de Clean Architecture, CQRS e DDD. Funcionalidades como frontend, autenticação com Keycloak, MongoDB e testes automatizados não foram implementadas pois a decisão foi priorizar uma base arquitetural sólida em vez de quantidade de entregas sem qualidade.
