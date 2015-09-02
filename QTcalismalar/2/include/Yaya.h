/**
* @file B111210013-B111210013
* @description Console'da baðlý liste yapýsý kullanarak bir uygulama yapmak.
* @course 1.ÖÐRETÝM A GRUBU
* @assignment 4
* @date 15.11.2012
* @author GÜLSEN ÇÝMEN-YAÐMUR AYGÜL- gs.1905.glsn@hotmail.com
*/
#ifndef Yaya_h
#define Yaya_h
#include <iostream>
#include <string>
#include <time.h>
#include <dos.h>
#include <windows.h>
#include <conio.h>
using namespace std;

class Yaya
{
public:
	int			KimlikNo;
	int			Oncelik;
	string Saat;
	Yaya*	Sonraki; 
	
	Yaya()
	{
		time_t rawtime;
		struct tm * timeinfo;
		char buffer [80];

		time ( &rawtime );
		timeinfo = localtime ( &rawtime );

		strftime (buffer,80,"%H:%M:%S",timeinfo);

		Saat=buffer;
		Sonraki=NULL;
	}
	void YayaEkle(Yaya* pEklenecek);
	void YayaEkle();
	void YayaGecir();
	void YayaGetir();
	void YListeyazdir();
};



#endif
