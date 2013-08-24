lib_LTLIBRARIES = libpangosharpglue-1.32.5.la

libpangosharpglue_1_32_5_la_SOURCES =

nodist_libpangosharpglue_1_32_5_la_SOURCES = generated.c

libpangosharpglue_1_32_5_la_LDFLAGS = -module -avoid-version -no-undefined

libpangosharpglue_1_32_5_la_LIBADD = $(PANGO_LIBS)

INCLUDES = $(PANGO_CFLAGS) -I$(top_srcdir)

libpangosharpglue.dll: $(libpangosharpglue_1_32_5_la_OBJECTS) libpangosharpglue.rc libpangosharpglue.def
	./build-dll libpangosharpglue $(VERSION)

CLEANFILES = lib*.a lib*.dll

EXTRA_DIST =
