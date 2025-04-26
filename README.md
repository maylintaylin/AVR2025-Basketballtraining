# AVR2025-Basketballtraining

**Titel des Projekts: Immersives VR-Basketballtraining**

**Teammitglieder:** <br> Maylin Mittmann 70494395 <br> Mirjam Werner 317243, <br> Samantha Rauhaus 70493970

**1.) Einleitung** <br>
In diesem Projekt entwickeln wir eine interaktive VR-Anwendung die den Nutzern den gezielten Einsatz von Virtual-Reality-Technologien und deren theoretischer Schwerpunkte näher bringen soll. Ziel ist es, zentrale Aspekte der Wahrnehmung, Interaktion und Immersion durch eine spielerische, aber strukturierte Anwendung erlebbar zu machen. Als Anwendungsszenario dient eine virtuelle Basketballwurf-Simulation, bei der Nutzer:innen aktiv mit einem dynamisch reagierenden System interagieren und dabei Veränderungen in Raum, Höhe und Distanz erleben.

**2.) Projektziel:** <br>
Ziel des Projekts ist die Umsetzung einer immersiven, interaktiven VR-Anwendung, in der Nutzer:innen Basketballbälle auf sich verändernde Zielobjekte (Körbe) werfen. Die Position, Höhe und Entfernung des Korbes ändert sich nach jedem erfolgreichen Treffer. Dadurch sollen verschiedene Aspekte der menschlichen visuellen Wahrnehmung, insbesondere die Tiefenwahrnehmung, sowie motorisches Lernen und kognitive Anpassungsprozesse verdeutlicht werden.
Das Projekt orientiert sich an den theoretischen Grundlagen aus den ersten Kapiteln des Buches "Virtual und Augmented Reality – Grundlagen und Methoden der Virtuellen und Augmentierten Realität" von Dörner, Broll, Grimm und Jung (2. Auflage, 2019). Dabei werden Konzepte wie Präsenz, Wahrnehmung im virtuellen Raum, Interaktion, Immersion und sensorische Illusionen praktisch umgesetzt und erlebbar gemacht.
Die Anwendung vereint diese theoretischen Grundlagen mit der praktischen Umsetzung in Unity für die Meta Quest 2 und zielt darauf ab, zentrale Herausforderungen und Chancen von VR-Anwendungen durch gezielte Experimente mit Raumwahrnehmung, Interaktion und Feedback zu veranschaulichen.

**2.1 Was soll den Nutzern durch die VR-Anwendung vermittelt werden?** <br>
- Verbesserung der Wurfgenauigkeit <br>
- Zielverfolgung durch wechsel der Basketballkörbe und räumliches Bewusstsein im virtuellen Raum <br>
- Vermittlung von besserer Ballkontrolle und Hand-Augen-Koordination <br>
- Förderung von körperlicher Bewegung


**2.2 Was erleben die Nutzenden?** <br>
Die VR-Anwendung bietet den Nutzenden: <br>
Freies Training: Werfen auf einen Basketballkorb aus verschiedenen Perspektiven und Entfernungen <br>
Interaktive Übung: Der Korb erscheint an zufälligen Positionen im Raum, dies fördert die Zielgenauigkeit der Nutzer sowie deren Orientierung im virtuellen Raum <br>
Erleben realistischer Ballphysik (bei Wurf, Dribbling und Fangen durch beachtung der Schwerkraft und Masse des Basketballs) <br>
Echtzeit-Feedback durch Sound (beim Fangen, Werfen und Dribbling), visuelle Punkteanzeige und Vibration (bei Ballkontakt sowie treffen des Ziels) <br>

**2.3 Interaktion durch:** <br>
- Steuerung über VR-Controller <br>
- Werfen, Fangen und Dribbeln durch natürliche Bewegungen <br>
Feedbacksystem: <br>
- Auditiv: Soundeffekte bei Ballaktionen <br>
- Haptisch: Vibration bei Ballkontakt <br>
- Visuell: Punktanzeige und bewegliches Ziel <br>
- Adaptiv: Ziel verschwindet nach Treffer und taucht an neuer Stelle auf

**3.) Theoretische Schwerpunkte und eingesetzte VR-Konzepte:** <br>

**1. Tiefenwahrnehmung:** 
- Durch Variation von Korbposition, -höhe und -entfernung wird die räumliche Einschätzung des Ziels herausgefordert.
- Ziel: Verstehen und Erleben, wie visuelle Hinweise (Größe, Schatten, Parallaxe) die Entfernungseinschätzung beeinflussen. <br>

