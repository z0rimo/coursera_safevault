# SafeVault – Secure Coding Project (Assignment Submission)

This repository contains the secure code and tests produced across the activities:

- **Activity 1** — Writing Secure Code Using Microsoft Copilot (input validation & SQL injection prevention)
- **Activity 2** — Implementing Authentication & Authorization Using Microsoft Copilot (RBAC)
- **Activity 3** — Debugging & Resolving Security Issues Using Microsoft Copilot (SQLi, XSS, etc.)

## What’s inside

- `src/SafeVault` — example secure code patterns (validation, parameterized SQL, RBAC, anti‑XSS helpers)
- `tests/SafeVault.Tests` — unit & security tests
- `VULNERABILITY_REPORT.md` — issues found and the fixes applied (with before/after)
- `COPILOT_SUMMARY.md` — how Copilot assisted (prompts, snippets, acceptance criteria)
- `TEST_PLAN.md` — what we tested and how to run tests
- `SECURITY.md` — threat model & controls

## Quickstart

```bash
# run tests
dotnet test

# (optional) format
dotnet tool update -g dotnet-format
dotnet format
```

## Submission URL

Replace this with your repo URL: `https://github.com/<your-username>/safevault`

## References

- OWASP Cheat Sheet Series — Input Validation, SQL Injection Prevention, XSS Prevention: https://cheatsheetseries.owasp.org/
- .NET Data Protection & Identity: https://learn.microsoft.com/aspnet/core/security/
- GitHub Repos Quickstart: https://docs.github.com/repositories/working-with-files/managing-files/creating-new-files
# coursera_safevault
