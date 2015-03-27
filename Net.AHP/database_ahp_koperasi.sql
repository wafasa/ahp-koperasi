-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.5.27 - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             8.0.0.4396
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for ahp_koperasi
DROP DATABASE IF EXISTS `ahp_koperasi`;
CREATE DATABASE IF NOT EXISTS `ahp_koperasi` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `ahp_koperasi`;


-- Dumping structure for table ahp_koperasi.tbl_anggota
DROP TABLE IF EXISTS `tbl_anggota`;
CREATE TABLE IF NOT EXISTS `tbl_anggota` (
  `kode` int(10) NOT NULL AUTO_INCREMENT,
  `nama` varchar(50) DEFAULT NULL,
  `alamat` text,
  `telp` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`kode`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

-- Dumping data for table ahp_koperasi.tbl_anggota: ~6 rows (approximately)
/*!40000 ALTER TABLE `tbl_anggota` DISABLE KEYS */;
INSERT INTO `tbl_anggota` (`kode`, `nama`, `alamat`, `telp`) VALUES
	(1, 'jendral', 'xxx', 'xxx'),
	(2, 'debie', 'xxxxxxxx', 'xxxxxxxxxxx'),
	(3, 'jhon', 'xxx', 'xxx'),
	(4, 'brewok', 'xxxx', '12345'),
	(5, 'pk anam', 'bwi', '098xxx'),
	(6, 'andy', 'bwi', '000');
/*!40000 ALTER TABLE `tbl_anggota` ENABLE KEYS */;


-- Dumping structure for table ahp_koperasi.tbl_anggota_kriteria_items
DROP TABLE IF EXISTS `tbl_anggota_kriteria_items`;
CREATE TABLE IF NOT EXISTS `tbl_anggota_kriteria_items` (
  `kode` int(10) NOT NULL AUTO_INCREMENT,
  `kode_anggota` int(10) DEFAULT NULL,
  `kode_kriteria` int(10) DEFAULT NULL,
  `kode_kriteria_item` int(10) DEFAULT NULL,
  PRIMARY KEY (`kode`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

-- Dumping data for table ahp_koperasi.tbl_anggota_kriteria_items: ~30 rows (approximately)
/*!40000 ALTER TABLE `tbl_anggota_kriteria_items` DISABLE KEYS */;
INSERT INTO `tbl_anggota_kriteria_items` (`kode`, `kode_anggota`, `kode_kriteria`, `kode_kriteria_item`) VALUES
	(1, 1, 1, 3),
	(2, 1, 2, 8),
	(3, 1, 4, 20),
	(4, 1, 6, 25),
	(5, 1, 7, 31),
	(6, 2, 1, 1),
	(7, 2, 2, 9),
	(8, 2, 4, 20),
	(9, 2, 6, 26),
	(10, 2, 7, 32),
	(11, 3, 1, 3),
	(12, 3, 2, 7),
	(13, 3, 4, 19),
	(14, 3, 6, 27),
	(15, 3, 7, 31),
	(16, 4, 1, 1),
	(17, 4, 2, 9),
	(18, 4, 4, 19),
	(19, 4, 6, 26),
	(20, 4, 7, 31),
	(21, 5, 1, 1),
	(22, 5, 2, 9),
	(23, 5, 4, 19),
	(24, 5, 6, 30),
	(25, 5, 7, 32),
	(26, 6, 1, 1),
	(27, 6, 2, 7),
	(28, 6, 4, 20),
	(29, 6, 6, 26),
	(30, 6, 7, 31);
/*!40000 ALTER TABLE `tbl_anggota_kriteria_items` ENABLE KEYS */;


-- Dumping structure for table ahp_koperasi.tbl_kriteria
DROP TABLE IF EXISTS `tbl_kriteria`;
CREATE TABLE IF NOT EXISTS `tbl_kriteria` (
  `kode` int(10) NOT NULL AUTO_INCREMENT,
  `nama` varchar(50) DEFAULT NULL,
  `aktif` enum('True','False') DEFAULT NULL,
  PRIMARY KEY (`kode`),
  UNIQUE KEY `nama` (`nama`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- Dumping data for table ahp_koperasi.tbl_kriteria: ~5 rows (approximately)
/*!40000 ALTER TABLE `tbl_kriteria` DISABLE KEYS */;
INSERT INTO `tbl_kriteria` (`kode`, `nama`, `aktif`) VALUES
	(1, 'PEKERJAAN', 'True'),
	(2, 'PENGHASILAN', 'True'),
	(4, 'TANGGUNGAN DI BANK LAIN', 'True'),
	(6, 'USIA', 'True'),
	(7, 'JAMINAN', 'True');
/*!40000 ALTER TABLE `tbl_kriteria` ENABLE KEYS */;


-- Dumping structure for table ahp_koperasi.tbl_kriteria_bobot
DROP TABLE IF EXISTS `tbl_kriteria_bobot`;
CREATE TABLE IF NOT EXISTS `tbl_kriteria_bobot` (
  `kode_a` int(10) DEFAULT NULL,
  `kode_b` int(10) DEFAULT NULL,
  `nilai` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table ahp_koperasi.tbl_kriteria_bobot: ~25 rows (approximately)
/*!40000 ALTER TABLE `tbl_kriteria_bobot` DISABLE KEYS */;
INSERT INTO `tbl_kriteria_bobot` (`kode_a`, `kode_b`, `nilai`) VALUES
	(1, 1, 1),
	(1, 2, 0.5),
	(1, 4, 2),
	(1, 6, 3),
	(1, 7, 2),
	(2, 1, 0),
	(2, 2, 1),
	(2, 4, 3),
	(2, 6, 4),
	(2, 7, 4),
	(4, 1, 0),
	(4, 2, 0),
	(4, 4, 1),
	(4, 6, 2),
	(4, 7, 0.25),
	(6, 1, 0),
	(6, 2, 0),
	(6, 4, 0),
	(6, 6, 1),
	(6, 7, 0.5),
	(7, 1, 0),
	(7, 2, 0),
	(7, 4, 0),
	(7, 6, 0),
	(7, 7, 1);
/*!40000 ALTER TABLE `tbl_kriteria_bobot` ENABLE KEYS */;


-- Dumping structure for table ahp_koperasi.tbl_kriteria_items
DROP TABLE IF EXISTS `tbl_kriteria_items`;
CREATE TABLE IF NOT EXISTS `tbl_kriteria_items` (
  `kode` int(10) NOT NULL AUTO_INCREMENT,
  `kode_kriteria` int(10) DEFAULT NULL,
  `nama` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`kode`),
  UNIQUE KEY `kode_kriteria_nama` (`kode_kriteria`,`nama`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=latin1;

-- Dumping data for table ahp_koperasi.tbl_kriteria_items: ~16 rows (approximately)
/*!40000 ALTER TABLE `tbl_kriteria_items` DISABLE KEYS */;
INSERT INTO `tbl_kriteria_items` (`kode`, `kode_kriteria`, `nama`) VALUES
	(33, 1, 'PENSIUNAN'),
	(3, 1, 'PNS'),
	(1, 1, 'SWASTA'),
	(7, 2, '<= 1.5 JUTA'),
	(8, 2, '> 1.5 JUTA - 3 JUTA'),
	(9, 2, '> 3 JUTA'),
	(19, 4, 'ADA'),
	(20, 4, 'TIDAK ADA'),
	(24, 5, '>= 4 ANAK'),
	(25, 6, '18 - 25 TH'),
	(26, 6, '25 - 30 TH'),
	(27, 6, '30 - 35 TH'),
	(29, 6, '35 - 40 TH'),
	(30, 6, '40 - 45 TH'),
	(32, 7, 'BPKB'),
	(31, 7, 'SERTIFIKAT');
/*!40000 ALTER TABLE `tbl_kriteria_items` ENABLE KEYS */;


-- Dumping structure for table ahp_koperasi.tbl_kriteria_items_bobot
DROP TABLE IF EXISTS `tbl_kriteria_items_bobot`;
CREATE TABLE IF NOT EXISTS `tbl_kriteria_items_bobot` (
  `kode_a` int(10) DEFAULT NULL,
  `kode_b` int(10) DEFAULT NULL,
  `nilai` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table ahp_koperasi.tbl_kriteria_items_bobot: ~49 rows (approximately)
/*!40000 ALTER TABLE `tbl_kriteria_items_bobot` DISABLE KEYS */;
INSERT INTO `tbl_kriteria_items_bobot` (`kode_a`, `kode_b`, `nilai`) VALUES
	(0, 0, 1),
	(21, 24, 4),
	(24, 24, 1),
	(7, 7, 1),
	(7, 8, 0.5),
	(7, 9, 0.3),
	(8, 7, 0),
	(8, 8, 1),
	(8, 9, 0.5),
	(9, 7, 0),
	(9, 8, 0),
	(9, 9, 1),
	(19, 19, 1),
	(19, 20, 0.5),
	(20, 19, 0),
	(20, 20, 1),
	(1, 1, 1),
	(1, 3, 0.5),
	(3, 1, 0),
	(3, 3, 1),
	(25, 25, 1),
	(25, 26, 2),
	(25, 27, 3),
	(25, 29, 4),
	(25, 30, 5),
	(26, 25, 0),
	(26, 26, 1),
	(26, 27, 2),
	(26, 29, 3),
	(26, 30, 4),
	(27, 25, 0),
	(27, 26, 0),
	(27, 27, 1),
	(27, 29, 2),
	(27, 30, 3),
	(29, 25, 0),
	(29, 26, 0),
	(29, 27, 0),
	(29, 29, 1),
	(29, 30, 2),
	(30, 25, 0),
	(30, 26, 0),
	(30, 27, 0),
	(30, 29, 0),
	(30, 30, 1),
	(31, 31, 1),
	(31, 32, 2),
	(32, 31, 0),
	(32, 32, 1);
/*!40000 ALTER TABLE `tbl_kriteria_items_bobot` ENABLE KEYS */;


-- Dumping structure for table ahp_koperasi.temp_proses
DROP TABLE IF EXISTS `temp_proses`;
CREATE TABLE IF NOT EXISTS `temp_proses` (
  `kode_a` int(10) DEFAULT NULL,
  `kode_b` int(10) DEFAULT NULL,
  `nilai` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table ahp_koperasi.temp_proses: ~0 rows (approximately)
/*!40000 ALTER TABLE `temp_proses` DISABLE KEYS */;
/*!40000 ALTER TABLE `temp_proses` ENABLE KEYS */;


-- Dumping structure for table ahp_koperasi.user
DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `kode` int(10) NOT NULL AUTO_INCREMENT,
  `nama` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`kode`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Dumping data for table ahp_koperasi.user: ~1 rows (approximately)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`kode`, `nama`, `password`) VALUES
	(1, 'trias', 'trias');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
