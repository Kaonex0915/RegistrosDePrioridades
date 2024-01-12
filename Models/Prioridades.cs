using System.ComponentModel.DataAnnotations;

public class Prioridades {
    [Key]
    public int PrioridadId{ get ; set;}
    //[Required] Indica que el campo es requerido.
    //[Required(ErrorMessage = "Tas pendejo pa?")]
    public string Descripcion{ get; set; } =string.Empty;
    //[Range] determinar el rango de valores que deben ser ingresados
    //[Range(1, 31 )]
    public int DiasCompromiso {get; set;}  

}