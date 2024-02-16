using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor() 
            {
                Id = 1,
                InstructorId = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Description = "Yazılım geliştirmeye lisede \"yazılım\" bölümünde okurken başladım.\r\n\r\nÜniversite hayatıma ÖSS 2003 Türkiye derecesiyle başladım. Sırasıyla Başkent ve ODTÜ'de Yönetim Bilişim Sistemleri (Lisans-Burslu) ve Tıp Bilişimi(Yüksek Lisans) okudum. Profesyonel iş hayatıma ise henüz üniversite birinci sınıftayken başladım.\r\n\r\nAğırlıklı olarak Savunma Sanayisi, Bankacılık sektörlerine kurumsal yazılım geliştirme süreçleri konusunda danışmanlık veriyorum.\r\n\r\nMicrosoft Certified Trainer (MCT) ,PMP ve ITIL sertifikalarına sahibim.\r\n\r\n\"Engin Demiroğ\" YouTube kanalımda ücretsiz eğitim videoları ve içerikleri paylaşmaktayım.\r\n\r\nDanışmanlık yaptığım kurumların bazıları : Merkez Bankası,TAI, Birleşmiş Milletler,NATO,İş Bankası, Akbank, Halkbank, Vakıfbank, Yapı Kredi Bankası, Ziraat Bankası, Emniyet, Başbakanlık, Cumhurbaşkanlığı, Hazine Müsteşarlığı, Maliye Bakanlığı, Tarım Bakanlığı, Tübitak.\r\n\r\nDanışmanlık veya eğitim verdiğim kurum sayısı son 10 yılda 300'ü geçmiştir.\r\n\r\nDevFramework ismiyle geliştirdiğim altyapı projem birçok kurum ve firmada yazılım geliştirme altyapısı olarak kullanılmaktadır.",
            };
            Instructor instructor2 = new Instructor()
            {
                Id = 2,
                InstructorId = 2,
                FirstName = "Halit Enes",
                LastName = "Kalaycı",
                Description = "Yazılım geliştirme sürecine lise sonuncu sınıfta başladım.\r\n\r\nSakarya Üniversitesi Yönetim Bilişim Sistemleri programından mezun oldum. \r\n\r\nProfesyonel iş hayatım üniversite 3. sınıfta başladı.\r\n\r\nKariyerime kodlama.io'da Yazılım Eğitmeni ve Danışmanı olarak devam ediyorum.\r\n\r\nEğitim ve danışmanlık verdiğim kurumların bazıları; Esbaş, Etiya, KDK, Turkcell, Bosch. \r\n\r\nkodlama.io olarak geliştirdiğimiz \"nArch\" projesinde aktif geliştirici olarak rol almaktayım.",
            };

            instructors = new List<Instructor>() { instructor1, instructor2 };
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
            Console.WriteLine("Instructor Added.");
        }

        public void Delete(Instructor instructor)
        {
            instructors.Remove(instructor);
            Console.WriteLine("Instructor Deleted");
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Instructor Updated.");
        }
    }
}
