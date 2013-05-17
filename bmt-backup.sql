-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 17, 2013 at 07:12 PM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bmt-backup`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_detailrentalagreement`
--

CREATE TABLE IF NOT EXISTS `tbl_detailrentalagreement` (
  `id_rentalagreement` varchar(15) NOT NULL,
  `id_category` varchar(6) NOT NULL,
  `id_subcategory` varchar(6) NOT NULL,
  `price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_detailrentalagreement`
--

INSERT INTO `tbl_detailrentalagreement` (`id_rentalagreement`, `id_category`, `id_subcategory`, `price`) VALUES
('RAB001/E13.0001', 'CAT001', 'SUB001', 10000),
('RAB001/E13.0002', 'CAT001', 'SUB001', 10000),
('RAB001/E13.0002', 'CAT001', 'SUB002', 2000),
('RAB001/E13.0002', 'CAT001', 'SUB003', 30000),
('RAB001/E13.0003', 'CAT001', 'SUB001', 10000),
('RAB001/E13.0003', 'CAT001', 'SUB002', 20000),
('RAB001/E13.0004', 'CAT001', 'SUB001', 10000),
('RAB001/E13.0004', 'CAT002', 'SUB010', 20000),
('RAB001/E13.0005', 'CAT001', 'SUB001', 10000),
('RAB001/E13.0005', 'CAT001', 'SUB002', 20000),
('RAB001/E13.0006', 'CAT001', 'SUB001', 10000),
('RAB001/E13.0006', 'CAT001', 'SUB002', 20000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_detailrentalreceipt`
--

CREATE TABLE IF NOT EXISTS `tbl_detailrentalreceipt` (
  `id_rentalreceipt` varchar(16) NOT NULL,
  `id_category` varchar(6) NOT NULL,
  `id_subcategory` varchar(6) NOT NULL,
  `brand` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `remark` varchar(255) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_trrentalagreement`
--

CREATE TABLE IF NOT EXISTS `tbl_trrentalagreement` (
  `id` varchar(15) NOT NULL,
  `id_customer` varchar(6) NOT NULL,
  `created_date` datetime NOT NULL,
  `agreement_date` datetime NOT NULL,
  `cut_off_date` int(11) NOT NULL,
  `reference` varchar(50) NOT NULL,
  `created_by` varchar(6) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_trrentalagreement`
--

INSERT INTO `tbl_trrentalagreement` (`id`, `id_customer`, `created_date`, `agreement_date`, `cut_off_date`, `reference`, `created_by`, `status`) VALUES
('RAB001/E13.0003', 'CUS001', '2013-05-06 14:17:13', '2013-05-06 14:16:13', 0, 'NONE', 'SLS002', 'INACTIVE'),
('RAB001/E13.0004', 'CUS007', '2013-05-06 15:08:04', '2013-05-06 15:07:24', 25, 'NONE', 'SLS002', 'ACTIVE'),
('RAB001/E13.0005', 'CUS001', '2013-05-16 18:12:16', '2013-05-16 18:11:58', 25, 'NONE', 'SLS002', 'ACTIVE'),
('RAB001/E13.0006', 'CUS001', '2013-05-16 18:20:34', '2013-05-16 18:20:21', 25, 'REF', 'SLS002', 'ACTIVE');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_trrentalreceipt`
--

CREATE TABLE IF NOT EXISTS `tbl_trrentalreceipt` (
  `id` varchar(16) NOT NULL,
  `id_rentalagreement` varchar(15) NOT NULL,
  `created_date` datetime NOT NULL,
  `receipt_date` datetime NOT NULL,
  `reference` varchar(255) NOT NULL,
  `created_by` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
