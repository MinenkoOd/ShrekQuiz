using ShrekQuiz.Models;

namespace ShrekQuiz.Services;

public class QuizService
{
    public List<Question> Questions { get; } =
    [
        new Question
        {
            Id = 1,
            Text = "Гимн Болота: Как называется песня группы Smash Mouth, под которую Шрек открывает дверь туалета в начале?",
            Options = ["All Star", "I'm a Believer", "Hallelujah"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture1.png"
        },
        new Question
        {
            Id = 2,
            Text = "Родное место: Где живет наш главный герой и почему он так дорожит этим местом?",
            Options = ["В хрустальном замке", "На уютном болоте", "В многоэтажке Дюлока"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture2.png"
        },
        new Question
        {
            Id = 3,
            Text = "Незваные гости: Кто первым из сказочных существ появился на болоте Шрека?",
            Options = ["Три слепых мышонка", "Пиноккио", "Семь гномов с Белоснежкой"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture3.png"
        },
        new Question
        {
            Id = 4,
            Text = "Коронная фраза: Какую фразу Осел повторял каждые 5 минут по пути в Тридевятое Царство?",
            Options = ["Мы уже приехали?", "Я хочу есть!", "Шрек, посмотри на ту птицу!"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture4.png"
        },
        new Question
        {
            Id = 5,
            Text = "Завтрак чемпиона: Какое блюдо Осел пообещал приготовить Шреку утром, когда они познакомились?",
            Options = ["Жареных крыс", "Хрустящие вафли", "Овсянку на воде"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture5.jpg"
        },
        new Question
        {
            Id = 6,
            Text = "Тщательный уход: Как Шрек чистит зубы в начале первого фильма?",
            Options = ["Пальцем и грязью", "Выдавливает слизень-пасту", "Веточкой дерева"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture6.png"
        },
        new Question
        {
            Id = 7,
            Text = "Летающий осел: Благодаря чему Осел смог взлететь в самом начале первого фильма?",
            Options = ["Он выпил редкий эликсир", "На него попала пыльца феи", "Сила веры и дружбы"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture7.png"
        },
        new Question
        {
            Id = 8,
            Text = "Путешествие: Как называется королевство, в котором живут родители Фионы?",
            Options = ["Очень Далекое Место", "Тридевятое Царство", "Дюлок Сити"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture8.png"
        },
        new Question
        {
            Id = 9,
            Text = "Выбор Лорда: Кого изначально (кроме Фионы) Зеркало предлагало в жены Фаркуаду?",
            Options = ["Русалочку", "Золушку и Белоснежку", "Рапунцель"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture9.png"
        },
        new Question
        {
            Id = 10,
            Text = "Секрет Фионы: Когда именно Фиона превращалась в огра до снятия заклятия?",
            Options = ["В полночь", "После захода солнца", "Когда злилась"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture10.png"
        },
        new Question
        {
            Id = 11,
            Text = "Оружие Кота: Какое секретное «оружие» использует Кот в сапогах, чтобы обезоружить врагов?",
            Options = ["Острые когти", "Гипнотизирующий взгляд", "Слишком большие и милые глаза"],
            CorrectAnswerIndex = 2,
            ImagePath = "images/Picture11.png"
        },
        new Question
        {
            Id = 12,
            Text = "Кондитерский допрос: Как зовут пекаря, который создал Пряню?",
            Options = ["Кондитер с Друри-Лейн", "Мастер Плюшка", "Дядя Пряник"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture12.png"
        },
        new Question
        {
            Id = 13,
            Text = "Наследник: Как зовут кузена Фионы, которого Шрек искал в третьей части?",
            Options = ["Артур", "Эдуард", "Ланселот"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture13.png"
        },
        new Question
        {
            Id = 14,
            Text = "Стильный Кот: Кто нанял Кота в сапогах, чтобы «разобраться» со Шреком?",
            Options = ["Король Гарольд", "Принц Чарминг", "Фея-Крестная"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture14.png"
        },
        new Question
        {
            Id = 15,
            Text = "Бизнес-леди: Какое предприятие возглавляла Фея-Крестная во второй части?",
            Options = ["Салон красоты", "Завод по производству зелий", "Магазин волшебных палочек"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture15.png"
        },
        new Question
        {
            Id = 16,
            Text = "Правда Пиноккио: Какое «неловкое» белье носит Пиноккио, согласно второй части?",
            Options = ["Розовые панталоны", "Кружевные стринги", "Семейные трусы в горошек"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture16.png"
        },
        new Question
        {
            Id = 17,
            Text = "Философия: «Огры — как лук!» Почему? Потому что у них есть...",
            Options = ["Корни", "Запах", "Слои", "Слезливость"],
            CorrectAnswerIndex = 2,
            ImagePath = "images/Picture17.png"
        },
        new Question
        {
            Id = 18,
            Text = "Обед Драконихи: Кого съела Дракониха в финале первой части мультфильма?",
            Options = ["Палача", "Лорда Фаркуада", "Коня Шрека"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture18.png"
        },
        new Question
        {
            Id = 19,
            Text = "Красавчик: Что Принц Чарминг всегда делает перед зеркалом, поправляя прическу?",
            Options = ["Посыпает блестками", "Использует бальзам «Вишневые губки»", "Прыскает лаком"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture19.png"
        },
        new Question
        {
            Id = 20,
            Text = "Превращение: В какое животное превратился Король Гарольд в конце второй части?",
            Options = ["В жабу", "В кролика", "В улитку"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture20.png"
        },
        new Question
        {
            Id = 21,
            Text = "Огромный пряник: Как звали гигантского пряничного человечка, который штурмовал замок?",
            Options = ["Монстро", "Кекс", "Манго"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture21.png"
        },
        new Question
        {
            Id = 22,
            Text = "Караоке: Какую песню исполняют Кот и Осел в самом конце «Шрек 2»?",
            Options = ["Livin' la Vida Loca", "I Feel Good", "YMCA"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture22.png"
        },
        new Question
        {
            Id = 23,
            Text = "Дети: Как называют детей Осла и Драконихи?",
            Options = ["Ослодраконы", "Дракослики", "Летающие упрямцы"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture23.png"
        },
        new Question
        {
            Id = 24,
            Text = "Бар: Как назывался бар, где собирались все злодеи сказок?",
            Options = ["Отравленное яблоко", "Гнилой корень", "Черная метка"],
            CorrectAnswerIndex = 0,
            ImagePath = "images/Picture24.png"
        },
        new Question
        {
            Id = 25,
            Text = "Косплей: В кого превратился Осел после того, как выпил зелье «Долго и Счастливо»?",
            Options = ["В единорога", "В белого породистого коня", "В принца"],
            CorrectAnswerIndex = 1,
            ImagePath = "images/Picture25.jpg"
        },
        new Question
        {
            Id = 26,
            Text = "Финал: Какой музыкальный инструмент Шрек использует, чтобы оглушить рыцарей в первой части (на самом деле это его уши)?",
            Options = ["Труба", "Барабан", "Громкая отрыжка"],
            CorrectAnswerIndex = 2,
            ImagePath = "images/Picture26.png"
        }
    ];
}
