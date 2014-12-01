<img src="http://www.cadtoppers.com/Themes/darkmark/images/logo.png">
CADTOPPERS.COM
==========

CADToppers.com AutoCAD Plugin

Met deze CADToppers.com AutoCAD Plugin is het mogelijk om op eenvoudige wijze een overzicht van de aanwezige lagen in AutoCAD te genereren.

De broncode mag vrij aangepast worden, wel zou het mooi zijn om de wijzigingen ook weer inzichtelijk te maken via GitHub.
Mocht je wijzigingen aan de code willen toevoegen, stuur mij dan een berichtje zodat ik je als Collaborator kan toevoegen.

HOE START IK MET DE PLUGIN
=========
<ul>
<li>Installeer de .NET SDK van AutoDESK</li>
<li><a href="https://github.com/roynijkamp/CADToppers.com/archive/master.zip">Download de laatste versie van de Plugin</a></li>
<li><u>Of</u> Maak een clone van de repository <pre>git clone https://github.com/roynijkamp/CADToppers.com.git</pre></li>
<li>Open het project in Visual Studio</li>
</ul>

DE PLUGIN
=========
De plugin is geschreven met Visual Studio Express 2012.
Om de Code te kunnen compileren is het noodzakelijk de juiste .NET libraries van AutoDESK te installeren. (http://usa.autodesk.com/adsk/servlet/index?id=1911627&siteID=123112)

Na het compileren kun je de DLL via het commando <b>NETLOAD</b> inladen in AutoCAD.<br>
Met het commando <b>CADTOP</b> wordt uiteindelijk de plugin gestart.

WAAROM DEZE PLUGIN
==========
CADToppers.com is een Nederlandstalig CAD gerelateerd forum waar enthousiaste gebruikers elkaar ondersteunen bij allerdaagse CAD uitdagingen.<br>
Een van de uitdagingen was om op eenvoudige wijze een overzicht te genereren van de aanwezige layers.<br>
Het uiteindelijke resultaat is een .NET plugin.

DISCLAIMER
==========
Deze plugin is gestest op AutoCAD 2015, en zal in theorie ook functioneren op eerdere versies.
Ondanks zorgvuldige testen van de Plugin kan er geen 100% werking worden gegarandeerd.
