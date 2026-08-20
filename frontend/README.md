# Portfolio frontend

React-frontend voor een persoonlijk portfolio, gebouwd met Vite. De applicatie haalt de hero en portfolio-items op uit een aparte API via Axios en gebruikt TanStack Query voor het laden en cachen van data.

## Huidige status

- Hero-sectie met content en afbeelding uit de API.
- Responsive portfolio-overzicht met maximaal vier projecten per pagina.
- De taal staat momenteel vast op Engels (`en`).
- Projectdetailpagina's en de secties **Over mij** en **Contact** moeten nog worden uitgewerkt.

## Project starten

Vereisten: Node.js 20.19+ en npm.

1. Installeer de dependencies:

   ```bash
   npm install
   ```

2. Maak of controleer `.env` in de hoofdmap:

   ```env
   VITE_API_BASE_URL=http://localhost:<poort>
   ```

   De ingestelde backend moet de hero- en portfolio-endpoints aanbieden.

3. Start de ontwikkelserver:

   ```bash
   npm run dev
   ```

4. Open de URL die Vite in de terminal toont (standaard `http://localhost:5173`).

## Overige commando's

```bash
npm run build    # productiebuild maken
npm run preview  # productiebuild lokaal bekijken
npm run lint     # code controleren
```
