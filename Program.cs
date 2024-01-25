using Balta.ContentContext;
using Balta.SubscriptionContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

// foreach (var article in articles)
// {
//     Console.WriteLine($"{article.Id} | {article.Title} | {article.Url}");
// }

var courseCsharpFundamentals = new Course("Fundamentos C#", "fundamentos-csharp");
var courseOop = new Course("Fundamentos OOP", "fundamentos-opp");
var courseAspnet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

var courses = new List<Course>();
courses.Add(courseCsharpFundamentals);
courses.Add(courseOop);
courses.Add(courseAspnet);

var careerDotnet = new Career("Especialista em .NET", "especialista-dotnet");

var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOop);
var careerItem1 = new CareerItem(1, "Comece por aqui", "", courseCsharpFundamentals);
var careerItem3 = new CareerItem(3, "Aprenda ASP.NET", "", null);
careerDotnet.Items.Add(careerItem2);
careerDotnet.Items.Add(careerItem1);
careerDotnet.Items.Add(careerItem3);

var careers = new List<Career>();
careers.Add(careerDotnet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);

    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"     {item.Order} - {item.Title} - Curso: {item.Course?.Title}");

        Console.WriteLine($"          Item de carreira é inválido? {item.IsInvalid}");
        if (item.IsInvalid)
        {
            foreach (var notification in item.Notifications)
            {
                Console.WriteLine($"          {notification.Property} - {notification.Message}");
            }
        }
    }
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();
student.CreateSubscription(payPalSubscription);