/**
* @file g�lsen-ya�mur
* @description �zyineleme ve stack den yararlanarak floodfill algoritmas� ger�ekle�tirme
* @course 1.��retim A grubu
* @assignment 2
* @date 19.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/
#include "izgara.h"
#include<QtGui/qpainter.h>

izgara::izgara()
	{
		sutunSayisi = 10;
		satirSayisi = 10;
		Genislik    = 20;
	    Yukseklik   = 20;
		x           = 100;
		y           = 100;
	}
	void izgara::PozisyonAta(int x,int y)
	{
		this->x = x;
		this->y = y;

	}
	void izgara::SatirveSutunSayisi(int satir,int sutun)
	{
		this->satirSayisi = satir;
		this->sutunSayisi = sutun;
	}
	void izgara::BoyutAta(int Genislik,int Yukseklik)
	{
		this->Genislik = Genislik;
		this->Yukseklik = Yukseklik;
	}


	void izgara::Ciz(QPainter& painter)
	{

	for(int j=0;j<20;j++)
	{
	
	for(int i=0;i<20;i++)
	{
	
     painter.drawRect(x+Genislik*i,y,Genislik,Yukseklik);
	}
	y+=20;
	}



	}