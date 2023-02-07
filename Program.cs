using BaltaOrientacaoObjetos.ContentContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

var courses = new List<Course>();
var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

courses.Add(courseOOP);
courses.Add(courseCSharp);
courses.Add(courseAspNet);

var careers = new List<Career>();

var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
careers.Add(careerDotNet);

var careerItem1 = new CareerItem(1, "Comece por aqui", "", courseAspNet);
var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);

careerDotNet.Items.Add(careerItem1);
careerDotNet.Items.Add(careerItem2);
careerDotNet.Items.Add(careerItem3);
