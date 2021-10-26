using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http; //get Post Get Delete
using System.Net.Http.Headers;
using Newtonsoft.Json;
using PokemonWebApp.Models;

namespace PokemonWebApp.Pages.Pokemons
{
    public class DeleteModel : PageModel
    {
        [BindProperty] 
        public Pokemon Pokemon { get; set; }

        string baseUrl = "https://localhost:5001/";
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                //fazendo metodo GET
                HttpResponseMessage response = await client.GetAsync("api/Pokemons/" + id);
               
                //Booleando que informa se foi certo ou errado 
                if(response.IsSuccessStatusCode)
                {
                    //Capiturar string do json
                    string result = response.Content.ReadAsStringAsync().Result;
                    //Transformar a string em json em objeto 
                    Pokemon = JsonConvert.DeserializeObject<Pokemon>(result);
                }
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            if(Pokemon.ID != id)
            {
                return BadRequest();
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("applicarion/json"));
                HttpResponseMessage  response = await client.DeleteAsync("api/Pokemons/" + Pokemon.ID);
                if (response.IsSuccessStatusCode)
                {
                    //Seucesso voltar para Pokedex //localhost:port/Pokemons
                    return RedirectToPage("./Index");
                }
                else
                {
                    return Page();
                }
            } 
        }
        
    }
}
