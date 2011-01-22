all: Skybound.Gecko.dll

clean:
	cd Skybound.Gecko && xbuild Skybound.Gecko.csproj /target:clean
	rm Skybound.Gecko.dll

Skybound.Gecko.dll: Skybound.Gecko/Skybound.Gecko.csproj
	cd Skybound.Gecko && xbuild Skybound.Gecko.csproj
	cp Skybound.Gecko/bin/Debug/Skybound.Gecko.dll .

