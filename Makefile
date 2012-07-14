all: Skybound.Gecko.dll

clean:
	cd Skybound.Gecko && xbuild /p:Configuration=Debug_Linux Skybound.Gecko.csproj /target:clean
#	cd Skybound.Gecko && xbuild /p:Configuration=Release_Linux Skybound.Gecko.csproj /target:clean
	cd GeckoFxTest && xbuild /p:Configuration=Debug_Linux GeckoFxTest.csproj /target:clean
#	cd GeckoFxTest && xbuild /p:Configuration=Release_Linux GeckoFxTest.csproj /target:clean
	rm -rf Skybound.Gecko/obj Skybound.Gecko/bin GeckoFxTest/obj GeckoFxTest/bin

Skybound.Gecko.dll: Skybound.Gecko/Skybound.Gecko.csproj
	cd Skybound.Gecko && xbuild /p:Configuration=Debug_Linux Skybound.Gecko.csproj
#	cd Skybound.Gecko && xbuild /p:Configuration=Release_Linux Skybound.Gecko.csproj
	cd Skybound.Gecko/Linux && make && cp geckofix.so ../bin/x86/Debug_Linux/

test: GeckoFxTest/GeckoFxTest.csproj
	cd GeckoFxTest && xbuild /p:Configuration=Debug_Linux GeckoFxTest.csproj
#	cd GeckoFxTest && xbuild /p:Configuration=Release_Linux GeckoFxTest.csproj
	cp GeckoFxTest/GeckoFxTest.sh GeckoFxTest/bin/x86/Debug_Linux/
	cp Skybound.Gecko/Linux/geckofix.so GeckoFxTest/bin/x86/Debug_Linux
	cd GeckoFxTest/bin/x86/Debug_Linux && ./GeckoFxTest.sh

unittest: GeckofxUnitTests/GeckofxUnitTests.csproj
	cd GeckofxUnitTests && xbuild GeckofxUnitTests.csproj

install:
	install -d $(DESTDIR)/usr/lib
	install Skybound.Gecko/bin/Debug/Skybound.Gecko.dll $(DESTDIR)/usr/lib/Skybound.Gecko.dll
