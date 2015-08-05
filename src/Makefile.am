bushdir=$(bindir)
bush_SCRIPTS = bush.exe
EXTRA_DIST = $(bush_sources) $(bush_sources_in)
CLEANFILES = bush.exe

bush_sources_in = AssemblyInfo.cs.in
bush_generated_sources = $(bush_sources_in:.in=)
bush_sources = main.cs

bush_build_sources = $(addprefix $(srcdir)/, $(bush_sources))
bush_build_sources += $(bush_generated_sources)
resources = $(srcdir)/../resources/dummy.txt

embedded= $(foreach res,$(resources), $(addprefix -resource:,$(res)),$(notdir $(res)))

bush.exe: $(bush_build_sources) $(resources)
	$(MCS) $(GTKSHARP_LIBS) $(embedded) -out:$@ $<

