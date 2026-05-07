# AGENTS.md — ShrekQuiz

## Architecture

- **Blazor WebAssembly standalone** — .NET 8, client-side only. No server, no API, no database.
- All data is hardcoded in `QuizService` (registered as singleton in `Program.cs`).
- Single page app: `Pages/Home.razor` handles three states (start → quiz → result).
- Model: `Models/Question.cs` (Id, Text, Options, CorrectAnswerIndex, ImagePath).
- UI: Bootstrap 5 + custom CSS (`wwwroot/css/app.css`) with a swamp/album-aesthetic design system using CSS custom properties.

## Project structure

```
ShrekQuiz/
├── Models/Question.cs          # Data model
├── Services/QuizService.cs     # 26 hardcoded questions
├── Pages/Home.razor            # Entire quiz UI (start, quiz, result)
├── Layout/MainLayout.razor     # Minimal layout wrapper
├── wwwroot/
│   ├── css/app.css             # Custom design system
│   ├── css/bootstrap/          # Bootstrap 5 (minified, checked in)
│   └── images/Picture1.png … Picture26.png  # Question images
├── Program.cs                  # DI registration, Blazor bootstrap
└── App.razor                   # Router
```

The root-level `images/` directory is a duplicate of `wwwroot/images/` — only the `wwwroot` copy is used at runtime.

## Commands

```bash
# Development (starts dev server with hot reload)
cd ShrekQuiz && dotnet run

# Build
dotnet build ShrekQuiz/ShrekQuiz.csproj

# Publish for production
dotnet publish ShrekQuiz/ShrekQuiz.csproj -c Release -o /app/publish

# Docker (serves on localhost:8080)
docker compose up --build
```

There are **no tests** in this project.

## Docker / deployment

- Multi-stage build: `dotnet:8.0` SDK → `nginx:alpine` serving `wwwroot` as static files.
- The `nginx.conf` contains **critical MIME type declarations** for `.wasm`, `.dll`, `.pdb`, `.dat` — Blazor WASM will not load without them.
- Host port 8080 maps to container port 80.

## Conventions

- App language is **Russian** (questions, UI text, comments in Razor).
- Question image paths follow the pattern `images/Picture{N}.png` (two use `.jpg`: #5 and #25).
- CSS uses `var()`-based design tokens (colors, spacing, radii, shadows) defined in `:root` — prefer extending custom properties over hardcoding values.
- Bootstrap is bundled as a minified file; do not replace with a CDN unless the app moves to a non-Docker deployment.
- Question 3's correct answer was ambiguous in the spec; the implementation chose index 0 ("Три слепых мышонка").
