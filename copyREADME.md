# 🏪 Software Lojas Ribeiro

Sistema de gerenciamento comercial completo desenvolvido em C# Windows Forms com integração ao MySQL.

## 📋 Descrição

Sistema desktop para gestão de lojas, incluindo controle de estoque, vendas, compras, clientes, fornecedores e pagamentos. Desenvolvido com .NET Framework 4.7.2 e Entity Framework para persistência de dados.

## ✨ Funcionalidades

- 🔐 **Sistema de Login** - Autenticação de usuários com criptografia BCrypt
- 👥 **Gestão de Clientes** - Cadastro e gerenciamento completo de clientes
- 📦 **Gestão de Produtos** - Controle de estoque e categorias
- 🏭 **Gestão de Fornecedores** - Cadastro e controle de fornecedores
- 🛒 **Sistema de Vendas** - Registro de vendas e controle de devedores
- 📥 **Sistema de Compras** - Registro de compras de produtos
- 💰 **Controle de Pagamentos** - Gestão financeira e fluxo de caixa
- 👨‍💼 **Gestão de Funcionários** - Cadastro e controle de funcionários

## 🚀 Como Executar

### Pré-requisitos

- Windows 10 ou superior
- .NET Framework 4.7.2 ou superior
- MySQL Server
- Visual Studio 2022 (recomendado) ou MSBuild

### ⚡ Execução Rápida (Um Comando)

Basta executar o script PowerShell que faz tudo automaticamente:

```powershell
.\build-and-run.ps1
```

**Este script irá:**
1. ✅ Baixar o NuGet (se necessário)
2. ✅ Restaurar todas as dependências
3. ✅ Compilar o projeto
4. ✅ Executar a aplicação

### Opção 2: Execução Manual

1. **Clone o repositório:**
```bash
git clone <url-do-repositorio>
cd lojinha
```

2. **Restaure os pacotes NuGet:**
```powershell
# Baixar nuget.exe (se não tiver)
Invoke-WebRequest -Uri "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe" -OutFile "nuget.exe"

# Restaurar pacotes
.\nuget.exe restore SoftwareLojasRibeiro.sln
```

3. **Compile o projeto:**
```powershell
# Com MSBuild do Visual Studio
& "C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\MSBuild.exe" SoftwareLojasRibeiro\SoftwareLojasRibeiro.csproj /p:Configuration=Debug

# Ou com dotnet (pode ter problemas com projetos .NET Framework)
dotnet build SoftwareLojasRibeiro\SoftwareLojasRibeiro.csproj
```

4. **Execute a aplicação:**
```powershell
.\SoftwareLojasRibeiro\bin\Debug\SoftwareLojasRibeiro.exe
```

## 🗄️ Configuração do Banco de Dados

1. Certifique-se de que o MySQL Server está instalado e em execução

2. Execute o script SQL localizado em:
   ```
   SoftwareLojasRibeiro\create_database_dblojasribeiro.sql
   ```

3. Configure a string de conexão no arquivo `App.config` ou nas classes de conexão conforme necessário

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# (.NET Framework 4.7.2)
- **Interface:** Windows Forms
- **Banco de Dados:** MySQL
- **ORM:** Entity Framework 6.5.1 / Entity Framework Core 3.1.1
- **Segurança:** BCrypt.Net para criptografia de senhas
- **Gerenciamento de Dependências:** NuGet

## 📦 Principais Dependências

- Entity Framework 6.5.1
- MySql.Data 9.2.0
- BCrypt.Net-Next 4.0.3
- Microsoft.EntityFrameworkCore 3.1.1
- Google.Protobuf 3.26.1
- System.Configuration.ConfigurationManager 8.0.0

## 📁 Estrutura do Projeto

```
SoftwareLojasRibeiro/
├── br.com.project.CONNECTION/  # Conexão com banco de dados
├── br.com.project.DAO/         # Data Access Objects
├── br.com.project.MODEL/       # Modelos de dados
├── br.com.project.VIEW/        # Interfaces gráficas (Forms)
│   ├── FormLogin.cs           # Tela de login
│   ├── FormMenu.cs            # Menu principal
│   ├── FormClientes.cs        # Gestão de clientes
│   ├── FormProdutos.cs        # Gestão de produtos
│   ├── FormVendas.cs          # Sistema de vendas
│   ├── FormCompras.cs         # Sistema de compras
│   └── ...
└── create_database_dblojasribeiro.sql
```

## 🔧 Possíveis Problemas e Soluções

### Erro ao compilar
- **Solução:** Certifique-se de que o Visual Studio 2022 está instalado
- **Solução:** Verifique se o .NET Framework 4.7.2 está instalado
- **Solução:** Execute o script `build-and-run.ps1` que resolve automaticamente

### Erro de conexão com MySQL
- **Solução:** Verifique se o MySQL Server está rodando
- **Solução:** Confirme as credenciais de conexão no arquivo de configuração
- **Solução:** Execute o script SQL de criação do banco de dados

### Pacotes NuGet não encontrados
- **Solução:** Execute o script `build-and-run.ps1` que restaura automaticamente
- **Solução:** Ou execute manualmente: `.\nuget.exe restore SoftwareLojasRibeiro.sln`

### Script PowerShell não executa
- **Solução:** Execute o PowerShell como Administrador
- **Solução:** Execute: `Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser`

## 📸 Screenshots

*Em desenvolvimento - Screenshots serão adicionados em breve*

## 🎯 Melhorias Futuras

- [ ] Implementar relatórios em PDF
- [ ] Adicionar gráficos de vendas
- [ ] Sistema de backup automático
- [ ] Integração com API de nota fiscal
- [ ] Aplicação mobile complementar

## 👨‍💻 Autor

Desenvolvido como projeto de portfólio

## 📄 Licença

Este projeto é de código aberto e está disponível para fins educacionais e de demonstração.

---

⭐ Se este projeto foi útil para você, considere dar uma estrela!

## 💡 Dica

Para uma melhor experiência, abra o projeto diretamente no Visual Studio 2022 e pressione F5 para executar em modo debug.
