all: Skybound.Gecko.dll

clean:
	rm Skybound.Gecko.dll
	rm Skybound.Gecko/bin/Debug/Skybound.Gecko.dll

Skybound.Gecko.dll: Skybound.Gecko/Skybound.Gecko.csproj
	cd Skybound.Gecko && xbuild Skybound.Gecko.csproj
	cp Skybound.Gecko/bin/Debug/Skybound.Gecko.dll .

