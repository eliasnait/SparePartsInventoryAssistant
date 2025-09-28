

Dette program er et lager-system, hvor vi kan søge efter reservedele.

Når vi starter programmet, får vi en velkomstbesked.

har lavet en `bool` variabel der starter som `false`. Den styrer om vi har fundet delen eller ej.
Så længe vi ikke har fundet delen bliver brugeren ved med at blive spurgt i konsollen.

Brugeren kan skrive navnet på en reservedel. Hvis delen findes i lageret, ændrer vi det til `true`, og loopen stopper.

Hvis brugeren spørger om der overhovedet er noget på lager, svarer konsollen med en liste over de dele vi har.

Hvis brugeren skriver noget andet, får de at vide at delen ikke findes.

Vi bruger `if`, `else if` og `else` til at lave de tre betingelser.
Vi bruger også string interpolation $ så vi kan sætte brugerens input ind i teksten.
