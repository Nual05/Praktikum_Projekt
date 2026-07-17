DROP TABLE Artikel;
DROP TABLE Buchung;

CREATE TABLE Artikel (
    Artikelnummer VARCHAR(20) PRIMARY KEY,
    Bezeichnung VARCHAR(100) NOT NULL,
    Kategorie VARCHAR(50),
    Bestand DECIMAL(10,2) NOT NULL ,
    Mindestbestand DECIMAL(10,2) NOT NULL,
    Einheit VARCHAR(20) NOT NULL,
    CHECK (Bestand >= 0),
    CHECK (Mindestbestand >= 0)
);

CREATE TABLE Buchung (
    BuchungID INT PRIMARY KEY,
    Artikelnummer VARCHAR(20) NOT NULL,
    Datum DATE NOT NULL,
    Menge DECIMAL(10,2) NOT NULL,
    IstEingang CHAR(1) NOT NULL,

    FOREIGN KEY (Artikelnummer) REFERENCES Artikel(Artikelnummer),
    CHECK (IstEingang IN ('E','A'))
);