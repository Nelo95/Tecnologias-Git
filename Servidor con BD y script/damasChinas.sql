-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: damaschinas
-- ------------------------------------------------------
-- Server version	5.7.20-log

--
-- User for damasChinas 
--
DROP USER IF EXISTS 'damasChinas'@'localhost';
CREATE USER IF NOT EXISTS 'damasChinas'@'localhost' IDENTIFIED BY 'damasChinas';

--
-- Database creation
--
DROP DATABASE IF EXISTS damasChinas;
CREATE DATABASE IF NOT EXISTS damasChinas;

GRANT ALL PRIVILEGES ON damasChinas.* TO 'damasChinas'@'localhost';
FLUSH PRIVILEGES;

USE damasChinas;

--
-- Table structure for table `puntajes`
--

DROP TABLE IF EXISTS `puntajes`;
CREATE TABLE `puntajes` (
  `idpuntajes` int(11) NOT NULL AUTO_INCREMENT,
  `posicion` int(11) NOT NULL,
  `puntaje` int(11) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`idpuntajes`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `puntajes`
--

LOCK TABLES `puntajes` WRITE;
/*!40000 ALTER TABLE `puntajes` DISABLE KEYS */;
INSERT INTO `puntajes` VALUES (1,1,200,'2017-10-30');
/*!40000 ALTER TABLE `puntajes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `idusuarios` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `contrasenia` varchar(64) NOT NULL,
  PRIMARY KEY (`idusuarios`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'Cristina Garza','chrysgarza','c395478dec952880c7c67abe5f10e29564f469426fc3158384cd559ad411ccbb');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios_has_puntajes`
--

DROP TABLE IF EXISTS `usuarios_has_puntajes`;
CREATE TABLE `usuarios_has_puntajes` (
  `idpuntajes` int(11) NOT NULL,
  `idusuarios` int(11) NOT NULL,
  KEY `fkusuario_idx2` (`idpuntajes`),
  KEY `fkpuntajes_idx2` (`idusuarios`),
  CONSTRAINT `restPuntajes` FOREIGN KEY (`idusuarios`) REFERENCES `usuarios` (`idusuarios`),
  CONSTRAINT `restUsuariosPuntajes` FOREIGN KEY (`idpuntajes`) REFERENCES `puntajes` (`idpuntajes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `usuarios_has_puntajes`
--

LOCK TABLES `usuarios_has_puntajes` WRITE;
/*!40000 ALTER TABLE `usuarios_has_puntajes` DISABLE KEYS */;
INSERT INTO `usuarios_has_puntajes` VALUES (1,1);
/*!40000 ALTER TABLE `usuarios_has_puntajes` ENABLE KEYS */;
UNLOCK TABLES;


-- Dump completed on 2017-10-30 20:38:01
