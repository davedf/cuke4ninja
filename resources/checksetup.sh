#/bin/bash

if [ ! -f environment.local ]
then
    echo "environment.local not found"
    exit 1
fi

source environment.local

for dependency in "$XALANHOME/xalan.jar" "$XALANHOME/xml-apis.jar" "$XALANHOME/xercesImpl.jar" "$XALANHOME/serializer.jar"; do
	if [ ! -f $dependency ]; then
		echo "$dependency not found, check your Xalan instalation and local configuration. Xalan home configured is $XALANHOME"
    	exit 1
  	fi  
done

if [ ! -f $XEPHOME/xep ]; then
	echo "$XEPHOME/xep not found, check your XEP instalation and local configuration. XEP home configured is $XEPHOME"
	exit 1
fi  


for dependency in "xsl/fo/docbook.xsl" "xsl/extensions/xalan27.jar"; do
	if [ ! -f $dependency ]; then
		echo "$dependency not found, check your Docbook-XSL instalation and local configuration. "
    	exit 1
  	fi  
done

echo "everything OK"