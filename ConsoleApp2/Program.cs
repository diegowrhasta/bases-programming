// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;
using DummyLibrary.Interface;

ILead lead = new TeamLead();

lead.AssignTask();
lead.CreateSubTask();
lead.WorkOnTask();