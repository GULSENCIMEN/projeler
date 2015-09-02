/**
* @file B111210043-B111210013_1.��RET�M_�DEV3
* @description QT k�t�phaneleri ile y���n veri yap�s� kullanarak basit bir �izim program� tasarlamakt�r.
* @course 1.��retim A grubu
* @assignment 3
* @date 30.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/
#ifndef Shape_hpp
#define Shape_hpp
class QPainter;
class Shape
{
public:
Shape();
void setBorderColor(unsignedint color);//Kenar renk kodunu atama fonksiyonu
void setInsideColor(unsignedint color);//��erisinin renk kodunu atama fonksiyonu
void setStartPosition(int sx,int sy); //Ba�lang�� koordinatlar�n� atama fonksiyonu
void setEndPosition(int ex,int ey); 
unsigned int InsideColor();
virtualvoid draw(QPainter* painter)=0;
protected:
unsignedint m_uiBorderColor; //K�e�elerin alaca�� renk kodu
unsignedint m_uiInsideColor; //�eklin i�erisinin alaca�� renk kodu
int m_iStartX; //D�rtgenin ba�lang�� koordinatlar
int m_iStartY;
int m_iEndX; //D�rtgenin biti� koordinatlar�
int m_iEndY;
};
#endif