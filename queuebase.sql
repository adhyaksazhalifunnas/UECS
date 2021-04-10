-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 10, 2021 at 03:42 AM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `queuebase`
--

-- --------------------------------------------------------

--
-- Table structure for table `tr_guest`
--

CREATE TABLE `tr_guest` (
  `id` int(11) NOT NULL,
  `GuestName` varchar(50) COLLATE utf8_bin NOT NULL,
  `Admin` varchar(50) COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Dumping data for table `tr_guest`
--

INSERT INTO `tr_guest` (`id`, `GuestName`, `Admin`) VALUES
(1, 'Bangsat 1', 'ADMIN'),
(2, 'Hasyidan', 'ADMIN'),
(3, 'Test User 3', 'ADMIN'),
(4, 'Adhyaksa', 'ADMIN'),
(5, 'Oshino', 'ADMIN'),
(6, 'Shurararararagi', 'ADMIN'),
(7, 'Guest', 'ADMIN'),
(8, 'Heyy', 'ADMIN'),
(9, 'Tambahan', 'ADMIN'),
(10, 'GuestASA', 'ADMIN'),
(11, 'ASASASA', 'ADMIN'),
(12, 'Guest', 'ADMIN'),
(13, 'Bebek', 'ADMIN'),
(14, 'Guest', 'ADMIN'),
(15, 'AdhyaksaZ', 'ADMIN');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tr_guest`
--
ALTER TABLE `tr_guest`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tr_guest`
--
ALTER TABLE `tr_guest`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
