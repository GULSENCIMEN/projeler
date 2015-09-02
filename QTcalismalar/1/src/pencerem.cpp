/**
* @file gülsen-yaðmur
* @description özyineleme ve stack den yararlanarak floodfill algoritmasý gerçekleþtirme
* @course 1.öðretim A grubu
* @assignment 2
* @date 19.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/
#include "pencerem.h"
#include <QtGui/qpainter.h>
#include <QtGui/qevent.h>
#include<QtGui/QLineEdit.h>
#include "izgara.h"
#include "piksel.h"
#include "rectangle.h"

#include <QtGui/qpushbutton.h>
#include <QtGui/qmessagebox>
pencerem::pencerem()
{
	setFixedWidth(600);
	setFixedHeight(600);
	setWindowTitle("IZGARA ODEVI");	
	
}

void pencerem::buildForm()
{
	

	buton1	=	new	QPushButton("BeginFloodFill",this);
	buton2	=	new	QPushButton("ChooseSeed",this);
	buton1->setGeometry(176,520,100,30);
	buton2->setGeometry(315,520,100,30);
	connect(buton1,SIGNAL(clicked()),this,SLOT(clickedUndo()));
	connect(buton2,SIGNAL(clicked()),this,SLOT(clickedRedo()));
}
void pencerem::writeMessage(QString msg)
{
	QMessageBox	m;
	m.setText(msg);
	m.exec();
}
void pencerem::clickedUndo()
{
	writeMessage("undo");

}
void pencerem::clickedRedo()
{
	writeMessage("redo");

}

void pencerem::FloodFill(int x,int y)
{
  //Pikselin poniterýndan piksel nesnesi kur getState fonk ile x y koordinatlarýnýn dolu olup olmadýðýný konrol et.
  
 /*if(X>m_iDrawStartX && X<m_iDrawStartX+m_iDrawWidth)
  {
     if(Y>m_iDrawStartY && Y<m_iDrawStartY+m_iDrawWidth)
     {
	   return true;
	 }
	 return false;
 }
 return false;
 */

  FloodFill(x-1,y);
  FloodFill(x+1,y);
  FloodFill(x,y-1);
  FloodFill(x,y+1);

}
void pencerem::paintEvent(QPaintEvent* event)


{

	QPainter painter(this);

	QPen pen(Qt::red,2,Qt::SolidLine);

	painter.setPen(pen);

	izgara izg;
	izg.Ciz(painter);




	
}

void pencerem::buildGrid(int x,int y,int ColumnCount )
{
 //öz yinelemeli fonk. burda
}

void pencerem::mousePressEvent(QMouseEvent*event)
{

}
pencerem::~pencerem();
{
}
