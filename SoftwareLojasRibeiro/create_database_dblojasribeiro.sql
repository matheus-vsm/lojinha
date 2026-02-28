CREATE DATABASE  IF NOT EXISTS `DB_LOJA` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `DB_LOJA`;
-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: DB_LOJA
-- ------------------------------------------------------
-- Server version	8.0.42

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tb_categoria_produto`
--

DROP TABLE IF EXISTS `tb_categoria_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_categoria_produto` (
  `Id_Categoria_Prod` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Descricao` varchar(255) DEFAULT NULL,
  `Data_Cadastro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Id_Categoria_Prod`),
  KEY `Idx_Nome` (`Nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_categoria_produto`
--

LOCK TABLES `tb_categoria_produto` WRITE;
/*!40000 ALTER TABLE `tb_categoria_produto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_categoria_produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_categoria_publico`
--

DROP TABLE IF EXISTS `tb_categoria_publico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_categoria_publico` (
  `Id_Categoria_Pub` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Descricao` varchar(255) DEFAULT NULL,
  `Data_Cadastro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Id_Categoria_Pub`),
  KEY `Idx_Nome` (`Nome`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_categoria_publico`
--

LOCK TABLES `tb_categoria_publico` WRITE;
/*!40000 ALTER TABLE `tb_categoria_publico` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_categoria_publico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_clientes`
--

DROP TABLE IF EXISTS `tb_clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_clientes` (
  `Id_Cliente` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Rg` varchar(20) NOT NULL,
  `Cpf` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Numero` varchar(20) NOT NULL,
  `Datanasc` date DEFAULT NULL,
  `Endereco` varchar(100) DEFAULT NULL,
  `Cep` varchar(20) DEFAULT NULL,
  `Status` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Id_Cliente`),
  UNIQUE KEY `Rg` (`Rg`),
  UNIQUE KEY `Cpf` (`Cpf`),
  UNIQUE KEY `Idx_Email` (`Email`),
  KEY `Idx_Nome` (`Nome`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tb_compras`
--

DROP TABLE IF EXISTS `tb_compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_compras` (
  `Id_Compra` int NOT NULL AUTO_INCREMENT,
  `Data_Compra` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `Total_Compra` decimal(10,2) NOT NULL,
  `Observacoes` text,
  PRIMARY KEY (`Id_Compra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_compras`
--

LOCK TABLES `tb_compras` WRITE;
/*!40000 ALTER TABLE `tb_compras` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_fornecedores`
--

DROP TABLE IF EXISTS `tb_fornecedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_fornecedores` (
  `Id_Fornecedor` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Cnpj` varchar(20) NOT NULL,
  `Email` varchar(200) DEFAULT NULL,
  `Telefone` varchar(30) DEFAULT NULL,
  `Celular` varchar(30) DEFAULT NULL,
  `Cep` varchar(20) DEFAULT NULL,
  `Endereco` varchar(255) DEFAULT NULL,
  `Data_Cadastro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Id_Fornecedor`),
  UNIQUE KEY `Cnpj` (`Cnpj`),
  UNIQUE KEY `Idx_Nome` (`Nome`),
  UNIQUE KEY `Idx_Email` (`Email`),
  KEY `Idx_Cnpj` (`Cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_fornecedores`
--

LOCK TABLES `tb_fornecedores` WRITE;
/*!40000 ALTER TABLE `tb_fornecedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_fornecedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_funcionarios`
--

DROP TABLE IF EXISTS `tb_funcionarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_funcionarios` (
  `Id_Funcionario` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Rg` varchar(20) NOT NULL,
  `Cpf` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Numero` varchar(20) NOT NULL,
  `Datanasc` date DEFAULT NULL,
  `Cep` varchar(20) DEFAULT NULL,
  `Endereco` varchar(100) DEFAULT NULL,
  `Login` varchar(50) NOT NULL,
  `Senha` char(60) NOT NULL,
  `Tipo_Usuario` enum('ADMIN','NORMAL') NOT NULL DEFAULT 'NORMAL',
  `Data_Cadastro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Id_Funcionario`),
  UNIQUE KEY `Rg` (`Rg`),
  UNIQUE KEY `Cpf` (`Cpf`),
  UNIQUE KEY `Login` (`Login`),
  UNIQUE KEY `Idx_Email` (`Email`),
  KEY `Idx_Nome` (`Nome`),
  KEY `Idx_Login` (`Login`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_funcionarios`
--

LOCK TABLES `tb_funcionarios` WRITE;
/*!40000 ALTER TABLE `tb_funcionarios` DISABLE KEYS */;
INSERT INTO `tb_funcionarios` VALUES (1,'Administrador do Sistema','2','3','admin@loja.com.br','2','1990-01-01','','','Administrador','$2a$11$rKfV/mhO3l/EM2F3NYl0zu9JUYgrbPk7hMgdqb7Ll0iki5uR0A9Kq','ADMIN','2026-02-27 20:52:38',1);
-- Senha: SenhaAdministrador@123@
/*!40000 ALTER TABLE `tb_funcionarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_historico_devedores`
--

DROP TABLE IF EXISTS `tb_historico_devedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_historico_devedores` (
  `Id_Historico` int NOT NULL AUTO_INCREMENT,
  `Cliente_Id` int NOT NULL,
  `Venda_Id` int NOT NULL,
  `Divida_Inicial` decimal(10,2) NOT NULL,
  `Divida_Atual` decimal(10,2) NOT NULL,
  `Data_Inicio_Divida` datetime DEFAULT CURRENT_TIMESTAMP,
  `Data_Atualizacao` datetime DEFAULT NULL,
  `Data_Quitacao` datetime DEFAULT NULL,
  `Status` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Id_Historico`),
  KEY `Cliente_Id` (`Cliente_Id`),
  KEY `Venda_Id` (`Venda_Id`),
  CONSTRAINT `tb_historico_devedores_ibfk_1` FOREIGN KEY (`Cliente_Id`) REFERENCES `tb_clientes` (`Id_Cliente`),
  CONSTRAINT `tb_historico_devedores_ibfk_2` FOREIGN KEY (`Venda_Id`) REFERENCES `tb_vendas` (`Id_Venda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_historico_devedores`
--

LOCK TABLES `tb_historico_devedores` WRITE;
/*!40000 ALTER TABLE `tb_historico_devedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_historico_devedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_itenscompras`
--

DROP TABLE IF EXISTS `tb_itenscompras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_itenscompras` (
  `Id_Item_Compra` int NOT NULL AUTO_INCREMENT,
  `Compra_Id` int NOT NULL,
  `Fornecedor_Id` int NOT NULL,
  `Nome_Produto` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `Cor` varchar(20) NOT NULL,
  `Tamanho` varchar(10) NOT NULL,
  `Descricao` varchar(255) DEFAULT NULL,
  `Qtd` int NOT NULL,
  `Categoria_Prod_Id` int NOT NULL,
  `Categoria_Publ_Id` int NOT NULL,
  `Preco_Custo` decimal(10,2) NOT NULL,
  `Preco_Medio` decimal(10,2) NOT NULL,
  `Subtotal` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Id_Item_Compra`),
  KEY `Compra_Id` (`Compra_Id`),
  KEY `Fornecedor_Id` (`Fornecedor_Id`),
  CONSTRAINT `tb_itenscompras_ibfk_1` FOREIGN KEY (`Compra_Id`) REFERENCES `tb_compras` (`Id_Compra`),
  CONSTRAINT `tb_itenscompras_ibfk_2` FOREIGN KEY (`Fornecedor_Id`) REFERENCES `tb_fornecedores` (`Id_Fornecedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_itenscompras`
--

LOCK TABLES `tb_itenscompras` WRITE;
/*!40000 ALTER TABLE `tb_itenscompras` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_itenscompras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_itensvendas`
--

DROP TABLE IF EXISTS `tb_itensvendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_itensvendas` (
  `Id_Item_Venda` int NOT NULL AUTO_INCREMENT,
  `Venda_Id` int DEFAULT NULL,
  `Produto_Id` int DEFAULT NULL,
  `Qtd` int NOT NULL,
  `Preco_Unitario` decimal(10,2) NOT NULL,
  `Subtotal` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Id_Item_Venda`),
  KEY `Idx_Venda_Id` (`Venda_Id`),
  KEY `Idx_Produto_Id` (`Produto_Id`),
  CONSTRAINT `tb_itensvendas_ibfk_1` FOREIGN KEY (`Venda_Id`) REFERENCES `tb_vendas` (`Id_Venda`),
  CONSTRAINT `tb_itensvendas_ibfk_2` FOREIGN KEY (`Produto_Id`) REFERENCES `tb_produtos` (`Id_Produto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_itensvendas`
--

LOCK TABLES `tb_itensvendas` WRITE;
/*!40000 ALTER TABLE `tb_itensvendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_itensvendas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_pagamentos`
--

DROP TABLE IF EXISTS `tb_pagamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_pagamentos` (
  `Id_Pagamento` int NOT NULL AUTO_INCREMENT,
  `Vendaa_Id` int NOT NULL,
  `Forma_Pagamento` enum('Dinheiro','Cartão de Crédito','Cartão de Débito','PIX') NOT NULL,
  `Valor_Pago` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Id_Pagamento`),
  KEY `Vendaa_Id` (`Vendaa_Id`),
  CONSTRAINT `tb_pagamentos_ibfk_1` FOREIGN KEY (`Vendaa_Id`) REFERENCES `tb_vendas` (`Id_Venda`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_pagamentos`
--

LOCK TABLES `tb_pagamentos` WRITE;
/*!40000 ALTER TABLE `tb_pagamentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_pagamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_produtos`
--

DROP TABLE IF EXISTS `tb_produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_produtos` (
  `Id_Produto` int NOT NULL AUTO_INCREMENT,
  `Nome_Produto` varchar(100) NOT NULL,
  `Marca` varchar(100) NOT NULL,
  `Cor` varchar(20) NOT NULL,
  `Tamanho` varchar(10) NOT NULL,
  `Descricao` varchar(255) DEFAULT NULL,
  `Preco_Venda` decimal(10,2) NOT NULL,
  `Preco_Medio` decimal(10,2) NOT NULL,
  `Qtd_Estoque` int NOT NULL DEFAULT '0',
  `Categoria_Prod_Id` int NOT NULL,
  `Categoria_Publ_Id` int NOT NULL,
  `DataCadastro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`Id_Produto`),
  UNIQUE KEY `Idx_Produto_Unico` (`Nome_Produto`,`Marca`,`Cor`,`Tamanho`),
  KEY `Idx_Nome` (`Nome_Produto`),
  KEY `Categoria_Prod_Id` (`Categoria_Prod_Id`),
  KEY `Categoria_Publ_Id` (`Categoria_Publ_Id`),
  CONSTRAINT `tb_produtos_ibfk_1` FOREIGN KEY (`Categoria_Prod_Id`) REFERENCES `tb_categoria_produto` (`Id_Categoria_Prod`),
  CONSTRAINT `tb_produtos_ibfk_2` FOREIGN KEY (`Categoria_Publ_Id`) REFERENCES `tb_categoria_publico` (`Id_Categoria_Pub`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_produtos`
--

LOCK TABLES `tb_produtos` WRITE;
/*!40000 ALTER TABLE `tb_produtos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_produtos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tb_vendas`
--

DROP TABLE IF EXISTS `tb_vendas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tb_vendas` (
  `Id_Venda` int NOT NULL AUTO_INCREMENT,
  `Cliente_Id` int DEFAULT NULL,
  `Data_Venda` datetime DEFAULT CURRENT_TIMESTAMP,
  `Total_Venda` decimal(10,2) NOT NULL,
  `Desconto` decimal(10,2) DEFAULT '0.00',
  `Valor_Pago` decimal(10,2) DEFAULT '0.00',
  `Status` enum('Pendente','Concluída','Cancelada') DEFAULT 'Pendente',
  `Observacoes` text,
  PRIMARY KEY (`Id_Venda`),
  KEY `Idx_Cliente_Id` (`Cliente_Id`),
  CONSTRAINT `tb_vendas_ibfk_1` FOREIGN KEY (`Cliente_Id`) REFERENCES `tb_clientes` (`Id_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tb_vendas`
--

LOCK TABLES `tb_vendas` WRITE;
/*!40000 ALTER TABLE `tb_vendas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tb_vendas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-02-28 19:34:11
