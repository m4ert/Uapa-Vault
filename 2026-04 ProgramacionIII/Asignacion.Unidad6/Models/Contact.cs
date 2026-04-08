namespace Asignacion.Unidad6.Models;

/// <summary>
/// Representa la entidad de contacto en la base de datos.
/// </summary>
public class Contact
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
}
