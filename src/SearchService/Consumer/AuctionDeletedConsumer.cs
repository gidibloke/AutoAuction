using AutoMapper;
using Contracts;
using MassTransit;
using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.Consumer;
public class AuctionDeletedConsumer : IConsumer<AuctionDeleted>
{

    public async Task Consume(ConsumeContext<AuctionDeleted> context)
    {
        Console.WriteLine("Consuming auction deleted: " + context.Message.Id);
        await DB.DeleteAsync<Item>(context.Message.Id);

    }
}