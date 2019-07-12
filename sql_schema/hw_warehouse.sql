-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jul 12, 2019 at 08:47 AM
-- Server version: 5.7.26-log
-- PHP Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hw_warehouse`
--

-- --------------------------------------------------------

--
-- Table structure for table `package_list`
--

CREATE TABLE `package_list` (
  `id_package` int(5) NOT NULL,
  `name_package` varchar(50) COLLATE utf8mb4_bin NOT NULL,
  `stock` int(20) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `package_list`
--

INSERT INTO `package_list` (`id_package`, `name_package`, `stock`) VALUES
(10000, 'LED 5v-22w', 0),
(10001, 'Printed Circuit 5cmX50cm', 1351),
(10002, 'Evaporator 22ds', 2031),
(10003, 'Yokohama IC 22v', 435),
(10004, 'Tegra X7 ,@2Ghz', 5236),
(10005, 'Intermitted Receiver for NSW', 85),
(10006, 'ConrtolROD v2 22KG', 0),
(10007, 'U-235 Purified', 1000),
(11111, 'Plastik', 0),
(22222, 'Kertas', 900);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id_supplier` int(5) NOT NULL,
  `name_supplier` varchar(30) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id_supplier`, `name_supplier`) VALUES
(0, 'High Energy Stargazer Inc'),
(1, '日本電撃オンラインースタゲート'),
(10000, 'Research Motion Inc'),
(10001, 'NVIDIA Corporation Global'),
(10002, 'Nintendon'),
(10003, 'Philips Jpn Group'),
(10004, 'MC Arthur Corp Ltd'),
(11111, 'Mikocok Inc'),
(12345, 'Mitoktok Corp'),
(22222, 'Mikrotech Co.Ltd');

-- --------------------------------------------------------

--
-- Table structure for table `user_detail`
--

CREATE TABLE `user_detail` (
  `id_user` int(5) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `type` enum('ADMIN','PIC','EMP') COLLATE utf8mb4_bin NOT NULL DEFAULT 'EMP',
  `departement` varchar(30) COLLATE utf8mb4_bin NOT NULL DEFAULT 'not defined',
  `description` varchar(40) COLLATE utf8mb4_bin NOT NULL DEFAULT 'Fly to sky not restricted by boundary\\n'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `user_detail`
--

INSERT INTO `user_detail` (`id_user`, `name`, `type`, `departement`, `description`) VALUES
(11111, 'Administrator', 'ADMIN', 'not defined', 'Fly to sky not restricted by boundary\\n'),
(22222, 'PIC Tester', 'PIC', 'not defined', 'Fly to sky not restricted by boundary\\n'),
(33333, 'EMP TESTER', 'EMP', 'not defined', 'Fly to sky not restricted by boundary\\n'),
(55555, 'ニャンコ(Nyanko)', 'ADMIN', 'not defined', 'Fly to sky not restricted by boundary\\n'),
(44444, 'エレーナ(Elena)', 'PIC', 'not defined', 'Fly to sky not restricted by boundary\\n');

-- --------------------------------------------------------

--
-- Table structure for table `user_list`
--

CREATE TABLE `user_list` (
  `id_user` int(5) NOT NULL,
  `username` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `password` varchar(20) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `user_list`
--

INSERT INTO `user_list` (`id_user`, `username`, `password`) VALUES
(11111, 'admin', 'admin'),
(22222, 'pic', 'pic'),
(33333, 'emp', 'emp'),
(44444, 'elena', 'elena'),
(55555, 'nyanko', 'nyanko');

-- --------------------------------------------------------

--
-- Table structure for table `wh_production_history`
--

CREATE TABLE `wh_production_history` (
  `wh_ph` int(5) NOT NULL,
  `id_package` int(5) NOT NULL,
  `id_pic` int(5) NOT NULL,
  `id_maintain` int(5) NOT NULL,
  `package_items` int(20) NOT NULL DEFAULT '0',
  `datetime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `wh_production_history`
--

INSERT INTO `wh_production_history` (`wh_ph`, `id_package`, `id_pic`, `id_maintain`, `package_items`, `datetime`) VALUES
(3, 10004, 11111, 55555, 650, '2019-07-01 00:00:00'),
(4, 10004, 11111, 55555, 5, '2019-07-01 00:00:00'),
(5, 10004, 11111, 55555, 5, '2019-07-02 00:00:00'),
(6, 10003, 11111, 55555, 5, '2019-07-03 00:00:00'),
(7, 10003, 11111, 55555, 5, '2019-07-04 00:00:00'),
(8, 10003, 11111, 55555, 5, '2019-07-05 00:00:00'),
(9, 10005, 11111, 55555, 5, '2019-07-06 00:00:00'),
(10, 10005, 11111, 55555, 5, '2019-07-07 00:00:00'),
(12, 10005, 11111, 55555, 5, '2019-07-08 00:00:00'),
(13, 10001, 33333, 44444, 200, '2019-07-11 00:00:00'),
(14, 10001, 11111, 22222, 100, '2019-07-12 02:06:22'),
(16, 22222, 44444, 11111, 100, '2019-07-12 14:35:32'),
(17, 10007, 44444, 11111, 123, '2019-07-12 15:38:50');

