# AGENTS.md — ShrekQuiz

## Architecture

- **Blazor WebAssembly standalone** — .NET 8, client-side only. No server, no API, no database.
- All data is hardcoded in `QuizService` (registered as singleton in `Program.cs`).
- Single page app: `Pages/Home.razor` handles three states (start → quiz → result) via bool flags (`_showStart`, `_showResult`).
- Model: `Models/Question.cs` — `Id`, `Text`, `Options` (List\<string\>), `CorrectAnswerIndex`, `ImagePath`.
- UI: Bootstrap 5 (bundled minified) + custom CSS (`wwwroot/css/app.css`) with swamp/album-aesthetic design system using CSS custom properties.

## Project structure

```
ShrekQuiz/
├── Models/Question.cs          # Data model
├── Services/QuizService.cs     # 26 hardcoded questions (list initializer)
├── Pages/Home.razor            # Entire quiz UI: start, quiz, result
├── Layout/MainLayout.razor     # Minimal wrapper — just renders @Body
├── App.razor                   # Router with 404 fallback (Russian text)
├── _Imports.razor              # Global usings for all namespaces
├── Program.cs                  # DI registration, WASM bootstrap
├── wwwroot/
│   ├── index.html              # PWA meta tags, CSS/JS links, <base href="/">
│   ├── manifest.json           # PWA manifest (lang=ru, theme_color=#1a2e12)
│   ├── css/app.css             # Full custom design system (931 lines)
│   ├── css/bootstrap/
│   │   └── bootstrap.min.css   # Bootstrap 5 minified, checked in
│   └── images/                 # 27 files: Picture1.png … Picture26.png + PictureResult.PNG
└── Properties/
    └── launchSettings.json     # Dev server on http://localhost:5161
```

Root-level files: `Dockerfile`, `docker-compose.yml`, `nginx.conf`, `ShrekQuiz.sln`, `ShrekQuiz.md` (original spec — not used at runtime).

## Commands

```bash
# Development (starts dev server with hot reload on localhost:5161)
dotnet run --project ShrekQuiz/ShrekQuiz.csproj

# Build
dotnet build ShrekQuiz/ShrekQuiz.csproj

# Publish for production (creates /app/publish/wwwroot)
dotnet publish ShrekQuiz/ShrekQuiz.csproj -c Release -o /app/publish

# Docker (serves on localhost:8080)
docker compose up --build
```

There are **no tests** in this project.

## Docker / deployment

- Multi-stage build: `dotnet:8.0` SDK publishes, then `nginx:alpine` serves `wwwroot` as static files.
- **The `nginx.conf` MIME type declarations for `.wasm`, `.dll`, `.pdb`, `.dat` are CRITICAL** — Blazor WASM will not load without them.
- Host port 8080 maps to container port 80.
- SPA fallback: all routes -> `index.html` (no-cache headers to prevent stale loads).
- CSS/JS served with `no-store` cache headers; framework files (`.wasm`, `.dll`) cached 1 year with immutable.

## Image handling

- Question image paths in `QuizService` follow the pattern `images/Picture{N}.png`.
- Two exceptions use `.jpg`: Picture5 and Picture25.
- The result screen image is `images/PictureResult.PNG` (capital extension — case matters on Linux/nginx).
- **Image preloading**: Hidden `<img>` tags preload the next question's image while the user reads the current question. The start screen preloads Q1's image; each quiz step preloads the next; the last question preloads the result image. This avoids loading delays on slow connections.

## Conventions

- App language is **Russian** (questions, UI text, Razor comments, 404 page, PWA manifest).
- CSS uses `var()`-based design tokens (colors, spacing, typography, radii, shadows) defined in `:root` under `wwwroot/css/app.css`. Prefer extending custom properties over hardcoding hex values.
- The `--scale` custom property (default 1) gates global UI scaling across breakpoints — adjust it rather than touching individual sizes.
- Bootstrap is bundled as a minified file; do not replace with a CDN unless the app moves to a non-Docker deployment.
- Question 17 is the only question with 4 options (all others have 3).
- Question 3's correct answer was ambiguous in the spec; the implementation chose index 0 ("Три слепых мышонка").
- The result screen includes hardcoded birthday wishes — this is intentional for the app's original purpose, not a bug.
- The `_Imports.razor` file provides global `@using` for all project namespaces — new Razor files don't need explicit usings.

## State flow in Home.razor

```
_showStart=true  → start screen (hero title + "Начать квиз!" button)
    StartQuiz() sets _showStart=false, _currentIndex=1

_showResult=false & _showStart=false → quiz mode
    SelectAnswer(index) locks input, increments _score if correct
    NextQuestion() advances _currentIndex or sets _showResult=true

_showResult=true → result screen (score, birthday wishes, result image)
    RestartQuiz() resets all state to initial
```

Index math: `_currentIndex` is 1-based (question number). `CurrentQuestion` is `Questions[_currentIndex - 1]`. When `_currentIndex > Questions.Count`, the quiz is complete.

## Git notes

- Commit messages are in English.
- The root-level `images/` directory was removed in commit `6f8666f` — only `wwwroot/images/` is used.
- `ShrekQuiz.md` is the original AI-generated spec, not part of the running app.
