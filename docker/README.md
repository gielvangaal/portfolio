# Local container build smoke tests

Run from the repository root. The portfolio API already has its own Dockerfile; this change adds a production frontend image.

## Frontend

```bash
docker build -f docker/frontend/Dockerfile -t portfolio-frontend:local .
docker run --rm -p 8081:8080 --name portfolio-frontend portfolio-frontend:local
```

In another terminal:

```bash
curl -I http://localhost:8081/
curl -I http://localhost:8081/portfolio/example
```

Both requests should return HTTP 200. Open http://localhost:8081 in a browser to check that the static UI loads.

**Note:** This is a *static frontend smoke test*, not an end-to-end application test. The production image uses a same-origin API base URL (empty `VITE_API_BASE_URL`). Until a proxy/Gateway routes `/api` and backend media paths to the API, dynamic content will not load from this standalone frontend container. A later PAHP GitOps step will add that routing.

## Backend

```bash
docker build -f docker/backend/api/Dockerfile -t portfolio-api:local .
```

This checks that the existing .NET Dockerfile builds. Starting the API additionally requires a reachable MySQL instance and a valid `ConnectionStrings__DefaultConnection`. The existing `docker/backend/compose.yml` can be used for the full local backend stack with its environment variables configured.

## Deployment contract

- Frontend container listens on TCP 8080.
- Backend container listens on TCP 8080.
- Frontend is built to use same-origin backend URLs; the eventual Cilium Gateway must route `/api` and backend-served media paths to the API.
- The Kubernetes namespace will be `gielvangaal-dev-prod`.
- No Kubernetes, DNS, CI, or database configuration is changed here.