-- --------------------------------------------------------

--
-- Table structure for table `wh_receive_history`
--

CREATE TABLE `wh_receive_history` (
  `wh_rh` int(5) NOT NULL,
  `id_package` int(5) NOT NULL,
  `id_supplier` int(5) NOT NULL,
  `id_maintain` int(5) NOT NULL,
  `received` int(20) NOT NULL DEFAULT '0',
  `date` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `wh_receive_history`
--

INSERT INTO `wh_receive_history` (`wh_rh`, `id_package`, `id_supplier`, `id_maintain`, `received`, `date`) VALUES
(1, 10005, 10004, 55555, 100, '2019-07-02 00:00:00'),
(4, 10004, 10001, 55555, 5000, '2019-07-03 00:00:00'),
(5, 10004, 10001, 55555, 250, '2019-07-03 00:00:00'),
(6, 10004, 10001, 55555, 150, '2019-07-04 00:00:00'),
(7, 10003, 10003, 44444, 250, '2019-07-04 00:00:00'),
(8, 10004, 10003, 44444, 250, '2019-07-05 00:00:00'),
(9, 10002, 10003, 44444, 250, '2019-07-06 00:00:00'),
(10, 10002, 10003, 44444, 125, '2019-07-06 00:00:00'),
(11, 10004, 10000, 55555, 123, '2019-07-07 00:00:00'),
(12, 10004, 11111, 55555, 123, '2019-07-08 00:00:00'),
(13, 10007, 1, 11111, 123, '2019-07-09 00:00:00'),
(14, 10001, 0, 11111, 123, '2019-07-09 00:00:00'),
(15, 10007, 1, 11111, 1000, '2019-07-12 00:00:00'),
(16, 10001, 0, 11111, 100, '2019-07-12 00:00:00'),
(17, 10002, 0, 11111, 2000, '2019-07-12 14:18:16'),
(18, 10001, 0, 11111, 2000, '2019-07-12 14:18:40'),
(19, 22222, 10002, 11111, 1000, '2019-07-12 14:35:14');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `package_list`
--
ALTER TABLE `package_list`
  ADD PRIMARY KEY (`id_package`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indexes for table `user_detail`
--
ALTER TABLE `user_detail`
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `user_list`
--
ALTER TABLE `user_list`
  ADD PRIMARY KEY (`id_user`);

--
-- Indexes for table `wh_production_history`
--
ALTER TABLE `wh_production_history`
  ADD PRIMARY KEY (`wh_ph`),
  ADD KEY `id_package` (`id_package`),
  ADD KEY `id_pic` (`id_pic`),
  ADD KEY `id_maintain` (`id_maintain`);

--
-- Indexes for table `wh_receive_history`
--
ALTER TABLE `wh_receive_history`
  ADD PRIMARY KEY (`wh_rh`),
  ADD KEY `id_package` (`id_package`),
  ADD KEY `id_supplier` (`id_supplier`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `wh_production_history`
--
ALTER TABLE `wh_production_history`
  MODIFY `wh_ph` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `wh_receive_history`
--
ALTER TABLE `wh_receive_history`
  MODIFY `wh_rh` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `user_detail`
--
ALTER TABLE `user_detail`
  ADD CONSTRAINT `user_detail_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `user_list` (`id_user`);

--
-- Constraints for table `wh_production_history`
--
ALTER TABLE `wh_production_history`
  ADD CONSTRAINT `wh_production_history_ibfk_1` FOREIGN KEY (`id_package`) REFERENCES `package_list` (`id_package`),
  ADD CONSTRAINT `wh_production_history_ibfk_2` FOREIGN KEY (`id_pic`) REFERENCES `user_list` (`id_user`),
  ADD CONSTRAINT `wh_production_history_ibfk_3` FOREIGN KEY (`id_maintain`) REFERENCES `user_list` (`id_user`);

--
-- Constraints for table `wh_receive_history`
--
ALTER TABLE `wh_receive_history`
  ADD CONSTRAINT `wh_receive_history_ibfk_1` FOREIGN KEY (`id_supplier`) REFERENCES `supplier` (`id_supplier`),
  ADD CONSTRAINT `wh_receive_history_ibfk_2` FOREIGN KEY (`id_package`) REFERENCES `package_list` (`id_package`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
