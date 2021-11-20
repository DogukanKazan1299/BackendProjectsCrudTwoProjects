using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GameManager : IGameService
    {
        private IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public IResult Add(Game game)
        {
            _gameDal.Add(game);
            return new SuccessResult(Messages.GameAdded);
        }

        public IResult Delete(Game game)
        {
            _gameDal.Delete(game);
            return new SuccessResult(Messages.GameDeleted);
        }

        public IDataResult<Game> GetById(int id)
        {
            return new SuccessDataResult<Game>(_gameDal.Get(x => x.Id == id));
        }

        public IDataResult<List<Game>> GetList()
        {
            return new SuccessDataResult<List<Game>>(_gameDal.GetList().ToList());
        }

        public IDataResult<List<Game>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Game>>(_gameDal.GetList(x => x.CategoryId == categoryId).ToList());
        }

        public IResult Update(Game game)
        {
            _gameDal.Update(game);
            return new SuccessResult(Messages.GameUpdated);
        }
    }
}
