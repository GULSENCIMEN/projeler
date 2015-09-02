<?php
	class DBException extends Exception
	{
		public function hataGoruntule()
		{
			echo "Message: " . $this -> getMessage() . "<br />";
			echo "File: " . $this -> getFile() . "<br />";
			echo "Line: " . $this -> getLine();
		}

	}
?>