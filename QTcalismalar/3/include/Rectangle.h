/**
* @file B111210043-B111210013_1.ÖÐRETÝM_ÖDEV3
* @description QT kütüphaneleri ile yýðýn veri yapýsý kullanarak basit bir çizim programý tasarlamaktýr.
* @course 1.öðretim A grubu
* @assignment 3
* @date 30.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
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