**2. Motorisches Lernen & Koordination:**
- Durch wiederholte Interaktion mit dem Ziel erfolgt eine Anpassung der Wurfbewegung und Koordination. <br>
- Ziel: Demonstration adaptiver Lernprozesse in der VR. <br>

**3. Visuelle Stimuli & Interaktion:** <br>
- Farbliche Zielhervorhebung, Bewegungsanimationen. <br>
- Ziel: Steigerung der Aufmerksamkeit, Fokussierung und Feedback-Verarbeitung. <br>

**4. Presence & Immersion:** <br>
- Durch realistische Räume, Sounddesign, Lichtstimmungen und einfache physikalische Rückmeldungen. <br>
- Ziel: Nutzer:innen sollen ein Gefühl entwickeln, tatsächlich im Raum zu sein. <br>

**5. Pseudo-Haptik:** <br>
- Visuelle und auditive Effekte simulieren Rückmeldung bei Treffer oder Fehlwurf. <br>
- Ziel: Kompensation fehlender echter haptischer Reize. <br>

**6. Adaptiver Raum & kognitive Illusion:** <br>
- Das sich verändernde Ziel erzeugt die Illusion eines sich wandelnden Raums. <br>
- Ziel: Analyse des Einflusses bewegter Zielobjekte auf Raumgefühl und Orientierung. <br>

**7. Gamification & Motivation:** <br>
- Punktesystem, Zielanimationen sorgen für Motivation und Fortschrittserleben <br>


**4.) Technisches Konzept** 
**Tools und Plattformen:** <br>
- Unity <br>
- C# zum Programmieren <br>
- Blender für das erstellen der Assets <br>
- Audacity für Soundeffekte <br>
**Hardware:**
- Meta Quest 2 <br>
**Assets:**
- Eigenbau von Turnhalle, Korb, Basketball und weiteren Elementen <br>
- Physik-Komponenten (Rigidbody, Colliders) für realistische Ballbewegungen


**5.) Zeitplan und Aufgabenverteilung** <br> 

1 Woche: Planung und Recherche, Erste Projektskizzen und Designideen zum virtuellen Erscheinungsbild <br>
2 Woche: Erstellung der Raumumgebung (Turnhalle und Basketballfeld) <br>
3 Woche: Erstellung der Assets (Basketball, Basketballkorb, Punkteskala sowie passende Texturen und Oberflächen) <br>
4 Woche: Umsetzung der Ballphysik <br>
5 Woche: Integration von Sound und Vibrationsfeedback <br>
6 Woche: Positionen des Korbs wechseln <br>
7 Woche: Punkte zählen bei Korbtreffern <br>
8 Woche: Testen und Optimieren <br>
9 Woche: Fehlerbehebung und Feinschliff <br>
10 Woche: Präsentation und Projektabschluss <br>

**Hinweis zur aktuellen Arbeitsaufteilung und Projektstruktur:** <br>
Aktuell befinden wir uns in der frühen Phase unseres Projektes, in der wir uns intensiv in die grundlegenden Technologien und Werkzeuge einarbeiten. Dazu gehört insbesondere der Umgang mit Unity, der Programmiersprache C# sowie der Meta Quest 2 als Zielplattform. Parallel dazu vertiefen wir unser Verständnis der theoretischen Grundlagen aus dem Bereich Virtual Reality.
Aus diesem Grund ist eine detaillierte, feste Arbeitsaufteilung innerhalb des Teams zum jetzigen Zeitpunkt noch nicht möglich. Die genaue Verteilung der Aufgaben wird sich organisch entwickeln, sobald die individuellen Stärken und Interessen der Teammitglieder im praktischen Umgang mit den Technologien deutlicher werden.
Wir gehen davon aus, dass die Aufgabenbereiche – etwa Programmierung, Modellierung, Interaktionsdesign oder Testing – im Laufe der nächsten Wochen klarer definiert und unter den Teammitgliedern aufgeteilt werden. Diese Verteilung wird flexibel bleiben, um auf auftretende technische Herausforderungen, notwendige Schwerpunktverschiebungen oder Erkenntnisse aus der laufenden Entwicklung reagieren zu können.
Wir werden die Aufgabenverteilung und alle wesentlichen Änderungen dokumentieren und in regelmäßigen Projektständen transparent machen.


**GitHub IDs:** <br>
Samantha -> Samantha610 <br>
Maylin -> maylintaylin <br>
Mirjam -> Frl.Moe



