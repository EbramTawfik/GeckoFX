all: Skybound.Gecko.dll

clean:
	cd Skybound.Gecko && xbuild Skybound.Gecko.csproj /target:clean

Skybound.Gecko.dll: Skybound.Gecko/Skybound.Gecko.csproj
	cd Skybound.Gecko && xbuild Skybound.Gecko.csproj

install:
	install -d $(DESTDIR)/usr/lib
	install Skybound.Gecko/bin/Debug/Skybound.Gecko.dll $(DESTDIR)/usr/lib/Skybound.Gecko.dll
