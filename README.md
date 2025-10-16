## Implementando sua Stack de Testes de Unidade e Integrados em um Projeto .NET de Crowdfunding.


<img width="1080" height="632" alt="Screenshot_20251015-113607" src="https://github.com/user-attachments/assets/1fe5eecd-33a2-4a70-a5b9-46918c6b55d0" />



---

**DESCRIÇÃO:**
Quer se sentir mais seguro nas entregas de suas aplicações? Aprenda a testar um projeto de crowdfunding (vaquinha online) desenvolvida em .Net Core com a arquitetura MVC. 

Você ira baixar uma aplicação completa feita pelo expert e a sua missão será implementar a parte de testes desta aplicação.

Veja na teoria e na prática os principais conceitos de testes para aumentar a qualidade de entrega de seus projetos com testes de unidade, integrados e TDD.


---

# 🧪 Stack de Testes Automatizados para Projeto ASP.NET Core

[![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[![C#](https://img.shields.io/badge/C%23-12.0-green)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Build Status](https://github.com/Santosdevbjj/stackTestesUnidIntegra/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Santosdevbjj/stackTestesUnidIntegra/actions)
[![License](https://img.shields.io/badge/license-MIT-lightgrey)](LICENSE)

Este repositório implementa uma stack completa de testes para uma aplicação ASP.NET Core MVC de crowdfunding. O foco é garantir qualidade e confiabilidade com testes de unidade, integração, cobertura de código e validação de estilo, tudo automatizado via GitHub Actions.

---

## 📚 Sobre o Projeto

A aplicação simula uma plataforma de vaquinha online, permitindo que usuários façam doações. O projeto está estruturado em camadas (MVC + Services + Repositories) e utiliza boas práticas de TDD, DI e CI/CD.

---

## 🧰 Tecnologias Utilizadas

- **.NET 8 SDK**
- **C# 12**
- **ASP.NET Core MVC**
- **xUnit** – Framework de testes
- **Moq** – Mocking de dependências
- **FluentAssertions** – Assertivas elegantes
- **Coverlet** – Cobertura de código
- **ReportGenerator** – Relatórios HTML
- **GitHub Actions** – CI/CD automatizado
- **dotnet format** – Validação de estilo
- **SonarCloud** – Análise contínua de qualidade e segurança

---

## 🖥️ Requisitos

### 🔧 Software

| Item                     | Versão mínima |
|--------------------------|---------------|
| .NET SDK                 | 8.0           |
| Visual Studio / VS Code | 2022+         |
| Git                      | 2.30+         |
| SQL Server LocalDB       | 2019+         |

### 🖥️ Hardware

| Item         | Recomendado     |
|--------------|-----------------|
| CPU          | Intel i5+       |
| RAM          | 8 GB            |
| Armazenamento| SSD com 2 GB livres |
| SO           | Windows 10/11, macOS Ventura+, Ubuntu 22+ |

---

## 📦 Estrutura do Projeto


<img width="1080" height="1938" alt="Screenshot_20251016-002628" src="https://github.com/user-attachments/assets/4f056f68-ea00-48b5-96e9-0e1eaf1da2b2" />

---


## 📁 Explicação dos Arquivos

### 🔧 `.github/workflows/dotnet.yml`
Pipeline CI/CD que compila, testa, valida estilo, gera cobertura e publica relatórios automaticamente.

### 🔧 `src/VaquinhaOnline/Program.cs`
Ponto de entrada da aplicação web. Configura serviços e middleware.

### 🔧 `src/VaquinhaOnline/Startup.cs`
Configuração de serviços e rotas. Necessário para testes de integração com `WebApplicationFactory<Startup>`.

### 🔧 `src/VaquinhaOnline/Controllers/`
Controllers MVC que recebem requisições e interagem com os serviços.

### 🔧 `src/VaquinhaOnline/Models/Donation.cs`
Modelo de dados da doação.

### 🔧 `src/VaquinhaOnline/Repositories/`
Contém `IDonationRepository` e `DonationRepository`, responsáveis por persistência.

### 🔧 `src/VaquinhaOnline/Services/`
Contém `IDonationService` e `DonationService`, responsáveis pela lógica de negócio.

### 🧪 `tests/VaquinhaOnline.UnitTests/`
Testes de unidade para serviços e repositórios. Usa xUnit, Moq e FluentAssertions.

### 🔗 `tests/VaquinhaOnline.IntegrationTests/`
Testes de integração para controllers. Usa `WebApplicationFactory` e `HttpClient`.

### 📄 `sonar-project.properties`
Configura análise de qualidade e cobertura com SonarCloud.

### 📄 `.editorconfig`
Define estilo de código para `dotnet format`.

### 📄 `stackTestesUnidIntegra.sln`
Solução que agrupa todos os projetos para build e testes.

---

## 🚀 Como Executar o Projeto

```bash
git clone https://github.com/Santosdevbjj/stackTestesUnidIntegra.git
cd stackTestesUnidIntegra
dotnet restore
dotnet build
dotnet run --project src/VaquinhaOnline/VaquinhaOnline.csproj

```

**Acesse:** http://localhost:5000

---

🧪 **Como Executar os Testes**

`bash
dotnet test tests/VaquinhaOnline.UnitTests/VaquinhaOnline.UnitTests.csproj --collect:"XPlat Code Coverage"
dotnet test tests/VaquinhaOnline.IntegrationTests/VaquinhaOnline.IntegrationTests.csproj --collect:"XPlat Code Coverage"
`

Relatório gerado em coverage-report/

---

🤝 **Contribuições**

1. Fork o projeto
2. Crie uma branch: feature/sua-feature
3. Commit suas alterações
4. Envie um Pull Request

---

📄 **Licença**

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.
`




---
**Autor:** Sergio Santos 


---




