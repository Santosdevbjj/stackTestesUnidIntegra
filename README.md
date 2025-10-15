## Implementando sua Stack de Testes de Unidade e Integrados em um Projeto .NET de Crowdfunding.


<img width="1080" height="632" alt="Screenshot_20251015-113607" src="https://github.com/user-attachments/assets/1fe5eecd-33a2-4a70-a5b9-46918c6b55d0" />



---


**DESCRIÇÃO:**
Quer se sentir mais seguro nas entregas de suas aplicações? Aprenda a testar um projeto de crowdfunding (vaquinha online) desenvolvida em .Net Core com a arquitetura MVC. 

Você ira baixar uma aplicação completa feita pelo expert e a sua missão será implementar a parte de testes desta aplicação.

Veja na teoria e na prática os principais conceitos de testes para aumentar a qualidade de entrega de seus projetos com testes de unidade, integrados e TDD.


---


ggg# 🧪 Stack de Testes para Projeto .NET de Crowdfunding

[![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
[![C#](https://img.shields.io/badge/C%23-12.0-green)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![Build Status](https://github.com/Santosdevbjj/stackTestesUnidIntegra/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Santosdevbjj/stackTestesUnidIntegra/actions)
[![License](https://img.shields.io/badge/license-MIT-lightgrey)](LICENSE)

Este repositório implementa uma stack completa de testes para uma aplicação de crowdfunding (vaquinha online) desenvolvida com .NET 8 e C# 12, utilizando a arquitetura MVC. O objetivo é garantir qualidade, segurança e confiabilidade nas entregas com testes de unidade, integração e automatizados.

---

## 📚 Sobre o Projeto

Este projeto é baseado no repositório [dotnet-vaquinha-tests](https://github.com/elizarp/dotnet-vaquinha-tests), e foi expandido com uma estrutura profissional de testes. A aplicação simula uma plataforma de doações online, onde usuários podem contribuir com campanhas.

A stack de testes foi construída com foco em boas práticas de programação orientada a objetos, TDD (Test Driven Development), e automação via GitHub Actions.

---

## 🧰 Tecnologias Utilizadas

- **.NET 8 SDK**
- **C# 12**
- **xUnit** – Framework de testes
- **Moq** – Mocking de dependências
- **FluentAssertions** – Assertivas elegantes
- **Microsoft.AspNetCore.Mvc.Testing** – Testes de integração com WebApplicationFactory
- **GitHub Actions** – CI/CD automatizado
- **Coverlet** – Cobertura de código

---

## 🖥️ Requisitos

### 🔧 Software

| Item                     | Versão mínima |
|--------------------------|---------------|
| .NET SDK                 | 8.0           |
| Visual Studio / VS Code | 2022+         |
| SQL Server LocalDB       | 2019+         |
| Git                      | 2.30+         |

### 🖥️ Hardware

| Item         | Recomendado     |
|--------------|-----------------|
| CPU          | Intel i5+       |
| RAM          | 8 GB            |
| Armazenamento| SSD com 2 GB livres |
| SO           | Windows 10/11, macOS Ventura+, Ubuntu 22+ |

---

## 📦 Estrutura do Projeto

<img width="1080" height="1095" alt="Screenshot_20251015-114047" src="https://github.com/user-attachments/assets/6f6012a1-2d87-49ef-bd8c-ebedb2f6ca8f" />

---



## 🚀 Como Executar o Projeto

1. **Clone o repositório**
   ```bash
   git clone https://github.com/Santosdevbjj/stackTestesUnidIntegra.git
   cd stackTestesUnidIntegra

---


**2. Restaure os pacotes**
   `bash
   dotnet restore
   `

**3. Execute o projeto**
   `bash
   dotnet run --project src/VaquinhaOnline/VaquinhaOnline.csproj
   `

**4. Acesse no navegador**
   `
   http://localhost:5000
   `

---

🧪 **Como Executar os Testes**

✅ **Testes de Unidade**

`bash
dotnet test tests/VaquinhaOnline.UnitTests/VaquinhaOnline.UnitTests.csproj
`

🔗 **Testes de Integração**

`bash
dotnet test tests/VaquinhaOnline.IntegrationTests/VaquinhaOnline.IntegrationTests.csproj
`

🤖 **Testes Automatizados (CI/CD)**

Os testes são executados automaticamente via GitHub Actions a cada push ou pull request. Veja o status aqui.

---

🧠 **Arquitetura MVC**

- Model: Representa os dados e regras de negócio.
- View: Interface com o usuário.
- Controller: Gerencia as requisições e coordena as interações entre Model e View.

---

📚 **Testes Implementados**

**Testes de Unidade**
- DonationServiceTests: Valida regras de negócio.
- DonationRepositoryTests: Garante persistência correta.

**Testes de Integração**
- DonationControllerTests: Testa endpoints reais com banco em memória.

**Automatização**
- Pipeline CI/CD com GitHub Actions
- Cobertura de código com Coverlet (em breve)

---

🤝 **Contribuições**

Contribuições são bem-vindas! Siga os passos:

1. Fork o projeto
2. Crie uma branch: feature/sua-feature
3. Commit suas alterações
4. Envie um Pull Request

---

📄 **Licença**

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

---

📎 **Referências**

- Projeto base: dotnet-vaquinha-tests
- Documentação oficial .NET
- Documentação do xUnit
`

---
**Autor:** Sergio Santos 


---




