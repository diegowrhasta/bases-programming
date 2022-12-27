// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var lead = new TeamLead();

lead.AssignTask();
lead.CreateSubTask();
lead.WorkOnTask();

var manager = new Manager();

manager.AssignTask();
manager.CreateSubTask();

var programmer = new Programmer();
programmer.WorkOnTask();