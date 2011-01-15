all: Skybound.Gecko.dll

clean:
	cd Skybound.Gecko && xbuild Skybound.Gecko.csproj /target:clean

Skybound.Gecko.dll: Skybound.Gecko/Skybound.Gecko.csproj
	cd Skybound.Gecko && xbuild Skybound.Gecko.csproj

install:
	mkdir -p $(DESTDIR)/lib
	cp Skybound.Gecko/bin/Debug/Skybound.Gecko.dll $(DESTDIR)/lib/Skybound.Gecko.dll
