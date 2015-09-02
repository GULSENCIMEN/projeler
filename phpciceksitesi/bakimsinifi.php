<?php
/**
 * Created by PhpStorm.
 * User: user
 * Date: 26.05.2014
 * Time: 16:44
 */

class bakimsinifi {

    private $bakimid;
    private  $bakimadi;
    private  $bakimicerik;

    function __construct($bakimadi, $bakimicerik)
    {
        $this->setbakimadi($bakimadi);
        $this->setbakimicerik($bakimicerik);
    }

    public function setbakimid($bakimid)
    {
        $this->bakimid = $bakimid;
    }

    public function getbakimid()
    {
        return $this->bakimid;
    }
    public function setbakimadi($bakimadi)
    {
        $this->bakimadi = $bakimadi;
    }

    public function getbakimadi()
    {
        return $this->bakimadi;
    }

    public function setbakimicerik($bakimicerik)
    {
        $this->bakimicerik = $bakimicerik;
    }

    public function getbakimicerik()
    {
        return $this->bakimicerik;
    }

    public function listele()
    {
        return "{$this->getbakimadi()}"."{$this->getbakimicerik()}";
    }
} 