using System.Security.Cryptography.X509Certificates;

namespace MODUL10
{
    public class Mahasiswa
    {
        public String Nama { get; set; }
        public String NIM { get; set; }
        public List<String> Course{ get; set; }
        public int year { get; set; }
        public Mahasiswa(String Nama, String NIM, List<String> Course, int year) 
        {
            this.Nama = Nama;
            this.NIM = NIM;
            this.Course = Course;
            this.year = year;
        }
    }
}
