using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName = "C#"},
                new Category(){CategoryName = "Asp.Net MVC"},
                new Category(){CategoryName = "Windows Form"},
                new Category(){CategoryName = "Asp.Net Core MVC"},
            };
            categories.ForEach(c =>
            {
                context.Categories.Add(c);
            });
            context.SaveChanges();
            List<Blog> blogs = new List<Blog>()
            {
                new Blog()
                {
                    Title ="C# override methods",
                    Description = "Virtual ve override kavramlarının açıklanması",
                    UploadDate = DateTime.Now.AddDays(-15),
                    Home = true,
                    Confirmation = true,
                    Content = "override, devralınan bir metodun, özelliğin, dizin oluşturucunun veya olayın soyut veya sanal uygulamasını genişletmek ya da değiştirmek için gereklidir.Bir override yöntemi, temel sınıftan devralınan bir üyenin yeni bir uygulamasını sağlar. Bir bildirim tarafından geçersiz kılınan yöntem, override geçersiz kılınan temel yöntem olarak bilinir.",
                    Photo = "1.jpg",
                    CategoryId = 1
                },
                new Blog()
                {
                    Title ="C# Diziler",
                    Description = "Dizilerin açıklanması",
                    UploadDate = DateTime.Now.AddDays(-5),
                    Home = false,
                    Confirmation = false,
                    Content = "Dizi , hesaplanan dizinler üzerinden erişilen çeşitli değişkenler içeren bir veri yapısıdır. Dizinin öğeleri olarak da adlandırılan bir dizide bulunan değişkenler aynı türde. Bu tür, dizinin öğe türü olarak adlandırılır.",
                    Photo = "2.jpg",
                    CategoryId = 1
                },
                new Blog()
                {
                    Title ="C# Döngüler",
                    Description = "For While Do Döngü mekanizması",
                    UploadDate = DateTime.Now.AddDays(-7),
                    Home = true,
                    Confirmation = false,
                    Content = "C# döngüler, Programlama dilinde döngüler belirtilen komut satırlarının tekrar tekrar çalıştırılmasını sağlayan yapılardır. For döngüsü genellikle üç ifade ile kullanılır. Bu ifadelerden ilkinde döngü değişkeni için bir başlangıç değeri verilir. İkinci ifadede döngü değişkenin değerine bağlı bir koşul belirlenir bu koşul sağlandığı sürece döngü içerisindeki belirtilen işlemleri tekrar eder. Üçüncü ifade de çoğunlukla döngü değişkeninin artış yada azalış miktarı için kullanılır.",
                    Photo = "1.jpg",
                    CategoryId = 2
                },
                new Blog()
                {
                    Title ="C# Değişkenler",
                    Description = "For While Do Döngü mekanizması",
                    UploadDate = DateTime.Now.AddDays(-23),
                    Home = true,
                    Confirmation = true,
                    Content = "C# , Programlama dilinde döngüler belirtilen komut satırlarının tekrar tekrar çalıştırılmasını sağlayan yapılardır. For döngüsü genellikle üç ifade ile kullanılır. Bu ifadelerden ilkinde döngü değişkeni için bir başlangıç değeri verilir. İkinci ifadede döngü değişkenin değerine bağlı bir koşul belirlenir bu koşul sağlandığı sürece döngü içerisindeki belirtilen işlemleri tekrar eder. Üçüncü ifade de çoğunlukla döngü değişkeninin artış yada azalış miktarı için kullanılır.",
                    Photo = "2.jpg",
                    CategoryId = 3
                },
                new Blog()
                {
                    Title ="C# Generics",
                    Description = "For While Do Döngü mekanizması",
                    UploadDate = DateTime.Now.AddDays(-7),
                    Home = true,
                    Confirmation = false,
                    Content = " Bu ifadelerden ilkinde döngü değişkeni için bir başlangıç değeri verilir. İkinci ifadede döngü değişkenin değerine bağlı bir koşul belirlenir bu koşul sağlandığı sürece döngü içerisindeki belirtilen işlemleri tekrar eder. Üçüncü ifade de çoğunlukla döngü değişkeninin artış yada azalış miktarı için kullanılır.",
                    Photo = "2.jpg",
                    CategoryId = 4
                }
            };
            blogs.ForEach(blog =>
            {
                context.Blogs.Add(blog);
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}