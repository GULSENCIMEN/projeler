/**
* @file gülsen-yaðmur
* @description özyineleme ve stack den yararlanarak floodfill algoritmasý gerçekleþtirme
* @course 1.öðretim A grubu
* @assignment 2
* @date 19.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/
#ifndef PENCEREM_H
#define PENCEREM_H

#include <QtGui/QMainWindow>

class QPushButton;
class piksel;
class rectangle;


class pencerem : public QMainWindow
{
	Q_OBJECT

public:
	pencerem();
	~pencerem();
	void buildForm();
	void writeMessage(QString str);
	void buildGrid(int x,int y,int ColumnCount ); //pikselleri oluþturan fonksiyon


private:
	//void paintEvent(QPaintEvent* pe);
	int x;
	int y;
	QPushButton	*buton1;
	QPushButton	*buton2;

private:

void paintEvent(QPaintEvent* event); //pencerenin çizim fonksiyonu

void mousePressEvent(QMouseEvent* event); //fare butonu týklandýðýnda çaðrýlan fonksiyon

void FloodFill(int x,int y); //kapalý þeklin içerisini dolduran fonksiyon
private slots:
	void clickBtnBeginFill();
	void clickBtnChooseSeed();
	
	};

#endif // PENCEREM_H
