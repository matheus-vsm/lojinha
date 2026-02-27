-- ========================================
-- Script de Criação do Banco de Dados
-- Sistema: Software Lojas Ribeiro
-- Database: dblojasribeiro
-- ========================================

-- Criar o banco de dados se não existir
CREATE DATABASE IF NOT EXISTS dblojasribeiro
CHARACTER SET utf8mb4
COLLATE utf8mb4_general_ci;

-- Selecionar o banco de dados
USE dblojasribeiro;

-- ========================================
-- Tabela: Cliente
-- Descrição: Armazena dados dos clientes
-- ========================================
CREATE TABLE IF NOT EXISTS Cliente (
    Id VARCHAR(50) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Rg VARCHAR(20),
    Cpf VARCHAR(14) UNIQUE,
    Email VARCHAR(100),
    Numero VARCHAR(20),
    Datanasc DATE,
    Endereco VARCHAR(255),
    Cep VARCHAR(10),
    Status BOOLEAN DEFAULT TRUE,
    INDEX idx_cpf (Cpf),
    INDEX idx_nome (Nome)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: Funcionario
-- Descrição: Herda de Cliente, adiciona credenciais
-- ========================================
CREATE TABLE IF NOT EXISTS Funcionario (
    Id VARCHAR(50) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Rg VARCHAR(20),
    Cpf VARCHAR(14) UNIQUE,
    Email VARCHAR(100),
    Numero VARCHAR(20),
    Datanasc DATE,
    Endereco VARCHAR(255),
    Cep VARCHAR(10),
    Status BOOLEAN DEFAULT TRUE,
    Login VARCHAR(50) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    Tipo VARCHAR(20) NOT NULL,
    INDEX idx_login (Login),
    INDEX idx_tipo (Tipo)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: Categoria
-- Descrição: Categorias de produtos
-- ========================================
CREATE TABLE IF NOT EXISTS Categoria (
    Id VARCHAR(50) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Descricao TEXT,
    Status BOOLEAN DEFAULT TRUE,
    INDEX idx_nome (Nome)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: Fornecedor
-- Descrição: Dados dos fornecedores
-- ========================================
CREATE TABLE IF NOT EXISTS Fornecedor (
    Id VARCHAR(50) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Cnpj VARCHAR(18) UNIQUE,
    Email VARCHAR(100),
    Telefone VARCHAR(20),
    Celular VARCHAR(20),
    Cep VARCHAR(10),
    Endereco VARCHAR(255),
    Status BOOLEAN DEFAULT TRUE,
    INDEX idx_cnpj (Cnpj),
    INDEX idx_nome (Nome)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: Produto
-- Descrição: Catálogo de produtos
-- ========================================
CREATE TABLE IF NOT EXISTS Produto (
    Id VARCHAR(50) PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Marca VARCHAR(50),
    Cor VARCHAR(30),
    Tamanho VARCHAR(20),
    Descricao TEXT,
    Preco_Venda DECIMAL(10, 2) NOT NULL DEFAULT 0.00,
    Preco_Medio DECIMAL(10, 2) NOT NULL DEFAULT 0.00,
    Estoque INT NOT NULL DEFAULT 0,
    Id_Cat_Prod INT,
    Id_Cat_Pub INT,
    Status BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (Id_Cat_Prod) REFERENCES Categoria(Id) ON DELETE SET NULL,
    INDEX idx_nome (Nome),
    INDEX idx_marca (Marca),
    INDEX idx_estoque (Estoque)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: Venda
-- Descrição: Registro de vendas realizadas
-- ========================================
CREATE TABLE IF NOT EXISTS Venda (
    Id VARCHAR(50) PRIMARY KEY,
    Id_Cliente VARCHAR(50),
    Data_Venda DATETIME NOT NULL,
    Total_Venda DOUBLE NOT NULL DEFAULT 0.00,
    Desconto DOUBLE DEFAULT 0.00,
    Valor_Pago DOUBLE DEFAULT 0.00,
    Status VARCHAR(20) NOT NULL,
    Observacoes TEXT,
    FOREIGN KEY (Id_Cliente) REFERENCES Cliente(Id) ON DELETE SET NULL,
    INDEX idx_data_venda (Data_Venda),
    INDEX idx_status (Status),
    INDEX idx_cliente (Id_Cliente)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: ItensVenda
-- Descrição: Itens de cada venda
-- ========================================
CREATE TABLE IF NOT EXISTS ItensVenda (
    Id VARCHAR(50) PRIMARY KEY,
    Id_Venda VARCHAR(50) NOT NULL,
    Id_Produto VARCHAR(50) NOT NULL,
    Quantidade INT NOT NULL DEFAULT 1,
    Preco_Unitario DOUBLE NOT NULL,
    Subtotal DOUBLE NOT NULL,
    FOREIGN KEY (Id_Venda) REFERENCES Venda(Id) ON DELETE CASCADE,
    FOREIGN KEY (Id_Produto) REFERENCES Produto(Id) ON DELETE CASCADE,
    INDEX idx_venda (Id_Venda),
    INDEX idx_produto (Id_Produto)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: Pagamento
-- Descrição: Formas de pagamento das vendas
-- ========================================
CREATE TABLE IF NOT EXISTS Pagamento (
    Id VARCHAR(50) PRIMARY KEY,
    Id_Venda VARCHAR(50) NOT NULL,
    Forma_Pagamento VARCHAR(50) NOT NULL,
    Valor_Pago DOUBLE NOT NULL,
    FOREIGN KEY (Id_Venda) REFERENCES Venda(Id) ON DELETE CASCADE,
    INDEX idx_venda (Id_Venda)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: CompraProdutos
-- Descrição: Registro de compras de fornecedores
-- ========================================
CREATE TABLE IF NOT EXISTS CompraProdutos (
    Id VARCHAR(50) PRIMARY KEY,
    Data_Compra DATETIME NOT NULL,
    Total_Compra DOUBLE NOT NULL DEFAULT 0.00,
    Observacoes TEXT,
    INDEX idx_data_compra (Data_Compra)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: ItensCompraProdutos
-- Descrição: Itens de cada compra
-- ========================================
CREATE TABLE IF NOT EXISTS ItensCompraProdutos (
    Id VARCHAR(50) PRIMARY KEY,
    Id_Compra VARCHAR(50) NOT NULL,
    Id_Fornecedor VARCHAR(50),
    Nome_Produto VARCHAR(100) NOT NULL,
    Marca VARCHAR(50),
    Cor VARCHAR(30),
    Tamanho VARCHAR(20),
    Descricao TEXT,
    Quantidade INT NOT NULL DEFAULT 1,
    Id_Cat_Prod INT,
    Id_Cat_Publ INT,
    Preco_Custo DECIMAL(10, 2) NOT NULL,
    Preco_Medio DECIMAL(10, 2) NOT NULL,
    Subtotal DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (Id_Compra) REFERENCES CompraProdutos(Id) ON DELETE CASCADE,
    FOREIGN KEY (Id_Fornecedor) REFERENCES Fornecedor(Id) ON DELETE SET NULL,
    INDEX idx_compra (Id_Compra),
    INDEX idx_fornecedor (Id_Fornecedor)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- Tabela: Devedores
-- Descrição: Controle de dívidas de clientes
-- ========================================
CREATE TABLE IF NOT EXISTS Devedores (
    Id VARCHAR(50) PRIMARY KEY,
    Id_Cliente VARCHAR(50) NOT NULL,
    Id_Venda VARCHAR(50),
    Divida_Inicial DOUBLE NOT NULL,
    Divida_Atual DOUBLE NOT NULL,
    Data_Inicio DATETIME NOT NULL,
    Data_Atualizacao DATETIME NOT NULL,
    Data_Fim DATETIME NULL,
    Status BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (Id_Cliente) REFERENCES Cliente(Id) ON DELETE CASCADE,
    FOREIGN KEY (Id_Venda) REFERENCES Venda(Id) ON DELETE SET NULL,
    INDEX idx_cliente (Id_Cliente),
    INDEX idx_status (Status),
    INDEX idx_data_inicio (Data_Inicio)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- ========================================
-- DADOS INICIAIS
-- ========================================

-- Inserir Funcionário Administrador
INSERT INTO Funcionario (
    Id,
    Nome,
    Rg,
    Cpf,
    Email,
    Numero,
    Datanasc,
    Endereco,
    Cep,
    Status,
    Login,
    Senha,
    Tipo
) VALUES (
    '1',
    'Administrador do Sistema',
    '',
    '',
    'admin@lojasribeiro.com.br',
    '',
    '1990-01-01',
    '',
    '',
    TRUE,
    'Administrador',
    'SenhaAdministrador@123@',
    'ADMIN'
);

-- ========================================
-- FIM DO SCRIPT
-- ========================================

SELECT 'Banco de dados criado com sucesso!' AS Status;
SELECT 'Usuário Administrador criado:' AS Info;
SELECT Login, Tipo FROM Funcionario WHERE Tipo = 'ADMIN';
