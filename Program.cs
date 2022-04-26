﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             *  Exercise 1: Design a Stopwatch
                Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
                provide two methods: Start and Stop. We call the start method first, and the stop method next.
                Then we ask the stopwatch about the duration between start and stop. Duration should be a
                value in TimeSpan. Display the duration on the console.
                We should also be able to use a stopwatch multiple times. So we may start and stop it and then
                start and stop it again. Make sure the duration value each time is calculated properly.
                We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
                start time). So the class should throw an InvalidOperationException if its started twice. 

                Educational tip: The aim of this exercise is to make you understand that a class should be
                always in a valid state. We use encapsulation and information hiding to achieve that. The class
                should not reveal its implementation detail. It only reveals a little bit, like a blackbox. From the
                outside, you should not be able to misuse a class because you shouldn’t be able to see the
                implementation detail
             */
            var time = new Stopwatch();
            while (true)
            {
                Console.Write("Enter \"Start\" to start the time, or enter any other key to stop. ");
                var input = Console.ReadLine();
                if (input.ToLower() == "start")
                {
                    time.StartTime();
                    Console.Write("Time has started. Enter \"Stop\" to stop the time whenever you're ready. ");
                }
                else 
                {
                    break;
                }
                
                var input2 = Console.ReadLine();
                if (input2.ToLower() == "stop")
                {
                    time.StopTime();
                    Console.WriteLine("First time: " + time.Duration);
                    continue;
                }
            }



            //time.StartTime();
            //time.StartTime();
            //time.StopTime();
            //Console.WriteLine("Second time: " + time.Duration);
            //var time = new DateTime();

            //time.AddMilliseconds(DateTime.Now.Millisecond);
            //Console.WriteLine(time.AddMinutes(DateTime.Now.Minute));

            /*
                Exercise 2: Design a StackOverflow Post
                Design a class called Post. This class models a StackOverflow post. It should have properties
                for title, description and the date/time it was created. We should be able to up-vote or down-vote
                a post. We should also be able to see the current vote value. In the main method, create a post,
                up-vote and down-vote it a few times and then display the the current vote value.
                In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
                and down-voting. You should not give the ability to set the Vote property from the outside,
                because otherwise, you may accidentally change the votes of a class to 0 or to a random
                number. And this is how we create bugs in our programs. The class should always protect its
                state and hide its implementation detail.
                Educational tip: The aim of this exercise is to help you understand that classes should
                encapsulate data AND behaviour around that data. Many developers (even those with years of
                experience) tend to create classes that are purely data containers, and other classes that are
                purely behaviour (methods) providers. This is not object-oriented programming. This is
                procedural programming. Such programs are very fragile. Making a change breaks many parts
                of the code.
             */
            //var post = new Post("ABC Issue", "ABC description of my issue");
            //Console.WriteLine("Created date: " + post.GetDateCreated());
            //post.DownVote();
            //post.DownVote();
            //post.UpVote();
            //post.UpVote();
            //post.UpVote();
            //Console.WriteLine("vote status: " + post.VoteStatus);
            //Console.WriteLine("title: " + post.Title);
            //Console.WriteLine("description: " + post.Description);
            //post.Description = "ABC description update";
            //Console.WriteLine("updated description: " + post.Description);
        }
    }
}
