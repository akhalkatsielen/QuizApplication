using QuizApp.Context;
using QuizApp.Models;

namespace QuizApp.Repositories
{
    public class PlayersRepository : IPlayersRepository
    {
        private readonly QuizAppDbContext _context;
        public PlayersRepository(QuizAppDbContext context)
        {
            _context = context;
        }
        public List<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }

        public Player AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return player;
        }

        public Player DeletePlayer(int id)
        {
            var player = _context.Players.FirstOrDefault(x => x.Id == id);
            _context.Players.Remove(player);
            _context.SaveChanges();
            return player;
        }
    }
}