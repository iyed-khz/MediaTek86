
-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 06, 2023 at 11:46 AM
-- Server version: 8.0.31
-- PHP Version: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mediatek86`
--

-- --------------------------------------------------------

--
-- Table structure for table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `I_FK_ABSENCE_MOTIF` (`IDMOTIF`),
  KEY `I_FK_ABSENCE_PERSONNEL` (`IDPERSONNEL`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(1, '2022-02-03 00:44:42', 0, '2022-09-24 10:40:54'),
(5, '2022-01-10 00:18:22', 4, '2023-05-13 07:36:22'),
(4, '2022-01-07 02:47:58', 3, '2022-01-29 00:51:25'),
(3, '2022-01-04 12:33:01', 3, '2022-06-11 00:35:42'),
(2, '2022-01-09 22:57:16', 1, '2022-08-10 06:40:43'),
(1, '2022-01-09 07:07:35', 3, '2023-10-09 18:11:33'),
(2, '2022-02-02 15:56:13', 1, '2023-02-23 03:42:14'),
(3, '2022-02-10 03:10:49', 3, '2023-05-18 02:02:06'),
(4, '2022-02-03 10:59:28', 3, '2023-10-10 20:35:33'),
(5, '2022-02-06 03:36:57', 2, '2022-05-30 04:32:09'),
(1, '2022-03-06 20:26:39', 1, '2022-06-15 20:28:38'),
(2, '2022-03-05 14:24:14', 4, '2023-08-13 00:59:18'),
(3, '2022-03-02 07:50:35', 1, '2022-03-16 04:03:42'),
(4, '2022-03-08 22:04:14', 3, '2022-12-06 11:09:04'),
(5, '2022-03-08 08:29:34', 3, '2023-12-12 03:28:36'),
(1, '2022-04-10 07:42:26', 0, '2023-12-13 01:53:48'),
(2, '2022-04-05 16:22:16', 0, '2023-11-28 17:55:54'),
(3, '2022-04-10 00:30:01', 2, '2023-08-11 05:00:47'),
(4, '2022-04-07 01:19:26', 2, '2023-07-17 17:27:55'),
(5, '2022-04-08 16:33:23', 4, '2023-08-02 20:35:46'),
(1, '2022-05-05 16:20:25', 0, '2022-06-26 01:47:03'),
(2, '2022-05-03 12:19:05', 3, '2024-02-24 11:55:05'),
(3, '2022-05-01 17:15:20', 4, '2023-12-24 11:46:24'),
(4, '2022-05-03 18:27:17', 0, '2022-09-25 02:25:30'),
(5, '2022-05-06 12:49:00', 3, '2024-01-23 01:47:04'),
(1, '2022-06-02 05:07:23', 1, '2023-05-12 19:37:32'),
(2, '2022-06-02 05:05:27', 1, '2022-06-23 02:27:21'),
(3, '2022-06-07 02:58:26', 1, '2022-12-15 22:12:32'),
(4, '2022-06-02 01:43:26', 0, '2023-02-25 14:58:35'),
(5, '2022-06-08 11:52:52', 3, '2023-06-14 06:56:55'),
(1, '2022-07-07 11:59:20', 1, '2023-10-03 09:01:35'),
(2, '2022-07-05 11:00:37', 3, '2023-12-04 13:21:57'),
(3, '2022-07-08 07:33:23', 3, '2022-10-22 10:15:32'),
(4, '2022-07-08 09:55:19', 1, '2024-04-03 13:59:25'),
(5, '2022-07-09 00:52:29', 2, '2024-01-20 11:35:37'),
(1, '2022-08-05 02:01:02', 1, '2022-10-26 16:40:24'),
(2, '2022-08-08 17:46:22', 2, '2022-08-30 07:14:29'),
(3, '2022-08-05 10:18:04', 4, '2022-09-01 13:06:01'),
(4, '2022-08-09 10:28:07', 1, '2023-03-29 02:07:59'),
(5, '2022-08-06 21:39:08', 1, '2023-12-25 12:35:53'),
(1, '2022-09-05 03:08:34', 1, '2024-06-24 08:58:49'),
(2, '2022-09-05 08:32:42', 3, '2024-02-14 11:25:47'),
(3, '2022-09-07 02:12:37', 2, '2023-08-06 11:10:23'),
(4, '2022-09-10 10:10:09', 1, '2023-04-03 19:50:16'),
(5, '2022-09-05 10:13:29', 3, '2023-06-21 17:13:28'),
(1, '2022-10-02 22:53:50', 1, '2023-09-02 22:33:52'),
(2, '2022-10-03 11:31:32', 2, '2023-02-07 18:43:00'),
(3, '2022-10-01 19:33:34', 2, '2023-03-17 12:02:55'),
(4, '2022-10-01 21:05:37', 4, '2023-05-08 11:18:58'),
(5, '2022-10-10 02:43:43', 2, '2024-01-30 16:01:17');

-- --------------------------------------------------------

--
-- Table structure for table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Table structure for table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int NOT NULL,
  `NOM` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PRENOM` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `TEL` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `MAIL` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `I_FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 3, 'Olga', 'Fleming', '09 50 99 53 00', 'in.sodales@yahoo.ca'),
(2, 1, 'Hedley', 'Ochoa', '03 44 65 58 41', 'ut.lacus.nulla@icloud.net'),
(3, 2, 'Lane', 'Patterson', '04 54 55 17 64', 'dolor@icloud.org'),
(4, 2, 'Barrett', 'Gibbs', '07 71 37 91 55', 'sed@icloud.org'),
(5, 2, 'Laith', 'Maynard', '08 32 84 67 52', 'at@protonmail.org'),
(6, 2, 'Brady', 'Howard', '04 44 51 42 37', 'suspendisse.dui.fusce@yahoo.edu'),
(7, 1, 'Kiara', 'Cochran', '04 35 24 21 97', 'nunc.interdum@protonmail.ca'),
(8, 2, 'Amal', 'Tran', '07 13 44 43 25', 'blandit.viverra@hotmail.com'),
(9, 2, 'Colorado', 'Harrison', '02 14 56 94 37', 'velit.eget.laoreet@hotmail.org'),
(10, 3, 'Clio', 'Craig', '06 66 23 77 53', 'et.netus@aol.couk');

-- --------------------------------------------------------

--
-- Table structure for table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('', ''),
('responsable', '0d3e9c1701bbd27ce47d0de853d6d5bbd0598bef5b98f4cd4fd1b66ce44f1f3c');

-- --------------------------------------------------------

--
-- Table structure for table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
