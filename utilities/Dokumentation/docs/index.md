# Dokumentation Carrent

Benjamin Peter & Leonie Buser

## Einführung und Ziele

Es soll ein neues Autovermietungssystem „CarRent“ erstellt werden. Das System soll aus einem Server-Teil und optional einen Web-Client bestehen.

a) Die Daten sollen mittels Repository Pattern in eine Datenbank gespeichert werden können.

b) Die Business Logik soll auf dem Backend laufen und eine REST APIs anbieten.

c) Es soll zuerst ein Monolith erstellt werden und später auf eine Micro Service Architektur überführt werden.

### Aufgabenstellung

Um eine saubere Architektur in einem Projekt zu erreichen, die einerseits alle Zuständigkeiten klärt und abgrenzt und zudem eine Verteilung auf verschiedene Layers und Tiers ermöglicht, müssen in Visual Studio mehrere Projekte angelegt werden.
Wir wollen zudem die Möglichkeit haben alle internen und externen Abhängigkeiten zentral zu verwalten.

## Big Picture

### Context

![C4-Context-Diagramm](/pics/C4-Context.png)

### Container

![C4-Container-Diagramm](/pics/C4-Container.png)

### Components

![C4-Components-Diagramm](/pics/C4-Components-Unterricht.png)

## Domain-Model

![DomainModel-Diagramm](/pics/DomainModel.png)

## Use Cases

- Der Sachbeareiter kann Kunden mit Namen, Adresse & Kundennummer im System verwalten (CRUD).
- Der Sachbeareiter kann Kunden mit Namen oder Kundennummer suchen.
- Der Sachbearbeiter kann Autos verwalten (CRUD).
- Jedes Auto bekommt eine eindeutige Identifikation, Klasse, Marke und einen Typ.
- Der Kunde kann bei der Reservation eine bestimmte Klasse wählen & die Anzahl Tage angegeben werden. Dabei werden die Gesamtkosten für diesen Wagentyp berechnet.
- Bei der Abholung wird Reservation in einen Mietvertrag umgewandelt.  

## Deployment Diagramm

![Deployment-Diagramm](/pics/Deployment-Diagramm.png)

## Qualitätsanforderungen

## Risiken & technische Schulden
