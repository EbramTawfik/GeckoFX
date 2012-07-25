#!/usr/bin/make -f

FF_MAJOR=`firefox --version|cut -d\  -f3|cut -d\. -f1`
FF_VERSION=`firefox --version|cut -d\  -f3`
VERSION="$(FF_VERSION).1"

all: Geckofx

clean:
	xbuild /p:Configuration=Debug_Linux Geckofx.sln /target:clean
	rm -rf */obj */bin

Geckofx: Geckofx.sln
	xbuild /p:Configuration=Debug_Linux Geckofx.sln
	cd Geckofx-Core/Linux && make && cp geckofix.so ../bin/x86/Debug_Linux/

test: Geckofx
	cp GeckoFxTest/GeckoFxTest.sh GeckoFxTest/bin/x86/Debug_Linux/
	cp Geckofx-Core/Linux/geckofix.so GeckoFxTest/bin/x86/Debug_Linux
	cd GeckoFxTest/bin/x86/Debug_Linux && ./GeckoFxTest.sh

unittest: GeckofxUnitTests/GeckofxUnitTests.csproj
	cd GeckofxUnitTests && xbuild GeckofxUnitTests.csproj

tarclean: clean
	rm -f ../geckofx*.tar.gz

dist: tarclean
	tar --exclude-vcs --exclude-backups --exclude=obj --exclude=bin --exclude=debian --exclude=PutXulRunnerFolderHere --exclude=".*~" -czf ../geckofx-$(VERSION).tar.gz .
	cd .. && ln -s geckofx-$(VERSION).tar.gz geckofx_$(VERSION).orig.tar.gz 

install: Geckofx
	install -d $(DESTDIR)
	install GeckoFxTest/bin/x86/Debug_Linux/geckofx-14.dll $(DESTDIR)/geckofx-14.dll
	install GeckoFxTest/bin/x86/Debug_Linux/geckofx-14.dll.config $(DESTDIR)/geckofx-14.dll.config
	install GeckoFxTest/bin/x86/Debug_Linux/Geckofx-Winforms-14.dll $(DESTDIR)/Geckofx-Winforms-14.dll
	install Geckofx-Core/Linux/geckofix.so $(DESTDIR)/geckofix.so
