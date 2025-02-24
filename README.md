# KlasseHuis

Maak een venster **Huis** om (maximum 2) huisobjecten, nl. huis1 en
huis2 te creëren en de gegevens van die huisobjecten te tonen.

Je maakt voor deze toepassing eerst de (basis)klasse **Home** met
volgende eigenschappen:

-   **Location** -- string -- bevat de gemeente van het huis.
-   **Length** - double.
-   **Width** - double.
-   **NumberOfFloors** -- integer waarde van minimum 1. (gelijkvloers
    wordt als een verdieping beschouwd). Geef foutmelding als getracht
    wordt om een negatieve of nul-waarde aan deze eigenschap toe te
    kennen.
-   **Type** -- char die het type van het huis aangeeft: "O" voor
    "open bebouwing", "H" voor "half-open bebouwing" en "G" voor
    "Gesloten bebouwing".

De klasse Home bevat volgende methodes:

-   Constructor **Home** in 2 vormen: één constructor zonder parameters
    waarbij een "leeg" huisobject gecreëerd wordt (lege Locatie -
    Lengte, Breedte en AantalVerdieping op nul, type op "O") en één
    constructor met 5 parameters (de 5 eerder beschreven eigenschappen,
    in de volgorde zoals beschreven).

-   **IncreaseNumberOfFloors** -- deze methode zorgt ervoor dat het
    aantal verdiepingen verhoogd wordt met de waarde van de doorgegeven
    integer parameter (1 indien geen parameter wordt doorgegeven).

-   **DecreaseNumberOfFloors** -- deze methode zorgt ervoor dat het
    aantal verdiepingen verlaagd wordt met de waarde van de doorgegeven
    integer parameter (1 indien geen parameter wordt doorgegeven). OPM:
    de waarde mag niet tot gevolg hebben dat de eigenschap
    AantalVerdieping negatief zou worden. (zie eerder)

-   **GetSurface** -- deze functiemethode geeft een double als
    resultaat, nl. de vloeroppervlakte in vierkante meters (m^2^) van één
    verdieping (dus lengte, vermenigvuldigd met breedte). -- zou ook met
    een read-only property kunnen.

-   **GetVolume** - deze functiemethode geeft een double als resultaat, nl.
    de inhoud van het huis in kubieke meters (m^3^). Je mag veronderstellen dat
    elke verdieping 2,5m hoog is en dat elke verdieping ook even groot
    is (dus vloeroppervlakte, vermenigvuldigd met het aantal
    verdiepingen en met 2,5). -- zou ook met een read-only property
    kunnen.

Bij de start van het programma, wordt het venster Huis getoond:.

![empty window](./media/emptywindow.png)

Het venster bevat (+ enkele labels):

-   locationTextBox: bevat de Locatie van een te creëren huisobject.
-   lengthTextBox: bevat de Lengte van een te creëren huisobject.
-   widthTextBox: bevat de Breedte van een te creëren huisobject.
-   floorsTextBox: bevat het AantalVerdiepingen van een te
    creëren huisobject.
-   typeGroupBox: een groepsvak met stackpanel om het type van een te creëren
    huisobject te bepalen door middel van de keuzerondjes openRadioButton,
    halfOpenRadioButton en geslotenRadioButton.
-   resultTextBox (niet wijzigbaar). In dit tekstvak wordt de informatie
    van een huisobject getoond (bij drukken van de knoppen showFirstHomeButton en
    showSecondHomeButton).
-   createFirstHomeButton en createSecondHomeButton: deze knoppen dienen voor de creatie van
    respectievelijk een object huis1 en huis2. Gebruik in het ene geval
    de constructor zonder argumenten en in het andere geval de
    constructor met argumenten.
-   Merk op dat als het object huis1 al bestond, dat het bij het terug
    klikken op deze knop volledig "overschreven" wordt (eigenlijk wordt
    het "oude" object huis1 gewist en er wordt een nieuw object met
    diezelfde naam gemaakt).
-   increaseFloors1Button en increaseFloors2Button: bij het drukken van deze knoppen wordt
    het aantal verdiepingen van respectievelijk het object huis1 en
    huis2 met 1 verhoogd.
-   increaseMultipleFloors1Button en increaseMultipleFloors1Button: bij het drukken
    van deze knoppen wordt het aantal verdiepingen van respectievelijk
    het object huis1 en huis2 verhoogd met een door de gebruiker
    ingegeven waarde verhoogd. (in te geven met een InputBox).
-   decreaseFloors1Button en decreaseFloors2Button: bij het drukken van deze knoppen wordt
    het aantal verdiepingen van respectievelijk het object huis1 en
    huis2 met 1 verlaagd.
-   showFirstHomeButton en showSecondHomeButton: bij het drukken van deze knoppen worden de
    gegevens van respectievelijk de objecten huis1 en huis2 getoond in
    het tekstvak resultTextBox. (na een titel "gegevens van huis1" of
    "gegevens van huis2").
-   clearButton: bij het drukken van deze knop worden de tekstvakken in
    het venster leeggemaakt en openRadioButton wordt aangevinkt.
-   Je mag bij de start van het programma al onmiddellijk een "leeg"
    object huis1 en huis2 creëren. Dit maakt de rest van de toepassing
    iets eenvoudiger. Je moet dan niet bij alle acties (bij verhoging
    van verdieping, verlaging van verdieping, tonen van informatie)
    testen of het betreffende object huis1 of huis2 bestaat 
