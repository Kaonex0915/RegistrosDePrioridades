using System.ComponentModel.DataAnnotations;


public class Clientes {
    [Key]
    public int ClienteId{ get ; set;}
    
    [Required(ErrorMessage = "El campo es requerido")]
    public string Nombre{ get; set; } =string.Empty;
   
    [Required(ErrorMessage = "El telefono es requerido")]
    [StringLength(maximumLength:16, MinimumLength = 10)]
    public string Telefono {get; set;}  

    [Required(ErrorMessage = "El celular es requerido")]
    [StringLength(maximumLength:16, MinimumLength = 10)]
    public string Celular {get; set;}  

    [Required(ErrorMessage = "El RNC es requerido")]
    [StringLength(maximumLength:20, MinimumLength = 14)]
    public string RNC {get; set;}  

    [Required(ErrorMessage = "El correo electonico es requerido")]
    [StringLength(maximumLength:30, MinimumLength = 10)]
    public string Email {get; set;}  

    [Required(ErrorMessage = "La direccion es requerida")]
    [StringLength(maximumLength:40, MinimumLength = 5)]
    public string Direccion {get; set;}  
    

}
    