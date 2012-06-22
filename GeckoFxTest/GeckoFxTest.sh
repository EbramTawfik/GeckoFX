#!/bin/bash

if [ ! -f ./jemallocfix.so ]
then
# jemallocfix for firefox 10+
    echo -e "#include<stdlib.h>\nsize_t je_malloc_usable_size_in_advance(size_t n){ return n; }\nvoid * moz_xrealloc(void *ptr, size_t size) { return realloc(ptr, size); }" | gcc -xc --shared - -o jemallocfix.so
    strip jemallocfix.so
fi


export LD_LIBRARY_PATH=/usr/lib/firefox/
export MONO_PATH=/usr/lib/cli/gdk-sharp-2.0 
export LD_PRELOAD=./jemallocfix.so

# use need to use a mono with this patch in it https://bugzilla.novell.com/show_bug.cgi?id=672879
mono -debug GeckoFxTest.exe
