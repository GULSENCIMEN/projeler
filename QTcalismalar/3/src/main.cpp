/**
* @file B111210043-B111210013_1.��RET�M_�DEV3
* @description QT k�t�phaneleri ile y���n veri yap�s� kullanarak basit bir �izim program� tasarlamakt�r.
* @course 1.��retim A grubu
* @assignment 3
* @date 30.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
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
