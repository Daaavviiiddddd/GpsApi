namespace GpsApi.Models
{
    public record UbicacionDto(
        int? Id,
        string Telefono,
        string IMEI,
        decimal? Latitud,
        decimal? Longitud,
        decimal? Velocidad,
        DateTime? FechaHora,
        string MensajeCompleto,
        DateTime FechaRegistro
    );
}
