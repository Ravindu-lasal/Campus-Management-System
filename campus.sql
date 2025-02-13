CREATE DATABASE  IF NOT EXISTS `campus` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `campus`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: campus
-- ------------------------------------------------------
-- Server version	8.0.39

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
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `id` int NOT NULL AUTO_INCREMENT,
  `student_id` varchar(100) DEFAULT NULL,
  `student_name` varchar(100) DEFAULT NULL,
  `student_gender` varchar(45) DEFAULT NULL,
  `student_address` varchar(255) DEFAULT NULL,
  `student_grade` varchar(45) DEFAULT NULL,
  `student_section` varchar(45) DEFAULT NULL,
  `student_image` varchar(255) DEFAULT NULL,
  `student_status` varchar(45) DEFAULT NULL,
  `date_insert` date DEFAULT NULL,
  `date_update` date DEFAULT NULL,
  `date_delete` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES (1,'11','asasddd','Female','sdssfggfgfgfddzxxz','C','C','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\student_images\\11.jpg','Enrolled','2025-02-12','2025-02-12','2025-02-13'),(2,'222','qwqw','Male','wqsdsd','A','C','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\student_images\\222.jpg','Enrolled','2025-02-12','2025-02-12','2025-02-13'),(4,'444','sds','Female','sdsdsdfsfsdsddfxzxzxz','Grade 2','C','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\student_images\\444.jpg','Graduate','2025-02-12','2025-02-12',NULL),(5,'55','sdsd','Female','dsdsassdsswew','Grade 3','B','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\student_images\\55.jpg','Enrolled','2025-02-12','2025-02-12',NULL),(6,'66','gdf','Male','fgggssdsdsd','B','W','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\student_images\\66.jpg','Inactive','2025-02-12','2025-02-12','2025-02-12'),(7,'67','gdfg','Male','fdg','Grade 3','B','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\student_images\\67.jpg','Enrolled','2025-02-12',NULL,NULL),(8,'333','gihan','Male','asa','Grade 3','A','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\student_images\\333.jpg','Enrolled','2025-02-13','2025-02-13',NULL);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teachers`
--

DROP TABLE IF EXISTS `teachers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teachers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `teacher_id` varchar(45) DEFAULT NULL,
  `teacher_name` varchar(100) DEFAULT NULL,
  `teacher_gender` varchar(45) DEFAULT NULL,
  `teacher_address` varchar(255) DEFAULT NULL,
  `teacher_image` varchar(255) DEFAULT NULL,
  `teacher_status` varchar(45) DEFAULT NULL,
  `date_insert` date DEFAULT NULL,
  `date_update` date DEFAULT NULL,
  `date_delete` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teachers`
--

LOCK TABLES `teachers` WRITE;
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` VALUES (1,'111','sas','Male','asass','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\teacher images\\111.jpg','Active','2025-02-07',NULL,NULL),(2,'1212','asa','Female','sasa','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\teacher images\\1212.jpg','Active','2025-02-07','2025-02-11','2025-02-11'),(3,'121','qwqwq','Female','sas','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\teacher images\\121.jpg','Active','2025-02-07','2025-02-11','2025-02-11'),(4,'222','sasass','Male','asasaaaaaddfdfdfs','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\teacher images\\222.jpg','Active','2025-02-11','2025-02-12',NULL),(5,'333','dss','Female','ssadsdaaaaabb','C:\\Users\\ravin\\Desktop\\my project\\Visual Studio\\CampusManagementSystem\\CampusManagementSystem\\bin\\Debug\\teacher images\\333.jpg','Active','2025-02-12','2025-02-12',NULL);
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin123');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-13 12:56:49
