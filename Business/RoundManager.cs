using Business.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RoundManager : IRoundManager
    {
        private readonly IRoundHandler _handler;

        public RoundManager(IRoundHandler _roundHandler)
        {
            this._handler = _roundHandler;
        }
        public void CreateRound(int userid)
        {

            Game g = _handler.GetGame(userid);
            {
                int roundNr = 0;
                try
                {
                    Round round = _handler.GetRound(g.GameID);
                    if (round != null)
                    {
                        roundNr = round.RoundID;
                        if (roundNr <= 3 && round.WinnerID > 0)
                        {
                            Round r1 = new Round()
                            {
                                GameID = g.GameID,
                                RoundID = roundNr + 1,
                                WPM1 = 0,
                                Accuracy1 = 100,
                                TotalScore1 = 100,
                                WPM2 = 0,
                                Accuracy2 = 100,
                                TotalScore2 = 100
                            };
                            _handler.CreateRound(r1);
                            return;
                        }
                    }
                }
                catch
                {

                }



                Round r = new Round()
                {
                    GameID = g.GameID,
                    RoundID = 1,
                    WPM1 = 0,
                    Accuracy1 = 100,
                    TotalScore1 = 100,
                    WPM2 = 0,
                    Accuracy2 = 100,
                    TotalScore2 = 100
                };
                _handler.CreateRound(r);
            }
        }
        public void UpdateWPM(int userID, int wpm)
        {
            try
            {
                Game g = _handler.GetGame(userID);
                if (g != null)
                {
                    if (g.User1ID == userID)
                    {
                        Round r = _handler.GetRound(g.GameID);
                        r.WPM1 = wpm;
                        _handler.UpdateRound(r);
                    }

                    else if (g.User2ID == userID)
                    {
                        Round r = _handler.GetRoundByGameID(g.GameID);
                        r.WPM2 = wpm;
                        _handler.UpdateRound(r);

                    }
                }
            }

            catch
            {

            }

        }
        public void UpdateAccuracy(int userID, int accuracy)
        {
            try
            {
                Game g = _handler.GetGame(userID);
                if (g != null)
                {
                    if (g.User1ID == userID)
                    {
                        Round r = _handler.GetRound(g.GameID);
                        r.Accuracy1 = accuracy;
                        _handler.UpdateRound(r);
                    }

                    else if (g.User2ID == userID)
                    {
                        Round r = _handler.GetRound(g.GameID);
                        r.Accuracy2 = accuracy;
                        _handler.UpdateRound(r);
                    }

                }
            }

            catch
            {

            }

        }


        public void UpdateTotalScore(int userID, int totalScore)
        {
            try
            {
                Game g = _handler.GetGame(userID);
                if (g != null)
                {
                    if (g.User1ID == userID)
                    {
                        Round r = _handler.GetRound(g.GameID);

                        r.TotalScore1 = totalScore;
                        _handler.UpdateRound(r);
                    }

                    else if (g.User2ID == userID)
                    {
                        Round r = _handler.GetRound(g.GameID);

                        r.TotalScore2 = totalScore;
                        _handler.UpdateRound(r);
                    }
                }
            }

            catch
            {

            }

        }
        public void FinishRound(int userID)
        {
            try
            {
                Game g = _handler.GetGame(userID);
                if (g != null)
                {
                    Round r = _handler.GetRoundByGameID(g.GameID);
                    if (r.TotalScore1 > r.TotalScore2)
                    {
                        r.WinnerID = g.User1ID;
                    }

                    else if (r.TotalScore2 > r.TotalScore1)
                    {
                        r.WinnerID = g.User2ID;
                    }

                    else
                    {
                        //draw 
                    }
                    _handler.UpdateRound(r);
                }
            }

            catch
            {

            }

        }
        public Round GetRound(int userID)
        {
            return _handler.GetRound(userID);
        }
        public Game GetGame(int userID)
        {
            return _handler.GetGame(userID);
        }
    }
}
