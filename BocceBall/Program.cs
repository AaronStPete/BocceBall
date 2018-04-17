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


            ////TODO://///////////////////////////////////
            //All the teams, with their win / loss record
            //All the Players and what team they are on
            //All the Upcoming games(games who Date Happened is in the future)
            //Past games
        }
    }
}
