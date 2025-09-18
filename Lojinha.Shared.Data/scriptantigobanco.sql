-- Criação do banco
CREATE DATABASE IF NOT EXISTS dblojasribeiro
  DEFAULT CHARACTER SET utf8mb4
  COLLATE utf8mb4_0900_ai_ci;

USE dblojasribeiro;

-- Tabela: Categorias de Produto
CREATE TABLE tb_categoria_produto (
  Id_Categoria_Prod INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(100) NOT NULL,
  Descricao VARCHAR(255),
  Data_Cadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  Status TINYINT(1) DEFAULT 1,
  KEY Idx_Nome (Nome)
);

-- Tabela: Categorias de Público
CREATE TABLE tb_categoria_publico (
  Id_Categoria_Pub INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(100) NOT NULL,
  Descricao VARCHAR(255),
  Data_Cadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  Status TINYINT(1) DEFAULT 1,
  KEY Idx_Nome (Nome)
);

-- Tabela: Clientes
CREATE TABLE tb_clientes (
  Id_Cliente INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(100) NOT NULL,
  Rg VARCHAR(20) NOT NULL UNIQUE,
  Cpf VARCHAR(20) NOT NULL UNIQUE,
  Email VARCHAR(100) NOT NULL UNIQUE,
  Numero VARCHAR(20) NOT NULL,
  Datanasc DATE,
  Endereco VARCHAR(100),
  Cep VARCHAR(20),
  Status TINYINT(1) DEFAULT 1,
  KEY Idx_Nome (Nome)
);

-- Tabela: Compras
CREATE TABLE tb_compras (
  Id_Compra INT AUTO_INCREMENT PRIMARY KEY,
  Data_Compra TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  Total_Compra DECIMAL(10,2) NOT NULL,
  Observacoes TEXT
);

-- Tabela: Fornecedores
CREATE TABLE tb_fornecedores (
  Id_Fornecedor INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(100) NOT NULL UNIQUE,
  Cnpj VARCHAR(20) NOT NULL UNIQUE,
  Email VARCHAR(200) UNIQUE,
  Telefone VARCHAR(30),
  Celular VARCHAR(30),
  Cep VARCHAR(20),
  Endereco VARCHAR(255),
  Data_Cadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  Status TINYINT(1) DEFAULT 1
);

-- Tabela: Funcionários
CREATE TABLE tb_funcionarios (
  Id_Funcionario INT AUTO_INCREMENT PRIMARY KEY,
  Nome VARCHAR(100) NOT NULL,
  Rg VARCHAR(20) NOT NULL UNIQUE,
  Cpf VARCHAR(20) NOT NULL UNIQUE,
  Email VARCHAR(100) NOT NULL UNIQUE,
  Numero VARCHAR(20) NOT NULL,
  Datanasc DATE,
  Cep VARCHAR(20),
  Endereco VARCHAR(100),
  Login VARCHAR(50) NOT NULL UNIQUE,
  Senha CHAR(60) NOT NULL,
  Tipo_Usuario ENUM('ADMIN','NORMAL') DEFAULT 'NORMAL',
  Data_Cadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  Status TINYINT(1) DEFAULT 1,
  KEY Idx_Nome (Nome)
);

-- Inserção do usuário administrador padrão
INSERT INTO tb_funcionarios
(Nome, Rg, Cpf, Email, Numero, Datanasc, Endereco, Login, Senha, Tipo_Usuario, Cep)
VALUES
('Administrador', '00.000.000-0', '000.000.000-00', 'administrador@hotmail.com',
 '(11) 9 0000-0000', '0101-01-01', 'Rua Administrador', 'administrador',
 '$2a$11$fwQujo3xFNUW02HQvv.OSeNDWKBIjUJhe1TzwW9PxNYP0flyCvMPO', 'ADMIN', '00000-000');

-- Tabela: Histórico de Devedores
CREATE TABLE tb_historico_devedores (
  Id_Historico INT AUTO_INCREMENT PRIMARY KEY,
  Cliente_Id INT NOT NULL,
  Venda_Id INT NOT NULL,
  Divida_Inicial DECIMAL(10,2) NOT NULL,
  Divida_Atual DECIMAL(10,2) NOT NULL,
  Data_Inicio_Divida DATETIME DEFAULT CURRENT_TIMESTAMP,
  Data_Atualizacao DATETIME,
  Data_Quitacao DATETIME,
  Status TINYINT(1) DEFAULT 1,
  FOREIGN KEY (Cliente_Id) REFERENCES tb_clientes (Id_Cliente),
  FOREIGN KEY (Venda_Id) REFERENCES tb_vendas (Id_Venda)
);

