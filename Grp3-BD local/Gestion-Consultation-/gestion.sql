-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : jeu. 20 jan. 2022 à 12:15
-- Version du serveur :  10.4.19-MariaDB
-- Version de PHP : 8.0.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gestion`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `cni` varchar(10) NOT NULL,
  `nom` varchar(255) NOT NULL,
  `prenom` varchar(255) NOT NULL,
  `ville` varchar(255) NOT NULL,
  `telephone` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`cni`, `nom`, `prenom`, `ville`, `telephone`) VALUES
('2K17', 'franck', 'judes', 'Yaounde', '652520390'),
('2K15', 'Innocent', 'Njie', 'Garoua', '691601366');

-- --------------------------------------------------------

--
-- Structure de la table `commande`
--

CREATE TABLE `commande` (
  `num_com` varchar(225) NOT NULL,
  `cni` varchar(21) NOT NULL,
  `date` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `commande`
--

INSERT INTO `commande` (`num_com`, `cni`, `date`) VALUES
('1', '2k17', '2022-12-02'),
('2', '2k18', '2022-01-11');

-- --------------------------------------------------------

--
-- Structure de la table `produit`
--

CREATE TABLE `produit` (
  `num_com` varchar(225) NOT NULL,
  `reference` varchar(100) NOT NULL,
  `intitule` varchar(60) NOT NULL,
  `categorie` varchar(60) NOT NULL,
  `quantite` int(200) DEFAULT NULL,
  `prix` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `produit`
--

INSERT INTO `produit` (`num_com`, `reference`, `intitule`, `categorie`, `quantite`, `prix`) VALUES
('1', 'pointe', 'clou', 'clouterie', 110, '66000'),
('2', '//', 'Dangote', 'Ciment', 110, '120000'),
('1', 'P1', 'clou', 'Clouterie', 17, '2000'),
('1', 'P2', 'Dangote', 'Ciment', 2, '12000');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
