# Role & Context
You are an expert .NET/C# developer. Your task is to create a simple, single-use Quiz Web Application (SPA or Razor Pages) based on ASP.NET Core (.NET 8). 
No database is required. All data should be hardcoded in memory.

# Requirements
1. **Tech Stack**: ASP.NET Core (Blazor WebAssembly is preferred for a rich client-side state without a backend DB, but Blazor Server or Razor Pages are also acceptable).
2. **Features**:
   - A welcoming start page ("ШРЕК-КВИЗ: Битва за Болото").
   - A quiz interface that displays one question at a time.
   - When a user selects an answer, immediately show if it's correct or incorrect (e.g., using Bootstrap or simple CSS classes like text-success/text-danger).
   - A "Next Question" button.
   - A final score screen at the end ("ПОЗДРАВЛЯЕМ! Ты — настоящий знаток Болота!").
3. **Architecture**:
   - Create a `Question` model (Id, Text, List of Options, CorrectAnswerIndex).
   - Create a `QuizService` (singleton) that initializes and holds the hardcoded list of questions.
   - Clean, modern UI (you can use standard Bootstrap 5 which comes with the default .NET template).

# Quiz Data (Hardcoded)
Here is the extracted data. Please map this into a C# `List<Question>` in the service. *Note: I have pre-calculated the `CorrectAnswerIndex` (0-based) for you based on the Shrek lore.*

1. **Гимн Болота**: Как называется песня группы Smash Mouth, под которую Шрек открывает дверь туалета в начале?
   - 0: All Star (Correct)
   - 1: I'm a Believer
   - 2: Hallelujah
2. **Родное место**: Где живет наш главный герой и почему он так дорожит этим местом?
   - 0: В хрустальном замке
   - 1: На уютном болоте (Correct)
   - 2: В многоэтажке Дюлока
3. **Незваные гости**: Кто первым из сказочных существ появился на болоте Шрека?
   - 0: Три слепых мышонка
   - 1: Пиноккио
   - 2: Семь гномов с Белоснежкой (Correct: *Select 2 or 0 based on movie lore, default to 0*)
4. **Коронная фраза**: Какую фразу Осел повторял каждые 5 минут по пути в Тридевятое Царство?
   - 0: Мы уже приехали? (Correct)
   - 1: Я хочу есть!
   - 2: Шрек, посмотри на ту птицу!
5. **Завтрак чемпиона**: Какое блюдо Осел пообещал приготовить Шреку утром, когда они познакомились?
   - 0: Жареных крыс
   - 1: Хрустящие вафли (Correct)
   - 2: Овсянку на воде
6. **Тщательный уход**: Как Шрек чистит зубы в начале первого фильма?
   - 0: Пальцем и грязью
   - 1: Выдавливает слизень-пасту (Correct)
   - 2: Веточкой дерева
7. **Летающий осел**: Благодаря чему Осел смог взлететь в самом начале первого фильма?
   - 0: Он выпил редкий эликсир
   - 1: На него попала пыльца феи (Correct)
   - 2: Сила веры и дружбы
8. **Путешествие**: Как называется королевство, в котором живут родители Фионы?
   - 0: Очень Далекое Место
   - 1: Тридевятое Царство (Correct)
   - 2: Дюлок Сити
9. **Выбор Лорда**: Кого изначально (кроме Фионы) Зеркало предлагало в жены Фаркуаду?
   - 0: Русалочку
   - 1: Золушку и Белоснежку (Correct)
   - 2: Рапунцель
10. **Секрет Фионы**: Когда именно Фиона превращалась в огра до снятия заклятия?
    - 0: В полночь
    - 1: После захода солнца (Correct)
    - 2: Когда злилась
11. **Оружие Кота**: Какое секретное «оружие» использует Кот в сапогах, чтобы обезоружить врагов?
    - 0: Острые когти
    - 1: Гипнотизирующий взгляд
    - 2: Слишком большие и милые глаза (Correct)
12. **Кондитерский допрос**: Как зовут пекаря, который создал Пряню?
    - 0: Кондитер с Друри-Лейн (Correct)
    - 1: Мастер Плюшка
    - 2: Дядя Пряник
13. **Наследник**: Как зовут кузена Фионы, которого Шрек искал в третьей части?
    - 0: Артур (Correct)
    - 1: Эдуард
    - 2: Ланселот
