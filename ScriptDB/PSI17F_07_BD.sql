CREATE DATABASE  IF NOT EXISTS `dt_escoladigital` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `dt_escoladigital`;
-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dt_escoladigital
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aluno`
--

DROP TABLE IF EXISTS `aluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `aluno` (
  `IDAluno` int(50) NOT NULL AUTO_INCREMENT,
  `PrimeiroNome` varchar(50) NOT NULL,
  `Apelido` varchar(50) NOT NULL,
  `Numero` int(50) NOT NULL,
  `NIF` int(50) NOT NULL,
  `Telemovel` int(50) NOT NULL,
  `Email` varchar(200) NOT NULL,
  `Pass` varchar(100) NOT NULL,
  `IDCurso` int(50) DEFAULT NULL,
  `IDDados_Aluno` int(50) DEFAULT NULL,
  PRIMARY KEY (`IDAluno`),
  KEY `FK_iddados_aluno__idx` (`IDDados_Aluno`),
  KEY `FK_idcurso_` (`IDCurso`),
  CONSTRAINT `FK_idcurso_` FOREIGN KEY (`IDCurso`) REFERENCES `curso` (`IDCurso`),
  CONSTRAINT `FK_iddados_aluno_` FOREIGN KEY (`IDDados_Aluno`) REFERENCES `dados_aluno_matricula` (`IDDados_Aluno`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aluno`
--

LOCK TABLES `aluno` WRITE;
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
INSERT INTO `aluno` VALUES (4,'João','Fernandes',9,238264939,935376050,'joaopff23@gmail.com','FEr_2018?23',NULL,NULL),(5,'wetwdg','wgwfeg',32432,234342,24323,'testet','ff',NULL,NULL),(6,'gsfgg','sdgfsd',34242,43422,234234,'dfdaga','agasgda',NULL,NULL),(7,'gasdadsgas','sdgasgasg',6363,52535,34523523,'dhhdfghdfhd','hdfghdhgdfh',NULL,NULL);
/*!40000 ALTER TABLE `aluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `curso`
--

DROP TABLE IF EXISTS `curso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `curso` (
  `IDCurso` int(50) NOT NULL AUTO_INCREMENT,
  `NomeCurso` varchar(200) NOT NULL,
  `Turma` varchar(100) NOT NULL,
  PRIMARY KEY (`IDCurso`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `curso`
--

LOCK TABLES `curso` WRITE;
/*!40000 ALTER TABLE `curso` DISABLE KEYS */;
INSERT INTO `curso` VALUES (1,'Curso Profissional de Gestão e Programação de Sistemas Informáticos','faef'),(2,'Curso Profissional de Gestão e Programação de Sistemas Informáticos','GFSG'),(3,'Curso Profissional de Gestão e Programação de Sistemas Informáticos','tetet333t'),(4,'Curso Profissional de Desenho Digital 3D','shsh'),(5,'Curso Profissional de Gestão e Programação de Sistemas Informáticos','gdrd4r'),(6,'Curso Profissional de Gestão e Programação de Sistemas Informáticos','TGPSI2F'),(7,'Curso Profissional de Fotografia','fgsr34g'),(8,'Curso Profissional de Gestão e Programação de Sistemas Informáticos','sfdsf'),(9,'Curso Profissional de Fotografia','gdsasgasg');
/*!40000 ALTER TABLE `curso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dados_aluno_matricula`
--

DROP TABLE IF EXISTS `dados_aluno_matricula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dados_aluno_matricula` (
  `IDDados_Aluno` int(50) NOT NULL AUTO_INCREMENT,
  `NomeCompleto` varchar(400) NOT NULL,
  `Sexo` varchar(50) NOT NULL,
  `ResideCom` varchar(150) NOT NULL,
  `DataNascimento` datetime NOT NULL,
  `LocalNascimento` varchar(200) NOT NULL,
  `NIF` int(50) NOT NULL,
  `Naturalidade` varchar(200) NOT NULL,
  `NIC` int(50) NOT NULL,
  `MoradaCompleta` varchar(500) NOT NULL,
  `Email` varchar(200) NOT NULL,
  `Telemovel` int(20) NOT NULL,
  `IDAluno` int(50) NOT NULL,
  `IDDados_Pai` int(50) DEFAULT NULL,
  `IDDados_Mae` int(50) DEFAULT NULL,
  PRIMARY KEY (`IDDados_Aluno`),
  KEY `FK_iddados_pai__idx` (`IDDados_Pai`),
  KEY `FK_iddados_mae__idx` (`IDDados_Mae`),
  KEY `FK_idaluno_` (`IDAluno`),
  CONSTRAINT `FK_idaluno_` FOREIGN KEY (`IDAluno`) REFERENCES `aluno` (`IDAluno`),
  CONSTRAINT `FK_iddados_mae_` FOREIGN KEY (`IDDados_Mae`) REFERENCES `dados_mae_matricula` (`IDDados_Mae`),
  CONSTRAINT `FK_iddados_pai_` FOREIGN KEY (`IDDados_Pai`) REFERENCES `dados_pai_matricula` (`IDDados_Pai`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dados_aluno_matricula`
--

LOCK TABLES `dados_aluno_matricula` WRITE;
/*!40000 ALTER TABLE `dados_aluno_matricula` DISABLE KEYS */;
/*!40000 ALTER TABLE `dados_aluno_matricula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dados_mae_matricula`
--

DROP TABLE IF EXISTS `dados_mae_matricula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dados_mae_matricula` (
  `IDDados_Mae` int(50) NOT NULL AUTO_INCREMENT,
  `NomeCompleto` varchar(400) NOT NULL,
  `Profissao` varchar(200) NOT NULL,
  `Habilitacoes` varchar(150) NOT NULL,
  `DataNascimento` datetime NOT NULL,
  `LocalNascimento` varchar(200) NOT NULL,
  `NIF` int(50) NOT NULL,
  `Naturalidade` varchar(200) NOT NULL,
  `NIC` int(50) NOT NULL,
  `MoradaCompleta` varchar(500) NOT NULL,
  `Email` varchar(200) NOT NULL,
  `Telemovel` int(100) NOT NULL,
  `IDAluno` int(50) NOT NULL,
  PRIMARY KEY (`IDDados_Mae`),
  KEY `FK_idaluno_dados_mae_idx` (`IDAluno`),
  CONSTRAINT `FK_idaluno_dados_mae` FOREIGN KEY (`IDAluno`) REFERENCES `aluno` (`IDAluno`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dados_mae_matricula`
--

LOCK TABLES `dados_mae_matricula` WRITE;
/*!40000 ALTER TABLE `dados_mae_matricula` DISABLE KEYS */;
/*!40000 ALTER TABLE `dados_mae_matricula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dados_pai_matricula`
--

DROP TABLE IF EXISTS `dados_pai_matricula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dados_pai_matricula` (
  `IDDados_Pai` int(50) NOT NULL AUTO_INCREMENT,
  `NomeCompleto` varchar(250) NOT NULL,
  `Profissao` varchar(250) NOT NULL,
  `Habilitacoes` varchar(250) NOT NULL,
  `DataNascimento` datetime NOT NULL,
  `LocalNascimento` varchar(250) NOT NULL,
  `NIF` int(100) NOT NULL,
  `Naturalidade` varchar(250) NOT NULL,
  `NIC` int(100) NOT NULL,
  `MoradaCompleta` varchar(250) NOT NULL,
  `Email` varchar(250) NOT NULL,
  `Telemovel` int(100) NOT NULL,
  `IDAluno` int(50) NOT NULL,
  PRIMARY KEY (`IDDados_Pai`),
  KEY `FK_idaluno_pai__idx` (`IDAluno`),
  CONSTRAINT `FK_idaluno_pai_` FOREIGN KEY (`IDAluno`) REFERENCES `aluno` (`IDAluno`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dados_pai_matricula`
--

LOCK TABLES `dados_pai_matricula` WRITE;
/*!40000 ALTER TABLE `dados_pai_matricula` DISABLE KEYS */;
/*!40000 ALTER TABLE `dados_pai_matricula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `funcionario` (
  `IDFuncionario` int(50) NOT NULL AUTO_INCREMENT,
  `PrimeiroNome` varchar(50) NOT NULL,
  `Apelido` varchar(50) NOT NULL,
  `NumeroFuncionario` int(50) NOT NULL,
  `NIF` int(50) NOT NULL,
  `Email` varchar(200) NOT NULL,
  `Pass` varchar(100) NOT NULL,
  PRIMARY KEY (`IDFuncionario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` VALUES (2,'ewwer','erw',3242,4234,'testefuncionario','teste2'),(3,'dsfgs','fdgs',4324,2342,'ft','ff');
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matriula`
--

DROP TABLE IF EXISTS `matriula`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `matriula` (
  `IDMatricula` int(50) NOT NULL AUTO_INCREMENT,
  `IDAluno` int(50) NOT NULL,
  `IDDados_Aluno` int(50) NOT NULL,
  `IDDados_Mae` int(50) NOT NULL,
  `IDDados_Pai` int(50) NOT NULL,
  `IDFuncionario` int(50) NOT NULL,
  PRIMARY KEY (`IDMatricula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matriula`
--

LOCK TABLES `matriula` WRITE;
/*!40000 ALTER TABLE `matriula` DISABLE KEYS */;
/*!40000 ALTER TABLE `matriula` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'dt_escoladigital'
--

--
-- Dumping routines for database 'dt_escoladigital'
--
/*!50003 DROP PROCEDURE IF EXISTS `AlunoDeleteByValue` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AlunoDeleteByValue`(_SearchValue int (50))
BEGIN

DELETE FROM dados_aluno_matricula where (IDAluno like concat('%',_SearchValue,'%'));
DELETE FROM dados_mae_matricula where (IDAluno like concat('%',_SearchValue,'%'));
DELETE FROM dados_pai_matricula where (IDAluno like concat('%',_SearchValue,'%'));

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AlunoSearchByValue` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `AlunoSearchByValue`(_SearchValue varchar(250))
BEGIN

Select * from dados_aluno_matricula where (IDAluno LIKE concat('%',_SearchValue,'%')) || (NomeCompleto like concat('%',_SearchValue,'%'));

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-18 11:08:46
