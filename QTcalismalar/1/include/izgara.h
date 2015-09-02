/**
* @file g�lsen-ya�mur
* @description �zyineleme ve stack den yararlanarak floodfill algoritmas� ger�ekle�tirme
* @course 1.��retim A grubu
* @assignment 2
* @date 19.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/
#ifndef izgara_h
#define izgara_h


class QPainter;


class izgara
{
private:
	int satirSayisi;
	int sutunSayisi;
	int Genislik;
	int Yukseklik;
	int x;
	int y;
public:

	izgara();
	
	void PozisyonAta(int x,int y);
	
	void SatirveSutunSayisi(int satir,int sutun);
	
	void BoyutAta(int Genislik,int Yukseklik);
	
    void Ciz(QPainter& painter);
	

};

#endif