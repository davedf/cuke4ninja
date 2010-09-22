<?
function getRealIpAddr()
{
    if (!empty($_SERVER['HTTP_CLIENT_IP']))   //check ip from share internet
    {
      $ip=$_SERVER['HTTP_CLIENT_IP'];
    }
    elseif (!empty($_SERVER['HTTP_X_FORWARDED_FOR']))   //to check ip is pass from proxy
    {
      $ip=$_SERVER['HTTP_X_FORWARDED_FOR'];
    }
    else
    {
      $ip=$_SERVER['REMOTE_ADDR'];
    }
    return $ip;
}

function log_download(){
$fp = fopen('/home/webadmin/cuke4ninja.com/pdfdownload', 'a');
fwrite($fp, date("F j, Y, g:i a"). "\t". getRealIpAddr());
fwrite($fp, "\n");
fclose($fp);
}


log_download();

Header("Location: http://cuke4ninja.s3.amazonaws.com/cuke4ninja-2010-09-20.pdf?AWSAccessKeyId=1X67X2N8SN9A2283RSR2&Expires=1293584505&Signature=3wgEwjkvm4mnlcQvruT0yLitcLI%3D");
?>
[gojko@newjavaneuri html]$ cat reg
register.html  register.php   regok.html     regprob.html
[gojko@newjavaneuri html]$ cat register.php
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
    elseif (strpos($_POST["comments"],"site,admin.")==false && $_POST["company"]!="google" && strpos($_POST["comments"],"href=")==false && mail("gojko@gojko.com", "Cuke4Ninja registration", $message,"From: contact@cuke4ninja.com")) {
        Header("Location: http://cuke4ninja.com/regok.html");
    }
    else {
        Header("Location: http://cuke4ninja.com/regprob.html");

    }
?>