/**
* @file B111210043-B111210013_1.ÖÐRETÝM_ÖDEV3
* @description QT kütüphaneleri ile yýðýn veri yapýsý kullanarak basit bir çizim programý tasarlamaktýr.
* @course 1.öðretim A grubu
* @assignment 3
* @date 30.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/
#include<QApplication>
#include "OurWindow.h"
int main(int argc,char** argv)
{
	QApplication app(argc,argv);
	
	OurWindow* pWnd = new OurWindow();
	
	pWnd->buildForm();
	pWnd->show();
	
	return app.exec();

}
