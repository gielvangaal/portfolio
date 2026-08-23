# Portfolio frontend

React-frontend voor een persoonlijk portfolio, gebouwd met Vite. De applicatie haalt de hero en portfolio-items op uit een aparte API via Axios en gebruikt TanStack Query voor het laden en cachen van data.

## Techniek

- React 19 en Vite
- React Router voor client-side routering
- TanStack Query voor server-state en caching
- Axios voor API-verzoeken
- Gewone CSS met centrale tokens in `src/styles/tokens.css`

## Structuur en datastroom

De code is per verantwoordelijkheid verdeeld:

- `src/features` bevat de paginaonderdelen, bijbehorende hooks en CSS.
- `src/services` vormt de laag tussen features en API-clients.
- `src/api` verstuurt HTTP-verzoeken en bouwt media-URL's op.
- `src/mappers` zet API-responses om naar modellen voor de UI.
- `src/components` bevat gedeelde presentational en layout-componenten.

De normale datastroom is:

```text
component → query-hook → service → API-client → mapper → component
```

TanStack Query bewaart opgehaalde data vijf minuten als vers, probeert een
mislukt verzoek één keer opnieuw en refetcht niet bij het opnieuw focussen van
het browservenster. Deze instellingen staan in `src/main.jsx`.

## Routering

`BrowserRouter` wordt gestart in `src/main.jsx`. De beschikbare routes staan in
`src/App.jsx`:

- `/` toont de homepage met de hero en het portfolio-overzicht.
- `/portfolio/:slug` toont het project waarvan de slug in de URL staat.

Interne navigatie gebruikt `Link` van React Router. Daardoor wisselt React van
pagina zonder de volledige applicatie opnieuw te laden en blijft reeds geladen
portfolio-data in de cache. Gewone `<a>`-links blijven bedoeld voor externe
websites.

`ScrollToHash` in `App.jsx` beheert de positie na navigatie. Een route zonder
hash, zoals een detailpagina, opent bovenaan. Een route zoals `/#portfolio`
wacht totdat de portfoliosectie bestaat en zet de pagina direct op die sectie.
De routecontainer krijgt bij iedere padwijziging opnieuw de fade-in-animatie.

Omdat `BrowserRouter` gewone URL-paden gebruikt, moet de productieserver
onbekende frontendroutes zoals `/portfolio/mijn-project` terugsturen naar
`index.html`. Zonder deze SPA-fallback werken directe bezoeken en browser-refresh
op een detailpagina niet.

## API-configuratie

De frontend leest de basis-URL van de backend uit `VITE_API_BASE_URL`. De API
moet deze endpoints aanbieden:

```text
GET /api/Hero/:language
GET /api/portfolio?language=:language
GET /api/portfolio/:slug/:language
```

Relatieve paden van afbeeldingen en andere media worden eveneens aan
`VITE_API_BASE_URL` gekoppeld. De gebruikte taal staat voorlopig als `en` in
`src/App.jsx`.

## Project starten

Vereisten: Node.js 20.19+ en npm.

1. Installeer de dependencies:

   ```bash
   npm install
   ```

2. Maak of controleer `.env` in de hoofdmap:

   Bijvoorbeeld voor een lokale backend op poort 5000:

   ```env
   VITE_API_BASE_URL=http://localhost:5000
   ```

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
