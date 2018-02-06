using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi="C#" },
                new Category() { KategoriAdi="Java" },
                new Category() { KategoriAdi="Python" },
                new Category() { KategoriAdi="Kotlin" },
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() { Baslik="C# Delegates", Aciklama="Ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue augue nunc elit dolor, luctus placerat.",EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Velit mollis odio sollicitudin lacinia aliquam posuere, sapien elementum lobortis tincidunt, turpis dui ornare nisl, sollicitudin interdum turpis nunc eget sem nulla eu ultricies orci praesent id augue nec lorem pretium congue sit amet ac nunc fusce iaculis lorem eu diam hendrerit at mattis purus dignissim vivamus mauris tellus, fringilla vel dapibus a, blandit quis erat vivamus elementum aliquam luctus etiam fringilla pretium sem vitae sodales mauris id nulla est praesent laoreet, metus vel auctor aliquam, eros purus vulputate leo, eget consequat neque quam id tellus duis ultricies tempor tortor, vitae dignissim ligula mattis nec in hac habitasse platea dictumst.", Resim="1.jpg", CategoryId=1 },
                new Blog() { Baslik="C# Inheritance", Aciklama="Inheritance makes programs simpler and faster. With inheritance, we build several types upon a common abstraction. Then we later act upon all those types through the abstraction. We examine inheritance and polymorphism in the C# language.", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="Base class: The class another class inherits from.In the C# language, the ultimate base class is the object class. Derived class: The class with a base class. A derived class may have multiple levels of base classes. Example.When you specify that a class derives from another class, the class you create acquires all the features of the base class. If the derived class has a few extra features but is otherwise the same as the base class, this is a good approach.", Resim="1.jpg", CategoryId=1 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-30), Anasayfa=false, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=1 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="2.jpg", CategoryId=2 },
                new Blog() { Baslik="C# Generic List Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-5), Anasayfa=true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=2 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="2.jpg", CategoryId=2 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="2.jpg", CategoryId=3 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="2.jpg", CategoryId=3 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-15), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=3 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-17), Anasayfa=true, Onay=false, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="2.jpg", CategoryId=4 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=4},
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=4 },
                new Blog() { Baslik="C# Delegates Hakkında", Aciklama="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik="C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında", Resim="1.jpg", CategoryId=4 },
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}