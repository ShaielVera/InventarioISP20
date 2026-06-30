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
    internal class ClientesSupabaseService
    {
        private Supabase.Client supabase;
        public ClientesSupabaseService()
        {
            _= SettingSupabaseClient();
        }

        private async Task SettingSupabaseClient()
        {
            Env.Load("../../../");
            var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
            var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();
        }

        public async Task<List<Cliente>?> GetAllAsync()
        {
            try
            {
                var result = await supabase.From<Cliente>().Get();
                var clientes = result.Models;
                return clientes;
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
                var result = await supabase.From<Cliente>().Get();
                var clientes = result.Models;
                return clientes.Where(
                      c => c.first_name.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                      c.last_name.Contains(filter, StringComparison.OrdinalIgnoreCase) ||
                      c.dni.Contains(filter, StringComparison.OrdinalIgnoreCase))
                .ToList();
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
                var response = await supabase.From<Cliente>().Insert(cliente);
                return response.ResponseMessage!.IsSuccessStatusCode;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el cliente desde Supabase: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> UpdateClienteAsync(Cliente cliente)
        {
            try
            {
                var response = await supabase.From<Cliente>().Upsert(cliente);
                return response.ResponseMessage!.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente desde Supabase: " + ex.Message);
                return false;
            }
        }

        public async Task<bool> DeleteClienteAsync(int id)
        {
            try
            {
                await supabase.From<Cliente>()
                    .Where(c => c.id == id)
                    .Delete();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente desde Supabase: " + ex.Message);
                return false;
            }
        }
    }
}
