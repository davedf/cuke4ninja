cd $1

#use gsed if available over sed, for Darwin to work
SED=`which gsed`
if [ $? -ne 0 ]; then 
 SED=sed
fi

AWK=`which gawk`
if [ $? -ne 0 ]; then 
AWK=awk
fi

for c in *html; do
 echo $c
 mv $c $c.old
 #sed 's/<a[^>]*href="\([^\"]*\)"[^>]*><\/a>/\n\nAWKEMBED \1\n\n/g' $c.old  | 
 $SED 's/<body[^>]*>/\n\nAWKEMBED ..\/resources\/html_body_head.html\n\n/g' $c.old |  \
 $SED 's/<\/body[^>]*>/\n\nAWKEMBED ..\/resources\/html_body_foot.html\n\n/g'| \
 $SED 's/<\/head[^>]*>/\n\nAWKEMBED ..\/resources\/html_head.html\n\n/g' | \
 $AWK '/AWKEMBED/{ while ((getline line < $2 ) > 0) print line; close ($2); next;} //{print $0}'  > $c 
 $SED -i 's/..\/images/images/g' $c
 rm $c.old
done    
