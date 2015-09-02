/**
* @file B111210043-B111210013_1.ÖÐRETÝM_ÖDEV3
* @description QT kütüphaneleri ile yýðýn veri yapýsý kullanarak basit bir çizim programý tasarlamaktýr.
* @course 1.öðretim A grubu
* @assignment 3
* @date 30.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/
#include "OurWindow.h"
#include "Rectangle.h"
#include <QtGui/qpainter>
#include <QtGui/qpushbutton>
#include <QtGui/qmessagebox>
#include <QtGui/qradiobutton>
#include <QtGui/qmouseevent>
#include <QtGui/qgroupbox>
#include <QtGui/QHBoxLayout>

OurWindow::OurWindow()
{
	setFixedWidth(600);
	setFixedHeight(600);
	
	
	m_iDrawStartX		= 100;
	m_iDrawStartY		= 100;
	m_iDrawWidth		= 400;
	m_pActiveRectangle 	= NULL;
	m_iRectangleCount	= 0;
}

OurWindow::~OurWindow()
{
}
void OurWindow::writeMessage(QString msg)
{
	QMessageBox m;
	m.setText(msg);
	m.exec();
}
void OurWindow::clickUndo()
{
	Rectangle* pRect	=m_pRectangleList[m_iRectangleCount-1];
	if(!m_pUndoList.push(pRect))
	return;
	m_iRectangleCount--;

	repaint ();
}
void OurWindow::clickBlackRedo()
{
	if(m_iRectangleCount==100)
	return;
	Rectangle* pRect;
	if(!m_pUndoList.pop(pRect))
	return;
	m_pRectangleList[m_iRectangleCount];
	
	 m_iRectangleCount++;
	repaint();
	
	
}
void OurWindow::clickGreenRedo()
{
writeMessage("GreenRedo");	
}
void OurWindow::clickBlueRedo()
{
writeMessage("BlueRedo");	
	
}
void OurWindow::clickRdbBlack()
{
	deger1=11;
	//writeMessage("Black");
}
void OurWindow::clickRdbGreen()
{
	deger1=21;
	//writeMessage("Green");
}
void OurWindow::clickRdbBlue()
{
	deger1=31;
	//writeMessage("Blue");
}

bool OurWindow::isMouseInside(int X,int Y)
{
	if(X>m_iDrawStartX&&X<m_iDrawStartX+m_iDrawWidth)
	{
		if(Y>m_iDrawStartY&&Y<m_iDrawStartY+m_iDrawWidth)
		{
			return true;
		}
		return false;
	}
	return false;
}
void OurWindow::buildForm()
{
	m_pBtnUndo = new QPushButton("Undo",this);
	m_pBtnBlackRedo = new QPushButton("BlackRedo",this);
	m_pBtnGreenRedo = new QPushButton("GreenRedo",this);
	m_pBtnBlueRedo = new QPushButton("BlueRedo",this);
	m_pRdbBlack= new QRadioButton("Black",this);
	m_pRdbGreen= new QRadioButton("Green",this);
	m_pRdbBlue= new QRadioButton("Blue",this);
	m_pRdbLine= new QRadioButton("Line",this);
	m_pRdbRectangle= new QRadioButton("Rectangle",this);
	m_pRdbCircle= new QRadioButton("Circle",this);
	
	m_pGrpShapes  =new QGroupBox(this);
	
	m_pGrpShapes->setGeometry(150,40,300,40);
	
	QHBoxLayout* pLayoutMove   =new QHBoxLayout();
	
	
	pLayoutMove->addWidget(m_pRdbLine);
	pLayoutMove->addWidget(m_pRdbRectangle);
	pLayoutMove->addWidget(m_pRdbCircle);
	
	m_pGrpShapes->setLayout(pLayoutMove);
	
	m_pBtnUndo->setGeometry(150,550,100,30);
	m_pBtnBlackRedo->setGeometry(350,510,90,25);
	m_pBtnGreenRedo->setGeometry(350,540,90,25);
	m_pBtnBlueRedo->setGeometry(350,570,90,25);
	m_pRdbBlack->setGeometry(10,150,60,30);
	m_pRdbGreen->setGeometry(10,180,60,30);
	m_pRdbBlue->setGeometry(10,210,60,30);
	
	QObject::connect(m_pBtnUndo,SIGNAL(clicked()),this,SLOT(clickUndo()));
	QObject::connect(m_pBtnBlackRedo,SIGNAL(clicked()),this,SLOT(clickBlackRedo()));
	QObject::connect(m_pBtnGreenRedo,SIGNAL(clicked()),this,SLOT(clickGreenRedo()));
	QObject::connect(m_pBtnBlueRedo,SIGNAL(clicked()),this,SLOT(clickBlueRedo()));
	QObject::connect(m_pRdbBlack,SIGNAL(toggled(bool)),this,SLOT(clickRdbBlack()));
	QObject::connect(m_pRdbGreen,SIGNAL(toggled(bool)),this,SLOT(clickRdbGreen()));
	QObject::connect(m_pRdbBlue,SIGNAL(toggled(bool)),this,SLOT(clickRdbBlue()));
}
void OurWindow::mousePressEvent(QMouseEvent* event)
{
	int X = event->x();
	int Y = event->y();

	if(!isMouseInside(X,Y))
		return ;


	if(m_pActiveRectangle)
		delete m_pActiveRectangle;
	
	m_pActiveRectangle = new Rectangle();
	
	m_pActiveRectangle->setStartPosition(X,Y,deger1);
}
void OurWindow::mouseMoveEvent(QMouseEvent* event)
{

	int X = event->x();
	int Y = event->y();
	
	if(!isMouseInside(X,Y))
		return ;
		
	
	if(m_pActiveRectangle)
	{
		m_pActiveRectangle->setEndPosition(X,Y);
	}
	repaint();	
	
}
void OurWindow::mouseReleaseEvent(QMouseEvent* event)
{
	int X = event->x();
	int Y = event->y();
	if(!isMouseInside(X,Y))
		return;
	if(m_pActiveRectangle)
	{
		m_pActiveRectangle->setEndPosition(X,Y);
		
		m_pRectangleList[m_iRectangleCount] = m_pActiveRectangle;
		
		m_iRectangleCount++;
		
		m_pActiveRectangle = NULL;
		
	}
	repaint();
}
void OurWindow::paintEvent(QPaintEvent* event)
{

//if blue is checked>>deger=1

	QPainter painter(this);
	
	
	QPen pen(Qt::black);
	pen.setWidth(6);
	
	painter.setPen(pen);
	painter.drawRoundedRect(m_iDrawStartX,m_iDrawStartY,m_iDrawWidth,m_iDrawWidth,10,10);
	
	
	if(m_pActiveRectangle)
		m_pActiveRectangle->draw(&painter);
		
		
	for(int i=0;i<m_iRectangleCount;i++)
		m_pRectangleList[i]->draw(&painter);
	
}