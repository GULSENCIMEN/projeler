/**
* @file B111210043-B111210013_1.ÖÐRETÝM_ÖDEV3
* @description QT kütüphaneleri ile yýðýn veri yapýsý kullanarak basit bir çizim programý tasarlamaktýr.
* @course 1.öðretim A grubu
* @assignment 3
* @date 30.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/
#ifndef Shape_hpp
#define Shape_hpp
class QPainter;
class Shape
{
public:
Shape();
void setBorderColor(unsignedint color);//Kenar renk kodunu atama fonksiyonu
void setInsideColor(unsignedint color);//Ýçerisinin renk kodunu atama fonksiyonu
void setStartPosition(int sx,int sy); //Baþlangýç koordinatlarýný atama fonksiyonu
void setEndPosition(int ex,int ey); 
unsigned int InsideColor();
virtualvoid draw(QPainter* painter)=0;
protected:
unsignedint m_uiBorderColor; //Köeþelerin alacaðý renk kodu
unsignedint m_uiInsideColor; //Þeklin içerisinin alacaðý renk kodu
int m_iStartX; //Dörtgenin baþlangýç koordinatlar
int m_iStartY;
int m_iEndX; //Dörtgenin bitiþ koordinatlarý
int m_iEndY;
};
#endif