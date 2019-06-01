-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jun 01, 2019 at 03:39 PM
-- Server version: 5.7.25-log
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
  `name_package` varchar(30) COLLATE utf8mb4_bin NOT NULL,
  `stock` int(20) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `package_list`
--

INSERT INTO `package_list` (`id_package`, `name_package`, `stock`) VALUES
(11111, 'Plastik', 61),
(22222, 'Kertas', 2000);

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
(11111, 'Mikocok Inc'),
(12345, 'Mitoktok Corp');

-- --------------------------------------------------------

--
-- Table structure for table `user_detail`
--

CREATE TABLE `user_detail` (
  `id_user` int(5) NOT NULL,
  `name` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `type` enum('ADMIN','PIC','EMP') COLLATE utf8mb4_bin NOT NULL DEFAULT 'EMP'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Dumping data for table `user_detail`
--

INSERT INTO `user_detail` (`id_user`, `name`, `type`) VALUES
(11111, 'Administrator', 'ADMIN'),
(22222, 'PIC Tester', 'PIC'),
(33333, 'EMP TESTER', 'EMP');

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
(33333, 'emp', 'emp');

-- --------------------------------------------------------

--
-- Table structure for table `wh_production_history`
--

CREATE TABLE `wh_production_history` (
  `wh_ph` int(5) NOT NULL,
  `id_package` int(5) NOT NULL,
  `id_pic` int(5) NOT NULL,
  `id_maintain` int(5) NOT NULL,
  `package_items` int(20) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Table structure for table `wh_receive_history`
--

CREATE TABLE `wh_receive_history` (
  `wh_rh` int(5) NOT NULL,
  `id_package` int(5) NOT NULL,
  `id_supplier` int(5) NOT NULL,
  `id_maintain` int(5) NOT NULL,
  `received` int(20) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

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
  MODIFY `wh_ph` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `wh_receive_history`
--
ALTER TABLE `wh_receive_history`
  MODIFY `wh_rh` int(5) NOT NULL AUTO_INCREMENT;

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
