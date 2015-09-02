-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Anamakine: localhost
-- Üretim Zamanı: 24 May 2014, 20:18:29
-- Sunucu sürümü: 5.6.12-log
-- PHP Sürümü: 5.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Veritabanı: `bs`
--
CREATE DATABASE IF NOT EXISTS `bs` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `bs`;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `dersler`
--

CREATE TABLE IF NOT EXISTS `dersler` (
  `dersKodu` varchar(10) CHARACTER SET utf16 COLLATE utf16_turkish_ci NOT NULL DEFAULT '',
  `dersAdi` varchar(50) CHARACTER SET utf16 COLLATE utf16_turkish_ci NOT NULL,
  `icerik` varchar(500) CHARACTER SET utf16 COLLATE utf16_turkish_ci NOT NULL,
  `sicilNo` int(11) NOT NULL,
  PRIMARY KEY (`dersKodu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `dersler`
--

INSERT INTO `dersler` (`dersKodu`, `dersAdi`, `icerik`, `sicilNo`) VALUES
('BSM 103', 'ALGORITMALAR VE PROGRAMLAMA', 'Algoritma kavrami. Akis diyagramlari. Programlama ve programlama dili. Yapisal programlama kavrami. Dizi (vekt?r) kavrami. Dizilerde (vektorlerde) arama ve siralama algoritmalari.Cok boyutlu diziler (matrisler). Dosya (file) kullanimi ve dosyalarla ilgili temel kavramlar.Format kavrami ve girdi-cikti formatlama. Altprogram kavrami. Ozyineleme kavrami ve ozyinelemeli altprogram ornekleri.							', 3),
('FIZ 111', '    FIZIK I', 'Olcme ve birim sistemleri, statik, kinematik, dinamik.						', 1),
('MAT 111', '  MATEMATIK', 'On bilgiler, fonksiyonlar, limit ve sureklilik, turev, turevin uygulamalari								', 3),
('MAT 113', '    LINEER CEBIR', 'Lineer denklem sistemlerinin cozumu (kramer, ters matris, normal forma indirgeme y?ntemleri), matris ve determinant i?lemleri, matrisin ?z de?er ve ?z vekt?rleri, lineer uzaylarda lineer d?n???mler.									', 1),
('TUR 101', '        TURK DILI', 'Turkcenin yapi ve anlam bakimindan ozellikleri, temel eserler, toplum icinde kendini ifade etme dili dogru ve etkili kullanma yollari.							', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `koordinator`
--

CREATE TABLE IF NOT EXISTS `koordinator` (
  `sicilNo` int(11) NOT NULL DEFAULT '0',
  `Adi` varchar(20) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  `soyadi` varchar(20) CHARACTER SET utf8 COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`sicilNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `koordinator`
--

INSERT INTO `koordinator` (`sicilNo`, `Adi`, `soyadi`) VALUES
(1, 'Yılmaz ', 'DAŞCIOĞLU'),
(2, 'Emre', 'TABAR'),
(3, 'Hasan', 'KÜÇÜK');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
