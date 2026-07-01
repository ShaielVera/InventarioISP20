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
    internal class VehiculosService
    {

        HttpClient httpClient;
        string urlApi = "https://tdiafxytfpcirxwdgawh.supabase.co/rest/v1/vehiculos";
        JsonSerializerOptions options;

        public VehiculosService()
        {
            httpClient = SettingHttpClient();
            options = SettingJsonSerializer();
        }

        private HttpClient SettingHttpClient()
        {
            Env.Load("../../../");
            var apikey = Environment.GetEnvironmentVariable("SUPABASE_KEY");
            //instanciamos el httpClient y lo configuramos para poder utilizarlo en cada uno de los métodos
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlApi);
            //agregamos apikey de la url
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("apikey", apikey);
            return httpClient;
        }

        private JsonSerializerOptions SettingJsonSerializer()
        {
            return new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNameCaseInsensitive = true,
            };
        }

        public async Task<List<Vehiculos>?> GetAllAsync()
        {
            try
            {
                var response = await httpClient.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var vehiculos = JsonSerializer.Deserialize<List<Vehiculos>>(json);
                    return vehiculos;
                }
                else
                {
                    MessageBox.Show("Error al obtener los vehículos: " + response.ReasonPhrase);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los vehículos: " + ex.Message);
                return null;

            }

        }

        public async Task<List<Vehiculos>?> GetAllWithFilterAsync(string filter)
        {
            try
            {
                string flitroSupabase = $"?or=(patent.ilike.*{filter}*, vehicle.ilike.*{filter}*, brand.ilike.*{filter}*, model.ilike.*{filter}*, year.ilike.*{filter}*)";
                var response = await httpClient.GetAsync(flitroSupabase);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var vehiculos = System.Text.Json.JsonSerializer.Deserialize<List<Vehiculos>>(json);
                    return vehiculos;
                }
                else
                {
                    MessageBox.Show("Error al obtener los vehículos: " + response.ReasonPhrase);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los vehículos: " + ex.Message);
                return null;
            }
        }

        public async Task<bool> AddVehicleAsync(Vehiculos vehiculo)
        {
            try
            {
            var json = JsonSerializer.Serialize(vehiculo, options);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("", content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var detalle = await response.Content.ReadAsStringAsync();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el vehículo desde la Api: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> UpdateVehicleAsync(Vehiculos vehiculo)
        {
            try
            {
                var options = new JsonSerializerOptions();
                var json = JsonSerializer.Serialize(vehiculo, options);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                string urlSelectedId = $"?id=eq.{vehiculo.id}";
                var response = await httpClient.PutAsync(urlSelectedId, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar el vehículo: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el vehículo desde la Api: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteVehicleAsync(int id)
        {
            try
            {
                string urlSelectedId = $"?id=eq.{id}";
                var response = await httpClient.DeleteAsync(urlSelectedId);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al eliminar el vehículo: " + response.ReasonPhrase);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el vehículo desde la Api: " + ex.Message);
                return false;
            }
        }
    }
}
