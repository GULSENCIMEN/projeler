/**
* @file g�lsen-ya�mur
* @description �zyineleme ve stack den yararlanarak floodfill algoritmas� ger�ekle�tirme
* @course 1.��retim A grubu
* @assignment 2
* @date 19.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
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
	void buildGrid(int x,int y,int ColumnCount ); //pikselleri olu�turan fonksiyon


private:
	//void paintEvent(QPaintEvent* pe);
	int x;
	int y;
	QPushButton	*buton1;
	QPushButton	*buton2;

private:

void paintEvent(QPaintEvent* event); //pencerenin �izim fonksiyonu

void mousePressEvent(QMouseEvent* event); //fare butonu t�kland���nda �a�r�lan fonksiyon

void FloodFill(int x,int y); //kapal� �eklin i�erisini dolduran fonksiyon
private slots:
	void clickBtnBeginFill();
	void clickBtnChooseSeed();
	
	};

#endif // PENCEREM_H
