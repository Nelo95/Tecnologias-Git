-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: damaschinas
-- ------------------------------------------------------
-- Server version	5.7.20-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `puntajes`
--

DROP TABLE IF EXISTS `puntajes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `puntajes` (
  `idpuntajes` int(11) NOT NULL AUTO_INCREMENT,
  `posicion` int(11) NOT NULL,
  `puntaje` int(11) NOT NULL,
  `fecha` date NOT NULL,
  PRIMARY KEY (`idpuntajes`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

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
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `idusuarios` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `usuario` varchar(45) NOT NULL,
  `contrasenia` varchar(64) NOT NULL,
  PRIMARY KEY (`idusuarios`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

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
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios_has_puntajes` (
  `idpuntajes` int(11) NOT NULL,
  `idusuarios` int(11) NOT NULL,
  KEY `fkusuario_idx2` (`idpuntajes`),
  KEY `fkpuntajes_idx2` (`idusuarios`),
  CONSTRAINT `restPuntajes` FOREIGN KEY (`idusuarios`) REFERENCES `usuarios` (`idusuarios`),
  CONSTRAINT `restUsuariosPuntajes` FOREIGN KEY (`idpuntajes`) REFERENCES `puntajes` (`idpuntajes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios_has_puntajes`
--

LOCK TABLES `usuarios_has_puntajes` WRITE;
/*!40000 ALTER TABLE `usuarios_has_puntajes` DISABLE KEYS */;
INSERT INTO `usuarios_has_puntajes` VALUES (1,1);
/*!40000 ALTER TABLE `usuarios_has_puntajes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-10-30 20:38:01
