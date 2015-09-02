INCLUDEPATH=-I	"./include"
Main:Main.o	Yaya.o	Arac.o
	g++ Main.o Yaya.o Arac.o -o ./bin/Main
Main.o:./src/Main.cpp	
	g++ -c $(INCLUDEPATH) ./src/Main.cpp
Yaya.o:./src/Yaya.cpp
	g++ -c $(INCLUDEPATH) ./src/Yaya.cpp
Arac.o: ./src/Arac.cpp
	g++ -c $(INCLUDEPATH) ./src/Arac.cpp
	
clean:
	del *.o