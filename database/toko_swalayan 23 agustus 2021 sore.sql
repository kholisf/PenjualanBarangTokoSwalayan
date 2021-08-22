-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 22, 2021 at 10:35 AM
-- Server version: 5.6.20
-- PHP Version: 5.5.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `toko_swalayan`
--

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE IF NOT EXISTS `barang` (
  `KodeBarang` char(10) NOT NULL,
  `NamaBarang` varchar(100) NOT NULL,
  `Kategori` varchar(50) NOT NULL,
  `Satuan` varchar(50) NOT NULL DEFAULT '',
  `HargaBeli` double NOT NULL,
  `HargaJual` double NOT NULL,
  `Stok` int(11) NOT NULL,
  `Kedaluwarsa` date NOT NULL,
  `Keterangan` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`KodeBarang`, `NamaBarang`, `Kategori`, `Satuan`, `HargaBeli`, `HargaJual`, `Stok`, `Kedaluwarsa`, `Keterangan`) VALUES
('0000000000', 'DATA BARANG TELAH DI HAPUS', '', '', 0, 0, 0, '0000-00-00', ''),
('BRG0000001', 'Pepsoden ', 'pasta gigi', 'gram', 3000, 4000, 30, '2023-07-04', ''),
('BRG0000002', 'Formula', 'Alat Mandi', 'PCS', 3500, 4000, 40, '2021-07-04', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!! ::cobas sekali doang'),
('BRG0000004', 'Indomie Goreng', 'makan instan', 'pcs', 2500, 3000, 68, '2021-10-30', ''),
('BRG0000005', 'Bimoli', 'Minyak Goreng', 'Liter', 11000, 12000, 20, '2021-07-10', ''),
('BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', 20000, 24300, 19, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('BRG0000007', 'sari roti', 'roti', 'PCS', 11000, 12500, 26, '2021-10-31', 'rotii'),
('BRG0000008', 'madu', 'makan', 'Liter', 10000, 11000, 35, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('BRG0000009', 'beras', 'Bahan Pokok', 'kg', 10000, 11000, 28, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('BRG0000010', 'minyak goreng', 'Bahan Pokok', 'Liter', 12000, 13000, 15, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, ');

--
-- Triggers `barang`
--
DELIMITER //
CREATE TRIGGER `DeleteBarang` BEFORE DELETE ON `barang`
 FOR EACH ROW insert into barang_log values(sysdate(),current_user,'Hapus Record',old.KodeBarang,old.NamaBarang,old.Kategori,old.Satuan,old.HargaBeli,old.HargaJual,old.Stok,old.Kedaluwarsa,old.Keterangan)
//
DELIMITER ;
DELIMITER //
CREATE TRIGGER `InsertBarang` BEFORE INSERT ON `barang`
 FOR EACH ROW insert into barang_log values(sysdate(),current_user,'Tambah Record',new.KodeBarang,new.NamaBarang,new.Kategori,new.Satuan,new.HargaBeli,new.HargaJual,new.Stok,new.Kedaluwarsa,new.Keterangan)
//
DELIMITER ;
DELIMITER //
CREATE TRIGGER `UpdateBarang` BEFORE UPDATE ON `barang`
 FOR EACH ROW insert into barang_log values(sysdate(),current_user,'Ubah Record',old.KodeBarang,old.NamaBarang,old.Kategori,old.Satuan,old.HargaBeli,old.HargaJual,old.Stok,old.Kedaluwarsa,old.Keterangan)
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `barang_log`
--

CREATE TABLE IF NOT EXISTS `barang_log` (
  `TanggalTrigger` date NOT NULL,
  `UserTrigger` varchar(250) NOT NULL,
  `Informasi Trigger` varchar(250) NOT NULL,
  `KodeBarang` char(10) NOT NULL,
  `NamaBarang` varchar(100) NOT NULL,
  `Kategori` varchar(50) NOT NULL,
  `Satuan` varchar(50) NOT NULL,
  `HargaBeli` date NOT NULL,
  `HargaJual` double NOT NULL,
  `Stok` int(11) NOT NULL,
  `Kedaluwarsa` date NOT NULL,
  `Keterangan` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `barang_log`
--

INSERT INTO `barang_log` (`TanggalTrigger`, `UserTrigger`, `Informasi Trigger`, `KodeBarang`, `NamaBarang`, `Kategori`, `Satuan`, `HargaBeli`, `HargaJual`, `Stok`, `Kedaluwarsa`, `Keterangan`) VALUES
('2021-07-11', 'root@localhost', 'Tambah Record', 'BRG0000007', '1', '2', '2', '0000-00-00', 2, 2, '2021-07-11', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, 2'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000007', '1', '2', '2', '0000-00-00', 2, 2, '2021-07-11', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, 2'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000007', '1', '2', '2', '0000-00-00', 2, 3, '2021-07-11', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, 2iowqeq'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 48, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000005', 'Bimoli', 'Minyak Goreng', 'Liter', '2001-10-00', 12000, 50, '2021-07-10', ''),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000001', 'Pepsoden ', 'pasta gigi', 'gram', '0000-00-00', 4000, 7, '2023-07-04', ''),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 46, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000004', 'mie instan', 'makan instan', 'pcs', '0000-00-00', 3000, 48, '2021-07-09', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, iueqoiwueoiqwueoiqw'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 36, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000004', 'mie instan', 'makan instan', 'pcs', '0000-00-00', 3000, 88, '2021-07-09', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, iueqoiwueoiqwueoiqw'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000001', 'Pepsoden ', 'pasta gigi', 'gram', '0000-00-00', 4000, 0, '2023-07-04', ''),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 40, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 30, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000005', 'Bimoli', 'Minyak Goreng', 'Liter', '2001-10-00', 12000, 45, '2021-07-10', ''),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000002', 'Formula', 'Alat Mandi', 'PCS', '0000-00-00', 4000, 53, '2021-07-04', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!! ::cobas sekali doang'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 20, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-07-11', 'root@localhost', 'Ubah Record', 'BRG0000005', 'Bimoli', 'Minyak Goreng', 'Liter', '2001-10-00', 12000, 35, '2021-07-10', ''),
('2021-07-21', 'root@localhost', 'Hapus Record', 'BRG0000007', '1', '2', '2', '0000-00-00', 2, 0, '2021-07-11', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, 2iowqeq'),
('2021-07-21', 'root@localhost', 'Ubah Record', 'BRG0000004', 'mie instan', 'makan instan', 'pcs', '0000-00-00', 3000, 90, '2021-07-09', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, iueqoiwueoiqwueoiqw'),
('2021-07-21', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 18, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-07-21', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 15, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-07-21', 'root@localhost', 'Ubah Record', 'BRG0000005', 'Bimoli', 'Minyak Goreng', 'Liter', '2001-10-00', 12000, 33, '2021-07-10', ''),
('2021-07-22', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 30, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-08-05', 'root@localhost', 'Ubah Record', 'BRG0000005', 'Bimoli', 'Minyak Goreng', 'Liter', '2001-10-00', 12000, 35, '2021-07-10', ''),
('2021-08-05', 'root@localhost', 'Ubah Record', 'BRG0000004', 'mie instan', 'makan instan', 'pcs', '0000-00-00', 3000, 87, '2021-07-09', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, iueqoiwueoiqwueoiqw'),
('2021-08-06', 'root@localhost', 'Tambah Record', 'BRG0000007', 'mie sedap', 'Mie Instan', 'Bunkus', '0000-00-00', 3000, 0, '2022-01-01', ''),
('2021-08-06', 'root@localhost', 'Ubah Record', 'BRG0000007', 'mie sedap', 'Mie Instan', 'Bunkus', '0000-00-00', 3000, 0, '2022-01-01', ''),
('2021-08-09', 'root@localhost', 'Tambah Record', 'DIHAPUS', '', '', '', '0000-00-00', 0, 0, '0000-00-00', ''),
('2021-08-09', 'root@localhost', 'Hapus Record', 'BRG0000007', 'mie sedap', 'Mie Instan', 'Bunkus', '0000-00-00', 3000, 10, '2022-01-01', ''),
('2021-08-09', 'root@localhost', 'Ubah Record', 'DIHAPUS', '', '', '', '0000-00-00', 0, 0, '0000-00-00', ''),
('2021-08-09', 'root@localhost', 'Ubah Record', 'BRG0000004', 'mie instan', 'makan instan', 'pcs', '0000-00-00', 3000, 83, '2021-07-09', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, iueqoiwueoiqwueoiqw'),
('2021-08-10', 'root@localhost', 'Ubah Record', 'DIHAPUS', 'DATA BARANG TELAH DI HAPUS', '', '', '0000-00-00', 0, 0, '0000-00-00', ''),
('2021-08-10', 'root@localhost', 'Tambah Record', 'BRG0000007', '2', '3', '4', '0000-00-00', 1, 1, '2021-08-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-10', 'root@localhost', 'Ubah Record', 'BRG0000007', '2', '3', '4', '0000-00-00', 1, 1, '2021-08-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-10', 'root@localhost', 'Hapus Record', 'BRG0000007', '2', '3', '4', '0000-00-00', 1, 3, '2021-08-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-19', 'root@localhost', 'Tambah Record', 'BRG0000007', 'sari roti', 'roti', 'PCS', '2001-10-00', 12500, 0, '2021-10-31', 'rotii'),
('2021-08-19', 'root@localhost', 'Tambah Record', 'BRG0000008', '2', '2', '2', '0000-00-00', 2, 2, '0001-01-01', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, 3'),
('2021-08-19', 'root@localhost', 'Hapus Record', 'BRG0000008', '2', '2', '2', '0000-00-00', 2, 2, '0001-01-01', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, 3'),
('2021-08-19', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 29, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-08-19', 'root@localhost', 'Ubah Record', 'BRG0000007', 'sari roti', 'roti', 'PCS', '2001-10-00', 12500, 0, '2021-10-31', 'rotii'),
('2021-08-20', 'root@localhost', 'Tambah Record', 'BRG0000008', 'madu', 'makan', 'Liter', '2001-00-00', 11000, 0, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000002', 'Formula', 'Alat Mandi', 'PCS', '0000-00-00', 4000, 50, '2021-07-04', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!! ::cobas sekali doang'),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000004', 'Indomie Goreng', 'makan instan', 'pcs', '0000-00-00', 3000, 83, '2021-10-30', ''),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000008', 'madu', 'makan', 'Liter', '2001-00-00', 11000, 0, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000007', 'sari roti', 'roti', 'PCS', '2001-10-00', 12500, 15, '2021-10-31', 'rotii'),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000004', 'Indomie Goreng', 'makan instan', 'pcs', '0000-00-00', 3000, 78, '2021-10-30', ''),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000001', 'Pepsoden ', 'pasta gigi', 'gram', '0000-00-00', 4000, 50, '2023-07-04', ''),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000001', 'Pepsoden ', 'pasta gigi', 'gram', '0000-00-00', 4000, 47, '2023-07-04', ''),
('2021-08-20', 'root@localhost', 'Tambah Record', 'BRG0000009', 'beras', 'Bahan Pokok', 'kg', '2001-00-00', 11000, 100, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000009', 'beras', 'Bahan Pokok', 'kg', '2001-00-00', 11000, 100, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000008', 'madu', 'makan', 'Liter', '2001-00-00', 11000, 50, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000007', 'sari roti', 'roti', 'PCS', '2001-10-00', 12500, 20, '2021-10-31', 'rotii'),
('2021-08-20', 'root@localhost', 'Tambah Record', 'BRG0000010', 'minyak goreng', 'Bahan Pokok', 'Liter', '0000-00-00', 13000, 20, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000010', 'minyak goreng', 'Bahan Pokok', 'Liter', '0000-00-00', 13000, 20, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-20', 'root@localhost', 'Ubah Record', 'BRG0000008', 'madu', 'makan', 'Liter', '2001-00-00', 11000, 40, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-21', 'root@localhost', 'Ubah Record', 'BRG0000001', 'Pepsoden ', 'pasta gigi', 'gram', '0000-00-00', 4000, 40, '2023-07-04', ''),
('2021-08-21', 'root@localhost', 'Ubah Record', 'BRG0000002', 'Formula', 'Alat Mandi', 'PCS', '0000-00-00', 4000, 47, '2021-07-04', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!! ::cobas sekali doang'),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000009', 'beras', 'Bahan Pokok', 'kg', '2001-00-00', 11000, 40, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 25, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 22, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd'),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000008', 'madu', 'makan', 'Liter', '2001-00-00', 11000, 37, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000007', 'sari roti', 'roti', 'PCS', '2001-10-00', 12500, 30, '2021-10-31', 'rotii'),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000009', 'beras', 'Bahan Pokok', 'kg', '2001-00-00', 11000, 30, '2021-08-20', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, '),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000007', 'sari roti', 'roti', 'PCS', '2001-10-00', 12500, 29, '2021-10-31', 'rotii'),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000005', 'Bimoli', 'Minyak Goreng', 'Liter', '2001-10-00', 12000, 31, '2021-07-10', ''),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000007', 'sari roti', 'roti', 'PCS', '2001-10-00', 12500, 28, '2021-10-31', 'rotii'),
('2021-08-22', 'root@localhost', 'Ubah Record', 'BRG0000006', 'Olive Oil', 'Minyak Goreng', 'Liter', '2002-00-00', 24300, 21, '2021-07-10', 'Barang Tidak Memiliki Tanggal Kadaluwarsa!!, kashdakjsdas jkhsahjdhajkhdajhsd');

-- --------------------------------------------------------

--
-- Table structure for table `hak_akses`
--

CREATE TABLE IF NOT EXISTS `hak_akses` (
  `NamaAkses` varchar(50) NOT NULL,
  `Barang` enum('0','1') NOT NULL,
  `Pemasok` enum('0','1') NOT NULL,
  `TransaksiPenjualan` enum('0','1') NOT NULL,
  `TransaksiPembelian` enum('0','1') NOT NULL,
  `TransaksiKas` enum('0','1') NOT NULL,
  `Pegawai` enum('0','1') NOT NULL,
  `KonfigurasiServer` enum('0','1') NOT NULL,
  `HakAkses` enum('0','1') NOT NULL,
  `LaporanPenjualan` enum('0','1') NOT NULL,
  `LaporanPembelian` enum('0','1') NOT NULL,
  `LaporanKas` enum('0','1') NOT NULL,
  `LaporanInfoDataBarang` enum('0','1') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hak_akses`
--

INSERT INTO `hak_akses` (`NamaAkses`, `Barang`, `Pemasok`, `TransaksiPenjualan`, `TransaksiPembelian`, `TransaksiKas`, `Pegawai`, `KonfigurasiServer`, `HakAkses`, `LaporanPenjualan`, `LaporanPembelian`, `LaporanKas`, `LaporanInfoDataBarang`) VALUES
('guda', '0', '0', '1', '1', '0', '0', '0', '0', '1', '1', '1', '1'),
('Kasir', '0', '0', '1', '1', '0', '1', '1', '0', '0', '0', '0', '0'),
('Pemilik', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'),
('Pengembang', '', '', '', '', '', '', '', '', '', '', '', '0');

-- --------------------------------------------------------

--
-- Table structure for table `kas`
--

CREATE TABLE IF NOT EXISTS `kas` (
  `NomorTransaksi` char(15) NOT NULL,
  `Tanggal` datetime NOT NULL,
  `Uraian` varchar(250) NOT NULL,
  `Masuk` double NOT NULL,
  `Keluar` double NOT NULL,
  `Saldo` double NOT NULL,
  `KodePegawai` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kas`
--

INSERT INTO `kas` (`NomorTransaksi`, `Tanggal`, `Uraian`, `Masuk`, `Keluar`, `Saldo`, `KodePegawai`) VALUES
('KAS000000000001', '2021-07-04 23:07:55', 'Kas Masuk Dari penjualan dengan no. PNJ000000000001', 41006, 1000, 40006, 'PGW0000000'),
('KAS000000000002', '2021-07-04 23:44:49', 'Kas Masuk Dari penjualan dengan no. PNJ000000000002', 50000, 10000, 80006, 'PGW0000000'),
('KAS000000000003', '2021-07-06 17:06:10', 'Kas Masuk Dari penjualan dengan no. PNJ000000000003', 81000, 1000, 160006, 'PGW0000000'),
('KAS000000000004', '2021-07-07 02:17:05', 'Kas keluar dari pembelian dengan no. PMB000000000003', 0, 210000, -49994, 'PGW0000000'),
('KAS000000000005', '2021-07-07 02:23:12', 'kas Masuk Untuk Menominalkan saldo menjadi 0', 49994, 0, 0, 'PGW0000000'),
('KAS000000000006', '2021-07-09 02:35:55', 'Kas Masuk Dari penjualan dengan no. PNJ000000000004', 70000, 10000, 60000, 'PGW0000000'),
('KAS000000000007', '2021-07-09 02:36:46', 'Kas Masuk Dari penjualan dengan no. PNJ000000000005', 15000, 3000, 72000, 'PGW0000000'),
('KAS000000000008', '2021-07-09 02:41:39', 'Kas Masuk Dari penjualan dengan no. PNJ000000000006', 20000, 4000, 88000, 'PGW0000000'),
('KAS000000000009', '2021-07-09 02:49:51', 'Kas Masuk Dari penjualan dengan no. PNJ000000000007', 35000, 3000, 120000, 'PGW0000000'),
('KAS000000000010', '2021-07-09 03:00:11', 'Kas Masuk Dari penjualan dengan no. PNJ000000000008', 30000, 2000, 148000, 'PGW0000000'),
('KAS000000000011', '2021-07-09 03:24:44', 'Kas Masuk Dari penjualan dengan no. PNJ000000000009', 25000, 5000, 168000, 'PGW0000000'),
('KAS000000000012', '2021-07-10 14:09:22', 'Kas keluar dari pembelian dengan no. PMB000000000003', 0, 35012, 132988, 'PGW0000000'),
('KAS000000000013', '2021-07-11 04:20:19', 'Kas Masuk Dari penjualan dengan no. PNJ000000000010', 10, 4, 132994, 'PGW0000000'),
('KAS000000000014', '2021-07-11 04:43:17', 'Kas Masuk Dari penjualan dengan no. PNJ000000000011', 101000, -4569.55, 238563.55, 'PGW0000000'),
('KAS000000000015', '2021-07-11 04:48:36', 'Kas Masuk Dari penjualan dengan no. PNJ000000000012', 257000, 950, 494613.55, 'PGW0000000'),
('KAS000000000016', '2021-07-11 06:26:19', 'Kas keluar dari pembelian dengan no. PMB000000000004', 0, 100000, 394613.55, 'PGW0000000'),
('KAS000000000017', '2021-07-11 06:28:03', 'Kas keluar dari pembelian dengan no. PMB000000000005', 0, 235000, 159613.55, 'PGW0000000'),
('KAS000000000018', '2021-07-11 06:37:47', 'Kas Masuk Dari penjualan dengan no. PNJ000000000013', 250000, 7000, 402613.55, 'PGW0000000'),
('KAS000000000019', '2021-07-11 06:39:29', 'Kas Masuk Dari penjualan dengan no. PNJ000000000014', 400000, 37000, 765613.55, 'PGW0000000'),
('KAS000000000020', '2021-07-11 06:53:21', 'Kas Masuk Dari penjualan dengan no. PNJ000000000015', 15000, 3000, 777613.55, 'PGW0000000'),
('KAS000000000021', '2021-07-11 06:55:35', 'Kas Masuk Dari penjualan dengan no. PNJ000000000016', 50000, 1400, 826213.55, 'PGW0000000'),
('KAS000000000022', '2021-07-11 06:57:57', 'Kas Masuk Dari penjualan dengan no. PNJ000000000017', 25000, 1000, 850213.55, 'PGW0000000'),
('KAS000000000023', '2021-07-21 20:34:34', 'Kas Masuk Dari penjualan dengan no. PNJ000000000018', 82000, 100, 932113.55, 'PGW0000000'),
('KAS000000000024', '2021-07-21 22:19:43', 'Kas keluar dari pembelian dengan no. PMB000000000006', 0, 322000, 610113.55, 'PGW0000000'),
('KAS000000000025', '2021-07-22 12:38:47', 'Kas Masuk Dari penjualan dengan no. PNJ000000000019', 30000, 5700, 634413.55, 'PGW0000000'),
('KAS000000000026', '2021-08-05 20:36:33', 'Kas Masuk Dari penjualan dengan no. PNJ000000000020', 40000, 0, 674413.55, 'PGW0000000'),
('KAS000000000027', '2021-08-05 20:44:22', 'Kas Masuk Dari penjualan dengan no. PNJ000000000021', 10000, 0, 684413.55, 'PGW0000000'),
('KAS000000000028', '2021-08-06 17:56:54', 'Kas keluar dari pembelian dengan no. PMB000000000007', 0, 25000, 659413.55, 'PGW0000000'),
('KAS000000000029', '2021-08-10 00:02:12', 'Kas keluar dari pembelian dengan no. PMB000000000008', 0, 2, 659411.55, 'PGW0000000'),
('KAS000000000030', '2021-08-19 20:11:41', 'Kas Masuk Dari penjualan dengan no. PNJ000000000022', 100000, 3966.39999999999, 755445.15, 'PGW0000000'),
('KAS000000000031', '2021-08-19 20:15:13', 'Kas keluar dari pembelian dengan no. PMB000000000009', 0, 161700, 593745.15, 'PGW0000000'),
('KAS000000000032', '2021-08-19 00:00:00', 'ambil', 0, 97345, 496400.15, 'PGW0000000'),
('KAS000000000033', '2021-08-19 00:00:00', '2', 0, 96400, 400000.15, 'PGW0000000'),
('KAS000000000034', '2021-08-20 08:29:59', 'Kas Masuk Dari penjualan dengan no. PNJ000000000023', 30000, 3000, 427000.15, 'PGW0000000'),
('KAS000000000035', '2021-08-20 08:31:15', 'Kas keluar dari pembelian dengan no. PMB000000000010', 0, 555000, -127999.85, 'PGW0000000'),
('KAS000000000036', '2021-08-20 08:32:08', 'penambahan', 128000, 0, 0.150000000023283, 'PGW0000000'),
('KAS000000000037', '2021-08-20 08:40:54', 'Kas Masuk Dari penjualan dengan no. PNJ000000000024', 50000, 8000, 42000.15, 'PGW0000000'),
('KAS000000000038', '2021-08-20 08:42:45', 'Kas Masuk Dari penjualan dengan no. PNJ000000000025', 30000, 2000, 70000.15, 'PGW0000000'),
('KAS000000000039', '2021-08-20 09:12:07', 'Kas Masuk Dari penjualan dengan no. PNJ000000000026', 700000, 40000, 730000.15, 'PGW0000004'),
('KAS000000000040', '2021-08-20 09:13:53', 'Kas Masuk Dari penjualan dengan no. PNJ000000000027', 200000, 90000, 840000.15, 'PGW0000004'),
('KAS000000000041', '2021-08-20 09:19:47', 'Kas keluar dari pembelian dengan no. PMB000000000011', 0, 110000, 730000.15, 'PGW0000001'),
('KAS000000000042', '2021-08-20 20:36:14', 'Kas Masuk Dari penjualan dengan no. PNJ000000000028', 100000, 2000, 828000.15, 'PGW0000000'),
('KAS000000000043', '2021-08-21 11:23:48', 'Kas Masuk Dari penjualan dengan no. PNJ000000000001', 50000, 10000, 868000.15, 'PGW0000000'),
('KAS000000000044', '2021-08-21 11:26:30', 'Kas Masuk Dari penjualan dengan no. PNJ000000000002', 30000, 2000, 896000.15, 'PGW0000000'),
('KAS000000000045', '2021-08-22 14:47:12', 'Kas Masuk Dari penjualan dengan no. PNJ000000000003', 100000, 10000, 986000.15, 'PGW0000000'),
('KAS000000000046', '2021-08-22 15:05:44', 'Kas Masuk Dari penjualan dengan no. PNJ000000000004', 80000, 10000, 1056000.15, 'PGW0000000'),
('KAS000000000047', '2021-08-22 15:40:49', 'Kas Masuk Dari penjualan dengan no. PNJ000000000005', 50000, 40000, 1066000.15, 'PGW0000000'),
('KAS000000000048', '2021-08-22 15:49:39', 'Kas Masuk Dari penjualan dengan no. PNJ000000000006', 20000, 1000, 1085000.15, 'PGW0000000'),
('KAS000000000049', '2021-08-22 15:51:05', 'Kas Masuk Dari penjualan dengan no. PNJ000000000007', 15000, 4000, 1096000.15, 'PGW0000000'),
('KAS000000000050', '2021-08-22 16:04:08', 'Kas Masuk Dari penjualan dengan no. PNJ000000000008', 20000, 1000, 1115000.15, 'PGW0000000'),
('KAS000000000051', '2021-08-22 16:05:55', 'Kas Masuk Dari penjualan dengan no. PNJ000000000009', 20000, 10000, 1125000.15, 'PGW0000000'),
('KAS000000000052', '2021-08-22 16:19:53', 'Kas Masuk Dari penjualan dengan no. PNJ000000000010', 150000, 40000, 1235000.15, 'PGW0000000'),
('KAS000000000053', '2021-08-22 16:22:39', 'Kas Masuk Dari penjualan dengan no. PNJ000000000011', 50000, 30000, 1255000.15, 'PGW0000000'),
('KAS000000000054', '2021-08-22 16:27:48', 'Kas Masuk Dari penjualan dengan no. PNJ000000000012', 50000, 1400, 1303600.15, 'PGW0000000');

-- --------------------------------------------------------

--
-- Table structure for table `konsumen`
--

CREATE TABLE IF NOT EXISTS `konsumen` (
  `KodeKonsumen` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `konsumen`
--

INSERT INTO `konsumen` (`KodeKonsumen`) VALUES
('KSM0000001'),
('KSM0000002'),
('KSM0000003'),
('KSM0000004'),
('KSM0000005'),
('KSM0000006'),
('KSM0000007'),
('KSM0000008'),
('KSM0000009'),
('KSM0000010'),
('KSM0000011'),
('KSM0000012');

-- --------------------------------------------------------

--
-- Table structure for table `pegawai`
--

CREATE TABLE IF NOT EXISTS `pegawai` (
  `KodePegawai` char(10) NOT NULL,
  `NamaPegawai` varchar(50) NOT NULL,
  `Jabatan` varchar(50) NOT NULL,
  `Alamat` varchar(250) NOT NULL,
  `NomorTelepon` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `NamaAkses` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pegawai`
--

INSERT INTO `pegawai` (`KodePegawai`, `NamaPegawai`, `Jabatan`, `Alamat`, `NomorTelepon`, `Email`, `Username`, `Password`, `NamaAkses`) VALUES
('PGW0000000', 'Kholis', '', '', '', '', 'root', 'root', 'Pengembang'),
('PGW0000001', 'reza', 'Kasir', 'gerung', '082272829', 'rezagerung@gmail.com', 'reza', 'reza', 'Pemilik'),
('PGW0000002', 'Lalu Ichanul Wathoni', 'Kasi', 'Kediri', '082776674789', 'ihsan@gmail.com', 'ihsan', 'ihsan', 'Kasir'),
('PGW0000003', 'altof', 'kasir', 'serni', '08282888', 'altof@gmail.com', 'altof', 'altof', 'guda'),
('PGW0000004', 'syahrir', 'kasir', 'mataram', '08883838338', 'syahrir@gmail.com', 'syahrir', 'syahrir', 'Kasir');

--
-- Triggers `pegawai`
--
DELIMITER //
CREATE TRIGGER `DeletePegawai` BEFORE DELETE ON `pegawai`
 FOR EACH ROW insert into pegawai_log values(sysdate(),current_user,'Hapus Record',old.KodePegawai,old.NamaPegawai,old.Jabatan,old.Alamat,old.NomorTelepon,old.Email,old.Username,old.Password,old.NamaAkses)
//
DELIMITER ;
DELIMITER //
CREATE TRIGGER `InsertPegawai` BEFORE INSERT ON `pegawai`
 FOR EACH ROW insert into pegawai_log values(sysdate(),current_user,"Tambah Record",new.KodePegawai,new.NamaPegawai,new.Jabatan,new.Alamat,new.NomorTelepon,new.Email,new.Username,new.Password,new.NamaAkses)
//
DELIMITER ;
DELIMITER //
CREATE TRIGGER `UpdatePegawai` BEFORE UPDATE ON `pegawai`
 FOR EACH ROW insert into pegawai_log values(sysdate(),current_user,'Ubah Record Record', old.KodePegawai,old.NamaPegawai,old.Jabatan,old.Alamat,old.NomorTelepon,old.Email,old.Username,old.Password,old.NamaAkses)
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `pegawai_log`
--

CREATE TABLE IF NOT EXISTS `pegawai_log` (
  `TanggalTrigger` date NOT NULL,
  `UserTrigger` varchar(250) NOT NULL,
  `InformasiTrigger` varchar(250) NOT NULL,
  `KodePegawai` char(10) NOT NULL,
  `NamaPegawai` varchar(50) NOT NULL,
  `Jabatan` varchar(50) NOT NULL,
  `Alamat` varchar(250) NOT NULL,
  `NomorTelepon` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `NamaAkses` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pegawai_log`
--

INSERT INTO `pegawai_log` (`TanggalTrigger`, `UserTrigger`, `InformasiTrigger`, `KodePegawai`, `NamaPegawai`, `Jabatan`, `Alamat`, `NomorTelepon`, `Email`, `Username`, `Password`, `NamaAkses`) VALUES
('2021-07-21', 'root@localhost', 'Ubah Record Record', 'PGW0000000', '', '', '', '', '', 'root', 'root', 'Pengembang'),
('2021-08-07', 'root@localhost', 'Ubah Record Record', 'PGW0000001', 'reza', 'Kasir', 'gerung', '082272829', 'rezagerung@gmail.com', 'reza', 'reza', 'Kasir'),
('2021-08-07', 'root@localhost', 'Tambah Record', 'PGW0000002', 'Lalu Ichanul Wathoni', 'Kasi', 'Kediri', '082776674789', 'ihsan@gmail.com', 'ihsan', 'ihsan', 'Kasir'),
('2021-08-07', 'root@localhost', 'Ubah Record Record', 'PGW0000001', 'reza', 'Kasir', 'gerung', '082272829', 'rezagerung@gmail.com', 'reza', 'reza', 'Pemilik'),
('2021-08-07', 'root@localhost', 'Ubah Record Record', 'PGW0000001', 'reza', 'Kasir', 'gerung', '082272829', 'rezagerung@gmail.com', 'reza', 'tes', 'Pemilik'),
('2021-08-20', 'root@localhost', 'Tambah Record', 'PGW0000003', 'altof', 'kasir', 'serni', '08282888', 'altof@gmail.com', 'altof', 'altof', 'Kasir'),
('2021-08-20', 'root@localhost', 'Ubah Record Record', 'PGW0000003', 'altof', 'kasir', 'serni', '08282888', 'altof@gmail.com', 'altof', 'altof', 'Kasir'),
('2021-08-20', 'root@localhost', 'Tambah Record', 'PGW0000004', 'syahrir', 'kasir', 'mataram', '08883838338', 'syahrir@gmail.com', 'syahrir', 'syahrir', 'Kasir');

-- --------------------------------------------------------

--
-- Table structure for table `pemasok`
--

CREATE TABLE IF NOT EXISTS `pemasok` (
  `KodePemasok` char(10) NOT NULL,
  `NamaPemasok` varchar(100) NOT NULL,
  `Alamat` varchar(250) NOT NULL,
  `NomorTelepon` varchar(50) NOT NULL,
  `Keterangan` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pemasok`
--

INSERT INTO `pemasok` (`KodePemasok`, `NamaPemasok`, `Alamat`, `NomorTelepon`, `Keterangan`) VALUES
('PMK0000001', 'Sinar Abadi', 'Jln. Gede Ngurah', '082289989933', 'Memasok sembako'),
('PMK0000002', 'PT. indofood', 'Jln.ki hajar dewantara', '083377822647', 'Menyetok Snack'),
('PMK0000003', 'Tanpa Nama', 'Mandalika', '087787898828', 'memasok makanan instan'),
('PMK0000004', 'alfa', 'jln 11', '082247', 'memasok ');

--
-- Triggers `pemasok`
--
DELIMITER //
CREATE TRIGGER `DeletePemasok` BEFORE DELETE ON `pemasok`
 FOR EACH ROW insert into pemasok_log values(sysdate(),current_user,'Hapus Record', old.KodePemasok,old.NamaPemasok,old.Alamat,old.NomorTelepon,old.Keterangan)
//
DELIMITER ;
DELIMITER //
CREATE TRIGGER `InsertPemasok` BEFORE INSERT ON `pemasok`
 FOR EACH ROW insert into pemasok_log values(sysdate(),current_user,'Tambah Record',new.KodePemasok,new.NamaPemasok,new.Alamat,new.NomorTelepon,new.Keterangan)
//
DELIMITER ;
DELIMITER //
CREATE TRIGGER `UpdatePemasok` BEFORE UPDATE ON `pemasok`
 FOR EACH ROW insert into pemasok_log values(sysdate(),current_user,'Ubah Record Record', old.KodePemasok,old.NamaPemasok,old.Alamat,old.NomorTelepon,old.Keterangan)
//
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `pemasok_log`
--

CREATE TABLE IF NOT EXISTS `pemasok_log` (
  `TanggalTrigger` date NOT NULL,
  `UserTrigger` varchar(250) NOT NULL,
  `InformasiTrigger` varchar(250) NOT NULL,
  `KodePemasok` char(10) NOT NULL,
  `NamaPemasok` varchar(100) NOT NULL,
  `Alamat` varchar(250) NOT NULL,
  `NomorTelepon` varchar(50) NOT NULL,
  `Keterangan` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pemasok_log`
--

INSERT INTO `pemasok_log` (`TanggalTrigger`, `UserTrigger`, `InformasiTrigger`, `KodePemasok`, `NamaPemasok`, `Alamat`, `NomorTelepon`, `Keterangan`) VALUES
('2021-07-21', 'root@localhost', 'Ubah Record Record', 'PMK0000001', 'Sinar Abadi', 'Jln. Gede Ngurah', '0982098', 'Memasok sembako'),
('2021-07-21', 'root@localhost', 'Tambah Record', 'PMK0000002', 'PT. indofood', 'Jln.ki hajar dewantara', '083377822647', 'Menyetok Snack'),
('2021-08-06', 'root@localhost', 'Tambah Record', 'PMK0000003', 'Tanpa Nama', 'Mandalika', '087787898828', 'memasok makanan instan'),
('2021-08-20', 'root@localhost', 'Tambah Record', 'PMK0000004', 'alfa', 'jln 11', '082247', 'memasok ');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian`
--

CREATE TABLE IF NOT EXISTS `pembelian` (
  `NomorTransaksi` char(15) NOT NULL,
  `Tanggal` datetime NOT NULL,
  `KodePemasok` char(10) NOT NULL,
  `Potongan` double DEFAULT NULL,
  `TotalPembelian` double NOT NULL,
  `KodePegawai` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian`
--

INSERT INTO `pembelian` (`NomorTransaksi`, `Tanggal`, `KodePemasok`, `Potongan`, `TotalPembelian`, `KodePegawai`) VALUES
('PMB000000000003', '2021-07-10 14:09:22', 'PMK0000001', 0, 35012, 'PGW0000000'),
('PMB000000000004', '2021-07-11 06:26:19', 'PMK0000001', 0, 100000, 'PGW0000000'),
('PMB000000000005', '2021-07-11 06:28:03', 'PMK0000001', 0, 235000, 'PGW0000000'),
('PMB000000000006', '2021-07-21 22:19:43', 'PMK0000002', 0, 322000, 'PGW0000000'),
('PMB000000000007', '2021-08-06 17:56:54', 'PMK0000003', 0, 25000, 'PGW0000000'),
('PMB000000000008', '2021-08-10 00:02:12', 'PMK0000003', 0, 2, 'PGW0000000'),
('PMB000000000009', '2021-08-19 20:15:13', 'PMK0000003', 0, 161700, 'PGW0000000'),
('PMB000000000010', '2021-08-20 08:31:15', 'PMK0000004', 0, 555000, 'PGW0000000'),
('PMB000000000011', '2021-08-20 09:19:47', 'PMK0000003', 0, 110000, 'PGW0000001');

-- --------------------------------------------------------

--
-- Table structure for table `pembelian_detil`
--

CREATE TABLE IF NOT EXISTS `pembelian_detil` (
  `NomorTransaksi` char(15) NOT NULL,
  `KodeBarang` char(10) NOT NULL,
  `HargaSatuan` double NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `PersenDiskon` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembelian_detil`
--

INSERT INTO `pembelian_detil` (`NomorTransaksi`, `KodeBarang`, `HargaSatuan`, `Jumlah`, `PersenDiskon`) VALUES
('PMB000000000004', 'BRG0000001', 2500, 40, 0),
('PMB000000000005', 'BRG0000006', 20000, 4, 0),
('PMB000000000005', 'BRG0000001', 2500, 2, 0),
('PMB000000000005', 'BRG0000001', 3000, 50, 0),
('PMB000000000006', 'BRG0000006', 20000, 15, 0),
('PMB000000000006', 'BRG0000005', 11000, 2, 0),
('PMB000000000007', 'BRG0000001', 2500, 10, 0),
('PMB000000000008', '0000000000', 1, 2, 0),
('PMB000000000009', 'BRG0000007', 11000, 15, 2),
('PMB000000000010', 'BRG0000008', 10000, 50, 0),
('PMB000000000010', 'BRG0000007', 11000, 5, 0),
('PMB000000000011', 'BRG0000007', 11000, 10, 0);

-- --------------------------------------------------------

--
-- Table structure for table `penjualan`
--

CREATE TABLE IF NOT EXISTS `penjualan` (
  `NomorTransaksi` char(15) NOT NULL,
  `Tanggal` datetime NOT NULL,
  `KodeKonsumen` char(10) NOT NULL,
  `Potongan` double NOT NULL,
  `JumlahUang` double NOT NULL,
  `KodePegawai` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan`
--

INSERT INTO `penjualan` (`NomorTransaksi`, `Tanggal`, `KodeKonsumen`, `Potongan`, `JumlahUang`, `KodePegawai`) VALUES
('PNJ000000000001', '2021-08-21 11:23:48', 'KSM0000001', 0, 50000, 'PGW0000000'),
('PNJ000000000002', '2021-08-21 11:26:30', 'KSM0000002', 0, 30000, 'PGW0000000'),
('PNJ000000000003', '2021-08-22 14:47:12', 'KSM0000003', 20000, 100000, 'PGW0000000'),
('PNJ000000000004', '2021-08-22 15:05:44', 'KSM0000004', 2900, 80000, 'PGW0000000'),
('PNJ000000000005', '2021-08-22 15:40:49', 'KSM0000005', 14300, 50000, 'PGW0000000'),
('PNJ000000000006', '2021-08-22 15:49:39', 'KSM0000006', 3000, 20000, 'PGW0000000'),
('PNJ000000000007', '2021-08-22 15:51:05', 'KSM0000007', 1500, 15000, 'PGW0000000'),
('PNJ000000000008', '2021-08-22 16:04:08', 'KSM0000008', 3000, 20000, 'PGW0000000'),
('PNJ000000000009', '2021-08-22 16:05:55', 'KSM0000009', 2500, 20000, 'PGW0000000'),
('PNJ000000000010', '2021-08-22 16:19:53', 'KSM0000010', 22000, 150000, 'PGW0000000'),
('PNJ000000000011', '2021-08-22 16:22:39', 'KSM0000011', 5000, 50000, 'PGW0000000'),
('PNJ000000000012', '2021-08-22 16:27:48', 'KSM0000012', 0, 50000, 'PGW0000000');

-- --------------------------------------------------------

--
-- Table structure for table `penjualan_detil`
--

CREATE TABLE IF NOT EXISTS `penjualan_detil` (
  `NomorTransaksi` char(15) NOT NULL,
  `KodeBarang` char(10) NOT NULL,
  `HargaSatuan` double NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `PersenDiskon` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penjualan_detil`
--

INSERT INTO `penjualan_detil` (`NomorTransaksi`, `KodeBarang`, `HargaSatuan`, `Jumlah`, `PersenDiskon`) VALUES
('PNJ000000000001', 'BRG0000001', 4000, 10, 0),
('PNJ000000000002', 'BRG0000002', 4000, 7, 0),
('PNJ000000000003', 'BRG0000009', 11000, 10, 10),
('PNJ000000000004', 'BRG0000006', 24300, 3, 0),
('PNJ000000000005', 'BRG0000006', 24300, 1, 50),
('PNJ000000000006', 'BRG0000008', 11000, 2, 10),
('PNJ000000000007', 'BRG0000007', 12500, 1, 10),
('PNJ000000000008', 'BRG0000009', 11000, 2, 10),
('PNJ000000000009', 'BRG0000007', 12500, 1, 10),
('PNJ000000000010', 'BRG0000005', 12000, 11, 10),
('PNJ000000000011', 'BRG0000007', 12500, 2, 10),
('PNJ000000000012', 'BRG0000006', 24300, 2, 0);

-- --------------------------------------------------------

--
-- Stand-in structure for view `view_informasibarang`
--
CREATE TABLE IF NOT EXISTS `view_informasibarang` (
`KodeBarang` char(10)
,`NamaBarang` varchar(100)
,`Kategori` varchar(50)
,`Satuan` varchar(50)
,`HargaBeli` double
,`HargaJual` double
,`Stok` int(11)
,`Kedaluwarsa` date
,`Keterangan` varchar(250)
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `view_laporankas`
--
CREATE TABLE IF NOT EXISTS `view_laporankas` (
`Tanggal` datetime
,`NomorTransaksi` char(15)
,`Uraian` varchar(250)
,`Masuk` double
,`Keluar` double
,`Saldo` double
,`KodePegawai` char(10)
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `view_laporanpembeliandetil`
--
CREATE TABLE IF NOT EXISTS `view_laporanpembeliandetil` (
`KodeBarang` char(10)
,`NamaBarang` varchar(100)
,`HargaSatuan` double
,`Jumlah` int(11)
,`SubTotalHarga` double
,`PersenDiskon` double
,`JumlahDiskon` double
,`TotalHarga` double
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `view_laporanpembelianperpemasok`
--
CREATE TABLE IF NOT EXISTS `view_laporanpembelianperpemasok` (
`Tanggal` datetime
,`NomorTransaksi` char(15)
,`KodePemasok` char(10)
,`NamaPemasok` varchar(100)
,`JumlahItem` bigint(21)
,`Potongan` double
,`TotalPembelian` double
,`TotalPembayaran` double
,`Keterangan` varchar(250)
,`KodePegawai` char(10)
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `view_laporanpembelianpertanggal`
--
CREATE TABLE IF NOT EXISTS `view_laporanpembelianpertanggal` (
`Tanggal` datetime
,`NomorTransaksi` char(15)
,`KodePemasok` char(10)
,`NamaPemasok` varchar(100)
,`JumlahItem` bigint(21)
,`Potongan` double
,`TotalPembelian` double
,`TotalPembayaran` double
,`Keterangan` varchar(250)
,`KodePegawai` char(10)
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `view_laporanpenjualan`
--
CREATE TABLE IF NOT EXISTS `view_laporanpenjualan` (
`NomorTransaksi` char(15)
,`Tanggal` datetime
,`Potongan` double
,`JumlahItem` bigint(21)
,`TotalPenjualan` double
,`TotalPembayaran` double
,`JumlahUang` double
,`KodePegawai` char(10)
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `view_laporanpenjualandetil`
--
CREATE TABLE IF NOT EXISTS `view_laporanpenjualandetil` (
`KodeBarang` char(10)
,`NamaBarang` varchar(100)
,`HargaSatuan` double
,`Jumlah` int(11)
,`SubTotalHarga` double
,`PersenDiskon` double
,`JumlahDiskon` double
,`TotalHarga` double
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `view_laporantransaksipenjualan`
--
CREATE TABLE IF NOT EXISTS `view_laporantransaksipenjualan` (
`NomorTransaksi` char(15)
,`Tanggal` datetime
,`Potongan` double
,`JumlahItem` bigint(21)
,`TotalPenjualan` double
,`TotalPembayaran` double
,`JumlahUang` double
,`KodePegawai` char(10)
);
-- --------------------------------------------------------

--
-- Stand-in structure for view `view_noteuntukkonsumen`
--
CREATE TABLE IF NOT EXISTS `view_noteuntukkonsumen` (
`KodeBarang` char(10)
,`NamaBarang` varchar(100)
,`HargaSatuan` double
,`Jumlah` int(11)
,`PersenDiskon` double
,`SubTotal` double
,`JumlahDiskon` double
,`JumlahHarga` double
);
-- --------------------------------------------------------

--
-- Structure for view `view_informasibarang`
--
DROP TABLE IF EXISTS `view_informasibarang`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_informasibarang` AS select `barang`.`KodeBarang` AS `KodeBarang`,`barang`.`NamaBarang` AS `NamaBarang`,`barang`.`Kategori` AS `Kategori`,`barang`.`Satuan` AS `Satuan`,`barang`.`HargaBeli` AS `HargaBeli`,`barang`.`HargaJual` AS `HargaJual`,`barang`.`Stok` AS `Stok`,`barang`.`Kedaluwarsa` AS `Kedaluwarsa`,`barang`.`Keterangan` AS `Keterangan` from `barang` where ((`barang`.`Kategori` = 'Minyak Goreng') and (`barang`.`KodeBarang` <> '0000000000')) order by `barang`.`Kategori`;

-- --------------------------------------------------------

--
-- Structure for view `view_laporankas`
--
DROP TABLE IF EXISTS `view_laporankas`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_laporankas` AS select `kas`.`Tanggal` AS `Tanggal`,`kas`.`NomorTransaksi` AS `NomorTransaksi`,`kas`.`Uraian` AS `Uraian`,`kas`.`Masuk` AS `Masuk`,`kas`.`Keluar` AS `Keluar`,`kas`.`Saldo` AS `Saldo`,`kas`.`KodePegawai` AS `KodePegawai` from `kas` where ((`kas`.`Tanggal` >= '2021-08-01  00:00:00') and (`kas`.`Tanggal` <= '2021-08-22 00:44:27'));

-- --------------------------------------------------------

--
-- Structure for view `view_laporanpembeliandetil`
--
DROP TABLE IF EXISTS `view_laporanpembeliandetil`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_laporanpembeliandetil` AS select `a`.`KodeBarang` AS `KodeBarang`,`b`.`NamaBarang` AS `NamaBarang`,`a`.`HargaSatuan` AS `HargaSatuan`,`a`.`Jumlah` AS `Jumlah`,(`a`.`HargaSatuan` * `a`.`Jumlah`) AS `SubTotalHarga`,`a`.`PersenDiskon` AS `PersenDiskon`,((`a`.`HargaSatuan` * `a`.`Jumlah`) * (`a`.`PersenDiskon` / 100)) AS `JumlahDiskon`,((`a`.`HargaSatuan` * `a`.`Jumlah`) - ((`a`.`HargaSatuan` * `a`.`Jumlah`) * (`a`.`PersenDiskon` / 100))) AS `TotalHarga` from (`pembelian_detil` `a` join `barang` `b` on((`a`.`KodeBarang` = `b`.`KodeBarang`))) where (`a`.`NomorTransaksi` = 'PMB000000000010') order by `b`.`NamaBarang`;

-- --------------------------------------------------------

--
-- Structure for view `view_laporanpembelianperpemasok`
--
DROP TABLE IF EXISTS `view_laporanpembelianperpemasok`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_laporanpembelianperpemasok` AS select `a`.`Tanggal` AS `Tanggal`,`a`.`NomorTransaksi` AS `NomorTransaksi`,`a`.`KodePemasok` AS `KodePemasok`,`b`.`NamaPemasok` AS `NamaPemasok`,count(`c`.`KodeBarang`) AS `JumlahItem`,`a`.`Potongan` AS `Potongan`,sum(((`c`.`HargaSatuan` * `c`.`Jumlah`) - ((`c`.`HargaSatuan` * `c`.`Jumlah`) * (`c`.`PersenDiskon` / 100)))) AS `TotalPembelian`,(sum(((`c`.`HargaSatuan` * `c`.`Jumlah`) - ((`c`.`HargaSatuan` * `c`.`Jumlah`) * (`c`.`PersenDiskon` / 100)))) - `a`.`Potongan`) AS `TotalPembayaran`,`b`.`Keterangan` AS `Keterangan`,`a`.`KodePegawai` AS `KodePegawai` from ((`pembelian` `a` join `pemasok` `b` on((`a`.`KodePemasok` = `b`.`KodePemasok`))) join `pembelian_detil` `c` on((`a`.`NomorTransaksi` = `c`.`NomorTransaksi`))) where (`a`.`KodePemasok` = 'PMK0000003') group by `a`.`NomorTransaksi`;

-- --------------------------------------------------------

--
-- Structure for view `view_laporanpembelianpertanggal`
--
DROP TABLE IF EXISTS `view_laporanpembelianpertanggal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_laporanpembelianpertanggal` AS select `a`.`Tanggal` AS `Tanggal`,`a`.`NomorTransaksi` AS `NomorTransaksi`,`a`.`KodePemasok` AS `KodePemasok`,`b`.`NamaPemasok` AS `NamaPemasok`,count(`c`.`KodeBarang`) AS `JumlahItem`,`a`.`Potongan` AS `Potongan`,sum(((`c`.`HargaSatuan` * `c`.`Jumlah`) - ((`c`.`HargaSatuan` * `c`.`Jumlah`) * (`c`.`PersenDiskon` / 100)))) AS `TotalPembelian`,(sum(((`c`.`HargaSatuan` * `c`.`Jumlah`) - ((`c`.`HargaSatuan` * `c`.`Jumlah`) * (`c`.`PersenDiskon` / 100)))) - `a`.`Potongan`) AS `TotalPembayaran`,`b`.`Keterangan` AS `Keterangan`,`a`.`KodePegawai` AS `KodePegawai` from ((`pembelian` `a` join `pemasok` `b` on((`a`.`KodePemasok` = `b`.`KodePemasok`))) join `pembelian_detil` `c` on((`a`.`NomorTransaksi` = `c`.`NomorTransaksi`))) where ((`a`.`Tanggal` >= '2021-08-01 00:00:00') and (`a`.`Tanggal` <= '2021-08-22 00:43:50')) group by `a`.`NomorTransaksi`;

-- --------------------------------------------------------

--
-- Structure for view `view_laporanpenjualan`
--
DROP TABLE IF EXISTS `view_laporanpenjualan`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_laporanpenjualan` AS select `a`.`NomorTransaksi` AS `NomorTransaksi`,`a`.`Tanggal` AS `Tanggal`,`a`.`Potongan` AS `Potongan`,count(`b`.`KodeBarang`) AS `JumlahItem`,sum(((`b`.`HargaSatuan` * `b`.`Jumlah`) - ((`b`.`HargaSatuan` * `b`.`Jumlah`) * (`b`.`PersenDiskon` / 100)))) AS `TotalPenjualan`,(sum(((`b`.`HargaSatuan` * `b`.`Jumlah`) - ((`b`.`HargaSatuan` * `b`.`Jumlah`) * (`b`.`PersenDiskon` / 100)))) - `a`.`Potongan`) AS `TotalPembayaran`,`a`.`JumlahUang` AS `JumlahUang`,`a`.`KodePegawai` AS `KodePegawai` from (`penjualan` `a` join `penjualan_detil` `b` on((`a`.`NomorTransaksi` = `b`.`NomorTransaksi`))) where ((`a`.`Tanggal` >= '2021-08-01 00:00:00') and (`a`.`Tanggal` <= '2021-08-22 00:43:26')) group by `a`.`NomorTransaksi`;

-- --------------------------------------------------------

--
-- Structure for view `view_laporanpenjualandetil`
--
DROP TABLE IF EXISTS `view_laporanpenjualandetil`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_laporanpenjualandetil` AS select `a`.`KodeBarang` AS `KodeBarang`,`b`.`NamaBarang` AS `NamaBarang`,`a`.`HargaSatuan` AS `HargaSatuan`,`a`.`Jumlah` AS `Jumlah`,(`a`.`HargaSatuan` * `a`.`Jumlah`) AS `SubTotalHarga`,`a`.`PersenDiskon` AS `PersenDiskon`,((`a`.`HargaSatuan` * `a`.`Jumlah`) * (`a`.`PersenDiskon` / 100)) AS `JumlahDiskon`,((`a`.`HargaSatuan` * `a`.`Jumlah`) - ((`a`.`HargaSatuan` * `a`.`Jumlah`) * (`a`.`PersenDiskon` / 100))) AS `TotalHarga` from (`penjualan_detil` `a` join `barang` `b` on((`a`.`KodeBarang` = `b`.`KodeBarang`))) where (`a`.`NomorTransaksi` = 'PNJ000000000002') order by `b`.`NamaBarang`;

-- --------------------------------------------------------

--
-- Structure for view `view_laporantransaksipenjualan`
--
DROP TABLE IF EXISTS `view_laporantransaksipenjualan`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_laporantransaksipenjualan` AS select `a`.`NomorTransaksi` AS `NomorTransaksi`,`a`.`Tanggal` AS `Tanggal`,`a`.`Potongan` AS `Potongan`,count(`b`.`KodeBarang`) AS `JumlahItem`,sum(((`b`.`HargaSatuan` * `b`.`Jumlah`) - ((`b`.`HargaSatuan` * `b`.`Jumlah`) * (`b`.`PersenDiskon` / 100)))) AS `TotalPenjualan`,(sum(((`b`.`HargaSatuan` * `b`.`Jumlah`) - ((`b`.`HargaSatuan` * `b`.`Jumlah`) * (`b`.`PersenDiskon` / 100)))) - `a`.`Potongan`) AS `TotalPembayaran`,`a`.`JumlahUang` AS `JumlahUang`,`a`.`KodePegawai` AS `KodePegawai` from (`penjualan` `a` join `penjualan_detil` `b` on((`a`.`NomorTransaksi` = `b`.`NomorTransaksi`))) where ((`a`.`Tanggal` >= '2021-08-21 00:00:00') and (`a`.`Tanggal` <= '2021-08-21 22:30:26')) group by `a`.`NomorTransaksi`;

-- --------------------------------------------------------

--
-- Structure for view `view_noteuntukkonsumen`
--
DROP TABLE IF EXISTS `view_noteuntukkonsumen`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_noteuntukkonsumen` AS select `a`.`KodeBarang` AS `KodeBarang`,`b`.`NamaBarang` AS `NamaBarang`,`a`.`HargaSatuan` AS `HargaSatuan`,`a`.`Jumlah` AS `Jumlah`,`a`.`PersenDiskon` AS `PersenDiskon`,(`a`.`HargaSatuan` * `a`.`Jumlah`) AS `SubTotal`,((`a`.`HargaSatuan` * `a`.`Jumlah`) * (`a`.`PersenDiskon` / 100)) AS `JumlahDiskon`,((`a`.`HargaSatuan` * `a`.`Jumlah`) - ((`a`.`HargaSatuan` * `a`.`Jumlah`) * (`a`.`PersenDiskon` / 100))) AS `JumlahHarga` from (`penjualan_detil` `a` join `barang` `b` on((`a`.`KodeBarang` = `b`.`KodeBarang`))) where (`a`.`NomorTransaksi` = 'PNJ000000000012') group by `a`.`NomorTransaksi`;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
 ADD PRIMARY KEY (`KodeBarang`);

--
-- Indexes for table `hak_akses`
--
ALTER TABLE `hak_akses`
 ADD PRIMARY KEY (`NamaAkses`);

--
-- Indexes for table `kas`
--
ALTER TABLE `kas`
 ADD PRIMARY KEY (`NomorTransaksi`), ADD KEY `KodePegawai` (`KodePegawai`);

--
-- Indexes for table `konsumen`
--
ALTER TABLE `konsumen`
 ADD PRIMARY KEY (`KodeKonsumen`);

--
-- Indexes for table `pegawai`
--
ALTER TABLE `pegawai`
 ADD PRIMARY KEY (`KodePegawai`), ADD KEY `NamaAkses` (`NamaAkses`);

--
-- Indexes for table `pemasok`
--
ALTER TABLE `pemasok`
 ADD PRIMARY KEY (`KodePemasok`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
 ADD PRIMARY KEY (`NomorTransaksi`), ADD KEY `KodePemasok` (`KodePemasok`), ADD KEY `KodePegawai` (`KodePegawai`);

--
-- Indexes for table `pembelian_detil`
--
ALTER TABLE `pembelian_detil`
 ADD KEY `NomorTransaksi` (`NomorTransaksi`), ADD KEY `KodeBarang` (`KodeBarang`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
 ADD PRIMARY KEY (`NomorTransaksi`), ADD KEY `KodePegawai` (`KodePegawai`), ADD KEY `KodeKonsumen` (`KodeKonsumen`);

--
-- Indexes for table `penjualan_detil`
--
ALTER TABLE `penjualan_detil`
 ADD KEY `KodeBarang` (`KodeBarang`), ADD KEY `NomorTransaksi` (`NomorTransaksi`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `kas`
--
ALTER TABLE `kas`
ADD CONSTRAINT `kas_ibfk_1` FOREIGN KEY (`KodePegawai`) REFERENCES `pegawai` (`KodePegawai`) ON UPDATE CASCADE;

--
-- Constraints for table `pegawai`
--
ALTER TABLE `pegawai`
ADD CONSTRAINT `pegawai_ibfk_1` FOREIGN KEY (`NamaAkses`) REFERENCES `hak_akses` (`NamaAkses`) ON UPDATE CASCADE;

--
-- Constraints for table `pembelian`
--
ALTER TABLE `pembelian`
ADD CONSTRAINT `pembelian_ibfk_1` FOREIGN KEY (`KodePemasok`) REFERENCES `pemasok` (`KodePemasok`) ON UPDATE CASCADE,
ADD CONSTRAINT `pembelian_ibfk_2` FOREIGN KEY (`KodePegawai`) REFERENCES `pegawai` (`KodePegawai`) ON UPDATE CASCADE;

--
-- Constraints for table `pembelian_detil`
--
ALTER TABLE `pembelian_detil`
ADD CONSTRAINT `pembelian_detil_ibfk_2` FOREIGN KEY (`NomorTransaksi`) REFERENCES `pembelian` (`NomorTransaksi`) ON UPDATE CASCADE,
ADD CONSTRAINT `pembelian_detil_ibfk_3` FOREIGN KEY (`KodeBarang`) REFERENCES `barang` (`KodeBarang`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `penjualan`
--
ALTER TABLE `penjualan`
ADD CONSTRAINT `penjualan_ibfk_1` FOREIGN KEY (`KodePegawai`) REFERENCES `pegawai` (`KodePegawai`) ON UPDATE CASCADE,
ADD CONSTRAINT `penjualan_ibfk_2` FOREIGN KEY (`KodeKonsumen`) REFERENCES `konsumen` (`KodeKonsumen`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Constraints for table `penjualan_detil`
--
ALTER TABLE `penjualan_detil`
ADD CONSTRAINT `penjualan_detil_ibfk_2` FOREIGN KEY (`NomorTransaksi`) REFERENCES `penjualan` (`NomorTransaksi`) ON UPDATE CASCADE,
ADD CONSTRAINT `penjualan_detil_ibfk_3` FOREIGN KEY (`KodeBarang`) REFERENCES `barang` (`KodeBarang`) ON DELETE NO ACTION ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
