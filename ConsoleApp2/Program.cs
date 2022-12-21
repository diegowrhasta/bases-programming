// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var service = new ApiExploderService(userName: "diegow", shardId: 1);
await service.ExplodeMoonAsync();