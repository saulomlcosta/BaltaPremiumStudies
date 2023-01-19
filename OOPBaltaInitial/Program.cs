// See https://aka.ms/new-console-template for more information
using OOPBaltaInitial.ContentContext;
using OOPBaltaInitial.SubscriptionContext;
using static System.Console;

//First Example;

// #region Article
// 	var articles = new List<Article>();
// 	articles.Add(new Article("Artigo sobre OOP", "orietacao-objetos"));
// 	articles.Add(new Article("Artigo sobre C#", "csharp"));
// 	articles.Add(new Article("Artigo sobre .NET", ".net"));

// 	foreach (var article in articles)
// 	{
// 	    WriteLine(article.Title);
// 	    WriteLine(article.Url);
// 	}
// #endregion

//Second Example;
// #region Courses,Careers,CareerItem

// var courses = new List<Course>();
// var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
// var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
// var courseDotNet = new Course("Fundamentos .NET", "fundamentos-dotnet");
// courses.Add(courseOOP);
// courses.Add(courseCSharp);
// courses.Add(courseDotNet);

// var careers = new List<Career>();
// var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
// var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
// var careerItem1 = new CareerItem(1, "Comece por aqui!", "", courseCSharp);
// var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseDotNet);
// careerDotNet.Items.Add(careerItem2);
// careerDotNet.Items.Add(careerItem1);
// careerDotNet.Items.Add(careerItem3);
// careers.Add(careerDotNet);

// foreach (var career in careers)
// {
//     WriteLine(career.Title);
//     foreach (var item in career.Items.OrderBy(x => x.Order))
//     {
//         Console.ResetColor();
//         WriteLine($"{item.Order} - {item.Title}");
//         if (item.IsInvalid)
//         {
//             foreach (var notificationItem in item.Notifications)
//             {
//                 // Using notifications
//                 Console.BackgroundColor = ConsoleColor.Red;
//                 Console.ForegroundColor = ConsoleColor.Black;
//                 WriteLine($"{notificationItem.Property} - {notificationItem.Message}");

//                 // Simple Log in file.txt, creates a file inside a directory with notifications
//                 var DirectoryPath = Path.Combine(Environment.CurrentDirectory, "logError");
//                 Directory.CreateDirectory(DirectoryPath);
//                 var FilePath = Path.Combine(DirectoryPath, "logError.txt");

//                 using (var streamWriter = File.CreateText(FilePath))
//                 {
//                     streamWriter.WriteLine($"{notificationItem.Property} - {notificationItem.Message}");
//                 }
//             }
//             continue;
//         }

//         WriteLine(item.Course?.Title);
//         WriteLine(item.Course?.Level);
//     }
// }

// #endregion

// #region Subscription Student
// 	var paypalSubscription = new PaypalSubscription();

// 	var students = new List<Student>();
// 	var student1 = new Student();
// 	student1.Name = "Carlos";
// 	var student2 = new Student();
// 	student2.Name = "Jonas";
// 	students.Add(student1);
// 	students.Add(student2);

// 	student1.CreateSubscription(paypalSubscription);

// 	foreach (var item in students)
// 	{
// 	    WriteLine(item.Name);
// 	    WriteLine(item.IsPremium);

// 	    foreach (var notificationItem in item.Notifications)
// 	    {
// 	        WriteLine($"{notificationItem.Property} - {notificationItem.Message}");
// 	    }
// 	}
// #endregion

ReadLine();