using Project;
using Project.Classes;

namespace Project.Interfaces
{
    public interface ICostumerRepository
    {
        List<Costumers> GetUsers();
        void AddUsers(int? id, string names, string surname, string SecondName, string Aboniment);
        void UpdateUser(int? Id, string names, string surname, string SecondName, string Aboniment);
        IEnumerable<Costumers> DeleteUser(int? id);
    }
}
