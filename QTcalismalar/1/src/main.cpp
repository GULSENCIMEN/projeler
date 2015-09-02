/**
* @file gülsen-yaðmur
* @description özyineleme ve stack den yararlanarak floodfill algoritmasý gerçekleþtirme
* @course 1.öðretim A grubu
* @assignment 2
* @date 19.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
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
