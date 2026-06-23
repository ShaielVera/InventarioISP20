using Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DotNetEnv;

namespace Desktop.Services
{
    internal class ClientesService
    {

        HttpClient httpClient;
        string urlApi = "https://tdiafxytfpcirxwdgawh.supabase.co/rest/v1/clientes";

        public ClientesService()
        {
            DotNetEnv.Env.Load("../../../.env");
            var apikey = Environment.GetEnvironmentVariable("apikey_supabase");
            //Instanciamos el cliente HTTP y configuramos la URL base y los configuramos 
            httpClient = new HttpClient();
            httpClient.BaseAddress= new Uri(urlApi);
            //Agregamos el apikey y el header para aceptar json
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("apikey", apikey);
        }


        public async Task<List<Cliente>?> GetAllAsync()
        {
            try
            {
                var response = await httpClient.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var clientes = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(json);
                    return clientes;
                }
                else
                {
                    MessageBox.Show("Error al obtener los clientes: " + response.ReasonPhrase);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los clientes: " + ex.Message);
                return null;

            }

        }

        public async Task<List<Cliente>?> GetAllWithFilterAsync(string filter)
        {
            try
            {
                string flitroSupabase = $"?or=(first_name.ilike.*{filter}*, last_name.ilike.*{filter}*,dni.ilike.*{filter}*,address.ilike.*{filter}*)";
                var response = await httpClient.GetAsync(flitroSupabase);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var clientes = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(json);
                    return clientes;
                }
                else
                {
                    MessageBox.Show("Error al obtener los clientes: " + response.ReasonPhrase);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los clientes: " + ex.Message);
                return null;
            }
        }

        public async Task<bool> AddClienteAsync(Cliente cliente)
        {
            try
            { 
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNameCaseInsensitive = true,
            };
            var json = JsonSerializer.Serialize(cliente, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("", content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al crear el cliente: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cliente desde la Api: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> UpdateClienteAsync(Cliente cliente)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    PropertyNameCaseInsensitive = true,
                };
                var json = JsonSerializer.Serialize(cliente, options);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string urlSelectedId = $"?id=eq.{cliente.id}";
                var response = await httpClient.PutAsync(urlSelectedId, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente desde la Api: " + ex.Message);
                return false;
            }
        }
}
}
