/**
* @file g�lsen-ya�mur
* @description �zyineleme ve stack den yararlanarak floodfill algoritmas� ger�ekle�tirme
* @course 1.��retim A grubu
* @assignment 2
* @date 19.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/
#include "pencerem.h"
#include<QApplication>

int main(int argc,char**argv)

{

QApplication app(argc,argv);

pencerem*pWindow=new pencerem();
pWindow->buildForm();
pWindow->show();

return app.exec();

}
