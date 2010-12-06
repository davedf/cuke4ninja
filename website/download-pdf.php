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

Header("Location: http://cuke4ninja.s3.amazonaws.com/cuke4ninja-2010-12-06.pdf?AWSAccessKeyId=1X67X2N8SN9A2283RSR2&Expires=1300133611&Signature=nw2qr4oceqv3dnHY9tEXmkLEwRs%3D");
?>
