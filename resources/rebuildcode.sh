#!/bin/bash

DIR=`dirname $0`
rm -rf $DIR/src
#svn export ../src src
cp -R $DIR/../src $DIR/src
for i in `find $DIR/src -name .svn -type d`; do rm -rf $i; done
for i in `find $DIR/src -name lib -type d`; do rm -rf $i; done
for i in `find $DIR/src -type f`
do 
	echo numbering and splitting $i
	gawk -f $DIR/splitandnumber.awk $i
done
