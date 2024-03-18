using Elias.Application.Interfaces;
using Elias.Common;
using Elias.Data.Context;
using Elias.Data.DTOs.PortfolioDto;
using Elias.Data.Entities;
using Elias.Data.Entities.Portfolio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Elias.Application.Services
{
    public class PortfolioService : IPortfolioService
    {
        #region Inject Database
        private readonly DatabaseContext _db;

        public PortfolioService(DatabaseContext db)
        {
            _db = db;
        }

        #endregion



        public async Task CreatePortfolio(Portfolio portfolio, IFormFile Image, List<IFormFile> images)
        {
            _db.Add(portfolio);
            await SetPortfolioPic(portfolio, Image);
            SetMultiImageForPortfolio(images, portfolio);
            await _db.SaveChangesAsync();
        }

        public async Task DeletePortfolio(Portfolio portfolio)
        {
            _db.Remove(portfolio);
            await _db.SaveChangesAsync();
        }

        public  Portfolio FindPortfolioById(int id)
        {
            return _db.Portfolios.Find(id);
        }

        public List<GetPortfolioForIndex> GetPortfolioList()
        {
            return _db.Portfolios
                .Select(p => new GetPortfolioForIndex()
                {
                    CustomerName = p.CustomerName,
                    Id = p.Id,
                    PortfolioDate = p.PortfolioDate,
                    PortfolioName = p.PortfolioName,
                    PortfolioFamily = p.PortfolioFamily,
                }).AsNoTracking()
                .ToList();
        }

        public bool IsPortfolioExist()
        {
            return _db.Portfolios.Any();
        }

        public async Task UpdatePortfolio(Portfolio portfolio, IFormFile Image)
        {
            _db.Update(portfolio);
            await SetPortfolioPic(portfolio, Image);
            await _db.SaveChangesAsync();
        }

        private async Task SetPortfolioPic(Portfolio portfolio, IFormFile Image)
        {
            if (Image is not null)
            {
                if (portfolio.MainPicure is null)
                {
                    portfolio.MainPicure = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    string Imagepath = Path.Combine(Directory.GetCurrentDirectory().Remove(30), "Elias.Web/wwwroot/PortfolioImage/", portfolio.MainPicure);
                    using (var stream = new FileStream(Imagepath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
                else
                {
                    string DeleteDemoPath = "";
                    DeleteDemoPath = Path.Combine(Directory.GetCurrentDirectory().Remove(30), "Elias.Web/wwwroot/PortfolioImage/", portfolio.MainPicure);
                    if (File.Exists(DeleteDemoPath))
                    {
                        File.Delete(DeleteDemoPath);
                    }

                    portfolio.MainPicure = GenerateCode.GenerateUniqueCode() + Path.GetExtension(Image.FileName);
                    DeleteDemoPath = Path.Combine(Directory.GetCurrentDirectory().Remove(30), "Elias.Web/wwwroot/PortfolioImage/", portfolio.MainPicure);
                    using (var stream = new FileStream(DeleteDemoPath, FileMode.CreateNew))
                    {

                        Image.CopyTo(stream);
                    }
                }
            }
        }

        public  void SetMultiImageForPortfolio(List<IFormFile> images, Portfolio portfolio)
        {
            int portfolioId = GetPortfolioForPortfolioId(portfolio);
            if (images.Count > 0)
            {
                foreach (var item in images)
                {
                    
                        string uploads = Path.Combine(Directory.GetCurrentDirectory().Remove(30), "Elias.Web/wwwroot/PortfolioMoreImages/");
                    
                        var extension = Path.GetExtension(item.FileName);
                        var dynamicFileName = GenerateCode.GenerateUniqueCode() + extension;
                        using (var filesStream = new FileStream(Path.Combine(uploads, dynamicFileName), FileMode.Create))
                        {
                            item.CopyTo(filesStream);
                        }

                    _db.PortfolioImages.Add(new PortfolioImages { PortfolioId = portfolioId, PortfolioImageName = dynamicFileName });
                    _db.SaveChanges();  
                }
                _db.SaveChanges();
            }
        }


        public int GetPortfolioForPortfolioId(Portfolio portfolio)
        {
            _db.Add(portfolio);
             _db.SaveChanges();
            return portfolio.Id;
        }

        public List< GetPortfolioForShowByGroupIdDto> GetPortfolio()
        {
            return _db.Portfolios
                .Include(p=>p.PortfolioGroup)
                .Select(p => new GetPortfolioForShowByGroupIdDto()
                {
                    Id = p.Id,  
                    GroupName = p.PortfolioGroup.GroupName,
                    MainPicure = p.MainPicure,
                }).AsNoTracking().ToList();  
        }

        public Portfolio GetEntirePortfoWithImagesAndGroupsById(int id)
        {
            return _db.Portfolios
               .Include(p => p.PortfolioGroup)
               .Include(p => p.PortfolioImages)
               .FirstOrDefault(p => p.Id == id);
        }
    }
}
