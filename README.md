### 1. **Dekomponering**:
For å lage en enkel applikasjon for å organisere lekser, kan vi dele opp oppgaven i mindre komponenter:

- **Lagre data:**
  - Velge hvordan lekser skal lagres (f.eks. i en liste, database eller fil).
  
- **Legge til lekser:**
  - Lage en funksjon for å legge til nye lekser (med beskrivelse, frist, fag).
  
- **Vise lekser:**
  - Lage en funksjon for å vise en liste over alle lekser.
  
- **Markere lekser som fullført:**
  - Lage en funksjon for å markere en spesifikk lekse som fullført.

- **Brukergrensesnitt:**
  - Lage et enkelt brukergrensesnitt (f.eks. tekstbasert eller GUI).
  
- **Lagre endringer:**
  - Sørge for at listen over lekser oppdateres og kan lagres ved avslutning.

### 2. **Mønstergjenkjenning**:
- **Lignende operasjoner**: Legge til og markere lekser som fullført involverer begge oppdateringer av lekse-liste.
- **Gjenbrukbare funksjoner**: Både visning av listen og markering av fullført kan bruke samme funksjon for å iterere gjennom listen og vise status.

### 3. **Abstraksjon**:
Start med det mest grunnleggende:
- Opprett en enkel liste for lekser der hver lekse inneholder felter som navn, frist, fag og status (fullført/ikke fullført).
- Fokuser på tekstbasert lagring og funksjonalitet først, uten å komplisere med layout eller design.

### 4. **Algoritmer**:
Her er en stegvis algoritme for å programmere applikasjonen:

1. **Opprett datastruktur for lekser** (f.eks. en klasse `Lekse`):
   - Felter: navn, frist, fag, status (fullført/ikke fullført).
  
2. **Funksjon for å legge til nye lekser**:
   - La brukeren skrive inn navn, frist og fag for en ny lekse.
   - Legg denne lekse til listen.
   
3. **Funksjon for å vise alle lekser**:
   - Iterer gjennom listen og vis alle lekser på skjermen.
   - Vis status (fullført/ikke fullført) for hver lekse.

4. **Funksjon for å markere lekse som fullført**:
   - La brukeren velge hvilken lekse som skal markeres som fullført.
   - Oppdater statusen i listen.
   
5. **Test funksjonalitet**:
   - Legg til lekser, se listen, og marker dem som fullført.
   - Test applikasjonen for å sikre at alle funksjonene fungerer som de skal.
