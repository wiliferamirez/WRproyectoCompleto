namespace WRproyectoCompleto.Models;
using System.ComponentModel.DataAnnotations;


public class WREstudiante
{
    [Key]
    [Display(Name = "ID")]
    public int WRestudianteId { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [Display(Name = "Cedula")]
    public string WRcedulaEstudiante { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [Display(Name = "Nombre")]
    public string WRnombreEstudiante { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [Display(Name = "Apellido")]
    public string WRapellidoEstudiante { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [Display(Name = "Representante")]
    public string WRnombreRepresentanteEstudiante { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [Display(Name = "Edad")]
    public int WRedad{ get; set; }
}