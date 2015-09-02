/**
* @file B111210043-B111210013_1.ÖÐRETÝM_ÖDEV3
* @description QT kütüphaneleri ile yýðýn veri yapýsý kullanarak basit bir çizim programý tasarlamaktýr.
* @course 1.öðretim A grubu
* @assignment 3
* @date 30.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/
#ifndef OurWindow_h
#define OurWindow_h
#include "Stack.h"
#include<QtGui/qmainwindow>
class QPushButton;
class QRadioButton;
class Rectangle;
class QGroupBox;
class OurWindow:public QMainWindow
{
	Q_OBJECT
private:
Stack<Rectangle*>  m_pUndoList;
	QPushButton*	m_pBtnUndo;
	QPushButton*	m_pBtnBlackRedo;
	QPushButton*	m_pBtnGreenRedo;
	QPushButton*	m_pBtnBlueRedo;
	QRadioButton*	m_pRdbBlack;
	QRadioButton*	m_pRdbGreen;
	QRadioButton*	m_pRdbBlue;
	QRadioButton*	m_pRdbLine;
	QRadioButton*	m_pRdbRectangle;
	QRadioButton*	m_pRdbCircle;
	
	Rectangle*		m_pActiveRectangle;
	
	Rectangle*		m_pRectangleList[100];
	int				m_iRectangleCount;
	int				m_iDrawStartX;
	int				m_iDrawStartY;
	int				m_iDrawWidth;
	int deger1;
QGroupBox*  m_pGrpShapes;
	
public:
	
	OurWindow();
	~OurWindow();

	void buildForm();
	
	void writeMessage(QString str);
	
	
private:
	bool isMouseInside(int X,int Y);	
	
	void paintEvent(QPaintEvent* event);
	void mousePressEvent(QMouseEvent* event);
	void mouseMoveEvent(QMouseEvent* event);
	void mouseReleaseEvent(QMouseEvent* event);
	
	private slots:
		void clickUndo();
		void clickBlackRedo();
		void clickGreenRedo();
		void clickBlueRedo();
		void clickRdbBlack();
		void clickRdbGreen();
		void clickRdbBlue();
		

};


#endif
