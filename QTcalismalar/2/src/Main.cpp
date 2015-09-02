/**
* @file B111210013-B111210013
* @description Console'da baðlý liste yapýsý kullanarak bir uygulama yapmak.
* @course 1.ÖÐRETÝM A GRUBU
* @assignment 4
* @date 15.11.2012
* @author GÜLSEN ÇÝMEN-YAÐMUR AYGÜL- gs.1905.glsn@hotmail.com
*/
#include "Arac.h"
#include "Yaya.h"
#include <iostream>
#include <string>
#include <time.h>
#include <dos.h>
#include <windows.h>
#include <conio.h>

using namespace std;
class Yaya;
class Arac;
void AracEkle(Arac* pEklenecek);
	void AracEkle();
	void AracGecir();
	void AracGetir();
	void AListeYazdir();
	void YayaEkle(Yaya* pEklenecek);
	void YayaEkle();
	void YayaGecir();
	void YayaGetir();
	void YListeyazdir();

	void ListeYazdir()
	{
		system("cls");
		YListeyazdir();
		cout<<endl;
		AListeYazdir();
	}

int main()
{
	int Secim=0;

	while(Secim!=6)
	{
	cout<<"******** Menu ************"<<endl;
	cout<<"1-Yeni yaya gelsin\n2-Siradaki yayayi gecir\n3-Yeni arac gelsin\n4-Siradaki araci gecir\n5-Son Durum\n6-Cikis\n";
	cout<<"**************************"<<endl<<"\nSeciminizi yapin:";

	cin>>Secim;

	switch(Secim)
	{
	case 1:YayaEkle();break;
	case 2:YayaGetir();break;
	case 3:AracEkle();break;
	case 4:AracGetir();break;
	case 5:ListeYazdir();break;
	case 6:break;
	}
	}


}
