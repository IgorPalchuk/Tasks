using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._1
{
    public class StickGame
    {
        private readonly Random randomizer;
        public Player Turn {  get; private set; }
        public GameStatus GameStatus { get; private set;}

        public int InitialSticksNumber { get; }
        public int RemainingSticksNumber { get; private set;}

        public event Action<int> MachinePlayed;
        public event EventHandler<int> HumanTurnToMakeMove;
        public event Action<Player> EndOfGame;
        public StickGame(int numberOfSticks, Player whoMakesFirstMove)
        {
            InitialSticksNumber = numberOfSticks;
            Turn = whoMakesFirstMove;
            randomizer = new Random();
            GameStatus = GameStatus.NotStarted;
            RemainingSticksNumber = InitialSticksNumber;
        }
        public void HumanTakes(int sticks)
        {
            if(sticks < 1 || sticks > 3)
            {
                throw new ArgumentException("You cant take ");
            }

            if(sticks > RemainingSticksNumber)
            {
                throw new ArgumentException("You cant take more");
            }

            RemainingSticksNumber -= sticks;
        }
        public void Start()
        {
            if (GameStatus == GameStatus.GameIsOver)
            {
                RemainingSticksNumber = InitialSticksNumber;
            }

             GameStatus = GameStatus.InProgress;
            while(GameStatus == GameStatus.InProgress)
            {
                if(Turn == Player.Computer)
                {
                    CompMakesMove();
                }
                else
                {
                    HumanMakesMove();
                }

                FireEndOfGameIfRequired();

                Turn = Turn == Player.Computer ? Player.Human : Player.Computer;
            }
        }   

        private void FireEndOfGameIfRequired()
        {
            if(RemainingSticksNumber == 0)
            {
                GameStatus = GameStatus.GameIsOver;
                if(EndOfGame != null)
                {
                    EndOfGame(Turn == Player.Computer ? Player.Human : Player.Computer);
                }
            }
        }

        private void HumanMakesMove()
        {
            if (HumanTurnToMakeMove != null)
            {
                HumanTurnToMakeMove(this, RemainingSticksNumber);
            }
        }
        private void CompMakesMove()
        {
            int maxNumber = RemainingSticksNumber >=3 ? 3 : RemainingSticksNumber;  
            int sticks = randomizer.Next(1, maxNumber);

            TakeSticks(sticks);
            if(MachinePlayed != null)
            {
                MachinePlayed(sticks);
            }
        }

        private void TakeSticks(int sticks)
        {
            RemainingSticksNumber -= sticks;
        }
    }
}
