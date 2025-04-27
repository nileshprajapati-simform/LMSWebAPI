using LMSWebAPI.Entities;

namespace LMSWebAPI.Services;

public interface ICourseService
{
    Task<IEnumerable<Course>> GetAllAsync();
    Task<Course> GetByIdAsync(int id);
    Task AddAsync(Course course);
    Task UpdateAsync(Course course);
    Task DeleteAsync(int id);
}