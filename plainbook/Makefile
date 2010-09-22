#!/bin/bash 

include ../resources/environment.local

JAVAOPTS=-Xmn300M -Xms500M -Xmx800M  
XSLHOME=../resources/xsl
CLASSPATH=$(XALANHOME)/xalan.jar:$(XALANHOME)/xml-apis.jar:$(XALANHOME)/xercesImpl.jar:$(XALANHOME)/serializer.jar:$(XSLHOME)/extensions/xalan27.jar


%.dbxml: %.xml
	java $(JAVAOPTS) -cp $(CLASSPATH) -Dorg.apache.xerces.xni.parser.XMLParserConfiguration=org.apache.xerces.parsers.XIncludeParserConfiguration org.apache.xalan.xslt.Process  \
	-out $@  \
	-in $< \
	-xsl  ../resources/plainbook/pbtodb.xslt 

%.fo: %.dbxml
	java $(JAVAOPTS) -cp $(CLASSPATH) -Dorg.apache.xerces.xni.parser.XMLParserConfiguration=org.apache.xerces.parsers.XIncludeParserConfiguration org.apache.xalan.xslt.Process  \
	-out $@  \
	-in $< \
	-xsl  ../resources/docbook-print.xsl 
	

%.html: %.dbxml
	java $(JAVAOPTS) -cp $(CLASSPATH) -Dorg.apache.xerces.xni.parser.XMLParserConfiguration=org.apache.xerces.parsers.XIncludeParserConfiguration org.apache.xalan.xslt.Process  \
	-out $@  \
	-in $< \
	-xsl  ../resources/docbook-web.xsl 
	
%.pdf: %.fo
	$(XEPHOME)/xep -quiet -fo $< -pdf $@

docbook-chapters: implementing.dbxml tables.dbxml training.dbxml resources.dbxml author.dbxml about_the_doc.dbxml intro.dbxml hello_dotnet.dbxml hello_java.dbxml hello_ruby.dbxml gherkin.dbxml

code:
	sh ../resources/rebuildcode.sh

docbook: code docbook-chapters docbook.pdf

website: docbook-chapters docbook.html
	sh ../resources/embedfiles.sh .
	mv index.html toc.html
	rm -rf ../website-final
	cp -R ../website ../website-final
	sh ../resources/embedfiles.sh ../website-final
	mv *.html ../website-final
	cp -R ../images ../website-final	
	rm -rf ../website-final/*-300dpi.png
	cp -R ../resources/xsl/images ../website-final/images/resources

clean:
	rm -f *.pdf
	rm -f *.dbxml
	rm -f *.fo
	rm -f *.html
	rm -f *.html.old
	rm -rf ../website-final
	ln -s ../resources/docbook.xml docbook.dbxml
