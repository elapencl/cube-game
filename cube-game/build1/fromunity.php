<?php
    $text1 = $_POST["message"];
    //$text2 = $_POST["age"];
    //$text3 = $_POST["score"];

    if($text1 != "")
    {
        echo("Message succesfully sent!");
        echo("Field 1: " . $text1);
        //echo("Field 2: " . $text2);
        //echo("Field 3: " . $text3);
        $file = fopen("data.txt", "a");
        fwrite($file, $text1);
        //fwrite($file, $text2);
        //fwrite($file, $text3);
    }
    else
    {
        echo("Message delivery failed");
    }
    ?>
