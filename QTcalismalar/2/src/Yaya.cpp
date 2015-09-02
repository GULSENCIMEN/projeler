/**
* @file B111210013-B111210013
* @description Console'da baðlý liste yapýsý kullanarak bir uygulama yapmak.
* @course 1.ÖÐRETÝM A GRUBU
* @assignment 4
* @date 15.11.2012
* @author GÜLSEN ÇÝMEN-YAÐMUR AYGÜL- gs.1905.glsn@hotmail.com
*/
#include	"Yaya.h"
#include <iostream>
#include <string>
#include <time.h>
#include <dos.h>
#include <windows.h>
#include <conio.h>

using namespace std;

Yaya* YayaBasDugum = NULL ;
Yaya* yayaTemp;
Yaya* yayaTemp2;

	
void YayaEkle(Yaya* pEklenecek)
{
	if(YayaBasDugum==NULL)
	{
		YayaBasDugum=pEklenecek;
	}

	else if(YayaBasDugum->Oncelik>pEklenecek->Oncelik)
	{
		yayaTemp=YayaBasDugum;
		YayaBasDugum=pEklenecek;
		YayaBasDugum->Sonraki=yayaTemp;
	}
	else
	{	
		yayaTemp=YayaBasDugum;
		if(yayaTemp->Sonraki != NULL)
		{
		while(yayaTemp->Sonraki->Oncelik<pEklenecek->Oncelik)
			{
				yayaTemp=yayaTemp->Sonraki;
				if(yayaTemp->Sonraki==NULL)
				break;
			}
		}
		
		

		if(yayaTemp->Sonraki != NULL)
		{
			yayaTemp2=yayaTemp->Sonraki;
			yayaTemp->Sonraki=pEklenecek;
			yayaTemp->Sonraki->Sonraki=yayaTemp2;
		}

		else
		{
			yayaTemp->Sonraki=pEklenecek;
		}
		
	}
}

void YayaEkle()
{
	system("cls");
	cout<<"****** Yeni Yaya Ekle ******"<<endl<<endl;
	Yaya* Eklenecek=new Yaya();
	cout<<"Kimlik No: ";
	cin>>Eklenecek->KimlikNo;

	srand(time(NULL));
	Eklenecek->Oncelik=(rand()%10) + 1;
	cout<<endl;
	YayaEkle(Eklenecek);
	cout<<"Yaya basariyla eklendi!"<<endl;
	Sleep(500);
	system("cls");
}

void YayaGecir()
{
	yayaTemp=YayaBasDugum;
	YayaBasDugum=YayaBasDugum->Sonraki;
	delete yayaTemp;
	cout<<endl<<"Yaya basariyla gumrukten gecirildi!\n";
}


void YayaGetir()
{
	system("cls");
	int Sec;
	cout<<"**** Siradaki Yaya ****\n"<<endl<<"Kimlik No: "<<YayaBasDugum->KimlikNo<<"\nOncelik: "<<YayaBasDugum->Oncelik<<"\nGiris Saati: "<<YayaBasDugum->Saat<<endl<<"\nYayayi gecirmek istiyor musunuz?\n1-Evet\n2-Hayir\n\nSeciminiz: ";
	cin>>Sec;
	switch(Sec)
	{
		case 1:YayaGecir(); break;
		case 2:break;
	}
	cout<<endl;
}
void YListeyazdir()
{
	cout<<"**** Bekleyen Yaya Listesi *****"<<endl;
	Yaya* yayaTemp = YayaBasDugum;
	while(yayaTemp!=NULL)
	{	
		cout<<"-----------------------"<<endl;
		cout<<"Kimlik No: "<<yayaTemp->KimlikNo<<endl;
		cout<<"Giris Saati: "<<yayaTemp->Saat<<endl;
		cout<<"Oncelik: "<<yayaTemp->Oncelik<<endl<<endl;
		yayaTemp = yayaTemp->Sonraki;
	}
	
}
