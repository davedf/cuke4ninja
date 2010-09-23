<?php

   function iV($nm, $lab)
    {
        if ($nm!='')
                return $lab."\t:".substr($nm,0,1000)."\n";
        else
                return "";
    }
    $message=  iV($_POST["name"],"NAME").
                        iV($_POST["company"],"company").
                        iV($_POST["where"],"where").
                        iV($_POST["email"],"email").
                        iV($_POST["training"],"training").
                        iV($_POST["phone"],"phone").
                        iV($_POST["comments"],"comments");


    if (strpos($_POST["comments"],"href=")!==false){
        Header("Location: http://cuke4ninja.com/regprob.html");
    }
    elseif (strpos($_POST["comments"],"http://")!==false){
        Header("Location: http://cuke4ninja.com/regprob.html");
    }
    elseif (strpos($_POST["email"],"@")==false){
        Header("Location: http://cuke4ninja.com/regprob.html");
    }
    elseif (strpos($_POST["comments"],"site,admin.")==false && $_POST["company"]!="google" && strpos($_POST["comments"],"href=")==false && mail("gojko@neuri.co.uk", "Cuke4Ninja registration", $message,"From: contact@cuke4ninja.com")) {
        Header("Location: http://cuke4ninja.com/regok.html");
    }
    else {
        Header("Location: http://cuke4ninja.com/regprob.html");

    }
?>
