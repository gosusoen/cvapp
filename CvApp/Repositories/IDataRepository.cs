using CvApp.Models;

namespace CvApp.Repositories
{
    public interface IDataRepository
    {
        Task<List<CvModel>> GetCvModelList();
        Task<CvModel> GetCvModel(int id);
        Task AddCv(CvModel model);
        Task EditCv(CvModel model);
    }
}
