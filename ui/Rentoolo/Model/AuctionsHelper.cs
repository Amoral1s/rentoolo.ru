﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Rentoolo.Model
{
    public static class AuctionsHelper
    {

        public static List<AuctionsForPage> GetAuctions(Guid userId)
        {
            using (var ctx = new RentooloEntities())
            {
                var result = ctx.Auctions.Where(x=>x.UserId==userId).ToList();

                List<AuctionsForPage> list = new List<AuctionsForPage>();

                foreach (var item in result)
                {
                    list.Add(new AuctionsForPage
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Created = item.Created,
                        StartPrice = item.StartPrice
                    });
                }

                return list;
            }
        }
    }
}
