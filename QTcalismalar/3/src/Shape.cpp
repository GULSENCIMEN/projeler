/**
* @file B111210043-B111210013_1.ÖÐRETÝM_ÖDEV3
* @description QT kütüphaneleri ile yýðýn veri yapýsý kullanarak basit bir çizim programý tasarlamaktýr.
* @course 1.öðretim A grubu
* @assignment 3
* @date 30.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
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

//Dikdörtgenin baþlangýç koordinatlarýný atayan fonksiyon

void Shape::setStartPosition(int sx,int sy)
{
	m_iStartX 	= sx;
	m_iStartY 	= sy;
}
//Dikdörtgenin bitiþ koordinatlarýný atayan fonksiyon
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

