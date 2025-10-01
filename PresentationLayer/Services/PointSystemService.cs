using CoreLayer.Enums;
using DataAccessLayer.Models;
using DataAccessLayer.Repositories.IRepositories;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading.Tasks;

namespace PresentationLayer.Services
{
    public class PointSystemService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PointSystemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PointSystem> GetPointsForAction(PointActionType actionType)
        {
            var point = await _unitOfWork.PointSystemRepository.GetOneAsync(x => x.ActionType == actionType);
            if(point == null)
            {
                point = new PointSystem
                {
                    ActionType = actionType,
                    FixedPoints = 0,
                    PointsPerUnit = 0,
                    UnitValue = 0
                };
            }

            return point;

        }

        public async Task<int> CalculatePoints(PointActionType actionType, int quantity = 0)
        {
            var point = await GetPointsForAction(actionType);
            
            int totalPoints = point.FixedPoints;
            if(point.UnitValue > 0 && quantity > 0)
            {
                int units = quantity / point.UnitValue;
                totalPoints += units * point.PointsPerUnit;
            }
            
            
            return totalPoints;
        }
    }
}
