﻿# Empyrion Base Align
## FAQ

Eine übersetzte Version findet ihr im EmpyrionBaseAlign/bin Verzeichnis falls ihr die Mod nicht selber prüfen und compilieren wollt ;-)

### What is this?

Es soll dazu dienen eine neue Basis (AlignBase) so auszurichten und zu positionieren das sie im Rastermaß einer bestehenden Basis (MainBase) liegt und beim Bauen nahtlos an diese anschließt

#### What are all the commands?

Hinweis: Zur Zeit ist implementiert das ein Spieler nur eine Basis ausrichten kann die nicht mehr als 10 Blöcke hat, also direkt nach dem Setzen des Basisstarter. 
Damit werden viele Exploids vermieden die sich sonst ergeben würden. Spieler mit einer höheren Berechtigung dürfen alles Ausrichten.

#### Help

* /al : Zeigt die Kommandos der Mod an

#### Align

* /al {BaseToAlignId} {MainBaseId}
* /al {BaseToAlignId} {MainBaseId}
* /al {BaseToAlignId} 0

* /als {ShiftX},{ShiftY},{ShiftZ}		=> Letzte /al Basis um XYZ verschieben
* /alr {RotateX},{RotateY},{RotateZ}    => Letzte /al Basis um XYZ drehen

Richtet die Basis (BaseToAlignId) so aus und positioniert sie das sie im Rastermaß einer bestehenden Basis (MainBaseId) liegt und beim Bauen nahtlos an diese anschließt.

UNDO: Wenn die {MainBaseId} = 0 ist wird die Basis {BaseToAlignId} wieder an die ursprüngliche Position und Ausrichtung zurückgesetzt werden.

Tipp: mit "/al ID ID" kann man auch eine einzelne Basis noch mal verschieben und drehen ;-)

### Restore?
Im Logfile werden die 'setposition' und 'setrotation' Kommandos hinterlegt die zur Restaurierung der 'alten' Position und Ausrichtung genutzt werden können

### Is that it?
Zunächst erstmal und damit viel Spaß beim natlosen Bauen wünscht euch

### Konfiguration
Eine Konfiguration kann man in der Datei (wird beim ersten Start automatisch erstellt)

[Empyrion Directory]\Saves\Games\\[SaveGameName]\Mods\EmpyrionBaseAlign\Config.xml

vornehmen.

* FreePermissionLevel: Ab welcher Rolle ist das ändern beliebiger Basen erlaubt (Player, GameMaster, Moderator, Admin)
* ForbiddenPlayfields: Liste der Playfields in denen keine Basenausrichtung erlaubt ist
  - Beispieleintrag: <string>Akua</string>


ASTIC/TC