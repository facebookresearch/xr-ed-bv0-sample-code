## Overview

This project provides standalone demonstrations for Xrpa modules, organized for internal distribution and presentation.

---

## Adding New Integrations
- **Directory Structure:**
  Create a new sample directory in `Assets > Samples` for each Xrpa integration.
- **Package Updates:**
  Update the `package.json` to reflect any Xrpa-related changes.
- **Testing:**
  Ensure all sample directories are fully tested for functionality.

---

## Packaging Samples
- **Automation:**
  Use the `package_samples.py` script (found in the Python directory) to automatically gather and copy all samples and required executables into directories formatted for npm packaging via protokit.
- **Documentation:**
  Each sample must include a `README.md`. These are concatenated into the root `Assets > Samples` README, ensuring each demo is documented and self-explanatory.

---

## Versioning and Publishing
- **Main Packages:**
  Xrpa packages are copied without modification; internal npm versions stay identical to external releases.
- **Demo Packages:**
  Manually update version numbers in each demo's package before publishing.

---

## Publishing Procedure
1. **Set npm Registry (Public):**
   npm config set registry https://registry.npmjs.org/

   Build Xrpa with yarn.

2. **Develop Samples:**
   Write and thoroughly test sample code.

3. **Switch to Internal Registry:**
   npm set registry https://npm.thefacebook.com/

4. **Package Samples:**
   Run `package_samples.py`.

5. **Prepare Packages:**
   Go to each package directory and run:

   npm pack

6. **Version Numbers:**
   Update `package.json` in each demo package as needed.
   You can check latest versions with:

   npm list [package] versions

7. **Publish:**
   Run a dry run:

   npm publish [new zip] --dry-run

   If no errors, publish for real.

---

## Additional Notes
- Adhere to this workflow for consistency across all Xrpa module demos.
- Always coordinate version updates across related packages before official publishing.
