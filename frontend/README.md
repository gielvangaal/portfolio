# Portfolio frontend

React frontend for a personal portfolio, built with Vite. The application retrieves the hero and portfolio items from a separate API via Axios and uses TanStack Query for loading and caching data.

## Technology

- React 19 and Vite
- React Router for client-side routing
- TanStack Query for server-state and caching
- Axios for API requests
- Plain CSS with central tokens in `src/styles/tokens.css`

## Structure and data flow

The code is divided by responsibility:

- `src/features` contains the page sections, associated hooks and CSS.
- `src/services` forms the layer between features and API clients.
- `src/api` sends HTTP requests and builds media URLs.
- `src/mappers` converts API responses into models for the UI.
- `src/components` contains shared presentational and layout components.

The normal data flow is:

```text
component → query-hook → service → API-client → mapper → component
```

TanStack Query keeps fetched data fresh for five minutes, retries a
failed request once and does not refetch when the browser window regains
focus. These settings are in `src/main.jsx`.

## Routing

`BrowserRouter` is started in `src/main.jsx`. The available routes are defined in
`src/App.jsx`:

- `/` shows the homepage with the hero and portfolio overview.
- `/portfolio/:slug` shows the project whose slug is in the URL.

Internal navigation uses `Link` from React Router. This allows React to switch
pages without reloading the entire application and keeps already loaded
portfolio data in the cache. Regular `<a>` links remain intended for external
websites.

`ScrollToHash` in `App.jsx` manages the position after navigation. A route without
a hash, such as a detail page, opens at the top. A route such as `/#portfolio`
waits until the portfolio section exists and places the page directly on that section.
The route container gets the fade-in animation again on every path change.

Because `BrowserRouter` uses regular URL paths, the production server must
send unknown frontend routes such as `/portfolio/my-project` back to
`index.html`. Without this SPA fallback, direct visits and browser refreshes
on a detail page do not work.

## API configuration

The frontend reads the base URL of the backend from `VITE_API_BASE_URL`. The API
must provide these endpoints:

```text
GET /api/Hero/:language
GET /api/portfolio?language=:language
GET /api/portfolio/:slug/:language
```

Relative paths of images and other media are also linked to
`VITE_API_BASE_URL`. The language used is currently set to `en` in
`src/App.jsx`.

## Starting the project

Requirements: Node.js 20.19+ and npm.

1. Install the dependencies:

   ```bash
   npm install
   ```

2. Create or check `.env` in the root directory:

   For example, for a local backend on port 5000:

   ```env
   VITE_API_BASE_URL=http://localhost:5000
   ```

3. Start the development server:

   ```bash
   npm run dev
   ```

4. Open the URL that Vite shows in the terminal (default `http://localhost:5173`).

## Other commands

```bash
npm run build    # create production build
npm run preview  # view production build locally
npm run lint     # check code
```