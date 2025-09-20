# SECURITY.md

## Threats in scope
- Input abuse (injection, overlong fields, invalid encodings)
- SQL Injection (string concatenation / unsafe interpolation)
- Cross-Site Scripting (stored/reflected)
- Broken Authentication & RBAC bypass
- Secrets exposure (connection strings, tokens)
- Insufficient logging/monitoring

## Key Controls
- **Input validation**: length, type, regex, allow-listing.
- **Parameterized queries** everywhere (Dapper/ADO.NET).
- **RBAC** using `[Authorize(Roles = "...")]` and policy-based authorization.
- **Output encoding**: HTML encoding on dynamic output; avoid rendering unsafe HTML.
- **Cookie/session hardening**: HttpOnly, Secure, SameSite=Strict (if cookies are used).
- **Secrets** via environment variables or Secret Manager (no secrets in repo).
- **Audit logging**: log sign-in/out, failed access, and privilege changes.
- **Testing**: unit & security tests for validation, RBAC, and query parameterization.

## Operational Notes
- Rotate secrets regularly; prefer Managed Identity where available.
- Enforce HTTPS. Use HSTS in production.
- Enable CI to run tests on every push.
