using System.ComponentModel.DataAnnotations;


public class Prioridades {
    [Key]
    public int PrioridadId{ get ; set;}
    
    [Required(ErrorMessage = "El campo es requerido")]
    public string Descripcion{ get; set; } =string.Empty;
   
    [Range(1, 31 , ErrorMessage ="Los dias deben ser entre 1 y 31" ) ]
    public int DiasCompromiso {get; set;}  

}