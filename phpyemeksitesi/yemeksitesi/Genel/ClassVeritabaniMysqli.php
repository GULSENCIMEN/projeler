<?php
	require_once 'Ayarlar.php';
	require_once 'ClassIstisnaVeritabani.php';


	class Veritabani
	{
        private $baglantiNo;

        public function getBaglantiNo()
		{
			return $this -> baglantiNo;
		}

		public function __construct()
		{
			global $sunucu, $kullaniciAdi, $sifre, $veritabani;
			$this -> baglantiNo = mysqli_connect($sunucu, $kullaniciAdi, $sifre, $veritabani);

			// Bağlantiyi doğrula
			if (!$this -> baglantiNo)
			{
				throw new DBException("Veritabanına bağlantı girişimi başarısız");
			}

			mysqli_set_charset($this -> baglantiNo, "utf8");

		}

		public function __destruct()
		{
			
			mysqli_close($this -> baglantiNo);
		}

		public function select($alanlar, $tabloAdi, $kosul)
		{
			$sql = "SELECT " . $alanlar . " FROM " . $tabloAdi . " WHERE " . $kosul;
			$result = mysqli_query($this -> baglantiNo, $sql);
			if (!$result)
			{
				throw new DBException("Seçme sorgusunda sorun var...");
			}
			
			return $result;
		}

        public function varMı( $tabloAdi, $kosul)
        {

            $sql = "SELECT count(*) FROM " . $tabloAdi . " WHERE " . $kosul;
            $result = mysqli_query($this -> baglantiNo, $sql);
            if (!$result)
            {
                throw new DBException("Seçme sorgusunda sorun var...");
            }

            return $result;
        }

		public function kayitSayisi($alanlar, $tabloAdi, $kosul)
		{

			return mysqli_num_rows($this->select($alanlar, $tabloAdi, $kosul));
		}
		
		public function update($alanlarDegerler, $tabloAdi, $kosul)
		{
			foreach ($alanlarDegerler as $alan => $deger)
			{
				$sql = "UPDATE $tabloAdi SET $alan = $deger WHERE $kosul";
				mysqli_query($this -> baglantiNo, $sql);
			}
			return true;
		}

		public function insert($tabloAdi, $degerler)
		{


			$columns = "";
			$values = "";

			foreach ($degerler as $column => $value)
			{
				$columns .= ($columns == "") ? "" : ", ";
				$columns .= $column;
				$values .= ($values == "") ? "" : ", ";
				$values .= $value;
			}

			$sql = "insert into $tabloAdi ($columns) values ($values)";

			if(!mysqli_real_query($this -> baglantiNo, $sql))
			{
				throw new DBException("Ekleme sorgusunda sorun var...");
			}

			return mysqli_insert_id($this -> baglantiNo);

		}

		function delete($tabloAdi, $kosul)
		{
			$sql = "DELETE FROM " . $tabloAdi . " WHERE " . $kosul;

			if (!mysqli_real_query($this -> baglantiNo, $sql))
			{
				throw new DBException("Silme sorgusunda sorun var...");
			}
		}
	}
?>