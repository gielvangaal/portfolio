# Portfolio security: snelle check

GitHub doet het werk. Er draait niets extra op K3s.

- **Dependabot** controleert elke week npm, NuGet, Docker-base-images en GitHub Actions. Bekijk meldingen onder **GitHub → Security → Dependabot alerts** en update-PR's onder **Pull requests**.
- **Trivy** scant iedere dag de gepubliceerde frontend- en API-images van de nieuwste commit op `main`. Bekijk de resultaten onder **Actions → Scan portfolio container images**. **Run workflow** start direct een controle.
- **Bij een urgente CVE:** zoek de software/versie in Dependabot-alerts en Trivy-joblogs. Controleer daarna in `platform-gitops` of de getroffen image-tag echt wordt gebruikt; de scan van `main` bewijst **niet** wat productie draait. Update de dependency/base-image, bouw opnieuw en rol de nieuwe image via GitOps uit. Bij acute blootstelling: beperk tijdelijk toegang.
- **Let op:** een groene scan sluit een nieuwe zero-day niet uit. Check bij een net gepubliceerde kwetsbaarheid ook het leveranciersadvies. Trivy meldt HIGH/CRITICAL als een gefaalde job; een ontbrekende image-tag geeft eveneens een fout.

Deze eerste versie scant de meest recente images van `main`, **niet automatisch de image-digests in K3s**. Koppeling met daadwerkelijk gedeployde images is vervolgwerk onder PAHP platform-infra issue #41.