-- Tabela: Itens de Compras
CREATE TABLE tb_itenscompras (
  Id_Item_Compra INT AUTO_INCREMENT PRIMARY KEY,
  Compra_Id INT NOT NULL,
  Fornecedor_Id INT NOT NULL,
  Nome_Produto VARCHAR(100) NOT NULL,
  Marca VARCHAR(100) NOT NULL,
  Cor VARCHAR(20) NOT NULL,
  Tamanho VARCHAR(10) NOT NULL,
  Descricao VARCHAR(255),
  Qtd INT NOT NULL,
  Categoria_Prod_Id INT NOT NULL,
  Categoria_Publ_Id INT NOT NULL,
  Preco_Custo DECIMAL(10,2) NOT NULL,
  Preco_Medio DECIMAL(10,2) NOT NULL,
  Subtotal DECIMAL(10,2) NOT NULL,
  FOREIGN KEY (Compra_Id) REFERENCES tb_compras (Id_Compra),
  FOREIGN KEY (Fornecedor_Id) REFERENCES tb_fornecedores (Id_Fornecedor)
);

-- Tabela: Itens de Vendas
CREATE TABLE tb_itensvendas (
  Id_Item_Venda INT AUTO_INCREMENT PRIMARY KEY,
  Venda_Id INT,
  Produto_Id INT,
  Qtd INT NOT NULL,
  Preco_Unitario DECIMAL(10,2) NOT NULL,
  Subtotal DECIMAL(10,2),
  FOREIGN KEY (Venda_Id) REFERENCES tb_vendas (Id_Venda),
  FOREIGN KEY (Produto_Id) REFERENCES tb_produtos (Id_Produto)
);

-- Tabela: Pagamentos
CREATE TABLE tb_pagamentos (
  Id_Pagamento INT AUTO_INCREMENT PRIMARY KEY,
  Vendaa_Id INT NOT NULL,
  Forma_Pagamento ENUM('Dinheiro','Cartão de Crédito','Cartão de Débito','PIX') NOT NULL,
  Valor_Pago DECIMAL(10,2) NOT NULL,
  FOREIGN KEY (Vendaa_Id) REFERENCES tb_vendas (Id_Venda) ON DELETE CASCADE
);

-- Tabela: Produtos
CREATE TABLE tb_produtos (
  Id_Produto INT AUTO_INCREMENT PRIMARY KEY,
  Nome_Produto VARCHAR(100) NOT NULL,
  Marca VARCHAR(100) NOT NULL,
  Cor VARCHAR(20) NOT NULL,
  Tamanho VARCHAR(10) NOT NULL,
  Descricao VARCHAR(255),
  Preco_Venda DECIMAL(10,2) NOT NULL,
  Preco_Medio DECIMAL(10,2) NOT NULL,
  Qtd_Estoque INT NOT NULL DEFAULT 0,
  Categoria_Prod_Id INT NOT NULL,
  Categoria_Publ_Id INT NOT NULL,
  DataCadastro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  Status TINYINT(1) DEFAULT 1,
  UNIQUE KEY Uq_Produto (Nome_Produto, Marca, Cor, Tamanho),
  FOREIGN KEY (Categoria_Prod_Id) REFERENCES tb_categoria_produto (Id_Categoria_Prod),
  FOREIGN KEY (Categoria_Publ_Id) REFERENCES tb_categoria_publico (Id_Categoria_Pub)
);

-- Tabela: Vendas
CREATE TABLE tb_vendas (
  Id_Venda INT AUTO_INCREMENT PRIMARY KEY,
  Cliente_Id INT,
  Data_Venda DATETIME DEFAULT CURRENT_TIMESTAMP,
  Total_Venda DECIMAL(10,2) NOT NULL,
  Desconto DECIMAL(10,2) DEFAULT 0.00,
  Valor_Pago DECIMAL(10,2) DEFAULT 0.00,
  Status ENUM('Pendente','Concluída','Cancelada') DEFAULT 'Pendente',
  Observacoes TEXT,
  FOREIGN KEY (Cliente_Id) REFERENCES tb_clientes (Id_Cliente)
);