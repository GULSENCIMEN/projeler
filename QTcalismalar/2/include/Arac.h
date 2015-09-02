/**
* @file B111210013-B111210013
* @description Console'da baðlý liste yapýsý kullanarak bir uygulama yapmak.
* @course 1.ÖÐRETÝM A GRUBU
* @assignment 4
* @date 15.11.2012
* @author GÜLSEN ÇÝMEN-YAÐMUR AYGÜL- gs.1905.glsn@hotmail.com
*/
#ifndef Arac_h
#define Arac_h
#include <iostream>
#include <string>
#include <time.h>
#include <dos.h>
#include <windows.h>
#include <conio.h>
using namespace std;
class Arac
{
public:
	string			Plaka;
	int			Oncelik;
	string Saat;
	Arac*	Sonraki; 
	
	Arac()
	{
		time_t rawtime;
		struct tm * timeinfo;
		char buffer [80];

		time ( &rawtime );
		timeinfo = localtime ( &rawtime );

		strftime (buffer,80,"%I:%M:%S",timeinfo);

		Saat=buffer;
		Sonraki=NULL;
	}
	void AracEkle(Arac* pEklenecek);
	void AracEkle();
	void AracGecir();
	void AracGetir();
	void AListeYazdir();
};
#endif
