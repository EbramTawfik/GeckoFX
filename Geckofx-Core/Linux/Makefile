all: geckofix.so

geckofix.so: HashFunctions.o
	g++ --shared -lstdc++ -o geckofix.so HashFunctions.o
	#strip geckofix.so

jemallocfix.o: jemallocfix.c
	gcc -c -fPIC jemallocfix.c -o jemallocfix.o

HashFunctions.o:
	g++ -c -fPIC -I/usr/include/firefox HashFunctions.cpp -o HashFunctions.o

clean:
	rm -f a.out geckofix.so HashFunctions.o
