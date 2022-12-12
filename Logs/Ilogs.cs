using System.Threading.Tasks;

public interface ILogs :  IRepository< Logs ,int> {

    Task<bool> ExisteCedula(string nombre, string? idExcluir = null);

    Task<bool> ExisteNombre(string nombre, string? idExcluir = null);

}

public class Logs
{
    
}