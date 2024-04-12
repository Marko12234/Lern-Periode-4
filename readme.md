Lern-Periode 4

## übergeordnetes Thema: Ausführung und Planung

## Grob-Planung

1. Ich stehe mit den Noten gut da und sollte mich aufs Programmieren fokussieren.
  
2. Ich möchte mehr Prioritäten beim programmieren setzen, meine Zeit effektiver nutzen und fokussierter arbeiten und darum setze ich Prioritäten bei der Planung und plane kleinere und genauer definiertere Arbeitspakete.
  
3. Ich möchte ein Bildbearbeitungsprogramm mithilfe der Bibliothek ImageSharp von SixLabors schreiben.
  

## 10.4.24

✍️ Heute habe ich mich mit Bibliotheken auseinandergesetzt und gelernt, wie man eine installiert. Ich habe die Dokumentation von ImageSharp überflogen und habe mir den Code, den die Bibliothek ausstellt, angeschaut. Ich habe mir Gedanken über das UI gemacht und habe mich beim Erstellen des Projekts für eine WPF-Anwendung entschieden und mich über die Markupsprache xaml informiert. (56)

## 11.4.2024

- [x] Begrüssungsbildschirm und UI zur Bildauswahl
- [x] Bild aus Fileexplorer laden
- [x] UI zur Auswahl der Bearbeitungsmethode erstellen
- [x] Bildgrösse veränderbar durch Textboxeingabe

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | Programm gestartet | -   | Begrüssungsbildschirm wird angezeigt. | x   |
| 2   | siehe 1. | "Bild laden" angeklickt | Bild wird angezeigt | x   |
| 3   | siehe 2. | Knopf zur Benutzung der jeweiligen Arbeitsmethode angeklickt | weitere Informationen für Bildbearbeitung anzeigen | x   |
| 4   | siehe 3. | Eingabe Höhe oder Breite in Textbox | Bildgrösse verändert sich | x   |

✍️ Heute habe ich... (50-100 Wörter)

Heute habe ich gelernt wie man eine Bibliothek installiert und habe mich mithilfe der [offiziellen Dokumentation von ImageSharp ](https://docs.sixlabors.com/) über die Möglichkeiten dieser Bibliothek informiert. Ich habe mich entschieden dieser Projekt als WPF-Programm zu realisieren und habe erste Erfahrungen mit der Markupsprache xaml und dem Gestalten der UI gesammelt.

Ich habe die Dateiauswahl durch Dateiexplorer implementiert und habe somit die Bildauswahl ermöglicht.

Für Arbeitspaket 3 habe ich noch einige Platzhalterknöpfe eingebaut bei denen die Auswahl für die zusätzlichen Informationen nicht vorhanden sind. (81)

## 12.4.2024

- [ ] In offizieller Dokumentation anschauen wie man einen Filter einsetzt
- [ ] In offizieller Dokumentation anschauen wie man die Sättigung ändert
- [ ] In offizieller Dokumentation anschauen wie man die Schärfe ändert
- [ ] Bild im Fileexplorer speichern lernen

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --- | --- | --- | --- | --- |
| 1   | Bild ausgewählt | Filter einsetzen (Graufilter) | Graufilter angewendet |     |
| 2   | siehe 1. | Sättigung einstellbar mit Regler | Bildsättigung verändert |     |
| 3   | siehe 1. | Schärfe mit Regler einstellbar | Bildschärfe verändert |     |
| 4   | siehe 1. | "Bild speichern" angeklickt, Dateispeicherort ausgewählt | Bild gespeichert, "Bild erfolgreich gespeichert" Textnachricht angezeigt |
