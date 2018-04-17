using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BocceBall.Models;
using System.Data.Entity;
using BocceBall.Context;

namespace BocceBall
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataContext();

            //var newTeam1 = new Team
            //{
            //    Mascot = "Hawk",
            //    Color = "Red",
            //};


            //var newTeam2 = new Team
            //{
            //    Mascot = "Whale",
            //    Color = "Blue"
            //};


            //var newPlayer1 = new Player
            //{
            //    FullName = "Bob Ross",
            //    Nickname = "The Happy Painter",
            //    Number = 01,
            //    ThrowingArm = "Righty"
            //};

            //var newPlayer2 = new Player
            //{
            //    FullName = "Sal Dali",
            //    Nickname = "Mr. Mustachio",
            //    Number = 07,
            //    ThrowingArm = "Ambidextrous"
            //};

            //var newPlayer3 = new Player
            //{
            //    FullName = "Skrillex",
            //    Nickname = "Funny Hair Guy",
            //    Number = 03,
            //    ThrowingArm = "Robot"
            //};

            //var newPlayer4 = new Player
            //{
            //    FullName = "DeadMau5",
            //    Nickname = "No Face",
            //    Number = 05,
            //    ThrowingArm = "Rat Arm"
            //};

            //db.Teams.Add(newTeam1);
            //db.Teams.Add(newTeam2);
            //db.Players.Add(newPlayer1);
            //db.Players.Add(newPlayer2);
            //db.Players.Add(newPlayer3);
            //db.Players.Add(newPlayer4);

            //db.SaveChanges();

            //Player bobby = db.Players.Where(w => w.FullName == "Bob Ross").First();
            //Player sal = db.Players.Where(w => w.FullName == "Sal Dali").First();
            //Team blueTeam = db.Teams.Where(w => w.Color == "Blue").First();

            //blueTeam.Player.Add(bobby);
            //blueTeam.Player.Add(sal);

            //Player dub = db.Players.Where(w => w.FullName == "Skrillex").First();
            //Player rat = db.Players.Where(w => w.FullName == "DeadMau5").First();
            //Team redTeam = db.Teams.Where(w => w.Color == "Red").First();

            //redTeam.Player.Add(dub);
            //redTeam.Player.Add(rat);

            //db.SaveChanges();

            //var newGame1 = new Games
            //{
            //    HomeTeamID = 1,
            //    AwayTeamID = 2,

            //    HomeTeamScore = 4,
            //    AwayTeamScore = 5,

            //    Date = new DateTime(2018, 01, 01),
            //    Notes = "A battle for the ages!"
            //};

            //var newGame2 = new Games
            //{
            //    HomeTeamID = 2,
            //    AwayTeamID = 1,

            //    HomeTeamScore = 1,
            //    AwayTeamScore = 2,

            //    Date = new DateTime(2018, 10, 02),
            //    Notes = "Aaron's birthday bash"
            //};

            //db.Games.Add(newGame1);
            //db.Games.Add(newGame2);

            //db.SaveChanges();



            ////~:HOMEWORK REQUIREMENTS:~///////////////////////////////////
            //All the teams, with their win / loss record
            var redTeamWins = 0;
            var redTeamLosses = 0;
            var blueTeamWins = 0;
            var blueTeamLosses = 0;

            var oldGames = db.Games.Where(w => w.Date < DateTime.Today);

            foreach (var game in oldGames)
            {
                //determine winner
                //associate win with team
                //add to team record
            }
            //db.Games.Where(w => w.HomeTeamScore)


            //:All the Players and what team they are on://
            ////THE WRONG WAY////////////////////
            //var redPlayers = db.Players.Where(w => w.TeamID == 1);
            //var bluePlayers = db.Players.Where(w => w.TeamID == 2);
            //foreach (var player in redPlayers)
            //{
            //    Console.WriteLine($"{player.Nickname}");
            //}

            var teamPlayers = db.Players.Include(i => i.Team);

            foreach (var player in teamPlayers)
            {
                Console.WriteLine($"{player.FullName} is on the {player.Team.Color} team");
            }


            //All the Upcoming games(games who Date Happened is in the future)
            var comingSoon = db.Games.Where(w => w.Date > DateTime.Today);
            foreach (var game in comingSoon)
            {
                Console.WriteLine($"{game.Date}: {game.HomeTeam} vs {game.AwayTeam}");
            }


            //Past games
            var oldNews = db.Games.Where(w => w.Date < DateTime.Today);
            foreach (var game in oldNews)
            {
                Console.WriteLine($"{game.Date}: {game.HomeTeam} vs {game.AwayTeam} ");
            }
            Console.ReadLine();
        }
    }
}
