// See https://aka.ms/new-console-template for more information
using FluentScheduler;
using FluentScheduler.App.Scheduler;

Console.WriteLine("Hello, World!");

var fsRegistery = new FluentSchedulerRegistery();
JobManager.Initialize(fsRegistery);

Console.WriteLine("Press enterto terminate");
Console.ReadLine();
JobManager.StopAndBlock();