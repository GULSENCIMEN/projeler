#include "piksel.h"
#include<QtGui/qpainter.h>

piksel::piksel()
{

	x           = 100;
	y           = 100;
	Width		= 20;
}


void piksel::draw(QPainter* pntr)
{


}
void piksel::setPosition ( int x, int y)		//pikselin hangi pozisyonda �izilece�ini belirtir
{
	this->x=x;
	this->y=y;
}
 	
void piksel::changeState ()		//pikselin i�erisini doldurup doldurmayaca��n� belirtir
{
if(piksel is filled)=true;
else =false;
}

void piksel::setWidth ( int Width);
{
 this->Width=Width;
}
bool Piksel::getState()
{
   if(isFilled)
   return true;
   
   return false;
}
