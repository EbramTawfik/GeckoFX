ROOT_DIR=`pwd`
MONO="/usr/local/bin/mono"

NUNIT_RUNNER_CMD="$MONO --debug nunit-console-x86.exe"
NUNIT_OPTIONS='-apartment=STA -nothread -process=Single -exclude=slow'
LIBGECKOFIX='/home/hindlet/src/hg/firefox-paratext/prebuilt/x86_64/libgeckofix.so'
export MOZ_PATH='/home/hindlet/src/hg/firefox-paratext/mozilla-release/obj-x86_64-unknown-linux-gnu/dist/firefox'

function copy_all_nunit_files
{
	cp -u ${ROOT_DIR}/nunit/bin/* .
	cp -u ${ROOT_DIR}/nunit/bin/lib/nunit*.dll .
}

function copy_gtkstuff
{
	cp ${ROOT_DIR}/gtk/glib* .
	cp ${ROOT_DIR}/gtk/gtk* .
	cp ${ROOT_DIR}/gtk/gdk* .
	cp ${ROOT_DIR}/gtk/atk* .
}


pushd GeckofxUnitTests/bin/Debug
cp -u $LIBGECKOFIX .
copy_all_nunit_files
copy_gtkstuff
export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:$MOZ_PATH
export LD_PRELOAD=./libgeckofix.so
export MONO_PATH=/usr/lib/cli/gdk-sharp-2.0
export MONO_DEBUG=explicit-null-checks
export MONO_ENV_OPTIONS=-O=-gshared

$MONO ./GeckofxUnitTests.exe

popd
