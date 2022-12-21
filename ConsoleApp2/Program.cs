// See https://aka.ms/new-console-template for more information

using DummyLibrary.Classes;

var service = new ApiExploderServiceAuthService(userName: "diegow", shardId: 1);
await service.ExplodeMoonAsync();