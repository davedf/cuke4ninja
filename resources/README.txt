1. get Xalan http://xml.apache.org/xalan-j/downloads.html
2. get XEP (personal edition) http://www.renderx.com
3. copy resources/environment.template to resources/environment.local to set XEP and XALAN paths
4. get docbook-xsl from http://sourceforge.net/projects/docbook/files/, unpack it to resources/xsl (so that there is a folder resources/xsl/fo) 
5. run checksetup.sh in the resources folder to check your configuration
6. go to ../plainbook
7. run make docbook
8. open docbook.pdf

Makefile options

1. Create full book: 
	make docbook

2. Create single chapter (eg intro):
	make intro.pdf 

3. Clean up temporary files:
	make clean


After you change the code, remember to run rebuildcode.sh from the resources folder  
