/**
* @file B111210043-B111210013_1.ÖÐRETÝM_ÖDEV3
* @description QT kütüphaneleri ile yýðýn veri yapýsý kullanarak basit bir çizim programý tasarlamaktýr.
* @course 1.öðretim A grubu
* @assignment 3
* @date 30.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/
#include "Rectangle.h"
#include<QtGui/qpainter>



Rectangle::Rectangle()
{
	m_iStartX		= 0;
	m_iStartY		= 0;
	m_iEndX			= 0;
	m_iEndY			= 0;
	m_uiBorderColor	= Qt::blue;
	m_uiInsideColor	= Qt::black;	
	m_uiInsideColor2	= Qt::green;	
	m_uiInsideColor3	= Qt::blue;	
	bizimdeger=1;
}
void Rectangle::setStartPosition(int x,int y,int deger)
{
	m_iStartX		= x;
	m_iStartY		= y;
	bizimdeger=deger;
}
void Rectangle::setEndPosition(int x,int y)
{
	m_iEndX			= x;
	m_iEndY			= y;
}
void Rectangle::setBorderColor(unsigned int color)
{
	m_uiBorderColor	= color;
}

void Rectangle::setInsideColor( unsigned int color)
{
	m_uiInsideColor	= color;
}

void Rectangle::draw(QPainter* painter)
{
if(bizimdeger==11)
	{painter->fillRect(m_iStartX,m_iStartY,m_iEndX-m_iStartX,m_iEndY-m_iStartY,(Qt::GlobalColor)m_uiInsideColor);
	
	
	QPen pen((Qt::GlobalColor)m_uiBorderColor);
	pen.setWidth(4);
	painter->setPen(pen);
	painter->drawRect(m_iStartX,m_iStartY,m_iEndX-m_iStartX,m_iEndY-m_iStartY);
	}
	
	else if(bizimdeger==21)
	{painter->fillRect(m_iStartX,m_iStartY,m_iEndX-m_iStartX,m_iEndY-m_iStartY,(Qt::GlobalColor)m_uiInsideColor2);
	
	
	QPen pen((Qt::GlobalColor)m_uiBorderColor);
	pen.setWidth(4);
	painter->setPen(pen);
	painter->drawRect(m_iStartX,m_iStartY,m_iEndX-m_iStartX,m_iEndY-m_iStartY);
	}
	else if(bizimdeger==31)
	{painter->fillRect(m_iStartX,m_iStartY,m_iEndX-m_iStartX,m_iEndY-m_iStartY,(Qt::GlobalColor)m_uiInsideColor3);
	
	
	QPen pen((Qt::GlobalColor)m_uiBorderColor);
	pen.setWidth(4);
	painter->setPen(pen);
	painter->drawRect(m_iStartX,m_iStartY,m_iEndX-m_iStartX,m_iEndY-m_iStartY);
	}
	

}