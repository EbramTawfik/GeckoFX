#!/usr/bin/make -f

FF_MAJOR=`firefox --version|cut -d\  -f3|cut -d\. -f1`
FF_VERSION=`firefox --version|cut -d\  -f3`
VERSION="$(FF_VERSION).2"

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

tarclean: clean
	rm -f ../geckofx*.tar.gz

dist: tarclean
	tar --exclude-vcs --exclude-backups --exclude=obj --exclude=bin --exclude=debian --exclude=PutXulRunnerFolderHere --exclude=".*~" -czf ../geckofx-$(VERSION).tar.gz .
	cd .. && ln -s geckofx-$(VERSION).tar.gz geckofx_$(VERSION).orig.tar.gz 

install: Skybound.Gecko.dll
	install -d $(DESTDIR)
	install Skybound.Gecko/bin/x86/Debug_Linux/geckofx-14.dll $(DESTDIR)/geckofx-14.dll
	install Skybound.Gecko/bin/x86/Debug_Linux/geckofx-14.dll.config $(DESTDIR)/geckofx-14.dll.config
	install Skybound.Gecko/Linux/geckofix.so $(DESTDIR)/geckofix.so
