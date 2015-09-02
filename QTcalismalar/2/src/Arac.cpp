/**
* @file B111210013-B111210013
* @description Console'da baðlý liste yapýsý kullanarak bir uygulama yapmak.
* @course 1.ÖÐRETÝM A GRUBU
* @assignment 4
* @date 15.11.2012
* @author GÜLSEN ÇÝMEN-YAÐMUR AYGÜL- gs.1905.glsn@hotmail.com
*/
#include	"Arac.h"
#include <iostream>
#include <string>
#include <time.h>
#include <dos.h>
#include <windows.h>
#include <conio.h>

using namespace std;

Arac* AracBasDugum = NULL ;
Arac* aracTemp;
Arac* aracTemp2;






// Arac icin//
void AracEkle(Arac* pEklenecek)
{
	if(AracBasDugum==NULL)
	{
		AracBasDugum=pEklenecek;
	}

	else if(AracBasDugum->Oncelik>pEklenecek->Oncelik)
	{
		aracTemp=AracBasDugum;
		AracBasDugum=pEklenecek;
		AracBasDugum->Sonraki=aracTemp;
		delete pEklenecek;
	}
	else
	{	
		aracTemp=AracBasDugum;
		if(aracTemp->Sonraki != NULL)
		{
		while(aracTemp->Sonraki->Oncelik<pEklenecek->Oncelik)
			{
				aracTemp=aracTemp->Sonraki;
				if(aracTemp->Sonraki==NULL)
				break;
			}
		}
		
		

		if(aracTemp->Sonraki != NULL)
		{
			aracTemp2=aracTemp->Sonraki;
			aracTemp->Sonraki=pEklenecek;
			aracTemp->Sonraki->Sonraki=aracTemp2;
			delete pEklenecek;
		}

		else
		{
			aracTemp->Sonraki=pEklenecek;
		}
		
	}
}

void AracEkle()
{
	system("cls");
	cout<<"****** Yeni Arac Ekle ******"<<endl<<endl;
	Arac* Eklenecek=new Arac();
	cout<<"Plaka: ";
	cin>>Eklenecek->Plaka;

	srand(time(NULL));
	Eklenecek->Oncelik=(rand()%10) + 1;
	cout<<endl;
	AracEkle(Eklenecek);
	cout<<"Arac basariyla eklendi!"<<endl;
	Sleep(500);
	system("cls");
}

void AracGecir()
{
	aracTemp=AracBasDugum;
	AracBasDugum=AracBasDugum->Sonraki;
	delete aracTemp;
	cout<<endl<<"Arac basariyla gumrukten gecirildi!\n";
}


void AracGetir()
{
	system("cls");
	int Sec;
	cout<<"**** Siradaki Arac ****\n"<<endl<<"Plaka: "<<AracBasDugum->Plaka<<"\nOncelik: "<<AracBasDugum->Oncelik<<"\nGiris Saati: "<<AracBasDugum->Saat<<endl<<"\nAraci gecirmek istiyor musunuz?\n1-Evet\n2-Hayir\n\nSeciminiz: ";
	cin>>Sec;
	switch(Sec)
	{
		case 1:AracGecir(); break;
		case 2:break;
	}
	cout<<endl;
}
void	AListeYazdir()
{
	cout<<"**** Bekleyen Arac Listesi *****"<<endl;
	Arac* aracTemp = AracBasDugum;
	while(aracTemp!=NULL)
	{	
		cout<<"-----------------------"<<endl;
		cout<<"Plaka: "<<aracTemp->Plaka<<endl;
		cout<<"Giris Saati: "<<aracTemp->Saat<<endl;
		cout<<"Oncelik: "<<aracTemp->Oncelik<<endl<<endl;
		aracTemp = aracTemp->Sonraki;
	}
}
	
