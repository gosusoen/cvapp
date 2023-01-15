using CvApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CvApp.Repositories
{
    public class DataRepository : IDataRepository
    {
        CvAppContext _context;

        public DataRepository(CvAppContext context)
        {
            _context = context;
        }

        public async Task<List<CvModel>> GetCvModelList()
        {
            List<CvModel> result = new List<CvModel>();
            try
            {
                result = await _context.CvModels.ToListAsync();
            }
            catch (Exception e)
            {
                //
            }
            return result;
        }

        public async Task<CvModel> GetCvModel(int id)
        {
            CvModel result = new CvModel();
            try
            {
                result = await _context.CvModels.FirstOrDefaultAsync(a=>a.Id==id);
            }
            catch (Exception e)
            {
                //
            }
            return result;
        }

        public async Task<CvModel> AddCv(CvModel model)
        {
            try
            {
                _context.Entry(await _context.CvModels.FirstOrDefaultAsync(x => x.Id == model.Id)).CurrentValues.SetValues(model);
            }
            catch (Exception e)
            {
                //
            }
        }

        public async Task<CvModel> EditCv(CvModel model)
        {
            try
            {
                _context.Entry(await _context.CvModels.FirstOrDefaultAsync(x => x.Id == model.Id)).CurrentValues.SetValues(model);
            }
            catch (Exception e)
            {
                //
            }
        }

    }
}
