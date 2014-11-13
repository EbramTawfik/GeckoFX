#!/bin/bash

#if [ ! -f ./jemallocfix.so ]
#then
## jemallocfix for firefox 10+
#    echo -e "#include<stdlib.h>\nsize_t je_malloc_usable_size_in_advance(size_t n){ return n; }\nvoid * moz_xrealloc(void *ptr, size_t size) { return realloc(ptr, #size); }" | gcc -xc --shared - -o jemallocfix.so
#    strip jemallocfix.so
#fi

MONO_PREFIX=/usr/lib/fieldworks/mono
export PATH="$MONO_PREFIX/bin:$PATH"
#export LD_LIBRARY_PATH="$MONO_PREFIX/lib:/usr/lib/debug/usr/lib/firefox/"
export LD_LIBRARY_PATH=".:$MONO_PREFIX/lib:/usr/lib/firefox/"
#export MONO_PATH=/usr/lib/cli/gdk-sharp-2.0 
export MONO_GAC_PREFIX="$MONO_PREFIX/lib/mono/gac"
cp $MONO_GAC_PREFIX/gdk-sharp/2.12.0.0__35e10195dab3c99f/* .
cp $MONO_GAC_PREFIX/gtk-sharp/2.12.0.0__35e10195dab3c99f/* .
cp $MONO_GAC_PREFIX/atk-sharp/2.12.0.0__35e10195dab3c99f/* .
cp $MONO_GAC_PREFIX/pango-sharp/2.12.0.0__35e10195dab3c99f/* .
cp $MONO_GAC_PREFIX/glib-sharp/2.12.0.0__35e10195dab3c99f/* .
#export LD_PRELOAD="./jemallocfix.so:/usr/lib/firefox/libxpcom.so"
export LD_PRELOAD="./geckofix.so"

#cp $MONO_PREFIX/lib/*glue*.so .

which mono
# use need to use a mono with this patch in it https://bugzilla.novell.com/show_bug.cgi?id=672879
#gdb --args $MONO_PREFIX/bin/mono --debug GeckoFxTest.exe
#valgrind --vgdb=full $MONO_PREFIX/bin/mono --debug GeckoFxTest.exe
mono --debug GeckoFxTest.exe
