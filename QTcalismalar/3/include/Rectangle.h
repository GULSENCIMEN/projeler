/**
* @file B111210043-B111210013_1.��RET�M_�DEV3
* @description QT k�t�phaneleri ile y���n veri yap�s� kullanarak basit bir �izim program� tasarlamakt�r.
* @course 1.��retim A grubu
* @assignment 3
* @date 30.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/
#ifndef Rectangle_h
#define Rectangle_h


class QPainter;

class Rectangle
{
private:
	int				m_iStartX;
	int				m_iStartY;
	int				m_iEndX;
	int				m_iEndY;
	unsigned int	m_uiBorderColor;
	unsigned int	m_uiInsideColor;
	unsigned int	m_uiInsideColor2;
	unsigned int	m_uiInsideColor3;
	
	
public:
	Rectangle();
	
	void		setStartPosition(int x,int y,int deger);
	void		setEndPosition(int x,int y);
	void		setBorderColor(unsigned int color);
	void 		setInsideColor(unsigned int color);
	
	void		draw(QPainter* painter);
	int bizimdeger;
};


#endif