# AR Workshop Assignment

## Setup

Follow AR-TUTORIAL-COMPLETE-REFINED.md. This is a source kit, not a complete
Unity project. Create a Universal 3D project, copy the repository tools first,
and add the AR scripts only after installing their packages.

## Versions — fill from your actual setup

- Windows: Windows 11 pro for workstations 25H2
- Unity Editor (full patch): 6000.3.24f1
- AR Foundation: 6.3.5
- Apple ARKit XR Plug-in: 6.3.5
- Input System: 1.20.0
- Xcode used by the successful cloud run:
- iPhone model / iOS: iPhone 16 pro / iOS 27.0
- Sideloadly: v0.60

## Scenes

- PipelineCheck: non-AR installation test.
- ARBaseline: session, origin, camera, and status.
- SurfaceLab: plane detection and sphere placement.
- MarkerLab: reference image and rotating cube.
- CombinedLab: both workshop features.

The assignment deliverable is one app containing both tracking methods.
Use CombinedLab as the only enabled scene for the final iOS build.

## Repository

Use a public GitHub repository. The supplied standard macOS runner has free
compute for public repositories. Releases and their export assets are public.

## Build

1. Enable the intended scene in the active iOS profile.
2. Commit source, then export a fresh Xcode project locally.
3. Package it with Tools/Package-Xcode.ps1.
4. Attach xcode-export.zip to a new GitHub release at the source commit.
5. Manually run iOS unsigned build with that release tag.
6. Download the IPA, then sign/install with Sideloadly on Windows.

## Verification record

| Date | Source commit | Export tag/hash | Actions run | Device test | Result |
|---|---|---|---|---|---|
| 20/09/2026 | Preparation Commit b2ce29c | export-001 / FC72291DE603BF9A2B3D647C93029C8E920BC1276233F7B95B9C2E7B6A91BEC7 | https://github.com/fury471/ARWorkshopAssignment/actions/runs/35476208330 | Not performed | Compilation passed; IPA packaging failed because of incorrect `lipo` argument order. |
| 20/09/2026 | Corrected lipo argument order in workflow commit 398d4b0. | export-001 / FC72291DE603BF9A2B3D647C93029C8E920BC1276233F7B95B9C2E7B6A91BEC7 | https://github.com/fury471/ARWorkshopAssignment/actions/runs/35476942944 | iPhone 16 Pro: installed and launched; test cube visible | Corrected `lipo` argument order; Unsigned IPA generated successfully. |

## Assignment evidence

- Surface detection and multiple tap placements:
- Image recognition and cube rotation:
- Video / screenshots:
- Known limitations:
- Last successful signature refresh:
- Source link shared with supervisor:
- Demonstration appointment:

## Provenance

SpinObjectOnMarker reproduces the supplied marker workshop's rotation code.
TapToPlace adapts the supplied surface workshop with validation and mouse input.
Other starter code and pipeline instructions were generated with AI assistance.
Record your own edits and follow the course's disclosure requirements.

## Scope

This assignment does not implement persistent locations, building alignment,
two-floor navigation, or intelligent search. Those are later project stages.
