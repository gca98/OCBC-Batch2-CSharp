-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 28 Nov 2021 pada 12.56
-- Versi server: 10.1.36-MariaDB
-- Versi PHP: 7.2.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `movies`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `data_movies`
--

CREATE TABLE `data_movies` (
  `id` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Genre` varchar(50) NOT NULL,
  `Duration` varchar(50) NOT NULL,
  `ReleaseDate` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `data_movies`
--

INSERT INTO `data_movies` (`id`, `Name`, `Genre`, `Duration`, `ReleaseDate`) VALUES
(1, 'Bad Boys for Life', 'Action/Comedy', '2 h 5 mins', '2020-01-23 00:00:00'),
(2, 'John Wick', 'Action/Thriller', '1 h 41 mins', '2014-10-24 00:00:00'),
(3, 'The Martian', 'Sci-fi/Drama', '2 h 31 mins', '2015-10-02 00:00:00'),
(4, 'How to Train Your Dragon: The Hidden World', 'Animation/Family', '1 h 45 mins', '2019-02-22 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `data_movies`
--
ALTER TABLE `data_movies`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `data_movies`
--
ALTER TABLE `data_movies`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
