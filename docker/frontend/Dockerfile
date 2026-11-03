# Build React/Vite into static assets; Node.js is not used at runtime.
FROM node:22-alpine AS build
WORKDIR /app
COPY frontend/package.json frontend/package-lock.json ./
RUN npm ci
COPY frontend/ ./
# Same-origin API calls; Cilium Gateway will route /api and media to the API.
ARG VITE_API_BASE_URL=""
ENV VITE_API_BASE_URL=${VITE_API_BASE_URL}
RUN npm run build

# Serve only the generated static files, on a non-privileged port.
FROM nginxinc/nginx-unprivileged:stable-alpine
COPY docker/frontend/default.conf /etc/nginx/conf.d/default.conf
COPY --from=build /app/dist/ /usr/share/nginx/html/
EXPOSE 8080
