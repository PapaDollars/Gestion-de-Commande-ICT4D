-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 30, 2022 at 03:45 PM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `produitmiseajours`
--

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE IF NOT EXISTS `client` (
  `cni` int(19) NOT NULL,
  `password` varchar(8) NOT NULL,
  `nom` varchar(25) NOT NULL,
  `prenom` varchar(25) NOT NULL,
  `ville` varchar(15) NOT NULL,
  `tel` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`cni`, `password`, `nom`, `prenom`, `ville`, `tel`) VALUES
(0, '12341234', '', '', '', 0),
(0, '11112222', '', '', '', 0),
(123456789, '1234', 'iya', 'daniel', 'garoua', 696971951),
(987654321, '0000', 'dollars', 'papa', 'yaounde', 690642445),
(123456789, '1234', 'iya', 'daniel', 'garoua', 696971951),
(987654321, '0000', 'dollars', 'papa', 'yaounde', 690642445),
(0, '1111', 'daniel', 'iya', 'dle', 677889988);

-- --------------------------------------------------------

--
-- Table structure for table `produit`
--

CREATE TABLE IF NOT EXISTS `produit` (
  `Reference` varchar(25) NOT NULL,
  `Intitule` varchar(50) NOT NULL,
  `Quantite` float DEFAULT NULL,
  `Prix` float DEFAULT NULL,
  `Categorie` varchar(25) NOT NULL,
  PRIMARY KEY (`Reference`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `produit`
--

INSERT INTO `produit` (`Reference`, `Intitule`, `Quantite`, `Prix`, `Categorie`) VALUES
('prod-1', 'clou', 11, 50700, 'clouterie'),
('prod-2', 'vitre', 43, 5600, 'visserie'),
('prod-3', 'acer', 762, 5500, 'Quincaillerie'),
('prod-4', 'hp', 10, 600, 'Quincaillerie'),
('prod-5', 'test d''un long text pour voir', 1, 10, 'Quincaillerie');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
