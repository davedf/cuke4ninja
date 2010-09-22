BEGIN{
	curline=1;
}
/START:[a-zA-Z0-9]+/{
	match ($0, /START:([a-zA-Z0-9]*)/,arr);
	part=arr[1];
	activeparts[part]=1;
	next;
}
/END:[a-zA-Z0-9]+/{
	match ($0, /END:([a-zA-Z0-9]*)/,arr);
	part=arr[1];
	delete activeparts[part];
	next;
}
//{
    gsub(/\t/, "  ");
	fullfn=FILENAME ".full";
	#print sprintf("%-4d",curline) $0 >> fullfn;
	print $0 >> fullfn;
	for (part in activeparts){
	  partn=FILENAME "." part;
	  #print sprintf("%-4d",curline) $0 >> partn;
	  print $0 >> partn;
	}
	curline=curline+1;
}

