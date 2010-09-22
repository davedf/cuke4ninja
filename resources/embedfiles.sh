cd $1

for c in *html; do
 echo $c
 mv $c $c.old
 #sed 's/<a[^>]*href="\([^\"]*\)"[^>]*><\/a>/\n\nAWKEMBED \1\n\n/g' $c.old  | 
 gsed 's/<body[^>]*>/\n\nAWKEMBED ..\/resources\/html_body_head.html\n\n/g' $c.old |  \
 gsed 's/<\/body[^>]*>/\n\nAWKEMBED ..\/resources\/html_body_foot.html\n\n/g'| \
 gsed 's/<\/head[^>]*>/\n\nAWKEMBED ..\/resources\/html_head.html\n\n/g' | \
 gawk '/AWKEMBED/{ while ((getline line < $2 ) > 0) print line; close ($2); next;} //{print $0}'  > $c 
 gsed -i 's/..\/images/images/g' $c
 rm $c.old
done    
