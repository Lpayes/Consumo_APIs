using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ConsumodeAPIsLester
{
    public partial class Form1 : Form
    {
        private readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client.DefaultRequestHeaders.Add("x-api-key", "vivo_opKLpGfy0UICy5n5Q8kom8penG92l3 rsSrdN4DC9DIQdF7uA2yGDEY2ACmUG uCTR");
        }

        private async void btnBuscarPokemon_Click(object sender, EventArgs e)
        {
            string nombrePokemon = txtPokemon.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(nombrePokemon))
            {
                MessageBox.Show("Por favor, ingrese el nombre de un Pokémon.");
                return;
            }

            // URL para buscar el Pokémon
            string url = $"https://pokeapi.co/api/v2/pokemon/{nombrePokemon}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(jsonData);

                    // Obtener los datos del Pokémon
                    string pokemonName = data["name"].ToString();
                    double height = (double)data["height"] / 10; // Convertir a metros
                    double weight = (double)data["weight"] / 10; // Convertir a kg
                    string imageUrl = data["sprites"]["front_default"]?.ToString() ?? "";

                    lblNombrePokemon.Text = $"Nombre: {pokemonName}";
                    lblAlturaPokemon.Text = $"Altura: {height} m";
                    lblPesoPokemon.Text = $"Peso: {weight} kg";

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        picPokemon.Load(imageUrl);
                    }
                    else
                    {
                        picPokemon.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Pokémon no encontrado.");
                    LimpiarLabelsPokemon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                LimpiarLabelsPokemon();
            }
        }

        private void LimpiarLabelsPokemon()
        {
            lblNombrePokemon.Text = "Nombre: ";
            lblAlturaPokemon.Text = "Altura: ";
            lblPesoPokemon.Text = "Peso: ";
            picPokemon.Image = null;
            txtPokemon.Clear();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string pokemonName = lblNombrePokemon.Text.Replace("Nombre: ", "").Trim();

            if (string.IsNullOrEmpty(pokemonName) || lblAlturaPokemon.Text == "Altura: " || lblPesoPokemon.Text == "Peso: ")
            {
                MessageBox.Show("No se ha buscado un Pokémon aún.");
                return;
            }

            // Crear un objeto con los datos del Pokémon
            var pokemonData = new
            {
                Nombre = pokemonName,
                Altura = lblAlturaPokemon.Text.Replace("Altura: ", ""),
                Peso = lblPesoPokemon.Text.Replace("Peso: ", ""),
                Imagen = picPokemon.ImageLocation
            };

            // Crear carpeta si no existe
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PokemonsGuardados");
            Directory.CreateDirectory(folderPath);

            // Ruta del archivo JSON
            string filePath = Path.Combine(folderPath, "PokemonsGuardados.json");

            List<object> pokemonsList = new List<object>();

            // Verficar si el archivo ya existe
            if (File.Exists(filePath))
            {
                string existingJson = await File.ReadAllTextAsync(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    // Deserializar el JSON en la lista
                    pokemonsList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(existingJson);
                }
            }

            // Agregar el nuevo Pokémon a la lista
            pokemonsList.Add(pokemonData);

            // Guardar la lista completa en el archivo JSON
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(pokemonsList, Newtonsoft.Json.Formatting.Indented);
            await File.WriteAllTextAsync(filePath, json);

            MessageBox.Show($"Datos guardados en {filePath}");
        }

        private void btnLimpiarPokemon_Click(object sender, EventArgs e)
        {
            LimpiarLabelsPokemon();
        }

        private async void btnBuscarGato_Click(object sender, EventArgs e)
        {
            string nombreRaza = txtRaza.Text.ToLower().Trim();

            if (string.IsNullOrWhiteSpace(nombreRaza))
            {
                MessageBox.Show("Por favor, ingrese el nombre de una raza.");
                return;
            }

            string url = $"https://api.thecatapi.com/v1/breeds/search?q={nombreRaza}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    JArray data = JArray.Parse(jsonData);

                    if (data.Count > 0)
                    {
                        string breedId = data[0]["id"].ToString();
                        string breedName = data[0]["name"].ToString();
                        string origin = data[0]["origin"]?.ToString() ?? "Desconocido";
                        string temperament = data[0]["temperament"]?.ToString() ?? "Desconocido";

                        lblRaza.Text = $"Raza: {breedName}";
                        lblOrigenGato.Text = $"Origen: {origin}";
                        lblTemperamento.Text = $"Temperamento: {temperament}";

                        await BuscarImagenesPorRaza(breedId);
                    }
                    else
                    {
                        MessageBox.Show("Raza no encontrada.");
                        LimpiarLabelsGato();
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener los datos de razas.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                LimpiarLabelsGato();
            }
        }
        private async Task BuscarImagenesPorRaza(string breedId)
        {
            string urlImagen = $"https://api.thecatapi.com/v1/images/search?breed_ids={breedId}&limit=1";

            try
            {
                HttpResponseMessage response = await client.GetAsync(urlImagen);

                if (response.IsSuccessStatusCode)
                {
                    string jsonData = await response.Content.ReadAsStringAsync();
                    JArray data = JArray.Parse(jsonData);

                    if (data.Count > 0)
                    {
                        string imageUrl = data[0]["url"]?.ToString();
                        picGato.Load(imageUrl ?? string.Empty);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron imágenes para esta raza.");
                        picGato.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener las imágenes.");
                    picGato.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar imágenes: {ex.Message}");
            }
        }

        // Funcion para limpiar los controladores del gato
        private void LimpiarLabelsGato()
        {
            lblRaza.Text = "Raza: ";
            lblOrigenGato.Text = "Origen: ";
            lblTemperamento.Text = "Temperamento: ";
            picGato.Image = null;
            txtRaza.Clear();
        }

        private async void btnGuardarGato_Click(object sender, EventArgs e)
        {
            string breedName = lblRaza.Text.Replace("Raza: ", "").Trim();

            if (string.IsNullOrEmpty(breedName) || lblOrigenGato.Text == "Origen: " || lblTemperamento.Text == "Temperamento: ")
            {
                MessageBox.Show("No se ha buscado una raza de gato aún.");
                return;
            }

            // Se cren objeto con los  datos del gato
            var gatoData = new
            {
                Raza = breedName,
                Origen = lblOrigenGato.Text.Replace("Origen: ", ""),
                Temperamento = lblTemperamento.Text.Replace("Temperamento: ", ""),
                Imagen = picGato.ImageLocation
            };

            // Crear carpeta si no existe
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GatosGuardados");
            Directory.CreateDirectory(folderPath);

            // Ruta del archivo JSON
            string filePath = Path.Combine(folderPath, "GatosGuardados.json");

            // Inicializar la lista
            List<object> gatosList = new List<object>();

            // Verificar si el archivo ya existe
            if (File.Exists(filePath))
            {
                string existingJson = await File.ReadAllTextAsync(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    // Deserializar el JSON en la lista
                    gatosList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(existingJson);
                }
            }

            // Agregar el nuevo gato a la lista
            gatosList.Add(gatoData);

            // Guardar la lista completa en el archivo JSON
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(gatosList, Newtonsoft.Json.Formatting.Indented);
            await File.WriteAllTextAsync(filePath, json);

            MessageBox.Show($"Datos del gato guardados en {filePath}");
        }

        private void btnLimpiarIGato_Click(object sender, EventArgs e)
        {
            LimpiarLabelsGato();
        }

    }
}
