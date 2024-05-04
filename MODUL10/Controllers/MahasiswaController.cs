using Microsoft.AspNetCore.Mvc;

namespace MODUL10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<String> Course = new List<String> { "PBO", "KPL", "BD", "UX" };
        private static List<Mahasiswa> arrMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Muhammad Izhar Fahriansyah", "1302220056" , Course,2022 ),
            new Mahasiswa ("Nabiel Ascar Mochamad", "1302220080", Course,2021 ),
            new Mahasiswa ("Fauzan Arrizqy Putra", "1302220004" , Course, 2023),
            new Mahasiswa ("Wildan Hadi Fernando", "1302223012" , Course,2020)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return arrMahasiswa;
        }

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            return arrMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            arrMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            arrMahasiswa.RemoveAt(id);
        }
    }
}