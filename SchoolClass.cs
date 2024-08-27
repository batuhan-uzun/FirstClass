using FirstClass;

Person student1 = new Person();
student1.Name = "Ahmet";
student1.Surname = "Mutlu";
student1.BirthDate = DateTime.Parse("20.03.2003");

Console.WriteLine($"Student Name: {student1.Name} Student Surname: {student1.Surname} Student Birth Date: {student1.BirthDate.ToString("dd.MM.yyyy")}");

Person student2 = new Person();
student2.Name = "Selim";
student2.Surname = "Yılmaz";
student2.BirthDate = DateTime.Parse("10.08.2002");

Console.WriteLine($"Student Name: {student2.Name} Student Surname: {student2.Surname} Student Birth Date: {student2.BirthDate.ToString("dd.MM.yyyy")}");

Person teacher1 = new Person();
teacher1.Name = "Süleyman";
teacher1.Surname = "Gürbüz";
teacher1.BirthDate = DateTime.Parse("03.11.1985");

Console.WriteLine($"Teacher Name: {teacher1.Name} Teacher Surname: {teacher1.Surname} Teacher Birth Date: {teacher1.BirthDate.ToString("dd.MM.yyyy")}");

Person teacher2 = new Person();
teacher2.Name = "Osman";
teacher2.Surname = "Yıldırım";
teacher2.BirthDate = DateTime.Parse("28.09.1972");

Console.WriteLine($"Teacher Name: {teacher2.Name} Teacher Surname: {teacher2.Surname} Teacher Birth Date: {teacher2.BirthDate.ToString("dd.MM.yyyy")}");



