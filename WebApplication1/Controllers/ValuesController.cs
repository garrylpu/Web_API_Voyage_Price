using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<Voyage> list1 { get; set; } = new List<Voyage>();
        public ValuesController()
        {
            if (list1.Count() == 0)
            {
                list1.Add(new Voyage
                {
                    Price = 111,
                    name = "Voyage1"
                }
                 );
                list1.Add(new Voyage
                {
                    Price = 222,
                    name = "Voyage2"
                }
                );
                list1.Add(new Voyage
                {
                    Price = 333,
                    name = "Voyage3"
                }
             );
                list1.Add(new Voyage
                {
                    Price = 444,
                    name = "Voyage4"
                }
                );
                list1.Add(new Voyage
                {
                    Price = 555,
                    name = "Voyage5"
                }
                );
                list1.Add(new Voyage
                {
                    Price = 666,
                    name = "Voyage6"
                }
              );
                list1.Add(new Voyage
                {
                    Price = 777,
                    name = "Voyage7"
                }
                          );
                list1.Add(new Voyage
                {
                    Price = 888,
                    name = "Voyage8"
                }
                          );
                list1.Add(new Voyage
                {
                    Price = 999,
                    name = "Voyage9"
                }
                          );
                list1.Add(new Voyage
                {
                    Price = 1010,
                    name = "Voyage10"
                }
                          );
                list1.Add(new Voyage
                {
                    Price = 1111,
                    name = "Voyage11"
                }
                          );
                list1.Add(new Voyage
                {
                    Price = 1212,
                    name = "Voyage12"
                }
                          );
            }
        }
        public class Voyage
        {
            public string name;
            public int Price;
        }  
        public IEnumerable<Voyage> GetAverage()
        {
            

            return list1;

        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Voyage> Get()
        {
            return GetAverage().Take(10);
        }

        
        // GET api/values/5
        [HttpGet("{Price}")]
        public ActionResult<string> Get(int Price)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<Voyage> Post([FromBody] Voyage value)
        {

            var item = list1.Where(y => y.name == value.name).FirstOrDefault();
            if (item == null)
            {
                list1.Add(new Voyage
                {
                    Price = value.Price,
                    name = value.name,
                }
                );
            }
            else
            {
                item.Price = value.Price;

            }
            return GetAverage();


        }

        // PUT api/values/5
        [HttpPut("{Price}")]
        public void Put(int Price, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{Price}")]
        public void Delete(int Price)
        {
        }
    }
}
