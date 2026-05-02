# Copilot Instructions for InventarioISP20

## Build, test, and lint commands

This repository currently contains a single .NET Windows Forms app (`Desktop/Desktop.csproj`) referenced by `InventarioISP20.slnx`.

```powershell
# Build the full solution
dotnet build .\InventarioISP20.slnx -nologo

# Run the desktop app
dotnet run --project .\Desktop\Desktop.csproj

# Test status
# No test projects are currently present in this solution.
# `dotnet test .\InventarioISP20.slnx` currently runs restore/build only.
```

## High-level architecture

- The app is a single-process WinForms desktop application.
- Startup flow is `Program.Main` -> `Application.Run(new MenuPrincipalView())`.
- `MenuPrincipalView` is the navigation shell and currently contains the main interactive behavior:
  - Welcome button (`BtnWelcome_Click`) shows a greeting `MessageBox`.
  - Exit menu (`SubMenuSalirDelSistema_Click`) closes the main form.
  - Articles menu (`SubMenuArticulos_Click`) opens `ArticulosViews` with `Show()` (non-modal).
- Other forms (`CategoriasView`, `PrestamosView`, `UbicacionesView`, `ArticulosViews`) are currently mostly scaffolded placeholders with `InitializeComponent()` only.

## Key conventions in this codebase

- Forms use WinForms partial-class split files:
  - `*View.cs` for behavior/event handlers
  - `*View.Designer.cs` for generated UI wiring/layout
  - `*View.resx` for form resources
- Keep manual logic in `*.cs`; avoid hand-editing `*.Designer.cs` unless absolutely necessary.
- UI and identifiers are Spanish-first (menu labels and messages), and new UI text should stay consistent with that style.
- The project uses `FontAwesome.Sharp` controls in the main menu (`IconButton`, `IconMenuItem`) rather than only stock WinForms controls.
- Namespace usage is currently mixed (`Desktop` and `Desktop.Views`); when touching a form pair, ensure namespace/class names stay aligned across `.cs` and `.Designer.cs`.

## Mandatory instructions
- Siempre Habla en Español.