-   Creëer je de objecten niet onmiddellijk (alleen definitie), dan kan
    je programma eveneens werken, maar dan moet je de test of het object
    gecreëerd is wel telkens uitvoeren. Zo niet, dan krijg je fouten.
    (van een niet gecreëerd object kan je geen eigenschappen instellen
    of opvragen).

### Extra: 
definieer nu ook huis3 en huis4:
```
private Home huis3;
private Home huis4;
```

Na de creatie van huis1 voeg je instructie "huis3 = huis1;" toe. Na de
creatie van huis2 voeg je instructie "huis4 = huis2;" toe.

Voeg ten slotte ook de 2 opdrachtknoppen showThirdHomeButton en showFourthHomeButton toe.
Test de werking uit. Wat stel je vast?

![Afbeelding met tekst, schermopname, software, nummer Automatisch
gegenereerde
beschrijving](./media/example.png)

### XAML
Hoewel deze oefening een prima herhaling is om je XAML skills te testen kan je ook gebruik maken van onderstaande snippet.

```
    <Grid>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="2*"/>
            <ColumnDefinition/>
            <ColumnDefinition/>
        </Grid.ColumnDefinitions>
        <StackPanel Grid.Column="0">
            <GroupBox Header="Gegevens" Margin="10">
            <Grid Margin="10">
                <Grid.RowDefinitions>
                    <RowDefinition/>
                    <RowDefinition/>
                    <RowDefinition/>
                    <RowDefinition/>
                </Grid.RowDefinitions>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>
                <Label Content="Locatie" Grid.Column="0" Grid.Row="0"/>
                <Label Content="Lengte" Grid.Column="0" Grid.Row="1"/>
                <Label Content="Breedte" Grid.Column="0" Grid.Row="2"/>
                <Label Content="Verdiepingen" Grid.Column="0" Grid.Row="3"/>
                <TextBox Grid.Row="0" Grid.Column="1" Margin="10" x:Name="locationTextBox"/>
                <TextBox Grid.Row="1" Grid.Column="1" Margin="10" x:Name="lengthTextBox"/>
                <TextBox Grid.Row="2" Grid.Column="1" Margin="10" x:Name="widthTextBox"/>
                <TextBox Grid.Row="3" Grid.Column="1" Margin="10" x:Name="floorsTextBox"/>
            </Grid>
            </GroupBox>
            <GroupBox Header="Type bebouwing" Margin="10">
                <StackPanel>
                    <RadioButton Content="Open" Margin="10" x:Name="openRadioButton"/>
                    <RadioButton Content="Halfopen" Margin="10" x:Name="halfOpenRadioButton"/>
                    <RadioButton Content="Gesloten" Margin="10" x:Name="geslotenRadioButton"/>
                </StackPanel>
            </GroupBox>
            <TextBox x:Name="resultTextBox" Margin="10" Height="200" IsEnabled="False"/>
        </StackPanel>
        <StackPanel Grid.Column="1">
            <GroupBox Header="Huis 1" Margin="10">
                <StackPanel>
                    <Button Content="Creatie" Margin="10" x:Name="createHome1Button" Click="createHome1Button_Click"/>
                    <Button Content="Verdieping +1" Margin="10" x:Name="increaseFloors1Button" Click="increaseFloors1Button_Click"/>
                    <Button Content="Verdieping +?" Margin="10" x:Name="increaseMultipleFloors1Button" Click="increaseMultipleFloors1Button_Click"/>
                    <Button Content="Verdieping -1" Margin="10" x:Name="decreaseFloors1Button" Click="decreaseFloors1Button_Click"/>
                    <Button Content="Gegevens" Margin="10" x:Name="showHome1Button" Click="showHome1Button_Click"/>
                </StackPanel>
            </GroupBox>
            <GroupBox Header="Huis 3" Margin="10">
                <Button Content="Gegevens" Margin="10" x:Name="showHome3Button" Click="showHome3Button_Click"/>
            </GroupBox>
            <GroupBox Header="Acties" Margin="10">
                <Button Content="Wissen" Margin="10" x:Name="clearButton" Click="clearButton_Click"/>
            </GroupBox>
        </StackPanel>
        <StackPanel Grid.Column="2">
            <GroupBox Header="Huis 2" Margin="10">
                <StackPanel>
                    <Button Content="Creatie" Margin="10" x:Name="createHome2Button" Click="createHome2Button_Click"/>
                    <Button Content="Verdieping +1" Margin="10" x:Name="increaseFloors2Button" Click="increaseFloors2Button_Click"/>
                    <Button Content="Verdieping +?" Margin="10" x:Name="increaseMultipleFloors2Button" Click="increaseMultipleFloors2Button_Click"/>
                    <Button Content="Verdieping -1" Margin="10" x:Name="decreaseFloors2Button" Click="decreaseFloors2Button_Click"/>
                    <Button Content="Gegevens" Margin="10" x:Name="showHome2Button" Click="showHome2Button_Click"/>
                </StackPanel>
            </GroupBox>
            <GroupBox Header="Huis 4" Margin="10">
                <Button Content="Gegevens" Margin="10"  x:Name="showHome4Button" Click="showHome4Button_Click"/>
            </GroupBox>
        </StackPanel>
    </Grid>
```