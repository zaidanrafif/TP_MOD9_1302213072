using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302210032.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Zaidan Rafif", "1302213072"),
            new Mahasiswa("Muhammad Alif Rasyid Ramdani", "1302210098"),
            new Mahasiswa("Aryasatya Pratama", "1302210082"),
            new Mahasiswa("Zakya hakeem", "1302210135"),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswas.Add(value);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswas[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}
