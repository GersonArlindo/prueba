namespace BankConsole;

public class User{
    //Propiedades del la clase
    public int ID {get; set;}
    public string Name { get; set; } 
    public string Email { get; set; }
    public decimal Balance { get; set; }
    public DateTime RegisterDate { get; set; }

    //Metodo de la clase
    public string ShowData(){
        return $"Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha de Registro: {this.RegisterDate}.";
    }
}