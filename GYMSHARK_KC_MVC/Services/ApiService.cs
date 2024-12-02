using System.Net.Http.Json;
using GYMSHARK_KC_MVC.Models;

public class ApiService
{
    private readonly HttpClient _httpClient = new HttpClient();

    // Obtener productos desde la API
    public async Task<List<KCProducto>> GetProductosAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<KCProducto>>("https://localhost:5001/api/KCProductos");
    }
}
