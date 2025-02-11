This directory contains our static page to tell users that the HUG2 service is no longer available.

This page is not deployed as part of our pipeline. All changes must be sent to ICS for them to update on the live site.

Version 4.9.0 of GDS is included here. Modifications to make it run statically are:
- All path references are made relative (`/assets/...` -> `./assets/...`).