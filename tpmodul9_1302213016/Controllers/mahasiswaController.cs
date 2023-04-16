using Microsoft.AspNetCore.Mvc;


namespace tpmodul9_1302213016.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Reza Adhie Dharmawan","1302213016"),
            new Mahasiswa ("Muhammad Zaky Fathurahim","1302213067"),
            new Mahasiswa ("Rizki Muhammad Ridwan","1302210097"),
            new Mahasiswa ("Fasya Rayhan Maulana","1302213116" ),
            new Mahasiswa ("Mochaman Rifqi Barlian","1302210125"),
            new Mahasiswa ("Raihan Sulthon Yaafi","1302213074")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return ListMahasiswa[id];
        }


        [HttpPost]
        public void Post(Mahasiswa m)
        {
            ListMahasiswa.Add(m);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMahasiswa.RemoveAt(id);
        }


    }
}