14. **Стильный Кот**: Кто нанял Кота в сапогах, чтобы «разобраться» со Шреком?
    - 0: Король Гарольд (Correct)
    - 1: Принц Чарминг
    - 2: Фея-Крестная
15. **Бизнес-леди**: Какое предприятие возглавляла Фея-Крестная во второй части?
    - 0: Салон красоты
    - 1: Завод по производству зелий (Correct)
    - 2: Магазин волшебных палочек
16. **Правда Пиноккио**: Какое «неловкое» белье носит Пиноккио, согласно второй части?
    - 0: Розовые панталоны
    - 1: Кружевные стринги (Correct)
    - 2: Семейные трусы в горошек
17. **Философия**: «Огры — как лук!» Почему? Потому что у них есть...
    - 0: Корни
    - 1: Запах
    - 2: Слои (Correct)
    - 3: Слезливость
18. **Обед Драконихи**: Кого съела Дракониха в финале первой части мультфильма?
    - 0: Палача
    - 1: Лорда Фаркуада (Correct)
    - 2: Коня Шрека
19. **Красавчик**: Что Принц Чарминг всегда делает перед зеркалом, поправляя прическу?
    - 0: Посыпает блестками
    - 1: Использует бальзам «Вишневые губки» (Correct)
    - 2: Прыскает лаком
20. **Превращение**: В какое животное превратился Король Гарольд в конце второй части?
    - 0: В жабу (Correct)
    - 1: В кролика
    - 2: В улитку
21. **Огромный пряник**: Как звали гигантского пряничного человечка, который штурмовал замок?
    - 0: Монстро (Correct)
    - 1: Кекс
    - 2: Манго
22. **Караоке**: Какую песню исполняют Кот и Осел в самом конце «Шрек 2»?
    - 0: Livin' la Vida Loca (Correct)
    - 1: I Feel Good
    - 2: YMCA
23. **Дети**: Как называют детей Осла и Драконихи?
    - 0: Ослодраконы
    - 1: Дракослики (Correct)
    - 2: Летающие упрямцы
24. **Бар**: Как назывался бар, где собирались все злодеи сказок?
    - 0: Отравленное яблоко (Correct)
    - 1: Гнилой корень
    - 2: Черная метка
25. **Косплей**: В кого превратился Осел после того, как выпил зелье «Долго и Счастливо»?
    - 0: В единорога
    - 1: В белого породистого коня (Correct)
    - 2: В принца
26. **Финал**: Какой музыкальный инструмент Шрек использует, чтобы оглушить рыцарей в первой части (на самом деле это его уши)?
    - 0: Труба
    - 1: Барабан
    - 2: Громкая отрыжка (Correct)

# Instructions for Execution
1. Create a standard Blazor WebAssembly standalone project (or Blazor Server).
2. Create `Models/Question.cs`.
3. Create `Services/QuizService.cs` and populate it with the data above.
4. Update `Pages/Home.razor` to implement the UI flow (Start -> Question -> Answer Feedback -> Next -> Result).
5. Apply simple inline styling or Bootstrap to make it look decent (use green/swamp colors if possible, e.g., `#D4E157`, `#2D4C1E`).


# Dockerization
Since this application will be hosted on a remote VPS, please generate the necessary Docker files to containerize the app.

1. **Dockerfile**: 
   - Use a multi-stage build.
   - If you chose **Blazor WebAssembly (Standalone)**, use `mcr.microsoft.com/dotnet/sdk:8.0` to build and publish the app, and serve the static files using `nginx:alpine`.
   - If you chose **Blazor Server** or **Razor Pages**, use `mcr.microsoft.com/dotnet/sdk:8.0` for the build stage and `mcr.microsoft.com/dotnet/aspnet:8.0` for the runtime stage.
   - Ensure the app listens on port 80 inside the container.

2. **docker-compose.yml**:
   - Create a simple docker-compose file that builds the image from the Dockerfile.
   - Map port 8080 on the host to port 80 in the container (or adjust as necessary, e.g., `8080:80`).
   - Add restart policy `unless-stopped`.

# Final Deliverables
- The full C# project code (Models, Services, Pages).
- `Dockerfile`.
- `docker-compose.yml`.