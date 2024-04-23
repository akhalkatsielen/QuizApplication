using QuizApp.Models;
using QuizApp.Repositories;

namespace QuizApp.Services
{
    public class GameService : IGameService
    {
        private readonly IPlayersRepository _playersRepository;
        private readonly IQuestionsRepository _questionRepository;
        public GameService(IPlayersRepository playersRepository, IQuestionsRepository questionRepository)
        {
            _playersRepository = playersRepository;
            _questionRepository = questionRepository;
        }

        public Player SubmitQuiz(SubmitModel submitModel)
        {
            //Logic
            throw new NotImplementedException();
        }
    }
}
