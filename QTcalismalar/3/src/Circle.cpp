/**
* @file B111210043-B111210013_1.��RET�M_�DEV3
* @description QT k�t�phaneleri ile y���n veri yap�s� kullanarak basit bir �izim program� tasarlamakt�r.
* @course 1.��retim A grubu
* @assignment 3
* @date 30.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/
#include "Circle.h"
#include<QtGui/qpainter>
#include "Shape.h"
class QPainter;
class Rectangle:public Shape

void Ourwindow::paintevent(QPaintEvent*pe)
{
Qpainter painter(this);
QPen pen(Qt::SolidLine,3);
painter.setPen(pen);
painter.drawLine(0,0,100,100);

}