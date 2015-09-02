/**
* @file gülsen-yaðmur
* @description özyineleme ve stack den yararlanarak floodfill algoritmasý gerçekleþtirme
* @course 1.öðretim A grubu
* @assignment 2
* @date 19.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/
#ifndef Piksel_h
#define Piksel_h
class QPainter;
class piksel
{
private:
bool isFilled
//piksel dolu ise true deðil ise false barýndýrýr.
//true olduðu durumda piksel içi dolu bir kare ve içi boþ bir kare çizerken
//false olduðu durumda sadece içi boþ bir kare çizecektir
int x;			//pikselin x eksenindeki baþlangýç deðeri
int y; 			//pikselin y eksenindeki baþlangýç deðeri
int Width; 		//pikselin geniþliði
public:

piksel( int x, int y);
piksel();

void draw(QPainter* pntr);			//pikseli çizdirir
void setPosition ( int x, int y); 	//pikselin hangi pozisyonda çizileceðini belirtir
void changeState (); 				//pikselin içerisini doldurup doldurmayacaðýný belirtir
void setWidth ( int Width); 		//pikselin boyutunu belirtir.
bool getState(); 					//pikselin dolu olup olmadýðý bilgisini getirir
};

#endif