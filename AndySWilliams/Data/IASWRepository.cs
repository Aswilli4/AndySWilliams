using AndySWilliams.Data.Entities;
using System.Collections.Generic;

namespace AndySWilliams.Data
{
    public interface IASWRepository
    {
        IEnumerable<Family> GetAllFamilyMembers();
    }
}