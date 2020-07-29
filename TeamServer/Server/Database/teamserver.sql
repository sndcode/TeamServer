-- phpMyAdmin SQL Dump
-- version 4.2.12deb2+deb8u2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jul 27, 2020 at 04:11 PM
-- Server version: 5.5.62-0+deb8u1
-- PHP Version: 7.3.19-1+0~20200612.60+debian8~1.gbp6c8fe1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `teamserver`
--

-- --------------------------------------------------------

--
-- Table structure for table `termine_chris`
--

CREATE TABLE IF NOT EXISTS `termine_chris` (
  `day` varchar(255) NOT NULL,
  `user` varchar(256) NOT NULL,
  `context` varchar(256) NOT NULL,
  `prio` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `termine_chris`
--

INSERT INTO `termine_chris` (`day`, `user`, `context`, `prio`) VALUES
('montag', 'chris', 'Ganzer Tag :\nBuero\n\nRevision UM', ''),
('dienstag', 'chris', 'Ganzer Tag :\nBuero\n\nRevision UM', ''),
('mittwoch', 'chris', 'Ganzer Tag :\n\nAuÃƒÅ¸endienst', ''),
('donnerstag', 'chris', 'Ganzer Tag :\nBuero\n\nRevision UM', ''),
('freitag', 'chris', 'Ganzer Tag :\nBuero\n\nRevision UM', ''),
('prio1', 'chris', 'Revision UM', '1');

-- --------------------------------------------------------

--
-- Table structure for table `termine_maurice`
--

CREATE TABLE IF NOT EXISTS `termine_maurice` (
  `day` varchar(20) NOT NULL,
  `user` varchar(256) NOT NULL,
  `context` varchar(256) NOT NULL,
  `prio` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `termine_maurice`
--

INSERT INTO `termine_maurice` (`day`, `user`, `context`, `prio`) VALUES
('montag', 'maurice', 'Ganzer Tag :\nBuero', ''),
('dienstag', 'maurice', 'Ganzer Tag :\nBuero', ''),
('mittwoch', 'maurice', 'Morgens :\nBuero', ''),
('donnerstag', 'maurice', 'Ganzer Tag :\nBuero', ''),
('freitag', 'maurice', 'Ganzer Tag :\nBuero', ''),
('prio1', 'maurice', 'Planung Vodafone\n\nPlanung NC', '');

-- --------------------------------------------------------

--
-- Table structure for table `termine_max`
--

CREATE TABLE IF NOT EXISTS `termine_max` (
  `day` varchar(20) NOT NULL,
  `user` varchar(256) NOT NULL,
  `context` varchar(256) NOT NULL,
  `prio` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `termine_max`
--

INSERT INTO `termine_max` (`day`, `user`, `context`, `prio`) VALUES
('montag', 'max', 'Ganzer Tag :\nBuero', ''),
('dienstag', 'max', 'Ganzer Tag :\nBuero', ''),
('mittwoch', 'max', 'Morgens :\nBuero', ''),
('donnerstag', 'max', 'Ganzer Tag :\nBuero', ''),
('freitag', 'max', 'Ganzer Tag :\nBuero', ''),
('prio1', 'max', 'HSI', '');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`name`) VALUES
('maurice'),
('chris'),
('max'),
('herbert');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `termine_chris`
--
ALTER TABLE `termine_chris`
 ADD PRIMARY KEY (`day`);

--
-- Indexes for table `termine_maurice`
--
ALTER TABLE `termine_maurice`
 ADD PRIMARY KEY (`day`);

--
-- Indexes for table `termine_max`
--
ALTER TABLE `termine_max`
 ADD PRIMARY KEY (`day`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
