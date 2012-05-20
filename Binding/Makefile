BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs

all: OpenEars.dll

OpenEars.dll: AssemblyInfo.cs OpenEars.cs libOpenEars.a
	$(BTOUCH) -v OpenEars.cs --outdir=gen -ns=OpenEars --unsafe --sourceonly=genfiles 
	$(SMCS) -v -out:OpenEars.dll @genfiles AssemblyInfo.cs -resource:libOpenEars.a,libOpenEars.a -r:/Developer/MonoTouch/usr/lib/mono/2.1/monotouch.dll -target:library  
	-rm -fR gen
	-rm -f genfiles

 clean:
	-rm -f genfiles *.dll
	-rm -fR gen

