all: geckofix.so

geckofix.so: jemallocfix.o HashFunctions.o
	gcc --shared  -o geckofix.so jemallocfix.o HashFunctions.o
	#strip geckofix.so

jemallocfix.o:
	gcc -c jemallocfix.c -o jemallocfix.o

HashFunctions.o:
	g++ -c -I/usr/include/firefox HashFunctions.cpp -o HashFunctions.o

clean:
	rm -f a.out geckofix.so jemallocfix.o HashFunctions.o
