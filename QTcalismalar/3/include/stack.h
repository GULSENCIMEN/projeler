/**
* @file B111210043-B111210013_1.ÖÐRETÝM_ÖDEV3
* @description QT kütüphaneleri ile yýðýn veri yapýsý kullanarak basit bir çizim programý tasarlamaktýr.
* @course 1.öðretim A grubu
* @assignment 3
* @date 30.10.2012
* @author Yaðmur Aygül-Gülsen Çimen b111210043@sakarya.edu.tr
*/



//Stack sýnýfý þablonu
//Þablon sýnýflarýnýn prototipleri ile fonksiyon gövdeleri ayný .h dosyasý içerisinde yazýlmalýdýr

template<typename T>
class Stack
{
private:
	T*		m_pDatas;
	int		m_iTop;
	int		m_iSize;
public:
	Stack();
	~Stack();
	
	bool	push(T item);
	bool	pop(T& item);
	bool	isEmpty();
	int		count();
	
};

//Stack kurucu fonksiyonu.
//Þablon sýnýfýnýn kurucu fonksiyonu olduðu için ufak deðiþikliklere uðramýþtýr
template<typename T>
Stack<T>::Stack()
{
	m_iSize 	= 10;
	m_iTop		= 0;
	m_pDatas 	= new T[m_iSize];
}
//stack yok edildiðinde heap den alýnmýþ olan alan serbest býrakýlýr
template<typename T>
Stack<T>::~Stack()
{
	delete[] m_pDatas;
}
//push fonksiyonu yýðýna eleman eklemeye yarar
//Eðer eleman eklenemiyor ise fonksiyon false deðeri döndürür.
template<typename T>
bool Stack<T>::push(T item)
{
	if(m_iTop>=m_iSize)
		return false;
	
	m_pDatas[m_iTop] = item;
	
	m_iTop++;
	
	return true;
}
//push fonksiyonu yýðýndan eleman çýkarmaya yarar.
//Yýðýndan çýkartýlacak eleman fonksiyonun parametresi aralýðý ile alýnmalýdýr.
//Eðer yýðýnda eleman bulunmuyor ise fonksiyon false deðeri döndürür.
template<typename T>
bool Stack<T>::pop(T& item)
{
	if(m_iTop<=0)
		return false;
		
	item = m_pDatas[m_iTop-1];
	
	m_iTop--;
	
	return true;
}
//isEmpty fonksiyonu yýðýnýn boþ olduðu durumda true 
//aksi durumlarda false deðeri döndürür.
template<typename T>
bool Stack<T>::isEmpty()
{
	if(m_iTop==0)
		return true;
	return false;
}
//count fonksiyonu yýðýndaki eleman sayýsýný döndürür.
template<typename T>
int Stack<T>::count()
{
	return m_iTop;
}