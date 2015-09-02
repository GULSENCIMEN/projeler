/**
* @file g�lsen-ya�mur
* @description �zyineleme ve stack den yararlanarak floodfill algoritmas� ger�ekle�tirme
* @course 1.��retim A grubu
* @assignment 2
* @date 19.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/
#ifndef Piksel_h
#define Piksel_h
class QPainter;
class piksel
{
private:
bool isFilled
//piksel dolu ise true de�il ise false bar�nd�r�r.
//true oldu�u durumda piksel i�i dolu bir kare ve i�i bo� bir kare �izerken
//false oldu�u durumda sadece i�i bo� bir kare �izecektir
int x;			//pikselin x eksenindeki ba�lang�� de�eri
int y; 			//pikselin y eksenindeki ba�lang�� de�eri
int Width; 		//pikselin geni�li�i
public:

piksel( int x, int y);
piksel();

void draw(QPainter* pntr);			//pikseli �izdirir
void setPosition ( int x, int y); 	//pikselin hangi pozisyonda �izilece�ini belirtir
void changeState (); 				//pikselin i�erisini doldurup doldurmayaca��n� belirtir
void setWidth ( int Width); 		//pikselin boyutunu belirtir.
bool getState(); 					//pikselin dolu olup olmad��� bilgisini getirir
};

#endif