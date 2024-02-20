# KlasseHuis

Maak een venster **Huis** om (maximum 2) huisobjecten, nl. huis1 en
huis2 te creëren en de gegevens van die huisobjecten te tonen.

Je maakt voor deze toepassing eerst de (basis)klasse **Huis** met
volgende [eigenschappen]:

-   **Locatie** -- string -- bevat de gemeente van het huis.

-   **Lengte** - double.

-   **Breedte** - double.

-   **AantalVerdieping** -- integer waarde van minimum 1. (gelijkvloers
    wordt als een verdieping beschouwd). Geef foutmelding als getracht
    wordt om een negatieve of nul-waarde aan deze eigenschap toe te
    kennen.

-   **Type** -- string die het type van het huis aangeeft: "O" voor
    "open bebouwing", "H" voor "half-open bebouwing" en "G" voor
    "Gesloten bebouwing".

De klasse Huis bevat volgende [methods]:

-   Constructor **Huis** in 2 vormen: één constructor zonder parameters
    waarbij een "leeg" huisobject gecreëerd wordt (lege Locatie -
    Lengte, Breedte en AantalVerdieping op nul, type op "O") en één
    constructor met 5 parameters (de 5 eerder beschreven eigenschappen,
    in de volgorde zoals beschreven).

-   **VerhoogAantalVerdiepingen** -- deze methode zorgt ervoor dat het
    aantal verdiepingen verhoogd wordt met de waarde van de doorgegeven
    integer parameter (1 indien geen parameter wordt doorgegeven).

-   **VerlaagAantalVerdiepingen** -- deze methode zorgt ervoor dat het
    aantal verdiepingen verlaagd wordt met de waarde van de doorgegeven
    integer parameter (1 indien geen parameter wordt doorgegeven). OPM:
    de waarde mag niet tot gevolg hebben dat de eigenschap
    AantalVerdieping negatief zou worden. (zie eerder)

-   **Oppervlakte** -- deze functiemethode geeft een double als
    resultaat, nl. de vloeroppervlakte in vierkante meters van één
    verdieping (dus lengte, vermenigvuldigd met breedte). -- zou ook met
    een read-only property kunnen.

-   **Inhoud** - deze functiemethode geeft een double als resultaat, nl.
    de inhoud van het huis in kubieke meters. Je mag veronderstellen dat
    elke verdieping 2,5m hoog is en dat elke verdieping ook even groot
    is (dus vloeroppervlakte, vermenigvuldigd met het aantal
    verdiepingen en met 2,5). -- zou ook met een read-only property
    kunnen.

Bij de start van het programma, wordt het venster Huis getoond:.

![Afbeelding met tekst, schermopname, software, scherm Automatisch
gegenereerde
beschrijving](./media/image1.png)

Het venster bevat (+ enkele labels):

-   TxtLocatie: bevat de Locatie van een te creëren huisobject.

-   TxtLengte: bevat de Lengte van een te creëren huisobject.

-   TxtBreedte: bevat de Breedte van een te creëren huisobject.

-   TxtAantalVerdiepingen: bevat het AantalVerdiepingen van een te
    creëren huisobject.

-   GrpType: een groepsvak met stackpanel om het type van een te creëren
    huisobject te bepalen door middel van de keuzerondjes RadOpen,
    RadHalfopen en RadGesloten.

-   TxtResulaat (niet wijzigbaar). In dit tekstvak wordt de informatie
    van een huisobject getoond (bij drukken van de knoppen btnTonen1 en
    btnTonen2).

-   BtnCreatie1 en BtnCreatie2: deze knoppen dienen voor de creatie van
    respectievelijk een object huis1 en huis2. Gebruik in het ene geval
    de constructor zonder argumenten en in het andere geval de
    constructor met argumenten.

-   Merk op dat als het object huis1 al bestond, dat het bij het terug
    klikken op deze knop volledig "overschreven" wordt (eigenlijk wordt
    het "oude" object huis1 gewist en er wordt een nieuw object met
    diezelfde naam gemaakt).

-   BtnVerhogen1 en BtnVerhogen2: bij het drukken van deze knoppen wordt
    het aantal verdiepingen van respectievelijk het object huis1 en
    huis2 met 1 verhoogd.

-   BtnMeerdereVerhogingen1 en BtnMeerderVerhogingen2: bij het drukken
    van deze knoppen wordt het aantal verdiepingen van respectievelijk
    het object huis1 en huis2 verhoogd met een door de gebruiker
    ingegeven waarde verhoogd. (in te geven met een InputBox).

-   BtnVerlagen1 en BtnVerlagen2: bij het drukken van deze knoppen wordt
    het aantal verdiepingen van respectievelijk het object huis1 en
    huis2 met 1 verlaagd.

-   BtnTonen1 en BtnTonen2: bij het drukken van deze knoppen worden de
    gegevens van respectievelijk de objecten huis1 en huis2 getoond in
    het tekstvak txtResultaat. (na een titel "gegevens van huis1" of
    "gegevens van huis2").

-   BtnLeegmaken: bij het drukken van deze knop worden de tekstvakken in
    het venster leeggemaakt en RadOpen wordt aangevinkt.

-   Je mag bij de start van het programma al onmiddellijk een "leeg"
    object huis1 en huis2 creëren. Dit maakt de rest van de toepassing
    iets eenvoudiger. Je moet dan niet bij alle acties (bij verhoging
    van verdieping, verlaging van verdieping, tonen van informatie)
    testen of het betreffende object huis1 of huis2 bestaat in de klasse
    Huis.

-   Creëer je de objecten niet onmiddellijk (alleen definitie), dan kan
    je programma eveneens werken, maar dan moet je de test of het object
    gecreëerd is wel telkens uitvoeren. Zo niet, dan krijg je fouten.
    (van een niet gecreëerd object kan je geen eigenschappen instellen
    of opvragen).

[Toevoeging:] definieer nu ook huis3 en huis4:

private Huis huis3;

private Huis huis4;

Na de creatie van huis1 voeg je instructie "huis3 = huis1;" toe. Na de
creatie van huis2 voeg je instructie "huis4 = huis2;" toe.

Voeg ten slotte ook de 2 opdrachtknoppen BtnTonen3 en BtnTonen4 toe.
Test de werking uit. Wat stel je vast?

![Afbeelding met tekst, schermopname, software, nummer Automatisch
gegenereerde
beschrijving](./media/image2.png)
