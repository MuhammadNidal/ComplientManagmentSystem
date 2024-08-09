using ComplientManagmentSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplientManagmentSystem.Domain.Interfaces
{
    public interface IComplaintRepository
    {
        Task<Complaint> GetComplaintByIdAsync(int id);
        Task<IEnumerable<Complaint>> GetAllComplaintsAsync();
        Task AddComplaintAsync(Complaint complaint);
        Task UpdateComplaintAsync(Complaint complaint);
        Task DeleteComplaintAsync(int id);
    }
}
