using Microsoft.Extensions.Configuration;
using System;

namespace AdminLoginSignUpModule
{
    public class Program
    {
        static IConfiguration _configuration;
        static void Main()
        {
            Console.WriteLine("Yazarın Adı: ");
            string authorName = Console.ReadLine();

            Console.WriteLine("Yazarın İkinci Adı: ");
            string authorSecondName = Console.ReadLine();

            Console.WriteLine("Yazarın Soyadı: ");
            string authorLastName = Console.ReadLine();

            Console.WriteLine("Yazarın Doğum Tarihi (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime authorBirthday))
            {
                Console.WriteLine("Yazarın Gönderi Sayısı: ");
                if (int.TryParse(Console.ReadLine(), out int postCount))
                {
                    Console.WriteLine("Yazarın Hakkında: ");
                    string aboutMe = Console.ReadLine();

                    Console.WriteLine("Yazarın Hedefi: ");
                    string authorAim = Console.ReadLine();

                    Console.WriteLine("Haftada Kaç Saat Çalışıyor: ");
                    if (int.TryParse(Console.ReadLine(), out int hoursPerWeek))
                    {
                        Console.WriteLine("Kod Satırı Sayısı: ");
                        if (int.TryParse(Console.ReadLine(), out int linesOfCode))
                        {
                            Console.WriteLine("Tamamlanan Proje Sayısı: ");
                            if (int.TryParse(Console.ReadLine(), out int completedProject))
                            {
                                Console.WriteLine("Yazarın Rolü: ");
                                string authorRole = Console.ReadLine();

                                Console.WriteLine("Email: ");
                                string email = Console.ReadLine();

                                Console.WriteLine("Şifre: ");
                                string password = Console.ReadLine();

                                HashingAlgorithm hashing = new HashingAlgorithm(saltPassowrd);
                                var resultOfDTO = hashing.GenerateSaltedHash(password);

                                var newAuthor = new AuthorDTO()
                                    {
                                        Id = Guid.NewGuid(),
                                        AuthorName = authorName,
                                        AuthorSecondName = authorSecondName,
                                        AuthorLastName = authorLastName,
                                        AuthorBirthday = authorBirthday,
                                        PostCount = postCount,
                                        AboutMe = aboutMe,
                                        AuthorAim = authorAim,
                                        HoursPerWeek = hoursPerWeek,
                                        LinesOfCode = linesOfCode,
                                        CompletedProject = completedProject,
                                        AuthorRole = authorRole,
                                        CreatedDateTime = DateTime.Now,
                                        IsActive = true,
                                        IsDeleted = false,
                                        Email = email,
                                        Password = password
                                    };


                                Console.WriteLine("Yazar başarıyla eklendi.");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz tamamlanan proje sayısı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz kod satırı sayısı.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz saat sayısı.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz gönderi sayısı.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz tarih formatı.");
            }
        }
    }
}
