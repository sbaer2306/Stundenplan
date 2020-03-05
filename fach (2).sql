-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 06. Mrz 2020 um 00:15
-- Server-Version: 10.4.11-MariaDB
-- PHP-Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `stundenplan`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fach`
--

CREATE TABLE `fach` (
  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `lehrer` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `raum` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `kontakt` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `fa_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Daten für Tabelle `fach`
--

INSERT INTO `fach` (`name`, `lehrer`, `raum`, `kontakt`, `fa_id`) VALUES
('deutsch', 'deutschlehrer', '103', 'asd', 1),
('mathe', 'mathelehrer', '104', 'asd', 2),
('chemie', 'chemielehrer', '106', 'assa', 3),
('', '', '', '', 4),
('', '', '', '', 5),
('', '', '', '', 6),
('', '', '', '', 7);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `fach`
--
ALTER TABLE `fach`
  ADD PRIMARY KEY (`fa_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
