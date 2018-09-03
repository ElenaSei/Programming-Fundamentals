<?php
    $homesToVisit = intval(readline());
    $initialPresents = intval(readline());

    $timesBack = 0;
    $additionalPresentsTaken = 0;
    $leftPresents = $initialPresents;
    for ($i = 1; $i <= $homesToVisit; $i++){
        $presents = intval(readline());

        $leftPresents -= $presents;

        if ($leftPresents < 0){
            $presentsTemp = abs($leftPresents);
            $leftPresents = intval($initialPresents / $i) * ($homesToVisit - $i) + $presentsTemp;
            $additionalPresentsTaken += $leftPresents;
            $leftPresents -= $presentsTemp;
            $timesBack ++;
        }
    }

    if ($timesBack == 0){
        echo $leftPresents . "\n";
    } else{
        echo "$timesBack\n";
        echo $additionalPresentsTaken;
    }
