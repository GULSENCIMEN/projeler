/**
* @file B111210043-B111210013_1.��RET�M_�DEV3
* @description QT k�t�phaneleri ile y���n veri yap�s� kullanarak basit bir �izim program� tasarlamakt�r.
* @course 1.��retim A grubu
* @assignment 3
* @date 30.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/
#include "Shape.h"
#include <QtGui/qpainter>

Shape::Shape()
{
    m_iStartX 		= 0;
	m_iStartY 		= 0;
	m_iEndX			= 0;
	m_iEndY			= 0;
	m_uiBorderColor	= Qt::blue;		
	m_uiInsideColor	= Qt::green;


}

//Dikd�rtgenin ba�lang�� koordinatlar�n� atayan fonksiyon

void Shape::setStartPosition(int sx,int sy)
{
	m_iStartX 	= sx;
	m_iStartY 	= sy;
}
//Dikd�rtgenin biti� koordinatlar�n� atayan fonksiyon
void Shape::setEndPosition(int ex,int ey)
{
	m_iEndX		= ex;
	m_iEndY		= ey;

}
void Shape::setBorderColor(unsigned int color)
{
	m_uiBorderColor	= color;
}
void Shape::setInsideColor(unsigned int color)
{
	m_uiInsideColor	= color;
}
/*
unsigned int getInsideColor()
{

}
*/

