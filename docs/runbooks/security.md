# Portfolio security: alleen alerts en Trivy

**Doel:** ernstige kwetsbaarheden signaleren zonder een stroom automatische update-PR's. Geen extra software op K3s.

## GitHub-instellingen (eenmalig)

In **Settings → Advanced Security** (benaming kan afwijken):
- Dependency graph: **aan**
- Dependabot alerts: **aan**
- Dependabot security updates: **uit**

**Geen `.github/dependabot.yml`:** daardoor geen geplande Dependabot versie-update-PR's. De security-update-PR's moet je los daarvan uitzetten via GitHub Settings. GitHub kan ook alerts voor LOW/MODERATE aanmaken; geef vooral prioriteit aan Critical en aantoonbaar exploiteerbare High. De alertlijst kun je op ernst filteren.

## Trivy

**Actions → Scan portfolio container images** draait dagelijks en kan ook handmatig met **Run workflow** worden gestart. De workflow scant de gepubliceerde frontend- en API-image van de huidige `main` commit op HIGH/CRITICAL. Rode jobs kunnen ook komen door een ontbrekende image-tag; controleer het log.

**Let op:** de `main`-image is niet noodzakelijk de daadwerkelijk uitgerolde productie-image. Verifieer bij een urgente CVE de image-tag/digest in `platform-gitops` en K3s.

## Bij ernstige CVE

1. Lees het leveranciersadvies en bepaal of de kwetsbare versie/functionele route werkelijk aanwezig is.
2. Controleer de blootstelling: publieke frontend, interne API en paden voor onbetrouwbare input zijn niet hetzelfde risico.
3. Controleer bij voorkeur de exact gedeployde image; gebruik Dependabot Alerts en Trivy als signalering, niet als bewijs van exploitbaarheid.
4. Alleen bij reëel risico: dependency/base-image aanpassen, image opnieuw bouwen, via GitOps uitrollen en opnieuw controleren.

Ondersteunde runtimeversies blijven wenselijk. Geen directe publieke API-route verlaagt het risico, maar maakt verouderde runtimes niet automatisch veilig.

Vervolg: scanning van daadwerkelijk gedeployde image-digests (platform-infra issue #41).
