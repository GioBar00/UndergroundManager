CREATE DATABASE  IF NOT EXISTS `undergroundmanager` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `undergroundmanager`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: undergroundmanager
-- ------------------------------------------------------
-- Server version	8.0.13

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
-- Table structure for table `collegamento`
--

DROP TABLE IF EXISTS `collegamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `collegamento` (
  `idcollegamento` int(11) NOT NULL AUTO_INCREMENT,
  `lunghezza` varchar(45) NOT NULL,
  `idlinea` int(11) NOT NULL,
  `idstazione1` int(11) NOT NULL,
  `idstazione2` int(11) NOT NULL,
  PRIMARY KEY (`idcollegamento`),
  KEY `fk_collegamento_linea1_idx` (`idlinea`),
  KEY `fk_collegamento_stazione1_idx` (`idstazione1`),
  KEY `fk_collegamento_stazione2_idx` (`idstazione2`),
  CONSTRAINT `fk_collegamento_linea1` FOREIGN KEY (`idlinea`) REFERENCES `linea` (`idlinea`),
  CONSTRAINT `fk_collegamento_stazione1` FOREIGN KEY (`idstazione1`) REFERENCES `stazione` (`idstazione`),
  CONSTRAINT `fk_collegamento_stazione2` FOREIGN KEY (`idstazione2`) REFERENCES `stazione` (`idstazione`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `linea`
--

DROP TABLE IF EXISTS `linea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `linea` (
  `idlinea` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `colore` int(11) NOT NULL,
  `idmetropolitana` int(11) NOT NULL,
  PRIMARY KEY (`idlinea`),
  KEY `fk_linea_metropolitana_idx` (`idmetropolitana`),
  CONSTRAINT `fk_linea_metropolitana` FOREIGN KEY (`idmetropolitana`) REFERENCES `metropolitana` (`idmetropolitana`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `metropolitana`
--

DROP TABLE IF EXISTS `metropolitana`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `metropolitana` (
  `idmetropolitana` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `dataOraCreazione` datetime NOT NULL,
  `dataOraUltimaModifica` datetime NOT NULL,
  PRIMARY KEY (`idmetropolitana`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `stazione`
--

DROP TABLE IF EXISTS `stazione`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `stazione` (
  `idstazione` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `idmetropolitana` int(11) NOT NULL,
  `x` int(11) NOT NULL,
  `y` int(11) NOT NULL,
  PRIMARY KEY (`idstazione`),
  KEY `fk_stazione_metropolitana1_idx` (`idmetropolitana`),
  CONSTRAINT `fk_stazione_metropolitana1` FOREIGN KEY (`idmetropolitana`) REFERENCES `metropolitana` (`idmetropolitana`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-29 16:48:18
