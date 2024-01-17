-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 17, 2024 at 07:32 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_movies`
--
CREATE DATABASE IF NOT EXISTS `db_movies` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `db_movies`;

-- --------------------------------------------------------

--
-- Table structure for table `tb_movie`
--

CREATE TABLE IF NOT EXISTS `tb_movie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `genre` varchar(50) NOT NULL,
  `duration` varchar(10) NOT NULL,
  `release_date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_movie`
--

INSERT INTO `tb_movie` (`id`, `name`, `genre`, `duration`, `release_date`) VALUES
(1, 'Bad Boys for Life', 'Action/Comedy', '2h 5 mins', '2020-01-23'),
(2, 'John Wick', 'Action/Thriller', '1h 41 mins', '2014-10-24'),
(3, 'The Martian', 'Si-fi/Drama', '2h 31 mins', '2015-10-02'),
(4, 'How to Train Your Dragon: The Hidden World', 'Animation/Family', '1h 45 mins', '2020-01-23');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
