
using AcunMedyaOdev3_CihanKurtbey;
using System.Runtime.InteropServices;

Manager manager = new Manager(1, "Ahmet", 5000, "Yönetim", 10);
manager.DisplayInfo();

Console.WriteLine();

// Developer nesnesi oluşturma
Developer developer = new Developer(2, "Mehmet", 4000, "Yazılım", "Full Stack Developer");
developer.DisplayInfo();