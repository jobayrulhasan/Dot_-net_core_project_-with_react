﻿using Core_pro_with_react.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace Core_pro_with_react.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel { Id = 1, Title = "The GodFather", ImageId = 1, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 2, Title = "Highlander", ImageId = 2, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 3, Title = "Highlander II", ImageId = 3, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 4, Title = "The last of the Mohicans", ImageId = 4, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 5, Title = "Police academy 6", ImageId = 5, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 6, Title = "Rear window", ImageId = 6, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 7, Title = "Road House", ImageId = 7, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 8, Title = "The Shawshank Redemption", ImageId = 8, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 9, Title = "Star Treck IV", ImageId = 9, Ranking = 0, TtemType = 1},
            new ItemModel { Id = 10, Title = "Superman 4", ImageId = 10, Ranking = 0, TtemType = 1},
        };

        [HttpGet("{itemType:int}")] //specify the item type
        public ItemModel[] Get(int itemType) //depending on parameter we can get data here
        {
            ItemModel[] items = Items.Where(i => i.TtemType == itemType).ToArray();
            System.Threading.Thread.Sleep(200); //This is using to show the user loading time during faching data
            return items;
        }
    }
}
