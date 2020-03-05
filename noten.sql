-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 05. Mrz 2020 um 20:26
-- Server-Version: 10.4.11-MariaDB
-- PHP-Version: 7.4.2

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
-- Tabellenstruktur für Tabelle `noten`
--

CREATE TABLE `noten` (
  `no_id` int(11) NOT NULL,
  `fa_id` int(11) NOT NULL,
  `sa1` int(11) NOT NULL,
  `sa2` int(11) NOT NULL,
  `sa3` int(11) NOT NULL,
  `ex1` int(11) NOT NULL,
  `ex2` int(11) NOT NULL,
  `ex3` int(11) NOT NULL,
  `ex4` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `noten`
--

INSERT INTO `noten` (`no_id`, `fa_id`, `sa1`, `sa2`, `sa3`, `ex1`, `ex2`, `ex3`, `ex4`) VALUES
(1, 1, 1, 2, 3, 4, 5, 6, 0);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `noten`
--
ALTER TABLE `noten`
  ADD PRIMARY KEY (`no_id`),
  ADD KEY `fa_id` (`fa_id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `noten`
--
ALTER TABLE `noten`
  MODIFY `no_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `noten`
--
ALTER TABLE `noten`
  ADD CONSTRAINT `noten_ibfk_1` FOREIGN KEY (`fa_id`) REFERENCES `fach` (`fa_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
