using System;
using Microsoft.AspNetCore.Mvc;

namespace modul10tp_1302204106.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Faras Irzan", Nim = "1302204106" },
            new Mahasiswa { Nama = "Stephen Curry", Nim = "1302000002" }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> Get()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();
            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}

