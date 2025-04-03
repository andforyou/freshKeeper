-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: freshkeeper
-- ------------------------------------------------------
-- Server version	8.0.36

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
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categories` (
  `cate_id` int NOT NULL AUTO_INCREMENT,
  `cate_name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `description` varchar(255) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`cate_id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (0,'Proteins','Foods high in protein like meat, fish, eggs, and tofu.'),(1,'Carbohydrates','Foods rich in carbohydrates like rice, pasta, bread, and potatoes.'),(2,'Fats','Foods containing healthy fats like avocados, nuts, seeds, and olive oil.'),(3,'Dairy','Dairy products such as milk, cheese, yogurt, and butter.'),(4,'Vegetables','Various vegetables like broccoli, spinach, carrots, and peppers.'),(5,'Fruits','Fresh fruits including apples, bananas, oranges, and berries.'),(6,'Grains','Whole grains such as oats, quinoa, barley, and brown rice.'),(7,'Sugars','Foods containing sugars like sweets, candies, and desserts.'),(8,'Beverages','Drinks including water, juice, tea, coffee, and soft drinks.'),(9,'Seafood','Seafood like fish, shrimp, crab, and clams.'),(10,'Snacks','Snack foods such as chips, cookies, and crackers.'),(11,'Legumes','Foods like lentils, beans, chickpeas, and peas.'),(12,'Nuts and Seeds','Various nuts (e.g., almonds, walnuts) and seeds (e.g., chia, flax).'),(13,'Sweets and Desserts','Sweets such as chocolate, cakes, and ice cream.'),(14,'Baked Goods','Bread, muffins, cakes, and other baked products.'),(15,'Condiments and Sauces','Items like ketchup, mustard, mayonnaise, and salad dressings.'),(16,'Processed Foods','Packaged foods such as canned soup, frozen meals, and deli meats.'),(17,'Herbal and Spices','Various herbs and spices like oregano, basil, and turmeric.'),(18,'Oils','Different types of oils like olive oil, coconut oil, and sunflower oil.'),(19,'Alcoholic Beverages','Alcoholic drinks such as beer, wine, and spirits.'),(20,'Non-Alcoholic Beverages','Drinks such as soda, juice, tea, coffee, and flavored water.');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-10-24  0:31:20
