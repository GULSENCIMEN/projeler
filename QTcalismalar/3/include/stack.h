/**
* @file B111210043-B111210013_1.��RET�M_�DEV3
* @description QT k�t�phaneleri ile y���n veri yap�s� kullanarak basit bir �izim program� tasarlamakt�r.
* @course 1.��retim A grubu
* @assignment 3
* @date 30.10.2012
* @author Ya�mur Ayg�l-G�lsen �imen b111210043@sakarya.edu.tr
*/



//Stack s�n�f� �ablonu
//�ablon s�n�flar�n�n prototipleri ile fonksiyon g�vdeleri ayn� .h dosyas� i�erisinde yaz�lmal�d�r

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
//�ablon s�n�f�n�n kurucu fonksiyonu oldu�u i�in ufak de�i�ikliklere u�ram��t�r
template<typename T>
Stack<T>::Stack()
{
	m_iSize 	= 10;
	m_iTop		= 0;
	m_pDatas 	= new T[m_iSize];
}
//stack yok edildi�inde heap den al�nm�� olan alan serbest b�rak�l�r
template<typename T>
Stack<T>::~Stack()
{
	delete[] m_pDatas;
}
//push fonksiyonu y���na eleman eklemeye yarar
//E�er eleman eklenemiyor ise fonksiyon false de�eri d�nd�r�r.
template<typename T>
bool Stack<T>::push(T item)
{
	if(m_iTop>=m_iSize)
		return false;
	
	m_pDatas[m_iTop] = item;
	
	m_iTop++;
	
	return true;
}
//push fonksiyonu y���ndan eleman ��karmaya yarar.
//Y���ndan ��kart�lacak eleman fonksiyonun parametresi aral��� ile al�nmal�d�r.
//E�er y���nda eleman bulunmuyor ise fonksiyon false de�eri d�nd�r�r.
template<typename T>
bool Stack<T>::pop(T& item)
{
	if(m_iTop<=0)
		return false;
		
	item = m_pDatas[m_iTop-1];
	
	m_iTop--;
	
	return true;
}
//isEmpty fonksiyonu y���n�n bo� oldu�u durumda true 
//aksi durumlarda false de�eri d�nd�r�r.
template<typename T>
bool Stack<T>::isEmpty()
{
	if(m_iTop==0)
		return true;
	return false;
}
//count fonksiyonu y���ndaki eleman say�s�n� d�nd�r�r.
template<typename T>
int Stack<T>::count()
{
	return m_iTop;
}