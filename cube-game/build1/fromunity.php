<?php
    $text1 = $_POST["message"];

    if($text1 != "")
    {
        echo("Message succesfully sent!");
        echo("Field 1: " . $text1);
        $file = fopen("data.txt", "a");
        fwrite($file, $text1);
    }
    else
    {
        echo("Message delivery failed");
    }
    ?>
