# Empyrion Base Align
## FAQ

Eine �bersetzte Version findet ihr im EmpyrionBaseAlign/bin Verzeichnis falls ihr die Mod nicht selber pr�fen und compilieren wollt ;-)

### What is this?

Es soll dazu dienen eine neue Basis (AlignBase) so auszurichten und zu positionieren das sie im Rasterma� einer bestehenden Basis (MainBase) liegt und beim Bauen nahtlos an diese anschlie�t

#### What are all the commands?

Hinweis: Zur Zeit ist implementiert das ein Spieler nur eine Basis ausrichten kann die nicht mehr als 10 Bl�cke hat, also direkt nach dem Setzen des Basisstarter. 
Damit werden viele Exploids vermieden die sich sonst ergeben w�rden. Spieler mit einer h�heren Berechtigung d�rfen alles Ausrichten.

#### Help

* /al : Zeigt die Kommandos der Mod an

#### Align

* /al {BaseToAlignId} {MainBaseId}
* /al {BaseToAlignId} {MainBaseId} {ShiftX},{ShiftY},{ShiftZ}
* /al {BaseToAlignId} 0

Richtet die Basis (BaseToAlignId) so aus und positioniert sie das sie im Rasterma� einer bestehenden Basis (MainBaseId) liegt und beim Bauen nahtlos an diese anschlie�t.

Mit dem {ShiftXYZ} kann noch eine Verschiebung w�rend der Ausrichtung angegeben werden um die auszurichtene Basis im neuen Rasterma� zu verschieben.

UNDO: Wenn die {MainBaseId} = 0 ist wird die Basis {BaseToAlignId} wieder an die urspr�ngliche Position und Ausrichtung zur�ckgesetzt werden.

### Restore?
Im Logfile werden die 'setposition' und 'setrotation' Kommandos hinterlegt die zur Restaurierung der 'alten' Position und Ausrichtung genutzt werden k�nnen

### Is that it?
Zun�chst erstmal und damit viel Spa� beim natlosen Bauen w�nscht euch

ASTIC/TC