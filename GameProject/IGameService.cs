using System;
namespace GameProject
{
    interface IGameService 
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
