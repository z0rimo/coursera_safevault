# TEST_PLAN.md — Security Tests

## Scope
Validate critical security behaviors: input validation, SQLi protection, RBAC enforcement, and XSS hardening.

## Test Categories
1. **Validation tests**
   - Reject overlong usernames, invalid emails, weak passwords.
2. **Repository tests (SQLi)**
   - Ensure queries use parameters; simulate malicious input and verify no exceptions/leakage.
3. **RBAC tests**
   - Anonymous requests → 401; user role → 403 for admin endpoints; admin → 200.
4. **XSS tests**
   - Supply typical payloads (`<script>`, `"><img onerror=...>`) and verify output is encoded.

## How to run
```bash
dotnet test
```

## Exit criteria
- All tests green in CI.
- Code review confirms no dynamic SQL.
- Sensitive endpoints have authorization attributes.
